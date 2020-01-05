using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Notebook;

namespace NoteBook
{
    public partial class NoteBookModifyBookForm : Form
    {
        List<Book> books;
        Dictionary<string, string> directionImages;

        public NoteBookModifyBookForm()
        {
            InitializeComponent();
        }
        public NoteBookModifyBookForm(Book book, Dictionary<string, string> directionImages, List<Book> books)
        {
            InitializeComponent();
            this.Book = book;
            this.books = books;
            this.directionImages = directionImages;
            NameBookTextBox.Text = book.NameBook;
            IconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            IconPictureBox.ImageLocation = book.ImageBook;
            foreach (var element in directionImages)
            {
                if (!CategorieComboBox.Items.Contains(element.Key))
                {
                    CategorieComboBox.Items.Insert(CategorieComboBox.Items.Count - 1, element.Key);
                }
            }
            CategorieComboBox.SelectedItem = book.CategorieBook;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }
        private bool BookNameValidation()
        {
            bool condition = true;
            if (NameBookTextBox.TextLength == 0)
            {
                AvisoErrorProvider.SetError(NameBookTextBox, "Este Campo No Puede Quedar Vacio");
                condition = false;
                NameBookTextBox.Text = Book.NameBook;
            }
            else
            {
                for (int x = 0; x < books.Count; x++)
                {
                    if (books[x].NameBook == NameBookTextBox.Text && books[x].CategorieBook == (string)CategorieComboBox.SelectedItem)
                    {
                        DialogResult respuesta = MessageBox.Show("No Se Realizaron Cambios\nDeseas Salir?", "Aviso", MessageBoxButtons.YesNo);
                        switch (respuesta)
                        {
                            case DialogResult.Yes:
                                this.Close();
                                break;
                            case DialogResult.No:
                                condition = false;
                                break;
                        }
                    }
                    else
                    {
                        AvisoErrorProvider.SetError(NameBookTextBox, "");
                    }
                }
            }
            return condition;
        }

        public Book Book
        {
            get;
            set;
        }
    }
}