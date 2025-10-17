using Microsoft.AspNetCore.Mvc;
using S2_P4.Models;

namespace S2_P4.Controllers
{
    public class JugadorController : Controller
    {
        private static List<Jugador> jugador = new List<Jugador>
        {
            new Jugador{Id = 1, Username = "ShadowWolf", Nivel = 15},
            new Jugador{Id = 2, Username = "PixelQueen", Nivel = 22},
            new Jugador{Id = 3, Username = "DragonSlayer", Nivel = 30},
            new Jugador{Id = 4, Username = "CyberNinja", Nivel = 18},
            new Jugador{Id = 5, Username = "MysticMage", Nivel = 27},
            new Jugador{Id = 6, Username = "IronFist", Nivel = 12},
            new Jugador{Id = 7, Username = "SilentArrow", Nivel = 20},
            new Jugador{Id = 8, Username = "FireStorm", Nivel = 25},
            new Jugador{Id = 9, Username = "LunaBlade", Nivel = 19},
            new Jugador{Id = 10, Username = "NeonRider", Nivel = 23},
        };
        public IActionResult Index()
        {
            return View(jugador);
        }
    }
}
