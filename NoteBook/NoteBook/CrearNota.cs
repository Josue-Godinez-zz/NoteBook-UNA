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
        List<string> Colores;
        private Note nota = new Note();
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

            if (CategoriaLibro.Equals("Arte"))
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            nota = new Note();
            nota.Title = TitleTextBox.Text;
            nota.Category = CategoriaComboBox.Text;
            nota.ColorNota = ColorButton.BackColor;
            nota.Privacity = PrivacidadCheckBox.Checked;
            nota.CreationDate = DateTime.Now;
            nota.ModificationDate = DateTime.Now;

            NewNote = nota;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {

        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ColorNota.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = ColorNota.Color;
            }
        }
    }
}
