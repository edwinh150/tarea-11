using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroData
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarForm agre = new AgregarForm();

            agre.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarForm consul = new ConsultarForm();

            consul.Show();
        }
    }
}
