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
    public partial class VisualizarContenidoForm : Form
    {
        private Note notaOriginal;

        public Note NotaOriginal { get => notaOriginal; set => notaOriginal = value; }

        public VisualizarContenidoForm()
        {
            InitializeComponent();
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

                ContenidoTextBox.Font = Fuente.Font;


            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            notaOriginal.SetColorNota(FondoButton.BackColor);
            notaOriginal.SetColorLetra(LetraButton.BackColor);
            notaOriginal.SetFuente(Fuente.Font);
            notaOriginal.SetContenido(ContenidoTextBox.Text);
            notaOriginal.ModificationDate = DateTime.Now;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        public void Llenar()
        {
            FondoButton.BackColor = NotaOriginal.GetColorNota();
            ContenidoTextBox.BackColor = NotaOriginal.GetColorNota();
            LetraButton.BackColor = NotaOriginal.GetColorLetra();
            ContenidoTextBox.ForeColor = NotaOriginal.GetColorLetra();
            ContenidoTextBox.Font = NotaOriginal.GetFuente();
            ContenidoTextBox.Text = NotaOriginal.GetContenido();
        }
    }
}
