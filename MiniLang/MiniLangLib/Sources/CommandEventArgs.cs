namespace MiniLangLib.Sources
{
    public class CommandEventArgs
    {
        public CommandEventArgs(string commandText)
        {
            CommandText = commandText;
        }

        public string CommandText { get; private set; }

        public string CommandProcessingError { get; set; }

        public override string ToString()
        {
            return "CommandEventArgs[CommandText = " + CommandText + ", CommandProcessingError = " + CommandProcessingError + "]";
        }
    }
}