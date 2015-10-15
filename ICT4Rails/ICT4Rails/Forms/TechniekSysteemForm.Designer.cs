namespace ICT4Rails
{
    partial class TechniekSysteemForm
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
			this.btChangeDate = new System.Windows.Forms.Button();
			this.btFinished = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.lvTrains = new System.Windows.Forms.ListView();
			this.Train = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Engineer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Finished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbUsers = new System.Windows.Forms.ComboBox();
			this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btChangeDate
			// 
			this.btChangeDate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btChangeDate.BackColor = System.Drawing.Color.Silver;
			this.btChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btChangeDate.Font = new System.Drawing.Font("Arial", 15.75F);
			this.btChangeDate.Location = new System.Drawing.Point(565, 514);
			this.btChangeDate.Name = "btChangeDate";
			this.btChangeDate.Size = new System.Drawing.Size(356, 82);
			this.btChangeDate.TabIndex = 10;
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
			this.btFinished.Location = new System.Drawing.Point(195, 514);
			this.btFinished.Name = "btFinished";
			this.btFinished.Size = new System.Drawing.Size(356, 82);
			this.btFinished.TabIndex = 8;
			this.btFinished.Text = "Gerepareerd";
			this.btFinished.UseVisualStyleBackColor = false;
			this.btFinished.Click += new System.EventHandler(this.btFinished_Click);
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
			// lvTrains
			// 
			this.lvTrains.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lvTrains.BackColor = System.Drawing.Color.Silver;
			this.lvTrains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Train,
            this.StartDate,
            this.EndDate,
            this.Engineer,
            this.Finished,
            this.Comment});
			this.lvTrains.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvTrains.Location = new System.Drawing.Point(195, 77);
			this.lvTrains.Name = "lvTrains";
			this.lvTrains.Size = new System.Drawing.Size(726, 395);
			this.lvTrains.TabIndex = 12;
			this.lvTrains.UseCompatibleStateImageBehavior = false;
			this.lvTrains.View = System.Windows.Forms.View.Details;
			// 
			// Train
			// 
			this.Train.Text = "Trein";
			this.Train.Width = 48;
			// 
			// StartDate
			// 
			this.StartDate.Text = "Begindatum";
			this.StartDate.Width = 104;
			// 
			// EndDate
			// 
			this.EndDate.Text = "Einddatum";
			this.EndDate.Width = 103;
			// 
			// Engineer
			// 
			this.Engineer.Text = "Technicus";
			this.Engineer.Width = 113;
			// 
			// Finished
			// 
			this.Finished.Text = "Klaar";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(565, 488);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(356, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// cbUsers
			// 
			this.cbUsers.FormattingEnabled = true;
			this.cbUsers.Location = new System.Drawing.Point(195, 488);
			this.cbUsers.Name = "cbUsers";
			this.cbUsers.Size = new System.Drawing.Size(356, 21);
			this.cbUsers.TabIndex = 14;
			// 
			// Comment
			// 
			this.Comment.Text = "Opmerking";
			this.Comment.Width = 288;
			// 
			// TechniekSysteemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ICT4Rails.Properties.Resources.darkrailbackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1117, 708);
			this.Controls.Add(this.cbUsers);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lvTrains);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btChangeDate);
			this.Controls.Add(this.btFinished);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "TechniekSysteemForm";
			this.ShowIcon = false;
			this.Text = "OverviewForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChangeDate;
        private System.Windows.Forms.Button btFinished;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvTrains;
        private System.Windows.Forms.ColumnHeader Train;
        private System.Windows.Forms.ColumnHeader StartDate;
		private System.Windows.Forms.ColumnHeader Engineer;
		private System.Windows.Forms.ColumnHeader Finished;
		private System.Windows.Forms.ColumnHeader EndDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbUsers;
		private System.Windows.Forms.ColumnHeader Comment;
	}
}