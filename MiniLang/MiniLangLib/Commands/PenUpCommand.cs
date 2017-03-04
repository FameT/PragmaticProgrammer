namespace MiniLangLib.Commands
{
    public class PenUpCommand : PenStateChangingCommand
    {
        public PenUpCommand() : base('U', "Pen UP")
        {
        }

        public override void Execute()
        {
            if (Drawer != null)
            {
                Drawer.PenUp();
            }
        }
    }
}
