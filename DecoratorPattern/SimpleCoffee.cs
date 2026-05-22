using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return ("Here is ur Simple Coffee");
        }

        public double GetPrice()
        {
            return 5;
        }
    }
}
