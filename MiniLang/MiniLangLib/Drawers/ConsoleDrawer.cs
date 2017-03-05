using System;

namespace MiniLangLib.Drawers
{
    public class ConsoleDrawer : DrawerBase
    {
        protected override void DrawLine(Coordinates from, Coordinates to)
        {
            base.DrawLine(from, to);
            Console.WriteLine($"{from}--------------{to}.");   // TODO: sth better
        }
    }
}
