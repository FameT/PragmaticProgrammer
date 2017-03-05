using System;

namespace MiniLangLib.Drawers
{
    public abstract class DrawerBase : IDrawer
    {
        #region IDrawer implementation

        private readonly DrawerState _state = new DrawerState();

        protected DrawerState State { get { return _state; } }

        IDrawerState IDrawer.State { get { return State; } }

        public virtual void MoveTo(Direction direction, int distance)
        {
            var to = CalculateNewCoordinates(direction, distance);
            if (State.PenState == PenState.Down)
            {
                DrawLine(State.CurrentCoordinates, to);
            }
            State.CurrentCoordinates = to;
        }

        public virtual void PenDown()
        {
            SetPenState(PenState.Down);
        }

        public virtual void PenUp()
        {
            SetPenState(PenState.Up);
        }

        public virtual void SelectPen(int penNumber)
        {
            State.PenNumber = penNumber;
        }

        #endregion

        #region Virtual members

        protected virtual void SetPenState(PenState penState)
        {
            State.PenState = penState;
        }

        protected virtual void DrawLine(Coordinates from, Coordinates to)
        {
            return;
        }

        protected virtual Coordinates CalculateNewCoordinates(Direction direction, int distance)
        {
            int x;
            int y;

            switch (direction)
            {
                case Direction.North:
                    x = 0;
                    y = -1;
                    break;
                case Direction.South:
                    x = 0;
                    y = 1;
                    break;
                case Direction.East:
                    x = 1;
                    y = 0;
                    break;
                case Direction.West:
                    x = -1;
                    y = 0;
                    break;
                default:
                    throw new NotSupportedException($"This direction is not supported: {direction}.");
            }

            x = State.CurrentCoordinates.X + x * distance;
            y = State.CurrentCoordinates.Y + y * distance;

            return new Coordinates(x, y);
        }

        #endregion
    }
}
