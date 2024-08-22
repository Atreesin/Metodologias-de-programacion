using Practica_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Practica1
    {
        private static Random unicoRandomGlobal = new Random();
        private List<string> nombres = new List<string>() 
        { 
            "Lucía","Sofía","Martina","María","Paula","Julia","Emma",
            "Valeria","Daniela","Alba","Sara","Carla","Carmen","Noa",
            "Claudia","Valentina","Alma","Vega","Ana","Olivia","Hugo",
            "Lucas","Martín","Daniel","Pablo","Mateo","Alejandro",
            "Leo","Álvaro","Manuel","Adrián","David","Mario","Diego",
            "Enzo","Marco","Javier","Marcos","Izan","Antonio"
        };
        private List<string> apellidos = new List<string>()
        {
            "García", "Martínez", "López", "Pérez", "Gómez", "Hernández",
            "Sánchez", "Ramírez", "Torres", "Flores", "Gutiérrez", "Moreno",
            "Álvarez", "Vásquez", "Mendoza", "Jiménez", "Ruiz", "Castro",
            "Morales", "Ríos", "Vega", "Cano", "Ortega", "Cruz",
            "Jaramillo", "Orozco", "Salazar", "Cordero", "Paniagua", "Pineda",
            "Castilla", "Garcés", "Díaz", "Pantoja", "Téllez", "Peña"
        };
        private string separador = "***************************************************************";

        public void Main()
        {
            //EJERCICIO 7
            Pila pila = new Pila();
            Cola cola = new Cola();
            /*
            Error CS0120  Se requiere una referencia de objeto para el campo, método o propiedad 'Program.llenar(Coleccionable)' no estáticos Practica 1  C: \Users\atree\Desktop\ingenieria informatica\Metodologias de Programacion I\Clase 1\codigo\Practica 1\Practica 1\Program.cs    32  Activo
            */
            Console.WriteLine("llenando pila");
            llenar(pila);
            Console.WriteLine("llenando cola");
            llenar(cola);
            Console.WriteLine("Informar pila:");
            informar(pila);
            Console.WriteLine("Informar cola:");
            informar(cola);
            //FIN DE EJERCICIO 7
            Console.WriteLine(separador);

            //EJERCICIO 9
            Console.WriteLine("Instanciando coleccion multiple:");
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            Console.WriteLine("Informar coleccion multiple:");
            informar(multiple);
            Console.WriteLine(separador);
            //EJERCICIO 10
            //no tuve que modificar nada ya que utilize funciones de las clases creadas anteriormente

            /*
            Console.WriteLine($"Cantidad de nombres: {nombres.Count}");
            Console.WriteLine($"Cantidad de apellidos: {apellidos.Count}");
            
            Console.WriteLine($"Cantidad de nombres: {nombres[15]}");
            */

            //EJERCICIO 13
            Pila pilaDePersonas = new Pila();
            Cola colaDePersonas = new Cola();
            Console.WriteLine("Instanciando coleccion multiple:");
            ColeccionMultiple multipleDePersonas = new ColeccionMultiple(pilaDePersonas, colaDePersonas);
            Console.WriteLine("Informar coleccion multiple:");
            Console.WriteLine("llenando pila");
            llenarPersonas(pilaDePersonas);
            Console.WriteLine("llenando cola");
            llenarPersonas(colaDePersonas);
            informar(multipleDePersonas);
            Console.WriteLine(separador);

            /*EJERCICIO 14
             * 
             * En cuanto a las clases anteriores no fue necesario hacer ninguna modificacion
             * pero si fue necesario instanciar una pila exclusiva para almacenar
             * personas ya que si bien se pueden almacenar tanto personas como numeros
             * al momento de comparar los elementos en la pila y la cola si bien ambos son comparables no seria algo logico
             * pero al momento de comparar decidi implementar que al momento de utilizar las funciones
             * sosMayor(), sosMenor() y sosIgual() puedan recibir un comparable, 
             * y si el objeto que recibe es de tipo Persona haga la comparacion directa
             * pero si el objeto recibido es de tipo Numero 
             * lo interprete como un dni porque sino deberia implementar el cambio en la funcion informar()...
             * si bien se podria hacer esta modificacion.. no creo que sea logico ya que
             * esta funcion no es exclusiva para elementos de tipo Persona
             */

            //EJERCICIO 17
            /*si, funciono y no fue necesario decir explicitamente que Alumno tiene que implementar la interfaz comparable
             * el criterio para comparar a los alumnos fue por dni, el mismo utilizado para comparar personas
             * ya que estos tambien son personas
             */
            Pila pilaDeAlumnos = new Pila();
            Cola colaDeAlumnos = new Cola();
            Console.WriteLine("Instanciando coleccion multiple de Alumnos:");
            ColeccionMultiple multipleDeAlumnos = new ColeccionMultiple(pilaDeAlumnos, colaDeAlumnos);
            Console.WriteLine("Informar coleccion multiple:");
            Console.WriteLine("llenando pila");
            llenarAlumnos(pilaDeAlumnos);
            Console.WriteLine("llenando cola");
            llenarAlumnos(colaDeAlumnos);
            informar(multipleDeAlumnos);
            Console.WriteLine(separador);

            //EJERCICIO 19
            /*Si, se podria haber hecho esto miso sin interfaces
             *pero no se podrian haber utilizado un mismo metodo para tratar a los distintos elementos como por ejemplo
             *llenar(coleccionable), informar(coleccionable), etc
             *tendriamos que haber sobrecargado los metodos para cada elemento
             *y tendriamos metodos para cada elemento como por ejemplo
             *llenar(pila) llenar(cola)
             *informar(pila), informar(cola), informar(coleccionmultiple), etc
             *y esto llevaria demaciadas lineas de codigo que realiza la misma tarea
             */
        }

        //EJERCICIO 5
        public void llenar(Coleccionable coleccionable)
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
        public void informar(Coleccionable coleccionable)
        {
            Console.WriteLine($"El Coleccionable tiene {coleccionable.cuantos()} elementos comparables");
            Console.WriteLine($"El Comparable de menor valor de la coleccion es: {coleccionable.minimo()}");
            Console.WriteLine($"El Comparable de mayor valor de la coleccion es: {coleccionable.maximo()}");
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

        //EJERCICIO 12
        public void llenarPersonas(Coleccionable personas)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = $"{nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]} {apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]}";
                Numero dni = new Numero((new NumeroRandom(unicoRandomGlobal)).RandomUnico(10000000, 100000000));
                                
                Persona persona = new Persona(nombre, dni);
                Console.WriteLine(persona + " ");
                personas.agregar(persona);
            }
            Console.WriteLine("");
        }

        //EJERCICIO 16
        public void llenarAlumnos(Coleccionable alumnos)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = $"{nombres[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(40)]} {apellidos[(new NumeroRandom(unicoRandomGlobal)).RandomUnico(36)]}";
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
        int ingresarEntero()
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
    }
}
