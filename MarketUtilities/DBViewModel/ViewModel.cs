using MarketUtilities.Models;

namespace MarketUtilities.DBViewModel
{
    public class ViewModel
    {
        public IEnumerable<Categorium> oListaCategoria { get; set; }
        public IEnumerable<Pasillo> oListaPasillo { get; set; }
        public IEnumerable<Producto> oListaProducto { get; set; }
        public IEnumerable<User> oListaUsuario { get; set; }

    }
}
