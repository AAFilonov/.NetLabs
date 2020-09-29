using System.Collections.Generic;

namespace Lab4
{


    ///<summary>
    ///Сервис проката  
    ///</summary>
    public class RentService
    {
        /// <summary>
        /// Единственный экземпляр класса RentService
        /// </summary>
        private static RentService _instance;


        ///<summery>
        /// Словарь клиентов
        ///</summery
        private Dictionary<int, Client> _clients  = new Dictionary<int, Client>();
        ///<summary>
        ///Словарь автомобилей
        ///</summary> 
        private Dictionary<int, Car> _cars = new Dictionary<int, Car>();
        ///<summary>
        ///Список выданных автомобилей
        ///</summary>
       private  List<RentedCar> _rentedCars = new List<RentedCar>();
        public IEnumerable<Client> Clients
        {
            get { return _clients.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция номеров
        /// </summary>
        public IEnumerable<Car> Cars
        {
            get
            {
                return _cars.Values.AsEnumerable(); ;
            }
        }
        /// <summary>
        /// Коллекция поселений
        /// </summary>
        public IEnumerable<RentedCar> RentedCars
        {
            get
            {
                return _rentedCars;
            }
        }


        public static RentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RentService();
                }
                return _instance;
            }
        }
        private RentService()
        {

        }

    }
}
