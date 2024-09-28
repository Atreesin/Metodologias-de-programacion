using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class ClaveValor : Comparable
    {
        private Comparable clave, valor;
        public ClaveValor(Comparable clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public Comparable getClave() {  return this.clave; }
        public Comparable getValor() {  return this.valor; }
        public void setValor(Comparable valor) {  this.valor = valor; } 

        public bool sosIgual(Comparable c)
        {
            return this.clave.sosIgual(((ClaveValor)c).getClave());
        }

        public bool sosMayor(Comparable c)
        {
            return this.clave.sosMayor(((ClaveValor)c).getClave());
        }

        public bool sosMenor(Comparable c)
        {
            return this.clave.sosMenor(((ClaveValor)c).getClave());
        }

        public override string ToString()
        {
            return ($"Clave: {this.clave} Valor: {this.valor}");
        }
    }
}
