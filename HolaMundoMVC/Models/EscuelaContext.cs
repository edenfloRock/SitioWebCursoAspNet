using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
namespace HolaMundoMVC.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas{get;set;}

        public DbSet<Asignatura> Asignaturas{get;set;}

        public DbSet<Alumno> Alumnos{get;set;}

        public DbSet<Curso> Cursos{get;set;}

        public DbSet<Evaluación> Evaluaciones{get;set;}


        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Ejecuta el método base
            base.OnModelCreating(modelBuilder);


            //Crea una Escuela
            Escuela escuela = new Escuela();
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Edenflo";
            escuela.AñoDeCreación = 2011;

            escuela.Ciudad = "CDMX";
            escuela.Pais = "México";
            escuela.Dirección = "Calle Vista Hermosa, Mz 1, Lt. 20";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            

            //Creación de cursos
            var cursos = CargaCursos(escuela);

            //Para cada Asignatura cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            //Por cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos);

            //Agrega al modelo la Escuela
            modelBuilder.Entity<Escuela>().HasData(escuela);
            //Agrega al modelo los Cursos
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            //Agrega al modelo los Asignaturas
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            //Agrega al modelo los Alumnos
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());



        }

        private  List<Alumno> CargarAlumnos(List<Curso> cursos){
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();
            foreach (var curso in cursos){
                int cantRandom = rnd.Next(5, 20);
                var tmpList = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmpList);
            }
            return listaAlumnos;
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();

            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura>{
                    new Asignatura{Id = Guid.NewGuid().ToString(), Nombre = "Java", CursoId = curso.Id},
                    new Asignatura{Id = Guid.NewGuid().ToString(), Nombre = "Spark", CursoId = curso.Id},
                    new Asignatura{Id = Guid.NewGuid().ToString(), Nombre = "C#", CursoId = curso.Id},
                    new Asignatura{Id = Guid.NewGuid().ToString(), Nombre = "Data Factory", CursoId = curso.Id},
                    new Asignatura{Id = Guid.NewGuid().ToString(), Nombre = "Python", CursoId = curso.Id}

                };
                listaCompleta.AddRange(tmpList);
                //curso.Asignaturas = tmpList;

            }
            return listaCompleta;
        }

        private static List<Curso> CargaCursos(Escuela escuela)
        {
            return  ( new List<Curso>(){
                new Curso(){ Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre="Curso 101", Jornada = TiposJornada.Mañana, Dirección="Dirección siempre viva"},
                new Curso(){ Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre="Curso 102", Jornada = TiposJornada.Tarde, Dirección="Dirección siempre viva"},
                new Curso(){ Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre="Curso 103", Jornada = TiposJornada.Noche, Dirección="Dirección siempre viva"},
                new Curso(){ Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre="Curso 104", Jornada = TiposJornada.Mañana, Dirección="Dirección siempre viva"},
                new Curso(){ Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre="Curso 105", Jornada = TiposJornada.Tarde, Dirección="Dirección siempre viva"}

            });
        }


        private static List<Alumno> GenerarAlumnosAlAzar(Curso curso, int totalAlumnos)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno {CursoId = curso.Id, Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((al) => al.Id).Take(totalAlumnos).ToList();
        }

    }
}