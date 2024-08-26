using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Classes
{
    
    //EJERCICIO 15
    class Alumno : Persona
    {
        //PARAMETRO ADICIONAL DE CLASE QUE DETERMINA EL CRITERIO DE COMPARACION ENTRE ELEMENTOS DEL TIPO ALUMNO
        private static string compararAlumnosPor = "legajo";
        //********************************************************************************************
        private Numero legajo;
        private Numero promedio;

        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public Numero getLegajo() { return legajo; }
        public Numero getPromedio() {  return promedio; }

        public override string ToString()
        {
            return $"Alumno: \nLegajo: {this.legajo} \nNombre: {this.nombre} \nDni: {this.dni}\nPromedio:{promedio}";
        }
        //FIN EJERCICIO 15

        //EJERCICIO 18
        
        public override bool sosIgual(Comparable alumno)
        {
            /*EN CASO DE QUE SOLO SE PUEDAN COMPARAR POR LEGAJO
             * if (this.legajo.sosIgual(((Alumno)alumno).getLegajo()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            */
            switch (compararAlumnosPor)
            {
                case "nombre":
                    if (this.nombre == ((Alumno)alumno).getNombre())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "dni":
                    if (this.dni.sosIgual(((Alumno)alumno).getDni()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "legajo":
                    if (this.legajo.sosIgual(((Alumno)alumno).getLegajo()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }

        public override bool sosMenor(Comparable alumno)
        {
            /*EN CASO DE QUE SOLO SE PUEDAN COMPARAR POR LEGAJO
             * if (this.legajo.sosMenor(((Alumno)alumno).getLegajo()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            */
            switch (compararAlumnosPor)
            {
                case "nombre":
                    if (string.Compare(this.nombre, ((Alumno)alumno).getNombre()) < 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "dni":
                    if (this.dni.sosMenor(((Alumno)alumno).getDni()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "legajo":
                    if (this.legajo.sosMenor(((Alumno)alumno).getLegajo()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "promedio":
                    if (this.promedio.sosMenor(((Alumno)alumno).getPromedio()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
                }
            }

        public override bool sosMayor(Comparable alumno)
        {
            /*EN CASO DE QUE SOLO SE PUEDAN COMPARAR POR LEGAJO
             * if (this.legajo.sosMayor(((Alumno)alumno).getLegajo()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            */
            switch (compararAlumnosPor)
            {
                case "nombre":
                    if (string.Compare(this.nombre, ((Alumno)alumno).getNombre()) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "dni":
                    if (this.dni.sosMayor(((Alumno)alumno).getDni()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "legajo":
                    if (this.legajo.sosMayor(((Alumno)alumno).getLegajo()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "promedio":
                    if (this.promedio.sosMayor(((Alumno)alumno).getPromedio()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }
        //FIN EJERCICIO 18
        public static void setCompararAlunoPor(string criterio) 
        {
            if (criterio == "nombre" || criterio == "dni" || criterio == "promedio" || criterio == "legajo")
            {
                compararAlumnosPor = criterio;
            }
            else
            {
                compararAlumnosPor = "nombre";
            }
        }

        //
        /*no aplica
        protected int CompareTo(Object obj)
        {
            int resultado = 2;
            if (obj is Alumno)
            {
                var p = obj as Alumno;

                if (p != null)
                {
                    if (this.getLegajo().sosMenor(p.getLegajo()))
                    {
                        resultado = -1;
                    }
                    else if (this.getLegajo().sosIgual(p.getLegajo()))
                    {
                        resultado = 0;
                    }
                    else if (this.getLegajo().sosMayor(p.getLegajo()))
                    {
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    throw (new Exception("no se puede comparar el valor null"));
                }
            }
            if (obj is Persona)
            {
                var p = obj as Persona;
                
                if (p != null)
                {
                    if (this.getDni().sosMenor(p.getDni()))
                    {
                        resultado = -1;
                    }
                    else if (this.getDni().sosIgual(p.getDni()))
                    {
                        resultado = 0;
                    }
                    else if (this.getDni().sosMayor(p.getDni()))
                    {
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    throw (new Exception("no se puede comparar el valor null"));
                }
            }
            else if (obj is Numero)
            {
                var p = obj as Numero;


                if (p != null)
                {
                    if (this.getLegajo().sosMenor(p))
                    {
                        resultado = -1;
                    }
                    else if (this.getLegajo().sosIgual(p))
                    {
                        resultado = 0;
                    }
                    else if (this.getLegajo().sosMayor(p))
                    {
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    throw (new Exception("no se puede comparar el valor null"));
                }
            }
            else
            {
                throw (new Exception("El elemento no es una persona o un numero"));
            }
        }
        */
        }
    }
