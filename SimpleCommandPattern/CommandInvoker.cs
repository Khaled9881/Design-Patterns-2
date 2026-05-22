using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern
{
    public class CommandInvoker
    {
        private List<ICommand> _commands;

        public CommandInvoker()
        {
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            this._commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in this._commands)
                command.Execute();
        }
    }
}
