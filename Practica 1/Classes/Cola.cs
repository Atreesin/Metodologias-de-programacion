using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    //EJERCICIO 4

    class Cola: Coleccionable
    {
        private List<Comparable> datos = new List<Comparable>();

        public void encolar(Comparable elem)
        {
            this.datos.Add(elem);
        }

        public Comparable desencolar()
        {
            if (!this.esVacia())
            {
                Comparable temp = this.datos[0];
                this.datos.RemoveAt(0);
                return temp;
            }
            else
            {
                throw (new Exception("La Cola esta vacia!"));
            }
        }

        public Comparable tope()
        {
            return this.datos[0];
        }

        public bool esVacia()
        {
            return this.datos.Count == 0;
        }

        
        /* metodos de la interface */

        public int cuantos()
        {
            return this.datos.Count;
        }

        public Comparable minimo()
        {
            Comparable temp = this.datos[0];
            foreach (Comparable c in this.datos)
            {
                if (c.sosMenor(temp))
                {
                    temp = c;
                }
            }
            return temp;
        }

        public Comparable maximo()
        {
            Comparable temp = this.datos[0];
            foreach (Comparable c in this.datos)
            {
                if (c.sosMayor(temp))
                {
                    temp = c;
                }
            }
            return temp;
        }

        public void agregar(Comparable elem)
        {
            this.encolar(elem);
        }

        public bool contiene(Comparable elem)
        {
            foreach (Comparable c in this.datos)
            {
                if (c.sosIgual(elem))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
