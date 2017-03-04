using MiniLangLib.Drawers;
using MiniLangLib.Sources;

namespace MiniLang
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandReader = new ConsoleCommandsReader();
            var drawer = new ConsoleDrawer();

            using (new CommandHandler(commandReader, drawer))
            {
                commandReader.Start();
            }
        }
    }
}