using System;

namespace MiniLangLib.Sources
{
    public class ConsoleCommandsReader : ICommandsSource
    {
        public void Start()
        {
            Console.WriteLine("Welcome to MiniLang Console.");
            while (true)
            {
                Console.WriteLine("Please, enter command and hit <Enter> or press <Ctrl>+<C> to exit.");
                var command = Console.ReadLine();
                var e = new CommandEventArgs(command);
                OnCommandReceived(e);
                if (!string.IsNullOrWhiteSpace(e.CommandProcessingError))
                {
                    Console.WriteLine($"Error when trying to execute command: {e.CommandProcessingError}");
                }
            }
        }

        #region CommandReceived event

        public event EventHandler<CommandEventArgs> CommandReceived;

        protected virtual void OnCommandReceived(CommandEventArgs e)
        {
            var temp = CommandReceived;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        #endregion
    }
}
