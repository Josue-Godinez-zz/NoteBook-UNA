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
    public partial class NoteBookNewBookForm : Form
    {
        public NoteBookNewBookForm()
        {
            InitializeComponent();
        }
        public NoteBookNewBookForm(Dictionary<int, string> direcctionImages)
        {
            InitializeComponent();
            DirectionImages = direcctionImages;
        }
        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesComboBox.SelectedIndex != categoriesComboBox.Items.Count-1)
            {
                newImageCategorieButton.Visible = false;
                nameCategoriaTextBox.Visible = false;
                if (categoriesComboBox.SelectedIndex < 6)
                {
                    string direccionImagen = Path.Combine(Application.StartupPath, DirectionImages[categoriesComboBox.SelectedIndex]);
                    iconPictureBox.Image = new System.Drawing.Bitmap(direccionImagen);
                }
                else
                {
                    iconPictureBox.ImageLocation = DirectionImages[categoriesComboBox.SelectedIndex];
                }
            }
            else
            {
                newImageCategorieButton.Visible = true;
                nameCategoriaTextBox.Visible = true;
            }
        }
        private void newImageCategorieButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                iconPictureBox.ImageLocation = getImage.FileName;
            }
        }
        private void confirmationButton_Click(object sender, EventArgs e)
        {
            if (categoriesComboBox.SelectedIndex == categoriesComboBox.Items.Count - 1)
            {
                DirectionImages.Add(DirectionImages.Count, iconPictureBox.ImageLocation);
                categoriesComboBox.Items.Insert(categoriesComboBox.Items.Count - 1, nameCategoriaTextBox.Text);
            }
            Book newBook = new Book();
            newBook.NameBook = nameBookTextBox.Text;
            newBook.CategorieBook = (string)categoriesComboBox.SelectedItem;
            if(categoriesComboBox.SelectedIndex < 6)
            {
                newBook.ImageBook = DirectionImages[categoriesComboBox.SelectedIndex];
            }
            else
            {
                newBook.ImageBook = iconPictureBox.ImageLocation;
            }
        }

        private void nameBookTextBox_Leave(object sender, EventArgs e)
        {
            //if(nameBookTextBox.TextLength==0)
            //{

            //}
            //else if()
            //{

            //}
            //else
            //{

            //}
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Dictionary<int, string> DirectionImages
        {
            get;
            set;
        }
        public Book NewBook
        {
            get;
            set;
        }

        private void nameCategoriaTextBox_Leave(object sender, EventArgs e)
        {
            if(categoriesComboBox.Items.Contains(nameCategoriaTextBox.Text))
            {
                avisoErrorProvider.SetError(nameCategoriaTextBox,"Categoria Ya Existe");
                errorLabel.Text = avisoErrorProvider.GetError(nameCategoriaTextBox);
            }
            else
            {
                avisoErrorProvider.SetError(nameCategoriaTextBox, "");
                errorLabel.Text = avisoErrorProvider.GetError(nameCategoriaTextBox);
            }
        }
    }
}
