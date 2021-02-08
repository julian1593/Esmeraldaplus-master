using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class OrdenDeCompra
    {
        public OrdenDeCompra()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdOrdenCompra { get; set; }
        public string NombreProveedor { get; set; }
        public int? ValorUnitarioProducto { get; set; }
        public int? ValorTotalProducto { get; set; }
        public string Producto { get; set; }

        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
