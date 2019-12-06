using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fPrincipal auxiliar = new fPrincipal();
            interfazCategorias aux = new interfazCategorias();
            aux.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            interfazRegistro emergente = new interfazRegistro();
            emergente.Show();
        }
    }
}
