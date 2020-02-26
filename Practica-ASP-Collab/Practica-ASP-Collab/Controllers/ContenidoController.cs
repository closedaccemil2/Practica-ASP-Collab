using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_ASP_Collab.Controllers
{
    public class ContenidoController : Controller
    {
        // GET: Contenido
        public ActionResult Peliculas()
        {
            return View();
        }
        public ActionResult Noticias()
        {
            return View();
        }
        public ActionResult Musica()
        {
            return View();
        }

    }
}