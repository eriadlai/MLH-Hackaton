using System;
using System.Collections.Generic;

namespace MarketUtilities.Models
{
    public partial class Pasillo
    {
        public Pasillo()
        {
            Categoria = new HashSet<Categorium>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int ModifiedBy { get; set; }
        public int CreatedBy { get; set; }
        public byte[] ModifiedDate { get; set; } = null!;

        public virtual ICollection<Categorium> Categoria { get; set; }
    }
}
