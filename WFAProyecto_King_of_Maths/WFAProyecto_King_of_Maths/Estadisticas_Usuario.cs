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
    public partial class Estadisticas_Usuario : Form
    {
        public Estadisticas_Usuario()
        {
            InitializeComponent();
        }

        private void cmdRMEM_Click(object sender, EventArgs e)
        {
            Menu_de_Mundos regresoMuEsta = new Menu_de_Mundos();
            this.Close();
            regresoMuEsta.Show(); 
        }

        private void Estadisticas_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void Estadisticas_Usuario_Activated(object sender, EventArgs e)
        {

        }
    }
}