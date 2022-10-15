using System;
using System.Collections.Generic;

namespace MarketUtilities.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string User1 { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
