using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class Pagos
    {
        public int IdPago { get; set; }
        public int Cantidad { get; set; }
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public string Recibe { get; set; }
        public int Total { get; set; }
        public string Usuario { get; set; }
    }
}
