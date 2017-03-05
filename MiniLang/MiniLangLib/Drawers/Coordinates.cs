﻿namespace MiniLangLib.Drawers
{
    public struct Coordinates
    {
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
