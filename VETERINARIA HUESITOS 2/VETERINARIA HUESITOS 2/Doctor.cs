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
    public partial class Doctor : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        public Doctor()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "Select * from Doctor";
            SqlDataAdapter da=new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds=new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
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
            if (Id_Doctor.Text == "" || Nombre_Doctor.Text == "" || Nombre_Doctor.Text == "" || Apellido_Doctor.Text == "" || Matricula.Text == "")
            {
                MessageBox.Show("No se aceptan campos vacios");
            }

            else
            {
                Con.Open();
                String query = "insert into Doctor values(" + Id_Doctor.Text + ",'" + Nombre_Doctor.Text + "' ,'" + Apellido_Doctor.Text + "','" + Matricula.Text + "')";

                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor añadido con exito");
                Con.Close();
                populate();
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Id_Doctor.Text == "")
            {
                MessageBox.Show("Ingrese el Id_Doctor");
            }
            else
            {
                Con.Open();
                string query = "delete from Doctor where Id_Doctor = " + Id_Doctor.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor eliminado con exito");
                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Doctor.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            Nombre_Doctor.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            Apellido_Doctor.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            Matricula.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query = "Update Doctor set Nombre_Doctor = '" + Nombre_Doctor.Text + "', Apellido_Doctor = '" + Apellido_Doctor.Text + "', Matricula = '" + Matricula.Text+"' where Id_Doctor = " + Id_Doctor.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizacion exitosa");
            Con.Close();
            populate();



            
                
        }
    }
}
