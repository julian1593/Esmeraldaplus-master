using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class OrdenDeVenta
    {
        public OrdenDeVenta()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int IdOrdenVenta { get; set; }
        public int? CantidadProducto { get; set; }
        public int? ValorUnitario { get; set; }
        public int? ValorTotal { get; set; }

        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
