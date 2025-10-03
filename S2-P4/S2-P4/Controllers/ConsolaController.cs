using Microsoft.AspNetCore.Mvc;
using S2_P4.Models;

namespace S2_P4.Controllers
{
    public class ConsolaController : Controller
    {
        private static List<Consola> consola = new List<Consola>
        {
            new Consola{Id = 1, Name = "Xbox Series X", Ano = "2020", Precio = 499},
            new Consola{Id = 2, Name = "Nintendo Switch", Ano = "2017", Precio = 299},
            new Consola{Id = 3, Name = "PlayStation 4", Ano = "2013", Precio = 399},
            new Consola{Id = 4, Name = "Xbox One", Ano = "2013", Precio = 499},
            new Consola{Id = 5, Name = "Nintendo Wii U", Ano = "2012", Precio = 299},
            new Consola{Id = 6, Name = "PlayStation 3", Ano = "2006", Precio = 499},
            new Consola{Id = 7, Name = "Xbox 360", Ano = "2005", Precio = 399},
            new Consola{Id = 8, Name = "Nintendo GameCube", Ano = "2001", Precio = 199},
            new Consola{Id = 9, Name = "Sega Dreamcast", Ano = "1999", Precio = 299},
            new Consola{Id = 10, Name = "PlayStation 2", Ano = "2000", Precio = 299}
        };
        public IActionResult Index()
        {
            return View(consola);
        }
    }
}
