using MetodologíasDeProgramaciónI;
using Practica_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Adapter
{
    public class IterableAdapter : Collection
    {
        protected Coleccionable adicional;

        public IterableAdapter(Coleccionable coleccionable)
        {
            this.adicional = coleccionable;
        }

        public void addStudent(Student student)
        {
            this.adicional.agregar(((AlumnoAdapter)student).getAlumno());
        }

        public IteratorOfStudent getIterator()
        {
            return new IteradorAdapter((IteradorDeListComparables)((Iterable)adicional).crearIterador());
        }

        public void sort()
        {
            this.adicional.ordenar();
        }
    }
}
