using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class ClassResta_Niveles
    {
        Random rndlvlR1 = new Random();
        private int a1R, bR1, opcion1_1R, opcion2_1R, opcion3_1R, resultado1R = 0,
               punteomaxR1 = 100000, contadorR1;
        List<int> opcionesR1 = new List<int>();
        public void generarlvlR1()
        {
            a1R = rndlvlR1.Next(1, 16);
            bR1 = rndlvlR1.Next(1, 16);

            /*Con está condicioón buscara valores positivos y que el resultado de la resta me quede positivo */
            while (bR1 > a1R)
            {
                a1R = rndlvlR1.Next(1, 16);
            }
                resultado1R = a1R - bR1;
          
            opcion1_1R = rndlvlR1.Next(1, 31);
            opcion2_1R = rndlvlR1.Next(1, 31);
            opcion3_1R = rndlvlR1.Next(1, 31);
            
            if ((opcion1_1R == resultado1R) || (opcion1_1R == opcion1_R2) || (opcion1_R2 == opcion3_1R))
            {
                opcion1_1R = rndlvlR1.Next(1, 31);
            }
            if ((opcion2_1R == resultado1R) || (opcion2_1R == opcion1_1R) || (opcion2_1R == opcion3_1R))
            {
                opcion2_1R = rndlvlR1.Next(1, 31);
            }
            if ((opcion3_1R == resultado1R) || (opcion3_1R == opcion1_1R) || (opcion3_1R == opcion2_1R))
            {
                opcion3_1R = rndlvlR1.Next(1, 31);
            }

            opcionesR1.Add(opcion1_1R);
            opcionesR1.Add(opcion2_1R);
            opcionesR1.Add(opcion3_1R);
            opcionesR1.Add(resultado1R);
            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcionesR1[0] = 0;
            opcionesR1[1] = 0;
            opcionesR1[2] = 0;
            opcionesR1[3] = 0;

        }
        public void Respuesta_LvR1()
        {/* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */
            //Opcion 1 que me devuleve un valor 
            contadorR1 = rndlvlR1.Next(4);
            opcionesR1[contadorR1] = opcion1_1R;

            // opción 2 
            while (opcionesR1[contadorR1] != 0)
            {
                contadorR1 = rndlvlR1.Next(4);
            }
            opcionesR1[contadorR1] = opcion2_1R;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opcionesR1[contadorR1] != 0)
            {
                contadorR1 = rndlvlR1.Next(4);
            }
            opcionesR1[contadorR1] = opcion3_1R;// le agregue un valor diferente a 0, 

            // resultado 
            while (opcionesR1[contadorR1] != 0)
            {
                contadorR1 = rndlvlR1.Next(4);
            }
            opcionesR1[contadorR1] = resultado1R;// le agregue un valor diferente a 0
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N1R()
        {
            return a1R;
        }
        public int retonar_numero2N1R()
        {
            return bR1;
        }
        public int retonar_resultadoN1R()
        {
            return resultado1R;
        }
        public List<int> retornar_listaN1R()
        {
            return opcionesR1;
        }
        public string punteosN1R()
        {
            punteomaxR1 = punteomaxR1 - 1667;
            return Convert.ToString(punteomaxR1);
        }
        public string quitarpuntosN1R()
        {
            punteomaxR1 = punteomaxR1 - 20000;
            return Convert.ToString(punteomaxR1);
        }
        /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */

        /*Fin Nivel 1__________________________________________________________________________________________________________*/



        /*Inicio Segundo Nivel*/

        /*solo tengo que cambiar el nombre a las variable ya que el concepto de este segundo nivel es el mismo que el lv1
         solo que cambia a la hora de dar el resultado */
        Random rndlv2R = new Random();
        private int a2R, b2R, opcion1_R2, opcion2_R2, opcion3_R2, resultado_R2,
                    punteomaxR2 = 110000, contador2R, c2R;

        List<int> opcioneslvlR2 = new List<int>();
        public void generarlvlR2()
        {
            a2R = rndlv2R.Next(1, 16);
            b2R = rndlv2R.Next(1, 16);
            while (b2R > a2R)
            {
                b2R = rndlv2R.Next(1, 16);
            }
            resultado_R2 = a2R - b2R;
            c2R = a2R - resultado_R2; /*esta variable c2 es el resultad de b2 el cual necesito encontrar */

            opcion1_R2 = rndlv2R.Next(1, 31);
            opcion2_R2 = rndlv2R.Next(1, 31);
            opcion3_R2 = rndlv2R.Next(1, 31);

            if ((opcion1_R2 == c2R) || (opcion1_R2 == opcion2_R2) || (opcion1_R2 == opcion3_R2))
            {
                opcion1_R2 = rndlv2R.Next(1, 31);
            }
            if (opcion2_R2 == c2R)
            {
                opcion2_R2 = rndlv2R.Next(1, 31);
            }
            if (opcion3_R2 == c2R)
            {
                opcion3_R2 = rndlv2R.Next(1, 31);
            }

            opcioneslvlR2.Add(opcion1_R2);
            opcioneslvlR2.Add(opcion2_R2);
            opcioneslvlR2.Add(opcion3_R2);
            opcioneslvlR2.Add(resultado_R2);
            opcioneslvlR2.Add(c2R);
           
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcioneslvlR2[0] = 0;
            opcioneslvlR2[1] = 0;
            opcioneslvlR2[2] = 0;
            opcioneslvlR2[3] = 0;

        }
        public void Respuesta_Lv2()
        {
            //opcion 1 
            contador2R = rndlv2R.Next(4);
            opcioneslvlR2[contador2R] = opcion1_R2;

            // opción 2 
            while (opcioneslvlR2[contador2R] != 0)
            {
                contador2R = rndlv2R.Next(4);
            }
            opcioneslvlR2[contador2R] = opcion2_R2;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opcioneslvlR2[contador2R] != 0)
            {
                contador2R = rndlv2R.Next(4);
            }
            opcioneslvlR2[contador2R] = opcion3_R2;// le agregue un valor diferente a 0, 

            // resultado 
            while (opcioneslvlR2[contador2R] != 0)
            {
                contador2R = rndlv2R.Next(4);
            }
            opcioneslvlR2[contador2R] = c2R;// le agregue un valor diferente a 0
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N2R()
        {
            return a2R;
        }
        public int retonar_numero2N2R()
        {
            return b2R;
        }
        public int retonar_resultadoN2R()
        {
            return resultado_R2;
        }
        public int retonar_resucN2R()
        {
            return c2R;
        }
        public List<int> retornar_listaN2R()
        {
            return opcioneslvlR2;
        }
        public string quitapunteos_segundosN2R()
        {
            punteomaxR2 = punteomaxR2 - 1833;
            return Convert.ToString(punteomaxR2);
        }
        public string quitarpuntosN2R()
        {
            punteomaxR2 = punteomaxR2 - 20000;
            return Convert.ToString(punteomaxR2); /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }
        /*Fin Nivel 2____________________________________________________________________________________________________*/


        /*Iniciar Nivel 3 */

        Random rndLvlR3 = new Random();
        private int a3R, b3R, opcion1_R3, opcion2_R3, opcion3_R3, opcion4_R3, opcion5_R3, opcion6_R3, resultado_R3,
                    punteomaxR3 = 120000, contadorR3;

         List<string> opcioneslvlR3 = new List<string>();
        List<int> opcioneslvlR3listenteros = new List<int>(); 
        
        public void generarlvlR3()
        {
            a3R = rndLvlR3.Next(1, 16);
            b3R = rndLvlR3.Next(1, 16);
            while ( b3R > a3R)
            {
                b3R = rndLvlR3.Next(1, 16);
            }
            resultado_R3 = a3R - b3R;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/
           
            opcion1_R3 = rndLvlR3.Next(1, 31);
            opcion2_R3 = rndLvlR3.Next(1, 31);
            opcion3_R3 = rndLvlR3.Next(1, 31);
            opcion4_R3 = rndLvlR3.Next(1, 31);
            opcion5_R3 = rndLvlR3.Next(1, 31);
            opcion5_R3 = rndLvlR3.Next(1, 31);
            opcion6_R3 = rndLvlR3.Next(1, 31);

            /*para que las incognitas no sean iguales a resutado se condicionan*/

            if (opcion1_R3 == resultado_R3)
            {
                opcion1_R3 = rndLvlR3.Next(1, 31);
            }
            if (opcion2_R3 == resultado_R3)
            {
                opcion2_R3 = rndLvlR3.Next(1, 31);
            }
            if (opcion3_R3 == resultado_R3)
            {
                opcion3_R3 = rndLvlR3.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlR3.Add(opcion1_R3 + " - " + opcion2_R3);
            opcioneslvlR3.Add(opcion3_R3 + " - " + opcion4_R3);
            opcioneslvlR3.Add(opcion5_R3 + " - " + opcion6_R3);
            opcioneslvlR3.Add(Convert.ToString(a3R) + " + " + Convert.ToString(b3R));
            /*Aqui los valores se guardan como digitos y no como cadenas como en el anterior */
            opcioneslvlR3listenteros.Add(opcion1_R3 + opcion2_R3);
            opcioneslvlR3listenteros.Add(opcion3_R3 + opcion4_R3);
            opcioneslvlR3listenteros.Add(opcion5_R3 + opcion6_R3);
            opcioneslvlR3listenteros.Add(a3R + b3R); 

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlR3listenteros[0] = 0;
            opcioneslvlR3listenteros[1] = 0;
            opcioneslvlR3listenteros[2] = 0;
            opcioneslvlR3listenteros[3] = 0; 
            
        }
        public void Respuesta_LvlR3()
        {
            //opcion 1 
            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */
            contadorR3 = rndLvlR3.Next(4);
            opcioneslvlR3listenteros[contadorR3] = opcion1_R3 + opcion2_R3;
            opcioneslvlR3[contadorR3] = opcion1_R3 + " - " + opcion2_R3; 

            // opción 2 
            contadorR3 = rndLvlR3.Next(4);
            while (opcioneslvlR3listenteros[contadorR3] != 0)
            {
                contadorR3 = rndLvlR3.Next(4);
            }
            opcioneslvlR3listenteros[contadorR3] = opcion3_R3 + opcion4_R3; // le agregue un valor diferente a 0, 
            opcioneslvlR3[contadorR3] = opcion3_R3 + " - " + opcion4_R3;

            // opcion 3
            contadorR3 = rndLvlR3.Next(4);
            while (opcioneslvlR3listenteros[contadorR3] != 0)
            {
                contadorR3 = rndLvlR3.Next(4);
            }
            opcioneslvlR3listenteros[contadorR3] = (opcion5_R3 + opcion6_R3);// le agregue un valor diferente a 0, 
            opcioneslvlR3[contadorR3] = opcion5_R3 + " -" + opcion6_R3;

            // resultado 
            contadorR3 = rndLvlR3.Next(4);
            while (opcioneslvlR3listenteros[contadorR3] != 0)
            {
                contadorR3 = rndLvlR3.Next(4);
            }
            opcioneslvlR3listenteros[contadorR3] = resultado_R3; // le agregue un valor diferente a 0
            opcioneslvlR3[contadorR3] = (a3R + " - " + b3R);
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N32R()
        {
            return a3R;
        }
        public int retonar_numero2N32R()
        {
            return b3R;
        }
        public int retonar_resultadoN3R()
        {
            return resultado_R3;
        }
        public List<string> retornar_lista_cadena_N3R()
        {
            return opcioneslvlR3; 
        }
        public List<int> retornarlistaenterosResta()
        {
            return opcioneslvlR3listenteros; 
        }
        /*el punteo a quitar ya sea por segundo o respuesta mala se repetira en los demas Mundos que contengan Nivel 3 ya que 
         es una regla del juego */
        public string quitapunteos_segundosN3R()
        {
            punteomaxR3 = punteomaxR3 - 2000;
            return Convert.ToString(punteomaxR3);
        }
        public string quitarpuntosN3R()
        {
            punteomaxR3 = punteomaxR3 - 20000;
            return Convert.ToString(punteomaxR3); /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        // Fin Nivel 3________________________________________________________________________________________________


        /*INIICIO NIVEL 4*/

        Random rndlvlR4 = new Random();

        private int aR4, bR4, opcion1_R4, opcion2_R4, opcion3_R4, resultado_R4, opcion4_R4, opcion5_R4, opcion6_R4,
                    punteomaxS4 = 130000, contadorR4; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlR4 = new List<string>();
        List<int> opcioneslvlR4listenteros = new List<int>();

        public void generarlvlR4()
        {
            aR4 = rndlvlR4.Next(1, 16);
            bR4 = rndlvlR4.Next(1, 16);
            while (bR4 > aR4)
            {
                bR4 = rndlvlR4.Next(1, 16);
            }
            resultado_R4 = aR4 - bR4;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_R4 = rndlvlR4.Next(1, 31);
            opcion2_R4 = rndlvlR4.Next(1, 31);
            opcion3_R4 = rndlvlR4.Next(1, 31);
            opcion4_R4 = rndlvlR4.Next(1, 31);
            opcion5_R4 = rndlvlR4.Next(1, 31);
            opcion6_R4 = rndlvlR4.Next(1, 31);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y de esa forma respondr a la pregunta cual es menor */
            while (opcion1_R4 - opcion2_R4 <= resultado_R4)
            {
                opcion1_R4 = rndlvlR4.Next(1, 31);
                opcion2_R4 = rndlvlR4.Next(1, 31);
            }
            while ((opcion3_R4 - opcion4_R4 <= resultado_R4) || (opcion3_R4 - opcion4_R4 == opcion1_R4 - opcion2_R4))
            {
                opcion3_R4 = rndlvlR4.Next(1, 31);
                opcion4_R4 = rndlvlR4.Next(1, 31);
            }
            while ((opcion5_R4 - opcion6_R4 <= resultado_R4) || (opcion5_R4 - opcion6_R4 == opcion3_R4 - opcion4_R4) || (opcion5_R4 - opcion6_R4 == opcion1_R4 - opcion2_R4))
            {
                opcion5_R4 = rndlvlR4.Next(1, 31);
                opcion6_R4 = rndlvlR4.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlR4.Add(opcion1_R4 + " - " + opcion2_R4);
            opcioneslvlR4.Add(opcion3_R4 + " - " + opcion4_R4);
            opcioneslvlR4.Add(opcion5_R4 + " - " + opcion6_R4);
            opcioneslvlR4.Add(Convert.ToString(aR4) + " - " + Convert.ToString(bR4)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlR4listenteros.Add(opcion1_R4 - opcion2_R4);
            opcioneslvlR4listenteros.Add(opcion3_R4 - opcion4_R4);
            opcioneslvlR4listenteros.Add(opcion5_R4 - opcion6_R4);
            opcioneslvlR4listenteros.Add(aR4 - bR4);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlR4listenteros[0] = 0;
            opcioneslvlR4listenteros[1] = 0;
            opcioneslvlR4listenteros[2] = 0;
            opcioneslvlR4listenteros[3] = 0;

        }
        public void Respuesta_LvlR4()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorR4 = rndlvlR4.Next(4);
            opcioneslvlR4listenteros[contadorR4] = opcion1_R4 + opcion2_R4;
            opcioneslvlR4[contadorR4] = opcion1_R4 + " - " + opcion2_R4;

            // opción 2 

            contadorR4 = rndlvlR4.Next(4);
            while (opcioneslvlR4listenteros[contadorR4] != 0)
            {
                contadorR4 = rndlvlR4.Next(4);
            }
            opcioneslvlR4listenteros[contadorR4] = opcion3_R4 + opcion4_R4; // le agregue un valor diferente a 0, 
            opcioneslvlR4[contadorR4] = opcion3_R4 + " - " + opcion4_R4;

            // opcion 3

            contadorR4 = rndlvlR4.Next(4);
            while (opcioneslvlR4listenteros[contadorR4] != 0)
            {
                contadorR4 = rndlvlR4.Next(4);
            }
            opcioneslvlR4listenteros[contadorR4] = (opcion5_R4 + opcion6_R4);// le agregue un valor diferente a 0, 
            opcioneslvlR4[contadorR4] = opcion5_R4 + " - " + opcion6_R4;

            // resultado 

            contadorR4 = rndlvlR4.Next(4);
            while (opcioneslvlR4listenteros[contadorR4] != 0)
            {
                contadorR4 = rndlvlR4.Next(4);
            }
            opcioneslvlR4listenteros[contadorR4] = resultado_R4; // le agregue un valor diferente a 0
            opcioneslvlR4[contadorR4] = (aR4 + " - " + bR4); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NR4()
        {
            return aR4;
        }
        public int retonar_numero2NR4()
        {
            return bR4;
        }
        public int retonar_resultadoNR4()
        {
            return resultado_R4;
        }
        public List<string> retornar_listaNR4()
        {
            return opcioneslvlR4;
        }
        public List<int> retornarlistaenterosR4()
        {
            return opcioneslvlR4listenteros;
        }
        public string quitapunteos_segundosNR4()
        {
            punteomaxS4 = punteomaxS4 - 2167;
            return Convert.ToString(punteomaxS4);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN4R()
        {
            punteomaxS4 = punteomaxS4 - 20000;
            return Convert.ToString(punteomaxS4); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        //FIN NIVEL 4___________________________________________________________________________________________________

        /*INICIO NIVEL 5*/

        Random rndlvlR5 = new Random();

        private int aR5, bR5, opcion1_R5, opcion2_R5, opcion3_R5, resultado_R5, opcion4_R5, opcion5_R5, opcion6_R5,
                    punteomaxR5 = 140000, contadorR5; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlR5 = new List<string>();
        List<int> opcioneslvlR5listenteros = new List<int>();

        public void generarlvlR5()
        {
            aR5 = rndlvlR5.Next(1, 16);
            bR5 = rndlvlR5.Next(1, 16);
            while (bR5 > aR5)
            {
                bR5 = rndlvlR4.Next(1, 16);
            }
            resultado_R5 = aR5 - bR5;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_R5 = rndlvlR5.Next(1, 31);
            opcion2_R5 = rndlvlR5.Next(1, 31);
            opcion3_R5 = rndlvlR5.Next(1, 31);
            opcion4_R5 = rndlvlR5.Next(1, 31);
            opcion5_R5 = rndlvlR5.Next(1, 31);
            opcion6_R5 = rndlvlR5.Next(1, 31);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y de esa forma respondr a la pregunta cual es menor */
            while (opcion1_R5 - opcion2_R5 >= resultado_R5)
            {
                opcion1_R5 = rndlvlR5.Next(1, 31);
                opcion2_R5 = rndlvlR5.Next(1, 31);
            }
            while ((opcion3_R5 - opcion4_R5 >= resultado_R5) || (opcion3_R5 - opcion4_R5 == opcion1_R5 - opcion2_R5))
            {
                opcion3_R5 = rndlvlR5.Next(1, 31);
                opcion4_R5 = rndlvlR5.Next(1, 31);
            }
            while ((opcion5_R5 - opcion6_R5 >= resultado_R5) || (opcion5_R5 - opcion6_R5 == opcion3_R5 - opcion4_R5) || (opcion5_R5 - opcion6_R5 == opcion1_R5 - opcion2_R5))
            {
                opcion5_R4 = rndlvlR5.Next(1, 31);
                opcion6_R4 = rndlvlR5.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlR5.Add(opcion1_R4 + " - " + opcion2_R4);
            opcioneslvlR5.Add(opcion3_R4 + " - " + opcion4_R4);
            opcioneslvlR5.Add(opcion5_R4 + " - " + opcion6_R4);
            opcioneslvlR5.Add(Convert.ToString(aR4) + " - " + Convert.ToString(bR4)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlR5listenteros.Add(opcion1_R4 - opcion2_R4);
            opcioneslvlR5listenteros.Add(opcion3_R4 - opcion4_R4);
            opcioneslvlR5listenteros.Add(opcion5_R4 - opcion6_R4);
            opcioneslvlR5listenteros.Add(aR4 - bR4);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlR5listenteros[0] = 0;
            opcioneslvlR5listenteros[1] = 0;
            opcioneslvlR5listenteros[2] = 0;
            opcioneslvlR5listenteros[3] = 0;

        }
        public void Respuesta_LvlR5()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorR5 = rndlvlR5.Next(4);
            opcioneslvlR5listenteros[contadorR5] = opcion1_R5 + opcion2_R5;
            opcioneslvlR5[contadorR4] = opcion1_R5 + " - " + opcion2_R5;

            // opción 2 

            contadorR5 = rndlvlR5.Next(4);
            while (opcioneslvlR5listenteros[contadorR5] != 0)
            {
                contadorR5 = rndlvlR5.Next(4);
            }
            opcioneslvlR5listenteros[contadorR5] = opcion3_R5 + opcion4_R5; // le agregue un valor diferente a 0, 
            opcioneslvlR5[contadorR5] = opcion3_R5 + " - " + opcion4_R5;

            // opcion 3

            contadorR5 = rndlvlR5.Next(4);
            while (opcioneslvlR4listenteros[contadorR5] != 0)
            {
                contadorR5 = rndlvlR5.Next(4);
            }
            opcioneslvlR5listenteros[contadorR4] = (opcion5_R5 + opcion6_R5);// le agregue un valor diferente a 0, 
            opcioneslvlR5[contadorR4] = opcion5_R5 + " - " + opcion6_R5;

            // resultado 

            contadorR5 = rndlvlR5.Next(4);
            while (opcioneslvlR4listenteros[contadorR5] != 0)
            {
                contadorR5 = rndlvlR5.Next(4);
            }
            opcioneslvlR5listenteros[contadorR5] = resultado_R5; // le agregue un valor diferente a 0
            opcioneslvlR5[contadorR5] = (aR5 + " - " + bR5); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NR5()
        {
            return aR5;
        }
        public int retonar_numero2NR5()
        {
            return bR5;
        }
        public int retonar_resultadoNR5()
        {
            return resultado_R5;
        }
        public List<string> retornar_listaNR5()
        {
            return opcioneslvlR5;
        }
        public List<int> retornarlistaenterosR5()
        {
            return opcioneslvlR5listenteros;
        }
        public string quitapunteos_segundosNR5()
        {
            punteomaxR5 = punteomaxR5 - 2333;
            return Convert.ToString(punteomaxR5);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN5R()
        {
            punteomaxR5 = punteomaxR5 - 20000;
            return Convert.ToString(punteomaxR5); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

    }
}
