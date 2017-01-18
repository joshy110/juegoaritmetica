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
    public partial class Menu_Inicio : Form
    {
        // se llama a la clae del jugador
        Clase_Jugador Jugador1;
        Clase_Jugador Jugador2;
        Clase_Jugador Jugador3;
        public Menu_Inicio()
        {
            InitializeComponent();
            Jugador1 = new Clase_Jugador(); // la inicio cuando inicia el programa es decir se carga la clase jugador 
            Jugador2 = new Clase_Jugador();
            Jugador3 = new Clase_Jugador();
        }

        private void cmdjuenovo_Click(object sender, EventArgs e)
        {
            // cuando se hace click sobre juego nuevo se deshabilita este y se habilitan los demas. 
            cmdjuenovo.Enabled = false; 
            txtnomju1.Visible = true;
            txtnomju2.Visible = true;
            txtnomju3.Visible = true;
            cmdingreju1.Visible = true;
            cmdingreju2.Visible = true;
            cmdingreju3.Visible = true;
            
        }
        private void cmdingreju_Click(object sender, EventArgs e)
        {
            Jugador1.guardardatos(txtnomju1.Text); // el usuario ingresara datos 
            if(txtnomju1.Text == "") // si no ingresa nada aparecera un mensaje 
            {
                MessageBox.Show("Ingrese bien sus datos"); 
            }
            else // si si ingresa el juego continua normalmente 
            {
                lbltextoselec.Visible = true;
                radbtJug1.Visible = true;
                radbtJug1.Text = Jugador1.get_nombre();
            }
        }
        private void cmdingreju2_Click(object sender, EventArgs e)
        {
            Jugador2.guardardatos(txtnomju2.Text); // lo mismo que el ingreso de datos del usuario 1 
            if (txtnomju2.Text == "")
            {
                MessageBox.Show("Ingrese bien sus datos");
            }
            else
            {
                lbltextoselec.Visible = true;
                radbtJug2.Visible = true;
                radbtJug2.Text = Jugador2.get_nombre();
            }
            
        }
        private void cmdingreju3_Click(object sender, EventArgs e)
        {
            // sucede lo mismo que en los otros dos ingresos de usuario 
            Jugador3.guardardatos(txtnomju3.Text);
            if (txtnomju3.Text == "")
            {
                MessageBox.Show("Ingrese bien sus datos");
            }
            else
            {
                lbltextoselec.Visible = true;
                radbtJug3.Visible = true;
                radbtJug3.Text = Jugador3.get_nombre();
            }
        }
        /*en el evento de los radiobuttons valido el boton de guardar datos */
        private void radbtJug1_CheckedChanged(object sender, EventArgs e)
        {
            cmdguaju.Enabled = true; // si el usuario selecciona el rad boton 1 se habulita el boton guardar. 
        }
        private void radbtJug2_CheckedChanged(object sender, EventArgs e)
        {
            cmdguaju.Enabled = true; 
        }

        private void radbtJug3_CheckedChanged(object sender, EventArgs e)
        {
            cmdguaju.Enabled = true;
        }       
        /*Cuando el usuario haga click en el bóton guardar todo lo anterior como jugadores, radio buttons y crear usuario desaparece*/
        private void cmdguaju_Click(object sender, EventArgs e)
        {
            LblTitulo.Visible = true;
            cmdinicio.Visible = true;
            cmdregresoele.Visible = true; 

            // se deshabilita los demas botones es decir los hago no visibles al usuario 
            cmdingreju1.Visible = false; 
            lbltextoselec.Visible= false;
            radbtJug1.Visible = false;
            txtnomju1.Visible = false; 

            cmdingreju2.Visible = false; 
            lbltextoselec.Visible = false;
            radbtJug2.Visible= false;
            txtnomju2.Visible = false; 

            cmdingreju3.Visible = false; 
            lbltextoselec.Visible = false;
            radbtJug3.Visible = false;
            txtnomju3.Visible = false; 

            // ahora se deshabilita el boton guardar 
            cmdguaju.Visible = false; 

        }

        private void cmdinicio_Click(object sender, EventArgs e)
        {
            // luego de haber guardado los datos del usuario el podra iniciar el juego 
            Menu_de_Mundos cargareljuego = new Menu_de_Mundos();
            if (radbtJug1.Checked == true) // si el usuario inicio con el radio boton 1 la label dentro del Menu princial aparecera con este nombre. 
            {

                cargareljuego.lblNomJugaMP.Text = " usuario: " + radbtJug1.Text;
            }
                else  if (radbtJug2.Checked == true) // sino parecera con el nombre del rad botono 2 
                     {
                         cargareljuego.lblNomJugaMP.Text = " usuario: " + radbtJug2.Text;    
                     }
            else
            {
                cargareljuego.lblNomJugaMP.Text = " usuario: " + radbtJug3.Text; // y si inicara con el ultimo la label del Menu principoal aparecera con el nombre de la rad boton3 
            }
            
            this.Hide();
            cargareljuego.ShowDialog();  
            this.Close(); 
        }

        private void cmdregresoele_Click(object sender, EventArgs e)
        {
            // con este boton vuelvo a habilitar los botones donde el usuario ingresa datos y hago no visibles el boton inicio, 
            // el titulo kings of maths y este mimso. es decir lo contrario al boton guardar 
            LblTitulo.Visible = false;
            cmdinicio.Visible = false;
            cmdregresoele.Visible = false;

            // se deshabilita los demas botones es decir los hago no visibles al usuario 
            cmdingreju1.Visible = true;
            lbltextoselec.Visible = true;
            txtnomju1.Visible = true; 
            
            cmdingreju2.Visible = true;
            lbltextoselec.Visible = true;
            txtnomju2.Visible = true; 

            cmdingreju3.Visible = true;
            lbltextoselec.Visible = true;
            txtnomju3.Visible = true;

            // tambien se hace visible le boton guardar pero no se habilita 
            cmdguaju.Visible = true;
            cmdguaju.Enabled = true;
        }

        private void Menu_Inicio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a King of Maths", "Inicio"); 
        }
    }
}
