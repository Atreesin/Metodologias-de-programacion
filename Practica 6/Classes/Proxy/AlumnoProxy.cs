using Practica_6.Classes.Factory;
using Practica_6.Interfaces;
using System;
using System.Net;

namespace Practica_6.Classes.Proxy
{
    public class AlumnoProxy : IAlumno
    {
        private IAlumno alumnoReal = null;
        private int queCrear;

        public AlumnoProxy(string nombre, Numero dni, Numero legajo, Numero promedio, int opcion)
        {
            this.nombre = nombre;
            queCrear = opcion;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public override string getNombre()
        {
            return nombre;
        }

        public override bool getTiroAvion() 
        {
            crearAlumnoReal();
            return alumnoReal.getTiroAvion();
        }


        public override int getCalificacion() 
        {
            crearAlumnoReal();
            return alumnoReal.getCalificacion(); 
        }

        public override void setCalificacion(int calificacion)
        {
            crearAlumnoReal();
            alumnoReal.setCalificacion(calificacion);
        }

        public override bool sosIgual(Comparable alumno)
        {
            crearAlumnoReal();
            return alumnoReal.sosIgual(alumno);
        }

        public override bool sosMenor(Comparable alumno)
        {
            crearAlumnoReal();
            return alumnoReal.sosMenor(alumno);
        }

        public override bool sosMayor(Comparable alumno)
        {
            crearAlumnoReal();
            return alumnoReal.sosMayor(alumno);
        }


        public override int responderPregunta(int pregunta)
        {
            crearAlumnoReal();
            return alumnoReal.responderPregunta(pregunta);
        }

        
        public override Estrategia getCriterio()
        {
            crearAlumnoReal();
            return alumnoReal.getCriterio();
        }

        public override string ToString()
        {
            crearAlumnoReal();
            return $"Nombre: {getNombre()} Dni: {getDni()} Legajo: {getLegajo()} Promedio:{getPromedio()}";
        }

        public override void prestarAtencion()
        {
            crearAlumnoReal();
            alumnoReal.prestarAtencion();
        }

        public override void distraerse()
        {
            crearAlumnoReal();
            alumnoReal.distraerse();
        }


        public override void actualizar(IObservado observado)
        {
            crearAlumnoReal();
            alumnoReal.actualizar(observado);
        }

        public override void agregarObservador(IObservador observador)
        {
            crearAlumnoReal();
            alumnoReal.agregarObservador(observador);
        }

        public override void quitarObservador(IObservador observador)
        {
            crearAlumnoReal();
            alumnoReal.quitarObservador(observador);
        }

        public override void notificar()
        {
            crearAlumnoReal();
            alumnoReal.notificar();
        }

        private void crearAlumnoReal()
        {
            if (alumnoReal == null)
            {
                alumnoReal = FabricaDeAlumnos.CrearAleatorio(queCrear);
                alumnoReal.setNombre(nombre);
                alumnoReal.setDni(dni);
                alumnoReal.setLegajo(legajo);
                alumnoReal.setPromedio(promedio);
                alumnoReal.setCriterio(criterio);
            }
        }
    }
}
