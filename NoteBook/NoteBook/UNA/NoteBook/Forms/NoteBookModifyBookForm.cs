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
        readonly List<Book> books;
        readonly Dictionary<string, string> directionImages;

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
            AccessCheckBox.Checked = book.AccessBook;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if (BookNameValidation())
            {
                DialogResult respuesta = MessageBox.Show("Desea guardar cambios de este libro?", "Ejecutar Cambios", MessageBoxButtons.YesNo);
                switch (respuesta)
                {
                    case DialogResult.Yes:
                        ActivityRegister.Instance.SaveData(ActivityRegister.Instance.User.NameUser, "Modificar Libro", "Cambio de datos", "Nombre: \"" + Book.NameBook + "\" ~> \"" + NameBookTextBox.Text + "\" Categoría: \"" + Book.CategorieBook + "\" ~> \"" + (string)CategorieComboBox.SelectedItem + "\"");
                        Book.NameBook = NameBookTextBox.Text;
                        Book.CategorieBook[0] = (string)CategorieComboBox.SelectedItem;
                        Book.ImageBook = directionImages[(string)CategorieComboBox.SelectedItem];
                        Book.AccessBook = AccessCheckBox.Checked;
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
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
                    if (books[x].NameBook == NameBookTextBox.Text && books[x].CategorieBook[0] == (string)CategorieComboBox.SelectedItem && AccessCheckBox.Checked == books[x].AccessBook)
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

        private void CategorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategorieComboBox.SelectedIndex != CategorieComboBox.Items.Count - 1)
            {
                NewAvatarCategorieButton.Visible = false;
                NameNewCategorieTextBox.Visible = false;
                if (CategorieComboBox.SelectedIndex < 6)
                {
                    string direccionImagen = Path.Combine(Application.StartupPath, directionImages[(string)CategorieComboBox.SelectedItem]);
                    IconPictureBox.Image = new System.Drawing.Bitmap(direccionImagen);
                }
                else
                {
                    NewAvatarCategorieButton.Visible = true;
                    IconPictureBox.ImageLocation = directionImages[(string)CategorieComboBox.SelectedItem];
                }
            }
            else
            {
                NewAvatarCategorieButton.Visible = true;
                NameNewCategorieTextBox.Visible = true;
            }
        }
    }
}