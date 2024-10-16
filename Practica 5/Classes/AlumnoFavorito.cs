using Practica_5.Interfaces;
using System;
using System.Collections.Generic;


namespace Practica_5.Classes
{

    
  
    public class AlumnoFavorito : IAlumno 
    {
        

        public AlumnoFavorito(string nombre, Numero dni, Numero legajo, Numero promedio)
        {
            observadores = new List<IObservador>();
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public override void distraerse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yo nunca me distraigo, siempre presto atencion");
            Console.ForegroundColor= ConsoleColor.White;
        }

        public override void actualizar(IObservado observado)
        {
            if (observado is Profesor)
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
            if (observado is IAlumno)
            {
                if (((IAlumno)(observado)).getTiroAvion())
                {
                    this.notificar();
                }
            }
        }

        public override int responderPregunta(int pregunta)
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(3);
        }

    }
}
