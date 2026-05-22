using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee Coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            Coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return Coffee.GetDescription();
        }

        public virtual double GetPrice()
        {
            return Coffee.GetPrice();
        }
    }
}
