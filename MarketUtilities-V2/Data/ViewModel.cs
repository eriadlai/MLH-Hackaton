using MarketUtilities_V2.Models;

namespace MarketUtilities_V2.Data
{
    public class ViewModel
    {
        public IEnumerable<Categoria> oListaCategoria { get; set; }
        public IEnumerable<Pasillo> oListaPasillo{ get; set; }
        public IEnumerable<Producto> oListaProducto{ get; set; }
        public IEnumerable<Usuario> oListaUsuario{ get; set; }
        public Categoria Categoria { get; set; }
        public Pasillo Pasillo { get; set; }
        public Producto Producto { get; set; }
        public Usuario Usuario { get; set; }
    }
}
