using System;
using System.Collections.Generic;

namespace MarketUtilities.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int ModifiedBy { get; set; }
        public int CreatedBy { get; set; }
        public byte[] ModifiedDate { get; set; } = null!;
        public int PasilloId { get; set; }

        public virtual Pasillo Pasillo { get; set; } = null!;
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
