using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Notebook;

namespace NoteBook
{
    public partial class ModifyBook : Form
    {
        public ModifyBook()
        {
            InitializeComponent();
        }
        public ModifyBook(Book book)
        {
            InitializeComponent();
            NameBookTextBox.Text = book.NameBook;
        }
    }
}
