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
    public partial class Niveles_DIVISION : Form
    {
        ClassDivision_Niveles cargarlvl1D = new ClassDivision_Niveles();
        int conteo1D1 = 1, tiempo1D1 = 60, punteomax1D1 = 100000;
        public Niveles_DIVISION()
        {
            InitializeComponent();
        }
        private void tabNivel1Divi_Click(object sender, EventArgs e)
        {
            /*iniciar el conteo en 0 */
            lblconteoN1Divi.Text = " /10";
        }
        private void emepzarLvl1Divi()
        {
            /*Cargar los metodos de las clases */
            cargarlvl1D.generarlvlD1();
            cargarlvl1D.Respuesta_Lv1D1();

            /*cargo la lista de cadena*/
            List<string> Nivel1_Division = cargarlvl1D.retornar_Lista_cade_D1();

            /*obtengo las variables de los métodos */

            lbla.Text = Convert.ToString(cargarlvl1D.retonar_numero1N1D());
            lblb.Text = Convert.ToString(cargarlvl1D.retonar_numero2N1D());
            lbla2.Text = Convert.ToString(cargarlvl1D.retonrar_a2numero1N1D1());
            lblb2.Text = Convert.ToString(cargarlvl1D.retonar_b2numero2N1D());

            /*colo color y posiciones a los botones */
            cmdresp1N1Divi.Text = Nivel1_Division[0].ToString();
            cmdresp1N1Divi.BackColor = Color.Transparent;

            cmdresp2N1Di.Text = Nivel1_Division[1].ToString();
            cmdresp2N1Di.BackColor = Color.Transparent;

            cmdresp3N1Divi.Text = Nivel1_Division[2].ToString();
            cmdresp3N1Divi.BackColor = Color.Transparent;

            cmdresp4N1Divi.Text = Nivel1_Division[3].ToString();
            cmdresp4N1Divi.BackColor = Color.Transparent;
        }
        private void cmdiniciarN1Divi_Click(object sender, EventArgs e)
        {
            emepzarLvl1Divi();

            cmdresp1N1Divi.Enabled = true;
            cmdresp2N1Di.Enabled = true;
            cmdresp3N1Divi.Enabled = true;
            cmdresp4N1Divi.Enabled = true;

            timerN1Divi.Start();
            lblconteoN1Divi.Text = "1/10";
            lblpunteoN1Divi.Text = Convert.ToString(punteomax1D1);
        }
        private void timerN1Divi_Tick(object sender, EventArgs e)
        {
            int puntemin1Divi1 = 50000, limiinfe1Divi1 = 0, limeinfe2Divi1 = 0, A1Divi = 0, limiinfe3Divi = 0, limesupe1Divi = 0, limesupe2Divi = 0, limisupe3Divi = 0;

            A1Divi = (punteomax1D1 - puntemin1Divi1) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfe1Divi1 = puntemin1Divi1;
            limeinfe2Divi1 = puntemin1Divi1 + A1Divi;
            limiinfe3Divi = puntemin1Divi1 + (2 * A1Divi);
            //obtengo los limites superiores 
            limesupe1Divi = (puntemin1Divi1 + A1Divi) - 1;
            limesupe2Divi = ((puntemin1Divi1 + (2 * A1Divi)) - 1);
            limisupe3Divi = punteomax1D1;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN1Divi.Text) >= limiinfe1Divi1) && (Convert.ToInt32(lblpunteoN1Divi.Text) <= limesupe1Divi))
            {
                 picbEstreN1Divi.Image = imgliDivi.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                 picbEstreN1Divi.Image = imgliDivi.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteoN1Divi.Text) >= limeinfe2Divi1) && (Convert.ToInt32(lblpunteoN1Divi.Text) <= limesupe2Divi))
            {
                 picbEstreN1Divi.Image = imgliDivi.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN1Divi.Text) >= limiinfe3Divi) && (Convert.ToInt32(lblpunteoN1Divi.Text) <= limisupe3Divi))
            {
                picbEstreN1Divi.Image = imgliDivi.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempo1D1--; //disminuye c/segundo en cierto valor 
            lblpunteoN1Divi.Text = cargarlvl1D.quitapunteos_SeguN1D(); // le quito los puntos respectivos a sus segundos 

            if (( tiempo1D1 >= 0) && (Convert.ToInt32(lblpunteoN1Divi.Text) > 0) && (Convert.ToInt32(lblpunteoN1Divi.Text) >= puntemin1Divi1)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN1Divi.Text = tiempo1D1.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera 
                timerN1Divi.Stop();
                lblpunteoN1Divi.Text = "0";
                picbEstreN1Divi.Image = imgliDivi.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");// tendra que repetir el mundo en caso dado perdira 
                Niveles_DIVISION perdiste1 = new Niveles_DIVISION();
                this.Hide();
                perdiste1.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N1Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Division_Entero = cargarlvl1D.retornar_listaN1D();
            if (Nivel1_Division_Entero[0] == cargarlvl1D.retonar_resultadoN1D())
            {
                emepzarLvl1Divi();
                conteo1D1 = conteo1D1 + 1;
                lblconteoN1Divi.Text = Convert.ToString(conteo1D1) + " /10";

                if (conteo1D1 == 10)
                {
                    timerN1Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1");
                    cmdinicioN2Divi.Enabled = true; 
                    TBCDivison.SelectedIndex = 1;
                }
            }
            else
            {
                cmdresp1N1Divi.BackColor = Color.Red;
                tiempo1D1 -= 3;
                lbltiempoN1Divi.Text = Convert.ToString(tiempo1D1);
                lblpunteoN1Divi.Text = cargarlvl1D.quitarpuntosN1D();
            }
        }

        private void cmdresp2N1Di_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Division_Entero = cargarlvl1D.retornar_listaN1D();
            if (Nivel1_Division_Entero[1] == cargarlvl1D.retonar_resultadoN1D())
            {
                emepzarLvl1Divi();
                conteo1D1 = conteo1D1 + 1;
                lblconteoN1Divi.Text = Convert.ToString(conteo1D1) + " /10";

                if (conteo1D1 == 10)
                {
                    timerN1Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1");
                    cmdinicioN2Divi.Enabled = true; 
                    TBCDivison.SelectedIndex = 1;
                }
            }
            else
            {
                cmdresp2N1Di.BackColor = Color.Red;
                tiempo1D1 -= 3;
                lbltiempoN1Divi.Text = Convert.ToString(tiempo1D1);
                lblpunteoN1Divi.Text = cargarlvl1D.quitarpuntosN1D();
            }
        }

        private void cmdresp3N1Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Division_Entero = cargarlvl1D.retornar_listaN1D();
            if (Nivel1_Division_Entero[2] == cargarlvl1D.retonar_resultadoN1D())
            {
                emepzarLvl1Divi();
                conteo1D1 = conteo1D1 + 1;
                lblconteoN1Divi.Text = Convert.ToString(conteo1D1) + " /10";

                if (conteo1D1 == 10)
                {
                    timerN1Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1");
                    cmdinicioN2Divi.Enabled = true; 
                    TBCDivison.SelectedIndex = 1;
                }
            }
            else
            {
                cmdresp3N1Divi.BackColor = Color.Red;
                tiempo1D1 -= 3;
                lbltiempoN1Divi.Text = Convert.ToString(tiempo1D1);
                lblpunteoN1Divi.Text = cargarlvl1D.quitarpuntosN1D();
            }
        }

        private void cmdresp4N1Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Division_Entero = cargarlvl1D.retornar_listaN1D();
            if (Nivel1_Division_Entero[3] == cargarlvl1D.retonar_resultadoN1D())
            {
                emepzarLvl1Divi();
                conteo1D1 = conteo1D1 + 1;
                lblconteoN1Divi.Text = Convert.ToString(conteo1D1) + " /10";

                if (conteo1D1 == 10)
                {
                    timerN1Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1");
                    cmdinicioN2Divi.Enabled = true; 
                    TBCDivison.SelectedIndex = 1;
                }
            }
            else
            {
                cmdresp4N1Divi.BackColor = Color.Red;
                tiempo1D1 -= 3;
                lbltiempoN1Divi.Text = Convert.ToString(tiempo1D1);
                lblpunteoN1Divi.Text = cargarlvl1D.quitarpuntosN1D();
            }
        }


        // FFIN NIVEL 1 

        /*INICIO NIVEL 2 */
        //no me salio en ves de obtener division obtuve nivel 2 DIV 
        ClassDivision_Niveles cargarclselvD2 = new ClassDivision_Niveles();
        int conteoD2 = 1, tiempoD2 = 60, punteomaxD2 = 110000;
        private void tabN2Divi_Click(object sender, EventArgs e)
        {
            lblconteoN2Divi.Text = " /10"; // si da click en la tab esto le aparecera 
        }
        public void generarLvl2Division()
        { 
            //llamo los métodos de mis clases 
            cargarclselvD2.generarlvlDivi2();
            cargarclselvD2.Respuesta_Lv1Divi2();

            //llamo a la lista de mi clase 
            List<int> Nivel2_Division = cargarclselvD2.retornar_listaN2Divi();

            // realizo la operación en donde llamo las variables de la clase todo dentro de una misma label
            lbloperacionN2Divi.Text = Convert.ToString(cargarclselvD2.retonar_numero1N2Divi()) + " / " + Convert.ToString(cargarclselvD2.retonar_numero2N2Divi()) 
                                      + "   +    ?  /  " + Convert.ToString(cargarclselvD2.retonar_numero2N2Divi()) + "   =   " + Convert.ToString(cargarclselvD2.retonar_resultadp2N2Divi());

            // agrego color a mis botons y las posiciones que van a jugar
            cmdresp1N2Divi.Text = Nivel2_Division[0].ToString();
            cmdresp1N2Divi.BackColor = Color.Transparent;

            cmdresp2N2Divi.Text = Nivel2_Division[1].ToString();
            cmdresp2N2Divi.BackColor = Color.Transparent;

            cmdresp3N2Divi.Text = Nivel2_Division[2].ToString();
            cmdresp3N2Divi.BackColor = Color.Transparent;

            cmdresp4N2Divi.Text = Nivel2_Division[3].ToString();
            cmdresp4N2Divi.BackColor = Color.Transparent;
        }
         private void cmdinicioN2Divi_Click(object sender, EventArgs e) // doy inicio a mi operación con este boton 
          {
                generarLvl2Division(); 
                // leugo habilito los botones 
                cmdresp1N2Divi.Enabled = true;
                cmdresp2N2Divi.Enabled = true;
                cmdresp3N2Divi.Enabled = true;
                cmdresp4N2Divi.Enabled = true;

            lblconteoN2Divi.Text = " 1/10"; // agrego el conteo de las operaciones a su label 
            timerN2Divi.Start(); // inicio el tiempo 
            lblpunteoN2Divi.Text = Convert.ToString(punteomaxD2); // agrego el punteo maximo del nivel 
          }

        private void timerN2Divi_Tick(object sender, EventArgs e)
         {
            // obtenemos las estrellas del usuario. 
             int puntemin2Divi = 55000, limiinfe1Divi = 0, limeinfe2Divi = 0, A1Divi = 0,
               limiinfe3Divi = 0, limesupe1Divi = 0, limesupe2Divi = 0, limisupe3Divi = 0;

             A1Divi = (punteomaxD2 - puntemin2Divi) / 3;
             limiinfe1Divi = puntemin2Divi;
             limeinfe2Divi = puntemin2Divi + A1Divi;
             limiinfe3Divi = puntemin2Divi + (2 * A1Divi);
             limesupe1Divi = (puntemin2Divi + A1Divi) - 1;
             limesupe2Divi = ((puntemin2Divi + (2 * A1Divi)) - 1);
             limisupe3Divi = punteomaxD2;

             if ((Convert.ToInt32(lblpunteoN2Divi.Text) >= limiinfe1Divi) && (Convert.ToInt32(lblpunteoN2Divi.Text) <= limesupe1Divi))
             {
                 picestreN2Divi.Image = imgliDivi.Images[1];
             }
                        else
                        {
                            picestreN2Divi.Image = imgliDivi.Images[0];
                        }

             if ((Convert.ToInt32(lblpunteoN2Divi.Text) >= limeinfe2Divi) && (Convert.ToInt32(lblpunteoN2Divi.Text) <= limesupe2Divi))
             {
                 picestreN2Divi.Image = imgliDivi.Images[2];
             }

             if ((Convert.ToInt32(lblpunteoN2Divi.Text) >= limiinfe3Divi) && (Convert.ToInt32(lblpunteoN2Divi.Text) <= limisupe3Divi))
             {
                 picestreN2Divi.Image = imgliDivi.Images[3];
             }

             // agrego el tiempo que va disminuyendo de segundo en segundo quitando puntos al punteo 
             tiempoD2--;
             lblpunteoN2Divi.Text = cargarclselvD2.quitarpuntosN2Divi(); 
             if ((tiempoD2 >= 0) && (Convert.ToInt32(lblpunteoN2Divi.Text) > 0) && (Convert.ToInt32(lblpunteoN2Divi.Text) >= puntemin2Divi))
             {
                 lbltimepoN2Divi.Text = tiempoD2.ToString();
             }
                    else
                    {
                        timerN2Divi.Stop();
                        lblpunteoN2Divi.Text = "0";
                        picestreN2Divi.Image = imgliDivi.Images[0];
                        MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                        Niveles_MULTIPLICACION perdiste2M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                        this.Hide();
                        perdiste2M.ShowDialog();
                        this.Close();
                    }
            // agrego el tiempo que va disminuyendo de segundo en segundo quitando puntos al punteo 
        }
        private void cmdresp1N2Divi_Click(object sender, EventArgs e)
        {
            // llamo nuevamente a la lista 
            List<int> Nivel2_Division = cargarclselvD2.retornar_listaN2Divi(); 
            // realizo la condicion dle nivel si es verdadera el juego siguie 
            if (Nivel2_Division[0] == cargarclselvD2.retornarC2Divi())
            {
                generarLvl2Division();
                conteoD2 = conteoD2 + 1; //  la label de conteo se le va ir sumando este contador de mas 1 
                lblconteoN2Divi.Text = Convert.ToString(conteoD2) + " /10 ";
                if (conteoD2 == 10) // si el conteo llega a 10 en este boton que temrine el juego 
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2"); /*si termina este nivel en este boton saldra un mensaje 
                                                                              y los demas botones, el dle munod siguiente, se activara*/
                    
                    cmdinicioN2Divi.Enabled = true; 
                    cmdiniciarN3Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 2;
                }
            }
            else // si no es verdadera descuenta 20000 puntos y el juego no sigue hasta que el usuario elija la resp correcta
            {
                cmdresp1N2Divi.BackColor = Color.Red;
                tiempoD2 -= 3;
                lbltimepoN2Divi.Text = Convert.ToString(tiempoD2);
                lblpunteoN2Divi.Text = cargarclselvD2.quitarpuntosN2Divi();
            }
        }

        private void cmdresp2N2Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Division = cargarclselvD2.retornar_listaN2Divi(); // llamo nuevamente la lista de la clase 
            if (Nivel2_Division[1] == cargarclselvD2.retornarC2Divi()) // retorno el valor de la incognita 
            {
                generarLvl2Division();
                conteoD2 = conteoD2 + 1;
                lblconteoN2Divi.Text = Convert.ToString(conteoD2) + " /10 ";
                if (conteoD2 == 10) // si el conteo llega a 10 en este boton el juego parara si es que el usuario no pierde
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2"); /*en dado caso el usuairo terminara en este nivel le saldra un mensaje al usuario 
                                                                              y se hablitiara el boton de inicio del siguiente nivel*/
                   
                    cmdinicioN2Divi.Enabled = true; 
                    cmdiniciarN3Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 2;
                }
            }
            else 
            { // si el usuario tiene una resp falsa pasara lo que esta definido en este else 
                cmdresp2N2Divi.BackColor = Color.Red;
                tiempoD2 -= 3;
                lbltimepoN2Divi.Text = Convert.ToString(tiempoD2);
                lblpunteoN2Divi.Text = cargarclselvD2.quitarpuntosN2Divi();
            }
        }

        private void cmdresp3N2Divi_Click(object sender, EventArgs e)
        {// lo mismo sucede con este boton 
            List<int> Nivel2_Division = cargarclselvD2.retornar_listaN2Divi();
            if (Nivel2_Division[2] == cargarclselvD2.retornarC2Divi())
            {
                generarLvl2Division();
                conteoD2 = conteoD2 + 1;
                lblconteoN2Divi.Text = Convert.ToString(conteoD2) + " /10 ";
                if (conteoD2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2"); /* en caso dado que terminara este nivel en este boton saldra un mensjae y se activara el boton de inicio 
                                                                              del siguiente nivel. */
                    
                    cmdinicioN2Divi.Enabled = true; 
                    cmdiniciarN3Divi.Enabled = true; 
                    TBCDivison.SelectedIndex = 2;
                }
            }
            else
            {
                // en dado caso el usuario tuviera una mala se le quitan 3 segundos y se le descuetan 20000 puntos 
                cmdresp3N2Divi.BackColor = Color.Red;
                tiempoD2 -= 3;
                lbltimepoN2Divi.Text = Convert.ToString(tiempoD2);
                lblpunteoN2Divi.Text = cargarclselvD2.quitarpuntosN2Divi();
            }
        }

        private void cmdresp4N2Divi_Click(object sender, EventArgs e)
        {
            // llamo a la lista de mi clase dvision lvl2 
            // utilizo una condicion en donde si ahi esta la respuesta que pase a la siguiente operación. 
            List<int> Nivel2_Division = cargarclselvD2.retornar_listaN2Divi();
            if (Nivel2_Division[3] == cargarclselvD2.retornarC2Divi())
            {
                generarLvl2Division();
                conteoD2 = conteoD2 + 1;
                lblconteoN2Divi.Text = Convert.ToString(conteoD2) + " /10 ";
                if (conteoD2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2");
                    cmdinicioN2Divi.Enabled = true; 
                    cmdiniciarN3Divi.Enabled = true; 
                    TBCDivison.SelectedIndex = 2;
                }
            }
            else
            {// en dado caso ovtuviera una respuesta mala se le quitan 20000 y 3 segundos 
                cmdresp4N2Divi.BackColor = Color.Red;
                tiempoD2 -= 3;
                lbltimepoN2Divi.Text = Convert.ToString(tiempoD2);
                lblpunteoN2Divi.Text = cargarclselvD2.quitarpuntosN2Divi();
            }
        }

      
        // FIN NIVEL 2 

        // INICO NIVEL 3
        ClassDivision_Niveles cargarlvl3Divi = new ClassDivision_Niveles();
        int conteoDivi3 = 1, tiempoDivi3 = 60, punteomaxDivi3 = 120000;
        private void tabN3Divi_Click(object sender, EventArgs e)
        {
            lblconteoN3Divi.Text = " /10"; // si hace click sobre la tab saldra ese digito pues no lleva operaciones aun. 
        }
        public void devolverLvl3Divi()
        {// llamar los metodos de las clases 
            cargarlvl3Divi.generarlvlDivi3();
            cargarlvl3Divi.Respuesta_LvlDivi3();

            List<string> Nivel3_Divi_Cadena = cargarlvl3Divi.retornar_lista_CadenaN3ivi3();

           lbloperacionN3Divi.Text = "  ?   +   ?   =   " + Convert.ToString(cargarlvl3Divi.retonar_resultadoN3Divi3());

           cmdresp1N3Divi.Text = Nivel3_Divi_Cadena[0].ToString();
           cmdresp1N3Divi.BackColor = Color.Transparent;

           cmdresp2N3Divi.Text = Nivel3_Divi_Cadena[1].ToString();
           cmdresp2N3Divi.BackColor = Color.Transparent;

           cmdresp3N3Divi.Text = Nivel3_Divi_Cadena[2].ToString();
           cmdresp3N3Divi.BackColor = Color.Transparent;

           cmdresp4N3Divi.Text = Nivel3_Divi_Cadena[3].ToString();
           cmdresp4N3Divi.BackColor = Color.Transparent;
            
        }

        private void cmdiniciarN3Divi_Click(object sender, EventArgs e)
        {
            devolverLvl3Divi(); // inio el devolver pues en este metodo estará todo lo que tengo en las clases 

            // habilito los botones a usar en este nivel 
            cmdresp1N3Divi.Enabled = true;
            cmdresp2N3Divi.Enabled = true;
            cmdresp3N3Divi.Enabled = true; 
            cmdresp4N3Divi.Enabled = true;

            timerN3Divi.Start();  // iniciar tiempo 
            lblconteoN3Divi.Text = " 1/10"; // inicia en 1 ya que al darle click empezarán las operaciones 
            lblpunteoN3Divi.Text = Convert.ToString(punteomaxDivi3); 
 
        }
        private void timerN3Divi_Tick(object sender, EventArgs e)
        {
            // obtenga la manera patito de las estrellas para este nivel 
            int puntemin3Divi = 60000, limiinfe1Divi = 0, limeinfe2Divi = 0, A1Divi = 0,limiinfe3Divi = 0, limesupe1Divi = 0, limesupe2Divi = 0, limisupe3Divi = 0;
            // saco los limites de las expresiones a las que se igualan 
            A1Divi = (punteomaxDivi3 - puntemin3Divi) / 3;
            limiinfe1Divi = puntemin3Divi;
            limeinfe2Divi = puntemin3Divi + A1Divi;
            limiinfe3Divi = puntemin3Divi + (2 * A1Divi);
            limesupe1Divi = (puntemin3Divi + A1Divi) - 1;
            limesupe2Divi = ((puntemin3Divi + (2 * A1Divi)) - 1);
            limisupe3Divi = punteomaxDivi3;
            // condiciono c/uno de llos para que me de la estella deseada o bien dependiendo dle puntaje del usuario 
            if ((Convert.ToInt32(lblpunteoN3Divi.Text) >= limiinfe1Divi) && (Convert.ToInt32(lblpunteoN3Divi.Text) <= limesupe1Divi))
            {
                picestreN3Divi.Image = imgliDivi.Images[1];
            }
                      else
                      {
                         picestreN3Divi.Image = imgliDivi.Images[0];
                      }
            if ((Convert.ToInt32(lblpunteoN3Divi.Text) >= limeinfe2Divi) && (Convert.ToInt32(lblpunteoN3Divi.Text) <= limesupe2Divi))
            {
                picestreN3Divi.Image = imgliDivi.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN3Divi.Text) >= limiinfe3Divi) && (Convert.ToInt32(lblpunteoN3Divi.Text) <= limisupe3Divi))
            {
                picestreN3Divi.Image = imgliDivi.Images[3];
            }

            tiempoDivi3--;
            lblpunteoN3Divi.Text = cargarlvl3Divi.quitapunteos_segundosN3Divi3(); 
            if ((tiempoDivi3 >= 0) && (Convert.ToInt32(lblpunteoN3Divi.Text) > 0) && (Convert.ToInt32(lblpunteoN3Divi.Text) >= puntemin3Divi))
            {
                lbltiempoN3Divi.Text = tiempoDivi3.ToString();
            }
                 else
                 {// si no cumple con las condiciones de las estrellas perdera y tendra que iniciar desde el nivel 1 
                         timerN3Divi.Stop();
                         lblpunteoN3Divi.Text = "0";
                         picestreN3Divi.Image = imgliDivi.Images[0];
                          MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_MULTIPLICACION perdiste3M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                this.Hide();
                perdiste3M.ShowDialog();
                this.Close();
                 }
        }
        private void cmdresp1N3Divi_Click(object sender, EventArgs e)
        {// jalo la lista de enteros la cual declare en la clase 
            List<int> Nivel3_Divi_Enteros = cargarlvl3Divi.retornarlistaenterosDivi3();
            // realizo su condición 
            if (Nivel3_Divi_Enteros[0] == cargarlvl3Divi.retonar_resultadoN3Divi3())
            {
                devolverLvl3Divi(); // reinicia las operaciones para generar otros random 
                conteoDivi3 = conteoDivi3 + 1; // el conteo va ir aumentando conforme avanze y tenga correctas las respuestas
                lblconteoN3Divi.Text = Convert.ToString(conteoDivi3) + " /10"; // el maximo conteo al que podra llegar sera 10 

                if (conteoDivi3 == 10)
                {
                    timerN3Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3"); // si pasara de nivel se habilitaran los botones del lvl4 
                    cmdinicioN2Divi.Enabled = true;
                    cmdiniciarN3Divi.Enabled = true;
                    cmdiniciarN1Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 3;
                }
            }
            else
            {// si pierde se le restara puntaje y estrellas 
                cmdresp1N3Divi.BackColor = Color.Red;
                tiempoDivi3 -= 3;
                lbltiempoN3Divi.Text = Convert.ToString(tiempoDivi3);
                lblpunteoN3Divi.Text = cargarlvl3Divi.quitarpuntosN3Divi3();
            }
        }

        private void cmdresp2N3Divi_Click(object sender, EventArgs e)
        {// sucedra lo mismo del boton anterior a diferencia que esta es la respuesta 2 y la otra era la 2 
            List<int> Nivel3_Divi_Enteros = cargarlvl3Divi.retornarlistaenterosDivi3();

            if (Nivel3_Divi_Enteros[1] == cargarlvl3Divi.retonar_resultadoN3Divi3())
            {
                devolverLvl3Divi();
                conteoDivi3 = conteoDivi3 + 1;
                lblconteoN3Divi.Text = Convert.ToString(conteoDivi3) + " /10";

                if (conteoDivi3 == 10)
                {
                    timerN3Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2Divi.Enabled = true;
                    cmdiniciarN3Divi.Enabled = true;
                    cmdiniciarN1Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp2N3Divi.BackColor = Color.Red;
                tiempoDivi3 -= 3;
                lbltiempoN3Divi.Text = Convert.ToString(tiempoDivi3);
                lblpunteoN3Divi.Text = cargarlvl3Divi.quitarpuntosN3Divi3();
            }
        }

        private void cmdresp3N3Divi_Click(object sender, EventArgs e)
        {// sucedera lo mismo que en el boton 1 
            List<int> Nivel3_Divi_Enteros = cargarlvl3Divi.retornarlistaenterosDivi3();

            if (Nivel3_Divi_Enteros[2] == cargarlvl3Divi.retonar_resultadoN3Divi3())
            {
                devolverLvl3Divi();
                conteoDivi3 = conteoDivi3 + 1;
                lblconteoN3Divi.Text = Convert.ToString(conteoDivi3) + " /10";

                if (conteoDivi3 == 10)
                {
                    timerN3Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2Divi.Enabled = true;
                    cmdiniciarN3Divi.Enabled = true;
                    cmdiniciarN1Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp3N3Divi.BackColor = Color.Red;
                tiempoDivi3 -= 3;
                lbltiempoN3Divi.Text = Convert.ToString(tiempoDivi3);
                lblpunteoN3Divi.Text = cargarlvl3Divi.quitarpuntosN3Divi3();
            }
        }

        private void cmdresp4N3Divi_Click(object sender, EventArgs e)
        {// como se ha venido diciendo sucedra lo mismo que en el boton 1 
            List<int> Nivel3_Divi_Enteros = cargarlvl3Divi.retornarlistaenterosDivi3();

            if (Nivel3_Divi_Enteros[3] == cargarlvl3Divi.retonar_resultadoN3Divi3())
            {
                devolverLvl3Divi();
                conteoDivi3 = conteoDivi3 + 1;
                lblconteoN3Divi.Text = Convert.ToString(conteoDivi3) + " /10";

                if (conteoDivi3 == 10)
                {
                    timerN3Divi.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2Divi.Enabled = true;
                    cmdiniciarN3Divi.Enabled = true;
                    cmdiniciarN1Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp4N3Divi.BackColor = Color.Red;
                tiempoDivi3 -= 3;
                lbltiempoN3Divi.Text = Convert.ToString(tiempoDivi3);
                lblpunteoN3Divi.Text = cargarlvl3Divi.quitarpuntosN3Divi3();
            }
        }

        // FIN NIVEL 3 

        // INICIO NIVEL 4 
        ClassDivision_Niveles cargarlvl4Divi = new ClassDivision_Niveles();
        int conteoDivi4 = 1, tiempoDivi4 = 60, punteomaxDivi4 = 130000;
        private void tabN4Divi_Click(object sender, EventArgs e)
        {
            lblconteoN4Divi.Text = " /10"; // en dado caso el usuario hiciera click en la tab este valor es el que aparecera 
        }
        public void llamardatoslvl4C()
        {// llamo las respuestas y el generamiento de nivel de la clase a la forma 
            cargarlvl4Divi.generarlvlDivi4();
            cargarlvl4Divi.Respuesta_LvlDivi4();

            List<string> Nivel4_Divi_Cadena = cargarlvl4Divi.retornar_listaNDivi4_Cadena();  //retorno a lista de las cadena de caracteres*/

            lbloperacionN4Divi.Text = " ¿ Cuál el la División de menor valor ? "; //realizo la pregunta a respnder 

            /* se llama a los bototnes y la posicion que va jugar c/ uno 
             * con respecto al contador de lista de la clase respectiva de este nivel 
             * le pongo color transparente a lahora de iniciar el nivel */

           cmdresp1N4Divi.Text = Nivel4_Divi_Cadena[0].ToString();
           cmdresp1N4Divi.BackColor = Color.Transparent;

           cmdresp2N4Divi.Text = Nivel4_Divi_Cadena[1].ToString();
           cmdresp2N4Divi.BackColor = Color.Transparent;

           cmdresp3N4Divi.Text = Nivel4_Divi_Cadena[2].ToString();
           cmdresp3N4Divi.BackColor = Color.Transparent;

           cmdresp4N4Divi.Text = Nivel4_Divi_Cadena[3].ToString();
           cmdresp4N4Divi.BackColor = Color.Transparent;
        }

        private void cmdinicarN4Divi_Click(object sender, EventArgs e)
        {
            // inicio los valores tanod de las clases como de los botones, punteos, conteo y tiempo 
            llamardatoslvl4C();

            cmdresp1N4Divi.Enabled = true;
            cmdresp2N4Divi.Enabled = true;
            cmdresp3N4Divi.Enabled = true;
            cmdresp4N4Divi.Enabled = true;

            timerN4Divi.Start(); 
            lblconteoN4Divi.Text= " 1/10";
            lblpunteoN4Divi.Text = Convert.ToString(punteomaxDivi4);
        }

        private void timerN4Divi_Tick(object sender, EventArgs e)
        {
            // se declaran variables gloables 
            int punteminDivi_4 = 65000, limiinfeDivi1_4 = 0, limeinfeDivi2_4 = 0, ADivi_4 = 0, limiinfeDivi3_4 = 0, limesupeDivi1_4 = 0, limesupeDivi2_4 = 0, limisupeDivi3_4 = 0;

            ADivi_4 = (punteomaxDivi4 - punteminDivi_4) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDivi1_4 = punteminDivi_4;
            limeinfeDivi2_4 = punteminDivi_4 + ADivi_4;
            limiinfeDivi3_4 = punteminDivi_4 + (2 * ADivi_4);
            //obtengo los limites superiores 
            limesupeDivi1_4 = (punteminDivi_4 + ADivi_4) - 1;
            limesupeDivi2_4 = ((punteminDivi_4 + (2 * ADivi_4)) - 1);
            limisupeDivi3_4 = punteomaxDivi4;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN4Divi.Text) >= limiinfeDivi1_4) && (Convert.ToInt32(lblpunteoN4Divi.Text) <= limesupeDivi1_4))
            {
                picestreN4Divi.Image = imgliDivi.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
                        else
                        {
                            picestreN4Divi.Image = imgliDivi.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
                        }

            if ((Convert.ToInt32(lblpunteoN4Divi.Text) >= limeinfeDivi2_4) && (Convert.ToInt32(lblpunteoN4Divi.Text) <= limesupeDivi2_4))
            {
                picestreN4Divi.Image = imgliDivi.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN4Divi.Text) >= limiinfeDivi3_4) && (Convert.ToInt32(lblpunteoN4Divi.Text) <= limisupeDivi3_4))
            {
                picestreN4Divi.Image = imgliDivi.Images[3];// si el usuario es muy pro obtendra 3 estrellas
            }

            tiempoDivi4--;
            lblpunteoN4Divi.Text = cargarlvl4Divi.quitapunteos_segundosNDivi4();   // le quito los puntos respectivos a sus segundos 

            if ((tiempoDivi4 >= 0) && (Convert.ToInt32(lblpunteoN4Divi.Text) > 0) && (Convert.ToInt32(lblpunteoN4Divi.Text) >= punteminDivi_4)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltimepoN4Divi.Text = tiempoDivi4.ToString();

            }
                    else
                    {
                         // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                         timerN4Divi.Stop(); 
                         lblpunteoN4Divi.Text= "0";
                         picestreN4Divi.Image = imgliDivi.Images[0];
                         MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                         Niveles_DIV_MOD perdiste4DyM = new Niveles_DIV_MOD();
                         this.Hide();
                         perdiste4DyM.ShowDialog();
                         this.Close();
                    }
        }

        private void cmdresp1N4Divi_Click(object sender, EventArgs e)
        {
            // llamo la lista de la clase de lista de enteros 
            List<int> Nivel4_MOD_Enteros = cargarlvl4Divi.retornarlistaenterosDivi4(); 

            if (Nivel4_MOD_Enteros[0] == cargarlvl4Divi.retonar_resultadoNDivi4())
            {
                llamardatoslvl4C(); // se gernerran nuevas variables random 

                conteoDivi4 = conteoDivi4 + 1; // el conteo va aumentando en 1 
                lblconteoN4Divi.Text = Convert.ToString(conteoDivi4) + " /10"; // el conteo tendra un limite de 10 operaciones 

                if (conteoDivi4 == 10) // si el punteo llega a 10 pasa la condcion expuesta 
                {
                    timerN4Divi.Stop(); // se parara el timepo 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4"); // se mostrara un mensaje 
                    cmdinicioN2Divi.Enabled= true; // se habilitan los botones 
                    cmdiniciarN3Divi.Enabled = true;
                    cmdinicarN4Divi.Enabled = true;
                    cmdinicairN5Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 4; // se pasa a la siguiente tab 
                }
            }
            else
            {// se le quitara 20000 puntos por cada mala que el usuario obtenga llegando a un limite de 3 malas para perder 
                cmdresp1N4Divi.BackColor = Color.Red;
                tiempoDivi4 -= 3;
                lbltimepoN4Divi.Text = Convert.ToString(tiempoDivi4);
                lblpunteoN4Divi.Text = cargarlvl4Divi.quitarpuntosNDivi4(); 
            }
        }

        private void cmdresp2N4Divi_Click(object sender, EventArgs e)
        {
            // llamo la lista de la clase de lista de enteros 
            List<int> Nivel4_MOD_Enteros = cargarlvl4Divi.retornarlistaenterosDivi4();

            if (Nivel4_MOD_Enteros[1] == cargarlvl4Divi.retonar_resultadoNDivi4())
            {
                llamardatoslvl4C(); // se gernerran nuevas variables random 

                conteoDivi4 = conteoDivi4 + 1; // el conteo va aumentando en 1 
                lblconteoN4Divi.Text = Convert.ToString(conteoDivi4) + " /10"; // el conteo tendra un limite de 10 operaciones 

                if (conteoDivi4 == 10) // si el punteo llega a 10 pasa la condcion expuesta 
                {
                    timerN4Divi.Stop(); // se parara el timepo 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4"); // se mostrara un mensaje 
                    cmdinicioN2Divi.Enabled = true; // se habilitan los botones 
                    cmdiniciarN3Divi.Enabled = true;
                    cmdinicarN4Divi.Enabled = true;
                    cmdinicairN5Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 4; // se pasa a la siguiente tab 
                }
            }
            else
            {// se le quitara 20000 puntos por cada mala que el usuario obtenga llegando a un limite de 3 malas para perder 
                cmdresp2N4Divi.BackColor = Color.Red;
                tiempoDivi4 -= 3;
                lbltimepoN4Divi.Text = Convert.ToString(tiempoDivi4);
                lblpunteoN4Divi.Text = cargarlvl4Divi.quitarpuntosNDivi4();
            }
        }

        private void cmdresp3N4Divi_Click(object sender, EventArgs e)
        {
            // llamo la lista de la clase de lista de enteros 
            List<int> Nivel4_MOD_Enteros = cargarlvl4Divi.retornarlistaenterosDivi4();

            if (Nivel4_MOD_Enteros[2] == cargarlvl4Divi.retonar_resultadoNDivi4())
            {
                llamardatoslvl4C(); // se gernerran nuevas variables random 

                conteoDivi4 = conteoDivi4 + 1; // el conteo va aumentando en 1 
                lblconteoN4Divi.Text = Convert.ToString(conteoDivi4) + " /10"; // el conteo tendra un limite de 10 operaciones 

                if (conteoDivi4 == 10) // si el punteo llega a 10 pasa la condcion expuesta 
                {
                    timerN4Divi.Stop(); // se parara el timepo 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4"); // se mostrara un mensaje 
                    cmdinicioN2Divi.Enabled = true; // se habilitan los botones 
                    cmdiniciarN3Divi.Enabled = true;
                    cmdinicarN4Divi.Enabled = true;
                    cmdinicairN5Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 4; // se pasa a la siguiente tab 
                }
            }
            else
            {// se le quitara 20000 puntos por cada mala que el usuario obtenga llegando a un limite de 3 malas para perder 
                cmdresp3N4Divi.BackColor = Color.Red;
                tiempoDivi4 -= 3;
                lbltimepoN4Divi.Text = Convert.ToString(tiempoDivi4);
                lblpunteoN4Divi.Text = cargarlvl4Divi.quitarpuntosNDivi4();
            }
        }

        private void cmdresp4N4Divi_Click(object sender, EventArgs e)
        {
            // llamo la lista de la clase de lista de enteros 
            List<int> Nivel4_MOD_Enteros = cargarlvl4Divi.retornarlistaenterosDivi4();

            if (Nivel4_MOD_Enteros[3] == cargarlvl4Divi.retonar_resultadoNDivi4())
            {
                llamardatoslvl4C(); // se gernerran nuevas variables random 

                conteoDivi4 = conteoDivi4 + 1; // el conteo va aumentando en 1 
                lblconteoN4Divi.Text = Convert.ToString(conteoDivi4) + " /10"; // el conteo tendra un limite de 10 operaciones 

                if (conteoDivi4 == 10) // si el punteo llega a 10 pasa la condcion expuesta 
                {
                    timerN4Divi.Stop(); // se parara el timepo 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4"); // se mostrara un mensaje 
                    cmdinicioN2Divi.Enabled = true; // se habilitan los botones 
                    cmdiniciarN3Divi.Enabled = true;
                    cmdinicarN4Divi.Enabled = true;
                    cmdinicairN5Divi.Enabled = true;
                    TBCDivison.SelectedIndex = 4; // se pasa a la siguiente tab 
                }
            }
            else
            {// se le quitara 20000 puntos por cada mala que el usuario obtenga llegando a un limite de 3 malas para perder 
                cmdresp4N4Divi.BackColor = Color.Red;
                tiempoDivi4 -= 3;
                lbltimepoN4Divi.Text = Convert.ToString(tiempoDivi4);
                lblpunteoN4Divi.Text = cargarlvl4Divi.quitarpuntosNDivi4();
            }
        }

        // FIN NIVEL 4 

        // INICIO NIVEL 5 
        ClassDivision_Niveles cargarultimoLvl5Divi = new ClassDivision_Niveles();
        int conteo5Divi = 1, tiempo5Divi = 60, punteomax5Divi = 140000;
        private void tabN1Divi_Click(object sender, EventArgs e)
        {
            lblconteoN5Divi.Text = " /10"; // si hace click en la tab aparecera ese digito 
        }
        public void retonrarLvl5Divi()
        {
            cargarultimoLvl5Divi.generarlvlDivi5();
            cargarultimoLvl5Divi.Respuesta_LvlDivi5(); 

            List<string> Nivel5_Divi_Cadena = cargarultimoLvl5Divi.retornar_listaNDivi5_Cadena();  /*retorno a lista de las cadena de caracteres*/

            lbloperacionN5Divi.Text = " ¿Cual division es la mayor? "; //realizar la pregunta a responder por el usuario 

            /*le pongo color transparente a lahora de iniciar el nivel y las posiciones que juegan de c/uno de ellos */

            cmdrespN5Divi.Text = Nivel5_Divi_Cadena[0].ToString();
            cmdrespN5Divi.BackColor = Color.Transparent;

            cmdresp2N5Divi.Text = Nivel5_Divi_Cadena[1].ToString();
            cmdresp2N5Divi.BackColor = Color.Transparent;

            cmdresp3N5Divi.Text = Nivel5_Divi_Cadena[2].ToString();
            cmdresp3N5Divi.BackColor = Color.Transparent;

            cmdresp4N5Divi.Text = Nivel5_Divi_Cadena[3].ToString();
            cmdresp4N5Divi.BackColor = Color.Transparent;
        }
        private void cmdinicairN5Divi_Click(object sender, EventArgs e)
        {
            retonrarLvl5Divi(); // llamo el metodo donde devolvi mis clases 
            //habilito los botones a utilizar 
            cmdrespN5Divi.Enabled = true;
            cmdresp2N5Divi.Enabled = true;
            cmdresp3N5Divi.Enabled = true;
            cmdresp4N5Divi.Enabled = true;
            cmdinicairN5Divi.Enabled = false; 
            // inicio el tiempo, el conteo y asigno a la labldel punteo su valor 
            timerN5Divi.Start();
            lblconteoN5Divi.Text = "1/10";
            lblpunteoN5Divi.Text = Convert.ToString(punteomax5Divi); 
        }

        private void timerN5Divi_Tick(object sender, EventArgs e)
        {
            int punteminDivi2_5 = 70000, limiinfeDivi1_5 = 0, limeinfeDivi2_5 = 0, ADivi2_5 = 0, limiinfeDivi3_5 = 0, limesupeDivi1_5 = 0, limesupeDivi2_5 = 0, limisupeDivi3_5 = 0;

            ADivi2_5 = (punteomax5Divi - punteminDivi2_5) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDivi1_5 = punteminDivi2_5;
            limeinfeDivi2_5 = punteminDivi2_5 + ADivi2_5;
            limiinfeDivi3_5 = punteminDivi2_5 + (2 * ADivi2_5);
            //obtengo los limites superiores 
            limesupeDivi1_5 = (punteminDivi2_5 + ADivi2_5) - 1;
            limesupeDivi2_5 = ((punteminDivi2_5 + (2 * ADivi2_5)) - 1);
            limisupeDivi3_5 = punteomax5Divi;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN5Divi.Text) >= limiinfeDivi1_5) && (Convert.ToInt32(lblpunteoN5Divi.Text) <= limesupeDivi1_5))
            {
                picestreN5Divi.Image = imgliDivi.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
                 else
                {
                    picestreN5Divi.Image = imgliDivi.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
                }
            if ((Convert.ToInt32(lblpunteoN5Divi.Text) >= limeinfeDivi2_5) && (Convert.ToInt32(lblpunteoN5Divi.Text) <= limesupeDivi2_5))
            {
                picestreN5Divi.Image = imgliDivi.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN5Divi.Text) >= limiinfeDivi3_5) && (Convert.ToInt32(lblpunteoN5Divi.Text) <= limisupeDivi3_5))
            {
                picestreN5Divi.Image = imgliDivi.Images[3];// si el usuario es muy pro obtendra 3 estrellas
            }

            tiempo5Divi--;
            lblpunteoN5Divi.Text = cargarultimoLvl5Divi.quitapunteos_segundosNDivi5();  // le quito los puntos respectivos a sus segundos 

            if ((tiempo5Divi >= 0) && (Convert.ToInt32(lblpunteoN5Divi.Text) > 0) && (Convert.ToInt32(lblpunteoN5Divi.Text) >= punteminDivi2_5)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN5Divi.Text = tiempo5Divi.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                timerN5Divi.Stop(); 
                lblpunteoN5Divi.Text = "0";
                picestreN5Divi.Image = imgliDivi.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_DIVISION perdiste5Divi= new Niveles_DIVISION();
                this.Hide();
                perdiste5Divi.ShowDialog();
                this.Close();
            }
        }

        private void cmdrespN5Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Divi_Enteros = cargarultimoLvl5Divi.retornarlistaenterosDivi5();  // llamo la lista de enteros

            if (Nivel5_Divi_Enteros[0] == cargarultimoLvl5Divi.retonar_resultadoNDivi5()) // condiciono el resultado de la clase 
            {
                retonrarLvl5Divi(); 
                conteo5Divi = conteo5Divi + 1;
                lblconteoN5Divi.Text = Convert.ToString(conteo5Divi) + " /10"; // cada vez que vaya teniendo una respuesta correcta el conteo va ir aumentando en 1 

                if (conteo5Divi == 10)
                {
                    timerN5Divi.Stop(); // si en este boton terminara el usuario el timepo parara y mostrara un mensaje 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccionDiv = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccionDiv.Show();
                }
            }

            else
            {// en caso dado el usuario tuviera malas, se le marcara como rojo y disminuye su punteo 
                cmdrespN5Divi.BackColor = Color.Red;
                tiempo5Divi -= 3;
                lbltiempoN5Divi.Text = Convert.ToString(tiempo5Divi);
                lblpunteoN5Divi.Text = cargarultimoLvl5Divi.quitarpuntosNDivi5();
            }
        }

        private void cmdresp2N5Divi_Click_1(object sender, EventArgs e)
        {
            List<int> Nivel5_Divi_Enteros = cargarultimoLvl5Divi.retornarlistaenterosDivi5();  // llamo la lista de enteros

            if (Nivel5_Divi_Enteros[0] == cargarultimoLvl5Divi.retonar_resultadoNDivi5()) // condiciono el resultado de la clase 
            {
                retonrarLvl5Divi();
                conteo5Divi = conteo5Divi + 1;
                lblconteoN5Divi.Text = Convert.ToString(conteo5Divi) + " /10"; // cada vez que vaya teniendo una respuesta correcta el conteo va ir aumentando en 1 

                if (conteo5Divi == 10)
                {
                    timerN5Divi.Stop(); // si en este boton terminara el usuario el timepo parara y mostrara un mensaje 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccionDi = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccionDi.Show();
                }
            }

            else
            {// en caso dado el usuario tuviera malas, se le marcara como rojo y disminuye su punteo 
                cmdresp2N5Divi.BackColor = Color.Red;
                tiempo5Divi -= 3;
                lbltiempoN5Divi.Text = Convert.ToString(tiempo5Divi);
                lblpunteoN5Divi.Text = cargarultimoLvl5Divi.quitarpuntosNDivi5();
            }
        }

        private void cmdresp3N5Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Divi_Enteros = cargarultimoLvl5Divi.retornarlistaenterosDivi5();  // llamo la lista de enteros

            if (Nivel5_Divi_Enteros[0] == cargarultimoLvl5Divi.retonar_resultadoNDivi5()) // condiciono el resultado de la clase 
            {
                retonrarLvl5Divi();
                conteo5Divi = conteo5Divi + 1;
                lblconteoN5Divi.Text = Convert.ToString(conteo5Divi) + " /10"; // cada vez que vaya teniendo una respuesta correcta el conteo va ir aumentando en 1 

                if (conteo5Divi == 10)
                {
                    timerN5Divi.Stop(); // si en este boton terminara el usuario el timepo parara y mostrara un mensaje 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccionD = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccionD.Show();
                }
            }

            else
            {// en caso dado el usuario tuviera malas, se le marcara como rojo y disminuye su punteo 
                cmdresp3N5Divi.BackColor = Color.Red;
                tiempo5Divi -= 3;
                lbltiempoN5Divi.Text = Convert.ToString(tiempo5Divi);
                lblpunteoN5Divi.Text = cargarultimoLvl5Divi.quitarpuntosNDivi5();
            }
        }
        
    private void cmdresp4N5Divi_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Divi_Enteros = cargarultimoLvl5Divi.retornarlistaenterosDivi5();  // llamo la lista de enteros

            if (Nivel5_Divi_Enteros[0] == cargarultimoLvl5Divi.retonar_resultadoNDivi5()) // condiciono el resultado de la clase 
            {
                retonrarLvl5Divi(); // se genera nuevo random desde el metodo que llama las clases 
                conteo5Divi = conteo5Divi + 1;
                lblconteoN5Divi.Text = Convert.ToString(conteo5Divi) + " /10"; // cada vez que vaya teniendo una respuesta correcta el conteo va ir aumentando en 1 

                if (conteo5Divi == 10)
                {
                    timerN5Divi.Stop(); // si en este boton terminara el usuario el timepo parara y mostrara un mensaje 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccionD = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccionD.Show();
                }
            }

            else
            {// en caso dado el usuario tuviera malas, se le marcara como rojo y disminuye su punteo 
                cmdresp4N5Divi.BackColor = Color.Red;
                tiempo5Divi -= 3;
                lbltiempoN5Divi.Text = Convert.ToString(tiempo5Divi);
                lblpunteoN5Divi.Text = cargarultimoLvl5Divi.quitarpuntosNDivi5();
            }
        }
    }
}
        