namespace ICT4Rails
{
    partial class OverviewForm
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
            this.btnBeheerSysteem = new System.Windows.Forms.Button();
            this.btnTechniekSysteem = new System.Windows.Forms.Button();
            this.btnSchoonmaakSysteem = new System.Windows.Forms.Button();
            this.btninuitrijsysteem = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeheerSysteem
            // 
            this.btnBeheerSysteem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBeheerSysteem.BackColor = System.Drawing.Color.Silver;
            this.btnBeheerSysteem.Enabled = false;
            this.btnBeheerSysteem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeheerSysteem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeheerSysteem.Location = new System.Drawing.Point(113, 67);
            this.btnBeheerSysteem.Name = "btnBeheerSysteem";
            this.btnBeheerSysteem.Size = new System.Drawing.Size(298, 151);
            this.btnBeheerSysteem.TabIndex = 0;
            this.btnBeheerSysteem.Text = "Beheer Systeem";
            this.btnBeheerSysteem.UseVisualStyleBackColor = false;
            // 
            // btnTechniekSysteem
            // 
            this.btnTechniekSysteem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTechniekSysteem.BackColor = System.Drawing.Color.Silver;
            this.btnTechniekSysteem.Enabled = false;
            this.btnTechniekSysteem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechniekSysteem.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnTechniekSysteem.Location = new System.Drawing.Point(459, 252);
            this.btnTechniekSysteem.Name = "btnTechniekSysteem";
            this.btnTechniekSysteem.Size = new System.Drawing.Size(298, 151);
            this.btnTechniekSysteem.TabIndex = 1;
            this.btnTechniekSysteem.Text = "Techniek Systeem";
            this.btnTechniekSysteem.UseVisualStyleBackColor = false;
            // 
            // btnSchoonmaakSysteem
            // 
            this.btnSchoonmaakSysteem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSchoonmaakSysteem.BackColor = System.Drawing.Color.Silver;
            this.btnSchoonmaakSysteem.Enabled = false;
            this.btnSchoonmaakSysteem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchoonmaakSysteem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchoonmaakSysteem.Location = new System.Drawing.Point(459, 67);
            this.btnSchoonmaakSysteem.Name = "btnSchoonmaakSysteem";
            this.btnSchoonmaakSysteem.Size = new System.Drawing.Size(298, 151);
            this.btnSchoonmaakSysteem.TabIndex = 2;
            this.btnSchoonmaakSysteem.Text = "Schoonmaak Systeem";
            this.btnSchoonmaakSysteem.UseVisualStyleBackColor = false;
            // 
            // btninuitrijsysteem
            // 
            this.btninuitrijsysteem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btninuitrijsysteem.BackColor = System.Drawing.Color.Silver;
            this.btninuitrijsysteem.Enabled = false;
            this.btninuitrijsysteem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninuitrijsysteem.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btninuitrijsysteem.Location = new System.Drawing.Point(113, 252);
            this.btninuitrijsysteem.Name = "btninuitrijsysteem";
            this.btninuitrijsysteem.Size = new System.Drawing.Size(298, 151);
            this.btninuitrijsysteem.TabIndex = 3;
            this.btninuitrijsysteem.Text = "In/Uitrij Systeem";
            this.btninuitrijsysteem.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnLogout.Location = new System.Drawing.Point(113, 434);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(644, 108);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICT4Rails.Properties.Resources.darkrailbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 579);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btninuitrijsysteem);
            this.Controls.Add(this.btnSchoonmaakSysteem);
            this.Controls.Add(this.btnTechniekSysteem);
            this.Controls.Add(this.btnBeheerSysteem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "OverviewForm";
            this.ShowIcon = false;
            this.Text = "OverviewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeheerSysteem;
        private System.Windows.Forms.Button btnTechniekSysteem;
        private System.Windows.Forms.Button btnSchoonmaakSysteem;
        private System.Windows.Forms.Button btninuitrijsysteem;
        private System.Windows.Forms.Button btnLogout;
    }
}