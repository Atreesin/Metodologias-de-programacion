using Practica_7.Classes.Chain_of_Responsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7.Classes.Template
{
    public class Mazo
    {
        private List<Carta> cartas = new List<Carta>();
        private List<Carta> mesa = new List<Carta>();
        private Manejador manejador;

        public Mazo() 
        {
            manejador = GeneradorDeDatosAleatorios.getInstance(null);
        }
        /// <summary>
        /// Carga una lista de cartas y limpia la mesa si hay cartas de un juego anterior.
        /// </summary>
        /// <param name="mazo">Lista de cartas</param>
        public void cargarMazo(List<Carta> mazo)
        {
            cartas = mazo;
            if (quedanCartasEnMesa())
            {
                mesa.Clear();
            }

            /* 
            
            // si las cartas se comparan como mayor valor poseen un mayor valor que otra se deberia asignar un valor para poder comparar las cartas con los metodos de comparable
            // por ejemplo con el truco ademas el mazo es distinto asi que deberia generarse un mazo especifico para cada juego:
            // 1 de espada: 19
            // 1 de basto: 18
            // 7 de espada: 17
            // 7 de oro: 16
            // 3 (todos los palos): 15
            // 2 (todos los palos): 14
            // 1 de copa y 1 de oro: 13
            // 12 (todos los palos): 12
            // 11 (todos los palos): 11
            // 10 (todos los palos): 10
            // 7 de copas y 7 de basto: 7
            // 6 (todos los palos): 6
            // 5 (todos los palos): 5
            // 4 (todos los palos): 4

            // usando c.setValor(valor)

            // en caso se mazo generico:
            if (quedanCartas())
            {
                cartas.Clear();
            }

            Carta c;
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Oro");
                cartas.Add(c);
            }
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Copas");
                cartas.Add(c);
            }
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Espadas");
                cartas.Add(c);
            }
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Bastos");
                cartas.Add(c);
            }
            */
        }

        /// <summary>
        /// Vuelve a poner en el mazo las cartas que se jugaron en la mesa.
        /// </summary>
        public void devolverMesaAlMazo()
        {
            cartas = mesa;
            mesa.Clear();
        }

        /// <summary>
        /// Mezcla las cartas del mazo
        /// </summary>
        public void mezclar()
        {
            List<Carta> mezclado = cartas.OrderBy(x => manejador.numeroAleatorioSinLimite()).ToList();
            cartas = mezclado;
        }

        /// <summary>
        /// Toma una <see cref="Carta"/> del mazo
        /// </summary>
        /// <returns>Una <see cref="Carta"/> del mazo</returns>
        public Carta tomarCarta()
        {
            Carta c = null;
            if (quedanCartas())
            {
                c = cartas.First();
                cartas.Remove(c);
            }
            return c;
        }

        /// <summary>
        /// Toma una carta de la mesa
        /// </summary>
        /// <returns>Una <see cref="Carta"/> de la mesa</returns>
        public Carta tomarCartaDeLaMesa()
        {
            Carta c = null;
            if (quedanCartasEnMesa())
            {
                c = mesa.Last();
                cartas.Remove(c);
            }
            return c;
        }

        /// <summary>
        /// Deja una carta sobre la mesa
        /// </summary>
        /// <param name="carta">Una <see cref="Carta"/> que se va a dejar en la mesa</param>
        public void dejarCartaEnLaMesa(Carta carta)
        {
            if (carta != null)
            {
                mesa.Add(carta);
            }
            else
            {
                Console.WriteLine("no habia una carta");
            }
        }

        /// <summary>
        /// Muesta la ultima carta que se dejo sobre la mesa
        /// </summary>
        /// <returns>Ultima <see cref="Carta"/> sobre la mesa</returns>
        public Carta verCartaDeLaMesa()
        {
            Carta c = null;
            if (quedanCartasEnMesa())
            {
                c = mesa.Last();
            }
            return c;
        }

        /// <summary>
        /// Reparte cierta cantidad de cartas entre 2 jugadores
        /// </summary>
        /// <param name="j1">Judador 1</param>
        /// <param name="j2">Jugador 2</param>
        /// <param name="cantidad">Cantidad de cartas para cada jugador</param>
        public void repartir(Jugador j1, Jugador j2, int cantidad)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                j1.tomarCarta(tomarCarta());
                j2.tomarCarta(tomarCarta());
            }
        }

        /// <summary>
        /// Dice si quedan cartas en el mazo
        /// </summary>
        /// <returns></returns>
        public bool quedanCartas()
        {
            return (cartas.Count > 0);
        }

        /// <summary>
        /// Dice si quedan cartas sobre la mesa
        /// </summary>
        /// <returns></returns>
        public bool quedanCartasEnMesa()
        {
            return (mesa.Count > 0);
        }

        public override string ToString()
        {
            string mazo = "";
            foreach (var c in cartas)
            {
                mazo += "\n" + c.ToString();
            }
            return mazo;
        }
    }
}
