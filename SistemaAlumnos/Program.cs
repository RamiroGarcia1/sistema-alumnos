using System;
using System.Collections.Generic;

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

            Console.WriteLine(alumno1);

            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);

            if (!alumno1.CargarNotas(8.5m, 9.0m))
            {
                Console.WriteLine("Notas invalidas");
            }

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Listar alumnos");
                Console.WriteLine("3. Buscar por legajo");
                Console.WriteLine("4. Promedio general");
                Console.WriteLine("5. Cantidad de aprobados");
                Console.WriteLine("6. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":               
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
    }
}
