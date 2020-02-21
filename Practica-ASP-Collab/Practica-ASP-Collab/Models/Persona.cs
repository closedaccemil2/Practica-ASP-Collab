using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_ASP_Collab.Models
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }        
        public Vacante Vac { get; set; }
        

    }

    public enum Vacante
    {

        Dessarrollador, Disenador, Manager, Analista    }
}