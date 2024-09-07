using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.Classes
{

    public class Fabrica : FabricaDeComparables
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

        public const int NUMERO = 1;
        public const int NUMERODNI = 2;
        public const int NUMEROLEGAJO = 3;
        public const int NUMEROPROMEDIO = 4;
        public const int ALUMNO = 5;
        public const int CLAVEVALOR = 6;

        public static int FabricaPorDefecto = NUMERO;

        public Comparable crearComparableAleatorioPreseteado()
        {
            return crearAleatorio(FabricaPorDefecto);
        }

        public Comparable crearComparablePorTecladoPreseteado()
        {
            return crearPorTeclado(FabricaPorDefecto);
        }

        public Comparable crearAleatorio(int opcion)
        {
            
            Fabrica fabrica = null;

            switch (opcion)
            {
                case NUMERO:
                    fabrica = new FabricaDeNumeroAleatorio();
                    break;
                case NUMERODNI:
                    fabrica = new FabricaDeNumeroDniAleatorio();
                    break;
                case NUMEROPROMEDIO:
                    fabrica = new FabricaDeNumeroDniAleatorio();
                    break;
                case NUMEROLEGAJO:
                    fabrica = new FabricaDeNumeroDniAleatorio();
                    break;
                case ALUMNO:
                    fabrica = new FabricaDeAlumnoAleatorio();
                    break;
                case CLAVEVALOR:
                    fabrica = new FabricaDeClaveValorAleatorio();
                    break;
            }

            return fabrica.crearComparable();
        }

        public Comparable crearPorTeclado(int criterio)
        {
            Fabrica fabrica = null;

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
            }

            return fabrica.crearComparable();
        }

        public virtual Comparable crearComparable()
        { return null; }
       

    }


    /* ALEATORIOS */
    /**************************************************************************/
    public class FabricaDeAlumnoAleatorio : Fabrica
    {
        public override Comparable crearComparable()
        {
            //tambien se podrian generar nombres utilizando GeneradorDeDatosAleatorios.stringAleatorio(int random) pero no lo hice para que no quede un codigo tan largo

            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36).getValor()]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40).getValor()]}";
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().crearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().crearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().crearComparable());

            Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }
    }

    public class FabricaDeNumeroAleatorio : Fabrica
    {
        public override Comparable crearComparable()
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(100);
        }
    }

    public class FabricaDeNumeroDniAleatorio : Fabrica
    {
        public override Comparable crearComparable()
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(99999999);
        }
    }

    public class FabricaDeNumeroLegajoAleatorio : Fabrica
    {
        public override Comparable crearComparable()
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(99999);
        }
    }

    public class FabricaDeNumeroPromedioAleatorio : Fabrica
    {
        public override Comparable crearComparable()
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(10);
        }
    }

    public class FabricaDeClaveValorAleatorio : Fabrica
    {
        public override Comparable crearComparable()
        {
            Fabrica fabrica = new Fabrica();
            Comparable clave = fabrica.crearAleatorio(1);
            Comparable alumno = fabrica.crearAleatorio(5);
            return new ClaveValor(clave, alumno);
        }
        
    }
    /* POR TECLADO */
    /***************************************************************/
    public class FabricaDeAlumnoPorTeclado : Fabrica
    {
        public override Comparable crearComparable()
        {
            Console.WriteLine("Nombre y apellido:");
            string nombre = LectorDeDatos.stringPorTeclado();
            Console.WriteLine("Dni:");
            Numero dni = (Numero)new FabricaDeNumeroPorTeclado().crearComparable();
            Console.WriteLine("Legajo:");
            Numero legajo = (Numero)new FabricaDeNumeroPorTeclado().crearComparable();
            Console.WriteLine("Promedio:");
            Numero promedio = (Numero)new FabricaDeNumeroPorTeclado().crearComparable();

            Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }
    }

    public class FabricaDeNumeroPorTeclado : Fabrica
    {
        public override Comparable crearComparable()
        {
           return LectorDeDatos.numeroPorTeclado();
        }
    }

    public class FabricaDeClaveValorPorTeclado : Fabrica
    {
        public override Comparable crearComparable()
        {
            Fabrica fabrica = new Fabrica();
            Console.WriteLine("ingrese clave:");
            Comparable clave = fabrica.crearPorTeclado(1);
            Console.WriteLine("ingresar datos de Alumno:");
            Comparable alumno = fabrica.crearPorTeclado(5);
            return new ClaveValor(clave, alumno);
        }
    }
}
