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
    public partial class Cita : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        public Cita()
        {
            InitializeComponent();
        }
        
        void populate()
        {
            Con.Open();
            string query = "Select * from Cita";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CitaGV.DataSource = ds.Tables[0];
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
            if (Id_Cita.Text == "" || Id_Doctor.Text == "" || Id_Paciente.Text == "" || Nombre_Paciente.Text == "" || Telefono_Cliente.Text == ""|| Fecha_Turno.Text=="" )       
            {
                MessageBox.Show("No se aceptan campos vacio");
            }

            else
            {
                Con.Open();
                String query = "insert into Cita values(" + Id_Cita.Text + ",'" + Id_Doctor.Text + "' ,'" + Id_Paciente.Text + "','" + Nombre_Paciente.Text + "','" + Telefono_Cliente.Text + "','" + Motivo.SelectedItem.ToString() + "','"+ Estado.SelectedItem.ToString()+ "','" + Fecha_Turno.Text + "','" + Hora.SelectedItem.ToString() + "')";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cita agregada exitosamente");
                Con.Close();
                populate();
            }

        }

        private void Cita_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id_Cita.Text == "")
            {
                MessageBox.Show("Ingrese el Id_Cita");
            }
            else
            {
                Con.Open();
                string query = "delete from Cita where Id_Cita = " + Id_Cita.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cita Eliminada con exito");
                Con.Close();
                populate();
            }
        }

        private void CitaGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Cita.Text = CitaGV.SelectedRows[0].Cells[0].Value.ToString();
            Id_Doctor.Text = CitaGV.SelectedRows[0].Cells[1].Value.ToString();
            Id_Paciente.Text = CitaGV.SelectedRows[0].Cells[2].Value.ToString();
            Nombre_Paciente.Text = CitaGV.SelectedRows[0].Cells[3].Value.ToString();
            Telefono_Cliente.Text = CitaGV.SelectedRows[0].Cells[4].Value.ToString();
            Fecha_Turno.Text = CitaGV.SelectedRows[0].Cells[5].Value.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update Cita set Id_Doctor = '" + Id_Doctor.Text + "', Id_Paciente = '" + Id_Paciente.Text + "', Nombre_Paciente = '" + Nombre_Paciente.Text + "',Telefono_Cliente = '" +Telefono_Cliente.Text+"',Motivo = '" + Motivo.SelectedItem.ToString() + "', Estado = '" + Estado.SelectedItem.ToString()+ "', Fecha_Turno = '" + Fecha_Turno.Text + "', Hora = '" + Hora.SelectedItem.ToString()+ "'  where Id_Cita = " + Id_Cita.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizacion realizada con exito");
            Con.Close();
            populate();

        }
       


    }
}
