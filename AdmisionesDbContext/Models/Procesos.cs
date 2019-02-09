using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class Procesos
    {
        public int IdProceso { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }
        public string NombreProceso { get; set; }
        public int Porcentaje { get; set; }
    }
}
