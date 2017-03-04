namespace MiniLangLib.Commands
{
    public class PenDownCommand : PenStateChangingCommand
    {
        public PenDownCommand() : base('D', "Pen DOWN")
        {
        }

        public override void Execute()
        {
            if (Drawer != null)
            {
                Drawer.PenDown();
            }
        }
    }
}
