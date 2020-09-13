using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    ///<summary>
    ///Сервис проката  
    ///</summary>
    public class RentService
    {
        ///<summery>
        /// Словарь клиентов
        ///</summery
        public static Dictionary<int, Client>
        Clients { get; } = new Dictionary<int, Client>();
        ///<summary>
        ///Словарь автомобилей
        ///</summary> 
        public static Dictionary<int, Car>
        Cars { get; } = new Dictionary<int, Car>();
        ///<summary>
        ///Список выданных автомобилей
        ///</summary>
        public static List<RentedCar> RentedCars
        {
            get;
        } = new List<RentedCar>();

    }
}
