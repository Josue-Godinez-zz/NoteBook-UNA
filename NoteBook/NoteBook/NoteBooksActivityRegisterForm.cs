using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void PrinterButton_Click(object sender, EventArgs e)
        {
            Document archive = new Document(PageSize.LETTER);
            FileStream fileStream = new FileStream("Registro.pdf", FileMode.Create);
            Console.WriteLine(fileStream);
            PdfWriter writer = PdfWriter.GetInstance(archive, fileStream);
            archive.AddTitle("Registro De Actividades");
            archive.Open();
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 10f, BaseColor.BLACK);
            title.Add("Registro De Actividades");
            archive.Add(title);
            Paragraph events;
            for (int x = 0; x < ActivityRegister.Instance.GetData().Count; x++)
            {
                events = new Paragraph();
                events.Font = FontFactory.GetFont(FontFactory.TIMES, 8f, BaseColor.BLACK);
                events.Add(ActivityRegister.Instance.GetData()[x].TimeDateActivityRegister + "   -   " +
                    ActivityRegister.Instance.GetData()[x].UserActivityRegister + "   -   " +
                    ActivityRegister.Instance.GetData()[x].AccionActivityRegister + "   -   " +
                    ActivityRegister.Instance.GetData()[x].ObjectActivityRegister + "   -   " +
                    ActivityRegister.Instance.GetData()[x].AditionalInformationActivityRegister);
                archive.Add(events);
            }
            archive.Close();
            Process.Start(Application.StartupPath + "\\Registro.pdf");
        }

        private void NullButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
