using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public JsonResult ObtenerProductos()
        {
            var listProducto = new List<Producto>();
            var produ1 = new Producto() { IdpOrducto = 1, NombrewProducto = "peras", Precio = 12 };
            var produ2 = new Producto() { IdpOrducto = 1, NombrewProducto = "manzanas", Precio = 12 };
            var produ3 = new Producto() { IdpOrducto = 1, NombrewProducto = "kiwi", Precio = 12 };

            listProducto.Add(produ1);
            listProducto.Add(produ2);
            listProducto.Add(produ3);

            return Json(listProducto, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LlamarJson()
        {
            var output = ObtenerListaUsuarios();
            return Json(output, JsonRequestBehavior.AllowGet);
        }

        private List<Usuario> ObtenerListaUsuarios()
        {
            List<Usuario> lUsuarios = new List<Usuario>(){
            new Usuario(){ IdUsuario = 2, UserName = "Juan",  PerfilId = 3 },
            new Usuario(){ IdUsuario = 2, UserName = "Jan",  PerfilId = 3 }
            
        };
            return lUsuarios;
        }
    }

    public class Producto
    {
        public int IdpOrducto { get; set; }
        public string NombrewProducto { get; set; }
        public float Precio { get; set; }
    }

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public int PerfilId { get; set; }
    }

    public class Tipop
    {
        public int Id { get; set; }
    }
}
