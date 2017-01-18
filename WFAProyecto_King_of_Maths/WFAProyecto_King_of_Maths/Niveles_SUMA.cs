using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProyecto_King_of_Maths
{
    public partial class Niveles_SUMA : Form
    {
        ClassSuma_Niveles claseN1deS = new ClassSuma_Niveles(); /* se declarara la clase global para de ella sustraer lo que necesito en esté nivel1 de la suma */
        int conteo1 = 1, tiempo1 = 60, punteomax1 = 100000; /* declaro las variables globales a utiliziar en esté nivel  */
        public Niveles_SUMA()
        {
            InitializeComponent();
        }

        private void tabNivel1S_Click(object sender, EventArgs e)
        {
            lblconteoON1S.Text = "/10"; //cuando inicie e intente hacer click sobre la tab solo obtendra ese valor 
        }

        public void iniciarlvl1()
        {
            /* LLamó la clase en donde tengo los datos de este nivel */
            claseN1deS.generarlvl1();
            claseN1deS.Respuesta_Lv1();
            List<int> Nivel1_Suma = claseN1deS.retornar_listaN1S(); /* Luego creó una lista en la cual llamo el método de la 
                                                                 lista de la clase*/

            lbloperacionN1S1.Text = Convert.ToString(claseN1deS.retonar_numero1N1S()) + " + "
                + Convert.ToString(claseN1deS.retonar_numero2N1S()) + " = ? "; /* Coloco la operación del nivel 1 en la cual son sumas 
                                                                            donde el usuario hayara la respuesta con los botones*/

            /*Ahora empezamos con todos los botones en el mismo color para que se vea bien, es mas que todo visual*/
            cmdresp1N1S.Text = Nivel1_Suma[0].ToString();
            cmdresp1N1S.BackColor = Color.Transparent;

            cmdres2N1S.Text = Nivel1_Suma[1].ToString();
            cmdres2N1S.BackColor = Color.Transparent;

            cmdresp3N1S.Text = Nivel1_Suma[2].ToString();
            cmdresp3N1S.BackColor = Color.Transparent;

            cmdresp4N1S.Text = Nivel1_Suma[3].ToString();
            cmdresp4N1S.BackColor = Color.Transparent;
        }
        private void cmdinicioN1S_Click(object sender, EventArgs e)
        {
            /*con este botón doy inicio al nivel 1 de este mundo mostrando todos los botones, la lbl puntos con los puntos con 
             los que inicia y además inicia el timer para este nivel y tmabien la lbl conteo */
            iniciarlvl1();

            //habilito los botones de las respuestas 
            cmdresp1N1S.Enabled = true;
            cmdres2N1S.Enabled = true;
            cmdresp3N1S.Enabled = true;
            cmdresp4N1S.Enabled = true;
            cmdinicioN1S.Enabled = false; 

            lblconteoON1S.Text = "1/10"; // empieza con valor 1 pues con ello obtengo la primera operacione. 
            timerN1S.Start();            //incio el tiempo 
            lblpunteoN1S.Text = Convert.ToString(punteomax1); // cargo el puntaje maximo de este nivel 
        }
        private void timerN1S_Tick(object sender, EventArgs e)
        {
            //esto de las estrellas lo debi meter a una clase más no pude lograrlo por ello lo deje a lo patito en la forma 
            int puntemin1 = 50000, limiinfe1 = 0, limeinfe2 = 0, A1 = 0, limiinfe3 = 0, limesupe1 = 0, limesupe2 = 0, limisupe3 = 0;
      
            A1 = (punteomax1 - puntemin1) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfe1 = puntemin1; 
            limeinfe2 = puntemin1 + A1; 
            limiinfe3 = puntemin1 + (2 * A1); 
            //obtengo los limites superiores 
            limesupe1 = (puntemin1 + A1) - 1;
            limesupe2 = ((puntemin1 + (2 * A1)) - 1); 
            limisupe3 = punteomax1; 

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN1S.Text) >= limiinfe1) && (Convert.ToInt32(lblpunteoN1S.Text) <= limesupe1))
            {
                picboxestreN1S.Image = imgLiSuma.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                picboxestreN1S.Image = imgLiSuma.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteoN1S.Text) >= limeinfe2) && (Convert.ToInt32(lblpunteoN1S.Text) <= limesupe2))
            {
                picboxestreN1S.Image = imgLiSuma.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN1S.Text) >= limiinfe3) && (Convert.ToInt32(lblpunteoN1S.Text) <=  limisupe3))
            {
                picboxestreN1S.Image = imgLiSuma.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }
         
            tiempo1--; // le resto 1 segundo al tiempo que incia en 60 segundos 
            lblpunteoN1S.Text = claseN1deS.punteosN1S(); // le quito los puntos respectivos a sus segundos 

            if ((tiempo1 >= 0) && (Convert.ToInt32(lblpunteoN1S.Text) > 0) && (Convert.ToInt32(lblpunteoN1S.Text)>= puntemin1)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN1S.Text = tiempo1.ToString();
                
            }
            else
            {
                // si la condicion no se cumple el usuario perdera 
                timerN1S.Stop(); 
                lblpunteoN1S.Text = "0";
                picboxestreN1S.Image = imgLiSuma.Images[0]; 
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_SUMA perdiste1 = new Niveles_SUMA();
                this.Hide(); 
                perdiste1.ShowDialog();
                this.Close(); 
                
            }
        }

        private void cmdresp1N1S_Click(object sender, EventArgs e)
        {
            /*A la hora de darle el boton inicio empezamos obteniendo el randm declarado en este botón en este caso tomará 
             la posición 0, para ello recurri a la lista ya que dentro de ella guarde mis digitos de 1 a 31 que usare ahorita*/
            List<int> Nivel1_Suma = claseN1deS.retornar_listaN1S();
            if (Nivel1_Suma[0] == claseN1deS.retonar_resultadoN1S()) /*Condicione la lista en la posición 0 en caso dado fuera a resultado 
                                                                     que sea la respuesta correcta y el juego suga su curso, 
                                                                     * si no sucede lo explicare en el else*/
            {
                iniciarlvl1(); /*LLAMO NUEVAMENTE EL metodo de mi clase contenido dentro de la forma. */
                conteo1 = conteo1 + 1; // por c/operacion que vaya pasando y la tenga correcta se le iran aumentando el conteo hasta llegar a 10 oepraciones en la cual avanzara de nivel 
                lblconteoON1S.Text = Convert.ToString(conteo1) + " /10";
                if (conteo1 == 10) // si llega a 10 correctas sin perder antes pasara de nivel 
                {
                    timerN1S.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true; 
                    TabCSuma.SelectedIndex = 1; 
                }
            }

            else
            {
                // por cada mala se le restaran 3 segundos y 20000 puntos y ademas la casilla del boton que haya tenido la mala
                // se pondra color rojo. 
                cmdresp1N1S.BackColor = Color.Red;
                tiempo1 -= 3;
                lbltiempoN1S.Text = Convert.ToString(tiempo1);
                lblpunteoN1S.Text = claseN1deS.quitarpuntosN1S();
            }
        }

        private void cmdres2N1S_Click(object sender, EventArgs e)
        {
            // pasa lo mimso que en el cmdres1N1S 
            List<int> Nivel1_Suma = claseN1deS.retornar_listaN1S();
            if (Nivel1_Suma[1] == claseN1deS.retonar_resultadoN1S())
            {
                iniciarlvl1();
                conteo1 = conteo1 + 1;
                lblconteoON1S.Text = Convert.ToString(conteo1) + " /10";
                if (conteo1 == 10)
                {

                    timerN1S.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true; 
                    TabCSuma.SelectedIndex = 1; 

                }
            }

            else
            {
                cmdres2N1S.BackColor = Color.Red;
                tiempo1 -= 3;
                lbltiempoN1S.Text = Convert.ToString(tiempo1);
                lblpunteoN1S.Text = claseN1deS.quitarpuntosN1S();
            }
        }

        private void cmdresp3N1S_Click(object sender, EventArgs e)
        {
            // pasara lo mismo que en los anteriores botones 
            List<int> Nivel1_Suma = claseN1deS.retornar_listaN1S();
            if (Nivel1_Suma[2] == claseN1deS.retonar_resultadoN1S())
            {
                iniciarlvl1();
                conteo1 = conteo1 + 1;
                lblconteoON1S.Text = Convert.ToString(conteo1) + " /10";
                if (conteo1 == 10)
                {
                    timerN1S.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true; 
                    TabCSuma.SelectedIndex = 1; 

                }
            }

            else
            {
                cmdresp3N1S.BackColor = Color.Red;
                tiempo1 -= 3;
                lbltiempoN1S.Text = Convert.ToString(tiempo1);
                lblpunteoN1S.Text = claseN1deS.quitarpuntosN1S();
            }
        }

        private void cmdresp4N1S_Click(object sender, EventArgs e)
        {
            // pasara lo mismo que en los botones o comandos superiores 
            List<int> Nivel1_Suma = claseN1deS.retornar_listaN1S();
            if (Nivel1_Suma[3] == claseN1deS.retonar_resultadoN1S())
            {
                iniciarlvl1();

                this.cmdinicioN1S.Enabled = false;
                conteo1 = conteo1 + 1;
                lblconteoON1S.Text = Convert.ToString(conteo1) + " /10";
                if (conteo1 == 10)
                {
                    timerN1S.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true; 
                    TabCSuma.SelectedIndex = 1; 
                }
            }

            else
            {
                cmdresp4N1S.BackColor = Color.Red;
                tiempo1 -= 3;
                lbltiempoN1S.Text = Convert.ToString(tiempo1);
                lblpunteoN1S.Text = claseN1deS.quitarpuntosN1S();

            }
        }
        //FIn Nivel 1________________________________________________________________________________________

        /*Inicio Nivel 2 */

        ClassSuma_Niveles claselvl2S = new ClassSuma_Niveles(); // llamo la clase dle nivel 2 
        int conteo2 = 1, tiempo2 = 60, punteomax2 = 110000; 
        private void tabNivel2S_Click(object sender, EventArgs e)
        {
            lblconteoN2S.Text = " /10"; 
        }

        public void iniciarlvl2()
        {
            claselvl2S.generarlvl2();
            claselvl2S.Respuesta_Lv2();

            List<int> Nivel2_Suma = claselvl2S.retornar_listaN2S();

            lbloperacionN2S.Text = Convert.ToString(claselvl2S.retonar_numero1N2S()) + "   +    ?    =  " +
                                     Convert.ToString(claselvl2S.retonar_resultadoN2S());

            cmdresp1N2S.Text = Nivel2_Suma[0].ToString();
            cmdresp1N2S.BackColor = Color.Transparent;

            cmdresp2N2S.Text = Nivel2_Suma[1].ToString();
            cmdresp2N2S.BackColor = Color.Transparent;

            cmdresp3N2S.Text = Nivel2_Suma[2].ToString();
            cmdresp3N2S.BackColor = Color.Transparent;

            cmdresp4N2S.Text = Nivel2_Suma[3].ToString();
            cmdresp4N2S.BackColor = Color.Transparent;

        }
        private void cmdinicioN2S_Click(object sender, EventArgs e)
        {
            cmdresp1N2S.Enabled = true;
            cmdresp2N2S.Enabled = true;
            cmdresp3N2S.Enabled = true;
            cmdresp4N2S.Enabled = true;
            iniciarlvl2();
            timerN2S.Start();
            lblconteoN2S.Text = " 1/10";
            lblpunteoN2S.Text = Convert.ToString(punteomax2);
        }
        private void timerN2S_Tick(object sender, EventArgs e)
        {
            tiempo2--;
            lblpunteoN2S.Text = claselvl2S.quitapunteos_segundosN2S();

            int puntemin1_2S = 55000, limiinfe1_2S = 0, limeinfe2_2S = 0, A1_2S = 0,
              limiinfe3_2S = 0, limesupe1_2S = 0, limesupe2_2S = 0, limisupe3_2S = 0;
            
            A1_2S = (punteomax2 - puntemin1_2S) / 3;
            limiinfe1_2S = puntemin1_2S;
            limeinfe2_2S = puntemin1_2S + A1_2S;
            limiinfe3_2S = puntemin1_2S + (2 * A1_2S);
            limesupe1_2S = (puntemin1_2S + A1_2S) - 1;
            limesupe2_2S = ((puntemin1_2S + (2 * A1_2S)) - 1);
            limisupe3_2S = punteomax2;
            /*Me acorte más el trabajo mostrando con una imalist todas las estrellas */
            //lo mismo que el nivel 1 cuano esta en la posicion [1] obtendra 1 estrella 
            // posicion [2] obtendra 2 estrellas 
            //posicion [3]obtendra 3 estrellas 
            if ((Convert.ToInt32(lblpunteoN2S.Text) >= limiinfe1_2S) && (Convert.ToInt32(lblpunteoN2S.Text) <= limesupe1_2S))
            {
                picboxestreN2S.Image = imgLiSuma.Images[1]; 
            }
            else
            {
                picboxestreN2S.Image = imgLiSuma.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN2S.Text) >= limeinfe2_2S) && (Convert.ToInt32(lblpunteoN2S.Text) <= limesupe2_2S))
            {
                picboxestreN2S.Image = imgLiSuma.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN2S.Text) >= limiinfe3_2S) && (Convert.ToInt32(lblpunteoN2S.Text) <= limisupe3_2S))
            {
                picboxestreN2S.Image = imgLiSuma.Images[3];
            }
    
            //condicion donde si el usuario no llega a la puntuccion minima perdera el juego 
            if ((tiempo2 >= 0) && (Convert.ToInt32(lblpunteoN2S.Text) > 0) && (Convert.ToInt32(lblpunteoN2S.Text) >= puntemin1_2S))
            {
                lbltimepoN2s.Text = tiempo2.ToString();
            }
            else
            {
                timerN2S.Stop(); 
                lblpunteoN2S.Text = "0";
                picboxestreN2S.Image = imgLiSuma.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo");
                Niveles_SUMA perdiste2 = new Niveles_SUMA();
                this.Hide();
                perdiste2.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N2S_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Suma = claselvl2S.retornar_listaN2S();
            if (Nivel2_Suma[0] == claselvl2S.retonar_resucN2s())
            {
                iniciarlvl2();
                conteo2 = conteo2 + 1;
                lblconteoN2S.Text = Convert.ToString(conteo2) + " /10";

                if (conteo2 == 10)
                {
                    timerN2S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 2");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true; 
                    TabCSuma.SelectedIndex = 2; 
                }
            }
            else
            {
                cmdresp1N2S.BackColor = Color.Red;
                tiempo2 -= 3;
                lbltimepoN2s.Text = Convert.ToString(tiempo2);
                lblpunteoN2S.Text = claselvl2S.quitarpuntosN2S();
            }
        }

        private void cmdresp2N2S_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Suma = claselvl2S.retornar_listaN2S();
            if (Nivel2_Suma[1] == claselvl2S.retonar_resucN2s())
            {
                iniciarlvl2();
                conteo2 = conteo2 + 1;
                lblconteoN2S.Text = Convert.ToString(conteo2) + " /10";
                if (conteo2 == 10)
                {
                    timerN2S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 2");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true; 
                    TabCSuma.SelectedIndex = 2; 
                }
            }
            else
            {
                cmdresp2N2S.BackColor = Color.Red;
                tiempo2 -= 3;
                lbltimepoN2s.Text = Convert.ToString(tiempo2);
                lblpunteoN2S.Text = claselvl2S.quitarpuntosN2S();
            }
        }

        private void cmdresp3N2S_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Suma = claselvl2S.retornar_listaN2S();
            if (Nivel2_Suma[2] == claselvl2S.retonar_resucN2s())
            {
                iniciarlvl2();
                conteo2 = conteo2 + 1;
                lblconteoN2S.Text = Convert.ToString(conteo2) + " /10";
                if (conteo2 == 10)
                {
                    timerN2S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 2");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true; 
                    TabCSuma.SelectedIndex = 2; 

                }
            }
            else
            {
                cmdresp3N2S.BackColor = Color.Red;
                tiempo2 -= 3;
                lbltimepoN2s.Text = Convert.ToString(tiempo2);
                lblpunteoN2S.Text = claselvl2S.quitarpuntosN2S();
            }
        }

        private void cmdresp4N2S_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Suma = claselvl2S.retornar_listaN2S();
            if (Nivel2_Suma[3] == claselvl2S.retonar_resucN2s())
            {
                iniciarlvl2();
                conteo2 = conteo2 + 1;
                lblconteoN2S.Text = Convert.ToString(conteo2) + " /10";
                if (conteo2 == 10)
                {
                    timerN2S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 2");
                    cmdiniciarN3S.Enabled = true; 
                    TabCSuma.SelectedIndex = 2; 
                }
            }
            else
            {
                cmdresp4N2S.BackColor = Color.Red;
                tiempo2 -= 3;
                lbltimepoN2s.Text = Convert.ToString(tiempo2);
                lblpunteoN2S.Text = claselvl2S.quitarpuntosN2S();
            }
        }
        //FIN NIVEL2____________________________________________________________________________________

        /*INICIO NIVEL 3*/
        ClassSuma_Niveles cargarclaslvS3 = new ClassSuma_Niveles();
        int conteo3 = 1, tiempo3 = 60, punteomax3 = 120000;
        private void tabNivel3S_Click(object sender, EventArgs e)
        {
            lblconteoN3S.Text = " /10";
            
        }
        public void inciarlvlS3()
        { /*jalar los retornos de la forma de este nivel */
            cargarclaslvS3.generarlvlS3();
            cargarclaslvS3.Respuesta_LvlS3();
            List<string> Nivel3_Suma_Cadena = cargarclaslvS3.retornar_listaN3S();

            lbloperacionN3S.Text = "  ?   +   ?   =   " + Convert.ToString(cargarclaslvS3.retonar_resultadoN3S());

            cmdresp1N3S.Text = Nivel3_Suma_Cadena[0].ToString();
            cmdresp1N3S.BackColor = Color.Transparent;

            cmdresp2N3S.Text = Nivel3_Suma_Cadena[1].ToString();
            cmdresp2N3S.BackColor = Color.Transparent;

            cmdresp3N3S.Text = Nivel3_Suma_Cadena[2].ToString();
            cmdresp3N3S.BackColor = Color.Transparent;

            cmdresp4N3S.Text = Nivel3_Suma_Cadena[3].ToString();
            cmdresp4N3S.BackColor = Color.Transparent;
        }
        private void cmdiniciarN3S_Click(object sender, EventArgs e)
        {
            inciarlvlS3();

            cmdresp1N3S.Enabled = true;
            cmdresp2N3S.Enabled = true;
            cmdresp3N3S.Enabled = true;
            cmdresp4N3S.Enabled = true;
            cmdiniciarN3S.Enabled = false;
             
            timerN3S.Start();
            lblconteoN3S.Text = " 1/10 ";
            lblpuntosN3S.Text = Convert.ToString(punteomax3);
        }
        private void timerN3S_Tick(object sender, EventArgs e)
        {
            tiempo3--;
            lblpuntosN3S.Text = cargarclaslvS3.quitapunteos_segundosN3S(); /*quito los puntos por segundo que serian 2000 por segundo*/

            int puntemin1_3S = 60000, limiinfe1_3S = 0, limeinfe2_3S = 0, A1_3S = 0,
             limiinfe3_3S = 0, limesupe1_3S = 0, limesupe2_3S = 0, limisupe3_3S = 0;
            
            A1_3S = (punteomax3 - puntemin1_3S) / 3;
            limiinfe1_3S = puntemin1_3S;
            limeinfe2_3S = puntemin1_3S + A1_3S;
            limiinfe3_3S = puntemin1_3S + (2 * A1_3S);
            limesupe1_3S = (puntemin1_3S + A1_3S) - 1;
            limesupe2_3S = ((puntemin1_3S + (2 * A1_3S)) - 1);
            limisupe3_3S = punteomax3;
               // PARA LAS IMAGENES SUCEDERA LO MISMO SIEMPRE RESPETANDO SUS RESPECTIVAS CONDICIONES CON los intervalos entre 
            // limite inferior y superior respetivo a c/nivel 
            if ((Convert.ToInt32(lblpuntosN3S.Text) >= limiinfe1_3S) && (Convert.ToInt32(lblpuntosN3S.Text) <= limesupe1_3S))
            {
                picestreN3S.Image = imgLiSuma.Images[1]; 
            }
                     else
                {
                         picestreN3S.Image = imgLiSuma.Images[0]; 
                }
            if ((Convert.ToInt32(lblpuntosN3S.Text) >= limeinfe2_3S) && (Convert.ToInt32(lblpuntosN3S.Text) <= limesupe2_3S))
            {
                picestreN3S.Image = imgLiSuma.Images[2]; 
            }
            if ((Convert.ToInt32(lblpuntosN3S.Text) >= limiinfe3_3S) && (Convert.ToInt32(lblpuntosN3S.Text) <= limisupe3_3S))
            {
                picestreN3S.Image = imgLiSuma.Images[3]; 
            }

            if ((tiempo3 >= 0) && (Convert.ToInt32(lblpuntosN3S.Text) > 0) && (Convert.ToInt32(lblpuntosN3S.Text) >= puntemin1_3S))
            {
               lbltiempoN3S.Text = tiempo3.ToString();
            }
            else
            {
                timerN3S.Stop(); 
                lblpuntosN3S.Text = "0";
                picestreN3S.Image = imgLiSuma.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo");
                Niveles_SUMA perdiste3 = new Niveles_SUMA();
                this.Hide();
                perdiste3.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N3S_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Suma_Enteros = cargarclaslvS3.retornarlistaenteros();
            
            if (Nivel3_Suma_Enteros[0] == cargarclaslvS3.retonar_resultadoN3S())
            {
                inciarlvlS3();
                conteo3 = conteo3 + 1;
                lblconteoN3S.Text = Convert.ToString(conteo3) + " /10";
                if (conteo3 == 10)
                {
                    timerN3S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true; 
                    TabCSuma.SelectedIndex = 3; 
                }
            }
            else
            {
                cmdresp1N3S.BackColor = Color.Red;
                tiempo3 -= 3;
                lbltiempoN3S.Text = Convert.ToString(tiempo3);
                lblpuntosN3S.Text = cargarclaslvS3.quitarpuntosN3S();
            }
        }

        private void cmdresp2N3S_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Suma_Enteros = cargarclaslvS3.retornarlistaenteros();
            if (Nivel3_Suma_Enteros[1] == cargarclaslvS3.retonar_resultadoN3S())
            {
                inciarlvlS3();
                cmdiniciarN3S.Enabled = false;
                conteo3 = conteo3 + 1;
                lblconteoN3S.Text = Convert.ToString(conteo3) + " /10";
                if (conteo3 == 10)
                {
                    timerN3S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true; 
                    TabCSuma.SelectedIndex = 3; 
                }
            }
            else
            {
                cmdresp2N3S.BackColor = Color.Red;
                tiempo3 -= 3;
                lbltiempoN3S.Text = Convert.ToString(tiempo3);
                lblpuntosN3S.Text = cargarclaslvS3.quitarpuntosN3S();
            }
        }

        private void cmdresp3N3S_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Suma_Enteros = cargarclaslvS3.retornarlistaenteros();
            if (Nivel3_Suma_Enteros[2] == cargarclaslvS3.retonar_resultadoN3S())
            {
                inciarlvlS3();
                cmdiniciarN3S.Enabled = false;
                conteo3 = conteo3 + 1;
                lblconteoN3S.Text = Convert.ToString(conteo3) + " /10";
                if (conteo3 == 10)
                {
                    timerN3S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true; 
                    TabCSuma.SelectedIndex = 3; 
                }
            }
            else
            {
                cmdresp3N3S.BackColor = Color.Red;
                tiempo3 -= 3;
                lbltiempoN3S.Text = Convert.ToString(tiempo3);
                lblpuntosN3S.Text = cargarclaslvS3.quitarpuntosN3S();
            }
        }

        private void cmdresp4N3S_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Suma_Enteros = cargarclaslvS3.retornarlistaenteros();
            if (Nivel3_Suma_Enteros[3] == cargarclaslvS3.retonar_resultadoN3S())
            {
                inciarlvlS3();
                cmdiniciarN3S.Enabled = false;
                conteo3 = conteo3 + 1;
                lblconteoN3S.Text = Convert.ToString(conteo3) + " /10";
                if (conteo3 == 10)
                {
                    timerN3S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true; 
                    TabCSuma.SelectedIndex = 3; 
                }
            }
            else
            {
                cmdresp4N3S.BackColor = Color.Red;
                tiempo3 -= 3;
                lbltiempoN3S.Text = Convert.ToString(tiempo3);
                lblpuntosN3S.Text = cargarclaslvS3.quitarpuntosN3S();
            }
        }
        //FIN NIVEL 3__________________________________________________________________________________________________________

        /* INICIO NIVEL 4*/
        ClassSuma_Niveles llamarclasslvS4 = new ClassSuma_Niveles();
        int conteo4S = 1, tiempo4S = 60, punteomax4S = 130000;
        private void tabNivel4S_Click(object sender, EventArgs e)
        {
            lblconteoN4S.Text = " /10";
            
        }
        public void inciarlvlS4()
        { /*jalar los retornos de la forma de este nivel */
            llamarclasslvS4.generarlvlS4();
            llamarclasslvS4.Respuesta_LvlS4();

            List<string> Nivel4_Suma_Cadena = llamarclasslvS4.retornar_listaNS4(); /*retorno a lista de las cadena de caracteres*/

            lbloperacionN4S.Text = " ¿Cuál suma es la menor? "; /*realizo la pregunta a respnder */

            /*le pongo color transparente a lahora de iniciar el nivel */
            cmdresp1N4S.Text = Nivel4_Suma_Cadena[0].ToString();
            cmdresp1N4S.BackColor = Color.Transparent;

            cmdresp2N4S.Text = Nivel4_Suma_Cadena[1].ToString();
            cmdresp2N4S.BackColor = Color.Transparent;

            cmdresp3N4S.Text = Nivel4_Suma_Cadena[2].ToString();
            cmdresp3N4S.BackColor = Color.Transparent;

            cmdresp4N4S.Text = Nivel4_Suma_Cadena[3].ToString();
            cmdresp4N4S.BackColor = Color.Transparent;
        }

        private void cmdiniciarN4S_Click(object sender, EventArgs e)
        {
            inciarlvlS4();

            cmdresp1N4S.Enabled = true;
            cmdresp2N4S.Enabled = true;
            cmdresp3N4S.Enabled = true;
            cmdresp4N4S.Enabled= true;
            cmdiniciarN4S.Enabled = false; // lo deshabilito para que el usuario no este usandolo para intentar trabar el juego 

            timerN4S.Start(); 
            lblconteoN4S.Text= " 1/10";
            lblpunteoN4S.Text = Convert.ToString(punteomax4S); 
        }
        private void timerN4S_Tick(object sender, EventArgs e)
        {
            /*antes de condicionar el tiempo por cada segundo que vaya pasando se le ira quitando cierta cantidad de pntos */
            tiempo4S--;
            lblpunteoN4S.Text = llamarclasslvS4.quitapunteos_segundosNS4();

            /*ahora obtengo las estrellas para este nivel, lo tendre que pasar a la clase si me da tiempo */
            int puntemin1_4S = 65000, limiinfe1_4S = 0, limeinfe2_4S = 0, A1_4S = 0,
             limiinfe3_4S = 0, limesupe1_4S = 0, limesupe2_4S = 0, limisupe3_4S = 0;

            A1_4S = (punteomax4S - puntemin1_4S) / 3;
            limiinfe1_4S = puntemin1_4S;
            limeinfe2_4S = puntemin1_4S + A1_4S;
            limiinfe3_4S = puntemin1_4S + (2 * A1_4S);
            limesupe1_4S = (puntemin1_4S + A1_4S) - 1;
            limesupe2_4S = ((puntemin1_4S + (2 * A1_4S)) - 1);
            limisupe3_4S = punteomax4S;
            // si el ususario no respeta las condiciones para este nivel no podra pasar de nivel 
            // con el tema de las estrellas es el mimso caso en cada posicion que estás esten jugando 
            if ((Convert.ToInt32(lblpunteoN4S.Text) >= limiinfe1_4S) && (Convert.ToInt32(lblpunteoN4S.Text) <= limesupe1_4S))
            {
                picboxestreN4S.Image = imgLiSuma.Images[1]; 
            }
                 else
                 {
                    picboxestreN4S.Image = imgLiSuma.Images[0]; 
                 }
            if ((Convert.ToInt32(lblpunteoN4S.Text) >= limeinfe2_4S) && (Convert.ToInt32(lblpunteoN4S.Text) <= limesupe2_4S))
            {
                picboxestreN4S.Image = imgLiSuma.Images[2]; 
            }
            if ((Convert.ToInt32(lblpunteoN4S.Text) >= limiinfe3_4S) && (Convert.ToInt32(lblpunteoN4S.Text) <= limisupe3_4S))
            {
                picboxestreN4S.Image = imgLiSuma.Images[3]; 
            }

            if ((tiempo4S >= 0) && (Convert.ToInt32(lblpunteoN4S.Text) > 0) && (Convert.ToInt32(lblpunteoN4S.Text) >= puntemin1_4S))
            {
                lbltiempoN3S.Text = tiempo3.ToString();
            }
            else
            {
                timerN4S.Stop(); 
                lblpunteoN4S.Text = "0";
                picboxestreN4S.Image = imgLiSuma.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo");
                Niveles_SUMA perdiste4 = new Niveles_SUMA();
                this.Hide();
                perdiste4.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N4S_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Suma_Enteros = llamarclasslvS4.retornarlistaenterosS4(); 

            if (Nivel4_Suma_Enteros[0] == llamarclasslvS4.retonar_resultadoNS4())
            {
                inciarlvlS4();
               cmdiniciarN4S.Enabled = false;
               conteo4S = conteo4S + 1;
               lblconteoN4S.Text = Convert.ToString(conteo4S) + " /10";
               if (conteo4S == 10)
                {
                    timerN4S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true; 
                    cmdiniciarN5S.Enabled = true; 
                    TabCSuma.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp1N4S.BackColor = Color.Red;
                tiempo4S -= 3;
                lbltiempoN4S.Text = Convert.ToString(tiempo4S);
                lblpunteoN4S.Text = llamarclasslvS4.quitarpuntosN4S(); 
            }
        }

        private void cmdresp2N4S_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Suma_Enteros = llamarclasslvS4.retornarlistaenterosS4();

            if (Nivel4_Suma_Enteros[1] == llamarclasslvS4.retonar_resultadoNS4())
            {
                inciarlvlS4();
                cmdiniciarN4S.Enabled = false;
                conteo4S = conteo4S + 1;
                lblconteoN4S.Text = Convert.ToString(conteo4S) + " /10";
                if (conteo4S == 10)
                {
                    timerN4S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true;
                    cmdiniciarN5S.Enabled = true; 
                    TabCSuma.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp2N4S.BackColor = Color.Red;
                tiempo4S -= 3;
                lbltiempoN4S.Text = Convert.ToString(tiempo4S);
                lblpunteoN4S.Text = llamarclasslvS4.quitarpuntosN4S();
            }
        }

        private void cmdresp3N4S_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Suma_Enteros = llamarclasslvS4.retornarlistaenterosS4();

            if (Nivel4_Suma_Enteros[2] == llamarclasslvS4.retonar_resultadoNS4())
            {
                inciarlvlS4();
                cmdiniciarN4S.Enabled = false;
                conteo4S = conteo4S + 1;
                lblconteoN4S.Text = Convert.ToString(conteo4S) + " /10";
                if (conteo4S == 10)
                {
                    timerN4S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true;
                    cmdiniciarN5S.Enabled = true; 
                    TabCSuma.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp3N4S.BackColor = Color.Red;
                tiempo4S -= 3;
                lbltiempoN4S.Text = Convert.ToString(tiempo4S);
                lblpunteoN4S.Text = llamarclasslvS4.quitarpuntosN4S();
            }
        }

        private void cmdresp4N4S_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Suma_Enteros = llamarclasslvS4.retornarlistaenterosS4();

            if (Nivel4_Suma_Enteros[3] == llamarclasslvS4.retonar_resultadoNS4())
            {
                inciarlvlS4();
                cmdiniciarN4S.Enabled = false;
                conteo4S = conteo4S + 1;
                lblconteoN4S.Text = Convert.ToString(conteo4S) + " /10";
                if (conteo4S == 10)
                {
                    timerN4S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true;
                    cmdiniciarN5S.Enabled = true; 
                    TabCSuma.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp4N4S.BackColor = Color.Red;
                tiempo4S -= 3;
                lbltiempoN4S.Text = Convert.ToString(tiempo4S);
                lblpunteoN4S.Text = llamarclasslvS4.quitarpuntosN4S();
            }
        }

        
        // FIN NIVEL 4._________________________________________________________________-----_______________

        /*INICIO NIVEL 5*/
        ClassSuma_Niveles cargarlvl5_Suma = new ClassSuma_Niveles();  //  ClassSuma_Niveles llamarclasslvS4 = new ClassSuma_Niveles();
        int conteo5S = 1, tiempo5S = 60, punteomax5S = 140000;
        private void tabNivel5S_Click(object sender, EventArgs e)
        {
            lblconteoN5S.Text = " /10"; 
        }
        public void inciarlvlS5()
        { /*jalar los retornos de la forma de este nivel */

            cargarlvl5_Suma.generarlvlS5();

            cargarlvl5_Suma.Respuesta_LvlS5();

            List<string> Nivel5_Suma_Cadena = cargarlvl5_Suma.retornar_listaNS5(); /*retorno a lista de las cadena de caracteres*/

            lbloperacionN5S.Text = " ¿Cuál suma es la mayor? "; /*realizo la pregunta a respnder */

            /*le pongo color transparente a lahora de iniciar el nivel y las posiciones que juegan de c/uno de ellos */

            cmdresp1N5S.Text = Nivel5_Suma_Cadena[0].ToString();
            cmdresp1N5S.BackColor = Color.Transparent;

            cmdresp2N5S.Text = Nivel5_Suma_Cadena[1].ToString();
            cmdresp2N5S.BackColor = Color.Transparent;

            cmdresp3N5S.Text = Nivel5_Suma_Cadena[2].ToString();
            cmdresp3N5S.BackColor = Color.Transparent;

            cmdresp4N5S.Text = Nivel5_Suma_Cadena[3].ToString();
            cmdresp4N5S.BackColor = Color.Transparent;
        }

        private void cmdiniciarN5S_Click(object sender, EventArgs e)
        {
            inciarlvlS5();

            cmdresp1N5S.Enabled = true;
            cmdresp2N5S.Enabled = true;
            cmdresp3N5S.Enabled = true;
            cmdresp4N5S.Enabled = true;
            cmdiniciarN5S.Enabled = false; 

            timerN5S.Start(); 
            lblconteoN5S.Text = " 1/10";
            lblpunteoN5S.Text = Convert.ToString(punteomax5S); 
        }

        private void timerN5S_Tick(object sender, EventArgs e)
        {
          
            int puntemin1_5S = 70000, limiinfe1_5S = 0, limeinfe2_5S = 0, A1_5S = 0,
            limiinfe3_5S = 0, limesupe1_5S = 0, limesupe2_5S = 0, limisupe3_5S = 0;
       
            A1_5S = (punteomax5S - puntemin1_5S) / 3;
            //limites inferiores 
            limiinfe1_5S = puntemin1_5S;
            limeinfe2_5S = puntemin1_5S + A1_5S;
            limiinfe3_5S = puntemin1_5S + (2 * A1_5S);
            //limites superiores 
            limesupe1_5S = (puntemin1_5S + A1_5S) - 1;
            limesupe2_5S = ((puntemin1_5S + (2 * A1_5S)) - 1);
            limisupe3_5S = punteomax5S;
            // si el usuario no llegara al punteominimo perdera o bien si el timepo llegara a 0 
            if ((Convert.ToInt32(lblpunteoN5S.Text) >= limiinfe1_5S) && (Convert.ToInt32(lblpunteoN5S.Text) <= limesupe1_5S))
            {
                picbestreN5S.Image = imgLiSuma.Images[1];
            }
            else
            {
                picbestreN5S.Image = imgLiSuma.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN5S.Text) >= limeinfe2_5S) && (Convert.ToInt32(lblpunteoN5S.Text) <= limesupe2_5S))
            {
                picbestreN5S.Image = imgLiSuma.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN5S.Text) >= limiinfe3_5S) && (Convert.ToInt32(lblpunteoN5S.Text) <= limisupe3_5S))
            {
                picbestreN5S.Image = imgLiSuma.Images[3];

            }
            tiempo5S--;
            lblpunteoN5S.Text = cargarlvl5_Suma.quitapunteos_segundosNS5();
            // esta condicion contiene la misma sintaxis que las otras solo varian las variables 
            if ((tiempo5S >= 0) && (Convert.ToInt32(lblpunteoN5S.Text) > 0) && (Convert.ToInt32(lblpunteoN5S.Text) >= puntemin1_5S))
            {
                lbltiempoN5S.Text = tiempo5S.ToString();
            }
            else
            {
                timerN5S.Stop();
                lblconteoN5S.Text = "0";
                picbestreN5S.Image = imgLiSuma.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_SUMA perdiste5 = new Niveles_SUMA(); // reinicir la tab 
                this.Hide();
                perdiste5.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N5S_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Suma_Enteros = cargarlvl5_Suma.retornarlistaenterosS5();

            if (Nivel5_Suma_Enteros[0] == cargarlvl5_Suma.retonar_resultadoNS5())
            {
                inciarlvlS5();

                cmdiniciarN5S.Enabled = false;

                conteo5S = conteo5S + 1;
                lblconteoN5S.Text = Convert.ToString(conteo5S) + " /10";
                if (conteo5S == 10)
                {
                    timerN5S.Stop(); 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    // se activan los botones de inicio 
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true;
                    cmdiniciarN5S.Enabled = true; 
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show(); 
                }
            }
            else
            {
                cmdresp1N5S.BackColor = Color.Red;
                tiempo5S -= 3;
               lbltiempoN5S.Text = Convert.ToString(tiempo5S);
               lblpunteoN5S.Text = cargarlvl5_Suma.quitarpuntosN5S(); 
            }
        }

        private void cmdresp2N5S_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Suma_Enteros = cargarlvl5_Suma.retornarlistaenterosS5();

            if (Nivel5_Suma_Enteros[1] == cargarlvl5_Suma.retonar_resultadoNS5())
            {
                inciarlvlS5();

                cmdiniciarN5S.Enabled = false;

                conteo5S = conteo5S + 1;
                lblconteoN5S.Text = Convert.ToString(conteo5S) + " /10";
                if (conteo5S == 10)
                {
                    timerN5S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    // todos los niveles se activaran media vez pase de nivel 
                    cmdinicioN1S.Enabled = true;
                    cmdinicioN2S.Enabled = true;
                    cmdiniciarN3S.Enabled = true;
                    cmdiniciarN4S.Enabled = true;
                    cmdiniciarN5S.Enabled = true; 
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPEleccion.Show();
                }
            }
            else
            {
                cmdresp2N5S.BackColor = Color.Red;
                tiempo5S -= 3;
                lbltiempoN5S.Text = Convert.ToString(tiempo5S);
                lblpunteoN5S.Text = cargarlvl5_Suma.quitarpuntosN5S();
            }
        }

        private void cmdresp3N5S_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Suma_Enteros = cargarlvl5_Suma.retornarlistaenterosS5();

            if (Nivel5_Suma_Enteros[2] == cargarlvl5_Suma.retonar_resultadoNS5())
            {
                inciarlvlS5();

                cmdiniciarN5S.Enabled = false;

                conteo5S = conteo5S + 1;
                lblconteoN5S.Text = Convert.ToString(conteo5S) + " /10";
                if (conteo5S == 10)
                {
                    timerN5S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPEleccion.ShowDialog();
                    this.Close(); 
                }
            }
            else
            {
                cmdresp3N5S.BackColor = Color.Red;
                tiempo5S -= 3;
                lbltiempoN5S.Text = Convert.ToString(tiempo5S);
                lblpunteoN5S.Text = cargarlvl5_Suma.quitarpuntosN5S();
            }
        }

        private void cmdresp4N5S_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Suma_Enteros = cargarlvl5_Suma.retornarlistaenterosS5();

            if (Nivel5_Suma_Enteros[3] == cargarlvl5_Suma.retonar_resultadoNS5())
            {
                inciarlvlS5();

                cmdiniciarN5S.Enabled = false;

                conteo5S = conteo5S + 1;
                lblconteoN5S.Text = Convert.ToString(conteo5S) + " /10";
                if (conteo5S == 10)
                {
                    timerN5S.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPEleccion.Show();
                }
            }
            else
            {
                cmdresp4N5S.BackColor = Color.Red;
                tiempo5S -= 3;
                lbltiempoN5S.Text = Convert.ToString(tiempo5S);
                lblpunteoN5S.Text = cargarlvl5_Suma.quitarpuntosN5S();
            }
        }
        }

    }// FIN MUNDO SUMA 

