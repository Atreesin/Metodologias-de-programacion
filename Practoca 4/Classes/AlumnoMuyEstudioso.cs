using Practica_4;
using Practica_4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practoca_4.Classes
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni, legajo, promedio)
        {
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }
    }
}
