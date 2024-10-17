using Practica_7.Classes;
using Practica_7.Classes.Chain_of_Responsability;
using System;

namespace Practica_7
{
    public class GeneradorDeDatosAleatorios : Manejador
    {
        private static GeneradorDeDatosAleatorios unicoGenerador;

        private static Random unicoRandomGlobal;

        private GeneradorDeDatosAleatorios(Manejador m) : base(m)
        {
            unicoRandomGlobal = new Random();
        }

        public static GeneradorDeDatosAleatorios getInstance(Manejador m)
        {
            if (unicoGenerador == null)
            {
                unicoGenerador = new GeneradorDeDatosAleatorios(m);
            }
            return unicoGenerador;
        }

        public override int numeroAleatorio(int max)
        {
            return new NumeroRandom(unicoRandomGlobal).RandomUnico(max);
        }

        public override int numeroAleatorioSinLimite()
        {
            return new NumeroRandom(unicoRandomGlobal).RandomUnicoSinLimite();
        }

        public override string stringAleatorio(int cantidad)
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
