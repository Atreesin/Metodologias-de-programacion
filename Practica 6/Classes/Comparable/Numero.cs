

namespace Practica_6
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

            return (this.valor == ((Numero)n).getValor());
        }

        public bool sosMenor(Comparable n)
        {
            /*  Devuelve verdadero si el objeto
            que recibe el mensaje es más chico que
            el “comparable” recibido por parámetro,
            devuelve falso en caso contrario */

            return (this.valor < ((Numero)n).getValor());
        }

        public bool sosMayor(Comparable n)
        {
            /* Devuelve verdadero si el objeto
            que recibe el mensaje es más grande que
            el “comparable” recibido por parámetro,
            devuelve falso en caso contrario */
            return (this.valor > ((Numero)n).getValor());
        }
        
        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}
