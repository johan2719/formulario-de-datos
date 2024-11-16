using System;
using System.Windows.Forms;

namespace formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso: [Nombre del curso]\nEstudiante: [Tu nombre completo]\nGrupo: [Número de grupo colaborativo]", "Acerca de");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string password = "unad";
            if (txtPassword.Text == password)
            {
                // Redirige al otro formulario (Ejemplo: Formulario de Bienvenida o Principal)
                formulariodatos bienvenida = new formulariodatos();
                bienvenida.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intente de nuevo.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
