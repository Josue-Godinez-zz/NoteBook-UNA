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
    public partial class EditNoteForm : Form
    {
        List<string> Categorias;
        private Note nota = new Note();
        public EditNoteForm()
        {
            InitializeComponent();
        }

        public EditNoteForm(string CategoriaLibro):this()
        {
            Categorias = new List<string>();
            if (CategoriaLibro.Equals("Deportes"))
            {
                CategoriaComboBox.Items.Add("Deporte1");
                CategoriaComboBox.Items.Add("Deporte2");
            }
        }

        public Note NewNote
        {
            get;
            set;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            nota = new Note();
            nota.Title = TitleTextBox.Text;

            NewNote = nota;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
