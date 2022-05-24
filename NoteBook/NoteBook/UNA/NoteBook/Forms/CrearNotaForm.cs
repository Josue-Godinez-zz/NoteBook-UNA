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
using static NoteBook.NoteBookUserRegisterForm;

namespace NoteBook
{
    public partial class EditNoteForm : Form
    {
        List<string> Categorias;
        public bool nuevo = true;
        private Note nota = new Note();
        private Note notaOriginal;

        public EditNoteForm()
        {
            InitializeComponent();
        }

        public EditNoteForm(string CategoriaLibro):this()
        {
            Categorias = new List<string>();
            if (CategoriaLibro.Equals("Deportes"))
            {
                CategoriaComboBox.Items.Add("Futbol");
                CategoriaComboBox.Items.Add("Baloncesto");
                CategoriaComboBox.Items.Add("Tenis");
                CategoriaComboBox.Items.Add("Volleyball");
            }

            if (CategoriaLibro.Equals("Peliculas"))
            {
                CategoriaComboBox.Items.Add("Terror");
                CategoriaComboBox.Items.Add("Romance");
                CategoriaComboBox.Items.Add("Comedia");
                CategoriaComboBox.Items.Add("Accion");
            }

            if (CategoriaLibro.Equals("Juegos"))
            {
                CategoriaComboBox.Items.Add("Accion");
                CategoriaComboBox.Items.Add("Aventura");
                CategoriaComboBox.Items.Add("Estrategia");
                CategoriaComboBox.Items.Add("Puzzle");
            }

            if (CategoriaLibro.Equals("Musica"))
            {
                CategoriaComboBox.Items.Add("Clasica");
                CategoriaComboBox.Items.Add("Rock");
                CategoriaComboBox.Items.Add("Metal");
                CategoriaComboBox.Items.Add("Pop");
            }

            if (CategoriaLibro.Equals("Libros"))
            {
                CategoriaComboBox.Items.Add("Literatura");
                CategoriaComboBox.Items.Add("Sagas o Trilogias");
                CategoriaComboBox.Items.Add("Comics");
                CategoriaComboBox.Items.Add("Novela");
            }

            if (CategoriaLibro.Equals("Artes"))
            {
                CategoriaComboBox.Items.Add("Baile");
                CategoriaComboBox.Items.Add("Canto");
                CategoriaComboBox.Items.Add("Pintura");
                CategoriaComboBox.Items.Add("Poesia");
            }
        }

        public EditNoteForm(string CategoriaLibro, string Titulo) : this(CategoriaLibro)
        {
            this.Text = Titulo;
        }

        public Note NewNote
        {
            get;
            set;
        }

        public bool Nuevo { get => nuevo; set => nuevo = value; }

        public Note NotaOriginal { get => notaOriginal; set => notaOriginal = value; }

       
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            if (ValidacionTitulo(TitleTextBox.Text) && ValidacionCategoria() && ValidacionContenido(ContenidoTextBox.Text))
            {
                
                nota = new Note();
                nota.SetColorNota(FondoButton.BackColor);
                nota.SetColorLetra(LetraButton.BackColor);
                nota.SetFuente(FuenteButton.Font);
                nota.SetFuente(Fuente.Font);
                nota.Title = TitleTextBox.Text;
                nota.Category = CategoriaComboBox.Text;
                nota.SetContenido(ContenidoTextBox.Text);
                nota.Privacity = PrivacidadCheckBox.Checked;
                nota.User = ActivityRegister.Instance.User.NameUser;
                Console.WriteLine(nota.User);
                if (Nuevo)
                {
                    nota.CreationDate = DateTime.Now;
                }
                else
                {
                    nota.CreationDate = NotaOriginal.CreationDate;
                    nota.SetId(NotaOriginal.GetId());
                }

                nota.ModificationDate = DateTime.Now;

                NewNote = nota;
                this.DialogResult = DialogResult.OK;
                ActivityRegister.Instance.SaveData(ActivityRegister.Instance.User.NameUser, "´Visualizar Notas", "Búsqueda de Notas ", "");
                ActivityRegister.Instance.SaveData(ActivityRegister.Instance.User.NameUser, "Buscar", "Búsqueda de Notas ", "");
                if (Nuevo)
                {
                    ActivityRegister.Instance.SaveData(ActivityRegister.Instance.User.NameUser, "Nueva Nota", "Creacion de nota " + "\"" + nota.Title + "\"", "");
                }
                else
                {
                    ActivityRegister.Instance.SaveData(ActivityRegister.Instance.User.NameUser, "Editar Nota", "Modificación de nota ", "");
                }
                this.Close();

            }
            

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            if (CerrarSinGuardar())
            {
                this.Close();
            }
            
        }

        public void Llenar()
        {
            FondoButton.BackColor = NotaOriginal.GetColorNota();
            ContenidoTextBox.BackColor = NotaOriginal.GetColorNota();
            LetraButton.BackColor = NotaOriginal.GetColorLetra();
            ContenidoTextBox.ForeColor = NotaOriginal.GetColorLetra();
            FuenteButton.Font = notaOriginal.GetFuente();
            ContenidoTextBox.Font = NotaOriginal.GetFuente();
            ContenidoTextBox.Text = NotaOriginal.GetContenido();
            TitleTextBox.Text = NotaOriginal.Title;
            CategoriaComboBox.SelectedItem = NotaOriginal.Category;
            PrivacidadCheckBox.Checked = NotaOriginal.Privacity;
            ActivityRegister.Instance.User.NameUser = NotaOriginal.User;

        }


        
        private bool ValidacionTitulo(string name)
        {
            if (name.Length == 0)
            {
                AvisoErrorProvider.SetError(TitleTextBox, "Ningun Título Digitado");
                return false;
            }
            else if(name.Length >= 20)
            {
                AvisoErrorProvider.SetError(TitleTextBox, "El título no debe tener una extensión mayor a 20 caracteres");
                return false;
            }
            else
            {
                AvisoErrorProvider.SetError(TitleTextBox, "");
                return true;
            }
        }

        private bool ValidacionContenido(string contenido)
        {
            if (contenido.Length == 0)
            {
                AvisoErrorProvider.SetError(ContenidoTextBox, "No hay texto escrito en la nota");
                return false;
            }
            else
            {
                AvisoErrorProvider.SetError(ContenidoTextBox, "");
                return true;
            }
        }


        private bool ValidacionCategoria()
        {
            if (CategoriaComboBox.SelectedIndex == -1)
            {
                AvisoErrorProvider.SetError(CategoriaComboBox, "Debe Elegir Una Categoria");
                return false;
            }
            else
            {
                AvisoErrorProvider.SetError(CategoriaComboBox, "");
                return true;
            }
        }

        private bool CerrarSinGuardar()
        {
            return MessageBox.Show("No se ha guardado la información, realmente desea cerrar esta ventana",
                                        "¿Desea Continuar?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        

        private void FondoButton_Click(object sender, EventArgs e)
        {
            if (ColorNota.ShowDialog() == DialogResult.OK)
            {
                FondoButton.BackColor = ColorNota.Color;
                ContenidoTextBox.BackColor = ColorNota.Color;
            }

        }

        private void LetraButton_Click(object sender, EventArgs e)
        {
            if (ColorNota.ShowDialog() == DialogResult.OK)
            {
                LetraButton.BackColor = ColorNota.Color;
                ContenidoTextBox.ForeColor = ColorNota.Color;

            }
        }

        private void FuenteButton_Click(object sender, EventArgs e)
        {
            Fuente.ShowEffects = false;
            if (Fuente.ShowDialog() == DialogResult.OK)
            {
                FuenteButton.Font = Fuente.Font;
                ContenidoTextBox.Font = Fuente.Font;


            }

        }
    }
}
