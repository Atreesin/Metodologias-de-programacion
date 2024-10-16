

namespace Practica_5.Classes
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
            return (pila.contiene(comparable) || cola.contiene(comparable));
        }

        public void ordenar()
        {
            pila.ordenar();
            cola.ordenar();
        }


    }
}
