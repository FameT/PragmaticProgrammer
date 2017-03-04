using System.Text.RegularExpressions;

namespace MiniLangLib.Commands
{
    public class PenSelectionCommand : CommandBase
    {
        public PenSelectionCommand() : base("Pen selection", "([Pp]) (\\d+)$")
        {
        }

        private const int NumberOfRegexGroups = 3;

        private const int PenNumberRegexGroupIndex = 2;

        public override void Execute()
        {
            if (Drawer != null && Drawer.State != null)
            {
                Drawer.SelectPen(PenNumber);
            }
        }

        protected override void HandleMatch(Match match)
        {
            base.HandleMatch(match);

            if (match.Groups.Count != NumberOfRegexGroups)
            {
                throw new CommandParserException($"Invalid number of groups: {match.Groups.Count} (must be {NumberOfRegexGroups}).");
            }

            var penNumberStr = match.Groups[PenNumberRegexGroupIndex].Value;
            int penNumber;
            if (!int.TryParse(penNumberStr, out penNumber))
            {
                throw new CommandParserException($"Invalid pen number: {penNumberStr}.");
            }

            PenNumber = penNumber;
        }

        public override string ToString()
        {
            return $"PenSelectionCommand[PenNumber = {PenNumber}]";
        }

        public int PenNumber { get; set; }
    }
}