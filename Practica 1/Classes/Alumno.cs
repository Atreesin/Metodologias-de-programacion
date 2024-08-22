using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Classes
{
    //EJERCICIO 15
    class Alumno : Persona, Comparable
    {
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
            return $"Alumno: \nLegajo: {this.legajo} \nNombre: {this.nombre} Dni: {this.dni}\nPromedio:{promedio}";
        }

        //EJERCICIO 18
        //Esta vez fue necesario decir explicitamente que alumno implementa la interfaz comparable
        public bool sosIgual(Comparable alumno)
        {
            if (this.CompareTo(alumno) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable alumno)
        {
            if (this.CompareTo(alumno) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable alumno)
        {
            if (this.CompareTo(alumno) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //
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
    }
}
