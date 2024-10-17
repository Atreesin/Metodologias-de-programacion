using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_7.Classes.Template
{
    /// <summary>
    /// Juego de cartas "Jodete"
    /// <list type="bullet">
    /// <b>Reglas:</b>
    /// <item>Cada jugador empieza con 5 cartas.</item>
    /// <item>Se coloca una carta sobre la mesa.</item>
    /// <item>Si un jugador tiene una carta del mismo palo o numero que la carta sobre la mesa deja esa carta sobre la mesa y finaliza su turno.</item>
    /// <item>Si no tiene ninguna carta para jugar, toma una carta del mazo y pasa su turno.</item>
    /// <item>Cuando un jugador Tira una carta numero 2 el otro jugador toma 2 cartas.</item>
    /// </list> 
    /// <b>Gana el primer jugador que se queda sin cartas</b>
    /// </summary>
    public class Jodete : JuegoDeCartas
    {

        public Jodete(Jugador jugador1, Jugador jugador2)
        {
            this.mazo = new Mazo();
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

        protected override void jugarManos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Turno de: {jugador1.getNombre()}\tTiene: {jugador1.cuantasCartas()} cartas\n\tCarta: en la mesa: {mazo.verCartaDeLaMesa()} \n");

            //turno jugador1
            if (jugador1.tieneCartaNumero(mazo.verCartaDeLaMesa().getNumero()) || jugador1.tieneCartaPalo(mazo.verCartaDeLaMesa().getPalo()))
            {
                if (jugador1.tieneCartaNumero(mazo.verCartaDeLaMesa().getNumero()))
                {
                    mazo.dejarCartaEnLaMesa(jugador1.dejarCartaNumero(mazo.verCartaDeLaMesa().getNumero()));
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{jugador1.getNombre()} tiro la carta: {mazo.verCartaDeLaMesa()}");
                    Console.ReadKey();
                    if (mazo.verCartaDeLaMesa().getNumero() == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{jugador2.getNombre()} toma 2 cartas");
                        Console.ReadKey();
                        comprobarMazo();
                        jugador2.tomarCarta(mazo.tomarCarta());
                        comprobarMazo();
                        jugador2.tomarCarta(mazo.tomarCarta());
                    }
                }
                else
                {
                    mazo.dejarCartaEnLaMesa(jugador1.dejarCartaPalo(mazo.verCartaDeLaMesa().getPalo()));
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{jugador1.getNombre()} tiro la carta: {mazo.verCartaDeLaMesa()}");
                    Console.ReadKey();
                    if (mazo.verCartaDeLaMesa().getNumero() == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{jugador2.getNombre()} toma 2 cartas");
                        Console.ReadKey();
                        comprobarMazo();
                        jugador2.tomarCarta(mazo.tomarCarta());
                        comprobarMazo();
                        jugador2.tomarCarta(mazo.tomarCarta());
                    }
                }
                Console.WriteLine($"\tLe quedan: {jugador1.cuantasCartas()} cartas");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{jugador1.getNombre()} toma 1 carta y pasa el turno.");
                Console.ReadKey();
                comprobarMazo();
                jugador1.tomarCarta(mazo.tomarCarta());
                Console.WriteLine($"\tLe quedan: {jugador1.cuantasCartas()} cartas");
                Console.ReadKey();
            }

            //turno jugador 2

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Turno de: {jugador2.getNombre()}\tTiene: {jugador2.cuantasCartas()} cartas\n\tCarta: en la mesa: {mazo.verCartaDeLaMesa()} \n");

            
            if (jugador1.quedanCartas())
            {
                if (jugador2.tieneCartaNumero(mazo.verCartaDeLaMesa().getNumero()) || jugador2.tieneCartaPalo(mazo.verCartaDeLaMesa().getPalo()))
                {
                    if (jugador2.tieneCartaNumero(mazo.verCartaDeLaMesa().getNumero()))
                    {
                        mazo.dejarCartaEnLaMesa(jugador2.dejarCartaNumero(mazo.verCartaDeLaMesa().getNumero()));
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"{jugador2.getNombre()} tiro la carta: {mazo.verCartaDeLaMesa()}");
                        Console.ReadKey();
                        if (mazo.verCartaDeLaMesa().getNumero() == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"{jugador1.getNombre()} toma 2 cartas.");
                            Console.ReadKey();
                            comprobarMazo();
                            jugador1.tomarCarta(mazo.tomarCarta());
                            comprobarMazo();
                            jugador1.tomarCarta(mazo.tomarCarta());
                        }
                    }
                    else
                    {
                        mazo.dejarCartaEnLaMesa(jugador2.dejarCartaPalo(mazo.verCartaDeLaMesa().getPalo()));
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"{jugador2.getNombre()} tiro la carta: {mazo.verCartaDeLaMesa()}");
                        Console.ReadKey();
                        if (mazo.verCartaDeLaMesa().getNumero() == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"{jugador1.getNombre()} toma 2 cartas.");
                            Console.ReadKey();
                            comprobarMazo();
                            jugador1.tomarCarta(mazo.tomarCarta());
                            comprobarMazo();
                            jugador1.tomarCarta(mazo.tomarCarta());
                        }
                    }
                    Console.WriteLine($"\tLe quedan: {jugador2.cuantasCartas()} cartas");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{jugador2.getNombre()} toma 1 carta y pasa el turno.");
                    Console.ReadKey();
                    comprobarMazo();
                    jugador2.tomarCarta(mazo.tomarCarta());
                    Console.WriteLine($"\tLe quedan: {jugador2.cuantasCartas()} cartas");
                    Console.ReadKey();
                }
            }

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
            mazo.repartir(jugador1, jugador2, 5);
            mazo.dejarCartaEnLaMesa(mazo.tomarCarta());
        }

        protected override Jugador verificarGanador()
        {
            Jugador ganador = null;
            if (!jugador1.quedanCartas())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡¡¡Gane!!!");
                Console.ForegroundColor = ConsoleColor.Green;
                jugador1.agregarVictoria();
                ganador = jugador1;
                hayUnGanador = true;
            }
            if (!jugador2.quedanCartas())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡¡¡Gane!!!");
                Console.ForegroundColor = ConsoleColor.Green;
                jugador2.agregarVictoria();
                ganador = jugador2;
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

        public void comprobarMazo()
        {
            Carta temp;
            if (!mazo.quedanCartas())
            {
                temp = mazo.tomarCartaDeLaMesa();
                mazo.devolverMesaAlMazo();
                mazo.mezclar();
                mazo.dejarCartaEnLaMesa(temp);
            }
        }
    }
}
