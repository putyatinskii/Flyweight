using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Car_Factory car_Factory = new Car_Factory();
            CarType Lorry = car_Factory.Get_CarType("Lorry");
            Car car = new Car("белый", "BMW", Lorry);
            Console.WriteLine(car);

            CarType Sportscar = car_Factory.Get_CarType("Sportscar");
            Car car2 = new Car("красный", "Mercedes-Benz", Sportscar);
            Console.WriteLine(car2);

            CarType Jeep = car_Factory.Get_CarType("Jeep");
            Car car3 = new Car("зеленый", "Mercedes-Benz", Jeep);
            Console.WriteLine(car3);
        }
    }
}
