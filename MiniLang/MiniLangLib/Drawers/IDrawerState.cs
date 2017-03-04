namespace MiniLangLib.Drawers
{
    public interface IDrawerState
    {
        int PenNumber { get; }
        PenState PenState { get; }
        Coordinates CurrentCoordinates { get; }
    }
}
