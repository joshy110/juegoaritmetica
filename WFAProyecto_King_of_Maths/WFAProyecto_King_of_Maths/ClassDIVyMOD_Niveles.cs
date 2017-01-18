using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class ClassDIVyMOD_Niveles
    {
        /*empezare con el nivel DIV y MOD en el nivel 1 se trabajara solo DIV(/) y en el nivel 2 se trabajara solo MOD(%)*/
        Random rndlvlMOD = new Random();
        private int n1_1MOD, n2_1MOD, opcion1_1MOD, opcion2_1MOD, opcion3_1MOD, resultado1MOD = 0, punteomax1MOD = 100000, contador1MOD;

        List<int> opcionesMOD1 = new List<int>();

        public void generarlvl1MOD()
        {
            n1_1MOD = rndlvlMOD.Next(1, 16);// colocarle al random número de entre 1 a 16 para que me los lance en el label 
            n2_1MOD = rndlvlMOD.Next(1, 16);// lo mismo que el n1 solo que en este caso que me los coloque en el n2 
            while (n2_1MOD > n1_1MOD)
            {
                n2_1MOD = rndlvlMOD.Next(1, 16);
            }
            resultado1MOD = n1_1MOD % n2_1MOD; 

            opcion1_1MOD = rndlvlMOD.Next(1, 31);/* Estas opciones seran los bototnes en mi fomar y se les agrega un random de números de entre 1 a 31 
                                                  ya que seran mis posibles respuestas de la suma de resulatad*/
            opcion2_1MOD = rndlvlMOD.Next(1, 31);/* lo mismo sucede en esta opción 2 y en la opción 3 */
            opcion3_1MOD = rndlvlMOD.Next(1, 31);
            /* se condicionara al resultado de modo que las opciones no deban ser igual a él ya que de serlo 
             * provocaría un error que no queremos que suceda*/
            /* ahora se condicionan los valores para que no se repitan los numeros en los botones de la forma */
            if ((opcion1_1MOD == resultado1MOD) || (opcion1_1MOD == opcion2_1MOD) || (opcion1_1MOD == opcion3_1MOD))
            {
                opcion1_1MOD = rndlvlMOD.Next(1, 31);
            }
            if ((opcion2_1MOD == resultado1MOD) || (opcion2_1MOD == opcion1_1MOD) || (opcion2_1MOD == opcion3_1MOD))
            {
                opcion2_1MOD = rndlvlMOD.Next(1, 31);
            }
            if ((opcion3_1MOD == resultado1MOD) || (opcion3_1MOD == opcion1_1MOD) || (opcion3_1MOD == opcion2_1MOD))
            {
                opcion3_1MOD = rndlvlMOD.Next(1, 31);
            }

            opcionesMOD1.Add(opcion1_1MOD);
            opcionesMOD1.Add(opcion2_1MOD);
            opcionesMOD1.Add(opcion3_1MOD);
            opcionesMOD1.Add(resultado1MOD);
            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcionesMOD1[0] = 0;
            opcionesMOD1[1] = 0;
            opcionesMOD1[2] = 0;
            opcionesMOD1[3] = 0;

        }
        public void Respuesta_Lv1MOD()
        {/* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */
            //Opcion 1 que me devuleve un valor 
            contador1MOD = rndlvlMOD.Next(4);
            opcionesMOD1[contador1MOD] = opcion1_1MOD;

            // opción 2 
            while (opcionesMOD1[contador1MOD] != 0)
            {
                contador1MOD = rndlvlMOD.Next(4);
            }
            opcionesMOD1[contador1MOD] = opcion2_1MOD;// le agregue un valor diferente a 0, 

            // opcion 3
            while (opcionesMOD1[contador1MOD] != 0)
            {
                contador1MOD = rndlvlMOD.Next(4);
            }
            opcionesMOD1[contador1MOD] = opcion3_1MOD;// le agregue un valor diferente a 0, 

            // resultado 
            while (opcionesMOD1[contador1MOD] != 0)
            {
                contador1MOD = rndlvlMOD.Next(4);
            }
            opcionesMOD1[contador1MOD] = resultado1MOD;// le agregue un valor diferente a 0
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N1MOD()
        {
            return n1_1MOD;
        }
        public int retonar_numero2N1MOD()
        {
            return n2_1MOD;
        }
        public int retonar_resultadoN1MOD()
        {
            return resultado1MOD;
        }
        public List<int> retornar_listaN1MOD()
        {
            return opcionesMOD1;
        }
        public string quitarpunteos_segundosN1MOD()
        {
            punteomax1MOD = punteomax1MOD - 1667;
            return Convert.ToString(punteomax1MOD);
        }
        public string quitarpuntosN1MOD()
        {
            punteomax1MOD = punteomax1MOD - 20000;
            return Convert.ToString(punteomax1MOD);
        }
        /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        /*Fin Nivel 1__________________________________________________________________________________________________________*/



        /*Inicio Segundo Nivel*/

       /*En esté nivel solo se trabajara con el MOD % para que el usuario se vata acostumbrado a trabajar con este tipo de operaciones*/
        Random rndlvl2DIV = new Random();
        private int a1DIV2, b2DIV2, resultadoDIV2, opcion1DIV2, opcion2DIV2, opcion3DIV2, punteomaxDIV2 = 110000,
                    contadorDIV2;

        /*se agrega otra lista solo que está contiene cadena de caracteres */

        List<int> opcionesDIV2 = new List<int>();

        public void generarlvlDIV2()
        {
            a1DIV2 = rndlvl2DIV.Next(1, 16);
            resultadoDIV2 = rndlvl2DIV.Next(1, 16);

           /* while (b2DIV2 > a1DIV2)
            {
                b2DIV2 = rndlvl2DIV.Next(1, 16);   
            }*/
            if (resultadoDIV2 == 0) 
            {
                resultadoDIV2 = rndlvl2DIV.Next(1, 16); // en caso que resultado sea igual a 0 se busca otro random del resultado
            }
           while ((a1DIV2 == 0) || (resultadoDIV2 > a1DIV2)) // se utiliza un while para agregar un numero random si la condicion no se cumple
            {

                a1DIV2 = rndlvl2DIV.Next(1, 16);
            }
            b2DIV2 = a1DIV2 / resultadoDIV2;

            opcion1DIV2 = rndlvl2DIV.Next(1, 16); // agrego random a las ocpiones. 
            opcion2DIV2 = rndlvl2DIV.Next(1, 16);
            opcion3DIV2 = rndlvl2DIV.Next(1, 16);
            // condicono las opciones 

            if ((opcion1DIV2 == b2DIV2) || (opcion1DIV2 == opcion2DIV2) || (opcion1DIV2 == opcion3DIV2))
            {
                opcion1DIV2 = rndlvl2DIV.Next(1, 16);
            }
            if ((opcion2DIV2 == b2DIV2) || (opcion2DIV2 == opcion1DIV2) || (opcion2DIV2 == opcion3DIV2))
            {
                opcion2DIV2 = rndlvl2DIV.Next(1, 16);
            }
            if ((opcion3DIV2 == b2DIV2) || (opcion3DIV2 == opcion1DIV2) || (opcion3DIV2 == opcion2DIV2 ))
            {
                opcion3DIV2 = rndlvl2DIV.Next(1, 16);
            }

            /*datos lista enteros */
            opcionesDIV2.Add(opcion1DIV2);
            opcionesDIV2.Add(opcion2DIV2);
            opcionesDIV2.Add(opcion3DIV2);
            opcionesDIV2.Add(b2DIV2); 
            //opcionesDIV2.Add(resultadoDIV2);
            

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcionesDIV2[0] = 0;
            opcionesDIV2[1] = 0;
            opcionesDIV2[2] = 0;
            opcionesDIV2[3] = 0;

        }
        public void Respuesta_Lv1DIV2()
        {
            /* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */

            //Opcion 1 que me devuleve un valor 
            contadorDIV2 = rndlvl2DIV.Next(4);
            opcionesDIV2[contadorDIV2] = opcion1DIV2;

            // opción 2 
            while (opcionesDIV2[contadorDIV2] != 0)
            {
                contadorDIV2 = rndlvl2DIV.Next(4);
            }
            opcionesDIV2[contadorDIV2] = opcion2DIV2; // le agregue un valor diferente a 0, 

            // opcion 3
            while (opcionesDIV2[contadorDIV2] != 0)
            {
                contadorDIV2 = rndlvl2DIV.Next(4);
            }
            opcionesDIV2[contadorDIV2] = opcion3DIV2; // le agregue un valor diferente a 0, 


            // resultado es decir la incognita 
            while (opcionesDIV2[contadorDIV2] != 0)
            {
                contadorDIV2 = rndlvl2DIV.Next(4);
            }
            opcionesDIV2[contadorDIV2] = b2DIV2; // le agregue un valor diferente a 0

        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N2DIV()
        {
            return a1DIV2;
        }
        public int retonar_numero2N2DIV()
        {
            return b2DIV2;
        }
        public int retonar_resultadp2N2DIV()
        {
            return resultadoDIV2;
        }
        public List<int> retornar_listaN2DIV()
        {
            return opcionesDIV2;
        }
        public string quitapunteos_SeguN2DIV()
        {
            punteomaxDIV2 = punteomaxDIV2 - 1833;
            return Convert.ToString(punteomaxDIV2);
        }
        public string quitarpuntosN2DIV()
        {
            punteomaxDIV2 = punteomaxDIV2 - 20000;
            return Convert.ToString(punteomaxDIV2);
        }

        /*Fin Nivel 2____________________________________________________________________________________________________*/
        //
        //

        /*Inicio Nivel 3*/

        Random rndlvlDIV3 = new Random();

        private int aDIV3, bDIV3, opcion1_DIV3, opcion2_DIV3, opcion3_DIV3, resultado_DIV3, opcion4_DIV3, opcion5_DIV3, opcion6_DIV3,
                    punteomaxDIV3 = 120000, contadorDIV3; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlSDIV3_Cadena = new List<string>();
        List<int> opcioneslvlDIV3_enteros = new List<int>();

        public void generarlvlDIV3()
        {
            aDIV3 = rndlvlDIV3.Next(1, 16);
            bDIV3 = rndlvlDIV3.Next(1, 16);
            resultado_DIV3 = aDIV3 / bDIV3;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_DIV3 = rndlvlDIV3.Next(1, 31);
            opcion2_DIV3 = rndlvlDIV3.Next(1, 31);
            opcion3_DIV3 = rndlvlDIV3.Next(1, 31);
            opcion4_DIV3 = rndlvlDIV3.Next(1, 31);
            opcion5_DIV3 = rndlvlDIV3.Next(1, 31);
            opcion6_DIV3 = rndlvlDIV3.Next(1, 31);

            if (opcion1_DIV3 == resultado_DIV3)
            {
                opcion1_DIV3 = rndlvlDIV3.Next(1, 31);
            }
            if (opcion2_DIV3 == resultado_DIV3)
            {
                opcion2_DIV3 = rndlvlDIV3.Next(1, 31);
            }
            if (opcion3_DIV3 == resultado_DIV3)
            {
                opcion3_DIV3 = rndlvlDIV3.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlSDIV3_Cadena.Add(opcion1_DIV3 + " / " + opcion2_DIV3);
            opcioneslvlSDIV3_Cadena.Add(opcion3_DIV3 + " / " + opcion4_DIV3);
            opcioneslvlSDIV3_Cadena.Add(opcion5_DIV3 + " / " + opcion6_DIV3);
            opcioneslvlSDIV3_Cadena.Add(Convert.ToString(aDIV3) + " / " + Convert.ToString(bDIV3)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlDIV3_enteros.Add(opcion1_DIV3 / opcion2_DIV3);
            opcioneslvlDIV3_enteros.Add(opcion3_DIV3 / opcion4_DIV3);
            opcioneslvlDIV3_enteros.Add(opcion5_DIV3 / opcion6_DIV3);
            opcioneslvlDIV3_enteros.Add(aDIV3 / bDIV3);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlDIV3_enteros[0] = 0;
            opcioneslvlDIV3_enteros[1] = 0;
            opcioneslvlDIV3_enteros[2] = 0;
            opcioneslvlDIV3_enteros[3] = 0;

        }
        public void Respuesta_LvlDIV3()
        {
            //opcion 1 
            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */
            contadorDIV3 = rndlvlDIV3.Next(4);
            opcioneslvlDIV3_enteros[contadorDIV3] = opcion1_DIV3 + opcion2_DIV3;
            opcioneslvlSDIV3_Cadena[contadorDIV3] = opcion1_DIV3 + " / " + opcion2_DIV3;

            // opción 2 
            contadorDIV3 = rndlvlDIV3.Next(4);
            while (opcioneslvlDIV3_enteros[contadorDIV3] != 0)
            {
                contadorDIV3 = rndlvlDIV3.Next(4);
            }
            opcioneslvlDIV3_enteros[contadorDIV3] = opcion3_DIV3 + opcion4_DIV3; // le agregue un valor diferente a 0, 
            opcioneslvlSDIV3_Cadena[contadorDIV3] = opcion3_DIV3 + " / " + opcion4_DIV3;

            // opcion 3
            contadorDIV3 = rndlvlDIV3.Next(4);
            while (opcioneslvlDIV3_enteros[contadorDIV3] != 0)
            {
                contadorDIV3 = rndlvlDIV3.Next(4);
            }
            opcioneslvlDIV3_enteros[contadorDIV3] = (opcion5_DIV3 + opcion6_DIV3);// le agregue un valor diferente a 0, 
            opcioneslvlSDIV3_Cadena[contadorDIV3] = opcion5_DIV3 + " / " + opcion6_DIV3;

            // resultado 
            contadorDIV3 = rndlvlDIV3.Next(4);
            while (opcioneslvlDIV3_enteros[contadorDIV3] != 0)
            {
                contadorDIV3 = rndlvlDIV3.Next(4);
            }
            opcioneslvlDIV3_enteros[contadorDIV3] = resultado_DIV3; // le agregue un valor diferente a 0
            opcioneslvlSDIV3_Cadena[contadorDIV3] = (aDIV3 + " / " + bDIV3); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N3DIV()
        {
            return aDIV3;
        }
        public int retonar_numero2N3DIV()
        {
            return bDIV3;
        }
        public int retonar_resultadoN3DIV()
        {
            return resultado_DIV3;
        }
        public List<string> retornar_listaN3DIV()
        {
            return opcioneslvlSDIV3_Cadena;
        }
        public List<int> retornarlistaenterosDIV3()
        {
            return opcioneslvlDIV3_enteros;
        }
        public string quitapunteos_segundosN3DIV()
        {
            punteomaxDIV3 = punteomaxDIV3 - 2000;
            return Convert.ToString(punteomaxDIV3);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN3DIV()
        {
            punteomaxDIV3 = punteomaxDIV3 - 20000;
            return Convert.ToString(punteomaxDIV3); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        // Fin Nivel 3________________________________________________________________________________________________

        /*Inicio Nivel 4 */
        Random rndlvlDyMOD4 = new Random();

        private int aMOD4, bMOD4, opcion1_MOD4, opcion2_MOD4, opcion3_MOD4, resultado_MOD4, opcion4_MOD4, opcion5_MOD4, opcion6_MOD4,
                    punteomaxMOD4 = 130000, contadorMOD4; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlDIVyMOD4 = new List<string>();
        List<int> opcioneslvlDIVyMOD4listenteros = new List<int>();

        public void generarlvlDIVyMOD4()
        {
            aMOD4 = rndlvlDyMOD4.Next(1, 16);
            bMOD4 = rndlvlDyMOD4.Next(1, 16);
            resultado_MOD4 = aMOD4 % bMOD4;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_MOD4 = rndlvlDyMOD4.Next(1, 31);
            opcion2_MOD4 = rndlvlDyMOD4.Next(1, 31);
            opcion3_MOD4 = rndlvlDyMOD4.Next(1, 31);
            opcion4_MOD4 = rndlvlDyMOD4.Next(1, 31);
            opcion5_MOD4 = rndlvlDyMOD4.Next(1, 31);
            opcion6_MOD4 = rndlvlDyMOD4.Next(1, 31);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y de esa forma respondr a la pregunta cual es menor */
            while (opcion1_MOD4 % opcion2_MOD4 <= resultado_MOD4)
            {
                opcion1_MOD4 = rndlvlDyMOD4.Next(1, 31);
                opcion2_MOD4 = rndlvlDyMOD4.Next(1, 31);
            }
            while ((opcion3_MOD4 % opcion4_MOD4 <= resultado_MOD4) || (opcion3_MOD4 % opcion4_MOD4 == opcion1_MOD4 % opcion2_MOD4))
            {
                opcion3_MOD4 = rndlvlDyMOD4.Next(1, 31);
                opcion4_MOD4 = rndlvlDyMOD4.Next(1, 31);
            }
            while ((opcion5_MOD4 % opcion6_MOD4 <= resultado_MOD4) || (opcion5_MOD4 % opcion6_MOD4 == opcion3_MOD4 % opcion4_MOD4) || (opcion5_MOD4 % opcion6_MOD4 == opcion1_MOD4 % opcion2_MOD4))
            {
                opcion5_MOD4 = rndlvlDyMOD4.Next(1, 31);
                opcion6_MOD4 = rndlvlDyMOD4.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlDIVyMOD4.Add(opcion1_MOD4 + " MOD " + opcion2_MOD4);
            opcioneslvlDIVyMOD4.Add(opcion3_MOD4 + " MOD " + opcion4_MOD4);
            opcioneslvlDIVyMOD4.Add(opcion5_MOD4 + " MOD " + opcion6_MOD4);
            opcioneslvlDIVyMOD4.Add(Convert.ToString(aMOD4) + " MOD " + Convert.ToString(bMOD4)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlDIVyMOD4listenteros.Add(opcion1_MOD4 % opcion2_MOD4);
            opcioneslvlDIVyMOD4listenteros.Add(opcion3_MOD4 % opcion4_MOD4);
            opcioneslvlDIVyMOD4listenteros.Add(opcion5_MOD4 % opcion6_MOD4);
            opcioneslvlDIVyMOD4listenteros.Add(aMOD4 % bMOD4);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlDIVyMOD4listenteros[0] = 0;
            opcioneslvlDIVyMOD4listenteros[1] = 0;
            opcioneslvlDIVyMOD4listenteros[2] = 0;
            opcioneslvlDIVyMOD4listenteros[3] = 0;

        }
        public void Respuesta_LvlDIVyMOD4()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorMOD4 = rndlvlDyMOD4.Next(4);
            opcioneslvlDIVyMOD4listenteros[contadorMOD4] = opcion1_MOD4 % opcion2_MOD4;
            opcioneslvlDIVyMOD4[contadorMOD4] = opcion1_MOD4 + " MOD " + opcion2_MOD4;

            // opción 2 

            contadorMOD4 = rndlvlDyMOD4.Next(4);
            while (opcioneslvlDIVyMOD4listenteros[contadorMOD4] != 0)
            {
                contadorMOD4 = rndlvlDyMOD4.Next(4);
            }
            opcioneslvlDIVyMOD4listenteros[contadorMOD4] = opcion3_MOD4 % opcion4_MOD4; // le agregue un valor diferente a 0, 
            opcioneslvlDIVyMOD4[contadorMOD4] = opcion3_MOD4 + " MOD " + opcion4_MOD4;

            // opcion 3

            contadorMOD4 = rndlvlDyMOD4.Next(4);
            while (opcioneslvlDIVyMOD4listenteros[contadorMOD4] != 0)
            {
                contadorMOD4 = rndlvlDyMOD4.Next(4);
            }
            opcioneslvlDIVyMOD4listenteros[contadorMOD4] = (opcion5_MOD4 % opcion6_MOD4);// le agregue un valor diferente a 0, 
            opcioneslvlDIVyMOD4[contadorMOD4] = opcion5_MOD4 + " MOD " + opcion6_MOD4;

            // resultado 

            contadorMOD4 = rndlvlDyMOD4.Next(4);
            while (opcioneslvlDIVyMOD4listenteros[contadorMOD4] != 0)
            {
                contadorMOD4 = rndlvlDyMOD4.Next(4);
            }
            opcioneslvlDIVyMOD4listenteros[contadorMOD4] = resultado_MOD4; // le agregue un valor diferente a 0
            opcioneslvlDIVyMOD4[contadorMOD4] = (aMOD4 + " MOD " + bMOD4); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NDIVyMOD4()
        {
            return aMOD4;
        }
        public int retonar_numero2NDIVyMO4()
        {
            return bMOD4;
        }
        public int retonar_resultadoNDIVyMO4()
        {
            return resultado_MOD4;
        }
        public List<string> retornar_listaNDIVyMO4()
        {
            return opcioneslvlDIVyMOD4;
        }
        public List<int> retornarlistaenterosDIVyMO4()
        {
            return opcioneslvlDIVyMOD4listenteros;
        }
        public string quitapunteos_segundosNDIVyMO4()
        {
            punteomaxMOD4 = punteomaxMOD4 - 2167;
            return Convert.ToString(punteomaxMOD4);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosNDIVyMOD4()
        {
            punteomaxMOD4 = punteomaxMOD4 - 20000;
            return Convert.ToString(punteomaxMOD4); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        //FIN NIVEL 4___________________________________________________________________________________________-

        //INICIO NVIEL 5 

        Random rndlvlDIVyMOD5 = new Random();

        private int aDIVyMOD5, bDIVyMOD5, opcion1_DIVyMOD5, opcion2_DIVyMOD5, opcion3_DIVyMOD5, resultado_DIVyMOD5, opcion4_DIVyMOD5, opcion5_DIVyMOD5, opcion6_DIvyMOD5,
                    punteomaxDIVyMOD5 = 140000, contadorDIVYMOD5; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores en forma de enteros */
        List<string> opcioneslvlDIVyMOD5 = new List<string>();
        List<int> opcioneslvlDIvyMOD5listenteros = new List<int>();

        public void generarlvlDIVyMOD5()
        {
            aDIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            bDIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            resultado_DIVyMOD5 = aDIVyMOD5 + bDIVyMOD5;

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            opcion2_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            opcion3_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            opcion4_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            opcion5_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            opcion6_DIvyMOD5 = rndlvlDIVyMOD5.Next(1, 16);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y que sea solo esa opción la suma mayor necesaria para responder la pregunta*/
            while (opcion1_DIVyMOD5 / opcion2_DIVyMOD5 >= resultado_DIVyMOD5) 
            {
                opcion1_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16); // se busca otro número al azar 
                opcion2_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            }
            while ((opcion3_DIVyMOD5 / opcion4_DIVyMOD5 >= resultado_DIVyMOD5) || (opcion3_DIVyMOD5 + opcion4_DIVyMOD5 == opcion1_DIVyMOD5 + opcion2_DIVyMOD5))
            {
                opcion3_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16); // se busca otro número al azar 
                opcion4_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            }
            while ((opcion5_DIVyMOD5 / opcion6_DIvyMOD5 >= resultado_DIVyMOD5) || (opcion5_DIVyMOD5 + opcion6_DIvyMOD5 == opcion3_DIVyMOD5 + opcion4_DIVyMOD5) || (opcion5_DIVyMOD5 + opcion6_DIvyMOD5 == opcion1_DIVyMOD5 + opcion2_DIVyMOD5))
            {
                opcion5_DIVyMOD5 = rndlvlDIVyMOD5.Next(1, 16); // se busca otro número al azar 
                opcion6_DIvyMOD5 = rndlvlDIVyMOD5.Next(1, 16);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlDIVyMOD5.Add(opcion1_DIVyMOD5 + " MOD " + opcion2_DIVyMOD5);
            opcioneslvlDIVyMOD5.Add(opcion3_DIVyMOD5 + " MOD " + opcion4_DIVyMOD5);
            opcioneslvlDIVyMOD5.Add(opcion5_DIVyMOD5 + " MOD " + opcion6_DIvyMOD5);
            opcioneslvlDIVyMOD5.Add(Convert.ToString(aDIVyMOD5) + " MOD " + Convert.ToString(bDIVyMOD5)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            // almaceno los datos en en forma de enteros 
            opcioneslvlDIvyMOD5listenteros.Add(opcion1_DIVyMOD5 % opcion2_DIVyMOD5);
            opcioneslvlDIvyMOD5listenteros.Add(opcion3_DIVyMOD5 % opcion4_DIVyMOD5); 
            opcioneslvlDIvyMOD5listenteros.Add(opcion5_DIVyMOD5 % opcion6_DIvyMOD5);
            opcioneslvlDIvyMOD5listenteros.Add(aDIVyMOD5 % bDIVyMOD5);

            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlDIvyMOD5listenteros[0] = 0;
            opcioneslvlDIvyMOD5listenteros[1] = 0;
            opcioneslvlDIvyMOD5listenteros[2] = 0;
            opcioneslvlDIvyMOD5listenteros[3] = 0;

        }
        public void Respuesta_LvlDIVyMOD5()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4);
            opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] = opcion1_DIVyMOD5 % opcion2_DIVyMOD5;
            opcioneslvlDIVyMOD5[contadorDIVYMOD5] = opcion1_DIVyMOD5 + " MOD " + opcion2_DIVyMOD5;

            // opción 2 
            contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4); // random al contador 
            while (opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] != 0)
            {
                contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4);
            }
            opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] = opcion3_DIVyMOD5 % opcion4_DIVyMOD5; // le agregue un valor diferente a 0, 
            opcioneslvlDIVyMOD5[contadorDIVYMOD5] = opcion3_DIVyMOD5 + " MOD " + opcion4_DIVyMOD5;

            // opcion 3

            contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4);
            while (opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] != 0)
            {
                contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4);
            }
            opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] = (opcion5_DIVyMOD5 % opcion6_DIvyMOD5);// le agregue un valor diferente a 0, 
            opcioneslvlDIVyMOD5[contadorDIVYMOD5] = opcion5_DIVyMOD5 + " MOD " + opcion6_DIvyMOD5;

            // resultado 

            contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4);
            while (opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] != 0)
            {
                contadorDIVYMOD5 = rndlvlDIVyMOD5.Next(4);
            }
            opcioneslvlDIvyMOD5listenteros[contadorDIVYMOD5] = resultado_DIVyMOD5; // le agregue un valor diferente a 0
            opcioneslvlDIVyMOD5[contadorDIVYMOD5] = (aDIVyMOD5 + " MOD " + bDIVyMOD5); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NDIVyMOD5()
        {
            return aDIVyMOD5;
        }
        public int retonar_numero2NDIVyMOD5()
        {
            return bDIVyMOD5;
        }
        public int retonar_resultadoNDIVyMOD5()
        {
            return resultado_DIVyMOD5;
        }
        public List<string> retornar_listaNDIVyMOD5()
        {
            return opcioneslvlDIVyMOD5;
        }
        public List<int> retornarlistaenterosDIVyMOD5()
        {
            return opcioneslvlDIvyMOD5listenteros;
        }
        public string quitapunteos_segundosNDIVyMOD5()
        {
            punteomaxDIVyMOD5 = punteomaxDIVyMOD5 - 2333;
            return Convert.ToString(punteomaxDIVyMOD5);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosNDIVyMOD5()
        {
            punteomaxDIVyMOD5 = punteomaxDIVyMOD5 - 20000;
            return Convert.ToString(punteomaxDIVyMOD5); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }
        // FIN NIVEL 5............
    }
}
