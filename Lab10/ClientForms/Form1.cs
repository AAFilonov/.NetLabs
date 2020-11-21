using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ClassLibraryAnimals;
using Newtonsoft.Json;

namespace ClientForms
{
    public partial class Form1 : Form
    {
        IPHostEntry ipHost;
        IPAddress ipAddr;
        IPEndPoint ipEndPoint;
        Socket s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Буфер для входящих данных
            byte[] bytes = new byte[10240];

            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            ipHost = Dns.GetHostEntry("localhost");
            ipAddr = ipHost.AddressList[0];
            ipEndPoint = new IPEndPoint(ipAddr, 11000);
            s = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // Соединяем сокет с удаленной точкой
            s.Connect(ipEndPoint);
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            var request  = new AnimalRequest
            {
                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Get
            };
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            var request = new AnimalRequest
            {
                Animal = new Animal { 
                    Title = textBoxTitle.Text,
                    Latin_Title = textBoxLatin_Title.Text,
                    Habitat = textBoxHabitat.Text,
                    Protection_Status = comboBoxProtectionStatus.Text},              

                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Add
            };
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var request = new AnimalRequest
            {
                Animal = new Animal
                {
                    Title = textBoxTitle.Text,
                    Latin_Title = textBoxLatin_Title.Text,
                    Habitat = textBoxHabitat.Text,
                    Protection_Status = comboBoxProtectionStatus.Text
                },
                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Update
            };
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var request = new AnimalRequest
            {
                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Get
            };
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
