using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_ASP_Collab.Models;
using System.IO;

namespace Practica_ASP_Collab.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        public ActionResult Formulario()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Resultados(Persona per, HttpPostedFileBase imagen, HttpPostedFileBase pdf)
        {

            if (ModelState.IsValid)
            {
                string nombreFoto = imagen.FileName;
                string nombrePdf = pdf.FileName;

                pdf.SaveAs(Server.MapPath("/PDF/" + nombrePdf));
                imagen.SaveAs(Server.MapPath("/Fotos/" + nombreFoto));

                ViewBag.pdf = nombrePdf;
                ViewBag.foto = nombreFoto;
                return View(per);
            }
            else
            {
                return View("Formulario");
            }

        }
    }
}