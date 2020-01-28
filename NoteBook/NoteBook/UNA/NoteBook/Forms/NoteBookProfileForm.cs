using NoteBook.UNA.NoteBook.Seguridad;
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
        }
        public NoteBookProfileForm(User user, int cantidad_libros)
        {
            InitializeComponent();
            helpDeleteToolTip.SetToolTip(DeleteButton, "Eliminar Actual Usuario");
            helpDeleteToolTip.ToolTipTitle = "Eliminar";
            helpEditToolTip.SetToolTip(EditButton, "Editar Datos De Usuario");
            helpEditToolTip.ToolTipTitle = "Editar";
            NameLabel.Text = user.Name+" "+user.LastName;
            NameUserLabel.Text = user.NameUser;
            DatoLabel.Text = "Posees "+cantidad_libros+ " libros en total";
            User = user;
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
                PasswordUserTextBox.Enabled = true;
            }
            else
            {
                if(User.PasswordUser != PasswordUserTextBox.Text)
                {
                    DialogResult result = MessageBox.Show("Deseas Cambiar Contraseña?","Cambio De Contraseña",MessageBoxButtons.YesNo);
                    switch(result)
                    {
                        case DialogResult.Yes: User.PasswordUser = PasswordUserTextBox.Text;
                            MySqlService.Instance.ModificarContraseña(User);
                            ActivityRegister.Instance.SaveData(User.NameUser,"Perfil Usuario", "Cambio de Contraseña","");
                            break;
                        case DialogResult.No: PasswordUserTextBox.Text = User.PasswordUser;
                            break;
                    }
                }
                editProfile = false;
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