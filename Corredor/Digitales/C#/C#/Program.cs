using System;
using EscuelaMusica;

class Program
{
    static void Main(string[] args)
    {
        Escuela escuela = new Escuela("Academia Armonía", "Calle 10 #25-36");
        Profesor profesor1 = new Profesor("Laura", "Piano", 2500.0);
        Estudiante estudiante1 = new Estudiante("Carlos", "Piano", 2);
        Director director = new Director("Andrés");
        Instrumento instrumento = new Instrumento("Piano Yamaha", "Teclado", 3200.0);

        escuela.AgregarProfesor(profesor1);
        escuela.AgregarEstudiante(estudiante1);

        escuela.MostrarInfo();
        profesor1.Enseñar();
        estudiante1.Practicar();
        director.Supervisar();
        instrumento.Mostrar();

        Console.WriteLine("\n🎶 Fin del programa.");
    }
}