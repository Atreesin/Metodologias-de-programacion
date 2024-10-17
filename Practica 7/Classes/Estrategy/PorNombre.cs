using Practica_7.Interfaces;


namespace Practica_7.Classes
{
    public class PorNombre : Estrategia
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            return (((IAlumno)a).getNombre() == ((IAlumno)b).getNombre());
        }

        public bool sosMayor(Comparable a, Comparable b)
        {
            return (string.Compare(((IAlumno)a).getNombre(), ((IAlumno)b).getNombre()) > 0);
        }

        public bool sosMenor(Comparable a, Comparable b)
        {
            return (string.Compare(((IAlumno)a).getNombre(), ((IAlumno)b).getNombre()) < 0);
        }
        public override string ToString()
        {
            return "Nombre";
        }
    }
}
