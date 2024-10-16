using MetodologíasDeProgramaciónI;
using Practica_6.Classes.Decorator;
using Practica_6.Classes.Proxy;
using Practica_6.Composite;
using System;
using System.Collections.Generic;
using System.Net;


namespace Practica_6.Classes.Factory
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

        public const int AlumnoNormal = 1;
        public const int AlumnoFavorito = 2;
        public const int AlumnoMuyEstudioso = 3;
        public const int AlumnoNormalProxy = 4;
        public const int AlumnoFavoritoProxy = 5;
        public const int AlumnoMuyEstudiosoProxy = 6;
        public const int AlumnoCompuesto = 7;
        

        public const int AlumnoConLegajo = 1;
        public const int AlumnoConLetras = 2;
        public const int AlumnoConEstado = 3;
        public const int AlumnoConNumeroDeOrden = 4;
        public const int AlumnoConAsteriscos = 5;

        /// <summary>
        /// Crea un Alumno seleccionado Aleatorio.
        /// 
        /// <list type="bullet">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - AlumnoNormal</description>
        /// </item>
        /// <item>
        /// <description>2 - AlumnoFavorito</description>
        /// </item>
        /// <item>
        /// <description>3 - AlumnoMuyEstudioso</description>
        /// </item>
        /// <item>
        /// <description>4 - AlumnoNormalProxy</description>
        /// </item>
        /// <item>
        /// <description>5 - AlumnoFavoritoProxy</description>
        /// </item>
        /// <item>
        /// <description>6 - AlumnoMuyEstudiosoProxy</description>
        /// </item>
        /// <item>
        /// <description>7 - AlumnoCompuesto</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns>
        /// El Alumno Aleatorio elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public static IAlumno CrearAleatorio(int opcion)
        {
            FabricaDeAlumnos factory = null;
            switch (opcion)
            {
                case AlumnoNormal:
                    factory = new FabricaDeAlumnoNormalAleatorio();
                    break;
                case AlumnoFavorito:
                    factory = new FabricaDeAlumnoFavoritoAleatorio();
                    break;
                case AlumnoMuyEstudioso:
                    factory = new FabricaDeAlumnoMuyEstudiosoAleatorio();
                    break;
                case AlumnoNormalProxy:
                    factory = new FabricaDeAlumnoNormalProxyAleatorio();
                    break;
                case AlumnoFavoritoProxy:
                    factory = new FabricaDeAlumnoFavoritoProxyAleatorio();
                    break;
                case AlumnoMuyEstudiosoProxy:
                    factory = new FabricaDeAlumnoMuyEstudiosoProxyAleatorio();
                    break;
                case AlumnoCompuesto:
                    factory = new FabricaDeAlumnoCompuesto();
                    break;
            }
            return factory.CrearAlumno();
        }

        /// <summary>
        /// Crea un Alumno seleccionado al que se le tiene que ingresar los datos por teclado.
        /// 
        /// <list type="table">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - AlumnoNormal</description>
        /// </item>
        /// <item>
        /// <description>2 - AlumnoFavorito</description>
        /// </item>
        /// <item>
        /// <description>3 - AlumnoMuyEstudioso</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <returns>
        /// El Alumno creado por teclado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public static IAlumno CrearPorTeclado(int opcion)
        {
            FabricaDeAlumnos factory = null;
            switch (opcion)
            {
                case AlumnoNormal:
                    factory = new FabricaDeAlumnoNormalPorTeclado();
                    break;
                case AlumnoFavorito:
                    factory = new FabricaDeAlumnoFavoritoPorTeclado();
                    break;
                case AlumnoMuyEstudioso:
                    factory = new FabricaDeAlumnoMuyEstudiosoPorTeclado();
                    break;
                
            }
            return factory.CrearAlumno();
        }

        /// <summary>
        ///  Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno decorado con el decorado seleccionado
        ///
        /// <list type="table">
        /// <b>Opciones:</b>
        /// <item>
        /// <description>1 - ConLegajo</description>
        /// </item>
        /// <item>
        /// <description>2 - ConLetras</description>
        /// </item>
        /// <item>
        /// <description>3 - ConEstado</description>
        /// </item>
        /// <item>
        /// <description>4 - ConNumeroDeOrden</description>
        /// </item>
        /// <item>
        /// <description>5 - ConAsteriscos</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="opcion">Opcion de decorado</param>
        /// <param name="alumno">Alumno a decorar</param>
        /// <returns>
        /// El Alumno Decorado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public static IAlumno CrearDecorado(int opcion, IAlumno alumno)
        {
            FabricaDeAlumnos factory = null;

            switch (opcion)
            {
                case AlumnoConLegajo:
                    factory = new FabricaDeAlumnoConLegajo();
                    break;
                case AlumnoConLetras:
                    factory = new FabricaDeAlumnoConLetras();
                    break;
                case AlumnoConEstado:
                    factory = new FabricaDeAlumnoConEstado();
                    break;
                case AlumnoConNumeroDeOrden:
                    factory = new FabricaDeAlumnoConNumeroDeOrden();
                    break;
                case AlumnoConAsteriscos:
                    factory = new FabricaDeAlumnoConAsteriscos();
                    break;
            }

            return factory.CrearAlumno(alumno);
        }

        /// <summary>
        /// Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno adaptado 
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// El Alumno adaptado de tipo <see cref="Student"/>
        /// </returns>
        public static Student CrearAdaptado(IAlumno alumno)
        {
            FabricaDeAlumnos factory = new StudentsFactory();

            return factory.CrearStudent(alumno);
        }

        public abstract IAlumno CrearAlumno();
        public abstract IAlumno CrearAlumno(IAlumno alumno);
        public abstract Student CrearStudent(IAlumno alumno);
    }

    //************************//
    //** FABRICAS CONCRETAS **//
    //************************//

    /***************    Aleatorios     ********************/
    /// <summary>
    /// Fabrica concreta de Alumno Normal Aleatorio
    /// </summary>
    public class FabricaDeAlumnoNormalAleatorio : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Normal Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36)]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40)]}";
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().CrearComparable());

            IAlumno alumno = new AlumnoNormal(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Favorito Aleatorio
    /// </summary>
    public class FabricaDeAlumnoFavoritoAleatorio : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Favorito Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Alumno Favorito Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36)]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40)]}";
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().CrearComparable());

            IAlumno alumno = new AlumnoFavorito(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Muy Estudioso Aleatorio
    /// </summary>
    public class FabricaDeAlumnoMuyEstudiosoAleatorio : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Muy Estudioso Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Alumno MuyEstudioso Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36)]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40)]}";
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().CrearComparable());

            IAlumno alumno = new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Normal Proxy Aleatorio
    /// </summary>
    public class FabricaDeAlumnoNormalProxyAleatorio : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Normal Proxy Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36)]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40)]}";
            
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().CrearComparable());
            

            IAlumno alumno = new AlumnoProxy(nombre, dni, legajo, promedio, 1);
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Favorito Proxy Aleatorio
    /// </summary>
    public class FabricaDeAlumnoFavoritoProxyAleatorio : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Normal Proxy Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36)]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40)]}";
            
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().CrearComparable());
            

            IAlumno alumno = new AlumnoProxy(nombre, dni, legajo, promedio, 2);
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Muy Estudioso Proxy Aleatorio
    /// </summary>
    public class FabricaDeAlumnoMuyEstudiosoProxyAleatorio : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Favorito Proxy Aleatorio.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            string nombre = $"{apellidos[GeneradorDeDatosAleatorios.numeroAleatorio(36)]} {nombres[GeneradorDeDatosAleatorios.numeroAleatorio(40)]}";
            
            Numero dni = (Numero)(new FabricaDeNumeroDniAleatorio().CrearComparable());
            Numero legajo = (Numero)(new FabricaDeNumeroLegajoAleatorio().CrearComparable());
            Numero promedio = (Numero)(new FabricaDeNumeroPromedioAleatorio().CrearComparable());
            

            IAlumno alumno = new AlumnoProxy(nombre, dni, legajo, promedio, 3);
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /***************    Por Teclado     ********************/

    /// <summary>
    /// Fabrica concreta de Alumno Normal Por Teclado
    /// </summary>
    public class FabricaDeAlumnoNormalPorTeclado : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Normal al que se le tiene que ingresar los datos por teclado.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            Console.WriteLine("Nombre y apellido:");
            string nombre = LectorDeDatos.stringPorTeclado();
            Console.WriteLine("Dni:");
            Numero dni = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Legajo:");
            Numero legajo = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Promedio:");
            Numero promedio = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();

            IAlumno alumno = new AlumnoNormal(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Favorito Por Teclado
    /// </summary>
    public class FabricaDeAlumnoFavoritoPorTeclado : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno Favorito al que se le tiene que ingresar los datos por teclado.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            Console.WriteLine("Nombre y apellido:");
            string nombre = LectorDeDatos.stringPorTeclado();
            Console.WriteLine("Dni:");
            Numero dni = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Legajo:");
            Numero legajo = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Promedio:");
            Numero promedio = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();

            IAlumno alumno = new AlumnoFavorito(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Muy Estudioso Por Teclado
    /// </summary>
    public class FabricaDeAlumnoMuyEstudiosoPorTeclado : FabricaDeAlumnos
    {
        /// <summary>
        /// Crea un Alumno MuyEstudioso al que se le tiene que ingresar los datos por teclado.
        /// </summary>
        /// <returns>
        /// Un Alumno Normal Aleatorio de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            Console.WriteLine("Nombre y apellido:");
            string nombre = LectorDeDatos.stringPorTeclado();
            Console.WriteLine("Dni:");
            Numero dni = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Legajo:");
            Numero legajo = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();
            Console.WriteLine("Promedio:");
            Numero promedio = (Numero)new FabricaDeNumeroPorTeclado().CrearComparable();

            IAlumno alumno = new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
            alumno.setCriterio(new PorNombre());
            return alumno;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    

    /***************    Decorados       *********************/

    /// <summary>
    /// Fabrica concreta de Alumno Decorado Con Legajo
    /// </summary>
    public class FabricaDeAlumnoConLegajo : FabricaDeAlumnos
    {
        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            return null;
        }

        /// <summary>
        ///  Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno decorado con el Legajo
        ///
        /// </summary>
        /// <param name="alumno">Alumno a decorar</param>
        /// <returns>
        /// El Alumno Decorado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return new ConLegajo(alumno);
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Decorado Con Letras
    /// </summary>
    public class FabricaDeAlumnoConLetras : FabricaDeAlumnos
    {
        /// <summary>
        /// no hace nada
        /// </summary>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            return null;
        }

        /// <summary>
        ///  Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno decorado con La Calificacion escrita con Letras
        ///
        /// </summary>
        /// <param name="alumno">Alumno a decorar</param>
        /// <returns>
        /// El Alumno Decorado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return new ConLetras(alumno);
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Decorado Con Estado
    /// </summary>
    public class FabricaDeAlumnoConEstado : FabricaDeAlumnos
    {
        /// <summary>
        /// no hace nada
        /// </summary>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            return null;
        }

        /// <summary>
        ///  Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno decorado con El estado de aprobación
        ///
        /// </summary>
        /// <param name="alumno">Alumno a decorar</param>
        /// <returns>
        /// El Alumno Decorado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return new ConEstado(alumno);
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Decorado Con Numero de Orden
    /// </summary>
    public class FabricaDeAlumnoConNumeroDeOrden : FabricaDeAlumnos
    {

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            return null;
        }

        /// <summary>
        ///  Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno decorado con El número de orden secuencial dentro del listado
        ///
        /// </summary>
        /// <param name="alumno">Alumno a decorar</param>
        /// <returns>
        /// El Alumno Decorado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return new ConNumeroDeOrden(alumno);
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Decorado Con Asteriscos
    /// </summary>
    public class FabricaDeAlumnoConAsteriscos : FabricaDeAlumnos
    {
        /// <summary>
        /// no hace nada
        /// </summary>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            return null;
        }

        /// <summary>
        ///  Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno decorado con Un recuadro hecho con Asteriscos
        ///
        /// </summary>
        /// <param name="alumno">Alumno a decorar</param>
        /// <returns>
        /// El Alumno Decorado elegido de tipo <see cref="IAlumno"/>
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return new ConAsteriscos(alumno);
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return null;
        }
    }

    /***************    Adaptados       *********************/

    /// <summary>
    /// Fabrica concreta de Alumno Adaptado
    /// </summary>
    public class StudentsFactory : FabricaDeAlumnos
    {
        /// <summary>
        /// no hace nada
        /// </summary>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno()
        {
            return null;
        }

        /// <summary>
        /// no hace nada
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// null
        /// </returns>
        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            return null;
        }

        /// <summary>
        /// Recibe un Alumno del tipo <see cref="IAlumno"/> y crea un Alumno adaptado 
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns>
        /// El Alumno adaptado de tipo <see cref="Student"/>
        /// </returns>
        public override Student CrearStudent(IAlumno alumno)
        {
            return new AlumnoAdapter(alumno);
        }
    }

    /// <summary>
    /// Fabrica concreta de Alumno Compuesto
    /// </summary>
    public class FabricaDeAlumnoCompuesto : FabricaDeAlumnos
    {
        /// <summary>
        /// genera un Alumno compuesto de 5 Alumnos proxy (eligiento aleatoriamente entre alumnos muy estudiosos y normales)
        /// </summary>
        /// <returns></returns>
        public override IAlumno CrearAlumno()
        {
            IAlumno compuesto1 = new AlumnoCompuesto();

            IAlumno decorado;
            for (int i = 0; i < 5; i++)
            {
                IAlumno a;
                if (GeneradorDeDatosAleatorios.numeroAleatorio(10) > 5)
                {
                    a = FabricaDeAlumnos.CrearAleatorio(4);
                }
                else
                {
                    a = FabricaDeAlumnos.CrearAleatorio(6);
                }
                decorado = FabricaDeAlumnos.CrearDecorado(1, a);
                decorado = FabricaDeAlumnos.CrearDecorado(2, decorado);
                decorado = FabricaDeAlumnos.CrearDecorado(3, decorado);
                decorado = FabricaDeAlumnos.CrearDecorado(4, decorado);
                decorado = FabricaDeAlumnos.CrearDecorado(5, decorado);
                ((AlumnoCompuesto)compuesto1).agregarHijo(decorado);
            }

            return compuesto1;
        }

        public override IAlumno CrearAlumno(IAlumno alumno)
        {
            throw new NotImplementedException();
        }

        public override Student CrearStudent(IAlumno alumno)
        {
            throw new NotImplementedException();
        }
    }
}
