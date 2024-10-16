using Practica_6.Interfaces;
using System;
using System.Collections.Generic;


namespace Practica_6.Classes
{
    public abstract class IAlumno : Persona, IObservador, IObservado
    {
        protected List<IObservador> observadores;
        protected bool tiroAvion = false;
        protected Estrategia criterio = new PorNombre();
        protected Numero legajo;
        protected Numero promedio;
        protected int calificacion = 0;


        public virtual Numero getLegajo() { return legajo; }
        public virtual Numero getPromedio() { return promedio; }
        public virtual bool getTiroAvion() { return tiroAvion; }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setLegajo(Numero legajo)
        {
            this.legajo = legajo;
        }
        public void setPromedio(Numero promedio)
        {
            this.promedio = promedio;
        }

        public virtual int getCalificacion() { return calificacion; }
        public virtual void setCalificacion(int calificacion)
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


        public abstract int responderPregunta(int pregunta);

        public virtual string mostrarCalificacion()
        {
            return $"{this.nombre}    {this.getCalificacion()} ";
        }



        public virtual void setCriterio(Estrategia c)
        {
            this.criterio = c;
        }
        public virtual Estrategia getCriterio()
        {
            return this.criterio;
        }

        public override string ToString()
        {
            return $"Nombre: {getNombre()} Dni: {getDni()} Legajo: {getLegajo()} Promedio:{getPromedio()}";
        }

        public virtual void prestarAtencion()
        {
            Console.WriteLine($"{this.nombre} esta prestando atención");
        }

        public abstract void distraerse();


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

        public virtual void agregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public virtual void quitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public virtual void notificar()
        {
            foreach (IObservador observador in observadores)
            {
                observador.actualizar(this);
            }
        }
    }
}
