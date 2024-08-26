using Practica_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
        private static Random unicoRandomGlobal = new Random();
        private static List<string> nombres = new List<string>()
        {
            "Lucía","Sofía","Martina","María","Paula","Julia","Emma",
            "Valeria","Daniela","Alba","Sara","Carla","Carmen","Noa",
            "Claudia","Valentina","Alma","Vega","Ana","Olivia","Hugo",
            "Lucas","Martín","Daniel","Pablo","Mateo","Alejandro",
            "Leo","Álvaro","Manuel","Adrián","David","Mario","Diego",
            "Enzo","Marco","Javier","Marcos","Izan","Antonio"
        };
        private static List<string> apellidos = new List<string>()
        {
            "García", "Martínez", "López", "Pérez", "Gómez", "Hernández",
            "Sánchez", "Ramírez", "Torres", "Flores", "Gutiérrez", "Moreno",
            "Álvarez", "Vásquez", "Mendoza", "Jiménez", "Ruiz", "Castro",
            "Morales", "Ríos", "Vega", "Cano", "Ortega", "Cruz",
            "Jaramillo", "Orozco", "Salazar", "Cordero", "Paniagua", "Pineda",
            "Castilla", "Garcés", "Díaz", "Pantoja", "Téllez", "Peña"
        };
        private static string separador = "***************************************************************";

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

            //EJERCICIO 7
            Pila pila = new Pila();
            Cola cola = new Cola();
            
            Console.WriteLine("llenando pila");
            llenar(pila);
            Console.WriteLine("llenando cola");
            llenar(cola);
            Console.WriteLine(separador);
            Console.WriteLine("Informar pila:");
            informar(pila);
            Console.WriteLine(separador);
            Console.WriteLine("Informar cola:");
            informar(cola);
            //FIN DE EJERCICIO 7
            Console.WriteLine(separador);
            Console.ReadKey();
            

            //EJERCICIO 9
            Console.Clear();
            Console.WriteLine(separador);
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            Console.WriteLine("Informar coleccion multiple:");
            informar(multiple);
            Console.WriteLine(separador);
            Console.ReadKey();
            
            /*test
            Console.WriteLine($"Cantidad de nombres: {nombres.Count}");
            Console.WriteLine($"Cantidad de apellidos: {apellidos.Count}");
            
            Console.WriteLine($"Cantidad de nombres: {nombres[15]}");
            */

            //EJERCICIO 13
            Pila pilaDePersonas = new Pila();
            Cola colaDePersonas = new Cola();

            ColeccionMultiple multipleDePersonas = new ColeccionMultiple(pilaDePersonas, colaDePersonas);
            
            Console.WriteLine("llenando pila");
            llenarPersonas(pilaDePersonas);

            Console.WriteLine(separador);
            Console.ReadKey();

            Console.WriteLine("llenando cola");
            llenarPersonas(colaDePersonas);

            Console.WriteLine(separador);
            Console.ReadKey();

            Console.WriteLine("Informar coleccion multiple:");
            informarPersonas(multipleDePersonas);
            Console.WriteLine(separador);
            Console.ReadKey();
            
            Pila pilaDeAlumnos = new Pila();
            Cola colaDeAlumnos = new Cola();
            ColeccionMultiple multipleDeAlumnos = new ColeccionMultiple(pilaDeAlumnos, colaDeAlumnos);
            

            Console.WriteLine(separador);
            Console.ReadKey();

            Console.WriteLine("llenando pila");
            llenarAlumnos(pilaDeAlumnos);

            Console.WriteLine(separador);
            Console.ReadKey();

            Console.WriteLine("llenando cola");
            llenarAlumnos(colaDeAlumnos);

            Console.WriteLine(separador);
            Console.ReadKey();

            Console.WriteLine("Informar coleccion multiple:");
            informarAlumnos(multipleDeAlumnos);
            Console.WriteLine(separador);

            

            Console.ReadKey();
        }

        //EJERCICIO 5
        public static void llenar(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico());
                Console.Write(comparable.ToString() + " ");
                coleccionable.agregar(comparable);
            }
            Console.WriteLine("");
        }

        //EJERCICIO 6
        
        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine($"La coleccion tiene {coleccionable.cuantos()} elementos");
            Console.WriteLine($"El elemento de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El elemento de mayor valor de la coleccion es: {coleccionable.maximo()}");
            Console.WriteLine("ingrese un numero:");
            Comparable comparable = new Numero(ingresarEntero());
            if (coleccionable.contiene(comparable))
            {
                Console.WriteLine($"El elemento {comparable} esta en la colección.");
            }
            else
            {
                Console.WriteLine($"El elemento {comparable} no esta en la colección.");
            }
        }
        

        public static void informarPersonas(Coleccionable coleccionable)
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero para elegir el criterio de comparacion:\n1 - por Nombre\n2 - por DNI");
            int opcion = ingresarEntero(1, 2);
            
            switch (opcion)
            {
                case 1:
                    Persona.setCompararPor("nombre");
                    break;
                case 2:
                    Persona.setCompararPor("dni");
                    break;
                
                default:
                    break;
            }

            Console.WriteLine($"La colección tiene {coleccionable.cuantos()} elementos.");
            Console.WriteLine($"El Elemento de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El Elemento de mayor valor de la coleccion es: {coleccionable.maximo()}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingrese un numero para elegir el criterio de busqueda:\n1 - por Nombre\n2 - por DNI");
            opcion = ingresarEntero(1, 2);

            switch (opcion)
            {
                case 1:
                    Persona.setCompararPor("nombre");
                    break;
                case 2:
                    Persona.setCompararPor("dni");
                    break;

                default:
                    break;
            }
            Comparable dni = new Numero(0);
            string nombre = "";

            if (opcion == 1)
            {
                Console.WriteLine("ingrese el nombre:");
                nombre = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ingrese el dni:");
                dni = new Numero(ingresarEntero());
            }

            Persona persona = new Persona(nombre, (Numero)dni);

            if (coleccionable.contiene(persona))
            {
                if(opcion == 1)
                {
                    Console.WriteLine($"La persona con el nombre {nombre} esta en la colección.");
                }
                else
                {
                    Console.WriteLine($"La persona con el dni {dni} esta en la colección.");
                }
                
            }
            else
            {
                if (opcion == 1)
                {
                    Console.WriteLine($"La persona con el nombre {nombre} no esta en la colección.");
                }
                else
                {
                    Console.WriteLine($"La persona con el dni {dni} no esta en la colección.");
                }
            }
        }

        public static void informarAlumnos(Coleccionable coleccionable)
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero para elegir el criterio de comparacion:\n1 - por Nombre\n2 - por DNI\n3 - por legajo\n4 - por promedio(el primero que encuentre)");
            int opcion = ingresarEntero(1, 4);

            switch (opcion)
            {
                case 1:
                    Alumno.setCompararAlunoPor("nombre");
                    break;
                case 2:
                    Alumno.setCompararAlunoPor("dni");
                    break;
                case 3:
                    Alumno.setCompararAlunoPor("legajo");
                    break;
                case 4:
                    Alumno.setCompararAlunoPor("promedio");
                    break;

                default:
                    break;
            }
            Console.WriteLine($"La colección tiene {coleccionable.cuantos()} elementos.");
            Console.WriteLine($"El Elemento de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El Elemento de mayor valor de la coleccion es: {coleccionable.maximo()}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingrese un numero para elegir el criterio de busqueda:\n1 - por Nombre\n2 - por DNI\n3 - por legajo\n4 - por promedio(el primero que encuentre)");
            opcion = ingresarEntero(1, 4);

            string nombre = "";
            Numero dni = new Numero(0);
            Numero legajo = new Numero(0);
            Numero promedio = new Numero(0);
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingrese el nombre:");
                    nombre = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("ingrese el dni:");
                    dni = new Numero(ingresarEntero());
                    break;
                case 3:
                    Console.WriteLine("ingrese el numero de legajo:");
                    legajo = new Numero(ingresarEntero());
                    break;
                case 4:
                    Console.WriteLine("ingrese el promedio (entre 0 y 10):");
                    promedio = new Numero(ingresarEntero(0,10));
                    break;

                default:
                    break;
            }

            Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
            

            if (coleccionable.contiene(alumno))
            {                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La persona con el nombre {nombre} está en la colección.");
                        break;
                    case 2:
                        Console.WriteLine($"La persona con el dni {dni} está en la colección.");
                        break;
                    case 3:
                        Console.WriteLine($"La persona con el numero de legajo {legajo} está en la colección.");
                        break;
                    case 4:
                        Console.WriteLine($"hay al menos una persona con el promedio {promedio} en la colección.");
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La persona con el nombre {nombre} no está en la colección.");
                        break;
                    case 2:
                        Console.WriteLine($"La persona con el dni {dni} no está en la colección.");
                        break;
                    case 3:
                        Console.WriteLine($"La persona con el número de legajo {legajo} no está en la colección.");
                        break;
                    case 4:
                        Console.WriteLine($"No hay ninguna persona con el promedio {promedio} en la colección.");
                        break;

                    default:
                        break;
                }
            }

        }

        //EJERCICIO 12
        public static void llenarPersonas(Coleccionable personas)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = $"{apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]} {nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]}";
                Numero dni = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000000, 100000000));

                Persona persona = new Persona(nombre, dni);
                Console.WriteLine(persona + " ");
                personas.agregar(persona);
            }
            Console.WriteLine("");
        }

        //EJERCICIO 16
        public static void llenarAlumnos(Coleccionable alumnos)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = $"{apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]} {nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]}";
                Numero dni = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000000, 100000000));
                Numero legajo = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000, 100000));
                Numero promedio = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(11));

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                Console.WriteLine(alumno + " ");
                alumnos.agregar(alumno);
            }
            Console.WriteLine("");
        }



        //METODOS AUXILIARES
        public static int ingresarEntero()
        {
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El valor ingresado es incorrecto. \nPor favor intente de nuevo:");
                num = ingresarEntero();
            }
            return num;
        }
        public static int ingresarEntero(int min, int max)
        {
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El valor ingresado es incorrecto. \nPor favor intente de nuevo:");
                num = ingresarEntero();
            }
            if (num >= min && num <= max) 
            {
                return num;
            }
            else
            {
                Console.WriteLine($"Debe ingresar un numero entre: {min} y {max}");
                return ingresarEntero(min, max);
            }
            
        }
    }
}
