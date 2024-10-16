using System;


namespace Practica_5.Classes
{
    public class NumeroRandom
    {
        private Random randomUnicoDeInstancia = new Random();

        public NumeroRandom(Random r = null)
        {
            if (r != null)
                randomUnicoDeInstancia = r;
        }

        public int RandomUnico()
        {
            return randomUnicoDeInstancia.Next(100);
        }

        public int RandomUnico(int rango)
        {
            return randomUnicoDeInstancia.Next(rango);
        }
        public int RandomUnico(int min, int max)
        {
            return randomUnicoDeInstancia.Next(min, max);
        }
    }
}
