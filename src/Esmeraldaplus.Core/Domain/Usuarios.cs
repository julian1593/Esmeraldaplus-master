using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Inventario = new HashSet<Inventario>();
            Pedido = new HashSet<Pedido>();
        }

        public string IdUsuario { get; set; }
        public int IdRol { get; set; }
        public int? IdTelefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual Telefono IdTelefonoNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
