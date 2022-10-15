using System;
using System.Collections.Generic;

namespace MarketUtilities.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public string Sku { get; set; } = null!;
        public string Codigobarras { get; set; } = null!;
        public int CategoriaId { get; set; }

        public virtual Categorium Categoria { get; set; } = null!;
    }
}
