using System;


namespace Practica_6
{
    public static class LectorDeDatos
    {
        public static int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = comprobarEntero();
            return numero;
        }

        public static string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un string:");
            return Console.ReadLine();
        }

        private static int comprobarEntero()
        {
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El valor ingresado es incorrecto. \nPor favor intente de nuevo:");
                num = comprobarEntero();
            }
            return num;
        }
    }
}
