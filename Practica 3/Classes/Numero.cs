using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    
    public class Numero : Comparable
    {
        protected int valor;

        public Numero(int v) { valor = v; }

        public int getValor() { return valor; }

        public bool sosIgual(Comparable n)
        {
            /* Devuelve verdadero si el objeto
            que recibe el mensaje es el mismo que
            el “comparable” recibido por parámetro,
            devuelve falso en caso contrario */

            if (this.valor == ((Numero)n).getValor() )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable n)
        {
            /*  Devuelve verdadero si el objeto
            que recibe el mensaje es más chico que
            el “comparable” recibido por parámetro,
            devuelve falso en caso contrario */

            if (this.valor < ((Numero)n).getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable n)
        {
            /* Devuelve verdadero si el objeto
            que recibe el mensaje es más grande que
            el “comparable” recibido por parámetro,
            devuelve falso en caso contrario */
            if (this.valor > ((Numero)n).getValor())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
     

        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}
