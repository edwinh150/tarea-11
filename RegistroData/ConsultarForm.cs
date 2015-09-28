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

namespace RegistroData
{
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DARLENISM\\SQLEXPRESS;Initial Catalog=Pelicula;Integrated Security=True");
            SqlCommand Comand = new SqlCommand();

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                Comand.Connection = con;
                Comand.CommandText = "select * from Categorias";

                adapter = new SqlDataAdapter(Comand);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            ResultadodataGridView.DataSource = dt;
        }
    }
}
