namespace cursach.controls
{
    partial class VoteList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addVoteButton = new System.Windows.Forms.Button();
            this.voteListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addVoteButton
            // 
            this.addVoteButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addVoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVoteButton.ForeColor = System.Drawing.Color.White;
            this.addVoteButton.Location = new System.Drawing.Point(691, 5);
            this.addVoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addVoteButton.Name = "addVoteButton";
            this.addVoteButton.Size = new System.Drawing.Size(141, 37);
            this.addVoteButton.TabIndex = 0;
            this.addVoteButton.Text = "Add vote";
            this.addVoteButton.UseVisualStyleBackColor = false;
            this.addVoteButton.Click += new System.EventHandler(this.addVoteButton_Click);
            // 
            // voteListPanel
            // 
            this.voteListPanel.AutoScroll = true;
            this.voteListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.voteListPanel.Location = new System.Drawing.Point(0, 52);
            this.voteListPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voteListPanel.Name = "voteListPanel";
            this.voteListPanel.Size = new System.Drawing.Size(850, 353);
            this.voteListPanel.TabIndex = 1;
            // 
            // VoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.voteListPanel);
            this.Controls.Add(this.addVoteButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VoteList";
            this.Size = new System.Drawing.Size(850, 405);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVoteButton;
        private System.Windows.Forms.Panel voteListPanel;
    }
}
