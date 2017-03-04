namespace MiniLangLib.Commands
{
    public interface ICommandParser
    {
        ICommand Parse(string commandText);
    }
}
