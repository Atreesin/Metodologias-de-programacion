using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class PorLegajo : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            return (((Alumno)alumno1).getLegajo()).sosIgual(((Alumno)alumno2).getLegajo());
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            return (((Alumno)alumno1).getLegajo()).sosMenor(((Alumno)alumno2).getLegajo());
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            return (((Alumno)alumno1).getLegajo()).sosMayor(((Alumno)alumno2).getLegajo());
        }
        public override string ToString()
        {
            return "Legajo";
        }
    }
}
