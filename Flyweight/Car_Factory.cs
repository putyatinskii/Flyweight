using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Car_Factory
    {
        static List<CarType> car_list = new List<CarType>();
        public Car_Factory()
        {
            car_list.Add(new CarType("Lorry"));
            car_list.Add(new CarType("Sportscar"));
        }

        public CarType Get_CarType(string s)
        {
            CarType carType = car_list.Find(x => x.Get_type == s);
            if (carType == null)
            {
                carType = new CarType(s);
                car_list.Add(carType);
            }
            return carType;
        }
    }
}
