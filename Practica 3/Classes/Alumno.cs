using Practica_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
{

    //EJERCICIO 15
    public class Alumno : Persona
    {
        //PARAMETRO QUE DETERMINA EL CRITERIO DE COMPARACION ENTRE ELEMENTOS DEL TIPO ALUMNO
        private Estrategia criterio = new PorNombre();
        //********************************************************************************************
        private Numero legajo;
        private Numero promedio;

        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public Numero getLegajo() { return legajo; }
        public Numero getPromedio() { return promedio; }



        public override bool sosIgual(Comparable alumno)
        {
            return this.criterio.sosIgual(this, alumno);
        }

        public override bool sosMenor(Comparable alumno)
        {
            return this.criterio.sosMenor(this, alumno);
        }

        public override bool sosMayor(Comparable alumno)
        {
            return this.criterio.sosMayor(this, alumno);
        }
        


        public void setCriterio(Estrategia c)
        {
            this.criterio = c;
        }
        public  Estrategia getCriterio()
        {
            return this.criterio;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Dni: {this.dni} Legajo: {this.legajo} Promedio:{promedio}";
        }
    }
}
