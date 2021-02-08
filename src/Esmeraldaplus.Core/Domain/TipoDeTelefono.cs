using System;
using System.Collections.Generic;

namespace Esmeraldaplus.Core.Domain
{
    public partial class TipoDeTelefono
    {
        public TipoDeTelefono()
        {
            Telefono = new HashSet<Telefono>();
        }

        public int IdTipoTelefono { get; set; }
        public string TipoDeTelefono1 { get; set; }

        public virtual ICollection<Telefono> Telefono { get; set; }
    }
}
