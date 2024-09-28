using Practica_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
{
    public class AlumnoFavorito : Alumno 
    {
        
        public AlumnoFavorito(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni, legajo, promedio)
        {
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
            if (observado is Alumno)
            {
                if (((Alumno)(observado)).getTiroAvion())
                {
                    this.notificar();
                }
            }
        }
    }
}
