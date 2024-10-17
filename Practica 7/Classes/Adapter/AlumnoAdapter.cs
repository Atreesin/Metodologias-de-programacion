using MetodologíasDeProgramaciónI;


namespace Practica_7.Classes
{
    public class AlumnoAdapter : Student
    {
        protected IAlumno alumno;

        public AlumnoAdapter(IAlumno alumno) : base()
        {
            this.alumno = alumno;
        }

        public IAlumno getAlumno() { return alumno; }

        public string getName()
        {
            return alumno.getNombre();
        }

        public bool equals(Student student)
        {
            return alumno.sosIgual(((AlumnoAdapter)student).alumno);
        }

        public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((AlumnoAdapter)student).alumno);
        }

        public bool lessThan(Student student)
        {
            return alumno.sosMenor(((AlumnoAdapter)student).alumno);
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

        public override string ToString()
        {
            return alumno.ToString();
        }
    }
}
