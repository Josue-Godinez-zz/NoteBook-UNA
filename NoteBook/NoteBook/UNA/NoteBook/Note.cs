using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace UNA.NoteBook
{
    public class Note
    {
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

        public Color ColorNota
        {
            get;
            set;

        }

        public string Font
        {
            get;
            set;

        }

        public string ColorLetter
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
    }
}