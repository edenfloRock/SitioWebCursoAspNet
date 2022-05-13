using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
using System;
using System.Linq;

namespace HolaMundoMVC.Controllers
{
    public class EscuelaController: Controller
    {
        
        public IActionResult Index(){

            /* Escuela escuela = new Escuela();
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Edenflo";
            escuela.AñoDeCreación = 2011;

            escuela.Ciudad = "CDMX";
            escuela.Pais= "México";
            escuela.Dirección = "Calle Vista Hermosa, Mz 1, Lt. 20";
            escuela.TipoEscuela = TiposEscuela.Secundaria  ; */


            ViewBag.Bolsita = "La Monja";

            var escuela = _context.Escuelas.FirstOrDefault();

            return View(escuela); //Devuelve la vista por default (Index.cshtml)
        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context){
            _context = context;
        }
        
    }
}