using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAlumnos
{
    public class Preceptor : Persona
    {
        public Preceptor(string nombre, int documento) : base(nombre, documento)
        {
        }
        public override string Presentarse()
        {
            return $"Hola soy {Nombre}, preceptor del curso";
        }
    }
}
