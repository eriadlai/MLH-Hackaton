using MarketUtilities_V2.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketUtilities_V2.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        
        }
        public DbSet<Pasillo> Pasillo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
