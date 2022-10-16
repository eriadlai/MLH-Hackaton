using MarketUtilities_V2.Data;
using MarketUtilities_V2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarketUtilities_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

      
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewModel oModelo = new ViewModel();
            oModelo.oListaCategoria = _context.Categoria;
            oModelo.oListaPasillo = _context.Pasillo;
            return View(oModelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}