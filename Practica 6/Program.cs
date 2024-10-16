using MetodologíasDeProgramaciónI;
using Practica_6.Classes;
using Practica_6.Classes.Adapter;
using Practica_6.Classes.Command;
using Practica_6.Classes.Decorator;
using Practica_6.Classes.Factory;
using Practica_6.Classes.Proxy;
using Practica_6.Classes.Template;
using Practica_6.Interfaces;
using System;
using System.Runtime.InteropServices;


namespace Practica_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Juan");
            Jugador jugador2 = new Jugador("Pablo");
            JuegoDeCartas juego;
            while (jugador1.getVictorias() < 3 && jugador2.getVictorias() < 3)
            {
                juego = new CuloSucio(jugador1, jugador2);
                juego.jugar();
            }
            if (jugador1.getVictorias() == 3)
            {
                Console.WriteLine($"Tenemos un ganador:\n{jugador1}");
            }
            else
            {
                Console.WriteLine($"Tenemos un ganador:\n{jugador2}");
            }

            juego = new Jodete(jugador1, jugador2);
            juego.jugar();

            

            Student student;
            Teacher teacher= new Teacher();
            IAlumno alumno;
            Pila pila = new Pila();
            IterableAdapter listOfStudents = new IterableAdapter(pila);
            teacher.setStudents(listOfStudents);
            for (int i = 1; i <= 20; i++)
            {
                /*
                if (i <= 10)
                {
                    alumno = FabricaDeAlumnos.CrearAleatorio(4);
                }
                else
                {
                    alumno = FabricaDeAlumnos.CrearAleatorio(6);
                }
                */
                alumno = FabricaDeAlumnos.CrearAleatorio(7);
                alumno.setCriterio(new PorCalificacion());

                /*
                alumno = FabricaDeAlumnos.CrearDecorado(1, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(2, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(3, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(4, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(5, alumno);
                */
                student = FabricaDeAlumnos.CrearAdaptado(alumno);
                
                teacher.goToClass(student);
            }

            teacher.teachingAClass();

            imprimirElementos(listOfStudents);
            Console.WriteLine("Pulsar una tecla para el ejercicio 10");
            Console.ReadKey();

            /****       EJERCICIO 10        ****/
            Pila pila2 = new Pila();
            Aula aula = new Aula();

            pila2.setOrdenInicio(new OrdenInicio(aula));
            pila2.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila2.setOrdenAulaLlena(new OrdenAulaLlena(aula));

            llenar(pila2, 1);
            llenar(pila2, 3);

            /**    **/
            ColeccionableProxy coleccionable = new ColeccionableProxy(1);

            Console.WriteLine("cuantos: " + coleccionable.cuantos());
            Console.WriteLine("minimo: " + coleccionable.minimo());
            Console.WriteLine("maximo: " + coleccionable.maximo());

            coleccionable.agregar(new Numero(5));

            coleccionable.agregar(new Numero(3));
            coleccionable.agregar(new Numero(8));

            Console.WriteLine("cuantos: " + coleccionable.cuantos());
            Console.WriteLine("minimo: " + coleccionable.minimo());
            Console.WriteLine("maximo: " + coleccionable.maximo());

            Numero num = new Numero(15);
            coleccionable.agregar(num);
            Console.WriteLine("minimo: " + coleccionable.minimo());
            Console.WriteLine("maximo: " + coleccionable.maximo());
            
            Console.ReadKey();

        }

        /// <summary>
        /// Recibe un coleccionable y lo llena con 20 alumnos del tipo seleccionado.
        /// 
        /// <list type="bullet">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - AlumnoNormal</description>
        /// </item>
        /// <item>
        /// <description>2 - AlumnoFavorito</description>
        /// </item>
        /// <item>
        /// <description>3 - AlumnoMuyEstudiosoProxy</description>
        /// </item>
        /// <item>
        /// <description>4 - AlumnoNormalProxy</description>
        /// </item>
        /// <item>
        /// <description>5 - AlumnoFavoritoProxy</description>
        /// </item>
        /// <item>
        /// <description>6 - AlumnoMuyEstudiosoProxy</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="coleccionable">Conjunto a llenar</param>
        /// <param name="opcion">Tipo de Alumno elegido</param>
        public static void llenar(Coleccionable coleccionable, int opcion)
        {

            if (coleccionable is ColeccionMultiple)
            {

                Pila pila = new Pila();
                Cola cola = new Cola();
                for (int i = 0; i < 20; i++)
                {
                    Comparable comparable1 = FabricaDeAlumnos.CrearAleatorio(opcion);
                    Comparable comparable2 = FabricaDeAlumnos.CrearAleatorio(opcion);
                    pila.agregar(comparable1);
                    cola.agregar(comparable2);
                }
                coleccionable = new ColeccionMultiple(pila, cola);
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Comparable comparable = FabricaDeAlumnos.CrearAleatorio(opcion);

                    coleccionable.agregar(comparable);
                }
            }

        }

        public static void imprimirElementos(Collection c)
        {
            IteratorOfStudent iterador = c.getIterator();
            
            string conjunto = "";
            
            while (!iterador.end())
            {
                conjunto += $"{iterador.current()}\n";
                iterador.next();
            }
            Console.WriteLine($"{conjunto}");
        }
    }
}
