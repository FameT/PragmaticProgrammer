using System.Drawing;

namespace MiniLangLib.Drawers
{
    public class WinFormsDrawer : DrawerBase
    {
        public WinFormsDrawer(Graphics graphics)
        {
            _graphics = graphics;
        }

        private readonly Graphics _graphics;

        private Graphics Graphics { get { return _graphics; } }

        private readonly Pen _pen = new Pen(Color.Black);

        private Pen Pen { get { return _pen; } }

        #region Overrides

        public override void SelectPen(int penNumber)
        {
            Pen.Width = penNumber;
            base.SelectPen(penNumber);
        }

        protected override void DrawLine(Coordinates from, Coordinates to)
        {
            base.DrawLine(from, to);
            Graphics.DrawLine(Pen, from.X, from.Y, to.X, to.Y);
        }

        #endregion
    }
}