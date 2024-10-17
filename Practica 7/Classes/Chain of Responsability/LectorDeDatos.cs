using Practica_7.Classes.Chain_of_Responsability;
using System;


namespace Practica_7
{
    public class LectorDeDatos : Manejador
    {
        public LectorDeDatos(Manejador m) : base(m) { }

        public override int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = comprobarEntero();
            return numero;
        }

        public override string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un string:");
            return Console.ReadLine();
        }

        private int comprobarEntero()
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
