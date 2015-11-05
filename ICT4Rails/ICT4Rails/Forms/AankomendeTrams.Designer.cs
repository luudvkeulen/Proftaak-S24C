namespace ICT4Rails
{
    partial class AankomendeTrams
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
            this.lbAankomendeTrams = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbAankomendeTrams
            // 
            this.lbAankomendeTrams.FormattingEnabled = true;
            this.lbAankomendeTrams.Location = new System.Drawing.Point(12, 12);
            this.lbAankomendeTrams.Name = "lbAankomendeTrams";
            this.lbAankomendeTrams.Size = new System.Drawing.Size(513, 303);
            this.lbAankomendeTrams.TabIndex = 0;
            // 
            // AankomendeTrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 329);
            this.Controls.Add(this.lbAankomendeTrams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AankomendeTrams";
            this.ShowIcon = false;
            this.Text = "AankomendeTreinen";
            this.Shown += new System.EventHandler(this.AankomendeTreinen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAankomendeTrams;


    }
}