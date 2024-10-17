using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7.Classes.Template
{
    /// <summary>
    /// Una Carta/Naipe que tiene un numero, un palo y un valor (para compararse con otras cartas dependiendo el juego)
    /// </summary>
    public class Carta : Comparable
    {
        private int numero;
        private string palo;
        private int valor;

        /// <summary>
        /// Una Carta/Naipe que tiene un numero, un palo y un valor (para compararse con otras cartas dependiendo el juego)
        /// </summary>
        /// <param name="numero">Numero de carta entre 1-12</param>
        /// <param name="palo">
        /// <list type="table">
        /// <b>Palos:</b>
        /// <item>Espadas</item>
        /// <item>Bastos</item>
        /// <item>Oro</item>
        /// <item>Copas</item>
        /// </list>
        /// </param>
        public Carta(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
            this.valor = 0;
        }

        /// <summary>
        /// Asigna un valor numerico a una carta. Para cartas de mayor valor numeros mas grandes.
        /// </summary>
        /// <param name="valor">Valor de la carta</param>
        public void setValor(int valor)
        {
            this.valor = valor;
        }

        /// <summary>
        /// Valor asignado a la carta
        /// </summary>
        /// <returns>Valor de la carta</returns>
        public int getValor()
        {
            return this.valor;
        }

        /// <summary>
        /// Numero asignado a la carta
        /// </summary>
        /// <returns>Numero de la carta</returns>
        public int getNumero()
        {
             return numero;
        }

        /// <summary>
        /// Palo asignado a la carta
        /// </summary>
        /// <returns>Numero de la carta</returns>
        public string getPalo()
        {
            return palo;
        }

       
        /// <summary>
        /// Compara el valor de la carta, con el valor de la carta recibida por parametro
        /// </summary>
        /// <param name="c">Carta a comparar debe ser de tipo <see cref="Carta"/></param>
        /// <returns><b>True</b> Si son iguales</returns>
        public bool sosIgual(Comparable c)
        {
            return (this.valor == ((Carta)c).valor);
        }

        /// <summary>
        /// Compara el valor de la carta, con el valor de la carta recibida por parametro
        /// </summary>
        /// <param name="c">Carta a comparar debe ser de tipo <see cref="Carta"/></param>
        /// <returns><b>True</b> Si el valor de la carta es menor que el valor de <paramref name="c"/></returns>
        public bool sosMenor(Comparable c)
        {
            return (this.valor < ((Carta)c).valor);
        }

        /// <summary>
        /// Compara el valor de la carta, con el valor de la carta recibida por parametro
        /// </summary>
        /// <param name="c">Carta a comparar debe ser de tipo <see cref="Carta"/></param>
        /// <returns><b>True</b> Si el valor de la carta es mayor que el valor de <paramref name="c"/></returns>
        public bool sosMayor(Comparable c)
        {
            return (this.valor > ((Carta)c).valor);
        }

        public override string ToString()
        {
            return $"{numero} de {palo}";
        }
    }
}
