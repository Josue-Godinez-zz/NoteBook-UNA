﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Notebook;
using UNA.NoteBook;

namespace NoteBook
{
    public partial class VisualizarNotasForm : Form
    {
        private Book Libro;

        public VisualizarNotasForm()
        {
            InitializeComponent();
           

        }
        public void Refrescar(List<Note> lista)
        {
            VisualizarDataGridView.DataSource = new List<Note>();
           
            VisualizarDataGridView.Columns.Clear();
            DataGridViewTextBoxColumn Titulo = new DataGridViewTextBoxColumn();
            Titulo.DataPropertyName = "Title";
            Titulo.HeaderText = "Título";
            VisualizarDataGridView.Columns.Add(Titulo);
          



            DataGridViewTextBoxColumn Categoria = new DataGridViewTextBoxColumn();
            Categoria.DataPropertyName = "Category";
            Categoria.HeaderText = "Categoría";
            VisualizarDataGridView.Columns.Add(Categoria);

            DataGridViewTextBoxColumn Creacion = new DataGridViewTextBoxColumn();
            Creacion.DataPropertyName = "CreationDate";
            Creacion.HeaderText = "Fecha de Creación";
            VisualizarDataGridView.Columns.Add(Creacion);

            DataGridViewTextBoxColumn Modificacion = new DataGridViewTextBoxColumn();
            Modificacion.DataPropertyName = "ModificationDate";
            Modificacion.HeaderText = "Fecha de Modificación";
            VisualizarDataGridView.Columns.Add(Modificacion);

            DataGridViewCheckBoxColumn Privacidad = new DataGridViewCheckBoxColumn();
            Privacidad.DataPropertyName = "Privacity";
            Privacidad.HeaderText = "Privacidad";
            VisualizarDataGridView.Columns.Add(Privacidad);

            if (Libro.Note.Count > 0)
            {
               
                VisualizarDataGridView.DataSource = lista;
            }

            for (int i = 0; i < VisualizarDataGridView.Columns.Count; i++)
            {
                VisualizarDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                VisualizarDataGridView.Columns[i].Resizable = DataGridViewTriState.False;
                
            }
        }

        public VisualizarNotasForm(Book libro):this()
        {
            this.Libro = libro;
            Refrescar(Libro.Note);
            //VisualizarDataGridView.DataSource = Libro.Note;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            EditNoteForm editNote = new EditNoteForm(Libro.CategorieBook,"Nueva Nota");
            if (editNote.ShowDialog() == DialogResult.OK)
            {
                Note nota = editNote.NewNote;
                Libro.Note.Add(nota);
                Refrescar(Libro.Note);
                //VisualizarDataGridView.DataSource = Libro.Note;
                Console.WriteLine(Libro.Note.Count);


            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            EditNoteForm editNote = new EditNoteForm(Libro.CategorieBook, "Editar Nota");
            if (VisualizarDataGridView.SelectedRows.Count >= 1)
            {
                editNote.NotaOriginal = (Note)VisualizarDataGridView.SelectedRows[0].DataBoundItem;
                editNote.Llenar();
                editNote.Nuevo = false;
                if (editNote.ShowDialog() == DialogResult.OK)
                {

 
                    Note eliminar = (Note)VisualizarDataGridView.SelectedRows[0].DataBoundItem;
                    VisualizarDataGridView.ClearSelection();
                    Libro.Note.Remove(eliminar);
                    eliminar = editNote.NewNote;
                    Libro.Note.Add(eliminar);
                    Refrescar(Libro.Note);
                    //VisualizarDataGridView.DataSource = Libro.Note;
                    

                }
            }

            
        }

        private void AbrirButton_Click(object sender, EventArgs e)
        {
             VisualizarContenidoForm contenido = new VisualizarContenidoForm();
            if (VisualizarDataGridView.SelectedRows.Count >= 1)
            {
                contenido.NotaOriginal = (Note)VisualizarDataGridView.SelectedRows[0].DataBoundItem;
                contenido.Llenar();
                if (contenido.ShowDialog() == DialogResult.OK)
                {


                    Note eliminar = (Note)VisualizarDataGridView.SelectedRows[0].DataBoundItem;
                    VisualizarDataGridView.ClearSelection();
                    Libro.Note.Remove(eliminar);
                    eliminar = contenido.NotaOriginal;
                    Libro.Note.Add(eliminar);
                    Refrescar(Libro.Note);
                    


                }
            }


        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Predicate<Note> buscar = x => x.Title.Contains(BuscarTextBox.Text);

            Refrescar(Libro.Note.FindAll(buscar));


        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Refrescar(Libro.Note);
            BuscarTextBox.Clear();
        }
    }
}