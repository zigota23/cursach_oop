namespace cursach
{
    partial class VoteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NextVotingQuestionButton = new System.Windows.Forms.Button();
            this.questionComboBox = new System.Windows.Forms.ComboBox();
            this.OnFormClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vote panel";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.submitButton.Location = new System.Drawing.Point(72, 405);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(165, 43);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 8;
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSize = true;
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(724, 25);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(63, 20);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(632, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vote";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(560, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(452, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Personal Info";
            // 
            // NextVotingQuestionButton
            // 
            this.NextVotingQuestionButton.Location = new System.Drawing.Point(562, 405);
            this.NextVotingQuestionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextVotingQuestionButton.Name = "NextVotingQuestionButton";
            this.NextVotingQuestionButton.Size = new System.Drawing.Size(162, 43);
            this.NextVotingQuestionButton.TabIndex = 10;
            this.NextVotingQuestionButton.Text = "NEXT";
            this.NextVotingQuestionButton.UseVisualStyleBackColor = true;
            // 
            // questionComboBox
            // 
            this.questionComboBox.FormattingEnabled = true;
            this.questionComboBox.Location = new System.Drawing.Point(72, 162);
            this.questionComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.questionComboBox.Name = "questionComboBox";
            this.questionComboBox.Size = new System.Drawing.Size(300, 28);
            this.questionComboBox.TabIndex = 11;
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.OnFormClose);
            this.Controls.Add(this.questionComboBox);
            this.Controls.Add(this.NextVotingQuestionButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VoteForm";
            this.Text = "VoteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogOutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button NextVotingQuestionButton;
        private System.Windows.Forms.ComboBox questionComboBox;
        private System.Windows.Forms.Label OnFormClose;
    }
}