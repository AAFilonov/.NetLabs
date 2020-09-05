using System;
using System.Windows.Forms;
using Lab4;

namespace Lab4_2
{
    public partial class FormMain : Form
    {
        private Client _client;
        private Car _car;
        public FormMain()
        {
            InitializeComponent();
        }
         
       
        
        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _client = new Client();
            FormClient formClient = new FormClient(_client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _client = formClient.Client;
            }
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient(_client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                _client = formClient.Client;
            }
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _car = new Car();
            FormCar formCar = new FormCar(_car);
            if (formCar.ShowDialog() == DialogResult.OK)
            {
                _car = formCar.Car;
            }
        }

        private void editCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCar formCar = new FormCar(_car);
            if (formCar.ShowDialog() == DialogResult.OK)
            {
                _car = formCar.Car;
            }
        }

      
    }
}
