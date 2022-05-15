using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HolaMundoMVC.Controllers
{
    public class AsignaturaController: Controller
    {

        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId){
            //Devuelve la asignatura con el id especificado
            //asignaturaId es el que está en el Route

            if (!string.IsNullOrEmpty( asignaturaId)){
                var asignatura = 
                from asig in _context.Asignaturas 
                where asig.Id == asignaturaId
                select asig;
                return View( asignatura.SingleOrDefault() );

            }
            else{
                return View("MultiAsignatura", _context.Asignaturas); //Devuelve la vista por default (Index.cshtml)
            }

            
        }

        public IActionResult MultiAsignatura(){
            
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;


            return View("MultiAsignatura", _context.Asignaturas); //Devuelve la vista por default (Index.cshtml)
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context){
            _context = context;
        }
    }
}