using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string IdUsuario { get; set; }
        public int IdOrdenCompra { get; set; }
        public int IdOrdenVenta { get; set; }
        public int IdPedido { get; set; }
        public int? IdProducto { get; set; }

        public virtual OrdenDeCompra IdOrdenCompraNavigation { get; set; }
        public virtual OrdenDeVenta IdOrdenVentaNavigation { get; set; }
        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
