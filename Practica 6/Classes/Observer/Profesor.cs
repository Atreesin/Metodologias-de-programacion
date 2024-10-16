using Practica_6.Interfaces;
using System;
using System.Collections.Generic;


namespace Practica_6.Classes
{
    public class Profesor : Persona, IObservado, IObservador
    {
        private List<IObservador> observadores;
        private bool estaHablando = false;
        private Estrategia criterio = new PorAntiguedad();
        private Numero antiguedad;

        public Profesor(string nombre, Numero dni, Numero antiguedad)
        {
            observadores = new List<IObservador>();
            this.nombre = nombre;
            this.dni = dni;
            this.antiguedad = antiguedad;
        }

        public Numero getAntiguedad() {  return antiguedad; }

        public bool getEstaHablando() { return estaHablando; }

        public void setCriterio(Estrategia c)
        {
            this.criterio = c;
        }
        public Estrategia getCriterio()
        {
            return this.criterio;
        }

        public override bool sosIgual(Comparable alumno)
        {
            return this.criterio.sosIgual(this, alumno);
        }

        public override bool sosMenor(Comparable alumno)
        {
            return this.criterio.sosMenor(this, alumno);
        }

        public override bool sosMayor(Comparable alumno)
        {
            return this.criterio.sosMayor(this, alumno);
        }

        //*********************************************************

        public void hablarALaClase()
        {
            estaHablando = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hablando de algun tema");
            Console.ForegroundColor = ConsoleColor.White;
            this.notificar();
        }

        public void escribirEnElPizzarron()
        {
            estaHablando = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escribiendo en el pizzarron");
            Console.ForegroundColor = ConsoleColor.White;
            this.notificar();
        }

        public void hacerSilencio()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Silencio, no se distraigan");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //*********************************************************

        public void agregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (IObservador observador in observadores)
            {
                observador.actualizar(this);
            }
        }

        //*********************************************************

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni} Antiguedad: {this.antiguedad}";
        }

        public void actualizar(IObservado observado)
        {
            this.hacerSilencio();
        }
    }
}
