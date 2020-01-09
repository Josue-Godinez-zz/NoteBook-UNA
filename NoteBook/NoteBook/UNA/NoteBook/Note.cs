using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace UNA.NoteBook
{
    public class Note
    {
        public void SetColorNota(Color color)
        {
            ColorNota = color;
        }
        public Color GetColorNota()
        {
            return ColorNota;
        }


        public void SetColorLetra(Color color)
        {
            ColorLetter = color;
        }
        public Color GetColorLetra()
        {
            return ColorLetter;
        }


        public void SetFuente(Font fuente)
        {
            FontLetter = fuente;
        }
        public Font GetFuente()
        {
            return FontLetter;
        }

        public void SetContenido(string contenido)
        {
            ContenidoNota = contenido;
        }
        public string GetContenido()
        {
            return ContenidoNota;
        }
        public string Title
        {
            get;
            set;

        }

        public bool Privacity
        {
            get;
            set;

        }

        public string Category
        {
            get;
            set;

        }

        private Color ColorNota
        {
            get;
            set;

        }

        private Font FontLetter
        {
            get;
            set;

        }

        private Color ColorLetter
        {
            get;
            set;

        }

        public DateTime CreationDate
        {
            get;
            set;

        }

        public DateTime ModificationDate
        {
            get;
            set;

        }

        private string ContenidoNota
        {
            get;
            set;
            
        }

        private Notebook.Book Book
        {
            get => default;
            set
            {
            }
        }
    }
}