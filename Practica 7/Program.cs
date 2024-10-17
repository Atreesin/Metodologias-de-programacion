using MetodologíasDeProgramaciónI;
using Practica_7.Classes;
using Practica_7.Classes.Adapter;
using Practica_7.Classes.Chain_of_Responsability;
using Practica_7.Classes.Factory;
using System;


namespace Practica_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            Teacher teacher= new Teacher();
            IAlumno alumno;
            
            for (int i = 1; i <= 5; i++)
            {
                
                alumno = FabricaDeAlumnos.CrearAleatorio(1);
                alumno.setCriterio(new PorCalificacion());

                alumno = FabricaDeAlumnos.CrearDecorado(1, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(2, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(3, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(4, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(5, alumno);

                student = FabricaDeAlumnos.CrearAdaptado(alumno);

                teacher.goToClass(student);
            }
            
            for (int i = 1; i <= 2; i++)
            {
                
                alumno = FabricaDeAlumnos.CrearPorTeclado(3);
                alumno.setCriterio(new PorCalificacion());

                alumno = FabricaDeAlumnos.CrearDecorado(1, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(2, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(3, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(4, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(5, alumno);

                student = FabricaDeAlumnos.CrearAdaptado(alumno);

                teacher.goToClass(student);
            }

            for (int i = 1; i <= 20; i++)
            {
                
                alumno = FabricaDeAlumnos.CrearDesdeArchivo(7);
                alumno.setCriterio(new PorCalificacion());

                student = FabricaDeAlumnos.CrearAdaptado(alumno);
                
                teacher.goToClass(student);
            }

            teacher.teachingAClass();

            Console.WriteLine("Pulsar una tecla para salir");
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
