using MiniLangLib.Commands;
using MiniLangLib.Drawers;
using System;

namespace MiniLangLib.Sources
{
    public class CommandHandler : IDisposable
    {
        #region Constructors

        public CommandHandler(ICommandsSource commandsSource, IDrawer drawer) : this(commandsSource, new CommandParser(), drawer)
        {

        }

        public CommandHandler(ICommandsSource commandsSource, ICommandParser parser, IDrawer drawer)
        {
            if (commandsSource == null)
            {
                throw new ArgumentNullException(nameof(commandsSource));
            }

            if (drawer == null)
            {
                throw new ArgumentNullException(nameof(drawer));
            }

            if (parser == null)
            {
                throw new ArgumentNullException(nameof(parser));
            }

            CommandsSource = commandsSource;
            Drawer = drawer;
            Parser = parser;
        }

        #endregion

        #region Properties

        private ICommandsSource _commandsSource;

        public ICommandsSource CommandsSource
        {
            get { return _commandsSource; }
            private set
            {
                if (_commandsSource != null)
                {
                    _commandsSource.CommandReceived -= CommandReceivedHandler;
                }
                _commandsSource = value;
                if (_commandsSource != null)
                {
                    _commandsSource.CommandReceived += CommandReceivedHandler;
                }
            }
        }

        public IDrawer Drawer { get; private set; }

        public ICommandParser Parser { get; private set; }

        #endregion

        #region IDisposable pattern

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    CommandsSource = null;
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion

        #region Event handlers

        private void CommandReceivedHandler(object sender, CommandEventArgs e)
        {
            try
            {
                var command = Parser.Parse(e.CommandText);
                command.Drawer = Drawer;
                command.Execute();
            }
            catch (Exception ex)
            {
                e.CommandProcessingError = ex.Message;
            }
        }

        #endregion
    }
}