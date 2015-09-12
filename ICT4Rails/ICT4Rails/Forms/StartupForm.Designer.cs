namespace ICT4Rails
{
    partial class StartupForm
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
            this.lblConnecting = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(238, 42);
            this.Controls.Add(this.lblConnecting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConnecting;
    }
}