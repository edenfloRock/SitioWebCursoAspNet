using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HolaMundoMVC.Controllers
{
    public class CursoController: Controller
    {
        
        [Route ("Curso/Index/") ]
        [Route ("Curso/Index/{id}") ]
        [Route ("Curso/{id}") ]
        [Route ("Curso/") ]
        
        public IActionResult Index(string id){
            //Devuelve el curso con el id especificado
            //asignaturaId es el que está en el Route

            if (!string.IsNullOrEmpty( id)){
                var curso = 
                from cur in _context.Cursos
                where cur.Id == id
                select cur;
                return View( curso.SingleOrDefault() );

            }
            else{
                return View("MultiCurso", _context.Cursos); //Devuelve la vista por default (Index.cshtml)
            }

            
        }

        public IActionResult MultiCurso(){

            //ViewBag.CosaDinamica = "La Monja";
            //ViewBag.Fecha = DateTime.Now;


            return View("MultiCurso", _context.Cursos); //Devuelve la vista por default (Index.cshtml)
        }

        public IActionResult Create(){
            ViewBag.Fecha = DateTime.Now;

            return View(); //Devuelve la vista por default (Index.cshtml)
        }

        [HttpPost]
        public IActionResult Create(Curso curso){
            ViewBag.Fecha = DateTime.Now;

            if (ModelState.IsValid){
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.EscuelaId = escuela.Id;

                _context.Cursos.Add(curso);
                _context.SaveChanges();

                ViewBag.MensajeOK = "Curso creado";
                
                return View("Index", curso); //Devuelve la vista por default (Index.cshtml)

            }
            else{
                return View(curso); //Devuelve la vista por default (Index.cshtml)
            }

            
            
        }

        

        private EscuelaContext _context;
        public CursoController(EscuelaContext context){
            _context = context;
        }
    }
}