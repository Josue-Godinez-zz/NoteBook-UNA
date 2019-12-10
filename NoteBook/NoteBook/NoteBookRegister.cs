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
    public partial class NoteBookRegister : Form
    {
        private List<String> users;
        private List<User> registeredUser;
        bool userPassword = false;
        bool userName = false;

        public NoteBookRegister()
        {
            InitializeComponent();
            users = new List<string>();
        }
        public NoteBookRegister(List<User> users)
        {
            InitializeComponent();
            this.users = new List<string>();
            for(int x = 0; x < users.Count; x++)
            {
                User aux = users[x];
                this.users.Add(aux.NameUser);
            }
            
        }

        private void nameUserTextBox_Leave(object sender, EventArgs e)
        {
            if (users.Contains(nameUserTextBox.Text))
            {
                verificationErrorProvider.SetError(nameUserTextBox, "El Usuario Ya Existe");
                errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                userName = false;
            }
            else if (nameUserTextBox.TextLength == 0)
            {
                verificationErrorProvider.SetError(nameUserTextBox, "Datos Requerido");
                errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
                userName = false;
            }
            else
            {
                verificationErrorProvider.SetError(nameUserTextBox, "");
                errorLabel.Text = verificationErrorProvider.GetError(confirmationPasswordTextBox);
                userName = true;
            }
        }
        private void confirmationPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordUserTextBox.Text != confirmationPasswordTextBox.Text)
            {
                verificationErrorProvider.SetError(confirmationPasswordTextBox, "Contraseñas Distintas");
                errorLabel.Text = verificationErrorProvider.GetError(confirmationPasswordTextBox);
                userPassword = false;
            }
            else
            {
                verificationErrorProvider.SetError(confirmationPasswordTextBox, "");
                errorLabel.Text = "";
                userPassword = true;
            }
        }
        private void passwordUserTextBox_Leave(object sender, EventArgs e)
        {
            if(passwordUserTextBox.TextLength==0)
            {
                verificationErrorProvider.SetError(passwordUserTextBox, "Datos Requerido");
                errorLabel.Text = verificationErrorProvider.GetError(passwordUserTextBox);
                userPassword = false;
            }
            else if(passwordUserLabel.Text != confirmationPasswordTextBox.Text)
            {
                userPassword = false;
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
            Console.WriteLine(userPassword + "-" + userName);
            if (nameUserTextBox.TextLength == 0 && passwordUserTextBox.TextLength == 0)
            {
                verificationErrorProvider.SetError(passwordUserTextBox, "Datos Requeridos");
                verificationErrorProvider.SetError(nameUserTextBox, "Datos Requeridos");
                errorLabel.Text = verificationErrorProvider.GetError(nameUserTextBox);
            }
            else if (userName && userPassword)
            {
                DialogResult respuesta = MessageBox.Show("Desea Crear Usuario Nuevo?","Nuevo usuario", MessageBoxButtons.YesNo);
                switch(respuesta)
                {
                    case DialogResult.Yes: newUser();
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
            user.NameUser = nameUserTextBox.Text;
            user.PasswordUser = passwordUserTextBox.Text;
            NewUser = user;
            DialogResult = DialogResult.OK;
        }

        public User NewUser
        {
            get;
            set;
        }
    }
}
