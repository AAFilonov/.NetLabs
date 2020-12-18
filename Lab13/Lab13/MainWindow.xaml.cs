using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Data;
using Microsoft.Win32;

namespace Lab13
{
    public partial class MainWindow : Window
    {
       private DB_dotNetDataSet _dB_dotNetDataSet;
       private DB_dotNetDataSetTableAdapters.FilmTableAdapter _dB_dotNetDataSetFilmTableAdapter;
       private DB_dotNetDataSetTableAdapters.ProducerTableAdapter dB_dotNetDataSetProducerTableAdapter;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _dB_dotNetDataSet = (DB_dotNetDataSet)FindResource("dB_dotNetDataSet");
       
            // Загрузить данные в таблицу Producer. Можно изменить этот код как требуется.
             dB_dotNetDataSetProducerTableAdapter = new Lab13.DB_dotNetDataSetTableAdapters.ProducerTableAdapter();
            dB_dotNetDataSetProducerTableAdapter.Fill(_dB_dotNetDataSet.Producer);
            System.Windows.Data.CollectionViewSource producerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("producerViewSource")));
            producerViewSource.View.MoveCurrentToFirst();
        }
        public MainWindow()
        {
            InitializeComponent();
            // получаем строку подключения из app.config
         
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
            dB_dotNetDataSetProducerTableAdapter.Update(_dB_dotNetDataSet.Producer);
        }

        private void SaveProducer_Click(object sender, RoutedEventArgs e)
        {
            dB_dotNetDataSetProducerTableAdapter.Update(_dB_dotNetDataSet.Producer);
        }
    } 
}
