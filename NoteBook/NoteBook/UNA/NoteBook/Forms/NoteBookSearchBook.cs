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
using UNA.Notebook;

namespace NoteBook.UNA.NoteBook.Forms
{
    public partial class NoteBookSearchBook : Form
    {
        Dictionary<string, string> directionImages;
        List<Book> books;
        DataTable dataTable = new DataTable();
        string nameBook = "";
        string propietario = "";
        public NoteBookSearchBook()
        {
            InitializeComponent();
        }
        public NoteBookSearchBook(List<Book> books)
        {
            InitializeComponent();
            directionImages = MySqlService.Instance.ObtenerCategorias();
            this.books = books;
            CargarCategorias();
            BooksResultDataGridView.CellContentClick += BooksResultDataGridView_CellContentClick;
        }

        private void CargarCategorias()
        {
            foreach (var element in directionImages)
            {
                Categorie1ComboBox.Items.Add(element.Key);
                Categorie2ComboBox.Items.Add(element.Key);
                Categorie3ComboBox.Items.Add(element.Key);
            }
        }
        private void CargarLibros()
        {
            for (int x = 0; x < books.Count; x++)
            {
                if (books[x].CategorieBook.Count == 1)
                {
                    dataTable.Rows.Add(new object[] { books[x].NameBook, Image.FromFile(books[x].ImageBook), books[x].CategorieBook[0], null, null, books[x].User.NameUser });
                }
                else if (books[x].CategorieBook.Count == 2)
                {
                    dataTable.Rows.Add(new object[] { books[x].NameBook, Image.FromFile(books[x].ImageBook), books[x].CategorieBook[0], books[x].CategorieBook[1], null, books[x].User.NameUser });
                }
                else
                {
                    dataTable.Rows.Add((new object[]{books[x].NameBook, Image.FromFile(books[x].ImageBook), books[x].CategorieBook[0], books[x].CategorieBook[1], books[x].CategorieBook[2], books[x].User.NameUser}));
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameBookTextBox_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Nombre", NameBookTextBox.Text);
        }

        private void NoteBookSearchBook_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Avatar", typeof(Image));
            dataTable.Columns.Add("1° Categoria", typeof(string));
            dataTable.Columns.Add("2° Categoria", typeof(string));
            dataTable.Columns.Add("3° Categoria", typeof(string));
            dataTable.Columns.Add("Usuario", typeof(string));
            CargarLibros();
            BooksResultDataGridView.DataSource = dataTable;
            for (int x = 0; x < dataTable.Columns.Count; x++)
            {
                BooksResultDataGridView.Columns[x].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                BooksResultDataGridView.Columns[x].ReadOnly = true;
                if (x == 1)
                {
                    DataGridViewImageColumn column = (DataGridViewImageColumn)BooksResultDataGridView.Columns[x];
                    column.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }
        private void OpenBookButton_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
            BuscarLibro();
            ConfirmarBusqueda();
        }

        private void BooksResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDatos();
            BuscarLibro();
            ConfirmarBusqueda();
        }

        private void Categorie1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "1° Categoria", Categorie1ComboBox.SelectedItem);
        }

        private void Categorie2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'","2° Categoria", Categorie2ComboBox.SelectedItem);
        }

        private void Categorie3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "3° Categoria", Categorie3ComboBox.SelectedItem);
        }
        private void ObtenerDatos()
        {
            foreach (DataGridViewCell item in BooksResultDataGridView.CurrentRow.Cells)
            {
                if (item.ColumnIndex == 0)
                {
                    nameBook = item.Value.ToString();
                }
                if (item.ColumnIndex == 5)
                {
                    propietario = item.Value.ToString();
                }
            }
        }
        private void BuscarLibro()
        {
            for (int x = 0; x < books.Count; x++)
            {
                if (books[x].NameBook.Equals(nameBook) && books[x].User.NameUser.Equals(propietario))
                {
                    Libro = books[x];
                    break;
                }
            }
        }

        private void ConfirmarBusqueda()
        {
            DialogResult result = MessageBox.Show("Deseas abrir este libro?","Confirmación", MessageBoxButtons.YesNo);
            switch(result)
            {
                case DialogResult.Yes:
                    DialogResult = DialogResult.OK;
                    break;
                case DialogResult.No:
                    break;
            }
        }
        public Book Libro
        {
            get; 
            set;
        }
    }
}
