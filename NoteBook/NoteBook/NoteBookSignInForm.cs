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
        bool userName = false;
        bool userPassword = false;
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
            if(nameUserTextBox.TextLength == 0)
            {
                verificationErrorProvider.SetError(nameUserTextBox,"Campo Requerido");
                errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                userName = false;
            }
            else
            {
                for(int x = 0; x < users.Count; x++)
                {
                    if(nameUserTextBox.Text != users[x].NameUser)
                    {
                        verificationErrorProvider.SetError(nameUserTextBox, "Usuario No Existe");
                        errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                        userName = false;
                    }
                    else
                    {
                        verificationErrorProvider.SetError(nameUserTextBox, "");
                        errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                        userName = true;
                        user = x;
                    }
                }
            }
        }

        private void passwordUserTextBox_Leave(object sender, EventArgs e)
        {
            Console.WriteLine(userPassword + "-" + userName);
            if(userName)
            {
                if (passwordUserTextBox.TextLength == 0)
                {
                    verificationErrorProvider.SetError(passwordUserTextBox, "Campo Requerido");
                    errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                    userPassword = false;
                }
                else
                {
                    if (passwordUserTextBox.Text != users[user].PasswordUser)
                    {
                        verificationErrorProvider.SetError(passwordUserTextBox, "Contraseña Incorrecta");
                        errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                        userPassword = false;
                    }
                    else
                    {
                        verificationErrorProvider.SetError(passwordUserTextBox, "");
                        errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                        userPassword = true;
                    }
                }
            }
            else
            {
                verificationErrorProvider.SetError(passwordUserTextBox, "");
                errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                userPassword = true;
            }
        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            if(userName && userPassword)
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
