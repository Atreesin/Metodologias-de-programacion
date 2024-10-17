using Practica_7.Interfaces;


namespace Practica_7.Classes
{
    public class PorDni : Estrategia
    {
        public bool sosIgual(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getDni()).sosIgual(((IAlumno)alumno2).getDni());
        }

        public bool sosMenor(Comparable alumno1, Comparable alumno2)
        {
            return (((IAlumno)alumno1).getDni()).sosMenor(((IAlumno)alumno2).getDni());
        }

        public bool sosMayor(Comparable alumno1, Comparable alumno2)
        {
            if ((((IAlumno)alumno1).getDni()).sosMayor(((IAlumno)alumno2).getDni()))
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
            return "Dni";
        }
    }
}
