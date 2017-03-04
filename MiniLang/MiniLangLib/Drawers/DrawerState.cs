using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLangLib.Drawers
{
    public class DrawerState : IDrawerState
    {
        #region IDrawerState implementation

        public int PenNumber { get; set; }

        public PenState PenState { get; set; }

        public Coordinates CurrentCoordinates { get; set; }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"Pen #{PenNumber} is {PenState} in {CurrentCoordinates}.";
        }

        #endregion
    }
}