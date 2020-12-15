using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Lab11.Models;
using System.Drawing.Printing;
using System.IO;

namespace Lab11
{
    public partial class FormMain : Form
    {
          private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
        }
        private Font PrintFont;

        private void filmssBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Lab11dbDataSet);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_dotNetDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.dB_dotNetDataSet.Film);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_dotNetDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.dB_dotNetDataSet.Producer);
 
        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            filmTableAdapter.Update(dB_dotNetDataSet.Film);
            producerTableAdapter.Update(dB_dotNetDataSet.Producer);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printing();
        }

       
        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingPreview();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            var form = new FormFilm(filmBindingSource.Position);
            form.ShowDialog();
            filmTableAdapter.Fill(dB_dotNetDataSet.Film);
        }
        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Lab11dbDataSet);

        }

        private void pd_PrintSingle(object sender, PrintPageEventArgs ev)
        {
            float leftMargin = ev.MarginBounds.Left;
            float yPos = ev.MarginBounds.Top;
            string line;
            DataRowView dataRowView = (DataRowView)teachersBindingSource.Current;
            dB_dotNetDataSet.filmrow row = (lab11dbDataSet.teachersRow)dataRowView.Row;

            PrintFont = new Font("Arial", 20, FontStyle.Bold);
            line = "Teacher record report:";
            ev.Graphics.DrawString(line, PrintFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += PrintFont.GetHeight(ev.Graphics);


            PrintFont = new Font("Arial", 14);
            line = $"ID = {row.id}\r\n" +
                   $"FIRST NAME = {row.first_name}\r\n" +
                   $"MIDDLE_NAME = {row.middle_name}\r\n" +
                   $"LAST_NAME = {row.last_name}\r\n" +
                   $"DEGREE = {row.degreesRow.id}";

            ev.Graphics.DrawString(line, PrintFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += PrintFont.GetHeight(ev.Graphics) * 10;


            try
            {
                using (var ms = new MemoryStream(row.photo))
                {
                    ev.Graphics.DrawImage(Image.FromStream(ms), new Point((int)leftMargin, (int)yPos));
                }
            }
            catch (Exception)
            { }

            ev.HasMorePages = false;
        }

        public void Printing()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintSingle);
                // Print the document.
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PrintingPreview()
        {
            try
            {
                PrintPreviewDialog preview = new PrintPreviewDialog();
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintSingle);
                preview.Document = pd;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    


}
