using System.ComponentModel.DataAnnotations;

namespace MarketUtilities_V2.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string nombre { get; set; }
        [Display(Name = "Correo")]
        [Required]
        public string correo { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string password { get; set; }

    }
}
