using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class CarType
    {
        string type;
        public CarType(string type)
        {
            this.type = type;
        }

        public string Get_type
        {
            get
            {
                return type;
            }
        }
    }
}
