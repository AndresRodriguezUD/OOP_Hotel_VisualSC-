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
    public partial class Registro_Usuario : Form
    {
        Cliente myCliente = new Cliente();
        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagar frm6 = new Pagar();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void btn_Guardar_Usuario_Click(object sender, EventArgs e)
        {
            myCliente.Nombre = txt_Nombre.Text;
            myCliente.Cedula = txt_Cedula.Text;
            myCliente.Apellido = txt_Apellido.Text;
            myCliente.Genero = txt_Genero.Text;
            myCliente.Edad = txt_Edad.Text;
            myCliente.Fecha_nacimiento = txt_FechaNacimiento.Text;
            myCliente.Email = txt_Email.Text;

            MessageBox.Show("Se guardo el registro correctamente");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
