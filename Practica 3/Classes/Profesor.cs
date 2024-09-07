using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
{
    public class Profesor : Persona
    {
        Numero antiguedad;

        public Profesor(string nombre, Numero dni, Numero antiguedad) : base(nombre, dni)
        {

            this.antiguedad = antiguedad;
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algun tema");
        }

        public void escribirEnElPizzarron()
        {
            Console.WriteLine("Escribiendo en el pizzarron");
        }

    }
}
