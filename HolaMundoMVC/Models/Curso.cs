using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolaMundoMVC.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required( ErrorMessage ="El nombre del curso es requerido")]
        [StringLength(20)]
        public override string Nombre{get;set;}
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        [Display(Prompt ="Especifique dirección de correo", Name ="Address")]
        [MinLength(5, ErrorMessage ="La longitud mínima es de 5 caracteres")]
        [Required( ErrorMessage ="Se requiere la dirección")]
        public string Dirección { get; set; }


        // Escuela es Padre Curso
        public string EscuelaId{get;set;}

        public Escuela Escuela{get;set;}

    }
}