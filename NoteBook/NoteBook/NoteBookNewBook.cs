using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class NoteBookNewBookForm : Form
    {
        public NoteBookNewBookForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string direccionImagen = Path.Combine(Application.StartupPath, @"Resource\iconfinder_Soccer_2138356.png");
            iconPictureBox.Load(direccionImagen);
        }

        private void changeImage(int index)
        {

        }
    }
}
