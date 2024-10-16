
using System;

namespace Practica_6.Classes.Decorator
{
    public class ConAsteriscos : AlumnoDecorator
    {
        public ConAsteriscos(IAlumno alumno)
        {
            this.adicional = alumno;
        }

        public override string mostrarCalificacion()
        {
            string res = base.mostrarCalificacion();
            res = $"*    {res}";
            res += $"    *\n";
            string asteriscos = "";
            asteriscos = $"{new string('*', res.Length - 1)}";
            res = $"{asteriscos}\n{res}";
            res += $"{asteriscos}";

            return res;
        }
    }
}
