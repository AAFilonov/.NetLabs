using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class FIO: IValidatable
    {
        /// Имя
        public string FirstName { get; set; } = "";
        /// Отчество
        public string MiddleName { get; set; } = "";
        /// Фамилия
        public string LastName { get; set; } = "";
        public bool IsValid
        {
            get
            {
                if
                (string.IsNullOrWhiteSpace(FirstName)) return false;
                if
                (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if
                (string.IsNullOrWhiteSpace(LastName)) return false;
                return true;
            }
        }
       
        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя:{ FirstName}\r\nОтчество: { MiddleName}\r\n";
        }
   
        public FIO()
        {
        }
        public FIO(string firstName, string
        lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;

        }
    }
}
