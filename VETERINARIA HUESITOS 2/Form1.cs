using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETERINARIA_HUESITOS_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if (Usuario == "huesitos" && Contraseña == "1234")
            {
                MessageBox.Show("Bienvenido" + "," + txtUsuario.Text);

                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error!!,Usuario o Contraseña incorrectos.Ingrese nuevamente los datos por favor");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
