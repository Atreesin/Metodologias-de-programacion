using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes.Decorator
{
    public class ConNumeroDeOrden : AlumnoDecorator
    {
        private static int actual = 0;
        string orden;
        public ConNumeroDeOrden(IAlumno alumno)
        {
            this.adicional = alumno;
            actual++;
            orden = $"{actual})";
        }

        public override string mostrarCalificacion()
        {
            //actual++
            //string orden = $"{actual})";
            string res = base.mostrarCalificacion();
            if (res.Contains("**"))
            {
                res = $"{new string('*', orden.Length + 1)}{res}{new string('*', orden.Length + 1)}";
                res = Utils.InsertarCadena(res, "*    ", orden + " ");
            }
            else
            {
                res = $"{orden} {res}";
            }
            
            return res;
        }
    }
}
