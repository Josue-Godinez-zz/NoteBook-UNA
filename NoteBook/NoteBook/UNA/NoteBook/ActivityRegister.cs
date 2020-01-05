using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UNA.Notebook;
using UNA.NoteBook;
namespace NoteBook
{

    public class ActivityRegister
    {
        private static ActivityRegister _instance = null;

        private ActivityRegister()
        {

        }

        public static ActivityRegister Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ActivityRegister();
                }
                if (Activities == null)
                {
                    Activities = new List<Event>();
                }
                return _instance;
            }
        }

        public static List<Event> Activities
        {
            get;
            set;
        }

        public User User
        {
            get;
            set;
        }

        public Note Note
        {
            get;
            set;
        }

        public void SaveData(string user, string place, string time, string accion, string information)
        {
            Event @event = new Event(user, place, time, accion, information);
            Activities.Add(@event);
        }

        public List<Event> GetData()
        {
            return Activities;
        }
        public class Event
        {
            public Event()
            {
            }
            public Event(string user, string place, string time, string accion, string information)
            {
                UserActivityRegister = user;
                ObjectActivityRegister = place;
                TimeDateActivityRegister = time;
                AccionActivityRegister = accion;
                AditionalInformationActivityRegister = information;
            }
                public string TimeDateActivityRegister
            {
                get;
                set;
            }

            public string UserActivityRegister
            {
                get;
                set;
            }

            public string AccionActivityRegister
            {
                get;
                set;
            }

            public string ObjectActivityRegister
            {
                get;
                set;
            }

            public string AditionalInformationActivityRegister
            {
                get;
                set;
            }
        }
    }
}
