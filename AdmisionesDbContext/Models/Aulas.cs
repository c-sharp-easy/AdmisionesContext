using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class Aulas
    {
        public string IdAula { get; set; }
        public int Cupo { get; set; }
        public string Curso { get; set; }
        public string IdCurso { get; set; }
        public string Nivel { get; set; }
        public string NombreAula { get; set; }
        public string Ubicacion { get; set; }
    }
}
