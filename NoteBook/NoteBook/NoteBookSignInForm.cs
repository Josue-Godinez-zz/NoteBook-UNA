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
    public partial class NoteBookSignInForm : Form
    {
        List<User> users;
        int user;
        public NoteBookSignInForm()
        {
            InitializeComponent();
        }
        public NoteBookSignInForm(List<User>users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void nameUserTextBox_Leave(object sender, EventArgs e)
        {
            BookNameUserValidation();
        }

        private bool BookNameUserValidation()
        {
            bool condition = false;
            if (nameUserTextBox.TextLength == 0)
            {
                verificationErrorProvider.SetError(nameUserTextBox, "Campo Requerido");
                errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                condition = false;
            }
            else
            {
                for (int x = 0; x < users.Count; x++)
                {
                    if (nameUserTextBox.Text != users[x].NameUser)
                    {
                        verificationErrorProvider.SetError(nameUserTextBox, "Usuario No Existe");
                        errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                        condition = false;
                    }
                    else
                    {
                        verificationErrorProvider.SetError(nameUserTextBox, "");
                        errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                        condition = true;
                        user = x;
                        break;
                    }
                }
            }
            return condition;
        }

        private void passwordUserTextBox_Leave(object sender, EventArgs e)
        {
            BookPasswordUserValidation();
        }

        private bool BookPasswordUserValidation()
        {
            bool condition = false;
            if (BookNameUserValidation())
            {
                if (passwordUserTextBox.TextLength == 0)
                {
                    verificationErrorProvider.SetError(passwordUserTextBox, "Campo Requerido");
                    errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                    condition = false;
                }
                else
                {
                    if (passwordUserTextBox.Text != users[user].PasswordUser)
                    {
                        verificationErrorProvider.SetError(passwordUserTextBox, "Contraseña Incorrecta");
                        errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                        condition = false;
                    }
                    else
                    {
                        verificationErrorProvider.SetError(passwordUserTextBox, "");
                        errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                        condition = true;
                    }
                }
            }
            else
            {
                verificationErrorProvider.SetError(passwordUserTextBox, "");
                errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                condition = true;
            }
            return condition;
        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            if(BookNameUserValidation() && BookPasswordUserValidation())
            {
                if(users[user].NameUser == nameUserTextBox.Text && users[user].PasswordUser == passwordUserTextBox.Text)
                {
                    User = users[user];
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public User User
        {
            get;
            set;
        }
    }
}
