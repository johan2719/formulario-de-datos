using System;

namespace formularios
{
    public class EstructuraDatosUsuario
    {
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public int Estrato { get; set; }
        public string TipoAtencion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal ValorCopago { get; set; }

        // Constructor que recibe todos los parámetros
        public EstructuraDatosUsuario(string tipoIdentificacion, string numeroIdentificacion, string nombreCompleto, int edad, int estrato, string tipoAtencion, DateTime fechaRegistro)
        {
            TipoIdentificacion = tipoIdentificacion;
            NumeroIdentificacion = numeroIdentificacion;
            NombreCompleto = nombreCompleto;
            Edad = edad;
            Estrato = estrato;
            TipoAtencion = tipoAtencion;
            FechaRegistro = fechaRegistro;
        }

        // Constructor predeterminado (opcional)
        public EstructuraDatosUsuario() { }
    }


}