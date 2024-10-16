

namespace Practica_5.Classes
{
    internal class ConLegajo : AlumnoDecorator
    {
        public ConLegajo(IAlumno alumno)
        {
            this.adicional = alumno;
        }

        public override string mostrarCalificacion()
        {
            string res = base.mostrarCalificacion();
            string legajo = $"({getLegajo().ToString().Insert(getLegajo().ToString().Length -1, "/")})";

            if (res.Contains("**"))
            {
                res = $"{new string('*', legajo.Length + 1)}{res}{new string('*', legajo.Length + 1)}";
            }
            res = Utils.InsertarCadena(res, getNombre(), " " + legajo);

            return res;
        }
    }
}
