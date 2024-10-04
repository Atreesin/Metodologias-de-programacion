
using Practica_4.Interfaces;
using System;
using System.Collections.Generic;


namespace Practica_4.Classes
{
    public class AlumnoMuyEstudioso : IAlumno
    {
        public AlumnoMuyEstudioso(string nombre, Numero dni, Numero legajo, Numero promedio)
        {
            observadores = new List<IObservador>();
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }

        public override void distraerse()
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

        

    }
}
