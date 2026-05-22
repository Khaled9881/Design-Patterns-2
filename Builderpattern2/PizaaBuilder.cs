using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builderpattern2
{
    public class PizaaBuilder
    {
        private Pizaa pizaa;
        public PizaaBuilder()
        {
            pizaa = new Pizaa();
        }

        public PizaaBuilder AddCheese()
        {
            pizaa.Cheese = true;
            return this;
        }

        public PizaaBuilder SetSize(string size)
        {
            pizaa.Size = size;
            return this;
        }

        public PizaaBuilder AddPepperoni()
        {
            pizaa.Pepperoni = true;
            return this;
        }

        public Pizaa Build()
        {
            return pizaa;
        }
    }
}
