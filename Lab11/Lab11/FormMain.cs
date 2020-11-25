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

namespace Lab11
{
    public partial class FormMain : Form
    {
          private readonly SqlConnection _connection;
        public FormMain()
        {
            InitializeComponent();
          
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=CommentDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }


        private void toolStripButtonLoad_Click(object sender, System.EventArgs e)
        {
            var Films = Film.List(_connection);
            listViewFilms.Items.Clear();
            for (int i = 0; i < Films.Count; i++)
            {
                var Film = Films[i];
                var listListViewItem = listViewFilms.Items.Add(Film.FilmId.ToString());
                listListViewItem.Tag = Film;
                listListViewItem.SubItems.Add(Film.FirstName);
                listListViewItem.SubItems.Add(Film.SecondName);
                listListViewItem.SubItems.Add(Film.LastName);
            }
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            FormFilm formFilm = new FormFilm
            {
                Film = new Film()
            };
            if (formFilm.ShowDialog() == DialogResult.OK)
            {
                Film.Insert(_connection, formFilm.Film);
            }
        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            FormFilm formFilm = new FormFilm
            {
                Film = (Film)listViewFilms.SelectedItems[0].Tag
            };
            if (formFilm.ShowDialog() == DialogResult.OK)
            {
                Film.Update(_connection, formFilm.Film);
            }
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            Film.Delete(_connection, ((Film)listViewFilms.SelectedItems[0].Tag).FilmId);
        }
    }
      
    }
}
