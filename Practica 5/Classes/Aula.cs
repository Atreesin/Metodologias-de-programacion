using MetodologíasDeProgramaciónI;
using Practica_5.Classes.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Classes
{
    public class Aula
    {
        private Teacher teacher;


        public void comenzar()
        {
            Console.WriteLine("Comenzando con la clase");
            this.teacher = new Teacher();
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            this.teacher.goToClass(FabricaDeAlumnos.CrearAdaptado(alumno));
        }

        public void claseLista()
        {
            this.teacher.teachingAClass();
        }

    }
}
