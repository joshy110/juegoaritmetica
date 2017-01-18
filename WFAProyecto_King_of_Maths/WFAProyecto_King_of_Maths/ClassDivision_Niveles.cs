using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class ClassDivision_Niveles
    {
        /*se crean más variables de las que en los primeros niveles se acostumbra a realizar */
        Random rndlvl1D = new Random();
        private int a1D1, b1D1, a2D1, b2D1, opcion1D1, opcion2D1, opcion3D1, opcion4D1, opcion5D1, opcion6D1,
                    resultadoD1 = 0, punteomaxD1 = 100000, contadorD1;

        /*se agrega otra lista solo que está contiene cadena de caracteres */

        List<int> opcionesD1 = new List<int>();
        List<string> opcionesD1_cadena = new List<string>();

        public void generarlvlD1()
        {
            // se agrega un random de 1 a 6 para los valores de este nivel 
            a1D1 = rndlvl1D.Next(1, 6);
            b1D1 = rndlvl1D.Next(1, 6);
            a2D1 = rndlvl1D.Next(1, 6);
            b2D1 = rndlvl1D.Next(1, 6);

            resultadoD1 = ((a1D1 * b2D1) / (b1D1 * a2D1)); /* expresión a realizar */

            //Las opciones tendran un valor mayor entre los intervalos 
            opcion1D1 = rndlvl1D.Next(1, 16);
            opcion2D1 = rndlvl1D.Next(1, 16);
            opcion3D1 = rndlvl1D.Next(1, 16);
            opcion4D1 = rndlvl1D.Next(1, 16);
            opcion5D1 = rndlvl1D.Next(1, 16);
            opcion6D1 = rndlvl1D.Next(1, 16);

            // condiciono las opciones para que no salgan valores repetidos y de ser asi que el random se aploque solo al denominador 
            if (((opcion1D1 / opcion2D1) == resultadoD1) || ((opcion1D1 / opcion2D1) == (opcion3D1 / opcion4D1)) || ((opcion1D1 / opcion2D1) == (opcion5D1 / opcion6D1)))
            {
                opcion2D1 = rndlvl1D.Next(1, 16);
            }
            if (((opcion3D1 / opcion4D1) == resultadoD1) || ((opcion3D1 / opcion4D1) == (opcion1D1 / opcion2D1)) || ((opcion3D1 / opcion4D1) == (opcion5D1 / opcion6D1)))
            {
                opcion4D1 = rndlvl1D.Next(1, 16);
            }
            if (((opcion5D1 / opcion6D1) == resultadoD1) || ((opcion5D1 / opcion6D1) == (opcion1D1 / opcion2D1)) || ((opcion5D1 / opcion6D1) == (opcion3D1 / opcion4D1)))
            {
                opcion6D1 = rndlvl1D.Next(1, 16);
            }

            /*datos lista cadena */

            opcionesD1_cadena.Add(opcion1D1 + " / " + opcion2D1);
            opcionesD1_cadena.Add(opcion3D1 + " / " + opcion4D1);
            opcionesD1_cadena.Add(opcion5D1 + " / " + opcion6D1);
            opcionesD1_cadena.Add(Convert.ToString((a1D1 * b2D1) + " / " + Convert.ToString(b1D1 * a2D1)));

            /*datos lista enteros */
            opcionesD1.Add(opcion1D1 / opcion2D1);
            opcionesD1.Add(opcion3D1 / opcion4D1);
            opcionesD1.Add(opcion5D1 / opcion6D1);
            opcionesD1.Add(resultadoD1);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcionesD1[0] = 0;
            opcionesD1[1] = 0;
            opcionesD1[2] = 0;
            opcionesD1[3] = 0;

        }
        public void Respuesta_Lv1D1()
        {
            /* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */

            //Opcion 1 que me devuleve un valor 
            contadorD1 = rndlvl1D.Next(4);
            opcionesD1[contadorD1] = opcion1D1 / opcion2D1;
            opcionesD1_cadena[contadorD1] = opcion1D1 + " / " + opcion2D1;

            // opción 2 
            while (opcionesD1[contadorD1] != 0)
            {
                contadorD1 = rndlvl1D.Next(4);
            }
            opcionesD1[contadorD1] = (opcion3D1 / opcion4D1); // le agregue un valor diferente a 0, 
            opcionesD1_cadena[contadorD1] = (opcion3D1 + " / " + opcion4D1);

            // opcion 3
            while (opcionesD1[contadorD1] != 0)
            {
                contadorD1 = rndlvl1D.Next(4);
            }
            opcionesD1[contadorD1] = (opcion5D1 / opcion6D1);// le agregue un valor diferente a 0, 
            opcionesD1_cadena[contadorD1] = (opcion5D1 + " / " + opcion6D1);

            // resultado 
            while (opcionesD1[contadorD1] != 0)
            {
                contadorD1 = rndlvl1D.Next(4);
            }
            opcionesD1[contadorD1] = resultadoD1; // le agregue un valor diferente a 0
            opcionesD1_cadena[contadorD1] = (a1D1 * b2D1) + " / " + (b1D1 * a2D1);
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N1D()
        {
            return a1D1;
        }
        public int retonrar_a2numero1N1D1()
        {
            return a2D1;
        }
        public int retonar_numero2N1D()
        {
            return b1D1;
        }
        public int retonar_b2numero2N1D()
        {
            return b2D1;
        }

        public int retonar_resultadoN1D()
        {
            return resultadoD1;
        }
        public List<string> retornar_Lista_cade_D1()
        {
            return opcionesD1_cadena;
        }
        public List<int> retornar_listaN1D()
        {
            return opcionesD1;
        }
        public string quitapunteos_SeguN1D()
        {
            punteomaxD1 = punteomaxD1 - 1667;
            return Convert.ToString(punteomaxD1);
        }
        public string quitarpuntosN1D()
        {
            punteomaxD1 = punteomaxD1 - 20000;
            return Convert.ToString(punteomaxD1);
        }
        /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */

        // FIN NIVEL 1 

        /*INICIO NIVEL 2 */ 
        // declaro un random global y las variables tambien seran globales
        Random rndlvl2Divi = new Random();
        private int a1Divi2, b2Divi2, c1Divi2, resultadoDivi2, opcion1Divi2, opcion2Divi2, opcion3Divi2, punteomaxDivi2 = 110000,
                    contadorDivi2;

        /*se agrega otra lista solo que está contiene cadena de caracteres */

        List<int> opcionesDivi2 = new List<int>();

        public void generarlvlDivi2()
        {
            // utilizo las variables 
            a1Divi2 = rndlvl1D.Next(1, 16);
            b2Divi2 = rndlvl1D.Next(1, 16);
            resultadoDivi2 = rndlvl2Divi.Next(1, 16);
            resultadoDivi2 = (a1Divi2 / b2Divi2) + (c1Divi2 / b2Divi2); // miro la expreion resultado y de ella despejo C

           while ((a1Divi2 <=0) || (resultadoDivi2 <=0) || (resultadoDivi2 >= 31) || (a1Divi2 > resultadoDivi2)) 
            {
                a1Divi2 = rndlvl1D.Next(1, 16);
                resultadoDivi2 = rndlvl2Divi.Next(1, 16);
            }
            c1Divi2 = (resultadoDivi2 * b2Divi2) - a1Divi2; // con esto vamos a encontrar el valor que hay en C
                
            // agrego randoms a mis posibles respuestas. 
            opcion1Divi2 = rndlvl1D.Next(1, 16);
            opcion2Divi2 = rndlvl1D.Next(1, 16);
            opcion3Divi2 = rndlvl1D.Next(1, 16);

            // condiciono las opciones 
            if ((opcion1Divi2 == c1Divi2) || (opcion1Divi2 == opcion2Divi2) || (opcion1Divi2 ==opcion3Divi2 ))
            {
                opcion1Divi2 = rndlvl1D.Next(1, 16);
            }
            if ((opcion2Divi2 == c1Divi2) || (opcion2Divi2 == opcion1Divi2) || (opcion2Divi2 == opcion3Divi2))
            {
                opcion2Divi2 = rndlvl1D.Next(1, 16);
            }
            if ((opcion3Divi2 == c1Divi2) || (opcion3Divi2 == opcion1Divi2) || (opcion3Divi2 == opcion2Divi2))
            {
                opcion3Divi2 = rndlvl1D.Next(1, 16);
            }

            /*datos lista enteros */
            opcionesDivi2.Add(opcion1Divi2);
            opcionesDivi2.Add(opcion2Divi2);
            opcionesDivi2.Add(opcion3Divi2);
            opcionesDivi2.Add(resultadoDivi2);
            opcionesDivi2.Add(c1Divi2);

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una matriz  
            opcionesDivi2[0] = 0;
            opcionesDivi2[1] = 0;
            opcionesDivi2[2] = 0;
            opcionesDivi2[3] = 0;

        }
        public void Respuesta_Lv1Divi2()
        {
            /* llamar al contador global que llame al random para luego agrergarle los valoes a las opciones */
            //Opcion 1 que me devuleve un valor 

            contadorDivi2 = rndlvl1D.Next(4);
            opcionesDivi2[contadorDivi2] = opcion1Divi2;


            // opción 2 
            while (opcionesDivi2[contadorDivi2] != 0)
            {
                contadorDivi2 = rndlvl1D.Next(4);
            }
            opcionesDivi2[contadorDivi2] = opcion2Divi2; // le agregue un valor diferente a 0, 


            // opcion 3
            while (opcionesDivi2[contadorDivi2] != 0)
            {
                contadorDivi2 = rndlvl1D.Next(4);
            }
            opcionesDivi2[contadorDivi2] = opcion3Divi2; // le agregue un valor diferente a 0, 


            // resultado 
            while (opcionesDivi2[contadorDivi2] != 0)
            {
                contadorDivi2 = rndlvl1D.Next(4);
            }
            opcionesDivi2[contadorDivi2] = c1Divi2; // le agregue un valor diferente a 0

        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N2Divi()
        {
            return a1Divi2;
        }
        public int retonar_numero2N2Divi()
        {
            return b2Divi2;
        }
        public int retornarC2Divi()
        {
            return c1Divi2; 
        }
        public int retonar_resultadp2N2Divi()
        {
            return resultadoDivi2; 
        }
        public List<int> retornar_listaN2Divi()
        {
            return opcionesDivi2;
        }
        public string quitapunteos_SeguN2Divi()
        {
            punteomaxDivi2 = punteomaxDivi2 - 1833;
            return Convert.ToString(punteomaxDivi2);
        }
        public string quitarpuntosN2Divi()
        {
            punteomaxDivi2 = punteomaxDivi2 - 20000;
            return Convert.ToString(punteomaxDivi2);
        }
        /*lo que hize en los metodos punteo y quita puntos fue que en la forma agrege los puntos y por cada mala le quite 3 segundos */

        //FIN NIVEL 2 

        /*INICIO NIVEL 3*/
        Random rndlvlDivi3 = new Random();

        private int a1Divi3, b1Divi3, c1Divi3, resultado_Divi3, opcion1_Divi3, opcion2_Divi3, opcion3_Divi3, opcion4_Divi3, opcion5_Divi3, opcion6_Divi3, opcion7_Divi3, 
            punteomaxDivi3 = 120000, contadorDivi3; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlDivi3_Cadena = new List<string>();
        List<int> opcioneslvlDivi3_enteros = new List<int>();

        public void generarlvlDivi3()
        {
            // agrego random a los valores y pongo el resultado 
            a1Divi3 = rndlvlDivi3.Next(1, 16);
            b1Divi3 = rndlvlDivi3.Next(1, 16);
            c1Divi3 = rndlvlDivi3.Next(1, 16); 
            resultado_Divi3 = (a1Divi3 / b1Divi3) + (c1Divi3 / b1Divi3);

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_Divi3 = rndlvlDivi3.Next(1, 31);
            opcion2_Divi3 = rndlvlDivi3.Next(1, 31);
            opcion3_Divi3 = rndlvlDivi3.Next(1, 31);
            opcion4_Divi3 = rndlvlDivi3.Next(1, 31);
            opcion5_Divi3 = rndlvlDivi3.Next(1, 31);
            opcion6_Divi3 = rndlvlDivi3.Next(1, 31);
            opcion7_Divi3 = rndlvlDivi3.Next(1, 31);

            // se utilizara un while para este caso pues como es un ciclo repetivo no seria comvenite un if 
            while ((b1Divi3 == 1) || (opcion7_Divi3 ==1))
            {
                b1Divi3 = rndlvlDivi3.Next(1, 16);
                opcion7_Divi3 = rndlvlDivi3.Next(1, 31);
            }

           while (((opcion1_Divi3 / opcion7_Divi3) + (opcion2_Divi3 / opcion7_Divi3) == resultado_Divi3) || ((opcion1_Divi3 / opcion7_Divi3) + (opcion2_Divi3 / opcion7_Divi3) == 0))
            {
                opcion1_Divi3 = rndlvlDivi3.Next(1, 31);
                opcion2_Divi3 = rndlvlDivi3.Next(1, 31);
                opcion7_Divi3 = rndlvlDivi3.Next(1, 31);
            }
            while (((opcion3_Divi3 / opcion7_Divi3) + (opcion4_Divi3/opcion7_Divi3) == resultado_Divi3) || ((opcion3_Divi3 / opcion7_Divi3) + (opcion4_Divi3/opcion7_Divi3) == 0))
            {
                opcion3_Divi3 = rndlvlDivi3.Next(1, 31);
                opcion4_Divi3 = rndlvlDivi3.Next(1, 31);
                opcion7_Divi3 = rndlvlDivi3.Next(1, 31);
            }
            while (((opcion5_Divi3 / opcion7_Divi3) + (opcion6_Divi3 / opcion7_Divi3) == resultado_Divi3) || ((opcion5_Divi3 / opcion7_Divi3) + (opcion6_Divi3 / opcion7_Divi3) == 0))
            {
                opcion5_Divi3 = rndlvlDivi3.Next(1, 31);
                opcion6_Divi3 = rndlvlDivi3.Next(1, 31);
                opcion7_Divi3 = rndlvlDivi3.Next(1, 31);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlDivi3_Cadena.Add((opcion1_Divi3 + " / " + opcion7_Divi3) + "  + " + (opcion2_Divi3 + " / " + opcion7_Divi3));
            opcioneslvlDivi3_Cadena.Add((opcion3_Divi3 + " / " + opcion7_Divi3) + "  +  " + (opcion4_Divi3 + " / " + opcion7_Divi3));
            opcioneslvlDivi3_Cadena.Add((opcion5_Divi3 + " / " + opcion7_Divi3)+ "  +  " + (opcion6_Divi3 + " /" + opcion7_Divi3));
            opcioneslvlDivi3_Cadena.Add(Convert.ToString(a1Divi3/b1Divi3) + " + " + Convert.ToString(c1Divi3/b1Divi3)); /*es la operación  vuelta cadena caracteres*/

            // hago lo mismo y las agrego a la lista solo que de enteros
            opcioneslvlDivi3_enteros.Add((opcion1_Divi3 / opcion7_Divi3) + (opcion2_Divi3 / opcion7_Divi3));
            opcioneslvlDivi3_enteros.Add((opcion3_Divi3 / opcion7_Divi3) + (opcion4_Divi3/opcion7_Divi3));
            opcioneslvlDivi3_enteros.Add((opcion5_Divi3 / opcion7_Divi3) + (opcion6_Divi3 /opcion7_Divi3));
            opcioneslvlDivi3_enteros.Add(resultado_Divi3); 

          
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlDivi3_enteros[0] = 0;
            opcioneslvlDivi3_enteros[1] = 0;
            opcioneslvlDivi3_enteros[2] = 0;
            opcioneslvlDivi3_enteros[3] = 0;

        }
        public void Respuesta_LvlDivi3()
        {
            //opcion 1 
            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */
            contadorDivi3 = rndlvlDivi3.Next(4);
            opcioneslvlDivi3_enteros[contadorDivi3] = (opcion1_Divi3 / opcion7_Divi3) + (opcion2_Divi3 / opcion7_Divi3);
            opcioneslvlDivi3_Cadena[contadorDivi3] = (opcion1_Divi3 + " / " + opcion7_Divi3) + "  + " + (opcion2_Divi3 + " / " + opcion7_Divi3);

            // opción 2 
            contadorDivi3 = rndlvlDivi3.Next(4);
            while (opcioneslvlDivi3_enteros[contadorDivi3] != 0)
            {
                contadorDivi3 = rndlvlDivi3.Next(4);
            }
            opcioneslvlDivi3_enteros[contadorDivi3] = (opcion3_Divi3 / opcion7_Divi3) + (opcion4_Divi3 / opcion7_Divi3); // le agregue un valor diferente a 0, 
            opcioneslvlDivi3_Cadena[contadorDivi3] = (opcion3_Divi3 + " / " + opcion7_Divi3) + "  +  " + (opcion4_Divi3 + " / " + opcion7_Divi3);

            // opcion 3
            contadorDivi3 = rndlvlDivi3.Next(4);
            while (opcioneslvlDivi3_enteros[contadorDivi3] != 0)
            {
                contadorDivi3 = rndlvlDivi3.Next(4);
            }
            opcioneslvlDivi3_enteros[contadorDivi3] = (opcion5_Divi3 / opcion7_Divi3) + (opcion6_Divi3 / opcion7_Divi3);// le agregue un valor diferente a 0, 
            opcioneslvlDivi3_Cadena[contadorDivi3] = (opcion5_Divi3 + " / " + opcion7_Divi3) + "  +  " + (opcion6_Divi3 + " /" + opcion7_Divi3);

            // resultado 
            contadorDivi3 = rndlvlDivi3.Next(4);
            while (opcioneslvlDivi3_enteros[contadorDivi3] != 0)
            {
                contadorDivi3 = rndlvlDivi3.Next(4);
            }
            opcioneslvlDivi3_enteros[contadorDivi3] = resultado_Divi3; // le agregue un valor diferente a 0
            opcioneslvlDivi3_Cadena[contadorDivi3] = ((a1Divi3 / b1Divi3) + " + " + (c1Divi3 / b1Divi3)); ; /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1N3Divi3()
        {
            return a1Divi3;
        }
        public int retonar_numero2N3Divi3()
        {
            return b1Divi3;
        }
        public int retonar_resultadoN3Divi3()
        {
            return resultado_Divi3;
        }
        public List<string> retornar_lista_CadenaN3ivi3()
        {
            return opcioneslvlDivi3_Cadena;
        }
        public List<int> retornarlistaenterosDivi3()
        {
            return opcioneslvlDivi3_enteros;
        }
        public string quitapunteos_segundosN3Divi3()
        {
            punteomaxDivi3 = punteomaxDivi3 - 2000;
            return Convert.ToString(punteomaxDivi3);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosN3Divi3()
        {
            punteomaxDivi3 = punteomaxDivi3 - 20000;
            return Convert.ToString(punteomaxDivi3); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        // Fin Nivel 3_______________________________________________________________________________________}

        // INICIO NIVEL 4 
        Random rndlvlDivi4 = new Random();

        private int aDivi4, bDivi4, opcion1_Divi4, c1Divi4, opcion2_Divi4, opcion3_Divi4, resultado_Divi4, opcion4_Divi4, opcion5_Divi4, opcion6_Divi4, opcion7_Divi4, 
                    punteomaxDivi4 = 130000, contadorDivi4; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores*/
        List<string> opcioneslvlDiviD4_Cadena = new List<string>();
        List<int> opcioneslvlDivi4listenteros = new List<int>();

        public void generarlvlDivi4()
        {
            aDivi4 = rndlvlDivi4.Next(1, 16);
            bDivi4 = rndlvlDivi4.Next(1, 16);
            c1Divi4 = rndlvlDivi4.Next(1, 16);
            resultado_Divi4 = (aDivi4 / bDivi4) + (c1Divi4 / bDivi4);

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_Divi4 = rndlvlDivi4.Next(1, 31);
            opcion2_Divi4 = rndlvlDivi4.Next(1, 31);
            opcion3_Divi4 = rndlvlDivi4.Next(1, 31);
            opcion4_Divi4 = rndlvlDivi4.Next(1, 31);
            opcion5_Divi4 = rndlvlDivi4.Next(1, 31);
            opcion6_Divi4 = rndlvlDivi4.Next(1, 31);
            opcion7_Divi4 = rndlvlDivi4.Next(1, 31);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y de esa forma respondr a la pregunta cual es menor */
            while (((opcion1_Divi4 / opcion7_Divi4) + (opcion2_Divi4 / opcion7_Divi4) <= resultado_Divi4) || ((opcion1_Divi4 / opcion7_Divi4) + (opcion2_Divi4 / opcion7_Divi4) == 0))
            {
                opcion1_Divi4 = rndlvlDivi4.Next(1, 31);
                opcion2_Divi4 = rndlvlDivi4.Next(1, 31);
                opcion7_Divi4 = rndlvlDivi4.Next(1, 31);
            }
            while (((opcion3_Divi4 / opcion7_Divi4) + (opcion4_Divi4 / opcion7_Divi4) <= resultado_Divi4) || ((opcion3_Divi4 / opcion7_Divi4) + (opcion4_Divi4 / opcion7_Divi4) == 0))
            {
                opcion3_Divi4 = rndlvlDivi4.Next(1, 31);
                opcion4_Divi4 = rndlvlDivi4.Next(1, 31);
                opcion7_Divi4 = rndlvlDivi4.Next(1, 31);
            }
            while (((opcion5_Divi4 / opcion7_Divi4) + (opcion6_Divi4 / opcion7_Divi4) <= resultado_Divi4) || ((opcion5_Divi4 / opcion7_Divi4) + (opcion6_Divi4 / opcion7_Divi4) == 0))
            {
                opcion5_Divi4 = rndlvlDivi4.Next(1, 31);
                opcion6_Divi4 = rndlvlDivi4.Next(1, 31);
                opcion7_Divi4 = rndlvlDivi4.Next(1, 31);

            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlDiviD4_Cadena.Add((opcion1_Divi4 + " / " + opcion7_Divi4) + "  + " + (opcion2_Divi4 + " / " + opcion7_Divi4));
            opcioneslvlDiviD4_Cadena.Add((opcion3_Divi4 + " / " + opcion7_Divi4) + "  + " + (opcion4_Divi4 + " / " + opcion7_Divi4));
            opcioneslvlDiviD4_Cadena.Add((opcion5_Divi4 + " / " + opcion7_Divi4) + "  + " + (opcion6_Divi4 + " / " + opcion7_Divi4));
            opcioneslvlDiviD4_Cadena.Add(Convert.ToString(aDivi4 / bDivi4) + " + " + Convert.ToString(c1Divi4 / bDivi4)); /*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            opcioneslvlDivi4listenteros.Add((opcion1_Divi4 / opcion7_Divi4) + (opcion2_Divi4 / opcion7_Divi4));
            opcioneslvlDivi4listenteros.Add((opcion3_Divi4 / opcion7_Divi4) + (opcion4_Divi4 / opcion7_Divi4));
            opcioneslvlDivi4listenteros.Add((opcion5_Divi4 / opcion7_Divi4) + (opcion6_Divi4 / opcion7_Divi4));
            opcioneslvlDivi4listenteros.Add(resultado_Divi4); 

            // centinela 
            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlDivi4listenteros[0] = 0;
            opcioneslvlDivi4listenteros[1] = 0;
            opcioneslvlDivi4listenteros[2] = 0;
            opcioneslvlDivi4listenteros[3] = 0;

        }
        public void Respuesta_LvlDivi4()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorDivi4 = rndlvlDivi4.Next(4);
            opcioneslvlDivi4listenteros[contadorDivi4] = (opcion1_Divi4 / opcion7_Divi4) + (opcion2_Divi4 / opcion7_Divi4);
            opcioneslvlDiviD4_Cadena[contadorDivi4] = ((opcion1_Divi4 + " / " + opcion7_Divi4) + "  + " + (opcion2_Divi4 + " / " + opcion7_Divi4));

            // opción 2 

            contadorDivi4 = rndlvlDivi4.Next(4);
            while (opcioneslvlDivi4listenteros[contadorDivi4] != 0)
            {
                contadorDivi4 = rndlvlDivi4.Next(4);
            }
            opcioneslvlDivi4listenteros[contadorDivi4] = (opcion3_Divi4 / opcion7_Divi4) + (opcion4_Divi4 / opcion7_Divi4); // le agregue un valor diferente a 0, 
            opcioneslvlDiviD4_Cadena[contadorDivi4] = ((opcion3_Divi4 + " / " + opcion7_Divi3) + "  + " + (opcion4_Divi4 + " / " + opcion7_Divi4));

            // opcion 3

            contadorDivi4 = rndlvlDivi4.Next(4);
            while (opcioneslvlDivi4listenteros[contadorDivi4] != 0)
            {
                contadorDivi4 = rndlvlDivi4.Next(4);
            }
            opcioneslvlDivi4listenteros[contadorDivi4] = (opcion5_Divi4 / opcion7_Divi4) + (opcion6_Divi4 / opcion7_Divi4);// le agregue un valor diferente a 0, 
            opcioneslvlDiviD4_Cadena[contadorDivi4] = (opcion5_Divi4 + " / " + opcion7_Divi4) + "  + " + (opcion6_Divi4 + " / " + opcion7_Divi4);

            // resultado 

            contadorDivi4 = rndlvlDivi4.Next(4);
            while (opcioneslvlDivi4listenteros[contadorDivi4] != 0)
            {
                contadorDivi4 = rndlvlDivi4.Next(4);
            }
            opcioneslvlDivi4listenteros[contadorDivi4] = resultado_Divi4; // le agregue un valor diferente a 0
            opcioneslvlDiviD4_Cadena[contadorDivi4] = (Convert.ToString(aDivi4 / bDivi4) + " + " + Convert.ToString(c1Divi4 / bDivi4)); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NDivi4()
        {
            return aDivi4;
        }
        public int retonar_numero2NDivi4()
        {
            return bDivi4;
        }
        public int retonar_resultadoNDivi4()
        {
            return resultado_Divi4;
        }
        public List<string> retornar_listaNDivi4_Cadena()
        {
            return opcioneslvlDiviD4_Cadena;
        }
        public List<int> retornarlistaenterosDivi4()
        {
            return opcioneslvlDivi4listenteros;
        }
        public string quitapunteos_segundosNDivi4()
        {
            punteomaxDivi4 = punteomaxDivi4 - 2167;
            return Convert.ToString(punteomaxDivi4);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosNDivi4()
        {
            punteomaxDivi4 = punteomaxDivi4 - 20000;
            return Convert.ToString(punteomaxDivi4); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }

        //FIN NIVEL 4___________________________________________________________________________________________-

        // INICIO NIVEL 5
        Random rndlvlDivi5 = new Random();

        private int aDivi5, bDivi5, c1Divi5, opcion1_Divi5, opcion2_Divi5, opcion3_Divi5, resultado_Divi5, opcion4_Divi5, opcion5_Divi5, opcion6_Divi5, opcion7_Divi5, 
                    punteomaxDivi5 = 140000, contadorDivi5; /*algunas variable decidi cambiarlas por letras ya que podría confundirme más adelante*/

        /*crear 2 listas una string y otra entero en donde se iran guardando los valores en forma de enteros */
        List<string> opcioneslvlDivi5_Cadena = new List<string>();
        List<int> opcioneslvlDivi5listenteros = new List<int>();

        public void generarlvlDivi5()
        {
            aDivi5 = rndlvlDivi5.Next(1, 16);
            bDivi5 = rndlvlDivi5.Next(1, 16);
            c1Divi5 = rndlvlDivi5.Next(1, 16);
            resultado_Divi5 = (aDivi5 / bDivi5) + (c1Divi5 / bDivi5);

            /*se agregaron más opciones para poder agrgarlas a otra lista que se creara ya que dividire en 2 estas operaciones*/

            opcion1_Divi5 = rndlvlDivi5.Next(1, 16);
            opcion2_Divi5 = rndlvlDivi5.Next(1, 16);
            opcion3_Divi5 = rndlvlDivi5.Next(1, 16);
            opcion4_Divi5 = rndlvlDivi5.Next(1, 16);
            opcion5_Divi5 = rndlvlDivi5.Next(1, 16);
            opcion6_Divi5 = rndlvlDivi5.Next(1, 16);
            opcion7_Divi5 = rndlvlDivi5.Next(1,16);

            /*Con el siguiente mientras es como valido y condiciono este nivel para que me salga la repsuesta y ademas no se repitan números o sumas
             y que sea solo esa opción la suma mayor necesaria para responder la pregunta*/
            while (opcion1_Divi5 / opcion2_Divi5 >= resultado_Divi5)
            {
                opcion1_Divi5 = rndlvlDivi5.Next(1, 16); // se busca otro número al azar 
                opcion2_Divi5 = rndlvlDivi5.Next(1, 16);
            }
            while ((opcion3_Divi5 / opcion4_Divi5 >= resultado_Divi5) || (opcion3_Divi5 + opcion4_Divi5 == opcion1_Divi5 + opcion2_Divi5))
            {
                opcion3_Divi5 = rndlvlDivi5.Next(1, 16); // se busca otro número al azar 
                opcion4_Divi5 = rndlvlDivi5.Next(1, 16);
            }
            while ((opcion5_Divi5 / opcion6_Divi5 >= resultado_Divi5) || (opcion5_Divi5 + opcion6_Divi5 == opcion3_Divi5 + opcion4_Divi5) || (opcion5_Divi5 + opcion6_Divi5 == opcion1_Divi5 + opcion2_Divi5))
            {
                opcion5_Divi5 = rndlvlDivi5.Next(1, 16); // se busca otro número al azar 
                opcion6_Divi5 = rndlvlDivi5.Next(1, 16);
            }

            /*se agregan las opciones como cadena priemro para que así em guarden las sumas que quiero en el botón 
             * luego en la lista de enteros se agregan los valores que quiero que me salgan */
            opcioneslvlDivi5_Cadena.Add((opcion1_Divi5 + " / " + opcion7_Divi5) + "  + " + (opcion2_Divi5 + " / " + opcion7_Divi5));
            opcioneslvlDivi5_Cadena.Add((opcion3_Divi5 + " / " + opcion7_Divi5) + "  + " + (opcion4_Divi5 + " / " + opcion7_Divi5));
            opcioneslvlDivi5_Cadena.Add((opcion5_Divi5 + " / " + opcion7_Divi5) + "  + " + (opcion6_Divi5 + " / " + opcion7_Divi5));
            opcioneslvlDivi5_Cadena.Add(Convert.ToString(aDivi5 / bDivi5) + " + " + Convert.ToString(c1Divi5 / bDivi5));/*es la operación resultado
                                                                                       * vuelta cadena caracteres*/
            // almaceno los datos en en forma de enteros 
            opcioneslvlDivi5listenteros.Add((opcion1_Divi5 / opcion7_Divi5) + (opcion2_Divi5 / opcion7_Divi5));
            opcioneslvlDivi5listenteros.Add((opcion3_Divi5 / opcion7_Divi5) + (opcion4_Divi5 / opcion7_Divi5));
            opcioneslvlDivi5listenteros.Add((opcion5_Divi5 / opcion7_Divi5) + (opcion6_Divi4 / opcion7_Divi5));
            opcioneslvlDivi5listenteros.Add(resultado_Divi5);

            // todo lo que va entre "[]" son las posiciones que juegan las opciones dentro de la lista es como una pseudomatriz 
            /*la list de enteros es al que va tomar las posiciones ya no lo hara la lista de cadena de caracteres */
            opcioneslvlDivi5listenteros[0] = 0;
            opcioneslvlDivi5listenteros[1] = 0;
            opcioneslvlDivi5listenteros[2] = 0;
            opcioneslvlDivi5listenteros[3] = 0;

        }
        public void Respuesta_LvlDivi5()
        {
            //opcion 1 

            /*primero se realiza el random al contador, despues el contador toma cierta posición, luego en la siguiente lista, 
             la de cadena de caracteres se agrega la manera en que saldran los números en este caso se iran sumando, esto para 
             todo esté método */

            contadorDivi5 = rndlvlDivi5.Next(4);
            opcioneslvlDivi5listenteros[contadorDivi5] = ((opcion1_Divi5 / opcion7_Divi5) + (opcion2_Divi5 / opcion7_Divi5));
            opcioneslvlDivi5_Cadena[contadorDivi5] = ((opcion1_Divi5 + " / " + opcion7_Divi5) + "  + " + (opcion2_Divi5 + " / " + opcion7_Divi5));

            // opción 2 
            contadorDivi5 = rndlvlDivi5.Next(4); // random al contador 
            while (opcioneslvlDivi5listenteros[contadorDivi5] != 0)
            {
                contadorDivi5 = rndlvlDivi5.Next(4);
            }
            opcioneslvlDivi5listenteros[contadorDivi5] = ((opcion3_Divi5 / opcion7_Divi5) + (opcion4_Divi5 / opcion7_Divi5)); // le agregue un valor diferente a 0, 
            opcioneslvlDivi5_Cadena[contadorDivi5] = ((opcion3_Divi5 + " / " + opcion7_Divi5) + "  + " + (opcion4_Divi5 + " / " + opcion7_Divi5));

            // opcion 3

            contadorDivi5 = rndlvlDivi5.Next(4);
            while (opcioneslvlDivi5listenteros[contadorDivi5] != 0)
            {
                contadorDivi5 = rndlvlDivi5.Next(4);
            }
            opcioneslvlDivi5listenteros[contadorDivi5] = ((opcion5_Divi5 / opcion7_Divi5) + (opcion6_Divi4 / opcion7_Divi5));// le agregue un valor diferente a 0, 
            opcioneslvlDivi5_Cadena[contadorDivi5] = ((opcion5_Divi5 + " / " + opcion7_Divi5) + "  + " + (opcion6_Divi5 + " / " + opcion7_Divi5));

            // resultado 

            contadorDivi5 = rndlvlDivi5.Next(4);
            while (opcioneslvlDivi5listenteros[contadorDivi5] != 0)
            {
                contadorDivi5 = rndlvlDivi5.Next(4);
            }
            opcioneslvlDivi5listenteros[contadorDivi5] = (resultado_Divi5); // le agregue un valor diferente a 0
            opcioneslvlDivi5_Cadena[contadorDivi5] = (Convert.ToString(aDivi5 / bDivi5) + " + " + Convert.ToString(c1Divi5 / bDivi5)); /*cadena respuesta a la que se quiere llegar */
        }
        // ahora se retornaran los valores en forma de métodos. 
        public int retonar_numero1NDivi5()
        {
            return aDivi5;
        }
        public int retonar_numero2NDivi5()
        {
            return bDivi5;
        }
        public int retonar_resultadoNDivi5()
        {
            return resultado_Divi5;
        }
        public List<string> retornar_listaNDivi5_Cadena()
        {
            return opcioneslvlDivi5_Cadena;
        }
        public List<int> retornarlistaenterosDivi5()
        {
            return opcioneslvlDivi5listenteros;
        }
        public string quitapunteos_segundosNDivi5()
        {
            punteomaxDivi5 = punteomaxDivi5 - 2333;
            return Convert.ToString(punteomaxDivi5);
            /*se le quitara cierta cantidad por cada segundo que vaya pasanfo para hacer un poco mas dificil el juego y que 
             el usuario tenga que pensar un poco más de lo debido. */
        }
        public string quitarpuntosNDivi5()
        {
            punteomaxDivi5 = punteomaxDivi5 - 20000;
            return Convert.ToString(punteomaxDivi5); /*lo que hize en los metodos punteo y quita puntos fue 
                                                  * que en la forma agrege los puntos y por cada mala le quite 3 segundos */
        }
        // FIN NIVEL 5............

    }
}

