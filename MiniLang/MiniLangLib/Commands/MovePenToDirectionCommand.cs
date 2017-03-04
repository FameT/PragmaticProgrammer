using MiniLangLib.Drawers;
using System.Text.RegularExpressions;

namespace MiniLangLib.Commands
{
    class MovePenToDirectionCommand : CommandBase
    {
        public MovePenToDirectionCommand() : base("Draw a line to a direction", "([NnEeSsWw]) (\\d+)$")
        {
        }

        private const byte NumberOfRegexGroups = 3;

        private const byte DirectionRegexGroupIndex = 1;

        private const byte DistanceRegexGroupIndex = 2;

        public override void Execute()
        {
            if (Drawer != null)
            {
                Drawer.MoveTo(Direction, Distance);
            }
        }

        protected override void HandleMatch(Match match)
        {
            base.HandleMatch(match);

            if (match.Groups.Count != NumberOfRegexGroups)
            {
                throw new CommandParserException($"Invalid number of groups: {match.Groups.Count} (must be {NumberOfRegexGroups}).");
            }

            // Direction
            Direction direction;
            var directionStr = match.Groups[DirectionRegexGroupIndex].Value;
            switch (directionStr)
            {
                case "N":
                case "n":
                    direction = Direction.North;
                    break;
                case "E":
                case "e":
                    direction = Direction.East;
                    break;
                case "S":
                case "s":
                    direction = Direction.South;
                    break;
                case "W":
                case "w":
                    direction = Direction.West;
                    break;
                default:
                    throw new CommandParserException($"Unknown direction: {directionStr}.");
            }
            Direction = direction;

            // Distance
            var distanceStr = match.Groups[DistanceRegexGroupIndex].Value;
            int distance;
            if (!int.TryParse(distanceStr, out distance))
            {
                throw new CommandParserException($"Invalid distance: {distanceStr}.");
            }
            Distance = distance;
        }

        public override string ToString()
        {
            return $"MovePenToDirectionCommand[Direction = {Direction}, Distance = {Distance}]";
        }

        public Direction Direction { get; set; }

        public int Distance { get; set; }
    }
}