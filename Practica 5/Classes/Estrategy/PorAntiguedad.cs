using Practica_5.Interfaces;


namespace Practica_5.Classes
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
