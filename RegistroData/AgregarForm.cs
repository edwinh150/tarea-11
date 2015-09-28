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
    public partial class AgregarForm : Form
    {

        public AgregarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DARLENISM\\SQLEXPRESS;Initial Catalog=Pelicula;Integrated Security=True");
            SqlCommand Comand = new SqlCommand();

            try
            {
                con.Open();
                Comand.Connection = con;
                Comand.CommandText = String.Format("Insert Into Categorias(Descripcion) Values('{0}')", AgregarrichTextBox.Text);
                Comand.ExecuteNonQuery();
                MessageBox.Show("Fue Guardado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
