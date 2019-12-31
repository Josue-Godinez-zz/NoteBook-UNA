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
using UNA.NoteBook;

namespace NoteBook
{
    public partial class VisualizarNotasForm : Form
    {
        private Book Libro;

        public VisualizarNotasForm()
        {
            InitializeComponent();
        }

        public VisualizarNotasForm(Book libro):this()
        {
            this.Libro = libro;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            EditNoteForm editNote = new EditNoteForm(Libro.CategorieBook,"Nueva Nota");
            if (editNote.ShowDialog() == DialogResult.OK)
            {
                Note nota = editNote.NewNote;
                VisualizarDataGridView.Rows.Add(nota.Title, nota.Category, nota.CreationDate, nota.ModificationDate, nota.Privacity);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
