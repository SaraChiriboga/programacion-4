using S1_P4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S1_P4.Controllers
{
    public class ProductoController:Controller
    {
        public ActionResult Index()
        {
            var productos = new List<Producto>
            {
                new Producto {Id = 1, Nombre = "Laptop", Precio = 1200},
                new Producto {Id = 2, Nombre = "Celular", Precio = 1100},
            };
            return View(productos);
        }
    }
}