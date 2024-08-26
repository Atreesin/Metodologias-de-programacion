# Metodologias-de-programacion
ejercicios


//EJERCICIO 10
            //no tuve que modificar nada ya que utilize funciones de las clases creadas anteriormente


/*EJERCICIO 14
             * 
             * En cuanto a las clases anteriores no fue necesario hacer ninguna modificacion
             * pero si fue necesario instanciar una pila exclusiva para almacenar
             * personas ya que si bien se pueden almacenar tanto personas como numeros
             * al momento de comparar los elementos en la pila y la cola si bien ambos son comparables no seria algo logico
             * pero al momento de comparar decidi implementar que al momento de utilizar las funciones
             * sosMayor(), sosMenor() y sosIgual() puedan recibir un comparable, 
             * y si el objeto que recibe es de tipo Persona haga la comparacion directa
             * pero si el objeto recibido es de tipo Numero 
             * lo interprete como un dni porque sino deberia implementar el cambio en la funcion informar()...
             * si bien se podria hacer esta modificacion.. no creo que sea logico ya que
             * esta funcion no es exclusiva para elementos de tipo Persona
             */

//EJERCICIO 17
            /*si, funciono y no fue necesario decir explicitamente que Alumno tiene que implementar la interfaz comparable
             * el criterio para comparar a los alumnos fue por dni, el mismo utilizado para comparar personas
             * ya que estos tambien son personas
             */
            

//EJERCICIO 19
            /*Si, se podria haber hecho esto miso sin interfaces
             *pero no se podrian haber utilizado un mismo metodo para tratar a los distintos elementos como por ejemplo
             *llenar(coleccionable), informar(coleccionable), etc
             *tendriamos que haber sobrecargado los metodos para cada elemento
             *y tendriamos metodos para cada elemento como por ejemplo
             *llenar(pila) llenar(cola)
             *informar(pila), informar(cola), informar(coleccionmultiple), etc
             *y esto llevaria demaciadas lineas de codigo que realiza la misma tarea
             */
