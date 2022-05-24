using NoteBook.UNA.NoteBook.Seguridad;
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
using UNA.NoteBook;

namespace NoteBook
{
    public partial class NoteBookNewBookForm : Form
    {
        readonly List<Book> books;
        public NoteBookNewBookForm()
        {
            InitializeComponent();
        }
        public NoteBookNewBookForm(Dictionary<string, string> direcctionImages, List<Book> books, User actualUser)
        {
            InitializeComponent();
            this.books = books;
            User = actualUser;
            DirectionImages = direcctionImages;
            foreach (var element in DirectionImages)
            {
                if (!CategoriesComboBox.Items.Contains(element.Key))
                {
                    CategoriesComboBox.Items.Insert(CategoriesComboBox.Items.Count - 1, element.Key);
                }
            }
            foreach (var element in DirectionImages)
            {
                if (!SubCategorieComboBox.Items.Contains(element.Key))
                {
                    SubCategorieComboBox.Items.Insert(SubCategorieComboBox.Items.Count, element.Key);
                }
            }
            foreach (var element in DirectionImages)
            {
                if (!SubCategorie2ComboBox.Items.Contains(element.Key))
                {
                    SubCategorie2ComboBox.Items.Insert(SubCategorie2ComboBox.Items.Count, element.Key);
                }
            }
        }
        private void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriesComboBox.SelectedIndex != CategoriesComboBox.Items.Count - 1)
            {
                NewImageCategorieButton.Visible = false;
                NameCategoriaTextBox.Visible = false;
                if (CategoriesComboBox.SelectedIndex < 6)
                {
                    string direccionImagen = Path.Combine(Application.StartupPath, DirectionImages[(string)CategoriesComboBox.SelectedItem]);
                    IconPictureBox.Image = new System.Drawing.Bitmap(direccionImagen);
                }
                else
                {
                    IconPictureBox.ImageLocation = DirectionImages[(string)CategoriesComboBox.SelectedItem];
                }
            }
            else
            {
                NewImageCategorieButton.Visible = true;
                NameCategoriaTextBox.Visible = true;
            }
            BookNameValidation(NameBookTextBox.Text);
        }
        private void NewImageCategorieButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\User\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                IconPictureBox.ImageLocation = getImage.FileName;
            }
        }
        private void NameBookTextBox_Leave(object sender, EventArgs e)
        {
            BookNameCategorieValidation();
        }
        private bool BookNameValidation(string name)
        {
            if (name.Length == 0)
            {
                AvisoErrorProvider.SetError(NameBookTextBox, "Ningun Nombre Digitado");
                return false;
            }
            else
            {
                AvisoErrorProvider.SetError(NameBookTextBox, "");
                return true;
            }
        }
        private bool BookCategorieValidation()
        {
            if (CategoriesComboBox.SelectedIndex == -1)
            {
                AvisoErrorProvider.SetError(CategoriesComboBox, "Debe Elegir Una Categoria");
                return false;
            }
            else
            {
                AvisoErrorProvider.SetError(CategoriesComboBox, "");
                return true;
            }
        }
        private bool BookUniqueName()
        {
            bool condition = true;
            string auxCategorie = (string)CategoriesComboBox.SelectedItem;
            if (BookCategorieValidation())
            {
                for (int x = 0; x < books.Count; x++)
                {
                    if (books[x].CategorieBook[0] == auxCategorie && books[x].NameBook == NameBookTextBox.Text)
                    {
                        AvisoErrorProvider.SetError(NameBookTextBox, "Este Nombre Ya Esta Utilizado En Esta Categoria");
                        condition = false;
                        break;
                    }
                    else
                    {
                        AvisoErrorProvider.SetError(NameBookTextBox, "");
                    }
                }
            }
            return condition;
        }
        private bool BookNameCategorieValidation()
        {
            bool condition = true;
            if (NameCategoriaTextBox.TextLength == 0)
            {
                condition = false;
                AvisoErrorProvider.SetError(NameCategoriaTextBox, "Ningun Nombre Digitado");
            }
            else
            {
                for (int x = 0; x < books.Count; x++)
                {
                    if (NameCategoriaTextBox.Text == books[x].CategorieBook[0])
                    {
                        AvisoErrorProvider.SetError(NameCategoriaTextBox, "Esta Categoria Ya Existe");
                        condition = false;
                        break;
                    }
                    else
                    {
                        AvisoErrorProvider.SetError(NameBookTextBox, "");
                    }
                }
            }
            return condition;
        }
        private void NameCategoriaTextBox_Leave(object sender, EventArgs e)
        {
            BookCategorieValidation();
        }
        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if (BookNameValidation(NameBookTextBox.Text) && BookCategorieValidation() && CategoriesValidation())
            {
                if (BookUniqueName())
                {
                    if (CategoriesComboBox.SelectedIndex == CategoriesComboBox.Items.Count - 1)
                    {
                        if (BookNameCategorieValidation())
                        {
                            DirectionImages.Add(NameCategoriaTextBox.Text, IconPictureBox.ImageLocation);
                            CategoriesComboBox.Items.Insert(CategoriesComboBox.Items.Count - 1, NameCategoriaTextBox.Text);
                            MySqlService.Instance.CrearCategorias(NameCategoriaTextBox.Text, IconPictureBox.ImageLocation);
                            NewBook = BookCreation();
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        NewBook = BookCreation();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

            }
        }
        private bool CategoriesValidation()
        {
            bool result = true;
            if (SubCategorieCheckBox.Checked && SubCategorie2CheckBox.Checked)
            {
                if (SubCategorieComboBox.SelectedItem == SubCategorie2ComboBox.SelectedItem)
                {
                    AvisoErrorProvider.SetError(SubCategorie2ComboBox, "Categorias Iguales");
                    result = false;
                }
                else
                {
                    AvisoErrorProvider.SetError(SubCategorie2ComboBox, "");
                    result = true;
                }
            }
            else if (SubCategorie2CheckBox.Checked)
            {
                if (CategoriesComboBox.SelectedItem == SubCategorie2ComboBox.SelectedItem)
                {
                    AvisoErrorProvider.SetError(SubCategorie2ComboBox, "Categorias Iguales");
                    result = false;
                }
                else
                {
                    AvisoErrorProvider.SetError(SubCategorie2ComboBox, "");
                    result = true;
                }
            }
            else if(SubCategorieCheckBox.Checked)
            {
                if(CategoriesComboBox.SelectedItem == SubCategorieComboBox.SelectedItem)
                {
                    AvisoErrorProvider.SetError(SubCategorieComboBox, "Categorias Iguales");
                    result = false;
                }
                else
                {
                    AvisoErrorProvider.SetError(SubCategorieComboBox, "");
                    result = true;
                }
            }
            return result;
        }

        private Book BookCreation()
        {
            Book newBook = new Book();
            newBook.NameBook = NameBookTextBox.Text;
            if (CategoriesComboBox.SelectedIndex == CategoriesComboBox.Items.Count - 1)
            {
                newBook.CategorieBook.Add(NameCategoriaTextBox.Text);
            }
            else
            {
                newBook.CategorieBook.Add((string)CategoriesComboBox.SelectedItem);
            }
            if (CategoriesComboBox.SelectedIndex < 6)
            {
                newBook.ImageBook = DirectionImages[(string)CategoriesComboBox.SelectedItem];
            }
            else
            {
                newBook.ImageBook = IconPictureBox.ImageLocation;
            }
            if(SubCategorieCheckBox.Checked)
            {
                newBook.CategorieBook.Add(SubCategorieComboBox.Text);
            }
            if(SubCategorie2CheckBox.Checked)
            {
                newBook.CategorieBook.Add(SubCategorie2ComboBox.Text);
            }
            newBook.AccessBook = AccessCheckBox.Checked;
            newBook.User = User;
            ActivityRegister.Instance.SaveData(User.NameUser, "Libro Nuevo", "Creacion De Libro " + "\""+newBook.NameBook+"\"", "");
            return newBook;
        }
        public Dictionary<string, string> DirectionImages
        {
            get;
            set;
        }
        public Book NewBook
        {
            get;
            set;
        }
        public User User
        {
            get;
            set;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SubCategorieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SubCategorieCheckBox.Checked)
            {
                SubCategorieComboBox.Enabled = true;
            }
            else
            {
                SubCategorieComboBox.Enabled = false;
            }
        }
        private void SubCategorie2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubCategorie2CheckBox.Checked)
            {
                SubCategorie2ComboBox.Enabled = true;
            }
            else
            {
                SubCategorie2ComboBox.Enabled = false;
            }
        }
    }
}