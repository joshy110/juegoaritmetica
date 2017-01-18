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
    public partial class Niveles_Opera_Logicos : Form
    {
        Classe_Operaciones_Logicas cargarnivelesOL1 = new Classe_Operaciones_Logicas();
        int conteoOL1 = 1, tiempoOL1 = 60, punteomaxOL1 = 100000;
        public Niveles_Opera_Logicos()
        {
            //Constructor, primer meotdo que se ejecuta cuando se ejecuta la clase
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            lblconteoN1OL.Text = " /10"; /*al inicar el nivel simepre saldra sin nada*/
        }
        public void iniciarlvl1OL()
        {
            cargarnivelesOL1.generarLvl1(); /*cargo el nivel de las operaciones lógicas */

            // regreso los valores a la label de la operación 
            lbloperacionN1OL.Text = "" + Convert.ToString(cargarnivelesOL1.retornara()) + "  >  " + Convert.ToString(cargarnivelesOL1.retornarb()) +
                                     " o  " + Convert.ToString(cargarnivelesOL1.retornarc()) + "  >  " + Convert.ToString(cargarnivelesOL1.retornard());

            /*los botones los podre  como cadnea para poder hacer click sobre ellos y les agrege color transparente*/

            cmdVerdadero.Text = "" + Convert.ToString(cargarnivelesOL1.retornara()) + "  >  " + Convert.ToString(cargarnivelesOL1.retornarb()) +
                                     " o  " + Convert.ToString(cargarnivelesOL1.retornarc()) + "  >  " + Convert.ToString(cargarnivelesOL1.retornard());
            cmdVerdadero.BackColor = Color.Transparent;

            cmdFalso.Text = "" + Convert.ToString(cargarnivelesOL1.retornara()) + "  <  " + Convert.ToString(cargarnivelesOL1.retornarb()) +
                                     " o  " + Convert.ToString(cargarnivelesOL1.retornarc()) + "  <  " + Convert.ToString(cargarnivelesOL1.retornard());
            cmdFalso.BackColor = Color.Transparent;
        }
        private void cmdiniciarN1_Click_1(object sender, EventArgs e)
        {
            /*regreso el void donde estan el retorno de mi clase OL*/
            iniciarlvl1OL();

            /*activo los botones para que el usuario pueda jugar */
            cmdVerdadero.Enabled = true;
            cmdFalso.Enabled = true;

            lblconteoN1OL.Text = "1/10"; // le asigno al conteo que empieze con 1 ya que desde que el usuario da click en inicio saldra la primera operación
            timerN1OPL.Start(); // empiezo el timer 
            lblpunteoN1OL.Text = Convert.ToString(punteomaxOL1);// le asigno el punto a la label 

            /*asignatr los metodos de las variables de als clases a unas variables dentro de la forma para poder 
             compararlas */

        }
        private void timerN1OPL_Tick_1(object sender, EventArgs e)
        { // preparo el tiempo, estrellas y si pierde el mensaje de que perdio.
            
            int punteminOl1 = 50000, limiinfeOl1 = 0, limeinfeOL2 = 0, AOL1 = 0, limiinfeOL3 = 0, limesupeOL1 = 0, limesupeOL2 = 0, limisupeOL3 = 0;

            AOL1 = (punteomaxOL1 - punteminOl1) / 3;  // obtengo A, variable con la cual hare que todo lo demas funcione 
            //obtengo los limites inferiores 
            limiinfeOl1 = punteminOl1;
            limeinfeOL2 = punteminOl1 + AOL1;
            limiinfeOL3 = punteminOl1 + (2 * AOL1);
            //obtengo los limites superiores 
            limesupeOL1 = (punteminOl1 + AOL1) - 1;
            limesupeOL2 = ((punteminOl1 + (2 * AOL1)) - 1);
            limisupeOL3 = punteomaxOL1;

            //condiciono los intervalos entre del limite inferior y el limite superior
            if ((Convert.ToInt32(lblpunteoN1OL.Text) >= limiinfeOl1) && (Convert.ToInt32(lblpunteoN1OL.Text) <= limesupeOL1))
            {
                picestreOLN1.Image = imLOL1.Images[1]; // si se cumple la condicion anterior obtendra 1 estrella 
            }
            else
            {
                picestreOLN1.Image = imLOL1.Images[0]; // si no se cumple, por ser la ultima estrella, perdera sus estrellas y por ende el juego 
            }
            if ((Convert.ToInt32(lblpunteoN1OL.Text) >= limeinfeOL2) && (Convert.ToInt32(lblpunteoN1OL.Text) <= limesupeOL2))
            {
                picestreOLN1.Image = imLOL1.Images[2]; // si se cumple esta condicion el jugador obtendra 2 estrellas 
            }
            if ((Convert.ToInt32(lblpunteoN1OL.Text) >= limiinfeOL3) && (Convert.ToInt32(lblpunteoN1OL.Text) <= limisupeOL3))
            {
                picestreOLN1.Image = imLOL1.Images[3]; // si el usuario es muy pro obtendra 3 estrellas
            }

            tiempoOL1--; // le resto 1 segundo al tiempo que incia en 60 segundos 
            lblpunteoN1OL.Text = cargarnivelesOL1.punteos_SegundosN1OL(); // le quito los puntos respectivos a sus segundos 

            if ((tiempoOL1 >= 0) && (Convert.ToInt32(lblpunteoN1OL.Text) > 0) && (Convert.ToInt32(lblpunteoN1OL.Text) >= punteminOl1)) // realizo la conidcion para parar el tiempo en dado caso el usuario perdiera 
            {
                lbltiempoN1OL.Text = tiempoOL1.ToString();
            }
            else
            {
                // si la condicion no se cumple el usuario perdera 
                timerN1OPL.Stop();
                lblpunteoN1OL.Text = "0";
                picestreOLN1.Image = imLOL1.Images[0];
                MessageBox.Show("Lo siento ha perdido, vuelva a intentarlo");
                Niveles_Opera_Logicos perdiste1OL = new Niveles_Opera_Logicos();
                this.Hide();
                perdiste1OL.ShowDialog();
                this.Close();

            }
        }

        private void cmdVerdadero_Click(object sender, EventArgs e)
        {
            if (cmdVerdadero.Text == lbloperacionN1OL.Text) // realizo la validación 
            {
                iniciarlvl1OL(); // genero los numero aleatorios 
                conteoOL1 = conteoOL1 + 1;
                lblconteoN1OL.Text = Convert.ToString(conteoOL1) + " /10"; 
                if (conteoOL1 == 10)
                {
                    MessageBox.Show("Felicidades has pasado al siguiente nivel", "Nivel 1"); // se muestra el mensaje de que gano 
                    cmdinicioN2OL.Enabled = true; // habilito el boton del lvl 2 
                    TbcOL.SelectedIndex = 1; // se pasa a la siguiente tab
                }
            }
            else
            {// en caso dado la tuviera mala perdera 3 segundos y cierta cantidad de puntso 
                cmdVerdadero.BackColor = Color.Red;
                tiempoOL1 -= 3;
                lbltiempoN1OL.Text = Convert.ToString(tiempoOL1);
                lblpunteoN1OL.Text = cargarnivelesOL1.quitarpuntosN1OL();
            }
        }

        private void cmdFalso_Click(object sender, EventArgs e)
        {
            if (cmdFalso.Text != lbloperacionN1OL.Text) // si no es igual a lo que esta representado se le iran quitando puntos y 3 segundos 
            {
                iniciarlvl1OL();
                conteoOL1 = conteoOL1 + 1;
                lblconteoN1OL.Text = Convert.ToString(conteoOL1) + " /10"; // el conteo va ir aumentando de uno en uno 
                cmdFalso.BackColor = Color.Red;
                tiempoOL1 -= 3;
                lbltiempoN1OL.Text = Convert.ToString(tiempoOL1);
                lblpunteoN1OL.Text = cargarnivelesOL1.quitarpuntosN1OL();
                if (conteoOL1 == 10)
                {// es muy dificil que termine en falso pero puede pasar 
                    MessageBox.Show("Felicidades has pasado al siguiente nivel", "Nivel 1");
                    cmdinicioN2OL.Enabled = true;
                    TbcOL.SelectedIndex = 1;
                }



            }
        }
    }
}
