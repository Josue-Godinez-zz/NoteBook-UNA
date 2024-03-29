﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNA.NoteBook;

namespace UNA.Notebook
{
    public class Book

    {
        public Book()
        {
            Note = new List<Note>();
            CategorieBook = new List<string>();
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

        public List<String> CategorieBook // Cambiar a lista de categoria
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
            get;
            set;
        }
        
        public bool AccessBook
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
            
        }
    }
}