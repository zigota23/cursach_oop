namespace cursach
{
    partial class VoteAddForm
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
            this.CreateNewVotingButton = new System.Windows.Forms.Button();
            this.textBoxNewVotingQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateNewVotingButton
            // 
            this.CreateNewVotingButton.Location = new System.Drawing.Point(807, 494);
            this.CreateNewVotingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateNewVotingButton.Name = "CreateNewVotingButton";
            this.CreateNewVotingButton.Size = new System.Drawing.Size(286, 109);
            this.CreateNewVotingButton.TabIndex = 0;
            this.CreateNewVotingButton.Text = "button1";
            this.CreateNewVotingButton.UseVisualStyleBackColor = true;
            this.CreateNewVotingButton.Click += new System.EventHandler(this.CreateNewVotingButton_Click);
            // 
            // textBoxNewVotingQuestion
            // 
            this.textBoxNewVotingQuestion.Location = new System.Drawing.Point(62, 148);
            this.textBoxNewVotingQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewVotingQuestion.Multiline = true;
            this.textBoxNewVotingQuestion.Name = "textBoxNewVotingQuestion";
            this.textBoxNewVotingQuestion.Size = new System.Drawing.Size(642, 189);
            this.textBoxNewVotingQuestion.TabIndex = 1;
            // 
            // VoteAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.textBoxNewVotingQuestion);
            this.Controls.Add(this.CreateNewVotingButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VoteAddForm";
            this.Text = "VoteAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateNewVotingButton;
        private System.Windows.Forms.TextBox textBoxNewVotingQuestion;
    }
}