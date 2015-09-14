namespace ICT4Rails
{
    partial class AdminPanelForm
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
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListView();
            this.Gebruikersnaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnDeleteUser.Location = new System.Drawing.Point(565, 488);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(356, 108);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "Gebruiker verwijderen";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateUser.BackColor = System.Drawing.Color.Silver;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCreateUser.Location = new System.Drawing.Point(195, 488);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(356, 108);
            this.btnCreateUser.TabIndex = 8;
            this.btnCreateUser.Text = "Nieuwe Gebruiker";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnBack.Location = new System.Drawing.Point(891, 657);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(214, 39);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listUsers
            // 
            this.listUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listUsers.BackColor = System.Drawing.Color.Silver;
            this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gebruikersnaam,
            this.Rol});
            this.listUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.Location = new System.Drawing.Point(195, 77);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(726, 395);
            this.listUsers.TabIndex = 12;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            // 
            // Gebruikersnaam
            // 
            this.Gebruikersnaam.Text = "Gebruikersnaam";
            this.Gebruikersnaam.Width = 363;
            // 
            // Rol
            // 
            this.Rol.Text = "Rol";
            this.Rol.Width = 359;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICT4Rails.Properties.Resources.darkrailbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 708);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnCreateUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminPanelForm";
            this.ShowIcon = false;
            this.Text = "OverviewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.AdminPanelForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ColumnHeader Gebruikersnaam;
        private System.Windows.Forms.ColumnHeader Rol;
    }
}