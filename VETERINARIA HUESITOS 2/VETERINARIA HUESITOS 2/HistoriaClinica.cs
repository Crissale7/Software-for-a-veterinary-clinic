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
    public partial class HistoriaClinica : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        public HistoriaClinica()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "Select * from HistoriaClinica";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            HisGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)//HOME
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//AGREGAR
        {
            if (Id_HC.Text == "" || Id_Doctor.Text == "" || Id_Cliente.Text == "" || Nombre_Cliente.Text == "" || Apellido_Cliente.Text == "" || Telefono_Cliente.Text == "" || Nombre_Paciente.Text == "" || Raza.Text == "" || Color.Text == "" || Peso.Text == "" || Id_Vacuna.Text == "" || Id_Consulta.Text == "" || Observaciones.Text == "" || Fecha.Text == "")
            {
                MessageBox.Show("No se aceptan campos vacios");
            }
            else
            {

                Con.Open();
                String query = "insert into HistoriaClinica values(" + Id_HC.Text + ",'" + Id_Doctor.Text + "' ,'" + Id_Cliente.Text + "','" + Nombre_Cliente.Text + "','" + Apellido_Cliente.Text + "','" + Telefono_Cliente.Text + "','" + Nombre_Paciente.Text + "','" + Especie.SelectedItem.ToString() + "','" + Raza.Text + "','" + Sexo.SelectedItem.ToString() + "','" + Color.Text + "','" + Tamaño.SelectedItem.ToString() + "','" + Peso.Text + "','" + Castracion.SelectedItem.ToString() + "','" + Id_Vacuna.Text + "','" + Id_Consulta.Text + "','" + Observaciones.Text + "','" + Fecha.Text + "')";


                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Historia Clinica añadido con exito");
                Con.Close();
                populate();



            }

        }

        private void HistoriaClinica_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button3_Click(object sender, EventArgs e)//eliminar
        {
            if (Id_HC.Text == "")
            {
                MessageBox.Show("Ingrese el Id_HC");
            }
            else
            {
                Con.Open();
                string query = "delete from HistoriaClinica where Id_HC = " + Id_HC.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Historia Clinica eliminada con exito");
                Con.Close();
                populate();
            }


        }

        private void HisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_HC.Text = HisGV.SelectedRows[0].Cells[0].Value.ToString();
            Id_Doctor.Text = HisGV.SelectedRows[0].Cells[1].Value.ToString();
            Id_Cliente.Text = HisGV.SelectedRows[0].Cells[2].Value.ToString();
            Nombre_Cliente.Text = HisGV.SelectedRows[0].Cells[3].Value.ToString();
            Apellido_Cliente.Text = HisGV.SelectedRows[0].Cells[4].Value.ToString();
            Telefono_Cliente.Text = HisGV.SelectedRows[0].Cells[5].Value.ToString();
            Nombre_Paciente.Text = HisGV.SelectedRows[0].Cells[6].Value.ToString();
            Raza.Text = HisGV.SelectedRows[0].Cells[7].Value.ToString();
            Color.Text = HisGV.SelectedRows[0].Cells[8].Value.ToString();
            Peso.Text = HisGV.SelectedRows[0].Cells[9].Value.ToString();
            Id_Vacuna.Text = HisGV.SelectedRows[0].Cells[10].Value.ToString();
            Id_Consulta.Text = HisGV.SelectedRows[0].Cells[11].Value.ToString();
            Observaciones.Text = HisGV.SelectedRows[0].Cells[12].Value.ToString();
            Fecha.Text = HisGV.SelectedRows[0].Cells[13].Value.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e) //modificar
        {
            Con.Open();
            string query = "Update HistoriaClinica set Id_Doctor = '" + Id_Doctor.Text + "', Id_Cliente = '" + Id_Cliente.Text + "', Nombre_Cliente = '" + Nombre_Cliente.Text + "', Apellido_Cliente = '" + Apellido_Cliente.Text + "', Telefono_Cliente = '" +Telefono_Cliente.Text + "', Nombre_Paciente = '" + Nombre_Paciente.Text + "', Especie = '" + Especie.SelectedItem.ToString() + "', Raza = '" + Raza.Text + "', Sexo = '" + Sexo.SelectedItem.ToString() + "', Color = '" + Color.Text + "', Tamaño = '" + Tamaño.SelectedItem.ToString() + "', Peso = '" + Peso.Text + "', Castracion = '" + Castracion.Text + "', Id_Vacuna = '" + Id_Vacuna.Text + "', Id_Consulta = '" + Id_Consulta.Text + "', Observaciones = '" + Observaciones.Text + "', Fecha = '" + Fecha.Text + "'  where Id_HC = " + Id_HC.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizado exitosamente");
            Con.Close();
            populate();

        }
    }
}
