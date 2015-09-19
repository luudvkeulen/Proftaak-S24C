namespace ICT4Rails
{
    partial class BeheerSysteemForm
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
            this.btnRepairTrain = new System.Windows.Forms.Button();
            this.btnCleanTrain = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListView();
            this.Tramnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRepairTrain
            // 
            this.btnRepairTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRepairTrain.BackColor = System.Drawing.Color.Silver;
            this.btnRepairTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepairTrain.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnRepairTrain.Location = new System.Drawing.Point(753, 601);
            this.btnRepairTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepairTrain.Name = "btnRepairTrain";
            this.btnRepairTrain.Size = new System.Drawing.Size(475, 133);
            this.btnRepairTrain.TabIndex = 10;
            this.btnRepairTrain.Text = "Repareren";
            this.btnRepairTrain.UseVisualStyleBackColor = false;
            // 
            // btnCleanTrain
            // 
            this.btnCleanTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCleanTrain.BackColor = System.Drawing.Color.Silver;
            this.btnCleanTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanTrain.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnCleanTrain.Location = new System.Drawing.Point(260, 601);
            this.btnCleanTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanTrain.Name = "btnCleanTrain";
            this.btnCleanTrain.Size = new System.Drawing.Size(475, 133);
            this.btnCleanTrain.TabIndex = 8;
            this.btnCleanTrain.Text = "Schoonmaken";
            this.btnCleanTrain.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnBack.Location = new System.Drawing.Point(1188, 809);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 48);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listUsers
            // 
            this.listUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listUsers.BackColor = System.Drawing.Color.Silver;
            this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tramnummer,
            this.Rail,
            this.Status});
            this.listUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.Location = new System.Drawing.Point(260, 95);
            this.listUsers.Margin = new System.Windows.Forms.Padding(4);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(967, 485);
            this.listUsers.TabIndex = 12;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            // 
            // Tramnummer
            // 
            this.Tramnummer.Text = "Tramnummer";
            this.Tramnummer.Width = 363;
            // 
            // Rail
            // 
            this.Rail.Text = "Rail";
            this.Rail.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 359;
            // 
            // BeheerSysteemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICT4Rails.Properties.Resources.darkrailbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1489, 871);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRepairTrain);
            this.Controls.Add(this.btnCleanTrain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BeheerSysteemForm";
            this.ShowIcon = false;
            this.Text = "OverviewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepairTrain;
        private System.Windows.Forms.Button btnCleanTrain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ColumnHeader Tramnummer;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Rail;
    }
}