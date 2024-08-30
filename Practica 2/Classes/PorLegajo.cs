using Practica_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Classes
{
    public class PorLegajo : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            if ((((Alumno)alumno1).getLegajo()).sosIgual(((Alumno)alumno2).getLegajo()))
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
            if ((((Alumno)alumno1).getLegajo()).sosMenor(((Alumno)alumno2).getLegajo()))
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
            if ((((Alumno)alumno1).getLegajo()).sosMayor(((Alumno)alumno2).getLegajo()))
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
            return "legajo";
        }
    }
}
