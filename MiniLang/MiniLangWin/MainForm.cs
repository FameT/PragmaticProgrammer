using MiniLangLib.Drawers;
using MiniLangLib.Sources;
using System;
using System.Windows.Forms;

namespace MiniLangWin
{
    public partial class MainForm : Form, ICommandsSource
    {
        public MainForm()
        {
            InitializeComponent();
            _commandHandler = new CommandHandler(this, new WinFormsDrawer(pnlCanvas.CreateGraphics()));
        }

        private readonly CommandHandler _commandHandler;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtCommandText.Focus();
        }

        #region ICommandsSource implementation

        public event EventHandler<CommandEventArgs> CommandReceived;

        protected virtual void OnCommandReceived(CommandEventArgs e)
        {
            var temp = CommandReceived;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        #endregion

        #region Private methods

        #region Event handlers

        /// <summary>
        /// Handles mouse click on "Execute" button.
        /// </summary>
        /// <param name="sender">Event source.</param>
        /// <param name="e">An object containing event data.</param>
        private void ExecuteCommandHandler(object sender, EventArgs e)
        {
            ExecuteCommand();
        }

        /// <summary>
        /// Handles pressing a key while entering a command text.
        /// </summary>
        /// <param name="sender">Event source.</param>
        /// <param name="e">An object containing event data.</param>
        private void CommandTextKeyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || e.Modifiers != Keys.None)
            {
                return;
            }

            ExecuteCommand();
        }

        #endregion

        private void ExecuteCommand()
        {
            txtCommandText.Enabled = false;
            var e = new CommandEventArgs(txtCommandText.Text);
            OnCommandReceived(e);
            if (!string.IsNullOrWhiteSpace(e.CommandProcessingError))
            {
                txtCommandOutput.Text += Environment.NewLine;
                txtCommandOutput.Text += e.CommandProcessingError;
            }

            txtCommandText.Clear();
            txtCommandText.Enabled = true;
            txtCommandText.Focus();
        }

        #endregion
    }
}
