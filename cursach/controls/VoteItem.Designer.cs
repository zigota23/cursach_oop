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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoteItem));
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
            this.titleLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.titleLabel.Location = new System.Drawing.Point(15, 9);
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
            this.descriptionLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.descriptionLabel.Location = new System.Drawing.Point(16, 33);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // lblCreateAt
            // 
            this.lblCreateAt.AutoSize = true;
            this.lblCreateAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCreateAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateAt.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblCreateAt.Location = new System.Drawing.Point(584, 12);
            this.lblCreateAt.Name = "lblCreateAt";
            this.lblCreateAt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCreateAt.Size = new System.Drawing.Size(51, 20);
            this.lblCreateAt.TabIndex = 2;
            this.lblCreateAt.Text = "label1";
            // 
            // clsVote
            // 
            this.clsVote.AutoSize = true;
            this.clsVote.BackColor = System.Drawing.Color.Transparent;
            this.clsVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clsVote.Location = new System.Drawing.Point(730, 0);
            this.clsVote.Name = "clsVote";
            this.clsVote.Size = new System.Drawing.Size(20, 20);
            this.clsVote.TabIndex = 3;
            this.clsVote.Text = "X";
            this.clsVote.Click += new System.EventHandler(this.clsVote_Click);
            // 
            // VoteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.clsVote);
            this.Controls.Add(this.lblCreateAt);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "VoteItem";
            this.Size = new System.Drawing.Size(750, 100);
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
