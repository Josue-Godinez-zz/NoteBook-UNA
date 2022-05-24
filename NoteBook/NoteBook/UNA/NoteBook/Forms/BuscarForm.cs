using NoteBook.UNA.NoteBook.Seguridad;
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

namespace NoteBook.UNA.NoteBook.Forms
{
    public partial class BuscarForm : Form
    {
        List<Note> nota = new List<Note>();
        public BuscarForm()
        {
            InitializeComponent();
            nota = MySqlService.Instance.CargarNotas();
            Refrescar(nota);
        }

        public void Refrescar(List<Note> lista)
        {
            BuscarDataGridView.DataSource = new List<Note>();

            BuscarDataGridView.EnableHeadersVisualStyles = false;

            BuscarDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Lavender;
            BuscarDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            BuscarDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            BuscarDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;


            BuscarDataGridView.Columns.Clear();
            DataGridViewTextBoxColumn Titulo = new DataGridViewTextBoxColumn();
            Titulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Titulo.DataPropertyName = "Title";
            Titulo.HeaderText = "Título";
            BuscarDataGridView.Columns.Add(Titulo);

            DataGridViewTextBoxColumn Categoria = new DataGridViewTextBoxColumn();
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.DataPropertyName = "Category";
            Categoria.HeaderText = "Categoría";
            BuscarDataGridView.Columns.Add(Categoria);

            DataGridViewTextBoxColumn Creacion = new DataGridViewTextBoxColumn();
            Creacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Creacion.DataPropertyName = "CreationDate";
            Creacion.HeaderText = "Fecha de Creación";
            BuscarDataGridView.Columns.Add(Creacion);

            DataGridViewTextBoxColumn Modificacion = new DataGridViewTextBoxColumn();
            Modificacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Modificacion.DataPropertyName = "ModificationDate";
            Modificacion.HeaderText = "Fecha de Modificación";
            BuscarDataGridView.Columns.Add(Modificacion);

            DataGridViewCheckBoxColumn Privacidad = new DataGridViewCheckBoxColumn();
            Privacidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Privacidad.DataPropertyName = "Privacity";
            Privacidad.HeaderText = "Privacidad";
            BuscarDataGridView.Columns.Add(Privacidad);

            DataGridViewTextBoxColumn Usuario = new DataGridViewTextBoxColumn();
            Usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Usuario.DataPropertyName = "User";
            Usuario.HeaderText = "Usuario";
            BuscarDataGridView.Columns.Add(Usuario);

            BuscarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BuscarDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BuscarDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            BuscarDataGridView.DefaultCellStyle.ForeColor = Color.Green;
            BuscarDataGridView.DefaultCellStyle.SelectionBackColor = Color.Aqua;
            BuscarDataGridView.DefaultCellStyle.BackColor = Color.AliceBlue;
            BuscarDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;


            if (nota.Count > 0)
            {
                BuscarDataGridView.DataSource = lista;
            }

            for (int i = 0; i < BuscarDataGridView.Columns.Count; i++)
            {
                BuscarDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                BuscarDataGridView.Columns[i].Resizable = DataGridViewTriState.False;

            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Refrescar(nota);
            BuscarTituloTextBox.Clear();
            BuscarCategoriaTextBox.Clear();
        }

        private void BuscarTituloButton_Click(object sender, EventArgs e)
        {
            Predicate<Note> buscar = x => (x.Title.ToUpper().Contains(BuscarTituloTextBox.Text.ToUpper()));
            Refrescar(nota.FindAll(buscar));
        }

        private void BuscarCategoriaButton_Click(object sender, EventArgs e)
        {
            Predicate<Note> buscar = x => (x.Category.ToUpper().Contains(BuscarCategoriaTextBox.Text.ToUpper()));
            Refrescar(nota.FindAll(buscar));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
