using System;
namespace MiniLangLib.Commands
{
    public class CommandParserException : ApplicationException
    {
        public CommandParserException(string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }
}
