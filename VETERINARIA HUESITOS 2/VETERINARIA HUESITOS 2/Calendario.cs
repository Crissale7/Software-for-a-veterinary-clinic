using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VETERINARIA_HUESITOS_2
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            for (int f=1; f<= 96; f++) 
            {
                dataGridView1.Rows.Add();
            }
            CargarFecha();
        }
        private void CargarFecha()
        {
            DateTime Select = monthCalendar1.SelectionStart;
            label1.Text = "Fecha Seleccionada:" + Select.ToString("dd/MM/yyyy");
            string fecha = Select.Year.ToString() + Select.Month.ToString() + Select.Day.ToString();

            if (!File.Exists(fecha))
            {
                StreamWriter archivo = new StreamWriter(fecha);
                DateTime fe = DateTime.Today;
                for(int f=1; f <= 96; f++)
                {
                    archivo.WriteLine(fe.ToString("HH:mm"));
                    archivo.WriteLine("");
                    fe = fe.AddMinutes(15);
                }
                archivo.Close();
            }
            StreamReader archivo2 =new StreamReader(fecha);  
            int x = 0;
            while (!archivo2.EndOfStream)
            {
                String Linea1 = archivo2.ReadLine();
                String Linea2 = archivo2.ReadLine();
                dataGridView1.Rows[x].Cells[0].Value = Linea1;
                dataGridView1.Rows[x].Cells[1].Value = Linea2;
                x++;
            }
            archivo2.Close();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CargarFecha();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DateTime Select = monthCalendar1.SelectionStart;
            string fecha = Select.Year.ToString() + Select.Month.ToString() + Select.Day.ToString();

            StreamWriter archivo = new StreamWriter(fecha);  
            for(int f=0; f < dataGridView1.Rows.Count; f++)
            {
                archivo.WriteLine(dataGridView1.Rows[f].Cells[0].Value.ToString());
                if (dataGridView1.Rows[f].Cells[1].Value != null) 
                {
                    archivo.WriteLine(dataGridView1.Rows[f].Cells[1].Value.ToString());

                }
                else
                {
                    archivo.WriteLine("");

                }  
                    
            }
            archivo.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        
    }
}
