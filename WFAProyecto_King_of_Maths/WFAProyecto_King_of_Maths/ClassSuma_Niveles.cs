using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class ClassSuma_Niveles
    {
        Random rndlvl1 = new Random();
        private int n1_1, n2_1, opcion1_1, opcion2_1, opcion3_1, resultado1 = 0, punteomax1 = 100000, contador1;

        /* en el caso de los demas niveles los puntajes iran cambiandoe el punteo minimo ira cambiando en cada uno de los otris niveles*/
        /*Las estrellas o AC cambiara su nivelaje dependiendo de la codición*/

        // en declaración de variables no tiene que llevar espacio ni empezar con numeros
        //nombre de la lista 
        // declarar variables globales 
        /* Como no podemos utilizar arreglos o arrays se creara una lista en donde los datos de opciones se iran guardando en forma de matriz  
         * y de esa manera colocar menos variables a la hora de codificar ya que sería algo tedioso */
        List<int> opciones = new List<int>();

        public void generarlvl1()
        {
            n1_1 = rndlvl1.Next(1, 16);// colocarle al random número de entre 1 a 16 para que me los lance en el label 
            n2_1 = rndlvl1.Next(1, 16);// lo mismo que el n1 solo que en este caso que me los coloque en el n2 
            resultado1 = n1_1 + n2_1; // como este es el mundo de suma lo que se hara sera sumar las variables n1 y n2 
            opcion1_1 = rndlvl1.Next(1, 31);/* Estas opciones seran los bototnes en mi fomar y se les agrega un random de números de entre 1 a 31 
                                                  ya que seran mis posibles respuestas de la suma de resulatad*/
            opcion2_1 = rndlvl1.Next(1, 31);/* lo mismo sucede en esta opción 2 y en la opción 3 */
            opcion3_1 = rndlvl1.Next(1, 31);
            /* se condicionara al resultado de modo que las opciones no deban ser igual a él ya que de serlo 
             * provocaría un error que no queremos que suceda*/
            /* ahora se condicionan los valores para que no se repitan los numeros en los botones de la forma */
            if ((opcion1_1 == resultado1) || (opcion1_1 == opcion2_1) || (opcion1_1 == opcion3_1))
            {
                opcion1_1 = rndlvl1.Next(1, 31);
            }
            if ((opcion2_1 == resultado1) || (opcion2_1 == opcion1_1) || (opcion2_1 == opcion3_1))
            {
                opcion2_1 = rndlvl1.Next(1, 31);
            }
            if ((opcion3_1 == resultado1) || (opcion3_1 == opcion1_1) || (opcion3_1 == opcion2_1))
            {
                opcion3_1 = rndlvl1.Next(1, 31);
            }

            opciones.Add(opcion1_1);
            opciones.Add(opcion2_1);
            opciones.Add(opcion3_1);
            opciones.Add(resultado1);
            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opciones[0] = 0;
            opciones[1] = 0;
            opciones[2] = 0;
            opciones[3] = 0;

        }
        public void Respuesta_Lv1()
        {/* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */
            //Opcion 1 que me devuleve un valor 
            contador1 = rndlvl1.Next(4);
            opciones[contador1] = opcion1_1;

            // opción 2 
            while (opciones[contador1] != 0)
            {
                contador1 = rndlvl1.Next(4);
            }
            opciones[contador1] = opcion2_1;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opciones[contador1] != 0)
            {
                contador1 = rndlvl1.Next(4);
            }
            opciones[contador1] = opcion3_1;// le agregue un valor diferente a 0, 

            // resultado 
            while (opciones[contador1] != 0)
            {
                contador1 = rndlvl1.Next(4);
            }
            opciones[contador1] = resultado1;// le agregue un valor diferente a 0
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N1S()
        {
            return n1_1;
        }
        public int retonar_numero2N1S()
        {
            return n2_1;
        }
        public int retonar_resultadoN1S()
        {
            return resultado1;
        }
        public List<int> retornar_listaN1S()
        {
            return opciones;
        } public string punteosN1S()
        {
            punteomax1 = punteomax1 - 1667;
            return Convert.ToString(punteomax1);
        }
        public string quitarpuntosN1S()
        {
            punteomax1 = punteomax1 - 20000;
            return Convert.ToString(punteomax1);
        }
       
        /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
       /*Fin Nivel 1__________________________________________________________________________________________________________*/
       


        /*Inicio Segundo Nivel*/

        /*solo tengo que cambiar el nombre a las variable ya que el concepto de este segundo nivel es el mismo que el lv1
         solo que cambia a la hora de dar el resultado */
        Random rndlv2 = new Random();
        private int a2, b2, opcion1_2, opcion2_2, opcion3_2, resultado_2,
                    punteomax2 = 110000, contador2, c2;

        List<int> opcioneslvl2 = new List<int>();
        public void generarlvl2()
        {
            a2 = rndlv2.Next(1, 16);
            b2 = rndlv2.Next(1, 16);
            resultado_2 = a2 + b2;
            c2 = resultado_2 - a2; /* esta variable c2 es el resultad de b2 el cual necesito encontrar */

            //se agrega random a las opciones 
            opcion1_2 = rndlv2.Next(1, 31);
            opcion2_2 = rndlv2.Next(1, 31);
            opcion3_2 = rndlv2.Next(1, 31);

            //condiciono las opciones 
            if ((opcion1_2 == c2) || (opcion1_2 == opcion2_2) || (opcion1_2 == opcion3_2))
            {
                opcion1_2 = rndlv2.Next(1, 31);
            }
            if ((opcion2_2 == c2) || (opcion2_2 == opcion1_2) || (opcion2_2 == opcion3_2)) 
            {
                opcion2_2 = rndlv2.Next(1, 31);
            }
            if ((opcion3_2 == c2) || (opcion3_2 == opcion2_2) || (opcion3_2 == opcion1_2))
            {
                opcion3_2 = rndlv2.Next(1, 31);
            }
            // las agrego a la lista 
            opcioneslvl2.Add(opcion1_2);
            opcioneslvl2.Add(opcion2_2);
            opcioneslvl2.Add(opcion3_2);
            opcioneslvl2.Add(resultado_2);
            opcioneslvl2.Add(c2);
            
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcioneslvl2[0] = 0;
            opcioneslvl2[1] = 0;
            opcioneslvl2[2] = 0;
            opcioneslvl2[3] = 0;

        }
        public void Respuesta_Lv2()
        {
            //opcion 1 
            contador2 = rndlv2.Next(4);
            opcioneslvl2[contador2] = opcion1_2; // toma la posicion 0 

            // opción 2 
            while (opcioneslvl2[contador2] != 0)
            {
                contador2 = rndlv2.Next(4);
            }
            opcioneslvl2[contador2] = opcion2_2;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opcioneslvl2[contador2] != 0)
            {
                contador2 = rndlv2.Next(4);
            }
            opcioneslvl2[contador2] = opcion3_2;// le agregue un valor diferente a 0, 

            // resultado 
            while (opcioneslvl2[contador2] != 0)
            {
                contador2 = rndlv2.Next(4);
            }
            opcioneslvl2[contador2] = c2;// le agregue un valor diferente a 0
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N2S()
        {
            return a2;
        }
        public int retonar_numero2N2S()
        {
            return b2;
        }
        public int retonar_resultadoN2S()
        {
            return resultado_2;
        }
        public int retonar_resucN2s()
        {
            return c2; 
        }
        public List<int> retornar_listaN2S()
        {
            return opcioneslvl2;
        }
        public string quitapunteos_segundosN2S()
        {
            punteomax2 = punteomax2 - 1833;
            return Convert.ToString(punteomax2);
        }
        public string quitarpuntosN2S()
        {
            punteomax2 = punteomax2 - 20000;
            return Convert.ToString(punteomax2); /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        /*Fin Nivel 2____________________________________________________________________________________________________*/
        //
        //

         /*Inicio Nivel 3*/

        Random rndlvlS3 = new Random();

        private int aS3, bS3, opcion1_S3, opcion2_S3, opcion3_S3, resultado_S3, opcion4_S3, opcion5_S3, opcion6_S3,
                    punteomax3 = 120000, contador3; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlS3 = new List<string>();
        List<int> opcioneslvlS3listenteros = new List<int>(); 
        
        public void generarlvlS3()
        {
            // 
            aS3 = rndlvlS3.Next(1, 16);
            bS3 = rndlvlS3.Next(1, 16);
            resultado_S3 = aS3 + bS3;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_S3 = rndlvlS3.Next(1, 31);
            opcion2_S3 = rndlvlS3.Next(1, 31);
            opcion3_S3 = rndlvlS3.Next(1, 31);
            opcion4_S3 = rndlvlS3.Next(1, 31);
            opcion5_S3 = rndlvlS3.Next(1, 31);
            opcion6_S3 = rndlvlS3.Next(1, 31);

            if (opcion1_S3 == resultado_S3)
            {
                opcion1_S3 = rndlvlS3.Next(1, 31);
            }
            if (opcion2_S3 == resultado_S3)
            {
                opcion2_S3 = rndlvlS3.Next(1, 31);
            }
            if (opcion3_S3 == resultado_S3)
            {
                opcion3_S3 = rndlvlS3.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlS3.Add(opcion1_S3 + " + " + opcion2_S3);
            opcioneslvlS3.Add(opcion3_S3 + " + " + opcion4_S3);
            opcioneslvlS3.Add(opcion5_S3 + " + " + opcion6_S3);
            opcioneslvlS3.Add(Convert.ToString(aS3) + " + " + Convert.ToString(bS3)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlS3listenteros.Add(opcion1_S3 + opcion2_S3);
            opcioneslvlS3listenteros.Add(opcion3_S3 + opcion4_S3);
            opcioneslvlS3listenteros.Add(opcion5_S3 + opcion6_S3);
            opcioneslvlS3listenteros.Add(aS3 + bS3); 

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlS3listenteros[0] = 0;
            opcioneslvlS3listenteros[1] = 0;
            opcioneslvlS3listenteros[2] = 0;
            opcioneslvlS3listenteros[3] = 0; 
            
        }
        public void Respuesta_LvlS3()
        {
            //opcion 1 
            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */
            contador3 = rndlvlS3.Next(4);
            opcioneslvlS3listenteros[contador3] = opcion1_S3 + opcion2_S3;
            opcioneslvlS3[contador3] = opcion1_S3 + " + " + opcion2_S3; 

            // opción 2 
            contador3 = rndlvlS3.Next(4);
            while (opcioneslvlS3listenteros[contador3] != 0)
            {
                contador3 = rndlvlS3.Next(4);
            }
            opcioneslvlS3listenteros[contador3] = opcion3_S3 + opcion4_S3; // le agregue un valor diferente a 0, 
            opcioneslvlS3[contador3] = opcion3_S3 + " + " + opcion4_S3;

            // opcion 3
            contador3 = rndlvlS3.Next(4);
            while (opcioneslvlS3listenteros[contador3] != 0)
            {
                contador3 = rndlvlS3.Next(4);
            }
            opcioneslvlS3listenteros[contador3] = (opcion5_S3 + opcion6_S3);// le agregue un valor diferente a 0, 
            opcioneslvlS3[contador3] = opcion5_S3 + " + " + opcion6_S3;

            // resultado 
            contador3 = rndlvlS3.Next(4);
            while (opcioneslvlS3listenteros[contador3] != 0)
            {
                contador3 = rndlvlS3.Next(4);
            }
            opcioneslvlS3listenteros[contador3] = resultado_S3; // le agregue un valor diferente a 0
            opcioneslvlS3[contador3] = (aS3 + " + " + bS3); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N3S()
        {
            return aS3;
        }
        public int retonar_numero2N3S()
        {
            return bS3;
        }
        public int retonar_resultadoN3S()
        {
            return resultado_S3;
        }
        public List<string> retornar_listaN3S()
        {
            return opcioneslvlS3; 
        }
        public List<int> retornarlistaenteros()
        {
            return opcioneslvlS3listenteros; 
        }
        public string quitapunteos_segundosN3S()
        {
            punteomax3 = punteomax3 - 2000;
            return Convert.ToString(punteomax3);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN3S()
        {
            punteomax3 = punteomax3 - 20000;
            return Convert.ToString(punteomax3); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        // Fin Nivel 3________________________________________________________________________________________________


        /*Inicio Nivel 4 */

        Random rndlvlS4 = new Random();

        private int aS4, bS4, opcion1_S4, opcion2_S4, opcion3_S4, resultado_S4, opcion4_S4, opcion5_S4, opcion6_S4,
                    punteomaxS4 = 130000, contadorS4; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlS4 = new List<string>();
        List<int> opcioneslvlS4listenteros = new List<int>();

        public void generarlvlS4()
        {
            aS4 = rndlvlS4 .Next(1, 16);
            bS4 = rndlvlS4 .Next(1, 16);
            resultado_S4 = aS4 + bS4;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_S4 = rndlvlS4 .Next(1, 31);
            opcion2_S4 = rndlvlS4 .Next(1, 31);
            opcion3_S4 = rndlvlS4 .Next(1, 31);
            opcion4_S4 = rndlvlS4 .Next(1, 31);
            opcion5_S4 = rndlvlS4 .Next(1, 31);
            opcion6_S4 = rndlvlS4 .Next(1, 31);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y de esa forma respondr a la pregunta cual es menor */
            while (opcion1_S4 + opcion2_S4 <= resultado_S4)
            {
                opcion1_S4 = rndlvlS4.Next(1, 31);
                opcion2_S4 = rndlvlS4.Next(1, 31);
            }
            while ((opcion3_S4 + opcion4_S4 <= resultado_S4) || (opcion3_S4 + opcion4_S4 == opcion1_S4 + opcion2_S4))
            {
                opcion3_S4 = rndlvlS4.Next(1, 31);
                opcion4_S4 = rndlvlS4.Next(1, 31);
            }
            while ((opcion5_S4 + opcion6_S4 <= resultado_S4) || (opcion5_S4 + opcion6_S4 == opcion3_S4 + opcion4_S4) || (opcion5_S4 + opcion6_S4 == opcion1_S4 + opcion2_S4 ))
            {
                opcion5_S4 = rndlvlS4.Next(1, 31);
                opcion6_S4 = rndlvlS4.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlS4.Add(opcion1_S4 + " + " + opcion2_S4);
            opcioneslvlS4.Add(opcion3_S4 + " + " + opcion4_S4);
            opcioneslvlS4.Add(opcion5_S4 + " + " + opcion6_S4);
            opcioneslvlS4.Add(Convert.ToString(aS4) + " + " + Convert.ToString(bS4)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlS4listenteros.Add(opcion1_S4 + opcion2_S4);
            opcioneslvlS4listenteros.Add(opcion3_S4 + opcion4_S4);
            opcioneslvlS4listenteros.Add(opcion5_S4 + opcion6_S4);
            opcioneslvlS4listenteros.Add(aS4 + bS4);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlS4listenteros[0] = 0;
            opcioneslvlS4listenteros[1] = 0;
            opcioneslvlS4listenteros[2] = 0;
            opcioneslvlS4listenteros[3] = 0;

        }
        public void Respuesta_LvlS4()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorS4 = rndlvlS4.Next(4);
            opcioneslvlS4listenteros[contadorS4] = opcion1_S4 + opcion2_S4;
            opcioneslvlS4 [contadorS4] = opcion1_S4 + " + " + opcion2_S4;

            // opción 2 

            contadorS4 = rndlvlS4.Next(4);
            while (opcioneslvlS4listenteros[contadorS4] != 0)
            {
                contadorS4 = rndlvlS4.Next(4);
            }
            opcioneslvlS4listenteros[contadorS4] = opcion3_S4 + opcion4_S4; // le agregue un valor diferente a 0, 
            opcioneslvlS4 [contadorS4] = opcion3_S4 + " + " + opcion4_S4;

            // opcion 3

            contadorS4 = rndlvlS4.Next(4);
            while (opcioneslvlS4listenteros[contadorS4] != 0)
            {
                contadorS4 = rndlvlS4.Next(4);
            }
            opcioneslvlS4listenteros[contadorS4] = (opcion5_S4 + opcion6_S4);// le agregue un valor diferente a 0, 
            opcioneslvlS4[contadorS4] = opcion5_S4 + " + " + opcion6_S4;

            // resultado 

            contadorS4 = rndlvlS4.Next(4);
            while (opcioneslvlS4listenteros[contadorS4] != 0)
            {
                contadorS4 = rndlvlS4.Next(4);
            }
            opcioneslvlS4listenteros[contadorS4] = resultado_S4; // le agregue un valor diferente a 0
            opcioneslvlS4[contadorS4] = (aS4 + " + " + bS4); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NS4()
        {
            return aS4;
        }
        public int retonar_numero2NS4()
        {
            return bS4;
        }
        public int retonar_resultadoNS4()
        {
            return resultado_S4;
        }
        public List<string> retornar_listaNS4()
        {
            return opcioneslvlS4;
        }
        public List<int> retornarlistaenterosS4()
        {
            return opcioneslvlS4listenteros;
        }
        public string quitapunteos_segundosNS4()
        {
            punteomaxS4 = punteomaxS4 - 2167;
            return Convert.ToString(punteomaxS4);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN4S()
        {
            punteomaxS4 = punteomaxS4 - 20000;
            return Convert.ToString(punteomaxS4); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        //FIN NIVEL 4___________________________________________________________________________________________-


        /*INIICO NIVEL 5 (EL ULTIMO!!!!!) \O/*/

        Random rndlvlS5 = new Random();

        private int aS5, bS5, opcion1_S5, opcion2_S5, opcion3_S5, resultado_S5, opcion4_S5, opcion5_S5, opcion6_S5,
                    punteomaxS5 = 140000, contadorS5; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlS5 = new List<string>();
        List<int> opcioneslvlS5listenteros = new List<int>();

        public void generarlvlS5()
        {
            aS5 = rndlvlS5.Next(1, 16);
            bS5 = rndlvlS5.Next(1, 16);
            resultado_S5 = aS5 + bS5;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_S5 = rndlvlS5.Next(1, 31);
            opcion2_S5 = rndlvlS5.Next(1, 31);
            opcion3_S5 = rndlvlS5.Next(1, 31);
            opcion4_S5 = rndlvlS5.Next(1, 31);
            opcion5_S5 = rndlvlS5.Next(1, 31);
            opcion6_S5 = rndlvlS5.Next(1, 31);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y que sea solo esa opción la suma mayor necesaria para responder la pregunta*/
            while (opcion1_S5 + opcion2_S5 >= resultado_S5)
            {
                opcion1_S5 = rndlvlS5.Next(1, 31);
                opcion2_S5 = rndlvlS5.Next(1, 31);
            }
            while ((opcion3_S5 + opcion4_S5 >= resultado_S5) || (opcion3_S5 + opcion4_S5 == opcion1_S5 + opcion2_S5))
            {
                opcion3_S5 = rndlvlS5.Next(1, 31);
                opcion4_S5 = rndlvlS5.Next(1, 31);
            }
            while ((opcion5_S5 + opcion6_S5 >= resultado_S5) || (opcion5_S5 + opcion6_S5 == opcion3_S5 + opcion4_S5) || (opcion5_S4 + opcion6_S5 == opcion1_S5 + opcion2_S5))
            {
                opcion5_S5 = rndlvlS5.Next(1, 31);
                opcion6_S5 = rndlvlS5.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlS5.Add(opcion1_S5 + " + " + opcion2_S5);
            opcioneslvlS5.Add(opcion3_S5 + " + " + opcion4_S5);
            opcioneslvlS5.Add(opcion5_S5 + " + " + opcion6_S5);
            opcioneslvlS5.Add(Convert.ToString(aS5) + " + " + Convert.ToString(bS5)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlS5listenteros.Add(opcion1_S5 + opcion2_S5);
            opcioneslvlS5listenteros.Add(opcion3_S5 + opcion4_S5);
            opcioneslvlS5listenteros.Add(opcion5_S5 + opcion6_S5);
            opcioneslvlS5listenteros.Add(aS5 + bS5);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlS5listenteros[0] = 0;
            opcioneslvlS5listenteros[1] = 0;
            opcioneslvlS5listenteros[2] = 0;
            opcioneslvlS5listenteros[3] = 0;

        }
        public void Respuesta_LvlS5()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorS5 = rndlvlS5.Next(4);
            opcioneslvlS5listenteros[contadorS5] = opcion1_S5 + opcion2_S5;
            opcioneslvlS5[contadorS5] = opcion1_S5 + " + " + opcion2_S5;

            // opción 2 

            contadorS5 = rndlvlS5.Next(4);
            while (opcioneslvlS5listenteros[contadorS5] != 0)
            {
                contadorS5 = rndlvlS5.Next(4);
            }
            opcioneslvlS5listenteros[contadorS5] = opcion3_S5 + opcion4_S5; // le agregue un valor diferente a 0, 
            opcioneslvlS5[contadorS5] = opcion3_S5 + " + " + opcion4_S5;

            // opcion 3

            contadorS5 = rndlvlS5.Next(4);
            while (opcioneslvlS5listenteros[contadorS5] != 0)
            {
                contadorS5 = rndlvlS5.Next(4);
            }
            opcioneslvlS5listenteros[contadorS5] = (opcion5_S5 + opcion6_S5);// le agregue un valor diferente a 0, 
            opcioneslvlS5[contadorS5] = opcion5_S5 + " + " + opcion6_S5;

            // resultado 

            contadorS5 = rndlvlS5.Next(4);
            while (opcioneslvlS5listenteros[contadorS5] != 0)
            {
                contadorS5 = rndlvlS5.Next(4);
            }
            opcioneslvlS5listenteros[contadorS5] = resultado_S5; // le agregue un valor diferente a 0
            opcioneslvlS5[contadorS5] = (aS5 + " + " + bS5); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NS5()
        {
            return aS5;
        }
        public int retonar_numero2NS5()
        {
            return bS5;
        }
        public int retonar_resultadoNS5()
        {
            return resultado_S5;
        }
        public List<string> retornar_listaNS5()
        {
            return opcioneslvlS5;
        }
        public List<int> retornarlistaenterosS5()
        {
            return opcioneslvlS5listenteros;
        }
        public string quitapunteos_segundosNS5()
        {
            punteomaxS5 = punteomaxS5 - 2333;
            return Convert.ToString(punteomaxS5);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN5S()
        {
            punteomaxS5 = punteomaxS5 - 20000;
            return Convert.ToString(punteomaxS5); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }
    }


}
