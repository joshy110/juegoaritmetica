using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class ClassMultiplicación_Niveles
    {
        Random rndlvl1M = new Random();
        private int a1M, b1M, opcion1_1M, opcion2_1M, opcion3_1M, resultadoM1 = 0, punteomaxM1 = 100000, 
                    contadorM1;

        List<int> opciones1M = new List<int>();
        public void Lvl1M()
        {
            a1M = rndlvl1M.Next(1, 16);
            b1M = rndlvl1M.Next(1, 16);
            resultadoM1 = a1M * b1M;  

            opcion1_1M = rndlvl1M.Next(1, 225);
            opcion2_1M = rndlvl1M.Next(1, 225);
            opcion3_1M = rndlvl1M.Next(1, 225);
        
            if (opcion1_1M == resultadoM1)
            {
                opcion1_1M = rndlvl1M.Next(1, 225);
            }
            if (opcion2_1M == resultadoM1)
            {
                opcion2_1M = rndlvl1M.Next(1, 225);
            }
            if (opcion3_1M == resultadoM1)
            {
                opcion3_1M = rndlvl1M.Next(1, 225);
            }

            opciones1M.Add(opcion1_1M);
            opciones1M.Add(opcion2_1M);
            opciones1M.Add(opcion3_1M);
            opciones1M.Add(resultadoM1);
            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opciones1M[0] = 0;
            opciones1M[1] = 0;
            opciones1M[2] = 0;
            opciones1M[3] = 0;

        }
        public void Respuesta_LvM1()
        {/* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */
            //Opcion 1 que me devuleve un valor 
            contadorM1 = rndlvl1M.Next(4);
            opciones1M[contadorM1] = opcion1_1M;

            // opción 2 
            while (opciones1M[contadorM1] != 0)
            {
                contadorM1 = rndlvl1M.Next(4);
            }
            opciones1M[contadorM1] = opcion2_1M;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opciones1M[contadorM1] != 0)
            {
                contadorM1 = rndlvl1M.Next(4);
            }
            opciones1M[contadorM1] = opcion3_1M;// le agregue un valor diferente a 0, 

            // resultado 
            while (opciones1M[contadorM1] != 0)
            {
                contadorM1 = rndlvl1M.Next(4);
            }
            opciones1M[contadorM1] = resultadoM1;// le agregue un valor diferente a 0
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N1M()
        {
            return a1M;
        }
        public int retonar_numero2N1M()
        {
            return b1M;
        }
        public int retonar_resultadoN1M()
        {
            return resultadoM1;
        }
        public List<int> retornar_listaN1M()
        {
            return opciones1M;
        }
        public string punteos_SEgundosN1M()
        {
            punteomaxM1 = punteomaxM1 - 1667;
            return Convert.ToString(punteomaxM1);
        }
        public string quitarpuntosN1M()
        {
            punteomaxM1 = punteomaxM1 - 20000;
            return Convert.ToString(punteomaxM1);
        }
        /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */

        /*Fin Nivel 1__________________________________________________________________________________________________________*/



        /*Inicio Segundo Nivel*/

        /*solo tengo que cambiar el nombre a las variable ya que el concepto de este segundo nivel es el mismo que el lv1
         solo que cambia a la hora de dar el resultado */
        Random rndlvM2 = new Random();
        private int a2M, b2M, opcion1M2, opcion2M2, opcion3M2, resultadoM2,
                    punteomaxM2 = 110000, contadorM2, cM2;

        List<int> opcioneslvlM2 = new List<int>();
        public void LvlM2() // empezamos a generar las operaciones 
        {
            a2M = rndlvM2.Next(1, 16);
            b2M = rndlvM2.Next(1, 16);
            resultadoM2 = a2M * b2M;
            cM2 = resultadoM2 / a2M; /* esta variable c2 es el resultad de b2 el cual necesito encontrar */

            opcion1M2 = rndlvM2.Next(1, 225);
            opcion2M2 = rndlvM2.Next(1, 225);
            opcion3M2 = rndlvM2.Next(1, 225);

            if (opcion1M2 == cM2)
            {
                opcion1M2 = rndlvM2.Next(1, 225);
            }
            if (opcion2M2 == cM2)
            {
                opcion2M2 = rndlvM2.Next(1, 225);
            }
            if (opcion3M2 == cM2)
            {
                opcion3M2 = rndlvM2.Next(1, 225);
            }

            opcioneslvlM2.Add(opcion1M2);
            opcioneslvlM2.Add(opcion2M2);
            opcioneslvlM2.Add(opcion3M2);
            opcioneslvlM2.Add(resultadoM2);
            opcioneslvlM2.Add(cM2);
            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcioneslvlM2[0] = 0;
            opcioneslvlM2[1] = 0;
            opcioneslvlM2[2] = 0;
            opcioneslvlM2[3] = 0;

        }
        public void Respuesta_LvM2()
        {
            //opcion 1 
            contadorM2 = rndlvM2.Next(4);
            opcioneslvlM2[contadorM2] = opcion1M2;

            // opción 2 
            while (opcioneslvlM2[contadorM2] != 0)
            {
                contadorM2 = rndlvM2.Next(4);
            }
            opcioneslvlM2[contadorM2] = opcion2M2;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opcioneslvlM2[contadorM2] != 0)
            {
                contadorM2 = rndlvM2.Next(4);
            }
            opcioneslvlM2[contadorM2] = opcion3M2;// le agregue un valor diferente a 0, 

            // resultado 
            while (opcioneslvlM2[contadorM2] != 0)
            {
                contadorM2 = rndlvM2.Next(4);
            }
            opcioneslvlM2[contadorM2] = cM2;// con este while retorno el valor de la incognita de la multiplicacion que en este caso sería b2M
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N2M()
        {
            return a2M;
        }
        public int retonar_numero2N2M()
        {
            return b2M;
        }
        public int retonar_resultadoN2M()
        {
            return resultadoM2;
        }
        public int retonar_resucN2M()
        {
            return cM2;
        }
        public List<int> retornar_listaN2M()
        {
            return opcioneslvlM2;
        }
        public string quitapunteos_segundosN2M()
        {
            punteomaxM2 = punteomaxM2 - 1833;
            return Convert.ToString(punteomaxM2);
        }
        public string quitarpuntosN2M()
        {
            punteomaxM2 = punteomaxM2 - 20000;
            return Convert.ToString(punteomaxM2); /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        /*Fin Nivel 2____________________________________________________________________________________________________*/
        //
        //

        /*Inicio Nivel 3*/

        Random rndlvlS3 = new Random();

        private int aM3, bM3, opcion1_3M, opcion2_3M, opcion3_3M, resultado_3M, opcion4_3M, opcion5_3M, opcion6_3M,
                    punteomaxM3 = 120000, contadorM3; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlM3 = new List<string>();
        List<int> opcioneslvlM3listenteros = new List<int>();

        public void generarlvl3M()
        {
            aM3 = rndlvlS3.Next(1, 16);
            bM3 = rndlvlS3.Next(1, 16);
            resultado_3M = aM3 * bM3;
            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/
            opcion1_3M = rndlvlS3.Next(1, 225);
            opcion2_3M = rndlvlS3.Next(1, 225);
            opcion3_3M = rndlvlS3.Next(1, 225);
            opcion4_3M = rndlvlS3.Next(1, 225);
            opcion5_3M = rndlvlS3.Next(1, 225);
            opcion6_3M = rndlvlS3.Next(1, 225);

            if (opcion1_3M == resultado_3M)
            {
                opcion1_3M = rndlvlS3.Next(1, 225);
            }
            if (opcion2_3M == resultado_3M)
            {
                opcion2_3M = rndlvlS3.Next(1, 225);
            }
            if (opcion3_3M == resultado_3M)
            {
                opcion3_3M = rndlvlS3.Next(1, 225);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlM3.Add(opcion1_3M + " * " + opcion2_3M);
            opcioneslvlM3.Add(opcion3_3M + " * " + opcion4_3M);
            opcioneslvlM3.Add(opcion5_3M + " * " + opcion6_3M);
            opcioneslvlM3.Add(Convert.ToString(aM3) + " * " + Convert.ToString(bM3));
            opcioneslvlM3listenteros.Add(opcion1_3M * opcion2_3M);
            opcioneslvlM3listenteros.Add(opcion3_3M * opcion4_3M);
            opcioneslvlM3listenteros.Add(opcion5_3M * opcion6_3M);
            opcioneslvlM3listenteros.Add(aM3 * bM3);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlM3listenteros[0] = 0;
            opcioneslvlM3listenteros[1] = 0;
            opcioneslvlM3listenteros[2] = 0;
            opcioneslvlM3listenteros[3] = 0;

        }
        public void Respuesta_Lvl3M()
        {
            //opcion 1 
            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */
            contadorM3 = rndlvlS3.Next(4);
            opcioneslvlM3listenteros[contadorM3] = opcion1_3M * opcion2_3M;
            opcioneslvlM3[contadorM3] = opcion1_3M + " * " + opcion2_3M;

            // opción 2 
            contadorM3 = rndlvlS3.Next(4);
            while (opcioneslvlM3listenteros[contadorM3] != 0)
            {
                contadorM3 = rndlvlS3.Next(4);
            }
            opcioneslvlM3listenteros[contadorM3] = opcion3_3M * opcion4_3M; // le agregue un valor diferente a 0, 
            opcioneslvlM3[contadorM3] = opcion3_3M + " * " + opcion4_3M;

            // opcion 3
            contadorM3 = rndlvlS3.Next(4);
            while (opcioneslvlM3listenteros[contadorM3] != 0)
            {
                contadorM3 = rndlvlS3.Next(4);
            }
            opcioneslvlM3listenteros[contadorM3] = (opcion5_3M * opcion6_3M);// le agregue un valor diferente a 0, 
            opcioneslvlM3[contadorM3] = opcion5_3M + " * " + opcion6_3M;

            // resultado 
            contadorM3 = rndlvlS3.Next(4);
            while (opcioneslvlM3listenteros[contadorM3] != 0)
            {
                contadorM3 = rndlvlS3.Next(4);
            }
            opcioneslvlM3listenteros[contadorM3] = resultado_3M; // le agregue un valor diferente a 0
            opcioneslvlM3[contadorM3] = (aM3 + " * " + bM3);
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N3M()
        {
            return aM3;
        }
        public int retonar_numero2N3M()
        {
            return bM3;
        }
        public int retonar_resultadoN3M()
        {
            return resultado_3M;
        }
        public List<string> retornar_listaN3M()
        {
            return opcioneslvlM3;
        }
        public List<int> retornarlistaenterosM3()
        {
            return opcioneslvlM3listenteros;
        }
        public string quitapunteos_segundosN3M()
        {
            punteomaxM3 = punteomaxM3 - 2000;
            return Convert.ToString(punteomaxM3);
        }
        public string quitarpuntosN3M()
        {
            punteomaxM3 = punteomaxM3 - 20000;
            return Convert.ToString(punteomaxM3); /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        // Fin Nivel 3________________________________________________________________________________________________


        /*INIICIO NIVEL 4*/

        Random rndlvlM4 = new Random();

        private int aM4, bM4, opcion1_M4, opcion2_M4, opcion3_M4, resultado_M4, opcion4_M4, opcion5_M4, opcion6_M4,
                    punteomaxM4 = 130000, contadorM4; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlM4 = new List<string>();
        List<int> opcioneslvlMu4listenteros = new List<int>();

        public void generarlvlM4()
        {
            aM4 = rndlvlM4.Next(1, 16);
            bM4 = rndlvlM4.Next(1, 16);
            resultado_M4 = aM4 * bM4;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_M4 = rndlvlM4.Next(1, 50);
            opcion2_M4 = rndlvlM4.Next(1, 50);
            opcion3_M4 = rndlvlM4.Next(1, 50);
            opcion4_M4 = rndlvlM4.Next(1, 50);
            opcion5_M4 = rndlvlM4.Next(1, 50);
            opcion6_M4 = rndlvlM4.Next(1, 50);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y de esa forma respondr a la pregunta cual es menor */
            while (opcion1_M4 + opcion2_M4 <= resultado_M4)
            {
                opcion1_M4 = rndlvlM4.Next(1, 50);
                opcion2_M4 = rndlvlM4.Next(1, 50);
            }
            while ((opcion3_M4 * opcion4_M4 <= resultado_M4) || (opcion3_M4 * opcion4_M4 == opcion1_M4 * opcion2_M4))
            {
                opcion3_M4 = rndlvlM4.Next(1, 50);
                opcion4_M4 = rndlvlM4.Next(1, 50);
            }
            while ((opcion5_M4 * opcion6_M4 <= resultado_M4) || (opcion5_M4 * opcion6_M4 == opcion3_M4 * opcion4_M4) || (opcion5_M4 * opcion6_M4 == opcion1_M4 * opcion2_M4))
            {
                opcion5_M4 = rndlvlM4.Next(1, 50);
                opcion6_M4 = rndlvlM4.Next(1, 50);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlM4.Add(opcion1_M4 + " * " + opcion2_M4);
            opcioneslvlM4.Add(opcion3_M4 + " * " + opcion4_M4);
            opcioneslvlM4.Add(opcion5_M4 + " * " + opcion6_M4);
            opcioneslvlM4.Add(Convert.ToString(aM4) + " * " + Convert.ToString(bM4)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlMu4listenteros.Add(opcion1_M4 * opcion2_M4);
            opcioneslvlMu4listenteros.Add(opcion3_M4 * opcion4_M4);
            opcioneslvlMu4listenteros.Add(opcion5_M4 * opcion6_M4);
            opcioneslvlMu4listenteros.Add(aM4 + bM4);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlMu4listenteros[0] = 0;
            opcioneslvlMu4listenteros[1] = 0;
            opcioneslvlMu4listenteros[2] = 0;
            opcioneslvlMu4listenteros[3] = 0;

        }
        public void Respuesta_LvlM4()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorM4 = rndlvlM4.Next(4);
            opcioneslvlMu4listenteros[contadorM4] = opcion1_M4 + opcion2_M4;
            opcioneslvlM4[contadorM4] = opcion1_M4 + " * " + opcion2_M4;

            // opción 2 

            contadorM4 = rndlvlM4.Next(4);
            while (opcioneslvlMu4listenteros[contadorM4] != 0)
            {
                contadorM4 = rndlvlM4.Next(4);
            }
            opcioneslvlMu4listenteros[contadorM4] = opcion3_M4 + opcion4_M4; // le agregue un valor diferente a 0, 
            opcioneslvlM4[contadorM4] = opcion3_M4 + " * " + opcion4_M4;

            // opcion 3

            contadorM4 = rndlvlM4.Next(4);
            while (opcioneslvlMu4listenteros[contadorM4] != 0)
            {
                contadorM4 = rndlvlM4.Next(4);
            }
            opcioneslvlMu4listenteros[contadorM4] = (opcion5_M4 + opcion6_M4);// le agregue un valor diferente a 0, 
            opcioneslvlM4[contadorM4] = opcion5_M4 + " * " + opcion6_M4;

            // resultado 

            contadorM4 = rndlvlM4.Next(4);
            while (opcioneslvlMu4listenteros[contadorM4] != 0)
            {
                contadorM4 = rndlvlM4.Next(4);
            }
            opcioneslvlMu4listenteros[contadorM4] = resultado_M4; // le agregue un valor diferente a 0
            opcioneslvlM4[contadorM4] = (aM4 + " * " + bM4); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NM4()
        {
            return aM4;
        }
        public int retonar_numero2NM4()
        {
            return bM4;
        }
        public int retonar_resultadoNM4()
        {
            return resultado_M4;
        }
        public List<string> retornar_listaNM4()
        {
            return opcioneslvlM4;
        }
        public List<int> retornarlistaenterosM4()
        {
            return opcioneslvlMu4listenteros;
        }
        public string quitapunteos_segundosNM4()
        {
            punteomaxM4 = punteomaxM4 - 2167;
            return Convert.ToString(punteomaxM4);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN4M()
        {
            punteomaxM4 = punteomaxM4 - 20000;
            return Convert.ToString(punteomaxM4); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        /*INIICO NIVEL 5 (EL ULTIMO!!!!!) \O/*/

        Random rndlvlM5 = new Random();

        private int aM5, bM5, opcion1_M5, opcion2_M5, opcion3_M5, resultado_M5, opcion4_M5, opcion5_M5, opcion6_M5,
                    punteomaxM5 = 140000, contadorM5; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlM5 = new List<string>();
        List<int> opcioneslvlM5listenteros = new List<int>();

        public void generarlvlM5()
        {
            aM5 = rndlvlM5.Next(1, 16);
            bM5 = rndlvlM5.Next(1, 16);
            resultado_M5 = aM5 + bM5;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_M5 = rndlvlM5.Next(1, 50);
            opcion2_M5 = rndlvlM5.Next(1, 50);
            opcion3_M5 = rndlvlM5.Next(1, 50);
            opcion4_M5 = rndlvlM5.Next(1, 50);
            opcion5_M5 = rndlvlM5.Next(1, 50);
            opcion6_M5 = rndlvlM5.Next(1, 50);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y que sea solo esa opción la suma mayor necesaria para responder la pregunta*/
            while (opcion1_M5 + opcion2_M5 >= resultado_M5)
            {
                opcion1_M5 = rndlvlM5.Next(1, 50);
                opcion2_M5 = rndlvlM5.Next(1, 50);
            }
            while ((opcion3_M5 + opcion4_M5 >= resultado_M5) || (opcion3_M5 + opcion4_M5 == opcion1_M5 + opcion2_M5))
            {
                opcion3_M5 = rndlvlM5.Next(1, 50);
                opcion4_M5 = rndlvlM5.Next(1, 50);
            }
            while ((opcion5_M5 + opcion6_M5 >= resultado_M5) || (opcion5_M5 + opcion6_M5 == opcion3_M5 + opcion4_M5) || (opcion4_M5 + opcion6_M5 == opcion1_M5 + opcion2_M5))
            {
                opcion5_M5 = rndlvlM5.Next(1, 50);
                opcion6_M5 = rndlvlM5.Next(1, 50);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlM5.Add(opcion1_M5 + " * " + opcion2_M5);
            opcioneslvlM5.Add(opcion3_M5 + " *  " + opcion4_M5);
            opcioneslvlM5.Add(opcion5_M5 + " * " + opcion6_M5);
            opcioneslvlM5.Add(Convert.ToString(aM5) + " * " + Convert.ToString(bM5)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlM5listenteros.Add(opcion1_M5 * opcion2_M5);
            opcioneslvlM5listenteros.Add(opcion3_M5 * opcion4_M5);
            opcioneslvlM5listenteros.Add(opcion5_M5 * opcion6_M5);
            opcioneslvlM5listenteros.Add(aM5 * bM5);

            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlM5listenteros[0] = 0;
            opcioneslvlM5listenteros[1] = 0;
            opcioneslvlM5listenteros[2] = 0;
            opcioneslvlM5listenteros[3] = 0;

        }
        public void Respuesta_LvlM5()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorM5 = rndlvlM5.Next(4);
            opcioneslvlM5listenteros[contadorM5] = opcion1_M5 + opcion2_M5;
            opcioneslvlM5[contadorM5] = opcion1_M5 + " * " + opcion2_M5;

            // opción 2 

            contadorM5 = rndlvlM5.Next(4);
            while (opcioneslvlM5listenteros[contadorM5] != 0)
            {
                contadorM5 = rndlvlM5.Next(4);
            }
            opcioneslvlM5listenteros[contadorM5] = opcion3_M5 + opcion4_M5; // le agregue un valor diferente a 0, 
            opcioneslvlM5[contadorM5] = opcion3_M5 + " * " + opcion4_M5;

            // opcion 3

            contadorM5 = rndlvlM5.Next(4);
            while (opcioneslvlM5listenteros[contadorM5] != 0)
            {
                contadorM5 = rndlvlM5.Next(4);
            }
            opcioneslvlM5listenteros[contadorM5] = (opcion5_M5 + opcion6_M5);// le agregue un valor diferente a 0, 
            opcioneslvlM5[contadorM5] = opcion5_M5 + " * " + opcion6_M5;

            // resultado 

            contadorM5 = rndlvlM5.Next(4);
            while (opcioneslvlM5listenteros[contadorM5] != 0)
            {
                contadorM5 = rndlvlM5.Next(4);
            }
            opcioneslvlM5listenteros[contadorM5] = resultado_M5; // le agregue un valor diferente a 0
            opcioneslvlM5[contadorM5] = (aM5 + " * " + bM5); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NM5()
        {
            return aM5;
        }
        public int retonar_numero2NM5()
        {
            return bM5;
        }
        public int retonar_resultadoNM5()
        {
            return resultado_M5;
        }
        public List<string> retornar_listaNM5()
        {
            return opcioneslvlM5;
        }
        public List<int> retornarlistaenterosM5()
        {
            return opcioneslvlM5listenteros;
        }
        public string quitapunteos_segundosNM5()
        {
            punteomaxM5 = punteomaxM5 - 2333;
            return Convert.ToString(punteomaxM5);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN5M()
        {
            punteomaxM5 = punteomaxM5 - 20000;
            return Convert.ToString(punteomaxM5); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }
        //FIN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }
}
