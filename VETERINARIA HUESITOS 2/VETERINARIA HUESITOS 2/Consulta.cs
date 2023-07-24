using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VETERINARIA_HUESITOS_2
{
    public partial class Consulta : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        public Consulta()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "Select * from Consulta";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ConsultaGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Id_Consulta.Text == "" || Id_Cita.Text == "" || Id_Paciente.Text == "" || Sintomas.Text == "" || Diagnostico.Text == "" || Tratamiento.Text=="")
            {
                MessageBox.Show("No se aceptan campos vacios");
            }

            else
            {
                Con.Open();
                String query = "insert into Consulta values(" + Id_Consulta.Text + ",'" + Id_Cita.Text + "' ,'" + Id_Paciente.Text + "','" + Sintomas.Text + "','"+Diagnostico.Text+"','"+Tratamiento.Text+"')";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Consulta agregada exitosamente");
                Con.Close();
                populate();
            }

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id_Consulta.Text == "")
            {
                MessageBox.Show("Ingresar Id_Consulta");
            }
            else
            {
                Con.Open();
                string query = "delete from Consulta where Id_Consulta = " + Id_Consulta.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Consulta eliminada exitosamente");
                Con.Close();
                populate();
            }
        }

        private void ConsultaGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Consulta.Text = ConsultaGV.SelectedRows[0].Cells[0].Value.ToString();
            Id_Cita.Text = ConsultaGV.SelectedRows[0].Cells[1].Value.ToString();
            Id_Paciente.Text = ConsultaGV.SelectedRows[0].Cells[2].Value.ToString();
            Sintomas.Text = ConsultaGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnostico.Text = ConsultaGV.SelectedRows[0].Cells[4].Value.ToString();    
            Tratamiento.Text = ConsultaGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update Consulta set Id_Cita = '" + Id_Cita.Text + "', Id_Paciente = '" + Id_Paciente.Text + "', Sintomas = '" + Sintomas.Text + "', Diagnostico = '" + Diagnostico.Text + "', Tratamiento = '" + Tratamiento.Text + "' where Id_Consulta = " + Id_Consulta.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizacion exitosa ");
            Con.Close();
            populate();

        }
    }
}
