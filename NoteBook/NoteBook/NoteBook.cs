using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.NoteBook;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class NoteBookForm : Form
    {
        List<User> users= new List<User>();
        bool login = false;
        User actualSesion = null;
        public NoteBookForm()
        {
            InitializeComponent();
        }
        public NoteBookForm(User user)
        {
            InitializeComponent();
            users.Add(user);
            MessageBox.Show(Convert.ToString(users.Count));
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            NoteBookRegisterForm noteBookRegister = new NoteBookRegisterForm(users);
            if(noteBookRegister.ShowDialog() == DialogResult.OK)
            {
                users.Add(noteBookRegister.NewUser);
                MessageBox.Show("Usuario Creado Exitosamente","Felicidades");
                login = true;
                signOutButton.Enabled = true;
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(users.Count != 0 && login == false)
            {
                NoteBookSignInForm noteBookSignInForm = new NoteBookSignInForm(users);
                if (noteBookSignInForm.ShowDialog() == DialogResult.OK)
                {
                    login = true;
                    actualSesion = noteBookSignInForm.User;
                    MessageBox.Show("'"+actualSesion.NameUser+"' A Iniciado Sesion" , "Inicio de Sesion");
                    signOutButton.Enabled = true;
                }
            }
            else if(users.Count == 0)
            {
                MessageBox.Show("No Hay Usuarios Registrados", "Error");
            }
            else if(login == true)
            {
                NotebookProfileForm notebookProfileForm = new NotebookProfileForm();
                {
                    if(notebookProfileForm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            login = false;
            signOutButton.Enabled = false;
        }
    }
}
