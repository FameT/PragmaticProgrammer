using System;

namespace MiniLangLib.Sources
{
    /// <summary>
    /// Gets commands.
    /// </summary>
    public interface ICommandsSource
    {
        event EventHandler<CommandEventArgs> CommandReceived;
    }
}
