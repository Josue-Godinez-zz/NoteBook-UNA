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
    public partial class NotebookProfileForm : Form
    {
        bool editProfile = false;
        bool seePassword = false;
        public NotebookProfileForm()
        {
            InitializeComponent();
            helpDeleteToolTip.SetToolTip(deleteButton, "Eliminar Actual Usuario");
            helpDeleteToolTip.ToolTipTitle = "Eliminar";
            helpEditToolTip.SetToolTip(editButton, "Editar Datos De Usuario");
            helpEditToolTip.ToolTipTitle = "Editar";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(editProfile != true)
            {
                editProfile = true;
                nameUserTextBox.Enabled = true;
                passwordUserTextBox.Enabled = true;
            }
            else
            {
                editProfile = false;
                nameUserTextBox.Enabled = false;
                passwordUserTextBox.Enabled = false;
            }
        }

        private void passwordUserTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!seePassword)
            {
                passwordUserTextBox.PasswordChar = (char)0;
                seePassword = !seePassword;
            }
            else
            {
                passwordUserTextBox.PasswordChar = '*';
                seePassword = !seePassword;
            }
        }
    }
}
