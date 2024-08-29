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
        
        private Numero legajo;
        private Numero promedio;

        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public Numero getLegajo() { return legajo; }
        public Numero getPromedio() {  return promedio; }
                
        //FIN EJERCICIO 15

        //EJERCICIO 18
        
        public override bool sosIgual(Comparable alumno)
        {
            
             if (this.legajo.sosIgual(((Alumno)alumno).getLegajo()))
             {
                return true;
             }
             else
             {
                return false;
             }
            
        }

        public override bool sosMenor(Comparable alumno)
        {
            if (this.legajo.sosMenor(((Alumno)alumno).getLegajo()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool sosMayor(Comparable alumno)
        {
            if (this.legajo.sosMayor(((Alumno)alumno).getLegajo()))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //FIN EJERCICIO 18

        //METODOS AUXILIARES
        public override string ToString()
        {
            return $"Alumno: \nLegajo: {this.legajo} \nNombre: {this.nombre} \nDni: {this.dni}\nPromedio:{promedio}";
        }

    }
    }
