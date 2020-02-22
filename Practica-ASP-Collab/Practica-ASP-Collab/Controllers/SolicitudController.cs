﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_ASP_Collab.Models;

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
        public ActionResult Formulario(Persona per)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Resultados",per);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Resultados(Persona per)
        {
            return View(per);
        }
    }
}