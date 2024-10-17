using Practica_7.Interfaces;


namespace Practica_7.Classes
{
    public abstract class AlumnoDecorator : IAlumno
    {
        protected IAlumno adicional;

        

        /**       geters      **/
        public override string getNombre(){ return adicional.getNombre(); }
        public override bool getTiroAvion() { return adicional.getTiroAvion(); }
        public override int getCalificacion() { return adicional.getCalificacion(); }
        public override Estrategia getCriterio() { return adicional.getCriterio(); }
        public override Numero getLegajo() { return adicional.getLegajo(); }
        public override Numero getPromedio() { return adicional.getPromedio(); }

        /**       seters      **/
        public override void setCalificacion(int calificacion) { adicional.setCalificacion((int) calificacion); }
        public override void setCriterio(Estrategia c){ adicional.setCriterio(c); }

        /**       IObservado      **/
        public override void agregarObservador(IObservador observador)
        {
            adicional.agregarObservador(observador);
        }
        public override void quitarObservador(IObservador observador)
        {
            adicional.quitarObservador(observador);
        }
        public override void notificar()
        {
            adicional.notificar();
        }

        /**       IObservador      **/
        public override void actualizar(IObservado observado)
        {
            adicional.actualizar(observado);
        }

        /**       IAlumno      **/
        public override void prestarAtencion()
        {
            adicional.prestarAtencion();
        }
        public override void distraerse()
        {
            adicional.distraerse();
        }

        public override string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }
        public override int responderPregunta(int pregunta)
        {
            return adicional.responderPregunta(pregunta);
        }


        
        /**       Comparable      **/
        public override bool sosIgual(Comparable alumno)
        {
            return adicional.sosIgual(alumno);
        }
        public override bool sosMayor(Comparable alumno)
        {
            return adicional.sosMayor(alumno);
        }
        public override bool sosMenor(Comparable alumno)
        {
            return adicional.sosMenor(alumno);
        }

        public override string ToString()
        {
            return adicional.ToString();
        }

        

    }
}
