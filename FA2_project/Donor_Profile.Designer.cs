
namespace FA2_project
{
    partial class Donor_Profile
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabDonor = new System.Windows.Forms.TabControl();
            this.tabPRequestedDonations = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlDivide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtSelectedUser = new System.Windows.Forms.TextBox();
            this.lblDonate = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.lblSelectDonation = new System.Windows.Forms.Label();
            this.dataGdRqstDonations = new System.Windows.Forms.DataGridView();
            this.tabPHistory = new System.Windows.Forms.TabPage();
            this.dataGdDonationHistory = new System.Windows.Forms.DataGridView();
            this.tabDonor.SuspendLayout();
            this.tabPRequestedDonations.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRqstDonations)).BeginInit();
            this.tabPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdDonationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Visible = false;
            // 
            // tabDonor
            // 
            this.tabDonor.Controls.Add(this.tabPRequestedDonations);
            this.tabDonor.Controls.Add(this.tabPHistory);
            this.tabDonor.Location = new System.Drawing.Point(12, 12);
            this.tabDonor.Name = "tabDonor";
            this.tabDonor.SelectedIndex = 0;
            this.tabDonor.Size = new System.Drawing.Size(776, 354);
            this.tabDonor.TabIndex = 1;
            // 
            // tabPRequestedDonations
            // 
            this.tabPRequestedDonations.Controls.Add(this.btnBack);
            this.tabPRequestedDonations.Controls.Add(this.pnlDivide);
            this.tabPRequestedDonations.Controls.Add(this.panel1);
            this.tabPRequestedDonations.Controls.Add(this.lblSelectDonation);
            this.tabPRequestedDonations.Controls.Add(this.dataGdRqstDonations);
            this.tabPRequestedDonations.Location = new System.Drawing.Point(4, 22);
            this.tabPRequestedDonations.Name = "tabPRequestedDonations";
            this.tabPRequestedDonations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRequestedDonations.Size = new System.Drawing.Size(768, 328);
            this.tabPRequestedDonations.TabIndex = 0;
            this.tabPRequestedDonations.Text = "Requested Donations";
            this.tabPRequestedDonations.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(679, 298);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlDivide
            // 
            this.pnlDivide.BackColor = System.Drawing.Color.LightGray;
            this.pnlDivide.Location = new System.Drawing.Point(494, 24);
            this.pnlDivide.Name = "pnlDivide";
            this.pnlDivide.Size = new System.Drawing.Size(4, 287);
            this.pnlDivide.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.txtSelectedUser);
            this.panel1.Controls.Add(this.lblDonate);
            this.panel1.Controls.Add(this.btnDonate);
            this.panel1.Controls.Add(this.lblSelectedFile);
            this.panel1.Controls.Add(this.txtSelectedFile);
            this.panel1.Controls.Add(this.lblSelectedUser);
            this.panel1.Location = new System.Drawing.Point(534, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 228);
            this.panel1.TabIndex = 8;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownload.Location = new System.Drawing.Point(127, 102);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(26, 20);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "...";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtSelectedUser
            // 
            this.txtSelectedUser.Location = new System.Drawing.Point(40, 41);
            this.txtSelectedUser.Name = "txtSelectedUser";
            this.txtSelectedUser.Size = new System.Drawing.Size(100, 20);
            this.txtSelectedUser.TabIndex = 2;
            // 
            // lblDonate
            // 
            this.lblDonate.AutoSize = true;
            this.lblDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDonate.Location = new System.Drawing.Point(20, 137);
            this.lblDonate.Name = "lblDonate";
            this.lblDonate.Size = new System.Drawing.Size(138, 39);
            this.lblDonate.TabIndex = 7;
            this.lblDonate.Text = "If You Click This Buton\r\n  You Will Donate To\r\n    Selected Request";
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(54, 188);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(75, 23);
            this.btnDonate.TabIndex = 1;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFile.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSelectedFile.Location = new System.Drawing.Point(58, 77);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(64, 13);
            this.lblSelectedFile.TabIndex = 6;
            this.lblSelectedFile.Text = "Document";
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(29, 102);
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.Size = new System.Drawing.Size(100, 20);
            this.txtSelectedFile.TabIndex = 3;
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUser.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSelectedUser.Location = new System.Drawing.Point(58, 15);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(65, 13);
            this.lblSelectedUser.TabIndex = 5;
            this.lblSelectedUser.Text = "UserName";
            // 
            // lblSelectDonation
            // 
            this.lblSelectDonation.AutoSize = true;
            this.lblSelectDonation.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDonation.ForeColor = System.Drawing.Color.Crimson;
            this.lblSelectDonation.Location = new System.Drawing.Point(85, 24);
            this.lblSelectDonation.Name = "lblSelectDonation";
            this.lblSelectDonation.Size = new System.Drawing.Size(280, 20);
            this.lblSelectDonation.TabIndex = 4;
            this.lblSelectDonation.Text = "Select Request You Wish To Donate To";
            // 
            // dataGdRqstDonations
            // 
            this.dataGdRqstDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdRqstDonations.Location = new System.Drawing.Point(18, 54);
            this.dataGdRqstDonations.Name = "dataGdRqstDonations";
            this.dataGdRqstDonations.Size = new System.Drawing.Size(441, 246);
            this.dataGdRqstDonations.TabIndex = 0;
            this.dataGdRqstDonations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGdRqstDonations_CellContentClick);
            // 
            // tabPHistory
            // 
            this.tabPHistory.Controls.Add(this.dataGdDonationHistory);
            this.tabPHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPHistory.Name = "tabPHistory";
            this.tabPHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPHistory.Size = new System.Drawing.Size(768, 328);
            this.tabPHistory.TabIndex = 1;
            this.tabPHistory.Text = "Donation History";
            this.tabPHistory.UseVisualStyleBackColor = true;
            // 
            // dataGdDonationHistory
            // 
            this.dataGdDonationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdDonationHistory.Location = new System.Drawing.Point(0, 3);
            this.dataGdDonationHistory.Name = "dataGdDonationHistory";
            this.dataGdDonationHistory.Size = new System.Drawing.Size(765, 322);
            this.dataGdDonationHistory.TabIndex = 0;
            // 
            // Donor_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.tabDonor);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Donor_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMS-Donor";
            this.tabDonor.ResumeLayout(false);
            this.tabPRequestedDonations.ResumeLayout(false);
            this.tabPRequestedDonations.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRqstDonations)).EndInit();
            this.tabPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGdDonationHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabControl tabDonor;
        private System.Windows.Forms.TabPage tabPRequestedDonations;
        private System.Windows.Forms.TabPage tabPHistory;
        private System.Windows.Forms.DataGridView dataGdDonationHistory;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.Label lblSelectDonation;
        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.TextBox txtSelectedUser;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.DataGridView dataGdRqstDonations;
        private System.Windows.Forms.Label lblDonate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDivide;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnBack;
    }
}