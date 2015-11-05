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
            this.lvTrams = new System.Windows.Forms.ListView();
            this.Tram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Engineer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btChangeDate
            // 
            this.btChangeDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btChangeDate.BackColor = System.Drawing.Color.Silver;
            this.btChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangeDate.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btChangeDate.Location = new System.Drawing.Point(753, 633);
            this.btChangeDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChangeDate.Name = "btChangeDate";
            this.btChangeDate.Size = new System.Drawing.Size(475, 101);
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
            this.btFinished.Location = new System.Drawing.Point(260, 633);
            this.btFinished.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFinished.Name = "btFinished";
            this.btFinished.Size = new System.Drawing.Size(475, 101);
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
            this.btnBack.Location = new System.Drawing.Point(1188, 809);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 48);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvTrams
            // 
            this.lvTrams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvTrams.BackColor = System.Drawing.Color.Silver;
            this.lvTrams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tram,
            this.StartDate,
            this.EndDate,
            this.Engineer,
            this.Finished,
            this.Comment});
            this.lvTrams.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTrams.Location = new System.Drawing.Point(260, 95);
            this.lvTrams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvTrams.Name = "lvTrams";
            this.lvTrams.Size = new System.Drawing.Size(967, 485);
            this.lvTrams.TabIndex = 12;
            this.lvTrams.UseCompatibleStateImageBehavior = false;
            this.lvTrams.View = System.Windows.Forms.View.Details;
            // 
            // Tram
            // 
            this.Tram.Text = "Tram";
            this.Tram.Width = 48;
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
            // Comment
            // 
            this.Comment.Text = "Opmerking";
            this.Comment.Width = 288;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndDate.Location = new System.Drawing.Point(753, 601);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(473, 22);
            this.dtpEndDate.TabIndex = 13;
            // 
            // cbUsers
            // 
            this.cbUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(260, 601);
            this.cbUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(473, 24);
            this.cbUsers.TabIndex = 14;
            // 
            // TechniekSysteemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICT4Rails.Properties.Resources.darkrailbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1489, 871);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lvTrams);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btChangeDate);
            this.Controls.Add(this.btFinished);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "TechniekSysteemForm";
            this.ShowIcon = false;
            this.Text = "OverviewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TechniekSysteemForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChangeDate;
        private System.Windows.Forms.Button btFinished;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvTrams;
        private System.Windows.Forms.ColumnHeader Tram;
        private System.Windows.Forms.ColumnHeader StartDate;
		private System.Windows.Forms.ColumnHeader Engineer;
		private System.Windows.Forms.ColumnHeader Finished;
		private System.Windows.Forms.ColumnHeader EndDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.ComboBox cbUsers;
		private System.Windows.Forms.ColumnHeader Comment;
	}
}