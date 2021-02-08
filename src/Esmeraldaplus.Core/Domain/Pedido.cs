using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class Pedido
    {
        public Pedido()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdPedido { get; set; }
        public int? IdEstadoPedido { get; set; }
        public int? Cantidad { get; set; }
        public string IdUsuario { get; set; }

        public virtual EstadoDePedido IdEstadoPedidoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
