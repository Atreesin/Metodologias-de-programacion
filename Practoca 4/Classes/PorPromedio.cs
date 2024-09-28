using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class PorPromedio : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            return (((Alumno)alumno1).getPromedio()).sosIgual(((Alumno)alumno2).getPromedio());
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            return (((Alumno)alumno1).getPromedio()).sosMenor(((Alumno)alumno2).getPromedio());
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            return (((Alumno)alumno1).getPromedio()).sosMayor(((Alumno)alumno2).getPromedio());
        }
        public override string ToString()
        {
            return "Promedio";
        }
    }
}
