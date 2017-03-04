using System.Collections.Generic;

namespace MiniLangLib.Commands
{
    public class CommandParser : ICommandParser
    {
        #region Constructors

        public CommandParser()
        {
            InitCommands();
        }

        #endregion

        #region ICommandParser implementations

        public ICommand Parse(string commandText)
        {
            ICommand result = null;
            foreach (var command in _commands)
            {
                if(command.Parse(commandText))
                {
                    if (result == null)
                    {
                        result = command;
                    }
                    else
                    {
                        throw new CommandParserException($"Ambiguous command: {commandText}. Both {result.Name} and {command.Name} fit it.");
                    }
                }
            }

            if (result == null)
            {
                throw new CommandParserException($"Unknown command: {commandText}");
            }

            return result;
        }

        #endregion

        #region Commands

        private IList<ICommand> _commands = new List<ICommand>();

        private void AddCommand<T>() where T:ICommand, new()
        {
            _commands.Add(new T());
        }

        private void InitCommands()
        {
            AddCommand<PenSelectionCommand>();
            AddCommand<PenDownCommand>();
            AddCommand<PenUpCommand>();
            AddCommand<MovePenToDirectionCommand>();
        }

        #endregion
    }
}
