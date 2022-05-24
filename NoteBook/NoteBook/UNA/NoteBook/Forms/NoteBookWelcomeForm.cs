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
    public partial class NoteBookWelcomeForm : Form
    {
        public NoteBookWelcomeForm()
        {
            InitializeComponent();
        }
        public NoteBookWelcomeForm(List<User> users)
        {
            InitializeComponent();
            if(users.Count==0)
            {
                SignInButton.Enabled = false;
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
