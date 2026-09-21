using System;

namespace SistemaAlumnos
{
    public class Alumno : Persona
    {
     
        public decimal Nota1 { get; private set; }
        public decimal Nota2 { get; private set; }

        public Alumno(string nombre, int documento) : base(nombre, documento)
        {

        }

        public decimal Promedio()
        {
            return (Nota1 + Nota2) / 2;
        }

        public bool EstaAprobado()
        {
            return Promedio() >= 6;
        }

        public void SubirNota()
        {
            if (Nota1 + 1 <= 10)
            {
                Nota1 += 1;
            }
            if (Nota2 + 1 <= 10)
            {
                Nota2 += 1;
            }
        }
        public override string ToString()
        {
            return $"{Documento} - {Nombre} (promedio: {Promedio()})";
        }
        public bool CargarNotas(decimal nota1, decimal nota2)
        {
            if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
            {
                Nota1 = nota1;
                Nota2 = nota2;
                return true;
            }
            return false;
        }

    }
}

