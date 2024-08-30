using Practica_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Classes
{
    public class PorNombre : Estrategia
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            if (((Alumno)a).getNombre() == ((Alumno)b).getNombre())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable a, Comparable b)
        {
            if (string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable a, Comparable b)
        {
            if (string.Compare( ((Alumno)a).getNombre() , ((Alumno)b).getNombre()) < 0)
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
            return "nombre";
        }
    }
}
