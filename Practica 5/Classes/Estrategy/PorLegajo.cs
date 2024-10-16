using Practica_5.Interfaces;

namespace Practica_5.Classes
{
    public class PorLegajo : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getLegajo()).sosIgual(((IAlumno)alumno2).getLegajo());
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getLegajo()).sosMenor(((IAlumno)alumno2).getLegajo());
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getLegajo()).sosMayor(((IAlumno)alumno2).getLegajo());
        }
        public override string ToString()
        {
            return "Legajo";
        }
    }
}
