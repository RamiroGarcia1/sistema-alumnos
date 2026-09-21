using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAlumnos
{
   public class Profesor : Persona
    {
        public string Materia { get; private set; }
        public Profesor(string nombre, int documento, string materia) : base(nombre, documento)
        {
            Materia = materia;
        }   
    }
}
