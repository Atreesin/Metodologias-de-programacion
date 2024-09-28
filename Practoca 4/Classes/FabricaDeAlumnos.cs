using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practoca_4.Classes
{
    public abstract class FabricaDeAlumnos
    {
        protected static List<string> nombres = new List<string>()
        {
            "Lucía","Sofía","Martina","María","Paula","Julia","Emma",
            "Valeria","Daniela","Alba","Sara","Carla","Carmen","Noa",
            "Claudia","Valentina","Alma","Vega","Ana","Olivia","Hugo",
            "Lucas","Martín","Daniel","Pablo","Mateo","Alejandro",
            "Leo","Álvaro","Manuel","Adrián","David","Mario","Diego",
            "Enzo","Marco","Javier","Marcos","Izan","Antonio"
        };
        protected static List<string> apellidos = new List<string>()
        {
            "García", "Martínez", "López", "Pérez", "Gómez", "Hernández",
            "Sánchez", "Ramírez", "Torres", "Flores", "Gutiérrez", "Moreno",
            "Álvarez", "Vásquez", "Mendoza", "Jiménez", "Ruiz", "Castro",
            "Morales", "Ríos", "Vega", "Cano", "Ortega", "Cruz",
            "Jaramillo", "Orozco", "Salazar", "Cordero", "Paniagua", "Pineda",
            "Castilla", "Garcés", "Díaz", "Pantoja", "Téllez", "Peña"
        };

        public const int ALUMNO = 1;
        public const int ALUMNOFAVORITO = 2;
        public const int ALUMNOMUYESTUDIOSO = 3;
        public const int ALUMNOADAPTADO = 4;

        public static int FabricaPorDefecto = ALUMNO;

        public static Comparable crearComparableAleatorioPreseteado()
        {
            return crearAleatorio(FabricaPorDefecto);
        }

        public static Comparable crearComparablePorTecladoPreseteado()
        {
            return crearPorTeclado(FabricaPorDefecto);
        }

        public static Comparable crearAleatorio(int opcion)
        {

            FabricaDeAlumnos fabrica = null;

            switch (opcion)
            {
                case ALUMNO:
                    fabrica = new FabricaDeAlumnoAleatorio();
                    break;
                case ALUMNOFAVORITO:
                    fabrica = new FabricaDeAlumnoAleatorio();
                    break;
                case ALUMNOMUYESTUDIOSO:
                    fabrica = new FabricaDeAlumnoAleatorio();
                    break;
                case ALUMNOADAPTADO:
                    fabrica = new FabricaDeAlumnoAleatorio();
                    break;
            }

            return fabrica.crearComparable();
        }

        public static Comparable crearPorTeclado(int criterio)
        {
            FabricaDeComparables fabrica = null;

            switch (criterio)
            {
                case NUMERO:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case NUMERODNI:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case NUMEROPROMEDIO:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case NUMEROLEGAJO:
                    fabrica = new FabricaDeNumeroPorTeclado();
                    break;
                case ALUMNO:
                    fabrica = new FabricaDeAlumnoPorTeclado();
                    break;
                case CLAVEVALOR:
                    fabrica = new FabricaDeClaveValorPorTeclado();
                    break;
                case PROFESOR:
                    fabrica = new FabricaDeProfesorPorTeclado();
                    break;
            }

            return fabrica.crearComparable();
        }

        public abstract Comparable crearComparable();
    }
}
