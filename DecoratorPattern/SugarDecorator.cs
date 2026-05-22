using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return Coffee.GetDescription() + " + Sugar";
        }

        public override double GetPrice()
        {
            return Coffee.GetPrice() + 3;
        }
    }
}
