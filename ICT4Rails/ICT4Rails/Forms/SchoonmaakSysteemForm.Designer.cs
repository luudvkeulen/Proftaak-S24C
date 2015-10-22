namespace ICT4Rails
{
    partial class SchoonmaakSysteemForm
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
			this.cbUsers = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lvTrams = new System.Windows.Forms.ListView();
			this.TRAMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DATEADDED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DATEFINISHED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FINISHEDBY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.OPMERKING = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btChangeDate = new System.Windows.Forms.Button();
			this.btFinished = new System.Windows.Forms.Button();
			this.FINISHED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
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
			// cbUsers
			// 
			this.cbUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbUsers.FormattingEnabled = true;
			this.cbUsers.Location = new System.Drawing.Point(195, 506);
			this.cbUsers.Name = "cbUsers";
			this.cbUsers.Size = new System.Drawing.Size(356, 21);
			this.cbUsers.TabIndex = 19;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dateTimePicker1.Location = new System.Drawing.Point(565, 506);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(356, 20);
			this.dateTimePicker1.TabIndex = 18;
			// 
			// lvTrams
			// 
			this.lvTrams.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lvTrams.BackColor = System.Drawing.Color.Silver;
			this.lvTrams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TRAMID,
            this.DATEADDED,
            this.DATEFINISHED,
            this.FINISHEDBY,
            this.FINISHED,
            this.OPMERKING});
			this.lvTrams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvTrams.Location = new System.Drawing.Point(195, 95);
			this.lvTrams.Name = "lvTrams";
			this.lvTrams.Size = new System.Drawing.Size(726, 395);
			this.lvTrams.TabIndex = 17;
			this.lvTrams.UseCompatibleStateImageBehavior = false;
			this.lvTrams.View = System.Windows.Forms.View.Details;
			// 
			// TRAMID
			// 
			this.TRAMID.Text = "Tram";
			this.TRAMID.Width = 56;
			// 
			// DATEADDED
			// 
			this.DATEADDED.Text = "Begindatum";
			this.DATEADDED.Width = 104;
			// 
			// DATEFINISHED
			// 
			this.DATEFINISHED.Text = "Einddatum";
			this.DATEFINISHED.Width = 103;
			// 
			// FINISHEDBY
			// 
			this.FINISHEDBY.Text = "Schoonmaker";
			this.FINISHEDBY.Width = 141;
			// 
			// OPMERKING
			// 
			this.OPMERKING.Text = "Opmerking";
			this.OPMERKING.Width = 134;
			// 
			// btChangeDate
			// 
			this.btChangeDate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btChangeDate.BackColor = System.Drawing.Color.Silver;
			this.btChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btChangeDate.Font = new System.Drawing.Font("Arial", 15.75F);
			this.btChangeDate.Location = new System.Drawing.Point(565, 532);
			this.btChangeDate.Name = "btChangeDate";
			this.btChangeDate.Size = new System.Drawing.Size(356, 82);
			this.btChangeDate.TabIndex = 16;
			this.btChangeDate.Text = "Einddatum opslaan";
			this.btChangeDate.UseVisualStyleBackColor = false;
			this.btChangeDate.Click += new System.EventHandler(this.btChangeDate_Click);
			// 
			// btFinished
			// 
			this.btFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btFinished.BackColor = System.Drawing.Color.Silver;
			this.btFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFinished.Font = new System.Drawing.Font("Arial", 15.75F);
			this.btFinished.Location = new System.Drawing.Point(195, 532);
			this.btFinished.Name = "btFinished";
			this.btFinished.Size = new System.Drawing.Size(356, 82);
			this.btFinished.TabIndex = 15;
			this.btFinished.Text = "Schoongemaakt";
			this.btFinished.UseVisualStyleBackColor = false;
			this.btFinished.Click += new System.EventHandler(this.btFinished_Click);
			// 
			// FINISHED
			// 
			this.FINISHED.Text = "Klaar";
			// 
			// SchoonmaakSysteemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ICT4Rails.Properties.Resources.darkrailbackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1117, 708);
			this.Controls.Add(this.cbUsers);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lvTrams);
			this.Controls.Add(this.btChangeDate);
			this.Controls.Add(this.btFinished);
			this.Controls.Add(this.btnBack);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "SchoonmaakSysteemForm";
			this.ShowIcon = false;
			this.Text = "OverviewForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.SchoonmaakSysteemForm_Shown);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ComboBox cbUsers;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ListView lvTrams;
		private System.Windows.Forms.ColumnHeader TRAMID;
		private System.Windows.Forms.ColumnHeader DATEADDED;
		private System.Windows.Forms.ColumnHeader DATEFINISHED;
		private System.Windows.Forms.ColumnHeader FINISHEDBY;
		private System.Windows.Forms.Button btChangeDate;
		private System.Windows.Forms.Button btFinished;
		private System.Windows.Forms.ColumnHeader OPMERKING;
		private System.Windows.Forms.ColumnHeader FINISHED;
	}
}