using Lab4;
using System;

/*Прокат автомобилей
2. Клиенты (фамилия, имя, отчество, адрес, телефон).*/
namespace Lab4
{
    
    /// Клиент
    public class Client : IValidatable
    {
       public FIO Fio { get; set; } = new FIO();
        /// Адрес
        public string Adress { get; set; } = "";
        /// Номер телефонаы
        public string PhoneNumber { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if
                (!Fio.IsValid)return false;
                if
                (string.IsNullOrWhiteSpace(Adress)) return false;
                if
                (string.IsNullOrWhiteSpace(PhoneNumber)) return false;
                return true;
            }
        }


        public Client()
        {
        }
        public Client(string firstName, string
        lastName, string middleName,string adress,string phoneNumber)
        {
            Fio = new FIO(firstName, lastName, middleName);
            Adress = adress;
            PhoneNumber = phoneNumber;
            
        }
        public override string ToString()
        {
            return $" {Fio}Адресс: { Adress}\r\nНомер телефона: { PhoneNumber}\r\n";
        }
    }

}
