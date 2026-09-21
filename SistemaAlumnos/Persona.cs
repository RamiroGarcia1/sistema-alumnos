using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAlumnos
{
    public class Persona
    {
        public string Nombre { get; private set; }
        public int Documento { get; private set; }

        public Persona(string nombre, int documento)
        {
            Nombre = nombre;
            Documento = documento;
        }


        public virtual string Presentarse()
        {
            return $"Hola, soy {Nombre}";
        }
    }
}
