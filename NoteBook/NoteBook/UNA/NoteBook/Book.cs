using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNA.NoteBook;

namespace UNA.Notebook
{
    public class Book : PictureBox

    {
        public Book()
        {
            Note = new List<Note>();
        }

        public String ImageBook
        {
            get;
            set;
        }

        public String NameBook
        {
            get;
            set;
        }

        public string CategorieBook
        {
            get;
            set;
        }

        public List<UNA.NoteBook.Note> Note
        {
            get;
            set;
        }

        public User User
        {
            get => default;
            set
            {
            }
        }
    }
}