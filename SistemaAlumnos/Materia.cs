using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAlumnos
{
    public class Materia : IExportable
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public int CantidadHoras { get; private set; }

        public Materia(string codigo, string nombre, int cantidadHoras)
        {
            Codigo = codigo;
            Nombre = nombre;
            CantidadHoras = cantidadHoras;
        }

        public string ExportarLinea()
        {
            return $"MATERIA;{Codigo};{Nombre};{CantidadHoras}";
        }
    }
}
