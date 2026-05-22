using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builderpattern2
{
    public class Pizaa
    {
        public string Size { get; set; }

        public bool Cheese { get; set; }

        public bool Pepperoni { get; set; }

        public override string ToString()
        {
            return $"{Size} {Cheese} {Pepperoni}";
        }
    }
}
