using Practica_3.Classes;
using Practica_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class program
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
            /* Fabrica
             * opciones:
             * Numero = 1
             * NumeroDni = 2
             * NumeroLegajo = 3
             * NumeroPromedio = 4
             * Alumno = 5
             * ClaveValor = 6
             * Profesor = 7
             */
            //PARA LLENAR DICCIONARIOS ES NECESARIO USAR LA OPCION 6
            /*
            Pila pilaNumeros = new Pila();
            Cola colaNumeros = new Cola();
            Pila pilaAlumnos = new Pila();
            Cola colaAlumnos = new Cola();
            ColeccionMultiple coleccionMultipleNumeros = new ColeccionMultiple(pilaNumeros, colaNumeros);
            ColeccionMultiple coleccionMultipleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();

            llenar(pilaNumeros, 1);
            llenar(colaNumeros, 1);
            llenar(coleccionMultipleNumeros, 1);
            llenar(pilaAlumnos, 5);
            llenar(colaAlumnos, 5);
            llenar(coleccionMultipleAlumnos, 5);
            llenar(conjunto, 5);
            llenar(diccionario, 6);

            informar(pilaNumeros, 1);
            informar(colaNumeros, 1);
            informar(coleccionMultipleNumeros, 1);
            informar(pilaAlumnos, 5);
            informar(colaAlumnos, 5);
            informar(coleccionMultipleAlumnos, 5);
            informar(conjunto, 5);
            informar(diccionario, 6);
            */

            //****************************************************
            Profesor profesor = (Profesor)FabricaDeComparables.crearAleatorio(7);

            Pila pila = new Pila();
            llenar(pila, 5);
            AlumnoFavorito favorito = new AlumnoFavorito("Pepito Favorito", (Numero)FabricaDeComparables.crearAleatorio(2), (Numero)FabricaDeComparables.crearAleatorio(3), new Numero(10));
            agregarObservadores(profesor, pila);
            agregarObservador(favorito, pila);
            favorito.agregarObservador(profesor);
            profesor.agregarObservador(favorito);

            dictadoDeClases(profesor);

            Console.ReadKey();
        }


        public static void dictadoDeClases(Profesor profesor)
        {
            for (int i = 0; i < 5; i++)
            {
                profesor.hablarALaClase();
                profesor.escribirEnElPizzarron();
            }
        }

        //EJERCICIO 6
        public static void llenar(Coleccionable coleccionable, int opcion)
        {
            
            if (coleccionable is ColeccionMultiple)
            {
                //no estoy seguro si esta es la forma o si deberia implementar una fabrica de coleccion multiple
                Pila pila = new Pila();
                Cola cola = new Cola();
                for (int i = 0; i < 20; i++)
                {
                    Comparable comparable1 = FabricaDeComparables.crearAleatorio(opcion);
                    Comparable comparable2 = FabricaDeComparables.crearAleatorio(opcion);
                    pila.agregar(comparable1);
                    cola.agregar(comparable2);
                }
                coleccionable = new ColeccionMultiple(pila, cola);
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);

                    coleccionable.agregar(comparable);
                }
            }
            
        }

        public static void informar(Coleccionable coleccionable, int opcion)
        {
            Console.WriteLine($"La coleccion tiene {coleccionable.cuantos()} elementos");
            Console.WriteLine($"El elemento de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El elemento de mayor valor de la coleccion es: {coleccionable.maximo()}");
            Console.WriteLine("ingrese un numero:");
            
            Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
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
            Console.WriteLine(separador);
            Console.WriteLine($"La colección tiene {coleccionable.cuantos()} elementos.");
            Console.WriteLine($"El Elemento de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El Elemento de mayor valor de la coleccion es: {coleccionable.maximo()}");

            Console.ReadKey();

            Comparable dni = new Numero(0);

            Console.WriteLine("ingrese el dni:");
            dni = FabricaDeComparables.crearPorTeclado(1);

            Persona persona = new Persona("", (Numero)dni);

            if (coleccionable.contiene(persona))
            {
                Console.WriteLine($"La persona con el dni {dni} esta en la colección.");
            }
            else
            {
                Console.WriteLine($"La persona con el dni {dni} no esta en la colección.");
            }
        }

        public static void llenarPersonas(Coleccionable personas)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = $"{apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]} {nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]}";
                Numero dni = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000000, 100000000));

                Persona persona = new Persona(nombre, dni);

                personas.agregar(persona);
            }
        }

        
        public static void imprimirElementos(Iterable c)
        {
            Iterador iterador = c.crearIterador();
            iterador.anterior();
            string conjunto = "Coleccion:";
            if (c is Diccionario)
            {
                conjunto = "Diccionario:";
            }
            else if (c is Conjunto)
            {
                conjunto = "Conjunto:";
            }
            else if (c is Pila)
            {
                conjunto = "Pila:";
            }
            else if (c is Cola)
            {
                conjunto = "Cola:";
            }
            while (!iterador.fin())
            {
                if (iterador.primero())
                {
                    iterador.siguiente();
                    conjunto = $"{conjunto} [{iterador.actual()}]";
                    iterador.siguiente();
                }
                else
                {
                    conjunto = $"{conjunto}, [{iterador.actual()}]";
                    iterador.siguiente();
                }
            }
            Console.WriteLine($"[{conjunto}]");
        }

        public static void agregarObservadores(IObservado observado,Iterable c)
        {
            Iterador iterador = c.crearIterador();
            iterador.anterior();
            while (!iterador.fin())
            {
                if (iterador.primero())
                {
                    iterador.siguiente();
                    observado.agregarObservador((IObservador)iterador.actual());
                    iterador.siguiente();
                }
                else
                {
                    iterador.actual();
                    observado.agregarObservador((IObservador)iterador.actual());
                    iterador.siguiente();
                }
            }
        }

        public static void agregarObservador(IObservador observador, Iterable c)
        {
            Iterador iterador = c.crearIterador();
            iterador.anterior();
            while (!iterador.fin())
            {
                if (iterador.primero())
                {
                    iterador.siguiente();
                    ((IObservado)iterador.actual()).agregarObservador(observador);
                    iterador.siguiente();
                }
                else
                {
                    iterador.actual();
                    ((IObservado)iterador.actual()).agregarObservador(observador);
                    iterador.siguiente();
                }
            }
        }

        public static void cambiarEstrategia(Iterable coleccionable, Estrategia estrategia)
        {
            Iterador iterador = coleccionable.crearIterador();


            if (coleccionable is Diccionario)
            {
                while (!iterador.fin())
                {
                    ((Alumno)(((ClaveValor)(iterador.actual())).getValor())).setCriterio(estrategia);
                }
                iterador.siguiente();
            }
            else
            {
                while (!iterador.fin())
                {
                    ((Alumno)(iterador.actual())).setCriterio(estrategia);
                    iterador.siguiente();
                }
            }
        }

        
    }
}
