using Practica_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            /* test
            Numero num1 = new Numero(5);
            Numero num2 = new Numero(10);
            Numero num3 = new Numero(5);
            
            Console.WriteLine($"{num1.getValor()} es igual que {num2.getValor()}: {num1.sosIgual(num2)}");
            Console.WriteLine($"{num1.getValor()} es mayor que {num2.getValor()}: {num1.sosMayor(num2)}");
            Console.WriteLine($"{num1.getValor()} es menor que {num2.getValor()}: {num1.sosMenor(num2)}");
            Console.WriteLine($"{num1.getValor()} es igual que {num3.getValor()}: {num1.sosIgual(num3)}");
            */

            Practica1 practica1 = new Practica1();
            practica1.Main();

            Console.ReadKey();
        }

        
    }
}
