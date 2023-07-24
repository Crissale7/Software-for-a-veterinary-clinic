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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "Select * from Paciente";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PacienteGV.DataSource = ds.Tables[0];
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
            if (Id_Paciente.Text == "" || Id_Cliente.Text == "" || Nombre_Paciente.Text == "" || Raza.Text == "" || Peso.Text == "" || Fecha_de_Nacimiento.Text == "" || Fecha_de_Ingreso.Text == "")
            {
                MessageBox.Show("No se aceptan campos vacios");
            }
            else
            {

                Con.Open();
                String query = "insert into Paciente values(" + Id_Paciente.Text + ",'" + Id_Cliente.Text + "' ,'" + Nombre_Paciente.Text + "','" + Especie.SelectedItem.ToString() + "','" + Raza.Text + "','" + Sexo.SelectedItem.ToString() + "','" + Color.Text + "','" + Tamaño.SelectedItem.ToString() + "','" + Peso.Text + "','" + Castrado.SelectedItem.ToString() + "','" + Fecha_de_Nacimiento.Text + "','" + Fecha_de_Ingreso.Text + "')";


                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente añadido con exito");
                Con.Close();
                populate();



            }
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id_Paciente.Text == "")
            {
                MessageBox.Show("Ingrese el Id_Paciente");
            }
            else
            {
                Con.Open();
                string query = "delete from Paciente where Id_Paciente=" + Id_Paciente.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente eliminado con exito");
                Con.Close();
                populate();
            }
        }

        private void PacienteGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Paciente.Text = PacienteGV.SelectedRows[0].Cells[0].Value.ToString();
            Id_Cliente.Text = PacienteGV.SelectedRows[0].Cells[1].Value.ToString();
            Nombre_Paciente.Text = PacienteGV.SelectedRows[0].Cells[2].Value.ToString();
            Raza.Text = PacienteGV.SelectedRows[0].Cells[3].Value.ToString();
            Color.Text = PacienteGV.SelectedRows[0].Cells[4].Value.ToString();   
            Peso.Text = PacienteGV.SelectedRows[0].Cells[5].Value.ToString();
            Fecha_de_Nacimiento.Text= PacienteGV.SelectedRows[0].Cells[6].Value.ToString();
            Fecha_de_Ingreso.Text= PacienteGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update Paciente set Id_Cliente = '" + Id_Cliente.Text + "', Nombre_Paciente = '" + Nombre_Paciente.Text + "', Especie = '" + Especie.SelectedItem.ToString() + "', Raza = '" + Raza.Text + "', Sexo = '" + Sexo.SelectedItem.ToString() + "', Color = '" + Color.Text + "', Tamaño = '" + Tamaño.SelectedItem.ToString() + "', Peso = '" + Peso.Text + "', Castrado = '" + Castrado.Text + "', Fecha_de_Ingreso = '" + Fecha_de_Ingreso.Text + "' where Id_Paciente = " + Id_Paciente.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizado exitosamente");
            Con.Close();
            populate();
        }
    }
}