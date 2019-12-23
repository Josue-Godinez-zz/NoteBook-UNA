using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNA.NoteBook;
using System.Windows.Forms;
using UNA.Notebook;

namespace NoteBook
{
    public partial class NoteBookForm : Form
    {
        List<User> users= new List<User>();
        Dictionary<int, string> directionImages = new Dictionary<int, string>();
        List<Book> books = new List<Book>();
        bool isLogin = false;
        User actualSesion = null;
        public NoteBookForm()
        {
            InitializeComponent();
            preloadImages();
            libraryTableLayoutPanel.MaximumSize = new Size(libraryTableLayoutPanel.Width, libraryTableLayoutPanel.Height);
            libraryTableLayoutPanel.AutoScroll = true;



        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            NoteBookRegisterForm noteBookRegister = new NoteBookRegisterForm(users);
            if(noteBookRegister.ShowDialog() == DialogResult.OK)
            {
                users.Add(noteBookRegister.NewUser);
                MessageBox.Show("Usuario Creado Exitosamente","Felicidades");
                isLogin = true;
                userSingInLabel.Text = "<" + (string)noteBookRegister.NewUser.NameUser + ">";
                signOutButton.Enabled = true;
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(users.Count != 0 && isLogin == false)
            {
                NoteBookSignInForm noteBookSignInForm = new NoteBookSignInForm(users);
                if (noteBookSignInForm.ShowDialog() == DialogResult.OK)
                {
                    isLogin = true;
                    actualSesion = noteBookSignInForm.User;
                    MessageBox.Show("'"+actualSesion.NameUser+"' A Iniciado Sesion" , "Inicio de Sesion");
                    userSingInLabel.Text = "<" + actualSesion.NameUser + ">";
                    signOutButton.Enabled = true;
                }
            }
            else if(users.Count == 0)
            {
                MessageBox.Show("No Hay Usuarios Registrados", "Error");
            }
            else if(isLogin == true)
            {
                NotebookProfileForm notebookProfileForm = new NotebookProfileForm();
                {
                    if(notebookProfileForm.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }
        }
        private void signOutButton_Click(object sender, EventArgs e)
        {
            isLogin = false;
            actualSesion = null;
            userSingInLabel.Text = "<No Autentificado>";
            signOutButton.Enabled = false;
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            NoteBookNewBookForm noteBookNewBookForm = new NoteBookNewBookForm(directionImages, books);
            if(noteBookNewBookForm.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(Convert.ToString(libraryTableLayoutPanel.RowCount));
                if (libraryTableLayoutPanel.Controls.Count == (libraryTableLayoutPanel.RowCount * libraryTableLayoutPanel.ColumnCount))
                {
                    libraryTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 123));
                    libraryTableLayoutPanel.RowCount++;
                }
                Book pictureBox = noteBookNewBookForm.NewBook;
                Console.WriteLine(noteBookNewBookForm.NewBook.ImageBook);
                pictureBox.ImageLocation = noteBookNewBookForm.NewBook.ImageBook;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 45;
                pictureBox.Height = 45;
                pictureBox.Anchor = AnchorStyles.None;
                pictureBox.DoubleClick += (s, args)=>{
                    EditNoteForm editNote = new EditNoteForm(((Book)s).CategorieBook);
                    if(editNote.ShowDialog() == DialogResult.OK)
                    {
                        Console.WriteLine(editNote.NewNote.Title);
                    }
                };
                ToolTip toolTip = new ToolTip();
                toolTip.ToolTipTitle = noteBookNewBookForm.NewBook.NameBook;
                toolTip.SetToolTip(pictureBox, "Categoria: " + noteBookNewBookForm.NewBook.CategorieBook);
                toolTip.IsBalloon = true;
                libraryTableLayoutPanel.Controls.Add(pictureBox);
                books.Add(noteBookNewBookForm.NewBook);
                pictureBox.MouseDoubleClick += PictureBox_MouseDoubleClick; ;
            }
        }

        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
             //   Console.WriteLine(Convert.ToString(libraryTableLayoutPanel.Controls.GetChildIndex((PictureBox)sender)));
               // libraryTableLayoutPanel.Controls.GetChildIndex((PictureBox)sender);

                ModifyBook modifyBook = new ModifyBook(books[(libraryTableLayoutPanel.Controls.GetChildIndex((PictureBox)sender))]);
                if(modifyBook.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Console.WriteLine("Abre el libro y muestra notas"); 
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void preloadImages()
        {
            directionImages.Add(0, @"Resource\Deportes.png");
            directionImages.Add(1, @"Resource\Peliculas.png");
            directionImages.Add(2, @"Resource\Juegos.png");
            directionImages.Add(3, @"Resource\Musica.png");
            directionImages.Add(4, @"Resource\Libros.png");
            directionImages.Add(5, @"Resource\Artes.png");
        }

        private void elimiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
