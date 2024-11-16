using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace formularios
{
    public partial class formulariodatos : Form
    {
        private Stack<EstructuraDatosUsuario> pila = new Stack<EstructuraDatosUsuario>();
        private Queue<EstructuraDatosUsuario> cola = new Queue<EstructuraDatosUsuario>();
        private List<EstructuraDatosUsuario> lista = new List<EstructuraDatosUsuario>();
        private void ConfigurarDataGridView(DataGridView dgv)
        {
            dgv.Columns.Add("TipoIdentificacion", "Tipo Identificación");
            dgv.Columns.Add("NumeroIdentificacion", "Número Identificación");
            dgv.Columns.Add("NombreCompleto", "Nombre Completo");
            dgv.Columns.Add("Edad", "Edad");
            dgv.Columns.Add("Estrato", "Estrato");
            dgv.Columns.Add("TipoAtencion", "Tipo de Atención");
            dgv.Columns.Add("FechaRegistro", "Fecha Registro");
            dgv.Columns.Add("ValorCopago", "Valor Copago");
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView(dataGridViewPila);
            ConfigurarDataGridView(dataGridViewCola);
            ConfigurarDataGridView(dataGridViewLista);
        }



        public formulariodatos()
        {
            InitializeComponent();
            ConfigurarDataGrids();



            cbmEstructura.Items.Add("Pila");
            cbmEstructura.Items.Add("Cola");
            cbmEstructura.Items.Add("Lista");
            cbmEstructura.SelectedIndex = 0; // Selecciona Pila por defecto


        }

        private void inicioSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es la tecla de retroceso
            {
                e.Handled = true; // Bloquear la tecla no permitida
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir todos los caracteres, incluidos los espacios
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ')
            {
                // El caracter es permitido, nada que hacer
            }
            else
            {
                // Si el caracter no es válido, lo cancelamos
                e.Handled = true;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es la tecla de retroceso
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            // Validar que todos los campos estén llenos
            if (cmbTipoIdentificacion.SelectedItem == null ||
                string.IsNullOrEmpty(txtNumeroIdentificacion.Text) ||
                string.IsNullOrEmpty(txtNombreCompleto.Text) ||
                string.IsNullOrEmpty(txtEdad.Text) ||
                cmbEstrato.SelectedItem == null ||
                (!rbtnMedicinaGeneral.Checked && !rbtnExamenLaboratorio.Checked))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Validar que el número de identificación solo contenga números
            if (!int.TryParse(txtNumeroIdentificacion.Text, out _))
            {
                MessageBox.Show("El número de identificación debe ser solo numérico.");
                return;
            }

            // Validar que el nombre completo solo contenga letras
            if (!txtNombreCompleto.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre completo debe contener solo letras.");
                return;
            }

            // Validar que la edad solo contenga números
            if (!int.TryParse(txtEdad.Text, out _))
            {
                MessageBox.Show("La edad debe ser solo numérica.");
                return;
            }

            EstructuraDatosUsuario usuario = new EstructuraDatosUsuario
            {
                TipoIdentificacion = cmbTipoIdentificacion.SelectedItem.ToString(),
                NumeroIdentificacion = txtNumeroIdentificacion.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Edad = int.Parse(txtEdad.Text),
                Estrato = int.Parse(cmbEstrato.SelectedItem.ToString()),
                TipoAtencion = rbtnMedicinaGeneral.Checked ? "Medicina General" : "Examen Laboratorio",
                FechaRegistro = dtpFechaRegistro.Value,

            };
            RegistrarDatos(usuario);


            // Calcular el valor del copago basado en las condiciones definidas
            if (rbtnMedicinaGeneral.Checked)
            {
                // Calcular el copago para medicina general
                switch (usuario.Estrato)
                {
                    case 1:
                    case 2:
                        usuario.ValorCopago = 0;
                        break;
                    case 3:
                        usuario.ValorCopago = 10000;
                        break;
                    case 4:
                        usuario.ValorCopago = 15000;
                        break;
                    case 5:
                        usuario.ValorCopago = 20000;
                        break;
                    case 6:
                        usuario.ValorCopago = 30000;
                        break;
                }
            }
            else if (rbtnExamenLaboratorio.Checked)
            {
                // Calcular el copago para examen de laboratorio
                switch (usuario.Estrato)
                {
                    case 1:
                    case 2:
                    case 3:
                        usuario.ValorCopago = 0;
                        break;
                    case 4:
                        usuario.ValorCopago = 5000;
                        break;
                    case 5:
                        usuario.ValorCopago = 10000;
                        break;
                    case 6:
                        usuario.ValorCopago = 20000;
                        break;
                }
            }

            // Mostrar el valor del copago en el campo correspondiente
            txtValorCopago.Text = usuario.ValorCopago.ToString("C");

            // Registrar los datos en la estructura seleccionada (Pila, Cola, Lista)
            RegistrarDatos(usuario);
        }
        private void ActualizarDataGridViewPila()
        {
            dataGridViewPila.Rows.Clear();
            foreach (var usuario in pila)
            {
                dataGridViewPila.Rows.Add(usuario.TipoIdentificacion, usuario.NumeroIdentificacion, usuario.NombreCompleto,
                    usuario.Edad, usuario.Estrato, usuario.TipoAtencion, usuario.FechaRegistro.ToShortDateString(),
                    usuario.ValorCopago.ToString("C"));
            }
        }

        private void ActualizarDataGridViewCola()
        {
            dataGridViewCola.Rows.Clear();
            foreach (var usuario in cola)
            {
                dataGridViewCola.Rows.Add(usuario.TipoIdentificacion, usuario.NumeroIdentificacion, usuario.NombreCompleto,
                    usuario.Edad, usuario.Estrato, usuario.TipoAtencion, usuario.FechaRegistro.ToShortDateString(),
                    usuario.ValorCopago.ToString("C"));
            }
        }

        private void ActualizarDataGridViewLista()
        {
            dataGridViewLista.Rows.Clear();
            foreach (var usuario in lista)
            {
                dataGridViewLista.Rows.Add(usuario.TipoIdentificacion, usuario.NumeroIdentificacion, usuario.NombreCompleto,
                    usuario.Edad, usuario.Estrato, usuario.TipoAtencion, usuario.FechaRegistro.ToShortDateString(),
                    usuario.ValorCopago.ToString("C"));
            }
        }


        // Método para registrar los datos en la estructura seleccionada (Pila, Cola, Lista)

        private void RegistrarDatos(EstructuraDatosUsuario usuario)
        {
            // Lógica para registrar los datos en la estructura seleccionada
            if (cbmEstructura.SelectedItem.ToString() == "Pila")
            {
                // Apilar el usuario
                pila.Push(usuario);
                // Actualizar el DataGridView de la pila
                ActualizarDataGridViewPila();
            }
            else if (cbmEstructura.SelectedItem.ToString() == "Cola")
            {
                // Encolar el usuario
                cola.Enqueue(usuario);
                // Actualizar el DataGridView de la cola
                ActualizarDataGridViewCola();
            }
            else if (cbmEstructura.SelectedItem.ToString() == "Lista")
            {
                // Agregar el usuario a la lista
                lista.Add(usuario);
                // Actualizar el DataGridView de la lista
                ActualizarDataGridViewLista();
            }
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            cmbTipoIdentificacion.SelectedIndex = -1;
            txtNumeroIdentificacion.Clear();
            txtNombreCompleto.Clear();
            txtEdad.Clear();
            cmbEstrato.SelectedIndex = -1;
            rbtnMedicinaGeneral.Checked = false;
            rbtnExamenLaboratorio.Checked = false;
            txtValorCopago.Clear();
            dtpFechaRegistro.Value = DateTime.Now; // Poner la fecha actual
                                                   // Limpiar todos los TextBox
            txtNumeroIdentificacion.Clear();
            txtNombreCompleto.Clear();
            txtEdad.Clear();

            // Limpiar todos los ComboBox
            cmbTipoIdentificacion.SelectedIndex = -1; // Limpiar el ComboBox de tipo de identificación
            cmbEstrato.SelectedIndex = -1; // Limpiar el ComboBox de estrato

            // Limpiar todos los RadioButton
            rbtnMedicinaGeneral.Checked = false; // Deseleccionar el RadioButton de Medicina General
            rbtnExamenLaboratorio.Checked = false; // Deseleccionar el RadioButton de Examen de Laboratorio

            // Limpiar el DateTimePicker
            dtpFechaRegistro.Value = DateTime.Now; // Restablecer la fecha al valor actual
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Confirmar si el usuario realmente quiere salir
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbmEstructura_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarReporte();
            // Dependiendo de la selección en el ComboBox, cambia la pestaña activa
            if (cbmEstructura.SelectedItem.ToString() == "Pila")
            {
                tabControl1.SelectedIndex = 1;  // Pestaña 2 (índice 1)
            }
            else if (cbmEstructura.SelectedItem.ToString() == "Cola")
            {
                tabControl1.SelectedIndex = 2;  // Pestaña 3 (índice 2)
            }
            else if (cbmEstructura.SelectedItem.ToString() == "Lista")
            {
                tabControl1.SelectedIndex = 3;  // Pestaña 4 (índice 3)
            }
        }

        private void cmbEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularValorCopago();
        }

        private void rbtnMedicinaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            CalcularValorCopago();
        }

        private void rbtnExamenLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            CalcularValorCopago();
        }

        private void btnCalcularCopago_Click(object sender, EventArgs e)
        {
            CalcularValorCopago();
        }
        private void CalcularValorCopago()
        {

            // Verifica que el estrato esté seleccionado y que se haya elegido el tipo de atención
            if (cmbEstrato.SelectedItem != null &&
                (rbtnMedicinaGeneral.Checked || rbtnExamenLaboratorio.Checked))
            {
                int estrato = int.Parse(cmbEstrato.SelectedItem.ToString());
                int valorCopago = 0;

                // Cálculo del copago según el tipo de atención
                if (rbtnMedicinaGeneral.Checked)
                {
                    // Copago Medicina General
                    switch (estrato)
                    {
                        case 1:
                        case 2:
                            valorCopago = 0;
                            break;
                        case 3:
                            valorCopago = 10000;
                            break;
                        case 4:
                            valorCopago = 15000;
                            break;
                        case 5:
                            valorCopago = 20000;
                            break;
                        case 6:
                            valorCopago = 30000;
                            break;
                    }
                }
                else if (rbtnExamenLaboratorio.Checked)
                {
                    // Copago Examenes de Laboratorio
                    switch (estrato)
                    {
                        case 1:
                        case 2:
                        case 3:
                            valorCopago = 0;
                            break;
                        case 4:
                            valorCopago = 5000;
                            break;
                        case 5:
                            valorCopago = 10000;
                            break;
                        case 6:
                            valorCopago = 20000;
                            break;
                    }
                }

                // Mostrar el valor del copago en el TextBox
                txtValorCopago.Text = "$" + valorCopago.ToString("N0");  // Muestra el valor con formato de número
            }
            else
            {
                // Si no se ha seleccionado todo lo necesario, limpia el valor del copago
                txtValorCopago.Clear();
            }
        }
        private void ActualizarReporte()
        {
            // Verificar qué estructura de datos está seleccionada (Pila, Cola, Lista)
            if (cbmEstructura.SelectedItem.ToString() == "Pila") // Si la estructura es Pila
            {
                // Calcular la suma de los copagos en la Pila
                decimal sumaCopagos = 0;
                foreach (DataGridViewRow row in dataGridViewPila.Rows)
                {
                    if (row.Cells["ValorCopago"].Value != null)
                    {
                        sumaCopagos += Convert.ToDecimal(row.Cells["ValorCopago"].Value);
                    }
                }
                textBoxReporte.Text = "Suma de Copagos en la Pila: $" + sumaCopagos.ToString("F2");
            }
            else if (cbmEstructura.SelectedItem.ToString() == "Cola") // Si la estructura es Cola
            {
                // Calcular la cantidad de registros en la Cola
                int cantidadRegistros = dataGridViewCola.Rows.Count;
                textBoxReporte.Text = "Cantidad de Registros en la Cola: " + cantidadRegistros.ToString();
            }
            else if (cbmEstructura.SelectedItem.ToString() == "Lista") // Si la estructura es Lista
            {
                // Calcular el promedio de las edades en la Lista
                decimal sumaEdades = 0;
                int cantidadRegistros = 0;
                foreach (DataGridViewRow row in dataGridViewLista.Rows)
                {
                    if (row.Cells["Edad"].Value != null)
                    {
                        sumaEdades += Convert.ToDecimal(row.Cells["Edad"].Value);
                        cantidadRegistros++;
                    }
                }
                decimal promedio = cantidadRegistros > 0 ? sumaEdades / cantidadRegistros : 0;
                textBoxReporte.Text = "Promedio de Edades en la Lista: " + promedio.ToString("F2");
            }
            else
            {
                textBoxReporte.Text = "Por favor, seleccione una estructura de datos.";
            }
        }

        // Evento Click para el botón de "Reporte" en la Pila
        private void btnReportePila_Click(object sender, EventArgs e)
        {
            MostrarReportePila();
            if (pila.Count == 0)
            {
                MessageBox.Show("No hay datos en la Pila.");
                return;
            }

            // Crear un reporte de los datos en la pila
            string reporte = "Reporte de la Pila:\n\n";
            foreach (var usuario in pila )
            {
                reporte += $"ID: {usuario.NumeroIdentificacion}, Nombre: {usuario.NombreCompleto}, Edad: {usuario.Edad}, Estrato: {usuario.Estrato}, Tipo de Atención: {usuario.TipoAtencion}, Fecha de Registro: {usuario.FechaRegistro.ToShortDateString()}\n";
            }

            // Mostrar el reporte
            MessageBox.Show(reporte, "Reporte de la Pila");
        }

        // Evento Click para el botón de "Reporte" en la Cola
        private void btnReporteCola_Click(object sender, EventArgs e)
        {
            MostrarReporteCola();
            if (cola.Count == 0)
            {
                MessageBox.Show("No hay datos en la Cola.");
                return;
            }

            // Crear un reporte de los datos en la cola
            string reporte = "Reporte de la Cola:\n\n";
            foreach (var usuario in cola)
            {
                reporte += $"ID: {usuario.NumeroIdentificacion}, Nombre: {usuario.NombreCompleto}, Edad: {usuario.Edad}, Estrato: {usuario.Estrato}, Tipo de Atención: {usuario.TipoAtencion}, Fecha de Registro: {usuario.FechaRegistro.ToShortDateString()}\n";
            }

            // Mostrar el reporte
            MessageBox.Show(reporte, "Reporte de la Cola");
        }

        // Evento Click para el botón de "Reporte" en la Lista
        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            MostrarReporteLista();
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay datos en la Lista.");
                return;
            }

            // Crear un reporte de los datos en la lista
            string reporte = "Reporte de la Lista:\n\n";
            foreach (var usuario in lista)
            {
                reporte += $"ID: {usuario.NumeroIdentificacion}, Nombre: {usuario.NombreCompleto}, Edad: {usuario.Edad}, Estrato: {usuario.Estrato}, Tipo de Atención: {usuario.TipoAtencion}, Fecha de Registro: {usuario.FechaRegistro.ToShortDateString()}\n";
            }

            // Mostrar el reporte
            MessageBox.Show(reporte, "Reporte de la Lista");
        }

        // Evento Click para el botón de "Eliminar" en la Pila
        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (pila.Count == 0)
            {
                MessageBox.Show("No hay datos en la Pila.");
                return;
            }

            // Confirmar eliminación
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar el último registro de la Pila?",
                                         "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Desapilar (eliminar el último registro de la pila)
                pila.Pop();
                // Actualizar el DataGridView de la pila
                ActualizarDataGridViewPila();
            }
        }

        // Evento Click para el botón de "Eliminar" en la Cola
        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            if (cola.Count == 0)
            {
                MessageBox.Show("No hay datos en la Cola.");
                return;
            }

            // Confirmar eliminación
            var result = MessageBox.Show("¿Estás seguro de que deseas eliminar el primer registro de la Cola?",
                                         "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Desencolar (eliminar el primer registro de la cola)
                cola.Dequeue();
                // Actualizar el DataGridView de la cola
                ActualizarDataGridViewCola();
            }
        }

        // Evento Click para el botón de "Eliminar" en la Lista
        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay datos en la Lista.");
                return;
            }

            // Solicitar el número de identificación para eliminar
            string numeroIdentificacion = txtNumeroIdentificacion.Text.Trim();
            if (string.IsNullOrEmpty(numeroIdentificacion))
            {
                MessageBox.Show("Por favor, ingresa un número de identificación.");
                return;
            }

            // Buscar el usuario en la lista por número de identificación
            var usuarioAEliminar = lista.FirstOrDefault(u => u.NumeroIdentificacion == numeroIdentificacion);

            if (usuarioAEliminar != null)
            {
                // Confirmar eliminación
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario de la Lista?",
                                             "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Eliminar el usuario de la lista
                    lista.Remove(usuarioAEliminar);
                    // Actualizar el DataGridView de la lista
                    ActualizarDataGridViewLista();
                }
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con ese número de identificación.");
            }
        }

        private void textBoxReporte_TextChanged(object sender, EventArgs e)
        {

        }
        private void ConfigurarDataGrids()
        {
            // Configuración del DataGridView para la pila
            dataGridViewPila.Columns.Add("TipoIdentificacion", "Tipo Identificación");
            dataGridViewPila.Columns.Add("NumeroIdentificacion", "Número Identificación");
            dataGridViewPila.Columns.Add("NombreCompleto", "Nombre Completo");
            dataGridViewPila.Columns.Add("Edad", "Edad");
            dataGridViewPila.Columns.Add("Estrato", "Estrato");
            dataGridViewPila.Columns.Add("TipoAtencion", "Tipo Atención");
            dataGridViewPila.Columns.Add("FechaRegistro", "Fecha Registro");
            dataGridViewPila.Columns.Add("ValorCopago", "Valor Copago");

            // Configuración del DataGridView para la cola
            dataGridViewCola.Columns.Add("TipoIdentificacion", "Tipo Identificación");
            dataGridViewCola.Columns.Add("NumeroIdentificacion", "Número Identificación");
            dataGridViewCola.Columns.Add("NombreCompleto", "Nombre Completo");
            dataGridViewCola.Columns.Add("Edad", "Edad");
            dataGridViewCola.Columns.Add("Estrato", "Estrato");
            dataGridViewCola.Columns.Add("TipoAtencion", "Tipo Atención");
            dataGridViewCola.Columns.Add("FechaRegistro", "Fecha Registro");
            dataGridViewCola.Columns.Add("ValorCopago", "Valor Copago");

            // Configuración del DataGridView para la lista
            dataGridViewLista.Columns.Add("TipoIdentificacion", "Tipo Identificación");
            dataGridViewLista.Columns.Add("NumeroIdentificacion", "Número Identificación");
            dataGridViewLista.Columns.Add("NombreCompleto", "Nombre Completo");
            dataGridViewLista.Columns.Add("Edad", "Edad");
            dataGridViewLista.Columns.Add("Estrato", "Estrato");
            dataGridViewLista.Columns.Add("TipoAtencion", "Tipo Atención");
            dataGridViewLista.Columns.Add("FechaRegistro", "Fecha Registro");
            dataGridViewLista.Columns.Add("ValorCopago", "Valor Copago");
        }

        private void MostrarReportePila()
        {
            decimal sumaCopagos = 0;
            foreach (var usuario in pila)
            {
                sumaCopagos += usuario.ValorCopago;
            }
            textBoxReporte.Text = $"Suma de Copagos en la Pila: ${sumaCopagos:0.00}";
        }

        private void MostrarReporteCola()
        {
            decimal sumaCopagos = 0;
            foreach (var usuario in cola)
            {
                sumaCopagos += usuario.ValorCopago;
            }
            textBoxReporte.Text = $"Suma de Copagos en la Cola: ${sumaCopagos:0.00}";
        }

        private void MostrarReporteLista()
        {
            decimal sumaCopagos = 0;
            foreach (var usuario in lista)
            {
                sumaCopagos += usuario.ValorCopago;
            }
            textBoxReporte.Text = $"Suma de Copagos en la Lista: ${sumaCopagos:0.00}";
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

