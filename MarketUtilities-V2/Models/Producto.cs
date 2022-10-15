using System.ComponentModel.DataAnnotations;

namespace MarketUtilities_V2.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string nombre { get; set; }
        [Display(Name = "Precio")]
        [Required]
        public decimal precio { get; set; }
        [Display(Name = "SKU")]
        [Required]
        public string sku { get; set; }
        [Display(Name = "Codigo de Barras")]
        [Required]
        public string codigoDeBarras { get; set; }
        [Display(Name = "Pasllo: ")]
        [Required]
        public Categoria categoriaID { get; set; }
        [Display(Name = "Modificado Por:")]
        [Required]
        public int modified_by { get; set; }
        [Display(Name = "Fecha de Modifcacion")]
        [Required]
        public DateTime moified_date { get; set; }
    }
}
