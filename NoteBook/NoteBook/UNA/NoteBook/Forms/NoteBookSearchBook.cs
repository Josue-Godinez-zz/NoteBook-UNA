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
            CargarLibros();
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
                    BooksResultDataGridView.Rows.Add(books[x].NameBook, Image.FromFile(books[x].ImageBook), books[x].CategorieBook[0], null, null, books[x].User.NameUser);
                }
                else if (books[x].CategorieBook.Count == 2)
                {
                    BooksResultDataGridView.Rows.Add(books[x].NameBook, Image.FromFile(books[x].ImageBook), books[x].CategorieBook[0], books[x].CategorieBook[1], null, books[x].User.NameUser);
                }
                else
                {
                    BooksResultDataGridView.Rows.Add(books[x].NameBook, Image.FromFile(books[x].ImageBook), books[x].CategorieBook[0], books[x].CategorieBook[1], books[x].CategorieBook[2], books[x].User.NameUser);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameBookTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
