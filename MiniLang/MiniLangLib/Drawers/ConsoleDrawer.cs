using System;

namespace MiniLangLib.Drawers
{
    public class ConsoleDrawer : DrawerBase
    {
        public override void MoveTo(Direction direction, int distance)
        {
            Console.WriteLine($"{distance} to the {direction}.");   // TODO: sth better
            base.MoveTo(direction, distance);
        }
    }
}
