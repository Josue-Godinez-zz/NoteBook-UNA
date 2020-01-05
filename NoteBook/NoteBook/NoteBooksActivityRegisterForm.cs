using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NoteBook.ActivityRegister;

namespace NoteBook
{
    public partial class NoteBooksActivityRegisterForm : Form
    {
        public NoteBooksActivityRegisterForm()
        {
            InitializeComponent();
            Data();
        }

        public void Data()
        {
            List<Event> events = ActivityRegister.Instance.GetData();
            for (int x = 0; x < events.Count; x++)
            {
                ActivitiesDataGridView.Rows.Add(events[x].TimeDateActivityRegister, events[x].UserActivityRegister, events[x].AccionActivityRegister, events[x].ObjectActivityRegister, events[x].AditionalInformationActivityRegister);
            }
        }
    }
}
