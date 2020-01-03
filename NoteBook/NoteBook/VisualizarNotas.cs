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
        public void Refrescar(List<Note> lista)
        {
            VisualizarDataGridView.DataSource = new List<Note>();
           
            VisualizarDataGridView.Columns.Clear();
            DataGridViewTextBoxColumn Titulo = new DataGridViewTextBoxColumn();
            Titulo.DataPropertyName = "Title";
            Titulo.HeaderText = "Título";
            VisualizarDataGridView.Columns.Add(Titulo);
          



            DataGridViewTextBoxColumn Categoria = new DataGridViewTextBoxColumn();
            Categoria.DataPropertyName = "Category";
            Categoria.HeaderText = "Categoría";
            VisualizarDataGridView.Columns.Add(Categoria);

            DataGridViewTextBoxColumn Creacion = new DataGridViewTextBoxColumn();
            Creacion.DataPropertyName = "CreationDate";
            Creacion.HeaderText = "Fecha de Creación";
            VisualizarDataGridView.Columns.Add(Creacion);

            DataGridViewTextBoxColumn Modificacion = new DataGridViewTextBoxColumn();
            Modificacion.DataPropertyName = "ModificationDate";
            Modificacion.HeaderText = "Fecha de Modificación";
            VisualizarDataGridView.Columns.Add(Modificacion);

            DataGridViewCheckBoxColumn Privacidad = new DataGridViewCheckBoxColumn();
            Privacidad.DataPropertyName = "Privacity";
            Privacidad.HeaderText = "Privacidad";
            VisualizarDataGridView.Columns.Add(Privacidad);

            if (Libro.Note.Count > 0)
            {
               
                VisualizarDataGridView.DataSource = lista;
            }

            for (int i = 0; i < VisualizarDataGridView.Columns.Count; i++)
            {
                VisualizarDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                VisualizarDataGridView.Columns[i].Resizable = DataGridViewTriState.False;
                
            }

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
