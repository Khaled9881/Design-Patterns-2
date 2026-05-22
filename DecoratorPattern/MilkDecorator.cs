using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return Coffee.GetDescription() + " + Milk";
        }

        public override double GetPrice()
        {
            return Coffee.GetPrice() + 2;
        }
    }
}
