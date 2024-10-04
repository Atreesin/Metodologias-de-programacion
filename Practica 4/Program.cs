using MetodologíasDeProgramaciónI;
using Practica_4.Classes;
using Practica_4.Classes.Adapter;
using Practica_4.Classes.Decorator;
using Practica_4.Classes.Factory;
using Practica_4.Interfaces;
using System;


namespace Practica_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            Teacher teacher= new Teacher();
            IAlumno alumno;
            Pila pila = new Pila();
            IterableAdapter listOfStudents = new IterableAdapter(pila);
            teacher.setStudents(listOfStudents);
            for (int i = 1; i <= 20; i++)
            {
                if (i <= 10)
                {
                    alumno = (AlumnoNormal)FabricaDeAlumnos.CrearAleatorio(1);
                }
                else
                {
                    alumno = (AlumnoMuyEstudioso)FabricaDeAlumnos.CrearAleatorio(3);
                }
                alumno.setCriterio(new PorCalificacion());

                
                alumno = FabricaDeAlumnos.CrearDecorado(1, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(2, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(3, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(4, alumno);
                alumno = FabricaDeAlumnos.CrearDecorado(5, alumno);
                student = FabricaDeAlumnos.CrearAdaptado(alumno);
                
                teacher.goToClass(student);
            }

            teacher.teachingAClass();

            imprimirElementos(listOfStudents);
            Console.ReadKey();




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
