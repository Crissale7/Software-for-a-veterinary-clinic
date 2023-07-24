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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ITNM\source\repos\VETERINARIA HUESITOS 2\VETERINARIA HUESITOS 2\veterinaria huesitos.mdf"";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "Select * from Cliente";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClienteGV.DataSource = ds.Tables[0];
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
            if (Id_Cliente.Text == "" || Nombre_Cliente.Text == "" || Apellido_Cliente.Text == "" || Direccion.Text == "" || Telefono_Cliente.Text == "")
            {
                MessageBox.Show("No se aceptan campos vacio");
            }
            else
            {

                Con.Open();
                String query = "insert into Cliente values(" + Id_Cliente.Text + ",'" + Nombre_Cliente.Text + "' ,'" + Apellido_Cliente.Text + "','" + Direccion.Text + "',"+Telefono_Cliente.Text+")";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado exitosamente");
                Con.Close();
                populate();


            }

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            populate();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Id_Cliente.Text == "")
            {
                MessageBox.Show("Ingrese el Id_Cliente");
            }
            else
            {
                Con.Open();
                string query = "delete from Cliente where Id_Cliente=" + Id_Cliente.Text + "";
                SqlCommand cmd = new SqlCommand (query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado exitosamente");
                Con.Close();
                populate();
            }
        }

        private void ClienteGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Cliente.Text = ClienteGV.SelectedRows[0].Cells[0].Value.ToString();
            Nombre_Cliente  .Text= ClienteGV.SelectedRows[0].Cells[1].Value.ToString();
            Apellido_Cliente.Text= ClienteGV.SelectedRows[0].Cells[2].Value.ToString();
            Direccion.Text = ClienteGV.SelectedRows[0].Cells[3].Value.ToString();
            Telefono_Cliente.Text = ClienteGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Update Cliente set Nombre_Cliente = '" + Nombre_Cliente.Text + "', Apellido_Cliente = '" + Apellido_Cliente.Text + "', Direccion = '" + Direccion.Text + "',Telefono_Cliente = '" + Telefono_Cliente.Text + "' where Id_Cliente = " + Id_Cliente.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Actualizacion exitosa ");
            Con.Close();
            populate();
        }
    }
}
