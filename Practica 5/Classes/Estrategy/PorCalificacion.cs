using Practica_5.Interfaces;


namespace Practica_5.Classes
{
    public class PorCalificacion : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getCalificacion()) == (((IAlumno)alumno2).getCalificacion());
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getCalificacion()) < (((IAlumno)alumno2).getCalificacion());
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getCalificacion()) > (((IAlumno)alumno2).getCalificacion());
        }
        public override string ToString()
        {
            return "Calificacion";
        }
    }
}
