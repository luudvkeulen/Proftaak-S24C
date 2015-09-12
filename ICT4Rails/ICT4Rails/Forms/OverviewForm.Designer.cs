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
            this.btnBeheerSysteem.Location = new System.Drawing.Point(12, 12);
            this.btnBeheerSysteem.Name = "btnBeheerSysteem";
            this.btnBeheerSysteem.Size = new System.Drawing.Size(144, 74);
            this.btnBeheerSysteem.TabIndex = 0;
            this.btnBeheerSysteem.Text = "Beheer Systeem";
            this.btnBeheerSysteem.UseVisualStyleBackColor = true;
            // 
            // btnTechniekSysteem
            // 
            this.btnTechniekSysteem.Location = new System.Drawing.Point(12, 92);
            this.btnTechniekSysteem.Name = "btnTechniekSysteem";
            this.btnTechniekSysteem.Size = new System.Drawing.Size(144, 74);
            this.btnTechniekSysteem.TabIndex = 1;
            this.btnTechniekSysteem.Text = "Techniek Systeem";
            this.btnTechniekSysteem.UseVisualStyleBackColor = true;
            // 
            // btnSchoonmaakSysteem
            // 
            this.btnSchoonmaakSysteem.Location = new System.Drawing.Point(162, 12);
            this.btnSchoonmaakSysteem.Name = "btnSchoonmaakSysteem";
            this.btnSchoonmaakSysteem.Size = new System.Drawing.Size(144, 74);
            this.btnSchoonmaakSysteem.TabIndex = 2;
            this.btnSchoonmaakSysteem.Text = "Schoonmaak Systeem";
            this.btnSchoonmaakSysteem.UseVisualStyleBackColor = true;
            // 
            // btninuitrijsysteem
            // 
            this.btninuitrijsysteem.Location = new System.Drawing.Point(162, 92);
            this.btninuitrijsysteem.Name = "btninuitrijsysteem";
            this.btninuitrijsysteem.Size = new System.Drawing.Size(144, 74);
            this.btninuitrijsysteem.TabIndex = 3;
            this.btninuitrijsysteem.Text = "In/Uitrij Systeem";
            this.btninuitrijsysteem.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 172);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(294, 55);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Uitloggen";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 241);
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