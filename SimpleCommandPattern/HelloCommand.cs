using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern
{
    public class HelloCommand : ICommand
    {
        private int count = 0;
        public void Execute()
        {
            count++;
            Console.WriteLine($"Hello Friend {count}");
        }
        public void Undo()
        {
            count--;
        }



    }
}
