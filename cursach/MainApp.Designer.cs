namespace cursach
{
    partial class MainApp
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
            this.voteListControl = new cursach.controls.VoteList();
            this.contactControl = new cursach.controls.Contact();
            this.profileControl = new cursach.controls.Profile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.Label();
            this.codeeloGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.Fuchsia;
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.codeeloGradientPanel1.Controls.Add(this.voteListControl);
            this.codeeloGradientPanel1.Controls.Add(this.contactControl);
            this.codeeloGradientPanel1.Controls.Add(this.profileControl);
            this.codeeloGradientPanel1.Controls.Add(this.panel1);
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel1.DrawGradient = true;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(850, 467);
            this.codeeloGradientPanel1.TabIndex = 0;
            // 
            // voteListControl
            // 
            this.voteListControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voteListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voteListControl.Location = new System.Drawing.Point(0, 60);
            this.voteListControl.Name = "voteListControl";
            this.voteListControl.Size = new System.Drawing.Size(850, 407);
            this.voteListControl.TabIndex = 12;
            // 
            // contactControl
            // 
            this.contactControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactControl.Location = new System.Drawing.Point(0, 60);
            this.contactControl.Name = "contactControl";
            this.contactControl.Size = new System.Drawing.Size(850, 407);
            this.contactControl.TabIndex = 11;
            // 
            // profileControl
            // 
            this.profileControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileControl.Location = new System.Drawing.Point(0, 60);
            this.profileControl.Name = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(850, 407);
            this.profileControl.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 60);
            this.panel1.TabIndex = 9;
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSize = true;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(778, 22);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(63, 20);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(684, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vote";
            this.label6.Click += new System.EventHandler(this.Vote_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(612, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contact";
            this.label7.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.ForeColor = System.Drawing.Color.White;
            this.Profile.Location = new System.Drawing.Point(553, 22);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(53, 20);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(850, 467);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.codeeloGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogOutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Profile;
        private controls.Profile profileControl;
        private controls.Contact contactControl;
        private controls.VoteList voteListControl;
    }
}