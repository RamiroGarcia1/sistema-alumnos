using System;
using System.Collections.Generic;

namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Ramiro", 54321);
            alumno1.CargarNotas(8.0m, 9.0m);
            Console.WriteLine(alumno1.Nombre + " - " + alumno1.Documento);

            Alumno alumno2 = new Alumno("Obricio", 12345);
            alumno2.CargarNotas(7.0m, 6.0m);
            Console.WriteLine(alumno2.Nombre + " - " + alumno2.Documento);

            //Console.WriteLine(alumno1.Promedio());
            //Console.WriteLine(alumno2.Promedio());

            //Console.WriteLine(alumno1);

            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);

            //if (!alumno1.CargarNotas(8.5m, 9.0m))
            //{
            //    Console.WriteLine("Notas invalidas");
            //}

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Listar alumnos");
                Console.WriteLine("3. Buscar por documento");
                Console.WriteLine("4. Promedio general");
                Console.WriteLine("5. Cantidad de aprobados");
                Console.WriteLine("6. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("ingrese nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingrese legajo");
                        int legajo = Convert.ToInt32(Console.ReadLine());
                        Alumno nuevoAlumno = new Alumno(nombre, legajo);
                        Console.WriteLine("Ingrese nota 1");
                        decimal nota1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese nota 2");
                        decimal nota2 = Convert.ToDecimal(Console.ReadLine());
                        nuevoAlumno.CargarNotas(nota1, nota2);
                        alumnos.Add(nuevoAlumno);
                        break;
                    case "2":
                        foreach (Alumno alumno in alumnos)
                        {
                            Console.WriteLine(alumno);
                        }
                        break;
                    case "3":
                        bool encontrado = false;
                        Console.WriteLine("Ingrese el documento a buscar:");
                        int documentoBuscado = Convert.ToInt32(Console.ReadLine());
                        foreach (Alumno alumno in alumnos)
                        {
                            if (alumno.Documento == documentoBuscado)
                            {
                                Console.WriteLine(alumno);
                                encontrado = true;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No existe un alumno con ese documento");
                        }
                        break;
                    case "4":
                        if (alumnos.Count == 0)
                        {
                            Console.WriteLine("Todavía no hay alumnos cargados");
                        }
                        else
                        {
                            decimal sumaPromedios = 0;
                            foreach (Alumno alumno in alumnos)
                            {
                                sumaPromedios += alumno.Promedio();
                            }
                            decimal promedioGeneral = sumaPromedios/alumnos.Count;
                            Console.WriteLine($"Promedio general: {promedioGeneral}");
                        }
                        break;
                    case "5":
                        int aprobados = 0;
                        foreach (Alumno alumno in alumnos)
                        {
                            if (alumno.EstaAprobado())
                            {
                                aprobados++;
                            }
                        }
                        Console.WriteLine($"Alumnos aprobados:{aprobados}");
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
