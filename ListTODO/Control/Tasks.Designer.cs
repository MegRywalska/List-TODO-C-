namespace ListTODO.Control
{
    partial class Tasks
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
            this.taskList = new System.Windows.Forms.ListView();
            this.task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.done = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTask = new System.Windows.Forms.ListView();
            this.btnTrash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSingOut = new System.Windows.Forms.Button();
            this.lblValidationLogin = new System.Windows.Forms.Label();
            this.lblUserSignedUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskList
            // 
            this.taskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.task,
            this.done});
            this.taskList.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.taskList.FullRowSelect = true;
            this.taskList.GridLines = true;
            this.taskList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.taskList.HideSelection = false;
            this.taskList.Location = new System.Drawing.Point(18, 165);
            this.taskList.MultiSelect = false;
            this.taskList.Name = "taskList";
            this.taskList.ShowGroups = false;
            this.taskList.Size = new System.Drawing.Size(665, 717);
            this.taskList.TabIndex = 0;
            this.taskList.UseCompatibleStateImageBehavior = false;
            this.taskList.View = System.Windows.Forms.View.Details;
            // 
            // task
            // 
            this.task.Text = "Task";
            this.task.Width = 544;
            // 
            // done
            // 
            this.done.Text = "Done";
            this.done.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.done.Width = 112;
            // 
            // lstTask
            // 
            this.lstTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTask.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.lstTask.FullRowSelect = true;
            this.lstTask.GridLines = true;
            this.lstTask.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTask.HideSelection = false;
            this.lstTask.Location = new System.Drawing.Point(20, 280);
            this.lstTask.MultiSelect = false;
            this.lstTask.Name = "lstTask";
            this.lstTask.ShowGroups = false;
            this.lstTask.Size = new System.Drawing.Size(661, 603);
            this.lstTask.TabIndex = 0;
            this.lstTask.UseCompatibleStateImageBehavior = false;
            this.lstTask.View = System.Windows.Forms.View.Details;
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.White;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.btnTrash.Location = new System.Drawing.Point(468, 91);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(215, 60);
            this.btnTrash.TabIndex = 6;
            this.btnTrash.Text = "🗑";
            this.btnTrash.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.button1.Location = new System.Drawing.Point(243, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "🖉";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.button2.Location = new System.Drawing.Point(18, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 60);
            this.button2.TabIndex = 8;
            this.button2.Text = "🞤";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSingOut
            // 
            this.btnSingOut.BackColor = System.Drawing.Color.White;
            this.btnSingOut.FlatAppearance.BorderSize = 0;
            this.btnSingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingOut.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSingOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.btnSingOut.Location = new System.Drawing.Point(18, 16);
            this.btnSingOut.Name = "btnSingOut";
            this.btnSingOut.Size = new System.Drawing.Size(215, 60);
            this.btnSingOut.TabIndex = 9;
            this.btnSingOut.Text = "Sign out";
            this.btnSingOut.UseVisualStyleBackColor = false;
            this.btnSingOut.Click += new System.EventHandler(this.SignOutButtonClick);
            // 
            // lblValidationLogin
            // 
            this.lblValidationLogin.AutoSize = true;
            this.lblValidationLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationLogin.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidationLogin.ForeColor = System.Drawing.Color.White;
            this.lblValidationLogin.Location = new System.Drawing.Point(177, 16);
            this.lblValidationLogin.Name = "lblValidationLogin";
            this.lblValidationLogin.Size = new System.Drawing.Size(0, 31);
            this.lblValidationLogin.TabIndex = 10;
            // 
            // lblUserSignedUp
            // 
            this.lblUserSignedUp.AutoSize = true;
            this.lblUserSignedUp.BackColor = System.Drawing.Color.White;
            this.lblUserSignedUp.Font = new System.Drawing.Font("Courier New", 16F);
            this.lblUserSignedUp.Location = new System.Drawing.Point(468, 16);
            this.lblUserSignedUp.MinimumSize = new System.Drawing.Size(215, 60);
            this.lblUserSignedUp.Name = "lblUserSignedUp";
            this.lblUserSignedUp.Size = new System.Drawing.Size(215, 60);
            this.lblUserSignedUp.TabIndex = 11;
            this.lblUserSignedUp.Text = "UserSignedUp";
            this.lblUserSignedUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListTODO.Properties.Resources.Red_Sunset;
            this.Controls.Add(this.lblUserSignedUp);
            this.Controls.Add(this.lblValidationLogin);
            this.Controls.Add(this.btnSingOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTrash);
            this.Controls.Add(this.taskList);
            this.Font = new System.Drawing.Font("Courier New", 10.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tasks";
            this.Size = new System.Drawing.Size(700, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView taskList;
        private System.Windows.Forms.ColumnHeader task;
        private System.Windows.Forms.ColumnHeader done;
        private System.Windows.Forms.ListView lstTask;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSingOut;
        private System.Windows.Forms.Label lblValidationLogin;
        private System.Windows.Forms.Label lblUserSignedUp;
    }
}
