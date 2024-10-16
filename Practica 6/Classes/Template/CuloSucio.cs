using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Practica_6.Classes.Template
{
    /// <summary>
    /// Juego de cartas "CuloSucio"
    /// <list type="bullet">
    /// <b>Reglas:</b>
    /// <item>Se reparten todas las cartas del mazo entre 2 jugadores.</item>
    /// <item>Cada jugador va tirando de a 1 carta hasta que uno tire el <b>1 de Oro</b></item>
    /// </list> 
    /// Pierde el jugador al que le toca el <b>1 de Oro</b>
    /// </summary>
    public class CuloSucio : JuegoDeCartas
    {
        private Carta cartaJugadaJ1;
        private Carta cartaJugadaJ2;
        private Carta culoSucio;
        

        public CuloSucio(Jugador jugador1, Jugador jugador2)
        {
            this.mazo = new Mazo();
            culoSucio = new Carta(1, "Oro");
            culoSucio.setValor(1);
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
        }

        protected override List<Carta> generarMazo()
        {
            List<Carta> cts = new List<Carta>();
            Carta c;
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Oro");
                if (i == 1)
                {
                    c.setValor(1);
                    culoSucio = c;
                }
                cts.Add(c);
            }
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Copas");
                cts.Add(c);
            }
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Espadas");
                cts.Add(c);
            }
            for (int i = 1; i <= 12; i++)
            {
                c = new Carta(i, "Bastos");
                cts.Add(c);
            }
            return cts;
        }

        protected override void repartirCartas()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Repartiendo Cartas");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.WriteLine(".");
            Thread.Sleep(250);
            mazo.repartir(jugador1,jugador2, 24);
        }

        protected override void jugarManos()
        {
            if (jugador1.quedanCartas())
            {
                cartaJugadaJ1 = jugador1.dejarCarta();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{jugador1.getNombre()} tiro la carta: {cartaJugadaJ1}");
                Console.ReadKey();
            }
            if (jugador2.quedanCartas() && cartaJugadaJ1 != culoSucio)
            {
                cartaJugadaJ2 = jugador2.dejarCarta();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{jugador2.getNombre()} tiro la carta: {cartaJugadaJ2}");
                Console.ReadKey();
            }
            
        }

        protected override Jugador verificarGanador()
        {
            Jugador ganador = null;

            if (cartaJugadaJ1 == culoSucio)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡¡¡CULO SUCIO!!!");
                Console.ForegroundColor = ConsoleColor.Green;
                jugador2.agregarVictoria();
                ganador = jugador2;
                hayUnGanador = true;
            }
            if (cartaJugadaJ2 == culoSucio)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡¡¡CULO SUCIO!!!");
                Console.ForegroundColor = ConsoleColor.Green;
                jugador1.agregarVictoria();
                ganador = jugador1;
                hayUnGanador = true;
            }
            if (hayUnGanador)
            {
                Console.WriteLine($"El ganador es: {ganador.getNombre()}\n\tVictorias: {ganador.getVictorias()}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pulsar una tecla para continuar...");
                Console.Read();
            }

            return ganador;
        }
    }
}
