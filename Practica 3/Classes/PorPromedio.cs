using Practica_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
{
    public class PorPromedio : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            if (( ((Alumno)alumno1).getPromedio() ).sosIgual( ((Alumno)alumno2).getPromedio() ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            if ((((Alumno)alumno1).getPromedio()).sosMenor(((Alumno)alumno2).getPromedio()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            if ((((Alumno)alumno1).getPromedio()).sosMayor(((Alumno)alumno2).getPromedio()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "promedio";
        }
    }
}
