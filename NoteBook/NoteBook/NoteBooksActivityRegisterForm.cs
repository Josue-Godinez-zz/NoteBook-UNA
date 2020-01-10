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
using static NoteBook.VisualizarContenidoForm;

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
            List<Event> events = VisualizarContenidoForm.Instance.GetData();
            for (int x = 0; x < events.Count; x++)
            {
                ActivitiesDataGridView.Rows.Add(events[x].TimeDateActivityRegister, events[x].UserActivityRegister, events[x].AccionActivityRegister, events[x].ObjectActivityRegister, events[x].AditionalInformationActivityRegister);
            }
        }

        private void PrinterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (VisualizarContenidoForm.Instance.User == null)
                {
                    MessageBox.Show("Debes tener iniciada la sesión para poder crear PDF de Registro", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    VisualizarContenidoForm.Instance.SaveData(VisualizarContenidoForm.Instance.User.NameUser, "Registro Actividades", "Creo PDF de Registro", "");
                    PDFCrator();
                    DialogResult respuesta = (MessageBox.Show("El PDF fue creado exitosamente.\n\n" + "Ubicación de Archivo " + Application.StartupPath + "\\Registro.pdf" + "\n\nDesea abrirlo?", "Archivo PDF", MessageBoxButtons.YesNo));
                    switch (respuesta)
                    {
                        case DialogResult.Yes:
                            Process.Start(Application.StartupPath + "\\Registro.pdf");
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Asegurate de no tener ningun documento PDF\ncreado por el Registro de Actividades abierto", "Error");
            }
        }

        private void PDFCrator()
        {
            Document archive = new Document(PageSize.LETTER);
            FileStream fileStream = new FileStream("Registro.pdf", FileMode.Create);
            PdfWriter _1 = PdfWriter.GetInstance(archive, fileStream);
            archive.AddTitle("Registro De Actividades");
            archive.Open();
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 10f, BaseColor.BLACK);
            title.Add("Registro De Actividades");
            archive.Add(title);
            Paragraph events;
            for (int x = 0; x < VisualizarContenidoForm.Instance.GetData().Count; x++)
            {
                events = new Paragraph();
                events.Font = FontFactory.GetFont(FontFactory.TIMES, 8f, BaseColor.BLACK);
                events.Add(VisualizarContenidoForm.Instance.GetData()[x].TimeDateActivityRegister + "   -   " +
                    VisualizarContenidoForm.Instance.GetData()[x].UserActivityRegister + "   -   " +
                    VisualizarContenidoForm.Instance.GetData()[x].AccionActivityRegister + "   -   " +
                    VisualizarContenidoForm.Instance.GetData()[x].ObjectActivityRegister + "   -   " +
                    VisualizarContenidoForm.Instance.GetData()[x].AditionalInformationActivityRegister);
                archive.Add(events);
            }
            archive.Close();
        }

        private void NullButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
