using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Classes
{
    //EJERCICIO 11
    public class Persona : Comparable
    {
        protected static string compararPor = "nombre";
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
        public virtual bool sosIgual(Comparable persona)
        {
            if(compararPor == "dni")
            {
                if (this.dni.sosIgual(((Persona)persona).getDni()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (this.nombre == ((Persona)persona).getNombre())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

        }

        public virtual bool sosMenor(Comparable persona)
        {
            if (compararPor == "dni")
            {
                if (this.dni.sosMenor(((Persona)persona).getDni()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (string.Compare(this.nombre ,((Persona)persona).getNombre()) < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            
        }

        public virtual bool sosMayor(Comparable persona)
        {
            if (compararPor == "dni")
            {
                if (this.dni.sosMayor(((Persona)persona).getDni()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (string.Compare(this.nombre, ((Persona)persona).getNombre()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        //metodo adicional
        public static void setCompararPor(string criterio)
        {
            if (criterio == "nombre" || criterio == "dni")
            {
                compararPor = criterio;
            }
            else
            {
                compararPor = "nombre";
            }
        }

        //metodos auxiliares

        /*no aplica
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
        */

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni}";
        }
    }
}
