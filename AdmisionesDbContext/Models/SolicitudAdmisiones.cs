using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class SolicitudAdmisiones
    {
        public int IdSolicitud { get; set; }
        public string Apellido { get; set; }
        public string Aula { get; set; }
        public string CentroProcedencia { get; set; }
        public string Curso { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string EstadoSolicitud { get; set; }
        public string FechaNacimiento { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string LugarNacimiento { get; set; }
        public string Nivel { get; set; }
        public string Nombre { get; set; }
        public string NombreMadre { get; set; }
        public string NombrePadre { get; set; }
        public string PeriodoEscolar { get; set; }
        public string Tanda { get; set; }
        public string Telefono { get; set; }
        public string TelefonoPadres { get; set; }
        public string UrlActaNacimiento { get; set; }
        public string UrlCertificadoMedico { get; set; }
        public string UrlFoto { get; set; }
        public string UrlRecordNotas { get; set; }
        public string Usuario { get; set; }
        public string Sexo { get; set; }
        public int IdUsuario { get; set; }
    }
}
