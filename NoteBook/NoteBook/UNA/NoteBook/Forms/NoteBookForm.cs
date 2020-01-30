﻿using System;
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
using DataBaseAccess;
using MongoDB.Driver.Core.Configuration;
using NoteBook.UNA.NoteBook.Seguridad;
using NoteBook.UNA.NoteBook.Forms;

namespace NoteBook
{
    public partial class NoteBookForm : Form
    {
        List<User> users = new List<User>();
        Dictionary<string, string> directionImages = new Dictionary<string, string>();
        List<Book> books = new List<Book>();
        bool isLogin = false;
        User actualSesion = null;
        int opcionDeOrdenamiento = 0;

        MySqlAccess mySqlAccess = new MySqlAccess();
        public NoteBookForm()
        {
            users = MySqlService.Instance.CargarUsuarios();
            InitializeComponent();
            PreLoadImages();
            NoteBookWelcomeForm noteBookWelcomeForm = new NoteBookWelcomeForm(users);
            //if (noteBookWelcomeForm.ShowDialog() == DialogResult.Yes)
            //{
            //    RegisterNewUser();
            //}
            //else
            //{
            //    SignInUser();
            //}
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (users.Count != 0 && isLogin == false)
            {
                SignInUser();
            }
            else if (users.Count == 0)
            {
                MessageBox.Show("No Hay Usuarios Registrados", "Advertencia");
            }
            else if (isLogin == true)
            {
                NoteBookProfileForm notebookProfileForm = new NoteBookProfileForm(actualSesion, ContarLibros());
                {
                    DialogResult result = notebookProfileForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                    }
                    else if(result == DialogResult.Yes)
                    {
                        users.Remove(actualSesion);
                        SignOutButton.Enabled = false;
                        SignUpButton.Enabled = true;
                        actualSesion = null;
                        UserSingInLabel.Text = "<No Autentificado>";
                    }
                }
            }
        }
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            isLogin = false;
            ActivityRegister.Instance.SaveData(actualSesion.NameUser, "NoteBook", "Cerro Sesión", "");
            actualSesion = null;
            UserSingInLabel.Text = "<No Autentificado>";
            SignUpButton.Enabled = true;
            SignOutButton.Enabled = false;
            ActivityRegister.Instance.User = actualSesion;
            LibraryTableLayoutPanel.Controls.Clear();
        }

        private void CreateBookButton_Click(object sender, EventArgs e)
        {
            if (isLogin != false)
            {
                NoteBookNewBookForm noteBookNewBookForm = new NoteBookNewBookForm(directionImages, books, actualSesion);
                if (noteBookNewBookForm.ShowDialog() == DialogResult.OK)
                {
                    if (LibraryTableLayoutPanel.Controls.Count == (LibraryTableLayoutPanel.RowCount * LibraryTableLayoutPanel.ColumnCount))
                    {
                        LibraryTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 123));
                        LibraryTableLayoutPanel.RowCount++;
                    }
                    CreacionLibro(noteBookNewBookForm.NewBook);
                    MySqlService.Instance.CrearLibro(noteBookNewBookForm.NewBook);
                    MySqlService.Instance.AsociarLibroCategoria(noteBookNewBookForm.NewBook.CategorieBook);
                    directionImages = noteBookNewBookForm.DirectionImages;
                }
            }
            else
            {
                MessageBox.Show("Debes de iniciar sesión primero antes de poder crear un libro","Advertencia", MessageBoxButtons.OK);
            }
        }
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("h:mm:ss  tt");
        }

        private void PreLoadImages()
        {
            directionImages.Add("Deportes", "Resource/Deportes.png");
            directionImages.Add("Peliculas", "Resource/Peliculas.png");
            directionImages.Add("Juegos", "Resource/Juegos.png");
            directionImages.Add("Musica", "Resource/Musica.png");
            directionImages.Add("Libros", "Resource/Libros.png");
            directionImages.Add("Artes", "Resource/Artes.png");
        }
        private void CreacionLibro(Book book)
        {
            Panel panelBookCover = new Panel();
            panelBookCover.Anchor = AnchorStyles.None;
            panelBookCover.Size = new Size(90, 103);
            panelBookCover.BackColor = Color.FromArgb(224, 224, 224);
            panelBookCover.MouseEnter += PanelBookCover_MouseEnter;
            panelBookCover.MouseLeave += PanelBookCover_MouseLeave;
            panelBookCover.MouseClick += PanelBookCover_MouseClick;
            ToolTip toolTipInformation = new ToolTip();
            toolTipInformation.SetToolTip(panelBookCover, "<Click Izquiedo> Acceder A Este Libro\n<Click Derecho> Modificar Este Libro");
            toolTipInformation.IsBalloon = true;
            toolTipInformation.InitialDelay = 300;
            toolTipInformation.AutoPopDelay = 7000;
            toolTipInformation.ToolTipIcon = ToolTipIcon.Info;
            Label labelNameBook = new Label();
            labelNameBook.Text = book.NameBook;
            labelNameBook.ForeColor = Color.Black;
            labelNameBook.Location = new Point(10, 60);
            labelNameBook.TextAlign = ContentAlignment.MiddleCenter;
            labelNameBook.Size = new Size(74, 13);
            Label labelBookCategorie = new Label();
            labelBookCategorie.ForeColor = Color.Black;
            labelBookCategorie.Text = book.CategorieBook[0];
            labelBookCategorie.Location = new Point(10, 77);
            labelBookCategorie.TextAlign = ContentAlignment.MiddleCenter;
            labelBookCategorie.Size = new Size(74, 13);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Enabled = false;
            pictureBox.ImageLocation = book.ImageBook;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(45, 45);
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Location = new Point(23, 10);
            if (!books.Contains(book))
            {
                books.Add(book);
            }
            panelBookCover.Controls.Add(pictureBox);
            panelBookCover.Controls.Add(labelNameBook);
            panelBookCover.Controls.Add(labelBookCategorie);
            LibraryTableLayoutPanel.Controls.Add(panelBookCover);
        }

        private void PanelBookCover_MouseClick(object sender, MouseEventArgs e)
        {
            if (isLogin)
            {
                Book book = books[(LibraryTableLayoutPanel.Controls.GetChildIndex((Panel)sender))];
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if (book.User.Equals(actualSesion))
                    {
                        int id_libro = MySqlService.Instance.BuscarLibro(book);
                        NoteBookModifyBookForm modifyBook = new NoteBookModifyBookForm(book, books);
                        if (modifyBook.ShowDialog() == DialogResult.OK)
                        {
                            if(!modifyBook.PermitirBorrado)
                            {
                                Panel panelCoverBook = (Panel)sender;
                                PictureBox pictureBox = (PictureBox)panelCoverBook.Controls[0];
                                Label labelNameBook = (Label)panelCoverBook.Controls[1];
                                Label labelBookCategorie = (Label)panelCoverBook.Controls[2];
                                pictureBox.ImageLocation = modifyBook.Libro.ImageBook;
                                labelNameBook.Text = modifyBook.Libro.NameBook;
                                labelBookCategorie.Text = modifyBook.Libro.CategorieBook[0];
                                MySqlService.Instance.ActualizarLibro(id_libro, book);
                            }
                            else
                            {
                                Console.WriteLine("Se Borro");
                                MySqlService.Instance.BorrarLibro(id_libro);
                                LibraryTableLayoutPanel.Controls.Remove((Panel)sender);
                                books.Remove(book);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo el propietario del libro puede realizar modificaciones", "Advertencia");
                    }
                    
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if(book.AccessBook || (!book.AccessBook && book.User.Equals(actualSesion)))
                    {
                        VisualizarNotasForm visualizarNote = new VisualizarNotasForm(book);
                        if (visualizarNote.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo el propietario del libro puede acceder a él", "Advertencia");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de tener sesion iniciada para\npoder interactuar con este libro", "Advertencia");
            }
        }

        private void PanelBookCover_MouseLeave(object sender, EventArgs e)
        {
            Panel panelBookCover = (Panel)sender;
            panelBookCover.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void PanelBookCover_MouseEnter(object sender, EventArgs e)
        {
            Panel panelBookCover = (Panel)sender;
            panelBookCover.BackColor = Color.FromArgb(255, 192, 128);
        }
        private void LogActivitiesButton_Click(object sender, EventArgs e)
        {
            NoteBooksActivityRegisterForm noteBooksActivityRegisterForm = new NoteBooksActivityRegisterForm();
            noteBooksActivityRegisterForm.Show();
        }
        private void OrderBookButton_Click(object sender, EventArgs e)
        {
            opcionDeOrdenamiento++;
            LibraryTableLayoutPanel.Controls.Clear();
            if (opcionDeOrdenamiento == 1)
            {
                IEnumerable<Book> query = books.OrderBy(books => books.NameBook);
                foreach (Book books in query)
                {
                    CreacionLibro(books);
                }
                books = query.ToList();
            }
            else if (opcionDeOrdenamiento == 2)
            {
                IEnumerable<Book> query = books.OrderByDescending(books => books.NameBook);
                foreach (Book books in query)
                {
                    CreacionLibro(books);
                }
                books = query.ToList();
            }
            else if (opcionDeOrdenamiento == 3)
            {
                IEnumerable<Book> query = books.OrderBy(books => books.CategorieBook);
                foreach (Book books in query)
                {
                    CreacionLibro(books);
                }
                books = query.ToList();
            }
            else if (opcionDeOrdenamiento == 4)
            {
                IEnumerable<Book> query = books.OrderByDescending(books => books.CategorieBook);
                foreach (Book books in query)
                {
                    CreacionLibro(books);
                }
                books = query.ToList();
                opcionDeOrdenamiento = 0;
            }
        }
        private void RegisterNewUser()
        {
            NoteBookUserRegisterForm noteBookRegister = new NoteBookUserRegisterForm(users);
            if (noteBookRegister.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    users.Add(noteBookRegister.NewUser);
                    MySqlService.Instance.CrearUsuario(noteBookRegister.NewUser);
                    MessageBox.Show("Usuario Creado Exitosamente", "Felicidades");
                    actualSesion = noteBookRegister.NewUser;
                    isLogin = true;
                    UserSingInLabel.Text = "<" + noteBookRegister.NewUser.NameUser + ">";
                    SignOutButton.Enabled = true;
                    SignUpButton.Enabled = false;
                    ActivityRegister.Instance.User = actualSesion;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SignInUser()
        {
            NoteBookSignInForm noteBookSignInForm = new NoteBookSignInForm(users);
            if (noteBookSignInForm.ShowDialog() == DialogResult.OK)
            {
                isLogin = true;
                actualSesion = noteBookSignInForm.User;
                ActivityRegister.Instance.SaveData(actualSesion.NameUser, "Inicio Sesión", "Inicio Sesión", "");
                MessageBox.Show("'" + actualSesion.NameUser + "' A Iniciado Sesión", "Inicio de Sesión");
                UserSingInLabel.Text = "<" + actualSesion.NameUser + ">";
                SignOutButton.Enabled = true;
                SignUpButton.Enabled = false;
                ActivityRegister.Instance.User = actualSesion;
                books = MySqlService.Instance.CargarLibros(actualSesion);
                for (int x = 0; x < books.Count; x++)
                {
                    CreacionLibro(books[x]);
                }
            }
        }
        private int ContarLibros()
        {
            int cantidad = 0;
            for(int x=0; x<books.Count;x++)
            {
                if(books[x].User.NameUser == actualSesion.NameUser)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        private void BuscarNotaButton_Click(object sender, EventArgs e)
        {
            BuscarForm buscar = new BuscarForm();
            buscar.ShowDialog();
        }
    }
}