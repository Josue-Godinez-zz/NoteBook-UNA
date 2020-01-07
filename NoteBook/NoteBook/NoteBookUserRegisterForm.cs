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
    public partial class NoteBookUserRegisterForm : Form
    {
        private List<String> users;

        public NoteBookUserRegisterForm()
        {
            InitializeComponent();
            users = new List<string>();
        }
        public NoteBookUserRegisterForm(List<User> users)
        {
            InitializeComponent();
            this.users = new List<string>();
            for (int x = 0; x < users.Count; x++)
            {
                User aux = users[x];
                this.users.Add(aux.NameUser);
            }

        }

        private void NameUserTextBox_Leave(object sender, EventArgs e)
        {
            BookNameVerication();
        }

        private bool BookNameVerication()
        {
            bool condition = false;
            if (users.Contains(NameUserTextBox.Text))
            {
                VerificationErrorProvider.SetError(NameUserTextBox, "El Usuario Ya Existe");
                ErrorLabel.Text = VerificationErrorProvider.GetError(NameUserTextBox);
                condition = false;
            }
            else if (NameUserTextBox.TextLength == 0)
            {
                VerificationErrorProvider.SetError(NameUserTextBox, "Campo Requerido");
                ErrorLabel.Text = VerificationErrorProvider.GetError(NameUserTextBox);
                condition = false;
            }
            else
            {
                VerificationErrorProvider.SetError(NameUserTextBox, "");
                ErrorLabel.Text = VerificationErrorProvider.GetError(ConfirmationPasswordTextBox);
                condition = true;
            }
            return condition;
        }

        private void ConfirmationPasswordTextBox_Leave(object sender, EventArgs e)
        {
            BookConfirmationPasswordValidation();
        }
        private bool BookConfirmationPasswordValidation()
        {
            bool condition = false;
            if (ConfirmationPasswordTextBox.TextLength == 0)
            {
                VerificationErrorProvider.SetError(ConfirmationPasswordTextBox, "Campo Requerido");
                ErrorLabel.Text = VerificationErrorProvider.GetError(PasswordUserTextBox);
                condition = false;
            }
            else if (PasswordUserTextBox.Text != ConfirmationPasswordTextBox.Text)
            {
                VerificationErrorProvider.SetError(ConfirmationPasswordTextBox,"Contraseñas Distintas");
                ErrorLabel.Text = VerificationErrorProvider.GetError(ConfirmationPasswordTextBox);
                condition = false;
            }
            else
            {
                VerificationErrorProvider.SetError(ConfirmationPasswordTextBox, "");
                ErrorLabel.Text = VerificationErrorProvider.GetError(PasswordUserTextBox);
                condition = true;
            }
            return condition;
        }

        private void PasswordUserTextBox_Leave(object sender, EventArgs e)
        {
            BookPasswordValidation();
        }
        private bool BookPasswordValidation()
        {
            bool condition = false; ;
            if (ConfirmationPasswordTextBox.TextLength == 0)
            {
                VerificationErrorProvider.SetError(ConfirmationPasswordTextBox, "Campo Requerido");
                ErrorLabel.Text = VerificationErrorProvider.GetError(ConfirmationPasswordTextBox);
                condition = false;
            }
            else
            {
                VerificationErrorProvider.SetError(ConfirmationPasswordTextBox, "");
                ErrorLabel.Text = "";
                condition = true;
            }
            return condition;
        }



        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if (NameUserTextBox.TextLength == 0 && PasswordUserTextBox.TextLength == 0)
            {
                VerificationErrorProvider.SetError(PasswordUserTextBox, "Campos Requeridos");
                VerificationErrorProvider.SetError(NameUserTextBox, "Campos Requeridos");
                ErrorLabel.Text = VerificationErrorProvider.GetError(NameUserTextBox);
            }
            else if (BookConfirmationPasswordValidation() && BookNameVerication() && BookPasswordValidation())
            {
                DialogResult respuesta = MessageBox.Show("Desea Crear Usuario Nuevo?", "Nuevo usuario", MessageBoxButtons.YesNo);
                switch (respuesta)
                {
                    case DialogResult.Yes:
                        newUser();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void newUser()
        {
            User user = new User();
            user.NameUser = NameUserTextBox.Text;
            user.PasswordUser = PasswordUserTextBox.Text;
            NewUser = user;
            DialogResult = DialogResult.OK;
            ActivityRegister.Instance.SaveData(user.NameUser,"Nuevo Usuario", "Creacion De Nuevo Usuario", "");
            this.Close();
        }

        public User NewUser
        {
            get;
            set;
        }
    }
}
