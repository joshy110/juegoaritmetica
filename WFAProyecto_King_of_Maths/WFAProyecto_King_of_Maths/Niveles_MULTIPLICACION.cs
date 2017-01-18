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
    public partial class Niveles_MULTIPLICACION : Form
    {
        ClassMultiplicación_Niveles cargarclaseMultiLvl1 = new ClassMultiplicación_Niveles();
        int conteoM1 = 1, tiempoM1 = 60, punteomaxM1 = 100000;
        public Niveles_MULTIPLICACION()
        {
            InitializeComponent();
        }

        private void tabNivel1M_Click(object sender, EventArgs e)
        {
            lblconteoN1M.Text = " /10";
        }
        public void generarLvl1Multi()
        {
            cargarclaseMultiLvl1.Lvl1M();
            cargarclaseMultiLvl1.Respuesta_LvM1();
            List<int> Nivel1_Multipli = cargarclaseMultiLvl1.retornar_listaN1M();

            lbloperacionN1M.Text = Convert.ToString(cargarclaseMultiLvl1.retonar_numero1N1M()) + " * "
                                    + Convert.ToString(cargarclaseMultiLvl1.retonar_numero2N1M()) + "  =  ? ";

            cmdresp1N1M.Text = Nivel1_Multipli[0].ToString();
            cmdresp1N1M.BackColor = Color.Transparent;

            cmdresp2N1M.Text = Nivel1_Multipli[1].ToString();
            cmdresp2N1M.BackColor = Color.Transparent;

            cmdresp3N1M.Text = Nivel1_Multipli[2].ToString();
            cmdresp3N1M.BackColor = Color.Transparent;

            cmdresp4N1M.Text = Nivel1_Multipli[3].ToString();
            cmdresp4N1M.BackColor = Color.Transparent;
        }

        private void cmdiniciarN1M_Click(object sender, EventArgs e)
        {
            generarLvl1Multi();
            cmdresp1N1M.Enabled = true;
            cmdresp2N1M.Enabled = true;
            cmdresp3N1M.Enabled = true;
            cmdresp4N1M.Enabled = true;
            lblconteoN1M.Text = " 1/10 ";
            timerN1M.Start();
            lblpuntosN1M.Text = Convert.ToString(punteomaxM1);
        }
        private void timerN1M_Tick(object sender, EventArgs e)
        {
            int puntemin1M = 50000, limiinfe1 = 0, limeinfe2 = 0, A1 = 0,
              limiinfe3 = 0, limesupe1 = 0, limesupe2 = 0, limisupe3 = 0;

            A1 = (punteomaxM1 - puntemin1M) / 3;
            limiinfe1 = puntemin1M;
            limeinfe2 = puntemin1M + A1;
            limiinfe3 = puntemin1M + (2 * A1);
            limesupe1 = (puntemin1M + A1) - 1;
            limesupe2 = ((puntemin1M + (2 * A1)) - 1);
            limisupe3 = punteomaxM1;

            if ((Convert.ToInt32(lblpuntosN1M.Text) >= limiinfe1) && (Convert.ToInt32(lblpuntosN1M.Text) <= limesupe1))
            {
                picbNM1.Image = imgliM.Images[1]; 
            }
            else
            {
                picbNM1.Image = imgliM.Images[0]; 
            }
            if ((Convert.ToInt32(lblpuntosN1M.Text) >= limeinfe2) && (Convert.ToInt32(lblpuntosN1M.Text) <= limesupe2))
            {
                picbNM1.Image = imgliM.Images[2]; 
            }
            if ((Convert.ToInt32(lblpuntosN1M.Text) >= limiinfe3) && (Convert.ToInt32(lblpuntosN1M.Text) <= limisupe3))
            {
                picbNM1.Image = imgliM.Images[3]; 
            }
            tiempoM1--;
            lblpuntosN1M.Text = cargarclaseMultiLvl1.punteos_SEgundosN1M();
            if ((tiempoM1 >= 0) && (Convert.ToInt32(lblpuntosN1M.Text) > 0) && (Convert.ToInt32(lblpuntosN1M.Text) >= puntemin1M))
            {
                lbltiempoN1M.Text = tiempoM1.ToString();
            }
            else
            {
                timerN1M.Stop(); 
                lblpuntosN1M.Text = "0";
                picbNM1.Image = imgliM.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_MULTIPLICACION perdiste1M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                this.Hide();
                perdiste1M.ShowDialog();
                this.Close();
            }
        }
        private void cmdresp1N1M_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Multipli = cargarclaseMultiLvl1.retornar_listaN1M();
            if (Nivel1_Multipli[0] == cargarclaseMultiLvl1.retonar_resultadoN1M())
            {
                cmdiniciarN1M.Enabled = false;
                generarLvl1Multi();
                conteoM1 = conteoM1 + 1;
                lblconteoN1M.Text = Convert.ToString(conteoM1) + " /10";
                if (conteoM1 == 10)
                {
                    timerN1M.Stop();
                    MessageBox.Show("Felicidades has finalizado", "Nivel 1_Multiplicación");
                    cmdiniciarN2M.Enabled = true;
                    tabCMultipli.SelectedIndex = 1;
                }

            }
            else
            {
                cmdresp1N1M.BackColor = Color.Red;
                tiempoM1 -= 3;
                lbltiempoN1M.Text = Convert.ToString(tiempoM1);
                lblpuntosN1M.Text = cargarclaseMultiLvl1.quitarpuntosN1M();
            }

        }

        private void cmdresp2N1M_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Multipli = cargarclaseMultiLvl1.retornar_listaN1M();
            if (Nivel1_Multipli[1] == cargarclaseMultiLvl1.retonar_resultadoN1M())
            {
                cmdiniciarN1M.Enabled = false;
                generarLvl1Multi();
                conteoM1 = conteoM1 + 1;
                lblconteoN1M.Text = Convert.ToString(conteoM1) + " /10";
                if (conteoM1 == 10)
                {
                    timerN1M.Stop();
                    MessageBox.Show("Felicidades has finalizado", "Nivel 1_Multiplicación");
                    cmdiniciarN2M.Enabled = true;
                    tabCMultipli.SelectedIndex = 1;
                }

            }
            else
            {
                cmdresp2N1M.BackColor = Color.Red;
                tiempoM1 -= 3;
                lbltiempoN1M.Text = Convert.ToString(tiempoM1);
                lblpuntosN1M.Text = cargarclaseMultiLvl1.quitarpuntosN1M();
            }
        }

        private void cmdresp3N1M_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Multipli = cargarclaseMultiLvl1.retornar_listaN1M();
            if (Nivel1_Multipli[2] == cargarclaseMultiLvl1.retonar_resultadoN1M())
            {
                cmdiniciarN1M.Enabled = false;
                generarLvl1Multi();
                conteoM1 = conteoM1 + 1;
                lblconteoN1M.Text = Convert.ToString(conteoM1) + " /10 ";
                if (conteoM1 == 10)
                {
                    timerN1M.Stop();
                    MessageBox.Show("Felicidades has finalizado", "Nivel 1_Multiplicación");
                    cmdiniciarN2M.Enabled = true;
                    tabCMultipli.SelectedIndex = 1;
                }

            }
            else
            {
                cmdresp3N1M.BackColor = Color.Red;
                tiempoM1 -= 3;
                lbltiempoN1M.Text = Convert.ToString(tiempoM1);
                lblpuntosN1M.Text = cargarclaseMultiLvl1.quitarpuntosN1M();
            }
        }

        private void cmdresp4N1M_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_Multipli = cargarclaseMultiLvl1.retornar_listaN1M();
            if (Nivel1_Multipli[3] == cargarclaseMultiLvl1.retonar_resultadoN1M())
            {
                cmdiniciarN1M.Enabled = false;
                generarLvl1Multi();
                conteoM1 = conteoM1 + 1;
                lblconteoN1M.Text = Convert.ToString(conteoM1) + " / 10";
                if (conteoM1 == 10)
                {
                    timerN1M.Stop();
                    MessageBox.Show("Felicidades has finalizado", "Nivel 1_Multiplicación");
                    cmdiniciarN2M.Enabled = true;
                    tabCMultipli.SelectedIndex = 1;
                }

            }
            else
            {
                cmdresp4N1M.BackColor = Color.Red;
                tiempoM1 -= 3;
                lbltiempoN1M.Text = Convert.ToString(tiempoM1);
                lblpuntosN1M.Text = cargarclaseMultiLvl1.quitarpuntosN1M();
            }
        }
        //FIN NIVEL 1 M______________________________________________________________________________-

        /*INIICIO NIVEL 2*/
        ClassMultiplicación_Niveles cargarclselvlM2 = new ClassMultiplicación_Niveles();
        int conteoM2 = 1, tiempoM2 = 60, punteomaxM2 = 110000;
        private void tabNiel2M_Click(object sender, EventArgs e)
        {
            lblconteoN2M.Text = " /10";
        }
        public void generarLvl2M()
        {
            cargarclselvlM2.LvlM2();
            cargarclselvlM2.Respuesta_LvM2();
            List<int> Nivel2_Multipli = cargarclselvlM2.retornar_listaN2M();

            lbloperacionN2M.Text = Convert.ToString(cargarclselvlM2.retonar_numero1N2M()) + "   *   ?   =    " +
                                    Convert.ToString(cargarclselvlM2.retonar_resultadoN2M());

            cmdresp1N2M.Text = Nivel2_Multipli[0].ToString();
            cmdresp1N2M.BackColor = Color.Transparent;

            cmdresp2N2M.Text = Nivel2_Multipli[1].ToString();
            cmdresp2N2M.BackColor = Color.Transparent;

            cmdresp3N2M.Text = Nivel2_Multipli[2].ToString();
            cmdresp3N2M.BackColor = Color.Transparent;

            cmdresp4N2M.Text = Nivel2_Multipli[3].ToString();
            cmdresp4N2M.BackColor = Color.Transparent;
        }

        private void cmdiniciarN2M_Click(object sender, EventArgs e)
        {
            generarLvl2M();
            cmdresp1N2M.Enabled = true;
            cmdresp2N2M.Enabled = true;
            cmdresp3N2M.Enabled = true;
            cmdresp4N2M.Enabled = true;
            lblconteoN2M.Text = " 1/10";
            timerN2M.Start();
            lblpuntosN2M.Text = Convert.ToString(punteomaxM2);
        }

        private void timerN2M_Tick(object sender, EventArgs e)
        {
            int punteminM2 = 55000, limiinfeM1_2 = 0, limeinfeM2_2 = 0, AM2_2 = 0,
              limiinfeM3_2 = 0, limesupeM1_2 = 0, limesupeM2_2 = 0, limisupeM3_2 = 0;

            AM2_2 = (punteomaxM2 - punteminM2) / 3;
            limiinfeM1_2 = punteminM2;
            limeinfeM2_2 = punteminM2 + AM2_2;
            limiinfeM3_2 = punteminM2 + (2 * AM2_2);
            limesupeM1_2 = (punteminM2 + AM2_2) - 1;
            limesupeM2_2 = ((punteminM2 + (2 * AM2_2)) - 1);
            limisupeM3_2 = punteomaxM2;

            if ((Convert.ToInt32(lblpuntosN2M.Text) >= limiinfeM1_2) && (Convert.ToInt32(lblpuntosN2M.Text) <= limesupeM1_2))
            {
                picbN2M.Image = imgliM.Images[1];
            }
            else
            {
                picbN2M.Image = imgliM.Images[0];
            }
            if ((Convert.ToInt32(lblpuntosN2M.Text) >= limeinfeM2_2) && (Convert.ToInt32(lblpuntosN2M.Text) <= limesupeM2_2))
            {
                picbN2M.Image = imgliM.Images[2];
            }
            if ((Convert.ToInt32(lblpuntosN2M.Text) >= limiinfeM3_2) && (Convert.ToInt32(lblpuntosN2M.Text) <= limisupeM3_2))
            {
                picbN2M.Image = imgliM.Images[3];
            }
            tiempoM2--;
            lblpuntosN2M.Text= cargarclselvlM2.quitapunteos_segundosN2M();
            if ((tiempoM2 >= 0) && (Convert.ToInt32(lblpuntosN2M.Text) > 0) && (Convert.ToInt32(lblpuntosN2M.Text) >= punteminM2))
            {
                lbltiempoN2M.Text = tiempoM2.ToString();
            }
            else
            {
                timerN2M.Stop(); 
                lblpuntosN2M.Text = "0";
                picbN2M.Image = imgliM.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_MULTIPLICACION perdiste2M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                this.Hide();
                perdiste2M.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N2M_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Multipli = cargarclselvlM2.retornar_listaN2M();
            if (Nivel2_Multipli[0] == cargarclselvlM2.retonar_resucN2M())
            {
                cmdiniciarN2M.Enabled = false;
                generarLvl2M();
                conteoM2 = conteoM2 + 1;
                lblconteoN2M.Text = Convert.ToString(conteoM2) + " /10 ";
                if (conteoM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2_Mltiplicación");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    tabCMultipli.SelectedIndex = 2;
                }
            }
            else
            {
                cmdresp1N2M.BackColor = Color.Red;
                tiempoM2 -= 3;
                lbltiempoN2M.Text = Convert.ToString(tiempoM2);
                lblpuntosN2M.Text = cargarclselvlM2.quitarpuntosN2M();
            }
        }

        private void cmdresp2N2M_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Multipli = cargarclselvlM2.retornar_listaN2M();
            if (Nivel2_Multipli[1] == cargarclselvlM2.retonar_resucN2M())
            {
                cmdiniciarN2M.Enabled = false;
                generarLvl2M();
                conteoM2 = conteoM2 + 1;
                lblconteoN2M.Text = Convert.ToString(conteoM2) + " /10 ";
                if (conteoM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2_Mltiplicación");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    tabCMultipli.SelectedIndex = 2;
                }
            }
            else
            {
                cmdresp2N2M.BackColor = Color.Red;
                tiempoM2 -= 3;
                lbltiempoN2M.Text = Convert.ToString(tiempoM2);
                lblpuntosN2M.Text = cargarclselvlM2.quitarpuntosN2M();
            }
        }

        private void cmdresp3N2M_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Multipli = cargarclselvlM2.retornar_listaN2M();
            if (Nivel2_Multipli[2] == cargarclselvlM2.retonar_resucN2M())
            {
                cmdiniciarN2M.Enabled = false;
                generarLvl2M();
                conteoM2 = conteoM2 + 1;
                lblconteoN2M.Text = Convert.ToString(conteoM2) + " /10 ";
                if (conteoM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2_Mltiplicación");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    tabCMultipli.SelectedIndex = 2;
                }
            }
            else
            {
                cmdresp3N2M.BackColor = Color.Red;
                tiempoM2 -= 3;
                lbltiempoN2M.Text = Convert.ToString(tiempoM2);
                lblpuntosN2M.Text = cargarclselvlM2.quitarpuntosN2M();
            }
        }


        private void cmdresp4N2M_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_Multipli = cargarclselvlM2.retornar_listaN2M();
            if (Nivel2_Multipli[3] == cargarclselvlM2.retonar_resucN2M())
            {
                cmdiniciarN2M.Enabled = false;
                generarLvl2M();
                conteoM2 = conteoM2 + 1;
                lblconteoN2M.Text = Convert.ToString(conteoM2) + " /10 ";
                if (conteoM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2_Mltiplicación");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    tabCMultipli.SelectedIndex = 2;
                }
            }
            else
            {
                cmdresp4N2M.BackColor = Color.Red;
                tiempoM2 -= 3;
                lbltiempoN2M.Text = Convert.ToString(tiempoM2);
                lblpuntosN2M.Text = cargarclselvlM2.quitarpuntosN2M();
            }
        }
        // FIN NIVEL 2____________________________________________________________________________________

        /*INICIO NIVEL 3 */

        ClassMultiplicación_Niveles cargarLvl3Multi = new ClassMultiplicación_Niveles();
        int conteo3M = 1, tiempo3M = 60, punteomax3M = 120000;

        private void tabNivel3M_Click(object sender, EventArgs e)
        {
            lblconteoN3M.Text = " /10 ";
        }
        public void generarlvlMultipli3()
        {
            cargarLvl3Multi.generarlvl3M();
            cargarLvl3Multi.Respuesta_Lvl3M();
            List<string> Nivel3_Multipli_Cadena = cargarLvl3Multi.retornar_listaN3M();

            lbloperacionN3M.Text = " ?   *   ?   =  " + Convert.ToString(cargarLvl3Multi.retonar_resultadoN3M());

            cmdresp1N3M.Text = Nivel3_Multipli_Cadena[0].ToString();
            cmdresp1N3M.BackColor = Color.Transparent;

            cmdresp2N3M.Text = Nivel3_Multipli_Cadena[1].ToString();
            cmdresp2N3M.BackColor = Color.Transparent;

            cmdresp3N3M.Text = Nivel3_Multipli_Cadena[2].ToString();
            cmdresp3N3M.BackColor = Color.Transparent;

            cmdresp4N3M.Text = Nivel3_Multipli_Cadena[3].ToString();
            cmdresp4N3M.BackColor = Color.Transparent;

        }

        private void cmdiniciarN3M_Click(object sender, EventArgs e)
        {
            generarlvlMultipli3();

            cmdresp1N3M.Enabled = true;
            cmdresp2N3M.Enabled = true;
            cmdresp3N3M.Enabled = true;
            cmdresp4N3M.Enabled = true;

            timerN3M.Start();
            lblconteoN3M.Text = " 1/10 ";
            lblpuntosN3M.Text = Convert.ToString(punteomax3M);
        }

        private void timerN3M_Tick(object sender, EventArgs e)
        {
            int punteminM3_3 = 60000, limiinfeM1_3 = 0, limeinfeM2_3 = 0, AM3_3 = 0,
             limiinfeM3_3 = 0, limesupeM1_3 = 0, limesupeM2_3 = 0, limisupeM3_3 = 0;

            AM3_3 = (punteomax3M - punteminM3_3) / 3;
            limiinfeM1_3 = punteminM3_3;
            limeinfeM2_3 = punteminM3_3 + AM3_3;
            limiinfeM3_3 = punteminM3_3 + (2 * AM3_3);
            limesupeM1_3 = (punteminM3_3 + AM3_3) - 1;
            limesupeM2_3 = ((punteminM3_3 + (2 * AM3_3)) - 1);
            limisupeM3_3 = punteomax3M;

            if ((Convert.ToInt32(lblpuntosN3M.Text) >= limiinfeM1_3) && (Convert.ToInt32(lblpuntosN3M.Text) <= limesupeM1_3))
            {
                picbN3M.Image = imgliM.Images[1];
            }
            else
            {
                picbN3M.Image = imgliM.Images[0];
            }
            if ((Convert.ToInt32(lblpuntosN3M.Text) >= limeinfeM2_3) && (Convert.ToInt32(lblpuntosN3M.Text) <= limesupeM2_3))
            {
                picbN3M.Image = imgliM.Images[2];
            }
            if ((Convert.ToInt32(lblpuntosN3M.Text) >= limiinfeM3_3) && (Convert.ToInt32(lblpuntosN3M.Text) <= limisupeM3_3))
            {
                picbN3M.Image = imgliM.Images[3];
            }

            tiempo3M--;
            lblpuntosN3M.Text = cargarLvl3Multi.quitapunteos_segundosN3M();
            if ((tiempo3M >= 0) && (Convert.ToInt32(lblpuntosN3M.Text) > 0) && (Convert.ToInt32(lblpuntosN3M.Text) >= punteminM3_3))
            {
                lbltiempoN3M.Text = tiempo3M.ToString();
            }
            else
            {
                timerN3M.Stop(); 
                lblpuntosN3M.Text = "0";
                picbN3M.Image = imgliM.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_MULTIPLICACION perdiste3M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                this.Hide();
                perdiste3M.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N3M_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Multipli_Enteros = cargarLvl3Multi.retornarlistaenterosM3();
            if (Nivel3_Multipli_Enteros[0] == cargarLvl3Multi.retonar_resultadoN3M())
            {
                generarlvlMultipli3();
                cmdiniciarN3M.Enabled = false;
                conteo3M = conteo3M + 1;
                lblconteoN3M.Text = Convert.ToString(conteo3M) + " /10";
                if (conteo3M == 10)
                {
                    timerN3M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp1N3M.BackColor = Color.Red;
                tiempo3M -= 3;
                lbltiempoN3M.Text = Convert.ToString(tiempo3M);
                lblpuntosN3M.Text = cargarLvl3Multi.quitarpuntosN3M();
            }
        }

        private void cmdresp2N3M_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Multipli_Enteros = cargarLvl3Multi.retornarlistaenterosM3();
            if (Nivel3_Multipli_Enteros[1] == cargarLvl3Multi.retonar_resultadoN3M())
            {
                generarlvlMultipli3();
                cmdiniciarN3M.Enabled = false;
                conteo3M = conteo3M + 1;
                lblconteoN3M.Text = Convert.ToString(conteo3M) + " /10";
                if (conteo3M == 10)
                {
                    timerN3M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp2N3M.BackColor = Color.Red;
                tiempo3M -= 3;
                lbltiempoN3M.Text = Convert.ToString(tiempo3M);
                lblpuntosN3M.Text = cargarLvl3Multi.quitarpuntosN3M();
            }
        }

        private void cmdresp3N3M_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Multipli_Enteros = cargarLvl3Multi.retornarlistaenterosM3();
            if (Nivel3_Multipli_Enteros[2] == cargarLvl3Multi.retonar_resultadoN3M())
            {
                generarlvlMultipli3();
                cmdiniciarN3M.Enabled = false;
                conteo3M = conteo3M + 1;
                lblconteoN3M.Text = Convert.ToString(conteo3M) + " /10";
                if (conteo3M == 10)
                {
                    timerN3M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 3;
                }
                else
                {
                    cmdresp3N3M.BackColor = Color.Red;
                    tiempo3M -= 3;
                    lbltiempoN3M.Text = Convert.ToString(tiempo3M);
                    lblpuntosN3M.Text = cargarLvl3Multi.quitarpuntosN3M();
                }
            }
        }

        private void cmdresp4N3M_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_Multipli_Enteros = cargarLvl3Multi.retornarlistaenterosM3();
            if (Nivel3_Multipli_Enteros[3] == cargarLvl3Multi.retonar_resultadoN3M())
            {
                generarlvlMultipli3();
                cmdiniciarN3M.Enabled = false;
                conteo3M = conteo3M + 1;
                lblconteoN3M.Text = Convert.ToString(conteo3M) + " /10";
                if (conteo3M == 10)
                {
                    timerN3M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 3;
                }
            }
            else
            {
                cmdresp4N3M.BackColor = Color.Red;
                tiempo3M -= 3;
                lbltiempoN3M.Text = Convert.ToString(tiempo3M);
                lblpuntosN3M.Text = cargarLvl3Multi.quitarpuntosN3M();
            }
        }
        //FIN NIVEL 3_________________________________________________________________________________________________

        /*NIVEL 4*/

        ClassMultiplicación_Niveles llamarclasslvM4 = new ClassMultiplicación_Niveles();
        int conteo4M = 1, tiempo4M = 60, punteomax4M = 130000;
        private void tabNivel4M_Click(object sender, EventArgs e)
        {
            lblconteoN4M.Text = " / 10";
        }
        public void inciarlvlM4()
        { /*jalar los retornos de la forma de este nivel */

            llamarclasslvM4.generarlvlM4();
            llamarclasslvM4.Respuesta_LvlM4();

            List<string> Nivel4_MULTIPLI_Cadena = llamarclasslvM4.retornar_listaNM4();   /*retorno a lista de las cadena de caracteres*/

            lbloperacionN4M.Text = " ¿Cuál multiplicación es la menor? "; /*realizo la pregunta a respnder */

            /*le pongo color transparente a lahora de iniciar el nivel */
            cmdresp1N4M.Text = Nivel4_MULTIPLI_Cadena[0].ToString();
            cmdresp1N4M.BackColor = Color.Transparent;

            cmdresp2N4M.Text = Nivel4_MULTIPLI_Cadena[1].ToString();
            cmdresp2N4M.BackColor = Color.Transparent;

            cmdresp3N4M.Text = Nivel4_MULTIPLI_Cadena[2].ToString();
            cmdresp3N4M.BackColor = Color.Transparent;

            cmdresp4N4M.Text = Nivel4_MULTIPLI_Cadena[3].ToString();
            cmdresp4N4M.BackColor = Color.Transparent;
        }

        private void cmdinicioN4M_Click(object sender, EventArgs e)
        {
            inciarlvlM4();

            cmdresp1N4M.Enabled = true;
            cmdresp2N4M.Enabled = true;
            cmdresp3N4M.Enabled = true;
            cmdresp4N4M.Enabled = true;

            timerN4M.Start();
            lblconteoN4M.Text = " 1/10";
            lblpunteoN4M.Text = Convert.ToString(punteomax4M);

            cmdinicioN4M.Enabled = false;

        }
        private void timerN4M_Tick(object sender, EventArgs e)
        {
            int punteminM4 = 65000, limiinfeM1_4 = 0, limeinfeM2_4 = 0, AM4_4 = 0,
             limiinfeM3_4 = 0, limesupeM1_4 = 0, limesupeM2_4 = 0, limisupeM3_4 = 0;

            AM4_4 = (punteomax4M - punteminM4) / 3;
            limiinfeM1_4 = punteminM4;
            limeinfeM2_4 = punteminM4 + AM4_4;
            limiinfeM3_4 = punteminM4 + (2 * AM4_4);
            limesupeM1_4 = (punteminM4 + AM4_4) - 1;
            limesupeM2_4 = ((punteminM4 + (2 * AM4_4)) - 1);
            limisupeM3_4 = punteomax4M;

            if ((Convert.ToInt32(lblpunteoN4M.Text) >= limiinfeM1_4) && (Convert.ToInt32(lblpunteoN4M.Text) <= limesupeM1_4))
            {
                picbNM1.Image = imgliM.Images[1];
            }
            else
            {
                picbNM1.Image = imgliM.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN4M.Text) >= limeinfeM2_4) && (Convert.ToInt32(lblpunteoN4M.Text) <= limesupeM2_4))
            {
                picbNM1.Image = imgliM.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN4M.Text) >= limiinfeM3_4) && (Convert.ToInt32(lblpunteoN4M.Text) <= limisupeM3_4))
            {
                picbNM1.Image = imgliM.Images[3];
            }

            tiempo4M--;
            lblpunteoN4M.Text = llamarclasslvM4.quitapunteos_segundosNM4();
            if ((tiempo4M >= 0) && (Convert.ToInt32(lblpunteoN4M.Text) > 0) && (Convert.ToInt32(lblpunteoN4M.Text) >= punteminM4))
            {
                lbltiempoN4M.Text = tiempo4M.ToString();
            }
            else
            {
                timerN4M.Stop(); 
                lblpunteoN4M.Text = "0";
                picbN3M.Image = imgliM.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_MULTIPLICACION perdiste4M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                this.Hide();
                perdiste4M.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N4M_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Multipli_Enteros = llamarclasslvM4.retornarlistaenterosM4();

            if (Nivel4_Multipli_Enteros[0] == llamarclasslvM4.retonar_resultadoNM4())
            {
                inciarlvlM4();

                conteo4M = conteo4M + 1;
                lblconteoN4M.Text = Convert.ToString(conteo4M) + " /10";
                if (conteo4M == 10)
                {
                    timerN4M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel ");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true;
                    cmdinicioN5M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp1N4M.BackColor = Color.Red;
                tiempo4M -= 3;
                lbltiempoN4M.Text = Convert.ToString(tiempo4M);
                lblpunteoN4M.Text = llamarclasslvM4.quitarpuntosN4M();
            }
        }

        private void cmdresp2N4M_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Multipli_Enteros = llamarclasslvM4.retornarlistaenterosM4();

            if (Nivel4_Multipli_Enteros[1] == llamarclasslvM4.retonar_resultadoNM4())
            {
                inciarlvlM4();

                conteo4M = conteo4M + 1;
                lblconteoN4M.Text = Convert.ToString(conteo4M) + " /10";
                if (conteo4M == 10)
                {
                    timerN4M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true;
                    cmdinicioN5M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp2N4M.BackColor = Color.Red;
                tiempo4M -= 3;
                lbltiempoN4M.Text = Convert.ToString(tiempo4M);
                lblpunteoN4M.Text = llamarclasslvM4.quitarpuntosN4M();
            }
        }

        private void cmdresp3N4M_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Multipli_Enteros = llamarclasslvM4.retornarlistaenterosM4();

            if (Nivel4_Multipli_Enteros[2] == llamarclasslvM4.retonar_resultadoNM4())
            {
                inciarlvlM4();

                conteo4M = conteo4M + 1;
                lblconteoN4M.Text = Convert.ToString(conteo4M) + " /10";
                if (conteo4M == 10)
                {
                    timerN4M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true;
                    cmdinicioN5M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp3N4M.BackColor = Color.Red;
                tiempo4M -= 3;
                lbltiempoN4M.Text = Convert.ToString(tiempo4M);
                lblpunteoN4M.Text = llamarclasslvM4.quitarpuntosN4M();
            }
        }

        private void cmdresp4N4M_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_Multipli_Enteros = llamarclasslvM4.retornarlistaenterosM4();

            if (Nivel4_Multipli_Enteros[3] == llamarclasslvM4.retonar_resultadoNM4())
            {
                inciarlvlM4();

                conteo4M = conteo4M + 1;
                lblconteoN4M.Text = Convert.ToString(conteo4M) + " /10";
                if (conteo4M == 10)
                {
                    timerN4M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdiniciarN2M.Enabled = true;
                    cmdiniciarN3M.Enabled = true;
                    cmdinicioN4M.Enabled = true;
                    cmdinicioN5M.Enabled = true; 
                    tabCMultipli.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp4N4M.BackColor = Color.Red;
                tiempo4M -= 3;
                lbltiempoN4M.Text = Convert.ToString(tiempo4M);
                lblpunteoN4M.Text = llamarclasslvM4.quitarpuntosN4M();
            }
        }

        //FIN NIVEL 4M______________________________________________________________________________

        /*INICIO NIVEL 5*/
        ClassMultiplicación_Niveles ultimolvl5M = new ClassMultiplicación_Niveles();
        int conteo5M = 1, tiempo5M = 60, punteomax5M = 140000;

        private void tabNivel5M_Click(object sender, EventArgs e)
        {
            lblconteoN5M.Text = " /10";
        }
        private void comenzarlvl5M()
        {
            ultimolvl5M.generarlvlM5();
            ultimolvl5M.Respuesta_LvlM5();

            List<string> Nivel5_Multiplicacion_CadenaC = ultimolvl5M.retornar_listaNM5();

            lbloperacionN5M.Text = "¿Cuál multiplicación es la mayor?";

            cmdresp1N5M.Text = Nivel5_Multiplicacion_CadenaC[0].ToString();
            cmdresp1N5M.BackColor = Color.Transparent;

            cmdresp2N5M.Text = Nivel5_Multiplicacion_CadenaC[1].ToString();
            cmdresp2N5M.BackColor = Color.Transparent;

            cmdresp3N5M.Text = Nivel5_Multiplicacion_CadenaC[2].ToString();
            cmdresp3N5M.BackColor = Color.Transparent;

            cmdresp4N5M.Text = Nivel5_Multiplicacion_CadenaC[3].ToString();
            cmdresp4N5M.BackColor = Color.Transparent;
        }

        private void cmdinicioN5M_Click(object sender, EventArgs e)
        {
            comenzarlvl5M();

            cmdresp1N5M.Enabled = true;
            cmdresp2N5M.Enabled = true;
            cmdresp3N5M.Enabled = true;
            cmdresp4N5M.Enabled = true;

            timerN5M.Start();
            lblpunteoN5M.Text = Convert.ToString(punteomax5M);
            lblconteoN5M.Text = "1/10";
            cmdinicioN5M.Enabled = false;
        }

        private void timerN5M_Tick(object sender, EventArgs e)
        {
            int puntemin5_5 = 70000, limiinfe1_5 = 0, limeinfe2_5 = 0, A5_5 = 0,
             limiinfe3_5 = 0, limesupe1_5 = 0, limesupe2_5 = 0, limisupe3_5 = 0;

            A5_5 = (punteomax5M - puntemin5_5) / 3;
            limiinfe1_5 = puntemin5_5;
            limeinfe2_5 = puntemin5_5 + A5_5;
            limiinfe3_5 = puntemin5_5 + (2 * A5_5);
            limesupe1_5 = (puntemin5_5 + A5_5) - 1;
            limesupe2_5 = ((puntemin5_5 + (2 * A5_5)) - 1);
            limisupe3_5 = punteomax5M;

            if ((Convert.ToInt32(lblpunteoN5M.Text) >= limiinfe1_5) && (Convert.ToInt32(lblpunteoN5M.Text) <= limesupe1_5))
            {
                picbN5M.Image = imgliM.Images[1];
            }
            else
            {
                picbN5M.Image = imgliM.Images[0];
            }
            if ((Convert.ToInt32(lblpunteoN4M.Text) >= limeinfe2_5) && (Convert.ToInt32(lblpunteoN5M.Text) <= limesupe2_5))
            {
                picbN5M.Image = imgliM.Images[2];
            }
            if ((Convert.ToInt32(lblpunteoN5M.Text) >= limiinfe3_5) && (Convert.ToInt32(lblpunteoN5M.Text) <= limisupe3_5))
            {
                picbN5M.Image = imgliM.Images[3];
            }

            tiempo5M--;
            lblpunteoN5M.Text = ultimolvl5M.quitapunteos_segundosNM5();
            if ((tiempo5M >= 0) && (Convert.ToInt32(lblpunteoN5M.Text) > 0) && (Convert.ToInt32(lblpunteoN5M.Text) >= puntemin5_5))
            {
                lblpunteoN5M.Text = tiempo5M.ToString();
            }
            else
            {
                timerN5M.Stop(); 
                lblpunteoN5M.Text = "0";
                picbN5M.Image = imgliM.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuela a intentarlo"); // mostrar mensaje de volver a intentarlo 
                Niveles_MULTIPLICACION perdiste5M = new Niveles_MULTIPLICACION(); // reinicir la tab 
                this.Hide();
                perdiste5M.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N5M_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Multiplicacion_Enteros = ultimolvl5M.retornarlistaenterosM5();

            if (Nivel5_Multiplicacion_Enteros[0] == ultimolvl5M.retonar_resultadoNM5())
            {
                comenzarlvl5M();


                conteo5M = conteo5M + 1;
                lblconteoN5M.Text = Convert.ToString(conteo5M) + " /10";
                if (conteo5M == 10)
                {
                    timerN5M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Multiplicación");
                    Menu_de_Mundos regresoMPdeM5 = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPdeM5.ShowDialog();
                    this.Close(); 
                }
            }
            else
            {
                cmdresp1N5M.BackColor = Color.Red;
                tiempo5M -= 3;
                lbltiempoN5M.Text = Convert.ToString(tiempo5M);
                lblpunteoN5M.Text = ultimolvl5M.quitarpuntosN5M();
            }


        }

        private void cmdresp2N5M_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Multiplicacion_Enteros = ultimolvl5M.retornarlistaenterosM5();

            if (Nivel5_Multiplicacion_Enteros[1] == ultimolvl5M.retonar_resultadoNM5())
            {
                comenzarlvl5M();


                conteo5M = conteo5M + 1;
                lblconteoN5M.Text = Convert.ToString(conteo5M) + " /10";
                if (conteo5M == 10)
                {
                    timerN5M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Multiplicación");
                    Menu_de_Mundos regresoMPdeM5 = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPdeM5.ShowDialog();
                    this.Close(); 
                }
            }
            else
            {
                cmdresp2N5M.BackColor = Color.Red;
                tiempo5M -= 3;
                lbltiempoN5M.Text = Convert.ToString(tiempo5M);
                lblpunteoN5M.Text = ultimolvl5M.quitarpuntosN5M();
            }

        }

        private void cmdresp3N5M_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Multiplicacion_Enteros = ultimolvl5M.retornarlistaenterosM5();

            if (Nivel5_Multiplicacion_Enteros[2] == ultimolvl5M.retonar_resultadoNM5())
            {
                comenzarlvl5M();


                conteo5M = conteo5M + 1;
                lblconteoN5M.Text = Convert.ToString(conteo5M) + " /10";
                if (conteo5M == 10)
                {
                    timerN5M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Multiplicación");
                    Menu_de_Mundos regresoMPdeM5 = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPdeM5.ShowDialog();
                    this.Close(); 
                }
            }
            else
            {
                cmdresp3N5M.BackColor = Color.Red;
                tiempo5M -= 3;
                lbltiempoN5M.Text = Convert.ToString(tiempo5M);
                lblpunteoN5M.Text = ultimolvl5M.quitarpuntosN5M();
            }
        }

        private void cmdresp4N5M_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_Multiplicacion_Enteros = ultimolvl5M.retornarlistaenterosM5();

            if (Nivel5_Multiplicacion_Enteros[3] == ultimolvl5M.retonar_resultadoNM5())
            {
                comenzarlvl5M();


                conteo5M = conteo5M + 1;
                lblconteoN5M.Text = Convert.ToString(conteo5M) + " /10";
                if (conteo5M == 10)
                {
                    timerN5M.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Multiplicación");
                    Menu_de_Mundos regresoMPdeM5 = new Menu_de_Mundos();
                    this.Hide();
                    regresoMPdeM5.ShowDialog();
                    this.Close(); 
                }
            }
            else
            {
                cmdresp4N5M.BackColor = Color.Red;
                tiempo5M -= 3;
                lbltiempoN5M.Text = Convert.ToString(tiempo5M);
                lblpunteoN5M.Text = ultimolvl5M.quitarpuntosN5M();
            }
        }
        // FIN MUNDO MULTIPLI 
    }
}
        