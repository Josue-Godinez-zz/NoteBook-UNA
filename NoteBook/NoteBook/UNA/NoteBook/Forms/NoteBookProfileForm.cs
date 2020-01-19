using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.NoteBook;

namespace NoteBook
{
    public partial class NoteBookProfileForm : Form
    {
        bool editProfile = false;
        bool seePassword = false;
        public NoteBookProfileForm()
        {
            InitializeComponent();
            helpDeleteToolTip.SetToolTip(DeleteButton, "Eliminar Actual Usuario");
            helpDeleteToolTip.ToolTipTitle = "Eliminar";
            helpEditToolTip.SetToolTip(EditButton, "Editar Datos De Usuario");
            helpEditToolTip.ToolTipTitle = "Editar";
        }
        public NoteBookProfileForm(User user)
        {
            InitializeComponent();
            helpDeleteToolTip.SetToolTip(DeleteButton, "Eliminar Actual Usuario");
            helpDeleteToolTip.ToolTipTitle = "Eliminar";
            helpEditToolTip.SetToolTip(EditButton, "Editar Datos De Usuario");
            helpEditToolTip.ToolTipTitle = "Editar";
            User = user;
            NameUserTextBox.Text = user.NameUser;
            PasswordUserTextBox.Text = user.PasswordUser;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (editProfile != true)
            {
                editProfile = true;
                NameUserTextBox.Enabled = true;
                PasswordUserTextBox.Enabled = true;
            }
            else
            {
                editProfile = false;
                NameUserTextBox.Enabled = false;
                PasswordUserTextBox.Enabled = false;
            }
        }

        private void PasswordUserTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!seePassword)
            {
                PasswordUserTextBox.PasswordChar = (char)0;
                seePassword = !seePassword;
            }
            else
            {
                PasswordUserTextBox.PasswordChar = '*';
                seePassword = !seePassword;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas seguro de eliminar usuario", "Advertencia", MessageBoxButtons.YesNo);
            switch(respuesta)
            {
                case DialogResult.Yes:
                    this.Close();
                    DialogResult = respuesta;
                    ActivityRegister.Instance.SaveData(User.NameUser,"Perfil De Usuario","Eliminacion De Usuario","");
                break;
                case DialogResult.No:
                break;
            }
        }
        public User User
        {
            get;
            set;
        }
    }
}