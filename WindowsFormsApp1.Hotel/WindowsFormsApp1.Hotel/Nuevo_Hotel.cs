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
    public partial class Nuevo_Hotel : Form
    {
        public Nuevo_Hotel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nueva__Sucursal frm10 = new Nueva__Sucursal();
            frm10.Show();
        }
    }
}
