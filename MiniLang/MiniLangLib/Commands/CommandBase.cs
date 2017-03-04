using System.Text.RegularExpressions;
using MiniLangLib.Drawers;

namespace MiniLangLib.Commands
{
    public abstract class CommandBase : ICommand
    {
        #region Constructors

        protected CommandBase(string name, string regex)
        {
            Name = name;
            RegexText = regex;
        }

        #endregion

        #region Properties

        private Regex _regex;

        public Regex Regex
        {
            get
            {
                if (_regex == null)
                {
                    _regex = new Regex(RegexText, RegexOptions.Compiled);
                }

                return _regex;
            }
        }

        public string RegexText
        {
            get; private set;
        }

        #endregion

        #region Virtual members

        protected virtual void HandleMatch(Match match)
        {

        }

        #endregion

        #region ICommand implementation

        public virtual bool Parse(string input)
        {
            var match = Regex.Match(input);
            if (!match.Success)
            {
                return false;
            }
            else
            {
                HandleMatch(match);
                return true;
            }
        }

        public abstract void Execute();

        public IDrawer Drawer { get; set; }

        public string Name { get; private set; }

        #endregion
    }
}