using MetodologíasDeProgramaciónI;
using Practica_4.Classes.Factory;
using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes.Adapter
{
    public class IteradorAdapter : IteratorOfStudent
    {
        protected IteradorDeListComparables adicional;

        public IteradorAdapter(IteradorDeListComparables adicional)
        {
            this.adicional = adicional;
        }

        public void beginning()
        {
            this.adicional.inicio();
        }

        public Student current()
        {
            return FabricaDeAlumnos.CrearAdaptado((IAlumno)this.adicional.actual());
        }

        public bool end()
        {
            return adicional.fin();
        }

        public void next()
        {
            this.adicional.siguiente();
        }
    }
}
