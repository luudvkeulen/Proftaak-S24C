namespace ICT4Rails
{
    partial class LoginForm
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
            this.lblLoginName = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginName
            // 
            this.lblLoginName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.Location = new System.Drawing.Point(32, 31);
            this.lblLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(161, 23);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "Gebruikersnaam:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginName.Location = new System.Drawing.Point(211, 32);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(201, 22);
            this.txtLoginName.TabIndex = 1;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginPassword.Location = new System.Drawing.Point(211, 70);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(201, 22);
            this.txtLoginPassword.TabIndex = 3;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(72, 69);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(126, 23);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "Wachtwoord:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(440, 32);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 63);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 126);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.lblLoginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

