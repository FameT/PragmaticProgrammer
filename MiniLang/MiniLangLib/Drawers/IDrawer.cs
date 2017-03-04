namespace MiniLangLib.Drawers
{
    public interface IDrawer
    {
        IDrawerState State { get; }
        void SelectPen(int penNumber);
        void PenDown();
        void PenUp();
        void MoveTo(Direction direction, int distance);      
    }
}