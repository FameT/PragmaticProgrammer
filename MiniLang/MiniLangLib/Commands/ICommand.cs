using MiniLangLib.Drawers;

namespace MiniLangLib.Commands
{
    public interface ICommand
    {
        bool Parse(string input);
        void Execute();
        IDrawer Drawer { get; set; }
        string Name { get; }
    }
}
