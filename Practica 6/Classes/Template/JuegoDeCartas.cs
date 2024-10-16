using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica_6.Classes.Template
{
    public abstract class JuegoDeCartas
    {
        protected Mazo mazo;
        protected bool hayUnGanador;
        protected Jugador ganador;
        protected Jugador jugador1, jugador2;

        public void jugar()
        {
            iniciarTablero();
            mezclarMazo();
            repartirCartas();/*
            Console.WriteLine($"Cartas de: {jugador1.getNombre()}");
            jugador1.verCartas();
            Console.WriteLine($"Cartas de: {jugador2.getNombre()}");
            jugador2.verCartas();
            Console.Read();*/
            while (!hayUnGanador)
            {
                jugarManos();
                ganador = verificarGanador();
            }
        }

        public void iniciarTablero()
        {
            hayUnGanador = false;
            ganador = null;
            jugador1.setPuntaje(0);
            jugador1.vaciarMano();
            jugador2.setPuntaje(0);
            jugador2.vaciarMano();

        }

        protected void mezclarMazo()
        {
            mazo.cargarMazo(generarMazo());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Mezclando mazo");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.WriteLine(".");
            Thread.Sleep(250);
            mazo.mezclar();
        }

        protected abstract List<Carta> generarMazo();

        protected abstract void repartirCartas();
        protected abstract void jugarManos();
        protected abstract Jugador verificarGanador();

        public Jugador getGanador()
        { 
            return ganador;
        }
    }
}
