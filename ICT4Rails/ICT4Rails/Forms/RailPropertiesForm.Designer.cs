namespace ICT4Rails.Classes.Models
{
    partial class RailPropertiesForm
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
            this.lbl_rail = new System.Windows.Forms.Label();
            this.btn_block = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rail
            // 
            this.lbl_rail.AutoSize = true;
            this.lbl_rail.Location = new System.Drawing.Point(13, 13);
            this.lbl_rail.Name = "lbl_rail";
            this.lbl_rail.Size = new System.Drawing.Size(100, 17);
            this.lbl_rail.TabIndex = 0;
            this.lbl_rail.Text = "Huidig spoort: ";
            // 
            // btn_block
            // 
            this.btn_block.Location = new System.Drawing.Point(16, 177);
            this.btn_block.Name = "btn_block";
            this.btn_block.Size = new System.Drawing.Size(118, 38);
            this.btn_block.TabIndex = 2;
            this.btn_block.Text = "Blokeer";
            this.btn_block.UseVisualStyleBackColor = true;
            this.btn_block.Click += new System.EventHandler(this.btn_block_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(313, 177);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 35);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Terug";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // RailPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 227);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_block);
            this.Controls.Add(this.lbl_rail);
            this.Name = "RailPropertiesForm";
            this.Text = "RailPropertiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rail;
        private System.Windows.Forms.Button btn_block;
        private System.Windows.Forms.Button btn_back;
    }
}