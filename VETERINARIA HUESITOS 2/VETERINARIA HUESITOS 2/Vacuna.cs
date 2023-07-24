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
    public partial class Vacuna : Form
    {
        public Vacuna()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "Select * from Vacuna";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            VacunaGV.DataSource = ds.Tables[0];
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
            if (Id_Vacuna.Text == "" || Id_Paciente.Text == "" || Nombre_Paciente.Text == "" || Nombre_Vacuna.SelectedItem.ToString() == "" || Fecha_de_Vacunacion.Text == ""||Fecha_de_Vencimiento.Text=="")
            {
                MessageBox.Show("No se aceptan campos vacios");
            }
            else
            {

                Con.Open();
                String query = "insert into Vacuna values(" + Id_Vacuna.Text + ",'" + Id_Paciente.Text + "' ,'" + Nombre_Paciente.Text + "','" + Nombre_Vacuna.SelectedItem.ToString() + "','" + Fecha_de_Vacunacion.Text + "'," + Fecha_de_Vencimiento.Text +")";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vacuna añadida con exito");
                Con.Close();
                populate();


            }

        }

        private void Vacuna_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id_Vacuna.Text == "")
            {
                MessageBox.Show("Ingresar el Id_Vacuna");
            }
            else
            {
                Con.Open();
                string query = "delete from Vacuna where Id_Vacuna=" + Id_Vacuna.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vacuna eliminada con exito");
                Con.Close();
                populate();
            }
        }

        private void VacunaGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Vacuna.Text = VacunaGV.SelectedRows[0].Cells[0].Value.ToString();
            Id_Paciente.Text = VacunaGV.SelectedRows[0].Cells[1].Value.ToString();
            Nombre_Paciente.Text = VacunaGV.SelectedRows[0].Cells[2].Value.ToString();
            Fecha_de_Vacunacion.Text = VacunaGV.SelectedRows[0].Cells[3].Value.ToString();
            Fecha_de_Vencimiento.Text = VacunaGV.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update Vacuna set Id_Paciente = '" + Id_Paciente.Text + "', Nombre_Paciente = '" + Nombre_Paciente.Text + "', Nombre_Vacuna = '" + Nombre_Vacuna.SelectedItem.ToString() + "', Fecha_de_Vacunacion = '" + Fecha_de_Vacunacion.Text + "', Fecha_de_Vencimiento = '" + Fecha_de_Vencimiento.Text + "' where Id_Vacuna = " + Id_Vacuna.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizacion exitosa");
            Con.Close();
            populate();
        }
    }
}
