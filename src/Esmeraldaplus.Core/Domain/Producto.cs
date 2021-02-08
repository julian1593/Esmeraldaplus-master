using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class Producto
    {
        public Producto()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdProducto { get; set; }
        public int? CantidaadProducto { get; set; }
        public int? IdTipoProducto { get; set; }
        public string Descripcion { get; set; }
        public int? PrecioProducto { get; set; }

        public virtual TipoDeProducto IdTipoProductoNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
