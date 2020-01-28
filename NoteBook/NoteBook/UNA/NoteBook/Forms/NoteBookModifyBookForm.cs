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
        public NoteBookModifyBookForm(Book book, List<Book> books)
        {
            InitializeComponent();
            Libro = book;
            this.books = books;
            directionImages = MySqlService.Instance.ObtenerCategorias();
            NameBookTextBox.Text = book.NameBook;
            IconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            IconPictureBox.ImageLocation = book.ImageBook;
            CargarCategorias();
            SetearCategorias();
            AccessCheckBox.Checked = book.AccessBook;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas seguro que deseas eliminar este libro?", "Advertencia", MessageBoxButtons.YesNo);
            switch(respuesta)
            {
                case DialogResult.Yes:
                    DialogResult = DialogResult.OK;
                    PermitirBorrado = true;
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
           
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if (BookValidation())
            {
                DialogResult respuesta = MessageBox.Show("Desea guardar cambios de este libro?", "Ejecutar Cambios", MessageBoxButtons.YesNo);
                switch (respuesta)
                {
                    case DialogResult.Yes:
                        
                        DialogResult = DialogResult.OK;
                        PermitirBorrado = false;
                        ModificarLibro();
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
        private bool BookValidation()
        {
            bool condition = false;
            if(BookNameValidation()&&BookCategorieValidation())
            {
                condition = true;
            }
            return condition;
        }
        private bool BookNameValidation()
        {
            bool condition = true;
            if(NameBookTextBox.TextLength == 0)
            {
                AvisoErrorProvider.SetError(NameBookTextBox, "Este Campo No Puede Quedar Vacio");
                condition = false;
                NameBookTextBox.Text = Libro.NameBook;
            }
            else
            {
                if (NameBookTextBox.Text != Libro.NameBook)
                {
                    for (int x = 0; x < books.Count; x++)
                    {
                        if (NameBookTextBox.Text == books[x].NameBook)
                        {
                            AvisoErrorProvider.SetError(NameBookTextBox, "Nombre Ya Utilizado");
                            condition = false;
                            break;
                        }
                        else
                        {
                            AvisoErrorProvider.SetError(NameBookTextBox, "");
                        }
                    }
                }
            }
            return condition;
        }
        private bool BookCategorieValidation()
        {
            bool condition = true;
            if(CategorieComboBox.SelectedIndex == CategorieComboBox.Items.Count-1)
            {
                if(directionImages.ContainsKey(NameNewCategorieTextBox.Text))
                {
                    condition = false;
                    AvisoErrorProvider.SetError(NameNewCategorieTextBox,"Categoria Ya Existe");
                }
                else
                {
                    AvisoErrorProvider.SetError(NameNewCategorieTextBox, "");
                }
            }
            else
            {
                if(SubCategorieCheckBox.Checked)
                {
                    if(CategorieComboBox.SelectedItem == SubCategorieComboBox.SelectedItem)
                    {
                        condition = false;
                        AvisoErrorProvider.SetError(SubCategorieComboBox, "Categoria Repetida");
                    }
                    else
                    {
                        AvisoErrorProvider.SetError(SubCategorieComboBox, "");
                    }
                }
                if (SubCategorie2CheckBox.Checked)
                {
                    if (CategorieComboBox.SelectedItem == SubCategorie2ComboBox.SelectedItem)
                    {
                        condition = false;
                        AvisoErrorProvider.SetError(SubCategorie2ComboBox, "Categoria Repetida");
                    }
                    else
                    {
                        AvisoErrorProvider.SetError(SubCategorie2ComboBox, "");
                    }
                }
                if(SubCategorieCheckBox.Checked && SubCategorie2CheckBox.Checked)
                {
                    if(SubCategorieComboBox.SelectedItem == SubCategorie2ComboBox.SelectedItem)
                    {
                        condition = false;
                        AvisoErrorProvider.SetError(SubCategorie2ComboBox,"Categoria Repetida");
                    }
                    else
                    {
                        AvisoErrorProvider.SetError(SubCategorie2ComboBox, "");
                    }
                }
            }
            return condition;
        }
        private void ModificarLibro()
        {
            ActivityRegister.Instance.SaveData(ActivityRegister.Instance.User.NameUser, "Modificar Libro", "Cambio de datos", "Nombre: \"" + Libro.NameBook + "\" ~> \"" + NameBookTextBox.Text + "\" Categoría: \"" + Libro.CategorieBook + "\" ~> \"" + (string)CategorieComboBox.SelectedItem + "\"");
            Libro.NameBook = NameBookTextBox.Text;
            Libro.AccessBook = AccessCheckBox.Checked;
            Libro.CategorieBook.Clear();
            if(CategorieComboBox.SelectedIndex == CategorieComboBox.Items.Count-1)
            {
                MySqlService.Instance.CrearCategorias(NameNewCategorieTextBox.Text,IconPictureBox.ImageLocation);
                Libro.ImageBook = IconPictureBox.ImageLocation;
                Libro.CategorieBook.Add(NameNewCategorieTextBox.Text);
            }
            else
            {
                Libro.CategorieBook.Add((string)CategorieComboBox.SelectedItem);
                Libro.ImageBook = directionImages[(string)CategorieComboBox.SelectedItem];
            }
            if(SubCategorieCheckBox.Checked)
            {
                Libro.CategorieBook.Add((string)SubCategorieComboBox.SelectedItem);
            }
            if(SubCategorie2CheckBox.Checked)
            {
                Libro.CategorieBook.Add((string)SubCategorie2ComboBox.SelectedItem);
            }
        }
        public Book Libro
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
                    IconPictureBox.ImageLocation = directionImages[(string)CategorieComboBox.SelectedItem];
                }
            }
            else
            {
                NewAvatarCategorieButton.Visible = true;
                NameNewCategorieTextBox.Visible = true;
            }
        }
        private void CargarCategorias()
        {
            foreach (var element in directionImages)
            {
                if (!CategorieComboBox.Items.Contains(element.Key))
                {
                    CategorieComboBox.Items.Insert(CategorieComboBox.Items.Count - 1, element.Key);
                }
                if (!SubCategorieComboBox.Items.Contains(element.Key))
                {
                    SubCategorieComboBox.Items.Add(element.Key);
                }
                if (!SubCategorie2ComboBox.Items.Contains(element.Key))
                {
                    SubCategorie2ComboBox.Items.Add(element.Key);
                }
            }
        }
        private void SetearCategorias()
        {
            CategorieComboBox.SelectedItem = Libro.CategorieBook[0];
            if(Libro.CategorieBook.Count>1)
            {
                SubCategorieCheckBox.Checked = true;
                SubCategorieComboBox.Enabled = true;
                SubCategorieComboBox.SelectedItem = Libro.CategorieBook[1];
            }
            if (Libro.CategorieBook.Count > 2)
            {
                SubCategorie2CheckBox.Checked = true;
                SubCategorie2ComboBox.Enabled = true;
                SubCategorie2ComboBox.SelectedItem = Libro.CategorieBook[2];
            }
        }
        private void SubCategorieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SubCategorieCheckBox.Checked)
            {
                SubCategorieComboBox.Enabled = true;
            }
            else
            {
                AvisoErrorProvider.SetError(SubCategorieComboBox,"");
                SubCategorieComboBox.SelectedItem = null;
                SubCategorieComboBox.Enabled = false;
            }
        }
        private void SubCategorie2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SubCategorie2CheckBox.Checked)
            {
                SubCategorie2ComboBox.Enabled = true;
            }
            else
            {
                AvisoErrorProvider.SetError(SubCategorie2ComboBox, "");
                SubCategorie2ComboBox.SelectedItem = null;
                SubCategorie2ComboBox.Enabled = false;
            }
        }
        private void NewAvatarCategorieButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\User\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                IconPictureBox.ImageLocation = getImage.FileName;
            }
        }
        public bool PermitirBorrado
        {
            get;
            set;
        }
    }
}