using System;
using System.Windows.Forms;
using Lab4;

namespace Lab4_2
{
    public partial class FormRentedCar : Form
    {
        public RentedCar RentedCar { get; }
        
        public FormRentedCar(RentedCar rentedCar)
        {
            InitializeComponent();
            RentedCar = rentedCar;
            foreach (var item in RentService.Clients)
            {
                var client = item.Value;
                comboBoxClient.Items.Add(client);
            }
            foreach (var item in RentService.Cars)
            {
                var car = item.Value;
                comboBoxCar.Items.Add(car);
            }
        
            comboBoxClient.SelectedItem = rentedCar.Client;
            comboBoxCar.SelectedItem = rentedCar.Car;
            dateTimePickerStartDate.Value = rentedCar.StartDate;
            dateTimePickerEndDate.Value = rentedCar.EndDate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            RentedCar.Client = comboBoxClient.SelectedItem as Client;
            RentedCar.Car = comboBoxCar.SelectedItem as Car;
            RentedCar.StartDate = dateTimePickerStartDate.Value;
            RentedCar.EndDate = dateTimePickerEndDate.Value;
        }
    }
}
