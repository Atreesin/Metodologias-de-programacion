using Practica_2.Classes;
using Practica_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
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
            

            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            llenarDiccionario(diccionario);
            imprimirElementos(pila);
            Console.WriteLine(separador);
            imprimirElementos(cola);
            Console.WriteLine(separador);
            imprimirElementos(conjunto);
            Console.WriteLine(separador);
            imprimirElementos(diccionario);
            Console.WriteLine(separador);
            cambiarEstrategia(pila, new PorNombre());
            informarAlumnos(pila);
            Console.WriteLine(separador);
            cambiarEstrategia(pila, new PorLegajo());
            informarAlumnos(pila);
            Console.WriteLine(separador);
            cambiarEstrategia(pila, new PorPromedio());
            informarAlumnos(pila);
            Console.WriteLine(separador);
            cambiarEstrategia(pila, new PorDni());
            informarAlumnos(pila);
            Console.WriteLine(separador);


            Console.ReadKey();
        }

        
        public static void llenar(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico());
                
                coleccionable.agregar(comparable);
            }
        }

        public static void llenarDiccionario(Coleccionable diccionario)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable clave = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico());
                string nombre = $"{apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]} {nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]}";
                Numero dni = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000000, 100000000));
                Numero legajo = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000, 100000));
                Numero promedio = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(11));

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                ClaveValor claveValor = new ClaveValor(clave, alumno);
                diccionario.agregar(claveValor);
            }
        }

        
        
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
            Console.WriteLine(separador);
            Console.WriteLine($"La colección tiene {coleccionable.cuantos()} elementos.");
            Console.WriteLine($"El Elemento de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El Elemento de mayor valor de la coleccion es: {coleccionable.maximo()}");

            Console.ReadKey();
            

            
            Comparable dni = new Numero(0);
            
            Console.WriteLine("ingrese el dni:");
            dni = new Numero(ingresarEntero());
            
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

        public static void informarAlumnos(Coleccionable coleccionable)
        {
            Console.WriteLine(separador);
            Console.WriteLine($"La colección tiene {coleccionable.cuantos()} elementos.");
            Console.WriteLine($"El Elemento de menor {((Alumno)coleccionable.minimo()).getCriterio()} de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El Elemento de mayor {((Alumno)coleccionable.minimo()).getCriterio()} de la coleccion es: {coleccionable.maximo()}");

            Console.ReadKey();
            
            Alumno alumno;
            if (((Alumno)coleccionable.minimo()).getCriterio() is PorNombre)
            {
                Console.WriteLine($"ingrese {((Alumno)coleccionable.minimo()).getCriterio()}:");
                Numero aux = new Numero(0);
                string nombre = Console.ReadLine();
                alumno = new Alumno(nombre, aux, aux, aux);
                alumno.setCriterio(new PorNombre());
                if (coleccionable.contiene(alumno))
                {
                    Console.WriteLine($"La persona con el {alumno.getCriterio()} {nombre} está en la colección.");
                }
                else
                {
                    Console.WriteLine($"La persona con el {alumno.getCriterio()} {nombre} no está en la colección.");
                }
            }
            else
            {
                Console.WriteLine($"ingrese {((Alumno)coleccionable.minimo()).getCriterio()}:");
                Numero buscando = new Numero(ingresarEntero());

                alumno = new Alumno("", buscando, buscando, buscando);
                alumno.setCriterio(((Alumno)coleccionable.minimo()).getCriterio());
                if (coleccionable.contiene(alumno))
                {
                    Console.WriteLine($"La persona con el {alumno.getCriterio()} {buscando} está en la colección.");
                }
                else
                {
                    Console.WriteLine($"La persona con el {alumno.getCriterio()} {buscando} no está en la colección.");
                }
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

        
        public static void llenarAlumnos(Coleccionable alumnos)
        {
            
            for (int i = 0; i < 20; i++)
            {
                string nombre = $"{apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]} {nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]}";
                Numero dni = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000000, 100000000));
                Numero legajo = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000, 100000));
                Numero promedio = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(11));

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);

                alumnos.agregar(alumno);
            }
        }

        //EJERCICIO  7
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
            else if(c is Pila)
            {
                conjunto = "Pila:";
            }
            else if( c is Cola)
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

        //EJERCIICIO 9
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
