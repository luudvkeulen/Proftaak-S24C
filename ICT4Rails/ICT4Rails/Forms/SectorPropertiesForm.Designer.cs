namespace ICT4Rails
{
    partial class SectorPropertiesForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_place = new System.Windows.Forms.Button();
            this.lbl_curr_train = new System.Windows.Forms.Label();
            this.txtbox_tram = new System.Windows.Forms.TextBox();
            this.btn_filthy = new System.Windows.Forms.Button();
            this.btn_repair = new System.Windows.Forms.Button();
            this.cbBlocked = new System.Windows.Forms.CheckBox();
            this.txtb_opmerking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(769, 443);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trein keuze";
            // 
            // btn_reservation
            // 
            this.btn_reservation.Location = new System.Drawing.Point(13, 371);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(134, 50);
            this.btn_reservation.TabIndex = 4;
            this.btn_reservation.Text = "Reserveer";
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_place
            // 
            this.btn_place.Location = new System.Drawing.Point(217, 371);
            this.btn_place.Name = "btn_place";
            this.btn_place.Size = new System.Drawing.Size(134, 50);
            this.btn_place.TabIndex = 5;
            this.btn_place.Text = "Plaats de trein op deze sector";
            this.btn_place.UseVisualStyleBackColor = true;
            this.btn_place.Click += new System.EventHandler(this.btn_place_Click);
            // 
            // lbl_curr_train
            // 
            this.lbl_curr_train.AutoSize = true;
            this.lbl_curr_train.Location = new System.Drawing.Point(450, 19);
            this.lbl_curr_train.Name = "lbl_curr_train";
            this.lbl_curr_train.Size = new System.Drawing.Size(190, 17);
            this.lbl_curr_train.TabIndex = 6;
            this.lbl_curr_train.Text = "Huidige trein op deze sector:";
            // 
            // txtbox_tram
            // 
            this.txtbox_tram.Location = new System.Drawing.Point(13, 44);
            this.txtbox_tram.Name = "txtbox_tram";
            this.txtbox_tram.Size = new System.Drawing.Size(195, 22);
            this.txtbox_tram.TabIndex = 7;
            // 
            // btn_filthy
            // 
            this.btn_filthy.Location = new System.Drawing.Point(511, 371);
            this.btn_filthy.Name = "btn_filthy";
            this.btn_filthy.Size = new System.Drawing.Size(109, 50);
            this.btn_filthy.TabIndex = 8;
            this.btn_filthy.Text = "Tram is vies";
            this.btn_filthy.UseVisualStyleBackColor = true;
            this.btn_filthy.Click += new System.EventHandler(this.btn_filthy_Click);
            // 
            // btn_repair
            // 
            this.btn_repair.Location = new System.Drawing.Point(637, 371);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(109, 50);
            this.btn_repair.TabIndex = 9;
            this.btn_repair.Text = "Tram is kapot";
            this.btn_repair.UseVisualStyleBackColor = true;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // cbBlocked
            // 
            this.cbBlocked.AutoSize = true;
            this.cbBlocked.Location = new System.Drawing.Point(16, 15);
            this.cbBlocked.Margin = new System.Windows.Forms.Padding(4);
            this.cbBlocked.Name = "cbBlocked";
            this.cbBlocked.Size = new System.Drawing.Size(111, 21);
            this.cbBlocked.TabIndex = 1;
            this.cbBlocked.Text = "Geblokkeerd";
            this.cbBlocked.UseVisualStyleBackColor = true;
            this.cbBlocked.CheckedChanged += new System.EventHandler(this.cbBlocked_CheckedChanged);
            // 
            // txtb_opmerking
            // 
            this.txtb_opmerking.Location = new System.Drawing.Point(531, 162);
            this.txtb_opmerking.Name = "txtb_opmerking";
            this.txtb_opmerking.Size = new System.Drawing.Size(313, 22);
            this.txtb_opmerking.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opmerking";
            // 
            // SectorPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_opmerking);
            this.Controls.Add(this.btn_repair);
            this.Controls.Add(this.btn_filthy);
            this.Controls.Add(this.txtbox_tram);
            this.Controls.Add(this.lbl_curr_train);
            this.Controls.Add(this.btn_place);
            this.Controls.Add(this.btn_reservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBlocked);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SectorPropertiesForm";
            this.Text = "SectorPropertiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_place;
        private System.Windows.Forms.Label lbl_curr_train;
        private System.Windows.Forms.TextBox txtbox_tram;
        private System.Windows.Forms.Button btn_filthy;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.CheckBox cbBlocked;
        private System.Windows.Forms.TextBox txtb_opmerking;
        private System.Windows.Forms.Label label2;
    }
}