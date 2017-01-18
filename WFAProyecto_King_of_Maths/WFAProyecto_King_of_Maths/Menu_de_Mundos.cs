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
   
    public partial class Menu_de_Mundos : Form
    {
       
        public Menu_de_Mundos()
        {
            InitializeComponent();
        }

        private void cmdMundoSuma_Click(object sender, EventArgs e)
        {// llamo al mundo facil el cual es la suma 
            Niveles_SUMA cargarNxS = new Niveles_SUMA();
            this.Hide();
            cargarNxS.ShowDialog();
            this.Show(); 
        }

        private void Menu_de_Mundos_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Elija el Mundo en que desea jugar", "Menu Principal"); 
        }

        private void cmdMundoResta_Click(object sender, EventArgs e)
        {// llamo al mundo de la resta 
            Niveles_RESTA cargarNxRTB = new Niveles_RESTA();
            this.Hide();
            cargarNxRTB.ShowDialog();
            this.Show();
        }

        private void cmdMundoMultipli_Click(object sender, EventArgs e)
        {// lamo al mundo de multiplicación 
            Niveles_MULTIPLICACION cargarnivelesM = new Niveles_MULTIPLICACION();
            this.Hide();
            cargarnivelesM.ShowDialog();
            this.Show(); 
        }

        private void cmdMundoDivis_Click(object sender, EventArgs e)
        {// llamo al mundo de Divis 
            Niveles_DIVISION llamarNDIVIs = new Niveles_DIVISION(); 
            this.Hide();
            llamarNDIVIs.ShowDialog();
            this.Show(); 
        }

        private void cmdOpLogi_Click(object sender, EventArgs e)
        {// llamo al mundo de operaciones lógicas
            Niveles_Opera_Logicos llamarMuOPL = new Niveles_Opera_Logicos();  
            this.Hide();
            llamarMuOPL.ShowDialog();
            this.Show(); 
        }

        private void cmdMundoOpDesi_Click(object sender, EventArgs e)
        {// se dirige al mundo de Operaciones de desigualdad el cual no he logrado temrinar y dudo podre hacerlo ya que no se como
            Niveles_Opera_Desigua llamarMuDesi = new Niveles_Opera_Desigua(); 
            this.Hide();
            llamarMuDesi.ShowDialog();
            this.Show(); 
        }

        private void cmdMundoDIVyMOD_Click(object sender, EventArgs e)
        { // se dirige al mundo de DIv y MOD
            Niveles_DIV_MOD llamarMuDIVyMOD = new Niveles_DIV_MOD();
            this.Hide(); 
            llamarMuDIVyMOD.ShowDialog();
            this.Show(); 
        }

        private void cmdSalirJuego_Click(object sender, EventArgs e)
        {
            // se hara un dialog result en el cual si el usuario da ok o aceptar la aplicación se saldra de lo contrario se mostrara otra vez. 
            DialogResult segusalir = new DialogResult(); 
            segusalir = MessageBox.Show(" ¿Está seguro que desea salir? ", "Kings of Maths", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); // s emuestra el mensaje y los botones de aceptar o cancerlar( ok or cancel)
            if (segusalir == DialogResult.OK)
            {
                this.Close();
            }
            else 
            {
                Menu_de_Mundos regremostra = new Menu_de_Mundos(); 
                this.Hide();
                regremostra.ShowDialog();
                this.Show(); 
            }
        }

        private void cmdEstadistica_Click(object sender, EventArgs e)
        {
            Estadisticas_Usuario mostrarEstadisticaU = new Estadisticas_Usuario(); 
            mostrarEstadisticaU.lblNJuEstadi.Text = lblNomJugaMP.Text; // muestro el nombre del usuario en la forma de estadistica
            this.Hide();
            mostrarEstadisticaU.ShowDialog();
            this.Show(); 
        }
    }
}
