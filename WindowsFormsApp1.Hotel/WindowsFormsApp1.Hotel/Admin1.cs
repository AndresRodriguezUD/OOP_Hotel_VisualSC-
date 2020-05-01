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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo_Hotel frm8 = new Nuevo_Hotel();
            frm8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nueva__Sucursal frm9 = new Nueva__Sucursal();
            frm9.Show();
        }
    }
}
