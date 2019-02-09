using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class Evaluaciones
    {
        public int IdEvaluacion { get; set; }
        public string Estado { get; set; }
        public DateTime? Fecha { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEvaluacion { get; set; }
    }
}
