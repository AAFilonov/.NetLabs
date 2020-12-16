using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_dotNetDataSet.Film". При необходимости она может быть перемещена или удалена.
            this.filmTableAdapter.Fill(this.dB_dotNetDataSet.Film);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_dotNetDataSet.Producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.dB_dotNetDataSet.Producer);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filmBindingSource.RemoveCurrent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            producerTableAdapter.Update(dB_dotNetDataSet.Producer);
            filmTableAdapter.Update(dB_dotNetDataSet.Film);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.filmTableAdapter.Update(dB_dotNetDataSet.Film);
        }

        private void loadFilmsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.filmTableAdapter.Fill(dB_dotNetDataSet.Film);
        }

        private void loadProducersTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.producerTableAdapter.Fill(dB_dotNetDataSet.Producer);
        }
    }
}
