using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Classes.Template
{
    public class Jugador
    {
        private string nombre;
        private int victorias;
        private int puntaje;
        private List<Carta> mano;

        public Jugador(string nombre) 
        {
            this.nombre = nombre;
            victorias = 0;
            puntaje = 0;
            mano = new List<Carta>();
        }

        /// <summary>
        /// Nombre del jugador
        /// </summary>
        /// <returns></returns>
        public string getNombre() 
        {
            return nombre;
        }

        /// <summary>
        /// Puntaje del jugador
        /// </summary>
        /// <returns></returns>
        public int getPuntaje()
        {
            return puntaje;
        }

        /// <summary>
        /// Asigna un puntaje al jugador
        /// </summary>
        /// <param name="puntaje"></param>
        public void setPuntaje(int puntaje) 
        { 
            this.puntaje = puntaje;
        }
        
        /// <summary>
        /// Cantidad de victorias del jugador
        /// </summary>
        /// <returns></returns>
        public int getVictorias()
        {
            return victorias;
        }

        /// <summary>
        /// Suma una victoria al jugador
        /// </summary>
        public void agregarVictoria()
        {
            victorias++;
        }

        /// <summary>
        /// Setea en 0 las victorias y el puntaje del jugador
        /// </summary>
        public void resetearJuego()
        {
            victorias = 0;
            puntaje = 0;
        }

        /// <summary>
        /// Agrega una carta a la mano del jugador
        /// </summary>
        /// <param name="carta">Carta a añadir</param>
        public void tomarCarta(Carta carta)
        {
            if(carta != null)
            {
                mano.Add(carta);
            }
            else
            {
                Console.WriteLine("no hay carta para tomar.");
            }
        }

        /// <summary>
        /// Deja la ultima carta agregada a la mano
        /// </summary>
        /// <returns></returns>
        public Carta dejarCarta()
        {
            Carta c = null;
            if (quedanCartas())
            {
                c = mano.Last();
                mano.Remove(c);
            }
            return c; 
        }

        /// <summary>
        /// Deja la primer que encuentre en la mano con cierto <paramref name="numero"/>
        /// </summary>
        /// <param name="numero">numero a buscar</param>
        /// <returns>Carta con el <paramref name="numero"/> a buscar</returns>
        public Carta dejarCartaNumero(int numero)
        {
            Carta c = null;
            foreach (Carta carta in mano)
            {
                if (carta.getNumero() == numero && c == null)
                {
                    c = carta;
                    mano.Remove(c);
                    break;
                }
            }
            return c;
        }

        /// <summary>
        /// Deja la primer que encuentre en la mano con cierto <paramref name="palo"/>
        /// </summary>
        /// <param name="palo">Palo a buscar</param>
        /// <returns>Carta con el <paramref name="palo"/> a buscar</returns>
        public Carta dejarCartaPalo(string palo)
        {
            Carta c = null;
            foreach (Carta carta in mano)
            {
                if (carta.getPalo() == palo && c == null)
                {
                    c = carta;
                    mano.Remove(c);
                    break;
                }
            }
            return c;
        }

        /// <summary>
        /// Elimina todas las cartas de la mano del jugador
        /// </summary>
        public void vaciarMano()
        {
            mano.Clear();
        }

        /// <summary>
        /// Dice si quedan cartas en la mano del jugador
        /// </summary>
        /// <returns></returns>
        public bool quedanCartas()
        {
            return (mano.Count > 0);
        }

        /// <summary>
        /// Dice si el jugador tiene una carta de cierto <paramref name="palo"/>
        /// </summary>
        /// <param name="palo"></param>
        /// <returns></returns>
        public bool tieneCartaPalo(string palo)
        {
            foreach (Carta carta in mano)
            {
                if(carta.getPalo() == palo)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Dice si el jugador tiene una carta de cierto <paramref name="numero"/>
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool tieneCartaNumero(int numero)
        {
            foreach (Carta carta in mano)
            {
                if (carta.getNumero() == numero)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Dice si el jugador tiene una carta de cierto <paramref name="valor"/>
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public bool tieneCartaValor(int valor)
        {
            foreach (Carta carta in mano)
            {
                if (carta.getNumero() == valor)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Dice si el jugador tiene la <see cref="Carta"/> <paramref name="c"/>
        /// </summary>
        /// <param name="c">Carta a buscar</param>
        /// <returns></returns>
        public bool tieneCarta(Carta c)
        {
            foreach (Carta carta in mano)
            {
                if (carta == c)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Imprime en consola las cartas de la mano del jugador
        /// </summary>
        public void verCartas()
        {
            foreach(Carta carta in mano)
            {
                Console.WriteLine(carta);
            }
        }

        /// <summary>
        /// La cantidad de cartas que hay en la mano del jugador
        /// </summary>
        /// <returns></returns>
        public int cuantasCartas()
        {
            return mano.Count;
        }
        

        public override string ToString()
        {
            return $"Jugador: {nombre}\nPuntaje: {puntaje}\n\tVictorias: {victorias}";
        }
    }
}
