using Practica_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
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
