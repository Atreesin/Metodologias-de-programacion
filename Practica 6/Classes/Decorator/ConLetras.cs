using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Decorator
{
    public class ConLetras : AlumnoDecorator
    {
        public ConLetras(IAlumno alumno)
        {
            this.adicional = alumno;
        }

        public override string mostrarCalificacion()
        {
            string res = base.mostrarCalificacion();
            string letras = "(CERO)"; ;
            letras = Utils.DeNumeroALetras(getCalificacion());

            if (res.Contains("**"))
            {
                res = $"{new string('*', letras.Length)}{res}{new string('*', letras.Length)}";
            }
            res = Utils.InsertarCadena(res, $" {getCalificacion().ToString()} ", letras);

            return res;
        }
    }
}
