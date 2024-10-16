using MetodologíasDeProgramaciónI;
using Practica_5.Classes.Command;
using Practica_5.Interfaces;
using System.Collections.Generic;


namespace Practica_5.Classes
{
    public class Conjunto : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elementos = new List<Comparable>();
        protected OrdenEnAula1 ordenInicio, ordenAulaLlena;
        protected OrdenEnAula2 ordenLlegaAlumno;
        
        public virtual void agregar(Comparable c)
        {
            if (!this.pertenece(c))
            {
                elementos.Add(c);
                if (cuantos() == 1 && ordenInicio != null)
                {
                    ordenInicio.ejecutar();
                }
                if (ordenLlegaAlumno != null)
                {
                    ordenLlegaAlumno.ejecutar(c);
                }
                if (ordenAulaLlena != null && cuantos() == 40)
                {
                    ordenAulaLlena.ejecutar();
                }
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
            
            return temp;
        }

        public void ordenar()
        {
            elementos.Sort(new IAlumnoComparer());
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
