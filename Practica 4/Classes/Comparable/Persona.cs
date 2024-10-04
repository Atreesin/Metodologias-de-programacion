
namespace Practica_4.Classes
{
    //EJERCICIO 11
    public abstract class Persona : Comparable
    {
        protected static string compararPor = "nombre";
        protected string nombre;
        protected Numero dni;
        

        public virtual string getNombre() { return nombre; }

        public Numero getDni() {  return dni; }

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
