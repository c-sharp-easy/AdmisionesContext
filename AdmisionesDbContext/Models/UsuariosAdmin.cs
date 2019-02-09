using System;
using System.Collections.Generic;

namespace AdmisionesDbContext.Models
{
    public partial class UsuariosAdmin
    {
        public int IdUsuario { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string ReferenciaClave { get; set; }
        public string Telefono { get; set; }
        public string TipoUsuario { get; set; }
    }
}
