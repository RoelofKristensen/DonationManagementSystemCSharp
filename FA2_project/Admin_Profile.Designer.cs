
namespace FA2_project
{
    partial class Admin_Profile
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPAdmins = new System.Windows.Forms.TabPage();
            this.pnlDivide = new System.Windows.Forms.Panel();
            this.pnlNewAdmin = new System.Windows.Forms.Panel();
            this.lblAddAdmin = new System.Windows.Forms.Label();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtAddCPassword = new System.Windows.Forms.TextBox();
            this.lblAddCPassword = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.txtAddContact = new System.Windows.Forms.TextBox();
            this.lblAddContact = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAdminList = new System.Windows.Forms.Label();
            this.dataGdAdminList = new System.Windows.Forms.DataGridView();
            this.tabPRequestManage = new System.Windows.Forms.TabPage();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.pnlDownload = new System.Windows.Forms.Panel();
            this.txtDownload = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dataGdStatus = new System.Windows.Forms.DataGridView();
            this.tabPrequestHistory = new System.Windows.Forms.TabPage();
            this.dataGdRequestHistory = new System.Windows.Forms.DataGridView();
            this.tabPDonorHistory = new System.Windows.Forms.TabPage();
            this.dataGdDonorHistory = new System.Windows.Forms.DataGridView();
            this.tabAdmin.SuspendLayout();
            this.tabPAdmins.SuspendLayout();
            this.pnlNewAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdAdminList)).BeginInit();
            this.tabPRequestManage.SuspendLayout();
            this.pnlDownload.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdStatus)).BeginInit();
            this.tabPrequestHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRequestHistory)).BeginInit();
            this.tabPDonorHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdDonorHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(42, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Visible = false;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPAdmins);
            this.tabAdmin.Controls.Add(this.tabPRequestManage);
            this.tabAdmin.Controls.Add(this.tabPrequestHistory);
            this.tabAdmin.Controls.Add(this.tabPDonorHistory);
            this.tabAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(776, 354);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabPAdmins
            // 
            this.tabPAdmins.Controls.Add(this.pnlDivide);
            this.tabPAdmins.Controls.Add(this.pnlNewAdmin);
            this.tabPAdmins.Controls.Add(this.btnBack);
            this.tabPAdmins.Controls.Add(this.lblAdminList);
            this.tabPAdmins.Controls.Add(this.dataGdAdminList);
            this.tabPAdmins.Location = new System.Drawing.Point(4, 22);
            this.tabPAdmins.Name = "tabPAdmins";
            this.tabPAdmins.Size = new System.Drawing.Size(768, 328);
            this.tabPAdmins.TabIndex = 3;
            this.tabPAdmins.Text = "Manage Admins";
            this.tabPAdmins.UseVisualStyleBackColor = true;
            // 
            // pnlDivide
            // 
            this.pnlDivide.BackColor = System.Drawing.Color.LightGray;
            this.pnlDivide.Location = new System.Drawing.Point(417, 15);
            this.pnlDivide.Name = "pnlDivide";
            this.pnlDivide.Size = new System.Drawing.Size(4, 281);
            this.pnlDivide.TabIndex = 26;
            // 
            // pnlNewAdmin
            // 
            this.pnlNewAdmin.BackColor = System.Drawing.Color.Crimson;
            this.pnlNewAdmin.Controls.Add(this.lblAddAdmin);
            this.pnlNewAdmin.Controls.Add(this.btnAddAdmin);
            this.pnlNewAdmin.Controls.Add(this.txtAddCPassword);
            this.pnlNewAdmin.Controls.Add(this.lblAddCPassword);
            this.pnlNewAdmin.Controls.Add(this.txtAddPassword);
            this.pnlNewAdmin.Controls.Add(this.lblAddPassword);
            this.pnlNewAdmin.Controls.Add(this.txtAddContact);
            this.pnlNewAdmin.Controls.Add(this.lblAddContact);
            this.pnlNewAdmin.Controls.Add(this.txtAddName);
            this.pnlNewAdmin.Controls.Add(this.lblAddName);
            this.pnlNewAdmin.Location = new System.Drawing.Point(453, 15);
            this.pnlNewAdmin.Name = "pnlNewAdmin";
            this.pnlNewAdmin.Size = new System.Drawing.Size(281, 267);
            this.pnlNewAdmin.TabIndex = 25;
            // 
            // lblAddAdmin
            // 
            this.lblAddAdmin.AutoSize = true;
            this.lblAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdmin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddAdmin.Location = new System.Drawing.Point(8, 24);
            this.lblAddAdmin.Name = "lblAddAdmin";
            this.lblAddAdmin.Size = new System.Drawing.Size(270, 16);
            this.lblAddAdmin.TabIndex = 13;
            this.lblAddAdmin.Text = "Would  You Like To Add A New Admin";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(107, 222);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdmin.TabIndex = 12;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click_1);
            // 
            // txtAddCPassword
            // 
            this.txtAddCPassword.Location = new System.Drawing.Point(133, 178);
            this.txtAddCPassword.Name = "txtAddCPassword";
            this.txtAddCPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAddCPassword.TabIndex = 15;
            // 
            // lblAddCPassword
            // 
            this.lblAddCPassword.AutoSize = true;
            this.lblAddCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddCPassword.Location = new System.Drawing.Point(17, 178);
            this.lblAddCPassword.Name = "lblAddCPassword";
            this.lblAddCPassword.Size = new System.Drawing.Size(115, 13);
            this.lblAddCPassword.TabIndex = 22;
            this.lblAddCPassword.Text = "Confirm Password :";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(133, 139);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAddPassword.TabIndex = 16;
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddPassword.Location = new System.Drawing.Point(55, 139);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(69, 13);
            this.lblAddPassword.TabIndex = 21;
            this.lblAddPassword.Text = "Password :";
            // 
            // txtAddContact
            // 
            this.txtAddContact.Location = new System.Drawing.Point(133, 100);
            this.txtAddContact.Name = "txtAddContact";
            this.txtAddContact.Size = new System.Drawing.Size(100, 20);
            this.txtAddContact.TabIndex = 17;
            // 
            // lblAddContact
            // 
            this.lblAddContact.AutoSize = true;
            this.lblAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddContact.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddContact.Location = new System.Drawing.Point(30, 100);
            this.lblAddContact.Name = "lblAddContact";
            this.lblAddContact.Size = new System.Drawing.Size(98, 13);
            this.lblAddContact.TabIndex = 20;
            this.lblAddContact.Text = "Phone Number :";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(133, 61);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 18;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddName.Location = new System.Drawing.Point(51, 61);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(73, 13);
            this.lblAddName.TabIndex = 19;
            this.lblAddName.Text = "UserName :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(679, 298);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAdminList
            // 
            this.lblAdminList.AutoSize = true;
            this.lblAdminList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminList.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdminList.Location = new System.Drawing.Point(143, 11);
            this.lblAdminList.Name = "lblAdminList";
            this.lblAdminList.Size = new System.Drawing.Size(122, 25);
            this.lblAdminList.TabIndex = 23;
            this.lblAdminList.Text = "Admin List";
            // 
            // dataGdAdminList
            // 
            this.dataGdAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdAdminList.Location = new System.Drawing.Point(42, 39);
            this.dataGdAdminList.Name = "dataGdAdminList";
            this.dataGdAdminList.Size = new System.Drawing.Size(344, 253);
            this.dataGdAdminList.TabIndex = 14;
            // 
            // tabPRequestManage
            // 
            this.tabPRequestManage.Controls.Add(this.lblPending);
            this.tabPRequestManage.Controls.Add(this.lblDownload);
            this.tabPRequestManage.Controls.Add(this.pnlDownload);
            this.tabPRequestManage.Controls.Add(this.btnApprove);
            this.tabPRequestManage.Controls.Add(this.btnReject);
            this.tabPRequestManage.Controls.Add(this.pnlDataGrid);
            this.tabPRequestManage.Location = new System.Drawing.Point(4, 22);
            this.tabPRequestManage.Name = "tabPRequestManage";
            this.tabPRequestManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRequestManage.Size = new System.Drawing.Size(768, 328);
            this.tabPRequestManage.TabIndex = 0;
            this.tabPRequestManage.Text = "Manage NGO Requests";
            this.tabPRequestManage.UseVisualStyleBackColor = true;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.Crimson;
            this.lblPending.Location = new System.Drawing.Point(215, 14);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(181, 24);
            this.lblPending.TabIndex = 7;
            this.lblPending.Text = "Pending Requests";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownload.ForeColor = System.Drawing.Color.Crimson;
            this.lblDownload.Location = new System.Drawing.Point(54, 202);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(166, 20);
            this.lblDownload.TabIndex = 6;
            this.lblDownload.Text = "Download File Here";
            // 
            // pnlDownload
            // 
            this.pnlDownload.BackColor = System.Drawing.Color.Crimson;
            this.pnlDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDownload.Controls.Add(this.txtDownload);
            this.pnlDownload.Controls.Add(this.btnDownload);
            this.pnlDownload.Location = new System.Drawing.Point(44, 225);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(416, 58);
            this.pnlDownload.TabIndex = 5;
            // 
            // txtDownload
            // 
            this.txtDownload.Location = new System.Drawing.Point(37, 17);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(257, 20);
            this.txtDownload.TabIndex = 4;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(318, 17);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(651, 80);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(651, 124);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.Crimson;
            this.pnlDataGrid.Controls.Add(this.dataGdStatus);
            this.pnlDataGrid.Location = new System.Drawing.Point(29, 45);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(591, 136);
            this.pnlDataGrid.TabIndex = 4;
            // 
            // dataGdStatus
            // 
            this.dataGdStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdStatus.Location = new System.Drawing.Point(20, 21);
            this.dataGdStatus.Name = "dataGdStatus";
            this.dataGdStatus.Size = new System.Drawing.Size(550, 93);
            this.dataGdStatus.TabIndex = 0;
            this.dataGdStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGdStatus_CellContentClick);
            // 
            // tabPrequestHistory
            // 
            this.tabPrequestHistory.Controls.Add(this.dataGdRequestHistory);
            this.tabPrequestHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPrequestHistory.Name = "tabPrequestHistory";
            this.tabPrequestHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrequestHistory.Size = new System.Drawing.Size(768, 328);
            this.tabPrequestHistory.TabIndex = 1;
            this.tabPrequestHistory.Text = "NGO Request History";
            this.tabPrequestHistory.UseVisualStyleBackColor = true;
            // 
            // dataGdRequestHistory
            // 
            this.dataGdRequestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdRequestHistory.Location = new System.Drawing.Point(0, 3);
            this.dataGdRequestHistory.Name = "dataGdRequestHistory";
            this.dataGdRequestHistory.Size = new System.Drawing.Size(765, 322);
            this.dataGdRequestHistory.TabIndex = 0;
            // 
            // tabPDonorHistory
            // 
            this.tabPDonorHistory.Controls.Add(this.dataGdDonorHistory);
            this.tabPDonorHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPDonorHistory.Name = "tabPDonorHistory";
            this.tabPDonorHistory.Size = new System.Drawing.Size(768, 328);
            this.tabPDonorHistory.TabIndex = 2;
            this.tabPDonorHistory.Text = "Donor History";
            this.tabPDonorHistory.UseVisualStyleBackColor = true;
            // 
            // dataGdDonorHistory
            // 
            this.dataGdDonorHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdDonorHistory.Location = new System.Drawing.Point(0, 3);
            this.dataGdDonorHistory.Name = "dataGdDonorHistory";
            this.dataGdDonorHistory.Size = new System.Drawing.Size(765, 325);
            this.dataGdDonorHistory.TabIndex = 0;
            // 
            // Admin_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMS-Admin";
            this.Load += new System.EventHandler(this.Admin_Profile_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabPAdmins.ResumeLayout(false);
            this.tabPAdmins.PerformLayout();
            this.pnlNewAdmin.ResumeLayout(false);
            this.pnlNewAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdAdminList)).EndInit();
            this.tabPRequestManage.ResumeLayout(false);
            this.tabPRequestManage.PerformLayout();
            this.pnlDownload.ResumeLayout(false);
            this.pnlDownload.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGdStatus)).EndInit();
            this.tabPrequestHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRequestHistory)).EndInit();
            this.tabPDonorHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGdDonorHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPRequestManage;
        private System.Windows.Forms.TabPage tabPrequestHistory;
        private System.Windows.Forms.TabPage tabPDonorHistory;
        private System.Windows.Forms.DataGridView dataGdRequestHistory;
        private System.Windows.Forms.DataGridView dataGdDonorHistory;
        private System.Windows.Forms.TabPage tabPAdmins;
        private System.Windows.Forms.Label lblAdminList;
        private System.Windows.Forms.Label lblAddCPassword;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.Label lblAddContact;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddContact;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddCPassword;
        private System.Windows.Forms.DataGridView dataGdAdminList;
        private System.Windows.Forms.Label lblAddAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.DataGridView dataGdStatus;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlDownload;
        private System.Windows.Forms.TextBox txtDownload;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Panel pnlNewAdmin;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Panel pnlDivide;
    }
}