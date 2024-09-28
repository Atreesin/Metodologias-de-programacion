using MetodologíasDeProgramaciónI;
using Practica_4;
using Practica_4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practoca_4.Classes
{
    public class AlumnoAdapter : Student
    {
        protected Alumno alumno;

        public AlumnoAdapter(Alumno alumno)
        {
            this.alumno = alumno;
        }

        public string getName()
        {
            return alumno.getNombre();
        }

        public bool equals(Student student)
        {
            //no estoy seguro si es asi porque si me pasan por parametro un student que no es un alumno adaptado me retornaria falso...
            //y sino deberia cambiar las estrategias o comparables para que puedan comparar students ya que un student no es un comparable
            if (student is AlumnoAdapter s)
            {
                return alumno.sosIgual(s.alumno);
            }
            else
            {
                return false;
            }
        }

        public bool greaterThan(Student student)
        {
            if (student is AlumnoAdapter s)
            {
                return alumno.sosMayor(s.alumno);
            }
            else
            {
                return false;
            }
        }

        public bool lessThan(Student student)
        {
            if (student is AlumnoAdapter s)
            {
                return alumno.sosMenor(s.alumno);
            }
            else
            {
                return false;
            }
        }

        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
    }
}
