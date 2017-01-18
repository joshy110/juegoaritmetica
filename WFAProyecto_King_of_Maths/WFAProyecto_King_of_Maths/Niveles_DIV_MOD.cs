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
    public partial class Niveles_DIV_MOD : Form
    {
        ClassDIVyMOD_Niveles cargarDyM = new ClassDIVyMOD_Niveles();
        int conteoDyM1 = 1, tiempoDyM1 = 60, punteomaxDyM1 = 100000;
        public Niveles_DIV_MOD()
        {
            InitializeComponent();
        }

        private void tabN1DIV_MOD_Click(object sender, EventArgs e)
        {
            lblconteo1DyM.Text = " /10";  
        }

        private void inicarDyM_Niv1()
        {
            cargarDyM.generarlvl1MOD();
            cargarDyM.Respuesta_Lv1MOD();

            List<int> Nivel1_DyM = cargarDyM.retornar_listaN1MOD();

            lbloperacion1DyM.Text = Convert.ToString(cargarDyM.retonar_numero1N1MOD()) + "   MOD  " +
                                    Convert.ToString(cargarDyM.retonar_numero2N1MOD()) + "  =  ? ";

            resp1N1DyM.Text = Nivel1_DyM[0].ToString();
            resp1N1DyM.BackColor = Color.Transparent;

            resp2N1DyM.Text = Nivel1_DyM[1].ToString();
            resp2N1DyM.BackColor = Color.Transparent;

            resp3N1DyM.Text = Nivel1_DyM[2].ToString();
            resp3N1DyM.BackColor = Color.Transparent;

            resp4N1DyM.Text = Nivel1_DyM[3].ToString();
            resp4N1DyM.BackColor = Color.Transparent;                    
        }

        private void cmdinicioN1DyM_Click(object sender, EventArgs e)
        {
            inicarDyM_Niv1();

            resp1N1DyM.Enabled = true;
            resp2N1DyM.Enabled = true;
            resp3N1DyM.Enabled = true;
            resp4N1DyM.Enabled = true; 

            lblpunteo1DyM.Text = " 1/10";
            timerN1DyM.Start();
            lblpunteo1DyM.Text = Convert.ToString(punteomaxDyM1); 
        }

        private void timerN1DyM_Tick(object sender, EventArgs e)
        {
            //esto de las estrellas lo debi meter a una clase más no pude lograrlo por ello lo deje a lo patito en la forma 
            int punteminDyM1_1 = 50000, limiinfeDyM1_1 = 0, limeinfeDyM1_1 = 0, ADyM1_1 = 0, limiinfeDyM3_1 = 0, limesupeDyM1_1 = 0, limesupeDyM2_1 = 0, limisupeDyM3_1 = 0;

            ADyM1_1 = (punteomaxDyM1 - punteminDyM1_1) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDyM1_1 = punteminDyM1_1;
            limeinfeDyM1_1 = punteminDyM1_1 + ADyM1_1;
            limiinfeDyM3_1 = punteminDyM1_1 + (2 * ADyM1_1);
            //obtengo los limites superiores 
            limesupeDyM1_1 = (punteminDyM1_1 + ADyM1_1) - 1;
            limesupeDyM2_1 = ((punteminDyM1_1 + (2 * ADyM1_1)) - 1);
            limisupeDyM3_1 = punteomaxDyM1;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteo1DyM.Text) >= limiinfeDyM1_1) && (Convert.ToInt32(lblpunteo1DyM.Text) <= limesupeDyM1_1))
            {
                picbN1DyM.Image = imgliDIVyMOD.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                picbN1DyM.Image = imgliDIVyMOD.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteo1DyM.Text) >= limeinfeDyM1_1) && (Convert.ToInt32(lblpunteo1DyM.Text) <= limesupeDyM2_1))
            {
                picbN1DyM.Image = imgliDIVyMOD.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteo1DyM.Text) >= limiinfeDyM3_1) && (Convert.ToInt32(lblpunteo1DyM.Text) <= limisupeDyM3_1))
            {
                picbN1DyM.Image = imgliDIVyMOD.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempoDyM1--; // le resto 1 segundo al tiempo que incia en 60 segundos 
            lblpunteo1DyM.Text = cargarDyM.quitarpunteos_segundosN1MOD(); // le quito los puntos respectivos a sus segundos 

            if ((tiempoDyM1 >= 0) && (Convert.ToInt32(lblpunteo1DyM.Text) > 0) && (Convert.ToInt32(lblpunteo1DyM.Text) >= punteminDyM1_1)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempo1DyM.Text = tiempoDyM1.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                timerN1DyM.Stop(); 
                lblpunteo1DyM.Text = "0";
                picbN1DyM.Image = imgliDIVyMOD.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_DIV_MOD perdiste1 = new Niveles_DIV_MOD();
                perdiste1.Show();
                this.Close();

            }
        }

        private void resp1N1DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_DyM = cargarDyM.retornar_listaN1MOD(); 
            if (Nivel1_DyM[0] == cargarDyM.retonar_resultadoN1MOD())
            {
                inicarDyM_Niv1();
                conteoDyM1 = conteoDyM1 + 1;
                lblconteo1DyM.Text = Convert.ToString(conteoDyM1) + " /10";
                if (conteoDyM1 == 10)
                {
                    timerN1DyM.Stop(); 
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN2DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 1;
                }
            }

            else
            {
                resp1N1DyM.BackColor = Color.Red;
                tiempoDyM1 -= 3;
                lbltiempo1DyM.Text = Convert.ToString(tiempoDyM1);
                lblpunteo1DyM.Text = cargarDyM.quitarpuntosN1MOD(); 
            }
        }

        private void resp2N1DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_DyM = cargarDyM.retornar_listaN1MOD();
            if (Nivel1_DyM[1] == cargarDyM.retonar_resultadoN1MOD())
            {
                inicarDyM_Niv1();
                conteoDyM1 = conteoDyM1 + 1;
                lblconteo1DyM.Text = Convert.ToString(conteoDyM1) + " /10";
                if (conteoDyM1 == 10)
                {
                    timerN1DyM.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN2DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 1;
                }
            }

            else
            {
                resp2N1DyM.BackColor = Color.Red;
                tiempoDyM1 -= 3;
                lbltiempo1DyM.Text = Convert.ToString(tiempoDyM1);
                lblpunteo1DyM.Text = cargarDyM.quitarpuntosN1MOD();
            }
        }

        private void resp3N1DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_DyM = cargarDyM.retornar_listaN1MOD();
            if (Nivel1_DyM[2] == cargarDyM.retonar_resultadoN1MOD())
            {
                inicarDyM_Niv1();
                conteoDyM1 = conteoDyM1 + 1;
                lblconteo1DyM.Text = Convert.ToString(conteoDyM1) + " /10";
                if (conteoDyM1 == 10)
                {
                    timerN1DyM.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN2DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 1;
                }
            }

            else
            {
                resp3N1DyM.BackColor = Color.Red;
                tiempoDyM1 -= 3;
                lbltiempo1DyM.Text = Convert.ToString(tiempoDyM1);
                lblpunteo1DyM.Text = cargarDyM.quitarpuntosN1MOD();
            }
        }

        private void resp4N1DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel1_DyM = cargarDyM.retornar_listaN1MOD();
            if (Nivel1_DyM[3] == cargarDyM.retonar_resultadoN1MOD())
            {
                inicarDyM_Niv1();
                conteoDyM1 = conteoDyM1 + 1;
                lblconteo1DyM.Text = Convert.ToString(conteoDyM1) + " /10";
                if (conteoDyM1 == 10)
                {
                    timerN1DyM.Stop();
                    MessageBox.Show("Felicidades terminaste el primer nivel 1");
                    cmdinicioN2DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 1;
                }
            }

            else
            {
                resp4N1DyM.BackColor = Color.Red;
                tiempoDyM1 -= 3;
                lbltiempo1DyM.Text = Convert.ToString(tiempoDyM1);
                lblpunteo1DyM.Text = cargarDyM.quitarpuntosN1MOD();
            }
        }

        //FIN NIVEL 1 DIV_______________________________________________________________________________________

        /*INICIO NIVEL 2*/
       
        ClassDIVyMOD_Niveles cargarDyMlvl2 = new ClassDIVyMOD_Niveles();
        int conteoDyM2 = 1, tiempoDyM2 = 60, punteomaxDyM2 = 110000;

        private void tabN2DIV_MOD_Click(object sender, EventArgs e)
        {
            lblconteoN2DyM.Text = " /10"; 
        }
        public void generarLvl2DIV()
        {
            cargarDyMlvl2.generarlvlDIV2();
            cargarDyMlvl2.Respuesta_Lv1DIV2();

            List<int> Nivel2_DIV = cargarDyMlvl2.retornar_listaN2DIV(); 

           lbloperacionN2DyM.Text = Convert.ToString(cargarDyMlvl2.retonar_numero1N2DIV()) + "   DIV  ?   =    " +
                                     Convert.ToString(cargarDyMlvl2.retonar_resultadp2N2DIV());

           resp1N2DyM.Text = Nivel2_DIV[0].ToString();
           resp1N2DyM.BackColor = Color.Transparent;

           resp2N2DyM.Text = Nivel2_DIV[1].ToString();
           resp2N2DyM.BackColor = Color.Transparent;

           resp3N2DyM.Text = Nivel2_DIV[2].ToString();
           resp3N2DyM.BackColor = Color.Transparent;

           resp4N2DyM.Text = Nivel2_DIV[3].ToString();
           resp4N2DyM.BackColor = Color.Transparent;
        }
        private void cmdinicioN2DyM_Click(object sender, EventArgs e)
        {
            generarLvl2DIV();

            /* habilito el conteo */
            resp1N2DyM.Enabled = true;
            resp2N2DyM.Enabled = true;
            resp3N2DyM.Enabled = true;
            resp4N2DyM.Enabled = true;

            lblconteoN2DyM.Text = " 1/10";
            timerN2DyM.Start();
            lblpunteoN2DyM.Text = Convert.ToString(punteomaxDyM2);
        }

        private void timerN2DyM_Tick(object sender, EventArgs e)
        {
            int punteminDyM2_2 = 55000, limiinfeDyM2_2 = 0, limeinfeDyM2_2 = 0, ADyM2_2 = 0, limiinfeDyM3_2 = 0, limesupeDyM1_2 = 0, limesupeDyM2_2 = 0, limisupeDyM3_2 = 0;

            ADyM2_2 = (punteomaxDyM2 - punteminDyM2_2) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDyM2_2 = punteminDyM2_2;
            limeinfeDyM2_2 = punteminDyM2_2 + ADyM2_2;
            limiinfeDyM3_2 = punteminDyM2_2 + (2 * ADyM2_2);
            //obtengo los limites superiores 
            limesupeDyM1_2 = (punteminDyM2_2 + ADyM2_2) - 1;
            limesupeDyM2_2 = ((punteminDyM2_2 + (2 * ADyM2_2)) - 1);
            limisupeDyM3_2 = punteomaxDyM2;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN2DyM.Text) >= limiinfeDyM2_2) && (Convert.ToInt32(lblpunteoN2DyM.Text) <= limesupeDyM1_2))
            {
                picbN2DyM.Image = imgliDIVyMOD.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                picbN2DyM.Image = imgliDIVyMOD.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteoN2DyM.Text) >= limeinfeDyM2_2) && (Convert.ToInt32(lblpunteoN2DyM.Text) <= limesupeDyM2_2))
            {
                picbN2DyM.Image = imgliDIVyMOD.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN2DyM.Text) >= limiinfeDyM3_2) && (Convert.ToInt32(lblpunteoN2DyM.Text) <= limisupeDyM3_2))
            {
                picbN2DyM.Image = imgliDIVyMOD.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempoDyM2--; // le resto 1 segundo al tiempo que incia en 60 segundos 
            lblpunteo1DyM.Text = cargarDyM.quitapunteos_SeguN2DIV();  ; // le quito los puntos respectivos a sus segundos 

            if ((tiempoDyM2 >= 0) && (Convert.ToInt32(lblpunteoN2DyM.Text) > 0) && (Convert.ToInt32(lblpunteoN2DyM.Text) >= punteminDyM2_2)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN2DyM.Text = tiempoDyM2.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                timerN2DyM.Stop(); 
                lblpunteoN2DyM.Text = "0";
                picbN2DyM.Image = imgliDIVyMOD.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_DIV_MOD perdiste2DyM = new Niveles_DIV_MOD();
                perdiste2DyM.Show();
                this.Close();
            }
        }

        private void resp1N2DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_DIV = cargarDyMlvl2.retornar_listaN2DIV();
            if (Nivel2_DIV[0] == cargarDyMlvl2.retonar_numero2N2DIV())
            {
                generarLvl2DIV();
                conteoDyM2 = conteoDyM2 + 1;
                lblconteoN2DyM.Text = Convert.ToString(conteoDyM2) + " /10 ";

                if (conteoDyM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;  
                    TCDIV_MOD.SelectedIndex = 2;
                }
            }
            else
            {
                resp1N2DyM.BackColor = Color.Red;
                tiempoDyM2 -= 3;
                lbltiempoN2DyM.Text = Convert.ToString(tiempoDyM2);
                lblpunteoN2DyM.Text = cargarDyMlvl2.quitarpuntosN2DIV();
            }
        }

        private void resp2N2DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_DIV = cargarDyMlvl2.retornar_listaN2DIV();
            if (Nivel2_DIV[1] == cargarDyMlvl2.retonar_numero2N2DIV())
            {
                generarLvl2DIV();
                conteoDyM2 = conteoDyM2 + 1;
                lblconteoN2DyM.Text = Convert.ToString(conteoDyM2) + " /10 ";

                if (conteoDyM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;  
                    TCDIV_MOD.SelectedIndex = 2;
                }
            }
            else
            {
                resp2N2DyM.BackColor = Color.Red;
                tiempoDyM2 -= 3;
                lbltiempoN2DyM.Text = Convert.ToString(tiempoDyM2);
                lblpunteoN2DyM.Text = cargarDyMlvl2.quitarpuntosN2DIV();
            }
        }

        private void resp3N2DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_DIV = cargarDyMlvl2.retornar_listaN2DIV();
            if (Nivel2_DIV[2] == cargarDyMlvl2.retonar_numero2N2DIV())
            {
                generarLvl2DIV();
                conteoDyM2 = conteoDyM2 + 1;
                lblconteoN2DyM.Text = Convert.ToString(conteoDyM2) + " /10 ";

                if (conteoDyM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;  
                    TCDIV_MOD.SelectedIndex = 2;
                }
            }
            else
            {
                resp3N2DyM.BackColor = Color.Red;
                tiempoDyM2 -= 3;
                lbltiempoN2DyM.Text = Convert.ToString(tiempoDyM2);
                lblpunteoN2DyM.Text = cargarDyMlvl2.quitarpuntosN2DIV();
            }
        }

        private void resp4N2DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel2_DIV = cargarDyMlvl2.retornar_listaN2DIV();
            if (Nivel2_DIV[3] == cargarDyMlvl2.retonar_numero2N2DIV())
            {
                generarLvl2DIV();
                conteoDyM2 = conteoDyM2 + 1;
                lblconteoN2DyM.Text = Convert.ToString(conteoDyM2) + " /10 ";

                if (conteoDyM2 == 10)
                {
                    MessageBox.Show("Felicidades has finalizado", "Nivel2");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;  
                    TCDIV_MOD.SelectedIndex = 2;
                }
            }
            else
            {
                resp4N2DyM.BackColor = Color.Red;
                tiempoDyM2 -= 3;
                lbltiempoN2DyM.Text = Convert.ToString(tiempoDyM2);
                lblpunteoN2DyM.Text = cargarDyMlvl2.quitarpuntosN2DIV();
            }
        }
        // FIN NIVEL 2 

        /*INICIO NIVEL 3 */
        ClassDIVyMOD_Niveles cargarlvl3DIVyMOD = new ClassDIVyMOD_Niveles();
        int conteoDIV3 = 1, tiempoDIV3 = 60, punteomaxDIV3 = 120000; // se declaran las variables a usar en esté nivel 
        private void tabN3DIV_MOD_Click(object sender, EventArgs e)
        {
            lblconteoN3DyM.Text = " /10"; // si llegara hacer click sobre la tab que salga solo esté valor 
        }
        public void inciarlvlDIV3()
        { /*jalar los retornos de la forma de este nivel */

            cargarlvl3DIVyMOD.generarlvlDIV3(); // llamo el método de generar nivel en la clase 
            cargarlvl3DIVyMOD.Respuesta_LvlDIV3(); // llamo el metodo de las respuesta de mi clase 

            List<string> Nivel3_DIVyMOD_Cadena = cargarlvl3DIVyMOD.retornar_listaN3DIV(); 

           operacionN3DyM.Text = "  ?   DIV   ?   =   " + Convert.ToString(cargarlvl3DIVyMOD.retonar_resultadoN3DIV());

           resp1N3DyM.Text = Nivel3_DIVyMOD_Cadena[0].ToString();
           resp1N3DyM.BackColor = Color.Transparent;

           resp2N3DyM.Text = Nivel3_DIVyMOD_Cadena[1].ToString();
           resp2N3DyM.BackColor = Color.Transparent;

           resp3N3DyM.Text = Nivel3_DIVyMOD_Cadena[2].ToString();
           resp3N3DyM.BackColor = Color.Transparent;

           resp4N3DyM.Text = Nivel3_DIVyMOD_Cadena[3].ToString();
           resp4N3DyM.BackColor = Color.Transparent;
        }
        private void cmdinicioN3DyM_Click(object sender, EventArgs e)
        {
            inciarlvlDIV3();

            resp1N3DyM.Enabled = true;
            resp2N3DyM.Enabled = true;
            resp3N3DyM.Enabled = true;
            resp4N3DyM.Enabled = true;

            timerN3DyM.Start(); 
            lblconteoN3DyM.Text = " 1/10 ";
            lblpunteoN3DyM.Text = Convert.ToString(punteomaxDIV3);
        }
        private void timerN3DyM_Tick(object sender, EventArgs e)
        {
            int punteminDyM2_3 = 60000, limiinfeDyM2_3 = 0, limeinfeDyM2_3 = 0, ADyM2_3 = 0, limiinfeDyM3_3 = 0, limesupeDyM1_3 = 0, limesupeDyM2_3 = 0, limisupeDyM3_3 = 0;

            ADyM2_3 = (punteomaxDIV3 - punteminDyM2_3) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDyM2_3 = punteminDyM2_3;
            limeinfeDyM2_3 = punteminDyM2_3 + ADyM2_3;
            limiinfeDyM3_3 = punteminDyM2_3 + (2 * ADyM2_3);
            //obtengo los limites superiores 
            limesupeDyM1_3 = (punteminDyM2_3 + ADyM2_3) - 1;
            limesupeDyM2_3 = ((punteminDyM2_3 + (2 * ADyM2_3)) - 1);
            limisupeDyM3_3 = punteomaxDIV3;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN3DyM.Text) >= limiinfeDyM2_3) && (Convert.ToInt32(lblpunteoN3DyM.Text) <= limesupeDyM1_3))
            {
                picbN3DyM.Image = imgliDIVyMOD.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                picbN3DyM.Image = imgliDIVyMOD.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteoN3DyM.Text) >= limeinfeDyM2_3) && (Convert.ToInt32(lblpunteoN3DyM.Text) <= limesupeDyM2_3))
            {
                picbN3DyM.Image = imgliDIVyMOD.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN3DyM.Text) >= limiinfeDyM3_3) && (Convert.ToInt32(lblpunteoN3DyM.Text) <= limisupeDyM3_3))
            {
                picbN3DyM.Image = imgliDIVyMOD.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempoDIV3--; // le resto 1 segundo al tiempo que incia en 60 segundos 
            lblpunteoN3DyM.Text= cargarlvl3DIVyMOD.quitapunteos_segundosN3DIV();  // le quito los puntos respectivos a sus segundos 

            if ((tiempoDIV3 >= 0) && (Convert.ToInt32(lblpunteoN3DyM.Text) > 0) && (Convert.ToInt32(lblpunteoN3DyM.Text) >= punteminDyM2_3)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
               lbltiempoN3DyM.Text= tiempoDyM1.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                timerN3DyM.Stop();
                lblpunteoN3DyM.Text= "0";
                picbN3DyM.Image = imgliDIVyMOD.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_DIV_MOD perdiste3DyM = new Niveles_DIV_MOD();
                this.Hide(); 
                perdiste3DyM.ShowDialog();
                this.Close();
            }
        }
        private void resp1N3DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_DIV_Enteros = cargarlvl3DIVyMOD.retornarlistaenterosDIV3();

            if (Nivel3_DIV_Enteros[0] == cargarlvl3DIVyMOD.retonar_resultadoN3DIV())
            {
                inciarlvlDIV3();
                conteoDIV3 = conteoDIV3 + 1;
                lblconteoN3DyM.Text = Convert.ToString(conteoDIV3) + " /10";

                if (conteoDIV3 == 10)
                {
                    timerN3DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;  
                    cmdinicioN4DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 3;
                }
            }
            else
            {
                resp1N3DyM.BackColor = Color.Red;
                tiempoDIV3 -= 3;
                lbltiempoN3DyM.Text = Convert.ToString(tiempoDIV3);
                lblpunteoN3DyM.Text = cargarlvl3DIVyMOD.quitarpuntosN3DIV();
            }
        }

        private void resp2N3DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_DIV_Enteros = cargarlvl3DIVyMOD.retornarlistaenterosDIV3();

            if (Nivel3_DIV_Enteros[1] == cargarlvl3DIVyMOD.retonar_resultadoN3DIV())
            {
                inciarlvlDIV3();
                conteoDIV3 = conteoDIV3 + 1;
                lblconteoN3DyM.Text = Convert.ToString(conteoDIV3) + " /10";

                if (conteoDIV3 == 10)
                {
                    timerN3DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 3;
                }
            }
            else
            {
                resp2N3DyM.BackColor = Color.Red;
                tiempoDIV3 -= 3;
                lbltiempoN3DyM.Text = Convert.ToString(tiempoDIV3);
                lblpunteoN3DyM.Text = cargarlvl3DIVyMOD.quitarpuntosN3DIV();
            }
        }

        private void resp3N3DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_DIV_Enteros = cargarlvl3DIVyMOD.retornarlistaenterosDIV3();

            if (Nivel3_DIV_Enteros[2] == cargarlvl3DIVyMOD.retonar_resultadoN3DIV())
            {
                inciarlvlDIV3();
                conteoDIV3 = conteoDIV3 + 1;
                lblconteoN3DyM.Text = Convert.ToString(conteoDIV3) + " /10";

                if (conteoDIV3 == 10)
                {
                    timerN3DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 3;
                }
            }
            else
            {
                resp3N3DyM.BackColor = Color.Red;
                tiempoDIV3 -= 3;
                lbltiempoN3DyM.Text = Convert.ToString(tiempoDIV3);
                lblpunteoN3DyM.Text = cargarlvl3DIVyMOD.quitarpuntosN3DIV();
            }
        }

        private void resp4N3DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel3_DIV_Enteros = cargarlvl3DIVyMOD.retornarlistaenterosDIV3();

            if (Nivel3_DIV_Enteros[3] == cargarlvl3DIVyMOD.retonar_resultadoN3DIV())
            {
                inciarlvlDIV3();
                conteoDIV3 = conteoDIV3 + 1;
                lblconteoN3DyM.Text = Convert.ToString(conteoDIV3) + " /10";

                if (conteoDIV3 == 10)
                {
                    timerN3DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 3");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 3;
                }
            }
            else
            {
                resp4N3DyM.BackColor = Color.Red;
                tiempoDIV3 -= 3;
                lbltiempoN3DyM.Text = Convert.ToString(tiempoDIV3);
                lblpunteoN3DyM.Text = cargarlvl3DIVyMOD.quitarpuntosN3DIV();
            }
        }

               //FIN NIVEL 3__________________________________________________________________________________________________________

        /*Inicio nivel 4 */
        ClassDIVyMOD_Niveles cargarlvl4DIVyMOD = new ClassDIVyMOD_Niveles();
        int conteoMOD4 = 1, tiempoMOD4 = 60, punteomaxMOD4 = 130000;
        private void tabN4DIV_MOD_Click(object sender, EventArgs e)
        {
            lblconteoN4DyM.Text = " /10"; // inicia sin operaciones por ello no le agruegue numero al principio 
        }
        public void inciarlvlMOD4()
        { /*jalar los retornos de la forma de este nivel */

            cargarlvl4DIVyMOD.generarlvlDIVyMOD4();
            cargarlvl4DIVyMOD.Respuesta_LvlDIVyMOD4();

            List<string> Nivel4_MOD_Cadena = cargarlvl4DIVyMOD.retornar_listaNDIVyMO4(); //retorno a lista de las cadena de caracteres*/

            lbloperacionN4DyM.Text= " ¿Cuál el Residuo o MOD menor? "; //realizo la pregunta a respnder 

            /* se llama a los bototnes y la posicion que va jugar c/ uno 
             * con respecto al contador de lista de la clase respectiva de este nivel 
             * le pongo color transparente a lahora de iniciar el nivel */

            cmdresp1N4DyM.Text = Nivel4_MOD_Cadena[0].ToString();
            cmdresp1N4DyM.BackColor = Color.Transparent;

            cmdresp2N4DyM.Text = Nivel4_MOD_Cadena[1].ToString();
            cmdresp2N4DyM.BackColor = Color.Transparent;

            cmdresp3N4DyM.Text = Nivel4_MOD_Cadena[2].ToString();
            cmdresp3N4DyM.BackColor = Color.Transparent;

            cmdresp4N4DyM.Text = Nivel4_MOD_Cadena[3].ToString();
            cmdresp4N4DyM.BackColor = Color.Transparent;
        }
        private void cmdresp1N4DyM_Click(object sender, EventArgs e)
        {
            // inicio los valores tanod de las clases como de los botones, punteos, conteo y tiempo 
            inciarlvlMOD4();

            cmdresp1N4DyM.Enabled = true;
            cmdresp2N4DyM.Enabled = true;
            cmdresp3N4DyM.Enabled = true;
            cmdresp4N4DyM.Enabled = true;

            timerN4DyM.Start();
            lblconteoN4DyM.Text = " 1/10";
            lblpunteoN4DyM.Text = Convert.ToString(punteomaxMOD4);

        }
        
        private void timerN4DyM_Tick(object sender, EventArgs e)
        {
            int punteminDyM2_4 = 65000, limiinfeDyM2_4 = 0, limeinfeDyM2_4 = 0, ADyM2_4 = 0, limiinfeDyM3_4 = 0, limesupeDyM1_4 = 0, limesupeDyM2_4 = 0, limisupeDyM3_4 = 0;

            ADyM2_4 = (punteomaxMOD4 - punteminDyM2_4) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDyM2_4 = punteminDyM2_4;
            limeinfeDyM2_4 = punteminDyM2_4 + ADyM2_4;
            limiinfeDyM3_4 = punteminDyM2_4 + (2 * ADyM2_4);
            //obtengo los limites superiores 
            limesupeDyM1_4 = (punteminDyM2_4 + ADyM2_4) - 1;
            limesupeDyM2_4 = ((punteminDyM2_4 + (2 * ADyM2_4)) - 1);
            limisupeDyM3_4 = punteomaxMOD4;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN3DyM.Text) >= limiinfeDyM2_4) && (Convert.ToInt32(lblpunteoN3DyM.Text) <= limesupeDyM1_4))
            {
                picbN4DyM.Image = imgliDIVyMOD.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
                    else
                    {
                        picbN4DyM.Image = imgliDIVyMOD.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
                    }
            if ((Convert.ToInt32(lblpunteoN4DyM.Text) >= limeinfeDyM2_4) && (Convert.ToInt32(lblpunteoN4DyM.Text) <= limesupeDyM2_4))
            {
                picbN4DyM.Image = imgliDIVyMOD.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN4DyM.Text) >= limiinfeDyM3_4) && (Convert.ToInt32(lblpunteoN4DyM.Text) <= limisupeDyM3_4))
            {
                picbN4DyM.Image = imgliDIVyMOD.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempoMOD4--;
            lblpunteoN4DyM.Text = cargarlvl4DIVyMOD.quitapunteos_segundosNDIVyMO4();  // le quito los puntos respectivos a sus segundos 

            if ((tiempoMOD4 >= 0) && (Convert.ToInt32(lblpunteoN3DyM.Text) > 0) && (Convert.ToInt32(lblpunteoN4DyM.Text) >= punteminDyM2_4)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN4DyM.Text = tiempoDyM1.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                timerN4DyM.Stop();
                lblpunteoN3DyM.Text = "0";
                picbN4DyM.Image = imgliDIVyMOD.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_DIV_MOD perdiste4DyM = new Niveles_DIV_MOD();
                this.Hide(); 
                perdiste4DyM.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N4DyM_Click_1(object sender, EventArgs e)
        {
            List<int> Nivel4_MOD_Enteros = cargarlvl4DIVyMOD.retornarlistaenterosDIVyMO4();

            if (Nivel4_MOD_Enteros[0] == cargarlvl4DIVyMOD.retonar_resultadoNDIVyMO4())
            {
                inciarlvlMOD4();

                conteoMOD4 = conteoMOD4 + 1;
                lblconteoN4DyM.Text = Convert.ToString(conteoMOD4) + " /10";

                if (conteoMOD4 == 10)
                {
                    timerN4DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    cmdiniciarN5DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp1N4DyM.BackColor = Color.Red;
                tiempoMOD4 -= 3;
                lbltiempoN4DyM.Text = Convert.ToString(tiempoMOD4);
                lblpunteoN4DyM.Text = cargarlvl4DIVyMOD.quitarpuntosNDIVyMOD4();
            }
        }

        private void cmdresp2N4DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_MOD_Enteros = cargarlvl4DIVyMOD.retornarlistaenterosDIVyMO4();

            if (Nivel4_MOD_Enteros[1] == cargarlvl4DIVyMOD.retonar_resultadoNDIVyMO4())
            {
                inciarlvlMOD4();

                conteoMOD4 = conteoMOD4 + 1;
                lblconteoN4DyM.Text = Convert.ToString(conteoMOD4) + " /10";

                if (conteoMOD4 == 10)
                {
                    timerN4DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdiniciarN5DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp2N4DyM.BackColor = Color.Red;
                tiempoMOD4 -= 3;
                lbltiempoN4DyM.Text = Convert.ToString(tiempoMOD4);
                lblpunteoN4DyM.Text = cargarlvl4DIVyMOD.quitarpuntosNDIVyMOD4();
            }
        }

        private void cmdresp3N4DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_MOD_Enteros = cargarlvl4DIVyMOD.retornarlistaenterosDIVyMO4();

            if (Nivel4_MOD_Enteros[2] == cargarlvl4DIVyMOD.retonar_resultadoNDIVyMO4())
            {
                inciarlvlMOD4();

                conteoMOD4 = conteoMOD4 + 1;
                lblconteoN4DyM.Text = Convert.ToString(conteoMOD4) + " /10";

                if (conteoMOD4 == 10)
                {
                    timerN4DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    cmdiniciarN5DyM.Enabled = true;
                    cmdiniciarN5DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp3N4DyM.BackColor = Color.Red;
                tiempoMOD4 -= 3;
                lbltiempoN4DyM.Text = Convert.ToString(tiempoMOD4);
                lblpunteoN4DyM.Text = cargarlvl4DIVyMOD.quitarpuntosNDIVyMOD4();
            }
        }

        private void cmdresp4N4DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel4_MOD_Enteros = cargarlvl4DIVyMOD.retornarlistaenterosDIVyMO4();

            if (Nivel4_MOD_Enteros[3] == cargarlvl4DIVyMOD.retonar_resultadoNDIVyMO4())
            {
                inciarlvlMOD4();

                conteoMOD4 = conteoMOD4 + 1;
                lblconteoN4DyM.Text = Convert.ToString(conteoMOD4) + " /10";

                if (conteoMOD4 == 10)
                {
                    timerN4DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 4");
                    cmdinicioN2DyM.Enabled = true;
                    cmdinicioN3DyM.Enabled = true;
                    cmdinicioN4DyM.Enabled = true;
                    cmdiniciarN5DyM.Enabled = true;
                    cmdiniciarN5DyM.Enabled = true;
                    TCDIV_MOD.SelectedIndex = 4;
                }
            }
            else
            {
                cmdresp4N4DyM.BackColor = Color.Red;
                tiempoMOD4 -= 3;
                lbltiempoN4DyM.Text = Convert.ToString(tiempoMOD4);
                lblpunteoN4DyM.Text = cargarlvl4DIVyMOD.quitarpuntosNDIVyMOD4();
            }
        } 
        //FIN NIVEL 4___________________________-

        // INICICO NIVEL 5 

        ClassDIVyMOD_Niveles cargarultimoDIVyMOD = new ClassDIVyMOD_Niveles(); 
        int conteo5DIVyMOD = 1, tiempo5DIVyMOD = 60, punteomax5DIVyMOD = 140000;
        private void tabN5DIV_MOD_Click(object sender, EventArgs e)
        {
            lblconteoN5DyM.Text = " /10";
        }
        public void inciarlvlDIVyMOD5()
        { 
            /*jalar los retornos de la forma de este nivel */
            cargarultimoDIVyMOD.generarlvlDIVyMOD5();
            cargarultimoDIVyMOD.Respuesta_LvlDIVyMOD5();

            List<string> Nivel5_MOD_Cadena = cargarultimoDIVyMOD.retornar_listaNDIVyMOD5();  /*retorno a lista de las cadena de caracteres*/

            lbloperacionN5DyM.Text = " ¿Cuál Residuo o MOD es el mayor? "; //realizar la pregunta a responder por el usuario 

            /*le pongo color transparente a lahora de iniciar el nivel y las posiciones que juegan de c/uno de ellos */

            cmdresp1N5DyM.Text = Nivel5_MOD_Cadena[0].ToString();
            cmdresp1N5DyM.BackColor = Color.Transparent;

            cmdresp2N5DyM.Text = Nivel5_MOD_Cadena[1].ToString();
            cmdresp2N5DyM.BackColor = Color.Transparent;

            cmdresp3N5DyM.Text = Nivel5_MOD_Cadena[2].ToString();
            cmdresp3N5DyM.BackColor = Color.Transparent;

            cmdresp4N5DyM.Text = Nivel5_MOD_Cadena[3].ToString();
            cmdresp4N5DyM.BackColor = Color.Transparent;
        }
        private void cmdiniciarN5DyM_Click(object sender, EventArgs e)
        {
            inciarlvlDIVyMOD5();

            cmdresp1N5DyM.Enabled = true;
            cmdresp2N5DyM.Enabled = true;
            cmdresp3N5DyM.Enabled = true;
            cmdresp4N5DyM.Enabled = true;

            timerN5DyM.Start();
            lblconteoN5DyM.Text = " 1/10";
            lblpunteoN5DyM.Text = Convert.ToString(punteomax5DIVyMOD);
        }
        private void timerN5DyM_Tick(object sender, EventArgs e)
        {
            int punteminDyM2_5 = 70000, limiinfeDyM1_5 = 0, limeinfeDyM2_5 = 0, ADyM2_5 = 0, limiinfeDyM3_5 = 0, limesupeDyM1_5 = 0, limesupeDyM2_5 = 0, limisupeDyM3_5 = 0;

            ADyM2_5 = (punteomax5DIVyMOD - punteminDyM2_5) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeDyM1_5 = punteminDyM2_5;
            limeinfeDyM2_5 = punteminDyM2_5 + ADyM2_5;
            limiinfeDyM3_5 = punteminDyM2_5 + (2 * ADyM2_5);
            //obtengo los limites superiores 
            limesupeDyM1_5 = (punteminDyM2_5 + ADyM2_5) - 1;
            limesupeDyM2_5 = ((punteminDyM2_5 + (2 * ADyM2_5)) - 1);
            limisupeDyM3_5 = punteomax5DIVyMOD;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN5DyM.Text) >= limiinfeDyM1_5) && (Convert.ToInt32(lblpunteoN5DyM.Text) <= limesupeDyM1_5))
            {
                picbN5DyM.Image = imgliDIVyMOD.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                picbN5DyM.Image = imgliDIVyMOD.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteoN5DyM.Text) >= limeinfeDyM2_5) && (Convert.ToInt32(lblpunteoN5DyM.Text) <= limesupeDyM2_5))
            {
                picbN5DyM.Image = imgliDIVyMOD.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN5DyM.Text) >= limiinfeDyM3_5) && (Convert.ToInt32(lblpunteoN5DyM.Text) <= limisupeDyM3_5))
            {
                picbN5DyM.Image = imgliDIVyMOD.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempo5DIVyMOD--;
            lblpunteoN5DyM.Text = cargarultimoDIVyMOD.quitapunteos_segundosNDIVyMOD5();  // le quito los puntos respectivos a sus segundos 

            if ((tiempo5DIVyMOD >= 0) && (Convert.ToInt32(lblpunteoN5DyM.Text) > 0) && (Convert.ToInt32(lblpunteoN5DyM.Text) >= punteminDyM2_5)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN5DyM.Text = tiempoDyM1.ToString();

            }
            else
            {
                // si la condicion no se cumple el usuario perdera y tendra que empezar desde el nivel 1 
                timerN5DyM.Stop();
                lblpunteoN5DyM.Text = "0";
                picbN5DyM.Image = imgliDIVyMOD.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_DIV_MOD perdiste5DyM = new Niveles_DIV_MOD();
                this.Hide(); 
                perdiste5DyM.ShowDialog();
                this.Close();
            }
        }

        private void cmdresp1N5DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_DIVyMOD_Enteros = cargarultimoDIVyMOD.retornarlistaenterosDIVyMOD5(); 

            if (Nivel5_DIVyMOD_Enteros[0] == cargarultimoDIVyMOD.retonar_resultadoNDIVyMOD5())
            {
                inciarlvlDIVyMOD5();
                conteo5DIVyMOD = conteo5DIVyMOD + 1;
                lblconteoN5DyM.Text = Convert.ToString(conteo5DIVyMOD) + " /10";

                if (conteo5DIVyMOD == 10)
                {
                    timerN5DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                }
            }

            else
            {
                cmdresp1N5DyM.BackColor = Color.Red;
                tiempo5DIVyMOD -= 3;
                lbltiempoN5DyM.Text = Convert.ToString(tiempo5DIVyMOD);
                lblpunteoN5DyM.Text = cargarultimoDIVyMOD.quitarpuntosNDIVyMOD5(); 
            }
        }

        private void cmdresp2N5DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_DIVyMOD_Enteros = cargarultimoDIVyMOD.retornarlistaenterosDIVyMOD5();

            if (Nivel5_DIVyMOD_Enteros[1] == cargarultimoDIVyMOD.retonar_resultadoNDIVyMOD5())
            {
                inciarlvlDIVyMOD5();
                conteo5DIVyMOD = conteo5DIVyMOD + 1;
                lblconteoN5DyM.Text = Convert.ToString(conteo5DIVyMOD) + " /10";

                if (conteo5DIVyMOD == 10)
                {
                    timerN5DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                }
            }

            else
            {
                cmdresp2N5DyM.BackColor = Color.Red;
                tiempo5DIVyMOD -= 3;
                lbltiempoN5DyM.Text = Convert.ToString(tiempo5DIVyMOD);
                lblpunteoN5DyM.Text = cargarultimoDIVyMOD.quitarpuntosNDIVyMOD5();
            }
        }

        private void cmdresp3N5DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_DIVyMOD_Enteros = cargarultimoDIVyMOD.retornarlistaenterosDIVyMOD5();

            if (Nivel5_DIVyMOD_Enteros[2] == cargarultimoDIVyMOD.retonar_resultadoNDIVyMOD5())
            {
                inciarlvlDIVyMOD5();
                conteo5DIVyMOD = conteo5DIVyMOD + 1;
                lblconteoN5DyM.Text = Convert.ToString(conteo5DIVyMOD) + " /10";

                if (conteo5DIVyMOD == 10)
                {
                    timerN5DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                }
            }

            else
            {
                cmdresp3N5DyM.BackColor = Color.Red;
                tiempo5DIVyMOD -= 3;
                lbltiempoN5DyM.Text = Convert.ToString(tiempo5DIVyMOD);
                lblpunteoN5DyM.Text = cargarultimoDIVyMOD.quitarpuntosNDIVyMOD5();
            }
        }

        private void cmdresp4N5DyM_Click(object sender, EventArgs e)
        {
            List<int> Nivel5_DIVyMOD_Enteros = cargarultimoDIVyMOD.retornarlistaenterosDIVyMOD5();

            if (Nivel5_DIVyMOD_Enteros[3] == cargarultimoDIVyMOD.retonar_resultadoNDIVyMOD5())
            {
                inciarlvlDIVyMOD5();
                conteo5DIVyMOD = conteo5DIVyMOD + 1;
                lblconteoN5DyM.Text = Convert.ToString(conteo5DIVyMOD) + " /10";

                if (conteo5DIVyMOD == 10)
                {
                    timerN5DyM.Stop();
                    MessageBox.Show("Felicidades has temrinado", "Nivel 5_Suma");
                    Menu_de_Mundos regresoMPEleccion = new Menu_de_Mundos();
                    this.Close();
                    regresoMPEleccion.Show();
                }
            }

            else
            {
                cmdresp4N5DyM.BackColor = Color.Red;
                tiempo5DIVyMOD -= 3;
                lbltiempoN5DyM.Text = Convert.ToString(tiempo5DIVyMOD);
                lblpunteoN5DyM.Text = cargarultimoDIVyMOD.quitarpuntosNDIVyMOD5();
            }
        }
    }
}
