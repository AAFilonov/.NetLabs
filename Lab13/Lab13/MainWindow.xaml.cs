using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Win32;

namespace Lab13
{
    public partial class MainWindow : Window
    {
       private DB_dotNetDataSet dB_dotNetDataSet;
       private DB_dotNetDataSetTableAdapters.FilmTableAdapter dB_dotNetDataSetFilmTableAdapter;
       private DB_dotNetDataSetTableAdapters.ProducerTableAdapter dB_dotNetDataSetProducerTableAdapter;
        ConstraintCollection producers_dt;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dB_dotNetDataSet = (DB_dotNetDataSet)FindResource("dB_dotNetDataSet");

            // Загрузить данные в таблицу Producer. Можно изменить этот код как требуется.
            dB_dotNetDataSetProducerTableAdapter = new Lab13.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            dB_dotNetDataSetProducerTableAdapter.Fill(dB_dotNetDataSet.Producer);
            System.Windows.Data.CollectionViewSource producerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("producerViewSource")));
            producerViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Film. Можно изменить этот код как требуется.
            dB_dotNetDataSetFilmTableAdapter = new Lab13.DB_dotNetDataSetTableAdapters.FilmTableAdapter();
            dB_dotNetDataSetFilmTableAdapter.Fill(dB_dotNetDataSet.Film);
            System.Windows.Data.CollectionViewSource filmViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("filmViewSource")));
            filmViewSource.View.MoveCurrentToFirst();
            DB_dotNetDataSet.ProducerDataTable dt_producers = new DB_dotNetDataSet.ProducerDataTable();
        }

       
        public MainWindow()
        {
            InitializeComponent();
            // получаем строку подключения из app.config

           
        

        }
        struct Producer
        {

            public string FullName;
            public int id;
        }

        private void DeleteProducer_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < producerDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = producerDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            dB_dotNetDataSetProducerTableAdapter.Update(dB_dotNetDataSet.Producer);
        }

        private void SaveProducer_Click(object sender, RoutedEventArgs e)
        {
            dB_dotNetDataSetProducerTableAdapter.Update(dB_dotNetDataSet.Producer);
        }

        private void DeleteFilm_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < filmDataGrid.SelectedItems.Count; i++)
            {
                var dataRowView = filmDataGrid.SelectedItems[i] as DataRowView;
                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                }
            }
            dB_dotNetDataSetFilmTableAdapter.Update(dB_dotNetDataSet.Film);
        }

        private void SaveFilm_Click(object sender, RoutedEventArgs e)
        {
            dB_dotNetDataSetFilmTableAdapter.Update(dB_dotNetDataSet.Film);
        }

        private void LoadImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                
              DefaultExt = "All files",
                  Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|All files|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (filmDataGrid.SelectedItems.Count > 0)
                {
                    var dataRowView = filmDataGrid.SelectedItems[0] as DataRowView;
                    if (dataRowView != null)
                    {
                        var dataRow = dataRowView.Row as DB_dotNetDataSet.FilmRow;
                        if (dataRow != null)
                        {
                            dataRow.cover = File.ReadAllBytes(openFileDialog.FileName);
                        }
                    }
                }
            }
        }

    } 
}
