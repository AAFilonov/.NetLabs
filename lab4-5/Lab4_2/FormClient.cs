using System;
using System.Windows.Forms;
using ClassLibraryRentService;
namespace Lab4_2
{
    public partial class FormClient : Form
    {
        public Client Client { get; }
        public FormClient(Client client)
        {
            InitializeComponent();
            Client = client;
            FirstNameTextBox.Text = Client.Fio.FirstName;
            MiddleNameTextBox.Text = Client.Fio.MiddleName;
            LastNameTextBox.Text = Client.Fio.LastName;
            AdressTextBox.Text = Client.Adress;
            maskedTextBoxPhone.Text = Client.PhoneNumber;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Client.Fio.FirstName = FirstNameTextBox.Text;
            Client.Fio.MiddleName = MiddleNameTextBox.Text;
            Client.Fio.LastName = LastNameTextBox.Text;
            Client.Adress = AdressTextBox.Text;
            Client.PhoneNumber = maskedTextBoxPhone.Text;
        }
    }
}
