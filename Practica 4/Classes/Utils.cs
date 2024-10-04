
namespace Practica_4
{
    public static class Utils
    {
        public static string InsertarCadena(string original, string buscar, string aInsertar)
        {
            int posicion = original.IndexOf(buscar);
            if (posicion != -1)
            {
                posicion += buscar.Length;
                original = original.Insert(posicion, aInsertar);
            }
            return original;
        }

        public static string DeNumeroALetras(int numero)
        {
            string letras = "";
            switch (numero)
            {
                case 0:
                    letras = "(CERO)";
                    break;
                case 1:
                    letras = "(UNO)";
                    break;
                case 2:
                    letras = "(DOS)";
                    break;
                case 3:
                    letras = "(TRES)";
                    break;
                case 4:
                    letras = "(CUATRO)";
                    break;
                case 5:
                    letras = "(CINCO)";
                    break;
                case 6:
                    letras = "(SEIS)";
                    break;
                case 7:
                    letras = "(SIETE)";
                    break;
                case 8:
                    letras = "(OCHO)";
                    break;
                case 9:
                    letras = "(NUEVE)";
                    break;
                case 10:
                    letras = "(DIEZ)";
                    break;
            }
            return letras;
        }
    }
}
