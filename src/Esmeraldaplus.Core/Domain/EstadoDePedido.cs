using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class EstadoDePedido
    {
        public EstadoDePedido()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdEstadoPedido { get; set; }
        public string NombreEstadoPedido { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
