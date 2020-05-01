using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Hotel
{
        public partial class Cliente1 : Form
    {
        Valorestadia myValorestadia = new Valorestadia();
        public Cliente1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro_Usuario frm4 = new Registro_Usuario();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cotizar_Total_Click(object sender, EventArgs e)
        {
            //txt_TotalEstadía.Text = myValorestadia.CalcularAlojamiento();
        }
    }
}
