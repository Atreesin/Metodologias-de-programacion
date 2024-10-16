using Practica_5.Classes;
using Practica_5.Interfaces;
using System;
using System.Collections.Generic;

namespace Practica_5
{
    //EJERCICIO 4

    public class Cola: Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> datos = new List<Comparable>();
        private OrdenEnAula1 ordenInicio, ordenAulaLlena;
        private OrdenEnAula2 ordenLlegaAlumno;

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
            this.encolar(elem);
            if (cuantos() == 1 && ordenInicio != null)
            {
                ordenInicio.ejecutar();
            }
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(elem);
            }
            if (ordenAulaLlena != null && cuantos() == 40)
            {
                ordenAulaLlena.ejecutar();
            }
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

        public void ordenar()
        {
            datos.Sort(new IAlumnoComparer());
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}
