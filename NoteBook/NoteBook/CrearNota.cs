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
            if (ValidacionTitulo(TitleTextBox.Text) && ValidacionCategoria())
            {

                nota = new Note();
                nota.Title = TitleTextBox.Text;
                nota.Category = CategoriaComboBox.Text;
                nota.SetColorNota(ColorButton.BackColor);
                nota.SetColorLetra(ColorLetraButton.BackColor);
                nota.SetFuente(FuenteButton.Font);
                nota.SetFuente(Fuente.Font);
                nota.SetContenido(ContenidoTextBox.Text);
                nota.Privacity = PrivacidadCheckBox.Checked;
                if (Nuevo)
                {
                    nota.CreationDate = DateTime.Now;
                }
                else
                {
                    nota.CreationDate = NotaOriginal.CreationDate;
                }

                nota.ModificationDate = DateTime.Now;

                NewNote = nota;
                this.DialogResult = DialogResult.OK;
                if(Nuevo)
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



        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (ColorNota.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = ColorNota.Color;
                ContenidoTextBox.BackColor = ColorNota.Color;
            }
        }

        public void Llenar()
        {
            TitleTextBox.Text = NotaOriginal.Title;
            CategoriaComboBox.SelectedItem = NotaOriginal.Category;
            ColorButton.BackColor = NotaOriginal.GetColorNota();
            ContenidoTextBox.BackColor = NotaOriginal.GetColorNota();
            ColorLetraButton.BackColor = NotaOriginal.GetColorLetra();
            ContenidoTextBox.ForeColor = NotaOriginal.GetColorLetra();
            FuenteButton.Font = NotaOriginal.GetFuente();
            ContenidoTextBox.Font = NotaOriginal.GetFuente();
            ContenidoTextBox.Text = NotaOriginal.GetContenido();
            PrivacidadCheckBox.Checked = NotaOriginal.Privacity;

        }

        private void ColorLetraButton_Click(object sender, EventArgs e)
        {
            if (ColorNota.ShowDialog() == DialogResult.OK)
            {
                ColorLetraButton.BackColor = ColorNota.Color;
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

        private bool ValidacionTitulo(string name)
        {
            if (name.Length == 0)
            {
                AvisoErrorProvider.SetError(TitleTextBox, "Ningun Nombre Digitado");
                return false;
            }
            else
            {
                AvisoErrorProvider.SetError(TitleTextBox, "");
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

    }
}
