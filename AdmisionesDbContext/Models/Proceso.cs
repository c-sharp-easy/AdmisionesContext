using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class Proceso
    {
        public int IdPoces { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
    }
}
