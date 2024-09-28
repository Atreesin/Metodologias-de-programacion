using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{

    public class Alumno : Persona, IObservador, IObservado
    {
        private List<IObservador> observadores;
        private bool tiroAvion = false;
        protected Estrategia criterio = new PorNombre();
        private Numero legajo;
        private Numero promedio;
        private int calificacion = 0;


        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            observadores = new List<IObservador>();
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public Numero getLegajo() { return legajo; }
        public Numero getPromedio() { return promedio; }
        public bool getTiroAvion() { return tiroAvion; }
        public int getCalificacion() { return calificacion; }
        public void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
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
        
        //*************************************************

        public void prestarAtencion()
        {
            Console.WriteLine($"{this.nombre} esta prestando atención");
        }

        public virtual void distraerse()
        {
            int opc = GeneradorDeDatosAleatorios.numeroAleatorio(3);
            tiroAvion = false;
            switch (opc)
            {
                case 0:
                    Console.WriteLine($"{this.nombre} esta mirando el celular");
                    break;
                case 1:
                    Console.WriteLine($"{this.nombre} esta dibujando en el margen de la carpeta");
                    break;
                case 2:
                    tiroAvion = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{this.nombre} esta tirando avioncitos de papel");
                    Console.ForegroundColor = ConsoleColor.White;
                    this.notificar();
                    break;
            }
            
        }

        //*************************************************

        public virtual void actualizar(IObservado observado)
        {
           if (((Profesor)(observado)).getEstaHablando())
           {
                this.prestarAtencion();
           }
           else
           {
                this.distraerse();
           }
            
        }

        //*************************************************
        public virtual int responderPregunta(int pregunta)
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(3);
        }

        public string mostrarCalificacion()
        {
            return $"{this.nombre}\t{this.getCalificacion()}";
        }


        //*************************************************
        public void setCriterio(Estrategia c)
        {
            this.criterio = c;
        }
        public  Estrategia getCriterio()
        {
            return this.criterio;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni} Legajo: {this.legajo} Promedio:{promedio}";
        }

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
    }
}
