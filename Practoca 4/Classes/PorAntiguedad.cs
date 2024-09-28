using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class PorAntiguedad : Estrategia
    {
        public bool sosIgual(Comparable profesor1, Comparable profesor2)
        {
            return (((Profesor)profesor1).getAntiguedad()).sosIgual(((Profesor)profesor2).getAntiguedad());
        }

        public bool sosMenor(Comparable profesor1, Comparable profesor2)
        {
            return (((Profesor)profesor1).getAntiguedad()).sosMenor(((Profesor)profesor2).getAntiguedad());
        }

        public bool sosMayor(Comparable profesor1, Comparable profesor2)
        {
            return (((Profesor)profesor1).getAntiguedad()).sosMayor(((Profesor)profesor2).getAntiguedad());
        }
        public override string ToString()
        {
            return "Antiguedad";
        }
    }
}
