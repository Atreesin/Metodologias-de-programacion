using Practica_3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public static class GeneradorDeDatosAleatorios
    {
        //posiblemente estoy utilizando mal Random y hay una forma mas facil de utilizarlo
        private static Random unicoRandomGlobal = new Random();
        public static int numeroAleatorio(int max)
        {
            return new NumeroRandom(unicoRandomGlobal).RandomUnico(max);
        }

        public static string stringAleatorio(int cantidad)
        {
            int numeroDeLetra;
            string stringAleatorio = "";
            for (int i = 0; i < cantidad; i++)
            {
                numeroDeLetra = new NumeroRandom(unicoRandomGlobal).RandomUnico(26);
                stringAleatorio += (char)('a' + numeroDeLetra);
            }
            return stringAleatorio;
        }     
    }
}
