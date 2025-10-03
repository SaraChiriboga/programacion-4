using Microsoft.AspNetCore.Mvc;
using S2_P4.Models;

namespace S2_P4.Controllers
{
    public class VideojuegoController : Controller
    {
        private static List<Videojuego> videojuego = new List<Videojuego>
        {
            new Videojuego{Id = 1, Titulo = "FIFA 26", Plataforma = "PS5", Clasificacion = "A"},
            new Videojuego{Id = 2, Titulo = "MK1", Plataforma = "PS5", Clasificacion = "R"},
            new Videojuego{Id = 3, Titulo = "Call of Duty WW2", Plataforma = "PS5", Clasificacion = "R"},
            new Videojuego{Id = 4, Titulo = "Valorant", Plataforma = "PC", Clasificacion = "R"},
            new Videojuego{Id = 5, Titulo = "Minecraft", Plataforma = "XBOX", Clasificacion = "R"},
            new Videojuego{Id = 6, Titulo = "Outlast", Plataforma = "PS4", Clasificacion = "R"},
        };
        public IActionResult Index()
        {
            return View(videojuego);
        }
    }
}
