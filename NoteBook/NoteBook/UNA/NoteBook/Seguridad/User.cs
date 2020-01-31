using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.NoteBook
{
    public class User
    {
        public User()
        {
            Permissions = new List<int>();
        }
        public string NameUser
        {
            get;
            set;
        }

        public string PasswordUser
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }
        public List<int> Permissions
        {
            get;
            set;
        }
    }
}