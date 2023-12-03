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
            this.SuspendLayout();
            // 
            // addVoteButton
            // 
            this.addVoteButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addVoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVoteButton.ForeColor = System.Drawing.Color.White;
            this.addVoteButton.Location = new System.Drawing.Point(705, 12);
            this.addVoteButton.Name = "addVoteButton";
            this.addVoteButton.Size = new System.Drawing.Size(127, 34);
            this.addVoteButton.TabIndex = 0;
            this.addVoteButton.Text = "Add vote";
            this.addVoteButton.UseVisualStyleBackColor = false;
            this.addVoteButton.Click += new System.EventHandler(this.addVoteButton_Click);
            // 
            // VoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.addVoteButton);
            this.Name = "VoteList";
            this.Size = new System.Drawing.Size(850, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addVoteButton;
    }
}
