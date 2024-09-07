using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public static class LectorDeDatos
    {
        public static Numero numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero:");
            Numero numero = new Numero(comprobarEntero());
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
