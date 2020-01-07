namespace Hastahane.FormUI.Forms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.txtLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginUsername.ForeColor = System.Drawing.Color.White;
            this.txtLoginUsername.Location = new System.Drawing.Point(31, 50);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(435, 26);
            this.txtLoginUsername.TabIndex = 2;
            this.txtLoginUsername.Text = "HKorkmazDev";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(61, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(375, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.White;
            this.txtLoginPassword.Location = new System.Drawing.Point(31, 126);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(435, 26);
            this.txtLoginPassword.TabIndex = 3;
            this.txtLoginPassword.Text = "12345678";
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Delete_32px;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(463, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.LoginLogo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 251);
            this.panel4.TabIndex = 7;
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Tesla_96pxWhite;
            this.LoginLogo.Location = new System.Drawing.Point(89, 88);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(75, 75);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginLogo.TabIndex = 0;
            this.LoginLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(31, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 3);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(31, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 3);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLoginPassword);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtLoginUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 251);
            this.panel2.TabIndex = 13;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(748, 251);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}