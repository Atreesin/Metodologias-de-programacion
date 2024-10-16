using Practica_5.Interfaces;
using System.Collections.Generic;


namespace Practica_5.Classes
{
    public class IteradorDeListComparables : Iterador
    {
        private List<Comparable> comparables;
        private int indice;
        private int longitud;

        public IteradorDeListComparables(List<Comparable> comparables, int longitud)
        {
            this.comparables = comparables;
            this.longitud = longitud;
            this.indice = 0;
        }

        public Comparable actual()
        {
            return this.comparables[indice];
        }

        public void siguiente()
        {
            this.indice++;
        }

        public void anterior()
        {
            this.indice--;
        }

        public void inicio()
        {
            this.indice = 0;
        }

        public bool fin()
        {
            return (this.indice >= this.longitud);
        }

        public bool primero()
        {
            return (this.indice < 0);
        }

    }
}
