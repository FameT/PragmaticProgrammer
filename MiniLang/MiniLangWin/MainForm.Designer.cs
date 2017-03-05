namespace MiniLangWin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.btnExecuteCommand = new System.Windows.Forms.Button();
            this.txtCommandText = new System.Windows.Forms.TextBox();
            this.txtCommandOutput = new System.Windows.Forms.TextBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tlpRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRoot.Controls.Add(this.btnExecuteCommand, 1, 1);
            this.tlpRoot.Controls.Add(this.txtCommandText, 0, 1);
            this.tlpRoot.Controls.Add(this.txtCommandOutput, 0, 2);
            this.tlpRoot.Controls.Add(this.pnlCanvas, 0, 0);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpRoot.Size = new System.Drawing.Size(784, 483);
            this.tlpRoot.TabIndex = 0;
            // 
            // btnExecuteCommand
            // 
            this.btnExecuteCommand.AutoSize = true;
            this.btnExecuteCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecuteCommand.Location = new System.Drawing.Point(706, 356);
            this.btnExecuteCommand.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.btnExecuteCommand.Name = "btnExecuteCommand";
            this.btnExecuteCommand.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteCommand.TabIndex = 0;
            this.btnExecuteCommand.Text = "Execute";
            this.btnExecuteCommand.UseVisualStyleBackColor = true;
            this.btnExecuteCommand.Click += new System.EventHandler(this.ExecuteCommandHandler);
            // 
            // txtCommandText
            // 
            this.txtCommandText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommandText.Location = new System.Drawing.Point(3, 356);
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Size = new System.Drawing.Size(688, 20);
            this.txtCommandText.TabIndex = 1;
            this.txtCommandText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommandTextKeyUpHandler);
            // 
            // txtCommandOutput
            // 
            this.txtCommandOutput.BackColor = System.Drawing.Color.White;
            this.tlpRoot.SetColumnSpan(this.txtCommandOutput, 2);
            this.txtCommandOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommandOutput.Location = new System.Drawing.Point(3, 385);
            this.txtCommandOutput.Multiline = true;
            this.txtCommandOutput.Name = "txtCommandOutput";
            this.txtCommandOutput.ReadOnly = true;
            this.txtCommandOutput.Size = new System.Drawing.Size(778, 95);
            this.txtCommandOutput.TabIndex = 2;
            // 
            // pnlCanvas
            // 
            this.tlpRoot.SetColumnSpan(this.pnlCanvas, 2);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(6, 6);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(6);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(772, 341);
            this.pnlCanvas.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.tlpRoot);
            this.Name = "MainForm";
            this.Text = "MiniLang";
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Button btnExecuteCommand;
        private System.Windows.Forms.TextBox txtCommandText;
        private System.Windows.Forms.TextBox txtCommandOutput;
        private System.Windows.Forms.Panel pnlCanvas;
    }
}

