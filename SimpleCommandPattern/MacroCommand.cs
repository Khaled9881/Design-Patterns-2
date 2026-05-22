using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern
{
    public class MacroCommand : ICommand
    {

        private List<ICommand> _coomands;
        private Stack<ICommand> _UndoCommands;
        private Stack<ICommand> RedoCommands;
        public MacroCommand(List<ICommand> commands)
        {
            _coomands = commands;
            _UndoCommands = new Stack<ICommand>();
            RedoCommands = new Stack<ICommand>();
        }

        public void Execute()
        {
            foreach (var command in _coomands)
                command.Execute();
        }

        public void Undo()
        {
            if (_UndoCommands.Count > 0)
            {

                _UndoCommands.Push(_coomands[_coomands.Count() - 1]);
                _coomands.Remove(_coomands[_coomands.Count() - 1]);
            }
        }

        public void Redo()
        {
            if (_UndoCommands.Count > 0)
            {
                ICommand command = _UndoCommands.Pop();
                _coomands.Add(command);
            }
        }
    }
}
