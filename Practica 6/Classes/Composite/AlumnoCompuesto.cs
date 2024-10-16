using Practica_6.Classes;
using Practica_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6.Composite
{
    /// <summary>
    /// Alumno compuesto (NO SE PUEDE DECORAR CON LEGAJO)
    ///
    /// </summary>
    internal class AlumnoCompuesto : IAlumno
    {
        // Si se quiere decorar alumnos compuestos se deberia setear el legajo de el alumno compuesto
        private List<IAlumno> hijos;

        public AlumnoCompuesto()
        {
            this.hijos = new List<IAlumno>();
        }

        public void agregarHijo(IAlumno a)
        {
            hijos.Add(a);
        }

        public override string getNombre()
        {
            
            string nombre = "\nGrupo:";
            foreach (IAlumno a in hijos)
            {
                nombre += "\n\t" + a.getNombre();
            }

            return $"{nombre}\n\t";
        }

        public override int responderPregunta(int pregunta)
        {
            int res1 = 0;
            int res2 = 0;
            int res3 = 0;
            foreach (IAlumno a in hijos)
            {
                switch (a.responderPregunta(pregunta))
                {
                    case 0: res1++; break;
                    case 1: res2++; break;
                    case 2: res3++; break;
                }
            }
            int max = Math.Max(res1, Math.Max(res2, res3));

            if (res1 == max && res2 == max && res3 == max)
            {
                return GeneradorDeDatosAleatorios.numeroAleatorio(3);
            }
            else if (res1 == max && res2 == max)
            {
                return eleccionAleatoria(0, 1);
            }
            else if (res1 == max && res3 == max)
            {
                return eleccionAleatoria(0, 2);
            }
            else if (res2 == max && res3 == max)
            {
                return eleccionAleatoria(1, 2);
            }
            else if (res1 == max)
            {
                return 0;
            }
            else if (res2 == max)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public override void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
            foreach (IAlumno a in hijos)
            {
                a.setCalificacion(calificacion);
            }
        }

        public override int getCalificacion()
        {
            return this.calificacion;
        }
        public override string mostrarCalificacion()
        {
            string calificaciones = "";
            foreach (IAlumno a in hijos)
            {
               calificaciones += "\n" + a.mostrarCalificacion();
            }
            return calificaciones;
        }

        public override bool sosIgual(Comparable alumno)
        {

            foreach (IAlumno a in hijos)
            {
                if (a.sosIgual(alumno))
                {
                    return true;
                }
            }
            return false;
        }

        public override bool sosMenor(Comparable alumno)
        {
            foreach (IAlumno a in hijos)
            {
                if (!a.sosMenor(alumno))
                {
                    return false;
                }
            }
            return true;
        }

        public override bool sosMayor(Comparable alumno)
        {
            foreach (IAlumno a in hijos)
            {
                if (!a.sosMayor(alumno))
                {
                    return false;
                }
            }
            return true;
        }

        public override void distraerse()
        {
            foreach (IAlumno a in hijos)
            {
                a.distraerse();
            }
        }

        public override void setCriterio(Estrategia c)
        {
            this.criterio = c;
            foreach (IAlumno a in hijos)
            {
                a.setCriterio(c);
            }
        }

        private int eleccionAleatoria(int n1, int n2)
        {
            int random = GeneradorDeDatosAleatorios.numeroAleatorio(10);
            if (random > 5)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
    }
}
