using Practica_4.Classes;
using System;

namespace Practica_4
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
