﻿namespace ICT4Rails
{
    partial class Startup
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
            this.progressConnect = new System.Windows.Forms.ProgressBar();
            this.lblConnecting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressConnect
            // 
            this.progressConnect.Location = new System.Drawing.Point(12, 35);
            this.progressConnect.Name = "progressConnect";
            this.progressConnect.Size = new System.Drawing.Size(211, 23);
            this.progressConnect.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressConnect.TabIndex = 0;
            // 
            // lblConnecting
            // 
            this.lblConnecting.AutoSize = true;
            this.lblConnecting.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnecting.Location = new System.Drawing.Point(12, 9);
            this.lblConnecting.Name = "lblConnecting";
            this.lblConnecting.Size = new System.Drawing.Size(211, 23);
            this.lblConnecting.TabIndex = 1;
            this.lblConnecting.Text = "Connecting to the database...";
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 78);
            this.Controls.Add(this.lblConnecting);
            this.Controls.Add(this.progressConnect);
            this.Name = "Startup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressConnect;
        private System.Windows.Forms.Label lblConnecting;
    }
}