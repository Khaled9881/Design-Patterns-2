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
        private Stack<ICommand> ExecutedCoomands;
        private Stack<ICommand> _undo;

        public CommandInvoker()
        {
            _commands = new List<ICommand>();
            ExecutedCoomands = new Stack<ICommand>();
            _undo = new Stack<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            this._commands.Add(command);
            ExecutedCoomands.Push(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in ExecutedCoomands)
                Execute(command);

            _commands.Clear();
        }

        private void Execute(ICommand command)
        {
            command.Execute();
        }

        public void Undo()
        {
            var co = ExecutedCoomands.Pop();
            _undo.Push(co);
            co.Undo();
        }


        public void Redo()
        {
            var co = _undo.Pop();
            ExecutedCoomands.Push(co);
        }


    }
}
