using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class PorNombre : Estrategia
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            return (((Alumno)a).getNombre() == ((Alumno)b).getNombre());
        }

        public bool sosMayor(Comparable a, Comparable b)
        {
            return (string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) > 0);
        }

        public bool sosMenor(Comparable a, Comparable b)
        {
            return (string.Compare(((Alumno)a).getNombre(), ((Alumno)b).getNombre()) < 0);
        }
        public override string ToString()
        {
            return "Nombre";
        }
    }
}
