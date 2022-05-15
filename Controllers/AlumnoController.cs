using Microsoft.AspNetCore.Mvc;
using HolaMundoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HolaMundoMVC.Controllers
{
    public class AlumnoController: Controller
    {
        
        //Se usa convención: Alumno//Index/{id}
        public IActionResult Index(string id){
            //Devuelve el Alumno con el id especificado
            

            if (!string.IsNullOrEmpty( id)){
                var alumno = 
                from alum in _context.Alumnos 
                where alum.Id == id
                select alum;
                return View( alumno.SingleOrDefault() );

            }
            else{
                return View("MultiAlumno", _context.Alumnos); //Devuelve la vista por default (Index.cshtml)
            }

            
        }

        public IActionResult MultiAlumno(){

            /* var listaAlumnos = new List<Alumno>(){
                new Alumno{Nombre="Adán", UniqueId= Guid.NewGuid().ToString()},
                new Alumno{Nombre="Joel", UniqueId= Guid.NewGuid().ToString()},
                new Alumno{Nombre="Gaby", UniqueId= Guid.NewGuid().ToString()},
                new Alumno{Nombre="Luz", UniqueId= Guid.NewGuid().ToString()}

            }; */
            //var listaAlumnos = GenerarAlumnosAlAzar();


            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;


            return View("MultiAlumno", _context.Alumnos); //Devuelve la vista por default (Index.cshtml)
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context){
            _context = context;
        }
    }
}