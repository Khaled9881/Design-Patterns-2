using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern
{
    public class HelloCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Hello Friend");
        }
    }
}
