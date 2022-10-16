using System.ComponentModel.DataAnnotations;

namespace MarketUtilities_V2.Models
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string nombre { get; set; }
        [Display(Name = "Modificado Por:")]
        [Required]
        public int modified_by { get; set; }
        [Display(Name = "Creado Por: ")]
        [Required]
        public int created_by { get; set; }
        [Display(Name = "Fecha de Modifcacion")]
        [Required]
        public DateTime moified_date { get; set; }
        [Display(Name = "Pasillo: ")]
        [Required]
        public string pasilloID { get; set; }
    }
}
