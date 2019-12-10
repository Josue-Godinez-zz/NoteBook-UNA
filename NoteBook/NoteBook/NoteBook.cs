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
            NoteBookRegister noteBookRegister = new NoteBookRegister(users);
            if(noteBookRegister.ShowDialog() == DialogResult.OK)
            {
                users.Add(noteBookRegister.NewUser);
            }
        }
    }
}
