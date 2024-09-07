using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
{
    
    public class ColeccionMultiple : Coleccionable
    {
        private Pila pila;
        private Cola cola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }

        public int cuantos()
        { 
            return pila.cuantos()+cola.cuantos();
        }

        public Comparable minimo()
        {
            if (pila.minimo().sosMenor(cola.minimo()))
            {
                return pila.minimo();
            }
            return cola.minimo();
        }

        public Comparable maximo()
        {
            if(pila.maximo().sosMayor(cola.maximo()))
            {
                return pila.maximo();
            }
            return cola.maximo();
        }

        public void agregar(Comparable c) {
        //no hace nada
        }

        public bool contiene(Comparable comparable)
        {
            if(pila.contiene(comparable) || cola.contiene(comparable))
            {
                return true;
            }
            else return false;
        }
    }
}
