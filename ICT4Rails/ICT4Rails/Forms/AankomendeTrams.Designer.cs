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
            this.lbAankomendeTrams.BackColor = System.Drawing.SystemColors.Control;
            this.lbAankomendeTrams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAankomendeTrams.ForeColor = System.Drawing.Color.Black;
            this.lbAankomendeTrams.FormattingEnabled = true;
            this.lbAankomendeTrams.ItemHeight = 16;
            this.lbAankomendeTrams.Location = new System.Drawing.Point(13, 13);
            this.lbAankomendeTrams.Margin = new System.Windows.Forms.Padding(4);
            this.lbAankomendeTrams.Name = "lbAankomendeTrams";
            this.lbAankomendeTrams.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbAankomendeTrams.Size = new System.Drawing.Size(693, 368);
            this.lbAankomendeTrams.TabIndex = 0;
            this.lbAankomendeTrams.TabStop = false;
            this.lbAankomendeTrams.UseTabStops = false;
            // 
            // AankomendeTrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 405);
            this.Controls.Add(this.lbAankomendeTrams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AankomendeTrams";
            this.ShowIcon = false;
            this.Text = "Aankomende treinen";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.AankomendeTreinen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAankomendeTrams;


    }
}