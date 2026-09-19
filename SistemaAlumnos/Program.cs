using System;

namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Ramiro", 54321, 8.5m, 9.0m);
            Console.WriteLine(alumno1.Nombre + " - " + alumno1.Legajo);

            Alumno alumno2 = new Alumno("Obricio", 12345, 7.0m, 8.5m);
            Console.WriteLine(alumno2.Nombre + " - " + alumno2.Legajo);

            Console.WriteLine(alumno1.Promedio());
            Console.WriteLine(alumno2.Promedio());
        }
    }
}