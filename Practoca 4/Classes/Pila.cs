using Practica_4.Classes;
using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    

    public class Pila : Coleccionable, Iterable
    {
        private List<Comparable> datos = new List<Comparable>();
                

        public void apilar(Comparable c)
        {
            this.datos.Add(c);
        }
        
        public Comparable desapilar()
        {
            if (!this.esVacia())
            {
                Comparable temp = this.datos[-1];
                this.datos.RemoveAt(-1);
                return temp;
            }
            else
            {
                throw (new Exception("La pila esta vacia!"));
            } 
        }

        public Comparable tope()
        {
            return this.datos[-1];
        }

        public bool esVacia()
        {
            return this.datos.Count == 0;
        }

        //********************************************

        public Iterador crearIterador()
        {
            return new IteradorDeListComparables(datos, this.cuantos());
        }

        /* metodos de la interface */

        public int cuantos()
        {
            return this.datos.Count;
        }

        public Comparable minimo()
        {
            Iterador iterador = crearIterador();
            Comparable temp = iterador.actual();
            while (!iterador.fin())
            {
                if (iterador.actual().sosMenor(temp))
                {
                    temp = iterador.actual();
                }
                iterador.siguiente();
            }
            return temp;
        }

        public Comparable maximo()
        {
            Iterador iterador = crearIterador();
            Comparable temp = iterador.actual();
            while (!iterador.fin())
            {
                if (iterador.actual().sosMayor(temp))
                {
                    temp = iterador.actual();
                }
                iterador.siguiente();
            }
            return temp;
        }

        public void agregar(Comparable elem)
        {
            this.apilar(elem);
        }

        public bool contiene(Comparable elem)
        {
            Iterador iterador = crearIterador();
            while (!iterador.fin())
            {
                if ((iterador.actual().sosIgual(elem)))
                {
                    return true;
                }
                iterador.siguiente();
            }
            return false;
        }
    }
}
