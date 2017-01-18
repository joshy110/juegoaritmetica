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
    public partial class Niveles_RESTA : Form
    {
        public Niveles_RESTA()
        {
            InitializeComponent();
        }
        ClassResta_Niveles cargarclaseN1R = new ClassResta_Niveles();
        int conteoR1 = 1, tiempoR1 = 60, punteomaxR1 = 100000;
        private void tabNivel1R_Click(object sender, EventArgs e)
        {
            lblconteoN1R.Text = Convert.ToString(conteoR1) + " /10 ";
        }
        public void iniciarlvl1R()
        {
            cargarclaseN1R.generarlvlR1();
            cargarclaseN1R.Respuesta_LvR1();
            List<int> Nivel1_Resta = cargarclaseN1R.retornar_listaN1R();

            lbloperacionN1R.Text = Convert.ToString(cargarclaseN1R.retonar_numero1N1R()) + " - "
                + Convert.ToString(cargarclaseN1R.retonar_numero2N1R()) + " = ? ";

            cmdresp1N1R.Text = Nivel1_Resta[0].ToString();
            cmdresp1N1R.BackColor = Color.Transparent;

            cmdresp2N1R.Text = Nivel1_Resta[1].ToString();
            cmdresp2N1R.BackColor = Color.Transparent;

            cmdresp3N1R.Text = Nivel1_Resta[2].ToString();
            cmdresp3N1R.BackColor = Color.Transparent;

            cmdresp4N1R.Text = Nivel1_Resta[3].ToString();
            cmdresp4N1R.BackColor = Color.Transparent;

        }

        private void cmdiniciarN1R_Click(object sender, EventArgs e)
        {
            iniciarlvl1R();
            cmdresp1N1R.Enabled = true;
            cmdresp2N1R.Enabled = true;
            cmdresp3N1R.Enabled = true;
            cmdresp4N1R.Enabled = true;
            timerN1R.Start();
            lblpunteoN1R.Text = Convert.ToString(punteomaxR1);
            lblconteoN1R.Text = " 1/10 ";
        }

        private void timerN1R_Tick(object sender, EventArgs e)
        {
            int puntemin1R1 = 50000, limiinfe1R1 = 0, limeinfe2R1 = 0, A1R1 = 0,
              limiinfe3R1 = 0, limesupe1R1 = 0, limesupe2R1 = 0, limisupe3R1 = 0;

            A1R1 = (punteomaxR1 - puntemin1R1) / 3;

            limiinfe1R1 = puntemin1R1;
            limeinfe2R1 = puntemin1R1 + A1R1;
            limiinfe3R1 = puntemin1R1 + (2 * A1R1);
            limesupe1R1 = (puntemin1R1 + A1R1) - 1;
            limesupe2R1 = ((puntemin1R1 + (2 * A1R1)) - 1);
            limisupe3R1 = punteomaxR1;

            tiempoR1--;
            lblpunteoN1R.Text = cargarclaseN1R.punteosN1R();

            if ((Convert.ToInt32(lblpunteoN1R.Text) >= limiinfe1R1) && (Convert.ToInt32(lblpunteoN1R.Text) <= limesupe1R1))
            {
                picestreR1.Image = imglisR.Images[1]; 
            }
            else
            {
                picestreR1.Image = imglisR.Images[0]; 
            }
            if ((Convert.ToInt32(lblpunteoN1R.Text) >= limeinfe2R1) && (Convert.ToInt32(lblpunteoN1R.Text) <= limesupe2R1))
            {
                picestreR1.Image = imglisR.Images[2]; 
            }
            if ((Convert.ToInt32(lblpunteoN1R.Text) >= limiinfe3R1) && (Convert.ToInt32(lblpunteoN1R.Text) <= limisupe3R1))
            {
                picestreR1.Image = imglisR.Images[3]; 
            }

            if ((tiempoR1 >= 0) && (Convert.ToInt32(lblpunteoN1R.Text) > 0) && (Convert.ToInt32(lblpunteoN1R.Text) >= puntemin1R1))
            {
                lbltiempoN1R.Text = tiempoR1.ToString();
            }
            else
            {
                timerN1R.Stop(); 
                lblpunteoN1R.Text = "0"; // el punteo baja a 0 
                picestreR1.Image = imglisR.Images[0]; // no se muestra imagen 
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_RESTA perdiste1R = new Niveles_RESTA(); // reinicir la tab 
                this.Hide(); 
                perdiste1R.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N1R_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Resta = cargarclaseN1R.retornar_listaN1R();
            if (Nivel1_Resta[0] == cargarclaseN1R.retonar_resultadoN1R())
            {
                iniciarlvl1R();
                cmdiniciarN1R.Enabled = false;
                conteoR1 = conteoR1 + 1;
                lblconteoN1R.Text = Convert.ToString(conteoR1) + " /10";
                if (conteoR1 == 10)
                {
                    timerN1R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true; 
                    TCResta.SelectedIndex = 1; 

                }
            }
            else
            {
                cmdresp1N1R.BackColor = Color.Red;
                tiempoR1 -= 3;
                lbltiempoN1R.Text = Convert.ToString(tiempoR1);
                lblpunteoN1R.Text = cargarclaseN1R.quitarpuntosN1R();
            }
        }

        private void cmdresp2N1R_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Resta = cargarclaseN1R.retornar_listaN1R();
            if (Nivel1_Resta[1] == cargarclaseN1R.retonar_resultadoN1R())
            {
                iniciarlvl1R();
                cmdiniciarN1R.Enabled = false;
                conteoR1 = conteoR1 + 1;
                lblconteoN1R.Text = Convert.ToString(conteoR1) + " /10";
                if (conteoR1 == 10)
                {
                    timerN1R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true; 
                    TCResta.SelectedIndex = 1; 

                }
            }
            else
            {
                cmdresp2N1R.BackColor = Color.Red;
                tiempoR1 -= 3;
                lbltiempoN1R.Text = Convert.ToString(tiempoR1);
                lblpunteoN1R.Text = cargarclaseN1R.quitarpuntosN1R();
            }
        }

        private void cmdresp3N1R_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Resta = cargarclaseN1R.retornar_listaN1R();
            if (Nivel1_Resta[2] == cargarclaseN1R.retonar_resultadoN1R())
            {
                iniciarlvl1R();
                cmdiniciarN1R.Enabled = false;
                conteoR1 = conteoR1 + 1;
                lblconteoN1R.Text = Convert.ToString(conteoR1) + " /10";
                if (conteoR1 == 10)
                {
                    timerN1R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true; 
                    TCResta.SelectedIndex = 1; 

                }
            }
            else
            {
                cmdresp3N1R.BackColor = Color.Red;
                tiempoR1 -= 3;
                lbltiempoN1R.Text = Convert.ToString(tiempoR1);
                lblpunteoN1R.Text = cargarclaseN1R.quitarpuntosN1R();
            }
        }

        private void cmdresp4N1R_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Resta = cargarclaseN1R.retornar_listaN1R();
            if (Nivel1_Resta[3] == cargarclaseN1R.retonar_resultadoN1R())
            {
                iniciarlvl1R();
                cmdiniciarN1R.Enabled = false;
                conteoR1 = conteoR1 + 1;
                lblconteoN1R.Text = Convert.ToString(conteoR1) + " /10";
                if (conteoR1 == 10)
                {
                    timerN1R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true; 
                    TCResta.SelectedIndex = 1; 

                }
            }
            else
            {
                cmdresp4N1R.BackColor = Color.Red;
                tiempoR1 -= 3;
                lbltiempoN1R.Text = Convert.ToString(tiempoR1);
                lblpunteoN1R.Text = cargarclaseN1R.quitarpuntosN1R();
            }
        }
        //FIN NIVEL 1__________________________________________________________________________________________________

        /*INICIO NIVEL 2*/

        ClassResta_Niveles cargarNivel2 = new ClassResta_Niveles();
        int conteoR2 = 1, tiempoR2 = 60, punteomaxR2 = 110000;
        private void tabNivel2R_Click(object sender, EventArgs e)
        {
            lblconteoN2R.Text = " 10"; 
        }
        public void iniciarlvl2R()
        {
            cargarNivel2.generarlvlR2();
            cargarNivel2.Respuesta_Lv2();
            List<int> Nivel2_Resta = cargarNivel2.retornar_listaN2R();

            lbloperacionN2R.Text = Convert.ToString(cargarNivel2.retonar_numero1N2R()) + "   -    ?    =  "
                + Convert.ToString(cargarNivel2.retonar_resultadoN2R());

            cmdresp1N2R.Text = Nivel2_Resta[0].ToString();
            cmdresp1N2R.BackColor = Color.Transparent;

            cmdresp2N2R.Text = Nivel2_Resta[1].ToString();
            cmdresp2N2R.BackColor = Color.Transparent;

            cmdresp3N2R.Text = Nivel2_Resta[2].ToString();
            cmdresp3N2R.BackColor = Color.Transparent;

            cmdresp4N2R.Text = Nivel2_Resta[3].ToString();
            cmdresp4N2R.BackColor = Color.Transparent;

        }

        private void cmdiniciarN2R_Click(object sender, EventArgs e)
        {
            iniciarlvl2R();
            cmdresp1N2R.Enabled = true;
            cmdresp2N2R.Enabled = true;
            cmdresp3N2R.Enabled = true;
            cmdresp4N2R.Enabled = true;
            timerN2R.Start();
            lblpunteoN2R.Text = Convert.ToString(punteomaxR2);
            lblconteoN2R.Text = " 1/10 "; 
        }
        private void timerN2R_Tick(object sender, EventArgs e)
        {

            int puntemin1R2 = 55000, limiinfe1R2 = 0, limeinfe2R2 = 0, A1R2 = 0,
              limiinfe3R2 = 0, limesupe1R2 = 0, limesupe2R2 = 0, limisupe3R2 = 0;

            A1R2 = (punteomaxR2 - puntemin1R2) / 3;

            limiinfe1R2 = puntemin1R2;
            limeinfe2R2 = puntemin1R2 + A1R2;
            limiinfe3R2 = puntemin1R2 + (2 * A1R2);
            limesupe1R2 = (puntemin1R2 + A1R2) - 1;
            limesupe2R2 = ((puntemin1R2 + (2 * A1R2)) - 1);
            limisupe3R2 = punteomaxR2;

            if ((Convert.ToInt32(lblpunteoN2R.Text) >= limiinfe1R2) && (Convert.ToInt32(lblpunteoN2R.Text) <= limesupe1R2))
            {
                picestreR2.Image = imglisR.Images[1];
            }
            else
            {
                picestreR2.Image = imglisR.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN2R.Text) >= limeinfe2R2) && (Convert.ToInt32(lblpunteoN2R.Text) <= limesupe2R2))
            {
                picestreR2.Image = imglisR.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN2R.Text) >= limiinfe3R2) && (Convert.ToInt32(lblpunteoN2R.Text) <= limisupe3R2))
            {
                picestreR2.Image = imglisR.Images[3];
            }

            tiempoR2--;
            lblpunteoN2R.Text = cargarNivel2.quitapunteos_segundosN2R();
            if ((tiempoR2 >= 0) && (Convert.ToInt32(lblpunteoN2R.Text) > 0) && (Convert.ToInt32(lblpunteoN2R.Text) >= puntemin1R2))
            {
                lbltimepoN2R.Text = tiempoR2.ToString();
            }
            else
            {
                timerN2R.Stop(); 
                lblpunteoN2R.Text = "0";
                picestreR2.Image = imglisR.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_RESTA perdiste2R = new Niveles_RESTA(); // reinicir la tab 
                this.Hide();
                perdiste2R.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N2R_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Resta = cargarNivel2.retornar_listaN2R();
            if (Nivel2_Resta[0] == cargarNivel2.retonar_resucN2R())
            {
                iniciarlvl2R();
                cmdiniciarN2R.Enabled = false;
                conteoR2 = conteoR2 + 1;
                lblconteoN2R.Text = Convert.ToString(conteoR2) + " /10";
                if (conteoR2 == 10)
                {
                    timerN2R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true; 
                    TCResta.SelectedIndex = 2; 

                }
            }
            else
            {
                cmdresp1N2R.BackColor = Color.Red;
                tiempoR2 -= 3;
                lbltimepoN2R.Text = Convert.ToString(tiempoR2);
                lblpunteoN2R.Text = cargarNivel2.quitarpuntosN2R();
            }
        }

        private void cmdresp2N2R_Click(object sender, EventArgs e)
        {

            List<int> Nivel2_Resta = cargarNivel2.retornar_listaN2R();
            if (Nivel2_Resta[1] == cargarNivel2.retonar_resucN2R())
            {
                iniciarlvl2R();
                cmdiniciarN2R.Enabled = false;
                conteoR2 = conteoR2 + 1;
                lblconteoN2R.Text = Convert.ToString(conteoR2) + " /10";
                if (conteoR2 == 10)
                {
                    timerN2R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true; 
                    TCResta.SelectedIndex = 2;

                }
            }
            else
            {
                cmdresp2N2R.BackColor = Color.Red;
                tiempoR2 -= 3;
                lbltimepoN2R.Text = Convert.ToString(tiempoR2);
                lblpunteoN2R.Text = cargarNivel2.quitarpuntosN2R();
            }
        }

        private void cmdresp3N2R_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Resta = cargarNivel2.retornar_listaN2R();
            if (Nivel2_Resta[2] == cargarNivel2.retonar_resucN2R())
            {
                iniciarlvl2R();
                cmdiniciarN2R.Enabled = false;
                conteoR2 = conteoR2 + 1;
                lblconteoN2R.Text = Convert.ToString(conteoR2) + " /10";
                if (conteoR2 == 10)
                {
                    timerN2R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true; 
                    TCResta.SelectedIndex = 2;

                }
            }
            else
            {
                cmdresp3N2R.BackColor = Color.Red;
                tiempoR2 -= 3;
                lbltimepoN2R.Text = Convert.ToString(tiempoR2);
                lblpunteoN2R.Text = cargarNivel2.quitarpuntosN2R();
            }
        }

        private void cmdresp4N2R_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Resta = cargarNivel2.retornar_listaN2R();
            if (Nivel2_Resta[3] == cargarNivel2.retonar_resucN2R())
            {
                iniciarlvl2R();
                cmdiniciarN2R.Enabled = false;
                conteoR2 = conteoR2 + 1;
                lblconteoN2R.Text = Convert.ToString(conteoR2) + " /10";
                if (conteoR2 == 10)
                {
                    timerN2R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 1_Resta");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true; 
                    TCResta.SelectedIndex = 2;

                }
            }
            else
            {
                cmdresp4N2R.BackColor = Color.Red;
                tiempoR2 -= 3;
                lbltimepoN2R.Text = Convert.ToString(tiempoR2);
                lblpunteoN2R.Text = cargarNivel2.quitarpuntosN2R();
            }
        }

                            // FIN NIVEL 2 ________________________________________________________________________

                /*INICIO NIVEL 3*/

        ClassResta_Niveles cargarLvl3Res = new ClassResta_Niveles();
        int conteoR3 = 1, tiempoR3 = 60, punteomaxR3 = 120000;
        private void tabNivel3R_Click(object sender, EventArgs e)
        {
            lblconteoN3R.Text = " /10 "; 
        }
        private void iniciarLvl3R()
        {
            cargarLvl3Res.generarlvlR3();
            cargarLvl3Res.Respuesta_LvlR3();
            List<string> Nivel3_Resta_cadena = cargarLvl3Res.retornar_lista_cadena_N3R(); /*solo devolvemos los valores de la cadena */

            lbloperacionN3R.Text = " ?   -   ?  =  " + Convert.ToString(cargarLvl3Res.retonar_resultadoN3R());

            cmdresp1N3R.Text = Nivel3_Resta_cadena[0].ToString();
            cmdresp1N3R.BackColor = Color.Transparent;

            cmdresp2N3R.Text = Nivel3_Resta_cadena[1].ToString();
            cmdresp2N3R.BackColor = Color.Transparent;

            cmdresp3N3R.Text = Nivel3_Resta_cadena[2].ToString();
            cmdresp3N3R.BackColor = Color.Transparent;

            cmdresp4N3R.Text = Nivel3_Resta_cadena[3].ToString();
            cmdresp4N3R.BackColor = Color.Transparent;
        }

        private void cmdinicioN3R_Click(object sender, EventArgs e)
        {
            iniciarLvl3R();
            cmdresp1N3R.Enabled = true;
            cmdresp2N3R.Enabled = true;
            cmdresp3N3R.Enabled = true;
            cmdresp4N3R.Enabled = true;
            timerN3R.Start();
            lblpunteosN3R.Text = " 1/10 ";
            lblpunteosN3R.Text = Convert.ToString(punteomaxR3); 
        }

        private void timerN3R_Tick(object sender, EventArgs e)
        {
            int puntemin1R3 = 60000, limiinfe1R3 = 0, limeinfe2R3 = 0, A1R3 = 0,
              limiinfe3R3 = 0, limesupe1R3 = 0, limesupe2R3 = 0, limisupe3R3 = 0;

            A1R3 = (punteomaxR3 - puntemin1R3) / 3;

            limiinfe1R3 = puntemin1R3;
            limeinfe2R3 = puntemin1R3 + A1R3;
            limiinfe3R3 = puntemin1R3 + (2 * A1R3);
            limesupe1R3 = (puntemin1R3 + A1R3) - 1;
            limesupe2R3 = ((puntemin1R3 + (2 * A1R3)) - 1);
            limisupe3R3 = punteomaxR3;

            if ((Convert.ToInt32(lblpunteosN3R.Text) >= limiinfe1R3) && (Convert.ToInt32(lblpunteosN3R.Text) <= limesupe1R3))
            {
                picestreR3.Image = imglisR.Images[1];
            }
            else
            {
                picestreR3.Image = imglisR.Images[0];
            }
            if ((Convert.ToInt32(lblpunteosN3R.Text) >= limeinfe2R3) && (Convert.ToInt32(lblpunteosN3R.Text) <= limesupe2R3))
            {
                picestreR3.Image = imglisR.Images[2];
            }
            if ((Convert.ToInt32(lblpunteosN3R.Text) >= limiinfe3R3) && (Convert.ToInt32(lblpunteosN3R.Text) <= limisupe3R3))
            {
                picestreR3.Image = imglisR.Images[3];
            }

            tiempoR3--;
            lblpunteosN3R.Text = cargarLvl3Res.quitapunteos_segundosN3R();
            if ((tiempoR3 >= 0) && (Convert.ToInt32(lblpunteosN3R.Text) > 0) && (Convert.ToInt32(lblpunteosN3R.Text) >= puntemin1R3))
            {
                lbltiempoN3R.Text = tiempoR3.ToString();
            }
            else
            {
                timerN3R.Stop(); 
                lblpunteoN2R.Text = "0";
                picestreR3.Image = imglisR.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_RESTA perdiste3R = new Niveles_RESTA(); // reinicir la tab 
                this.Hide();
                perdiste3R.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N3R_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Resta_Enteros = cargarLvl3Res.retornarlistaenterosResta(); /*aqui devolvemos la lista de enteros creada en la clase de la resta */
            if (Nivel3_Resta_Enteros[0] == cargarLvl3Res.retonar_resultadoN3R())
            {
                iniciarLvl3R();
                cmdinicioN3R.Enabled = false;
                conteoR3 = conteoR3 + 1;
                lblconteoN3R.Text = Convert.ToString(conteoR3) + " /10";
                if (conteoR3 == 10)
                {
                    timerN3R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true; 
                    TCResta.SelectedIndex = 3; 
                }
            }
            else
            {
                cmdresp1N3R.BackColor = Color.Red;
                tiempoR3 -= 3;
                lbltiempoN3R.Text = Convert.ToString(tiempoR3);
                lblpunteosN3R.Text = cargarLvl3Res.quitarpuntosN3R();
            }
        }

        private void cmdresp2N3R_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Resta_Enteros = cargarLvl3Res.retornarlistaenterosResta(); /*aqui devolvemos la lista de enteros creada en la clase de la resta */
            if (Nivel3_Resta_Enteros[1] == cargarLvl3Res.retonar_resultadoN3R())
            {
                iniciarLvl3R();
                cmdinicioN3R.Enabled = false;
                conteoR3 = conteoR3 + 1;
                lblconteoN3R.Text = Convert.ToString(conteoR3) + " /10";
                if (conteoR3 == 10)
                {
                    timerN3R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true; 
                    TCResta.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp2N3R.BackColor = Color.Red;
                tiempoR3 -= 3;
                lbltiempoN3R.Text = Convert.ToString(tiempoR3);
                lblpunteosN3R.Text = cargarLvl3Res.quitarpuntosN3R();
            }
        }

        private void cmdresp3N3R_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Resta_Enteros = cargarLvl3Res.retornarlistaenterosResta(); /*aqui devolvemos la lista de enteros creada en la clase de la resta */
            if (Nivel3_Resta_Enteros[2] == cargarLvl3Res.retonar_resultadoN3R())
            {
                iniciarLvl3R();
                cmdinicioN3R.Enabled = false;
                conteoR3 = conteoR3 + 1;
                lblconteoN3R.Text = Convert.ToString(conteoR3) + " /10";
                if (conteoR3 == 10)
                {
                    timerN3R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true; 
                    TCResta.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp3N3R.BackColor = Color.Red;
                tiempoR3 -= 3;
                lbltiempoN3R.Text = Convert.ToString(tiempoR3);
                lblpunteosN3R.Text = cargarLvl3Res.quitarpuntosN3R();
            }
        }

        private void cmdresp4N3R_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Resta_Enteros = cargarLvl3Res.retornarlistaenterosResta(); /*aqui devolvemos la lista de enteros creada en la clase de la resta */
            if (Nivel3_Resta_Enteros[3] == cargarLvl3Res.retonar_resultadoN3R())
            {
                iniciarLvl3R();
                cmdinicioN3R.Enabled = false;
                conteoR3 = conteoR3 + 1;
                lblconteoN3R.Text = Convert.ToString(conteoR3) + " /10";
                if (conteoR3 == 10)
                {
                    timerN3R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true; 
                   TCResta.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp4N3R.BackColor = Color.Red;
                tiempoR3 -= 3;
                lbltiempoN3R.Text = Convert.ToString(tiempoR3);
                lblpunteosN3R.Text = cargarLvl3Res.quitarpuntosN3R();
            }
        }

        
                                //FIN NIVEL 3______________________________________________________________________________________

                    /*INICIO NIVEL 4*/

        ClassResta_Niveles llamarclalvR4 = new ClassResta_Niveles(); //instanciamos la clase de forma global para ese nivel 
        int conteo4R = 1, tiempo4R = 60, punteomax4R = 130000;
        private void tabNivel4R_Click(object sender, EventArgs e)
        {
            lblconteoN4R.Text = " /10"; /*Se empezara el nivel con el conteo en nada, es decir, a la hora de cargar tab de este nivel */
        }
        private void comenzarlvl4()
        {
        // se llama los métodos de las clases de la resta 
            llamarclalvR4.generarlvlR4();
            llamarclalvR4.Respuesta_LvlR4();

            List<string> Nivel4_Resta_Cadenacr = llamarclalvR4.retornar_listaNR4(); /*devuelvo la lista de cadena de caracteres*/

            lbloperacionN4R.Text = "¿Cuál es la resta menor?"; /*se formula la pregunta dle nivel */

            /*luego colocamos los botones en forma de string y devolvemos la lista y la posición de c/una de ellos */
            cmdresp1N4R.Text = Nivel4_Resta_Cadenacr[0].ToString();
            cmdresp1N4R.BackColor = Color.Transparent;

            cmdresp2N4R.Text = Nivel4_Resta_Cadenacr[1].ToString();
            cmdresp2N4R.BackColor = Color.Transparent;

            cmdresp3N4R.Text = Nivel4_Resta_Cadenacr[2].ToString();
            cmdresp3N4R.BackColor = Color.Transparent;

            cmdresp4N4R.Text = Nivel4_Resta_Cadenacr[3].ToString();
            cmdresp4N4R.BackColor = Color.Transparent; 

        }

        private void cmdiniciarN4R_Click(object sender, EventArgs e)
        {
            // se llama al método de la forma 
            comenzarlvl4(); 

            // Luego habilitamos los botones del juego 

             cmdresp1N4R.Enabled = true; 
             cmdresp2N4R.Enabled = true; 
             cmdresp3N4R.Enabled = true;
             cmdresp4N4R.Enabled = true;
             timerN4R.Start(); 
             lblconteoN4R.Text = " 1/10";
             lblpunteoN4R.Text = Convert.ToString(punteomax4R); 
        }

        private void timerN4R_Tick(object sender, EventArgs e)
        {
            int puntemin1R4 = 65000, limiinfe1R4 = 0, limeinfe2R4 = 0, A1R4 = 0,
             limiinfe3R4 = 0, limesupe1R4 = 0, limesupe2R4 = 0, limisupe3R4 = 0;

            A1R4 = (punteomax4R - puntemin1R4) / 3;

            limiinfe1R4 = puntemin1R4;
            limeinfe2R4 = puntemin1R4 + A1R4;
            limiinfe3R4 = puntemin1R4 + (2 * A1R4);
            limesupe1R4 = (puntemin1R4 + A1R4) - 1;
            limesupe2R4 = ((puntemin1R4 + (2 * A1R4)) - 1);
            limisupe3R4 = punteomax4R;

            if ((Convert.ToInt32(lblpunteoN4R.Text) >= limiinfe1R4) && (Convert.ToInt32(lblpunteoN4R.Text) <= limesupe1R4))
            {
                picestreR4.Image = imglisR.Images[1];
            }
            else
            {
                picestreR4.Image = imglisR.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN4R.Text) >= limeinfe2R4) && (Convert.ToInt32(lblpunteoN4R.Text) <= limesupe2R4))
            {
                picestreR4.Image = imglisR.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN4R.Text) >= limiinfe3R4) && (Convert.ToInt32(lblpunteoN4R.Text) <= limisupe3R4))
            {
                picestreR4.Image = imglisR.Images[3];
            }
            tiempo4R--;
            lblpunteoN4R.Text = llamarclalvR4.quitapunteos_segundosNR4();
            if ((tiempo4R >= 0) && (Convert.ToInt32(lblpunteoN4R.Text) > 0) && (Convert.ToInt32(lblpunteoN4R.Text) >= puntemin1R4))
            {
                lbltiempoN4R.Text= tiempoR3.ToString();
            }
            else
            {
                timerN4R.Stop(); 
                lblpunteoN4R.Text = "0";
                picestreR4.Image = imglisR.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_RESTA perdiste4R = new Niveles_RESTA(); // reinicir la tab 
                this.Hide();
                perdiste4R.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N4R_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Resta_Enteros = llamarclalvR4.retornarlistaenterosR4();

            if (Nivel4_Resta_Enteros[0] == llamarclalvR4.retonar_resultadoNR4())
            {
                comenzarlvl4();

                conteo4R = conteo4R + 1;
                lblconteoN4R.Text = Convert.ToString(conteo4R) + " /10";
                if (conteo4R == 10)
                {
                    timerN4R.Stop(); 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                    TCResta.SelectedIndex = 4; 
                }
            }
            else
            {
                cmdresp1N4R.BackColor = Color.Red;
                tiempo4R -= 3;
                lbltiempoN4R.Text = Convert.ToString(tiempo4R);
                lblpunteoN4R.Text = llamarclalvR4.quitarpuntosN4R(); 
            }
        }

        private void cmdresp2N4R_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Resta_Enteros = llamarclalvR4.retornarlistaenterosR4();

            if (Nivel4_Resta_Enteros[1] == llamarclalvR4.retonar_resultadoNR4())
            {
                comenzarlvl4();

                conteo4R = conteo4R + 1;
                lblconteoN4R.Text = Convert.ToString(conteo4R) + " /10";
                if (conteo4R == 10)
                {
                    timerN4R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                    TCResta.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp2N4R.BackColor = Color.Red;
                tiempo4R -= 3;
                lbltiempoN4R.Text = Convert.ToString(tiempo4R);
                lblpunteoN4R.Text = llamarclalvR4.quitarpuntosN4R();
            }
        }

        private void cmdresp3N4R_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Resta_Enteros = llamarclalvR4.retornarlistaenterosR4();

            if (Nivel4_Resta_Enteros[2] == llamarclalvR4.retonar_resultadoNR4())
            {
                comenzarlvl4();

                conteo4R = conteo4R + 1;
                lblconteoN4R.Text = Convert.ToString(conteo4R) + " /10";
                if (conteo4R == 10)
                {
                    timerN4R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                    TCResta.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp3N4R.BackColor = Color.Red;
                tiempo4R -= 3;
                lbltiempoN4R.Text = Convert.ToString(tiempo4R);
                lblpunteoN4R.Text = llamarclalvR4.quitarpuntosN4R();
            }
        }

        private void cmdresp4N4R_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Resta_Enteros = llamarclalvR4.retornarlistaenterosR4();

            if (Nivel4_Resta_Enteros[3] == llamarclalvR4.retonar_resultadoNR4())
            {
                comenzarlvl4();

                conteo4R = conteo4R + 1;
                lblconteoN4R.Text = Convert.ToString(conteo4R) + " /10";
                if (conteo4R == 10)
                {
                    timerN4R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4_Suma");
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                    TCResta.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp4N4R.BackColor = Color.Red;
                tiempo4R -= 3;
                lbltiempoN4R.Text = Convert.ToString(tiempo4R);
                lblpunteoN4R.Text = llamarclalvR4.quitarpuntosN4R();
            }
        }
        //FIN NIVEL 4______________________________________________________________________________________________

        /*INICO NIVEL 5 */
        ClassResta_Niveles llamarclalvlR5 = new ClassResta_Niveles(); //instanciamos la clase de forma global para ese nivel 
        int conteo5R = 1, tiempo5R = 60, punteomax5R = 140000;
        private void tabNivel5R_Click(object sender, EventArgs e)
        {
            lblconteoN5R.Text = " /10"; 
        }
        private void iniciar5ultimlvl()
        {
            llamarclalvlR5.generarlvlR5();
            llamarclalvlR5.Respuesta_LvlR5();

            List<string> Nivel5_Resta_Cadenaca_ = llamarclalvlR5.retornar_listaNR5();

            lbloperacionN5R.Text = "¿Cuál es la suma mayor?";

            cmdresp1N5R.Text = Nivel5_Resta_Cadenaca_[0].ToString();
            cmdresp1N5R.BackColor = Color.Transparent;

            cmdresp2N5R.Text = Nivel5_Resta_Cadenaca_[1].ToString();
            cmdresp2N5R.BackColor = Color.Transparent;

            cmdresp3N5R.Text = Nivel5_Resta_Cadenaca_[2].ToString();
            cmdresp3N5R.BackColor = Color.Transparent;

            cmdresp4N5R.Text = Nivel5_Resta_Cadenaca_[3].ToString();
            cmdresp4N5R.BackColor = Color.Transparent;
        }

        private void cmdiniciarN5R_Click(object sender, EventArgs e)
        {
            iniciar5ultimlvl();

            cmdresp1N5R.Enabled = true;
            cmdresp2N5R.Enabled = true;
            cmdresp3N5R.Enabled = true;
            cmdresp4N5R.Enabled = true;
            timerN5R.Start();
            lblconteoN5R.Text = " 1/10";
            lblpunteoN5R.Text = Convert.ToString(punteomax5R); 

        }

        private void timerN5R_Tick(object sender, EventArgs e)
        {
            int puntemin1R5 = 65000, limiinfe1R5 = 0, limeinfe2R5 = 0, A1R5 = 0,
             limiinfe3R5 = 0, limesupe1R5 = 0, limesupe2R5 = 0, limisupe3R5 = 0;

            A1R5 = (punteomax5R - puntemin1R5) / 3;

            limiinfe1R5 = puntemin1R5;
            limeinfe2R5 = puntemin1R5 + A1R5;
            limiinfe3R5 = puntemin1R5 + (2 * A1R5);
            limesupe1R5 = (puntemin1R5 + A1R5) - 1;
            limesupe2R5 = ((puntemin1R5 + (2 * A1R5)) - 1);
            limisupe3R5 = punteomax5R;

            if ((Convert.ToInt32(lblpunteoN5R.Text) >= limiinfe1R5) && (Convert.ToInt32(lblpunteoN5R.Text) <= limesupe1R5))
            {
                picestreR5.Image = imglisR.Images[1];
            }
            else
            {
                picestreR5.Image = imglisR.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN5R.Text) >= limeinfe2R5) && (Convert.ToInt32(lblpunteoN5R.Text) <= limesupe2R5))
            {
                picestreR5.Image = imglisR.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN5R.Text) >= limiinfe3R5) && (Convert.ToInt32(lblpunteoN5R.Text) <= limisupe3R5))
            {
                picestreR5.Image = imglisR.Images[3];
            }
            tiempo5R--;
            lblpunteoN5R.Text = llamarclalvlR5.quitapunteos_segundosNR5();
            if ((tiempo5R >= 0) && (Convert.ToInt32(lblpunteoN5R.Text) > 0) && (Convert.ToInt32(lblpunteoN5R.Text) >= puntemin1R5))
            {
               lbltiempoN5R.Text = tiempoR2.ToString();
            }
            else
            {
                timerN5R.Stop(); 
                lblpunteoN5R.Text = "0";
                picestreR5.Image = imglisR.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_RESTA perdiste5R = new Niveles_RESTA(); // reinicir la tab 
                this.Hide(); 
                perdiste5R.ShowDialog();
                this.Close(); 

            }
        }

        private void cmdresp1N5R_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Resta_Enteros = llamarclalvlR5.retornarlistaenterosR5();

            if (Nivel5_Resta_Enteros[0] == llamarclalvlR5.retonar_resultadoNR5())
            {
                iniciar5ultimlvl();
                conteo5R = conteo5R + 1;
                lblconteoN5R.Text= Convert.ToString(conteo5R) + " /10";
                if (conteo5R == 10)
                {
                    timerN5R.Stop(); 
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                }
            }
            else
            {
                cmdresp1N5R.BackColor = Color.Red;
                tiempo5R -= 3;
                lbltiempoN5R.Text= Convert.ToString(tiempo5R);
                lblpunteoN5R.Text = llamarclalvlR5.quitarpuntosN5R(); 
            }
        }

        private void cmdresp2N5R_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Resta_Enteros = llamarclalvlR5.retornarlistaenterosR5();

            if (Nivel5_Resta_Enteros[1] == llamarclalvlR5.retonar_resultadoNR5())
            {
                iniciar5ultimlvl();
                conteo5R = conteo5R + 1;
                lblconteoN5R.Text = Convert.ToString(conteo5R) + " /10";
                if (conteo5R == 10)
                {
                    timerN5R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                }
            }
            else
            {
                cmdresp2N5R.BackColor = Color.Red;
                tiempo5R -= 3;
                lbltiempoN5R.Text = Convert.ToString(tiempo5R);
                lblpunteoN5R.Text = llamarclalvlR5.quitarpuntosN5R();
            }
        }

        private void cmdresp3N5R_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Resta_Enteros = llamarclalvlR5.retornarlistaenterosR5();

            if (Nivel5_Resta_Enteros[2] == llamarclalvlR5.retonar_resultadoNR5())
            {
                iniciar5ultimlvl();
                conteo5R = conteo5R + 1;
                lblconteoN5R.Text = Convert.ToString(conteo5R) + " /10";
                if (conteo5R == 10)
                {
                    timerN5R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                }
            }
            else
            {
                cmdresp3N5R.BackColor = Color.Red;
                tiempo5R -= 3;
                lbltiempoN5R.Text = Convert.ToString(tiempo5R);
                lblpunteoN5R.Text = llamarclalvlR5.quitarpuntosN5R();
            }
        }

        private void cmdresp4N5R_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Resta_Enteros = llamarclalvlR5.retornarlistaenterosR5();

            if (Nivel5_Resta_Enteros[2] == llamarclalvlR5.retonar_resultadoNR5())
            {
                iniciar5ultimlvl();
                conteo5R = conteo5R + 1;
                lblconteoN5R.Text = Convert.ToString(conteo5R) + " /10";
                if (conteo5R == 10)
                {
                    timerN5R.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                    cmdiniciarN1R.Enabled = true;
                    cmdiniciarN2R.Enabled = true;
                    cmdinicioN3R.Enabled = true;
                    cmdiniciarN4R.Enabled = true;
                    cmdiniciarN5R.Enabled = true; 
                }
            }
            else
            {
                cmdresp4N5R.BackColor = Color.Red;
                tiempo5R -= 3;
                lbltiempoN5R.Text = Convert.ToString(tiempo5R);
                lblpunteoN5R.Text = llamarclalvlR5.quitarpuntosN5R();
            }
        }
    }
}
