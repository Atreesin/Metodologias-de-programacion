using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class Conjunto : Coleccionable, Iterable
    {
        private List<Comparable> elementos = new List<Comparable>();
        
        public virtual void agregar(Comparable c)
        {
            if (!this.pertenece(c))
            {
                elementos.Add(c);
            }
        }

        public virtual bool pertenece(Comparable elem)
        {
            Iterador iterador = crearIterador();
            while (!iterador.fin())
            {
                if ((iterador.actual().sosIgual(elem))){
                    return true;
                }
                iterador.siguiente();
            }
            /*
            foreach (Comparable c in this.elementos)
            {
                if (c.sosIgual(elem))
                {
                    return true;
                }
            }*/
            return false;
        }

        public virtual Iterador crearIterador()
        {
            return new IteradorDeListComparables(elementos, this.cuantos());
        }

        //interface coleccionable
        public virtual bool contiene(Comparable c)
        {
            return this.pertenece(c);
        }

        public virtual int cuantos()
        {
            return elementos.Count;
        }

        public virtual Comparable maximo()
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
            /*
            foreach (Comparable c in this.elementos)
            {
                if (c.sosMayor(temp))
                {
                    temp = c;
                }
            }*/
            return temp;
        }

        public virtual Comparable minimo()
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
            foreach (Comparable c in this.elementos)
            {
                if (c.sosMenor(temp))
                {
                    temp = c;
                }
            }*/
            return temp;
        }
    }
}
