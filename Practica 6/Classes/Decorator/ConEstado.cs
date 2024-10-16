using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Decorator
{
    public class ConEstado : AlumnoDecorator
    {
        public ConEstado(IAlumno alumno)
        {
            this.adicional = alumno;
        }

        public override string mostrarCalificacion()
        {
            string res = base.mostrarCalificacion();
            
            string estado = "(DESAPROBADO)";
            if (getCalificacion() >= 7) {
                estado = "(PROMOCIÓN)";
            }
            else if (getCalificacion() <= 6 || getCalificacion() >= 4)
            {
                estado = "(APROBADO)";
            }

            if (res.Contains("**"))
            {
                res = $"{new string('*', estado.Length + 1)}{res}{new string('*', estado.Length + 1)}";
            }

            int posicion = res.IndexOf(Utils.DeNumeroALetras(getCalificacion()));
            if (posicion != -1)
            {
                res = Utils.InsertarCadena(res, Utils.DeNumeroALetras(getCalificacion()), " " + estado);
            }
            else
            {
                res = Utils.InsertarCadena(res, $"    {getCalificacion().ToString()} ", " " + estado);
            }

            return res;
        }
    }
}
