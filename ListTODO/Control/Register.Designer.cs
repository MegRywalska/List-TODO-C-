namespace ListTODO.Control
{
    partial class Register
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
            this.btnSingUp = new System.Windows.Forms.Button();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSingUp
            // 
            this.btnSingUp.BackColor = System.Drawing.Color.White;
            this.btnSingUp.FlatAppearance.BorderSize = 0;
            this.btnSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUp.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSingUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.btnSingUp.Location = new System.Drawing.Point(395, 543);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(200, 60);
            this.btnSingUp.TabIndex = 9;
            this.btnSingUp.Text = "Sign up";
            this.btnSingUp.UseVisualStyleBackColor = false;
            this.btnSingUp.Click += new System.EventHandler(this.SignUpButtonClick);
            // 
            // btnSingIn
            // 
            this.btnSingIn.BackColor = System.Drawing.Color.White;
            this.btnSingIn.FlatAppearance.BorderSize = 0;
            this.btnSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingIn.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.btnSingIn.Location = new System.Drawing.Point(111, 543);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(200, 60);
            this.btnSingIn.TabIndex = 8;
            this.btnSingIn.Text = "Sign in";
            this.btnSingIn.UseVisualStyleBackColor = false;
            this.btnSingIn.Click += new System.EventHandler(this.SignInButtonClick);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPassword.Location = new System.Drawing.Point(203, 415);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(300, 34);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Text = "Password...";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseWaitCursor = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbLogin.Location = new System.Drawing.Point(203, 347);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(300, 34);
            this.tbLogin.TabIndex = 6;
            this.tbLogin.Text = "Login...";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin.UseWaitCursor = true;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbName.Location = new System.Drawing.Point(203, 277);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 34);
            this.tbName.TabIndex = 10;
            this.tbName.Text = "Name...";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.UseWaitCursor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListTODO.Properties.Resources.Red_Sunset;
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSingUp);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Font = new System.Drawing.Font("Courier New", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(700, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingUp;
        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbName;
    }
}
