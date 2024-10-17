
namespace Practica_7.Classes
{
    //EJERCICIO 11
    public abstract class Persona : Comparable
    {
        protected static string compararPor = "nombre";
        protected string nombre;
        protected Numero dni;
        

        public virtual string getNombre() { return nombre; }

        public virtual Numero getDni() {  return dni; }
        public virtual void setDni(Numero dni)
        {
            this.dni = dni;
        }

        // metodos de Comparable
        public abstract bool sosIgual(Comparable persona);

        public abstract bool sosMenor(Comparable persona);

        public abstract bool sosMayor(Comparable persona);

        

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni}";
        }
    }
}
