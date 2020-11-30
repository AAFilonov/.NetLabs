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

namespace Lab11
{
    public partial class FormMain : Form
    {
          private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
          
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=DB_dotNet;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }


        private void toolStripButtonLoadProducer_Click(object sender, EventArgs e)
        {
            var Producers = Producer.List(_connection);
            listViewProducers.Items.Clear();
            for (int i = 0; i < Producers.Count; i++)
            {
                var p = Producers[i];
                ListViewItem listListViewItem = new ListViewItem(p.Id.ToString()); 
                listListViewItem.Tag = p;
                listListViewItem.SubItems.Add(p.FirstName);
                listListViewItem.SubItems.Add(p.LastName);
                listViewProducers.Items.Add(listListViewItem);
            }

        }
        private void toolStripButtonAddProducer_Click(object sender, EventArgs e)
        {
            FormProducer formProducer = new FormProducer()
            {
                Producer = new Producer()
            };
            if (formProducer.ShowDialog() == DialogResult.OK)
            {
            
                Producer.Insert(_connection, formProducer.Producer);
            }
        }
        private void toolStripButtonUpdateProducer_Click(object sender, EventArgs e)
        {
            try
            {
                FormProducer formProducer = new FormProducer
                {
                    Producer = (Producer)listViewProducers.SelectedItems[0].Tag
                };
                if (formProducer.ShowDialog() == DialogResult.OK)
                {
                   
                    listViewProducers.SelectedItems[0].SubItems[1].Text = formProducer.Producer.FirstName;
                    listViewProducers.SelectedItems[0].SubItems[2].Text = formProducer.Producer.LastName;
                    Producer.Update(_connection, formProducer.Producer);
                }
            }
            catch (System.ArgumentOutOfRangeException ex )
            {
                MessageBox.Show("Аргумент не выбран","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void toolStripButtonDeleteProducer_Click(object sender, EventArgs e)
        {               
                Producer.Delete(_connection, ((Producer)listViewProducers.SelectedItems[0].Tag).Id);
            listViewProducers.Items.Remove(listViewProducers.SelectedItems[0]);
        }
        private void toolStripButtonLoad_Click(object sender, System.EventArgs e)
        {
            //var Films = Film.List(_connection);
            //listViewFilms.Items.Clear();
            //for (int i = 0; i < Films.Count; i++)
            //{
            //    var Film = Films[i];
            //    var listListViewItem = listViewFilms.Items.Add(Film.FilmId.ToString());
            //    listListViewItem.Tag = Film;
            //    listListViewItem.SubItems.Add(Film.Title);
            //    listListViewItem.SubItems.Add(Film.Year);
            //    listListViewItem.SubItems.Add(Film.ProdusserId);
            //}
        }
        

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            //FormFilm formFilm = new FormFilm()
            //{
            //    Film = new Film()
            //};
            //if (formFilm.ShowDialog() == DialogResult.OK)
            //{
            //    Film.Insert(_connection, formFilm.Film);
            //}
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            //FormFilm formFilm = new FormFilm
            //{
            //    Film = (Film)listViewFilms.SelectedItems[0].Tag
            //};
            //if (formFilm.ShowDialog() == DialogResult.OK)
            //{
            //    Film.Update(_connection, formFilm.Film);
            //}
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            //Film.Delete(_connection, ((Film)listViewFilms.SelectedItems[0].Tag).FilmId);
        }
     
    }
      
    
}
