using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practica_ASP_Collab.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
        [Range(16,200)]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage ="Debes introducir un correo electrónico válido.")]
        public string Correo { get; set; }
        public string Genero { get; set; }        
        public Vacante Vac { get; set; }
        

    }

    public enum Vacante
    {

        Dessarrollador, Disenador, Manager, Analista    }
}