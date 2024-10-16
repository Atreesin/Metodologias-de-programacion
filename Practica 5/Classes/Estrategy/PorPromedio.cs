using Practica_5.Interfaces;

namespace Practica_5.Classes
{
    public class PorPromedio : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getPromedio()).sosIgual(((IAlumno)alumno2).getPromedio());
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getPromedio()).sosMenor(((IAlumno)alumno2).getPromedio());
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getPromedio()).sosMayor(((IAlumno)alumno2).getPromedio());
        }
        public override string ToString()
        {
            return "Promedio";
        }
    }
}
