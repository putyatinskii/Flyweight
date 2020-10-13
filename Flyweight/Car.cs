using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Car 
    {
        string color;
        string firm;
        CarType carType;
        public Car(string color, string firm, CarType carType)
        {
            this.color = color;
            this.firm = firm;
            this.carType = carType;
        }

        public override string ToString()
        {
            return "Автомобиль относится к типу: " + carType.Get_type + ". Произведен фирмой: " + firm + ". Цвет автомобиля: " + color; 
        }
    }
}
