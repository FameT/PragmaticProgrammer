namespace MiniLangLib.Commands
{
    public abstract class PenStateChangingCommand : CommandBase
    {
        public PenStateChangingCommand(char commandLetter, string commandName) :
            base(commandName, $"[{char.ToUpper(commandLetter)}{char.ToLower(commandLetter)}]$")
        {
        }
    }
}