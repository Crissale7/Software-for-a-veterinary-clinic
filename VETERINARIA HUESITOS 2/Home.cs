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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cita t = new Cita();
            t.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Consulta m = new Consulta();
            m.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Vacuna v = new Vacuna();
            v.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            HistoriaClinica i = new HistoriaClinica();
            i.Show();
            this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Calendario A = new Calendario();
            A.Show();
            this.Hide();

        }
    }
}
