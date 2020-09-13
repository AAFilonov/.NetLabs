using System;
using System.Windows.Forms;
using Lab4;

namespace Lab4_2
{
    public partial class FormMain : Form
    {
     
        public FormMain()
        {
            InitializeComponent();
        }
         
       
        
        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new Client();
            FormClient formClient = new FormClient(client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                RentService.Clients.Add(client.ClientId, client);
                UpdateClientsList();
            }
            
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = listViewClients.SelectedItems[0].Tag as Client;
            FormClient formClient = new FormClient(client);
            if (formClient.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsList();
            }
        }

        private void UpdateClientsList()
        {
            listViewClients.Items.Clear();
            foreach (var item in RentService.Clients)
            {
                var client = item.Value;
                var listViewItem = new
                ListViewItem
                {
                    Tag = client,
                    Text = client.ToString()
                };
                listViewClients.Items.Add(listViewItem);
            }
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var car = new Car();
            FormCar formCar = new FormCar(car);
            if (formCar.ShowDialog() == DialogResult.OK)
            {
                RentService.Cars.Add(car.Number, car);
                UpdateCarsList();
            }
           
        }

        private void editCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var car = listViewCars.SelectedItems[0].Tag as Car;
            FormCar formCar = new FormCar(car);
            if (formCar.ShowDialog() == DialogResult.OK)
            {
                UpdateCarsList();
            }
        }
        private void UpdateCarsList()
        {
            listViewCars.Items.Clear();
            foreach (var item in RentService.Cars)
            {
                var car = item.Value;
                var listViewItem = new
                ListViewItem
                {
                    Tag = car,
                    Text = car.ToString()
                };
                listViewCars.Items.Add(listViewItem);
            }
        }
        private void addRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rentedCar= new RentedCar();
            FormRentedCar formRentedCar= new FormRentedCar(rentedCar);
            if (formRentedCar.ShowDialog() == DialogResult.OK)
            {
                RentService.RentedCars.Add(rentedCar);
                UpdateRentedCarsList();
            }
        }

        private void editSettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rentedCar = listViewRentedCars.SelectedItems[0].Tag as RentedCar;
            FormRentedCar formRentedCar = new FormRentedCar(rentedCar);
            if (formRentedCar.ShowDialog() == DialogResult.OK)
            {
                UpdateRentedCarsList();
            }
        }

        private void UpdateRentedCarsList()
        {
            listViewRentedCars.Items.Clear();
            foreach (var rentedCar in RentService.RentedCars)
            {
                var listViewItem = new ListViewItem
                {
                    Tag = rentedCar,
                    Text = rentedCar.Client.ToString()
                };
                listViewItem.SubItems.Add(rentedCar.Car.ToString());
                listViewItem.SubItems.Add(rentedCar.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(rentedCar.EndDate.ToShortDateString());
                listViewRentedCars.Items.Add(listViewItem);
            }
        }


    }
}
