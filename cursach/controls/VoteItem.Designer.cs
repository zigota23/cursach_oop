namespace cursach.controls
{
    partial class VoteItem
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.lblCreateAt = new System.Windows.Forms.Label();
            this.clsVote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(22, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(45, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(23, 47);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // lblCreateAt
            // 
            this.lblCreateAt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreateAt.AutoSize = true;
            this.lblCreateAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCreateAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateAt.ForeColor = System.Drawing.Color.White;
            this.lblCreateAt.Location = new System.Drawing.Point(607, 29);
            this.lblCreateAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAt.Name = "lblCreateAt";
            this.lblCreateAt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCreateAt.Size = new System.Drawing.Size(72, 20);
            this.lblCreateAt.TabIndex = 2;
            this.lblCreateAt.Text = "create at";
            // 
            // clsVote
            // 
            this.clsVote.AutoSize = true;
            this.clsVote.BackColor = System.Drawing.Color.Transparent;
            this.clsVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clsVote.ForeColor = System.Drawing.Color.White;
            this.clsVote.Location = new System.Drawing.Point(773, 7);
            this.clsVote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clsVote.Name = "clsVote";
            this.clsVote.Size = new System.Drawing.Size(20, 20);
            this.clsVote.TabIndex = 3;
            this.clsVote.Text = "X";
            this.clsVote.Click += new System.EventHandler(this.clsVote_Click);
            // 
            // VoteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.clsVote);
            this.Controls.Add(this.lblCreateAt);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VoteItem";
            this.Size = new System.Drawing.Size(800, 85);
            this.Load += new System.EventHandler(this.VoteItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label lblCreateAt;
        private System.Windows.Forms.Label clsVote;
    }
}
