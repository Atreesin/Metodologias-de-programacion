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
        public virtual bool sosIgual(Comparable persona)
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

        public virtual bool sosMenor(Comparable persona)
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

        public virtual bool sosMayor(Comparable persona)
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

        

        //metodos auxiliares

        

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni}";
        }
    }
}
