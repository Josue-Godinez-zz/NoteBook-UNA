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
        readonly List<User> users;
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

        private void NameUserTextBox_Leave(object sender, EventArgs e)
        {
            BookNameUserValidation();
        }

        private bool BookNameUserValidation()
        {
            bool condition = false;
            if (NameUserTextBox.TextLength == 0)
            {
                verificationErrorProvider.SetError(NameUserTextBox, "Campo Requerido");
                errorLabel.Text = verificationErrorProvider.GetError(NameUserTextBox);
                condition = false;
            }
            else
            {
                for (int x = 0; x < users.Count; x++)
                {
                    if (NameUserTextBox.Text != users[x].NameUser)
                    {
                        verificationErrorProvider.SetError(NameUserTextBox, "Usuario No Existe");
                        errorLabel.Text = verificationErrorProvider.GetError(NameUserTextBox);
                        condition = false;
                    }
                    else
                    {
                        verificationErrorProvider.SetError(NameUserTextBox, "");
                        errorLabel.Text = verificationErrorProvider.GetError(NameUserTextBox);
                        condition = true;
                        user = x;
                        break;
                    }
                }
            }
            return condition;
        }

        private void PasswordUserTextBox_Leave(object sender, EventArgs e)
        {
            BookPasswordUserValidation();
        }

        private bool BookPasswordUserValidation()
        {
            bool condition = false;
            if (BookNameUserValidation())
            {
                if (PasswordUserTextBox.TextLength == 0)
                {
                    verificationErrorProvider.SetError(PasswordUserTextBox, "Campo Requerido");
                    errorLabel.Text = verificationErrorProvider.GetError(PasswordUserTextBox);
                    condition = false;
                }
                else
                {
                    if (PasswordUserTextBox.Text != users[user].PasswordUser)
                    {
                        verificationErrorProvider.SetError(PasswordUserTextBox, "Contraseña Incorrecta");
                        errorLabel.Text = verificationErrorProvider.GetError(PasswordUserTextBox);
                        condition = false;
                    }
                    else
                    {
                        verificationErrorProvider.SetError(PasswordUserTextBox, "");
                        errorLabel.Text = verificationErrorProvider.GetError(PasswordUserTextBox);
                        condition = true;
                    }
                }
            }
            else
            {
                verificationErrorProvider.SetError(PasswordUserTextBox, "");
                errorLabel.Text = verificationErrorProvider.GetError(PasswordUserTextBox);
                condition = true;
            }
            return condition;
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if(BookNameUserValidation() && BookPasswordUserValidation())
            {
                if(users[user].NameUser == NameUserTextBox.Text && users[user].PasswordUser == PasswordUserTextBox.Text)
                {
                    User = users[user];
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.No;
        }
        public User User
        {
            get;
            set;
        }
    }
}
