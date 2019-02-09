using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class Notificaciones
    {
        public int IdNotificacion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Fecha { get; set; }
        public int IdUsuario { get; set; }
        public string Titulo { get; set; }
    }
}
