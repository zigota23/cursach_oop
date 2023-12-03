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
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.codeeloGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.Fuchsia;
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.codeeloGradientPanel1.Controls.Add(this.yesButton);
            this.codeeloGradientPanel1.Controls.Add(this.noButton);
            this.codeeloGradientPanel1.Controls.Add(this.descriptionLabel);
            this.codeeloGradientPanel1.Controls.Add(this.titleLabel);
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel1.DrawGradient = true;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(410, 351);
            this.codeeloGradientPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.titleLabel.Location = new System.Drawing.Point(36, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.descriptionLabel.Location = new System.Drawing.Point(37, 76);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(102, 24);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "description";
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Firebrick;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.Color.White;
            this.noButton.Location = new System.Drawing.Point(47, 243);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(117, 41);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.LimeGreen;
            this.yesButton.Location = new System.Drawing.Point(247, 243);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(117, 41);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(410, 351);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VoteForm";
            this.Text = "VoteForm";
            this.codeeloGradientPanel1.ResumeLayout(false);
            this.codeeloGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label descriptionLabel;
    }
}