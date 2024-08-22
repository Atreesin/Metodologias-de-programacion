using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Classes
{
    //EJERCICIO 11
    class Persona : Comparable
    {
        protected string nombre;
        protected Numero dni;

        public Persona(string nombre, Numero dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre() { return nombre; }

        public Numero getDni() {  return dni; }

        // metodos de Comparable
        public bool sosIgual(Comparable persona)
        {
            if (this.CompareTo(persona) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable persona)
        {
            if (this.CompareTo(persona) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable persona)
        {
            if (this.CompareTo(persona) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodos auxiliares
        protected int CompareTo(Object obj)
        {
            int resultado = 2;
            if (obj is  Persona)
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
                }
                else
                {
                    throw (new Exception("no se puede comparar el valor null"));
                }
            }
            else if(obj is Numero){
                var p = obj as Numero;


                if (p != null)
                {
                    if (this.getDni().sosMenor(p))
                    {
                        resultado = -1;
                    }
                    else if (this.getDni().sosIgual(p))
                    {
                        resultado = 0;
                    }
                    else if (this.getDni().sosMenor(p))
                    {
                        resultado = 1;
                    }
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


            return resultado;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni}";
        }
    }
}
