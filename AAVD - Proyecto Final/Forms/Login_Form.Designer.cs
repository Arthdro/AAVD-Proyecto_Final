namespace AAVD___Proyecto_Final
{
    partial class Login_Form
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbUserData = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.ckBoxSPassword = new System.Windows.Forms.CheckBox();
            this.gbUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(29, 196);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(78, 29);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 196);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbUserData
            // 
            this.gbUserData.Controls.Add(this.ckBoxSPassword);
            this.gbUserData.Controls.Add(this.lblPassword);
            this.gbUserData.Controls.Add(this.lblName);
            this.gbUserData.Controls.Add(this.txtboxPassword);
            this.gbUserData.Controls.Add(this.txtboxUsername);
            this.gbUserData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbUserData.Location = new System.Drawing.Point(29, 15);
            this.gbUserData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUserData.Name = "gbUserData";
            this.gbUserData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUserData.Size = new System.Drawing.Size(195, 148);
            this.gbUserData.TabIndex = 2;
            this.gbUserData.TabStop = false;
            this.gbUserData.Text = "User data";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPassword.Location = new System.Drawing.Point(69, 72);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(69, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Username";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(23, 90);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(143, 20);
            this.txtboxPassword.TabIndex = 11;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(23, 46);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(146, 20);
            this.txtboxUsername.TabIndex = 10;
            // 
            // ckBoxSPassword
            // 
            this.ckBoxSPassword.AutoSize = true;
            this.ckBoxSPassword.Location = new System.Drawing.Point(46, 118);
            this.ckBoxSPassword.Name = "ckBoxSPassword";
            this.ckBoxSPassword.Size = new System.Drawing.Size(101, 17);
            this.ckBoxSPassword.TabIndex = 14;
            this.ckBoxSPassword.Text = "Show password";
            this.ckBoxSPassword.UseVisualStyleBackColor = true;
            this.ckBoxSPassword.CheckedChanged += new System.EventHandler(this.ckBoxSPassword_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(256, 258);
            this.Controls.Add(this.gbUserData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogIn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbUserData.ResumeLayout(false);
            this.gbUserData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbUserData;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.CheckBox ckBoxSPassword;
    }
}

