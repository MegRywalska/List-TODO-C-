namespace ListTODO.Controll
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.lblValidationLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.btnSingUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValidationLogin
            // 
            this.lblValidationLogin.AutoSize = true;
            this.lblValidationLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationLogin.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidationLogin.ForeColor = System.Drawing.Color.White;
            this.lblValidationLogin.Location = new System.Drawing.Point(105, 447);
            this.lblValidationLogin.Name = "lblValidationLogin";
            this.lblValidationLogin.Size = new System.Drawing.Size(490, 31);
            this.lblValidationLogin.TabIndex = 0;
            this.lblValidationLogin.Text = "Incorrect login or password!";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbLogin.Location = new System.Drawing.Point(200, 293);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(300, 34);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Login...";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin.UseWaitCursor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPassword.Location = new System.Drawing.Point(200, 361);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(300, 34);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password...";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseWaitCursor = true;
            // 
            // btnSingIn
            // 
            this.btnSingIn.BackColor = System.Drawing.Color.White;
            this.btnSingIn.FlatAppearance.BorderSize = 0;
            this.btnSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingIn.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.btnSingIn.Location = new System.Drawing.Point(111, 539);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(200, 60);
            this.btnSingIn.TabIndex = 3;
            this.btnSingIn.Text = "Sing in";
            this.btnSingIn.UseVisualStyleBackColor = false;
            // 
            // btnSingUp
            // 
            this.btnSingUp.BackColor = System.Drawing.Color.White;
            this.btnSingUp.FlatAppearance.BorderSize = 0;
            this.btnSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUp.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSingUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.btnSingUp.Location = new System.Drawing.Point(395, 539);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(200, 60);
            this.btnSingUp.TabIndex = 4;
            this.btnSingUp.Text = "Sing up";
            this.btnSingUp.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.btnSingUp);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblValidationLogin);
            this.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(700, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidationLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.Button btnSingUp;
    }
}
