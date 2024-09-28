using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Classes
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
                return this.dni.sosIgual(((Persona)persona).getDni());
            }
            else
            {
                return (this.nombre == ((Persona)persona).getNombre());
            }
        }

        public virtual bool sosMenor(Comparable persona)
        {
            if (compararPor == "dni")
            {
                return this.dni.sosMenor(((Persona)persona).getDni());
            }
            else
            {
                return (string.Compare(this.nombre, ((Persona)persona).getNombre()) < 0);
            }
        }

        public virtual bool sosMayor(Comparable persona)
        {
            if (compararPor == "dni")
            {
                return this.dni.sosMayor(((Persona)persona).getDni());
            }
            else
            {
                return (string.Compare(this.nombre, ((Persona)persona).getNombre()) > 0);
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

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni}";
        }
    }
}
