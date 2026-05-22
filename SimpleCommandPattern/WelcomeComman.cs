using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern
{
    public class WelcomeComman : ICommand
    {
        private int count = 0;

        public void Execute()
        {
            count++;
            Console.WriteLine($"Welcome Mate {count}");
        }

        public void Undo()
        {
            count--;
        }
    }
}
