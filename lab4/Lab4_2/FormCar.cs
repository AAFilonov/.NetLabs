using Lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class FormCar : Form
    {
        public Car Car { get; }
        public FormCar(Car car)
        {
            InitializeComponent();
            Car = car;
            TypeComboBox.Items.Add(CarType.Motorcycle);
            TypeComboBox.Items.Add(CarType.PassengerСar);
            TypeComboBox.Items.Add(CarType.Truck);
            TypeComboBox.SelectedItem = car.Type;
            MarkTextBox.Text =  car.Mark;
            PriceNumericUpDown.Value =  car.Price;
            PriceRentNumericUpDown.Value = car.PriceRent;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Car.Mark = MarkTextBox.Text;
            Car.Price = PriceNumericUpDown.Value;
            Car.PriceRent = PriceRentNumericUpDown.Value;
            Car.Type = (CarType)TypeComboBox.SelectedItem;
        }
    }
}
