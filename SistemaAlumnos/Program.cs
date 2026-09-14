using System;

namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno()
            {
                Nombre = "Ramiro Garcia",
                Legajo = 54321,
                Nota1 = 8.5m,
                Nota2 = 9.0m
            };

            Console.WriteLine(alumno1.Nombre + " - " + alumno1.Legajo);

            Alumno alumno2 = new Alumno()
            {
                Nombre = "Obricio",
                Legajo = 12345,
                Nota1 = 7.0m,
                Nota2 = 8.5m
            };

            Console.WriteLine(alumno2.Nombre + " - " + alumno2.Legajo);

            
        }
    }
}