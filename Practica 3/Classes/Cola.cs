using Practica_3.Classes;
using Practica_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    //EJERCICIO 4

    public class Cola: Coleccionable, Iterable
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

        public Iterador crearIterador()
        {
            return new IteradorDeListComparables(this.datos, this.cuantos());

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
            /*
            Comparable temp = this.datos[0];
            foreach (Comparable c in this.datos)
            {
                if (c.sosMenor(temp))
                {
                    temp = c;
                }
            }*/
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
            }/*
            Comparable temp = this.datos[0];
            foreach (Comparable c in this.datos)
            {
                if (c.sosMayor(temp))
                {
                    temp = c;
                }
            }*/
            return temp;
        }

        public void agregar(Comparable elem)
        {
            this.encolar(elem);
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
            /*
            foreach (Comparable c in this.datos)
            {
                if (c.sosIgual(elem))
                {
                    return true;
                }
            }*/
            return false;
        }

    }
}
