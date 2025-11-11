using System;
using System.Collections.Generic;

namespace EscuelaMusica
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        public Escuela(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Profesores = new List<Profesor>();
            Estudiantes = new List<Estudiante>();
        }

        public void AgregarProfesor(Profesor p)
        {
            Profesores.Add(p);
        }

        public void AgregarEstudiante(Estudiante e)
        {
            Estudiantes.Add(e);
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"🎵 Escuela: {Nombre}, Ubicación: {Direccion}");
            Console.WriteLine($"Profesores: {Profesores.Count}, Estudiantes: {Estudiantes.Count}");
        }
    }
}