using Practica_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
{
    public class PorAntiguedad : Estrategia
    {
        public bool sosIgual(Comparable profesor1, Comparable profesor2)
        {
            if ((((Profesor)profesor1).getAntiguedad()).sosIgual(((Profesor)profesor2).getAntiguedad()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable profesor1, Comparable profesor2)
        {
            if ((((Profesor)profesor1).getAntiguedad()).sosMenor(((Profesor)profesor2).getAntiguedad()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable profesor1, Comparable profesor2)
        {
            if ((((Profesor)profesor1).getAntiguedad()).sosMayor(((Profesor)profesor2).getAntiguedad()))
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
            return "Antiguedad";
        }
    }
}
