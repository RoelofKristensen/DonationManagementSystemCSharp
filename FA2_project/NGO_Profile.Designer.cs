
namespace FA2_project
{
    partial class NGO_Profile
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabNGO = new System.Windows.Forms.TabControl();
            this.tabPRequests = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblPDF = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.tabPHistory = new System.Windows.Forms.TabPage();
            this.btnYour = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.dataGdRequestHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabNGO.SuspendLayout();
            this.tabPRequests.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRequestHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(167, 118);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(54, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Visible = false;
            // 
            // tabNGO
            // 
            this.tabNGO.Controls.Add(this.tabPRequests);
            this.tabNGO.Controls.Add(this.tabPHistory);
            this.tabNGO.Location = new System.Drawing.Point(12, 12);
            this.tabNGO.Name = "tabNGO";
            this.tabNGO.SelectedIndex = 0;
            this.tabNGO.Size = new System.Drawing.Size(776, 354);
            this.tabNGO.TabIndex = 3;
            // 
            // tabPRequests
            // 
            this.tabPRequests.Controls.Add(this.btnBack);
            this.tabPRequests.Controls.Add(this.label1);
            this.tabPRequests.Controls.Add(this.panel1);
            this.tabPRequests.Location = new System.Drawing.Point(4, 22);
            this.tabPRequests.Name = "tabPRequests";
            this.tabPRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRequests.Size = new System.Drawing.Size(768, 328);
            this.tabPRequests.TabIndex = 0;
            this.tabPRequests.Text = "Requests";
            this.tabPRequests.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.lblUpload);
            this.panel1.Controls.Add(this.lblPDF);
            this.panel1.Controls.Add(this.btnAddRequest);
            this.panel1.Controls.Add(this.lblFilePath);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Location = new System.Drawing.Point(144, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 159);
            this.panel1.TabIndex = 6;
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUpload.Location = new System.Drawing.Point(87, 29);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(243, 13);
            this.lblUpload.TabIndex = 4;
            this.lblUpload.Text = "Upload File Here To Create Your Request";
            // 
            // lblPDF
            // 
            this.lblPDF.AutoSize = true;
            this.lblPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDF.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPDF.Location = new System.Drawing.Point(317, 66);
            this.lblPDF.Name = "lblPDF";
            this.lblPDF.Size = new System.Drawing.Size(117, 13);
            this.lblPDF.TabIndex = 5;
            this.lblPDF.Text = "Please Upload PDF";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFilePath.Location = new System.Drawing.Point(13, 85);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(61, 13);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "File Path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(80, 82);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(330, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Location = new System.Drawing.Point(409, 82);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(189, 122);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(114, 23);
            this.btnAddRequest.TabIndex = 0;
            this.btnAddRequest.Text = "Add New Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // tabPHistory
            // 
            this.tabPHistory.Controls.Add(this.btnYour);
            this.tabPHistory.Controls.Add(this.btnAll);
            this.tabPHistory.Controls.Add(this.dataGdRequestHistory);
            this.tabPHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPHistory.Name = "tabPHistory";
            this.tabPHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPHistory.Size = new System.Drawing.Size(768, 328);
            this.tabPHistory.TabIndex = 1;
            this.tabPHistory.Text = "History";
            this.tabPHistory.UseVisualStyleBackColor = true;
            // 
            // btnYour
            // 
            this.btnYour.Location = new System.Drawing.Point(663, 74);
            this.btnYour.Name = "btnYour";
            this.btnYour.Size = new System.Drawing.Size(85, 23);
            this.btnYour.TabIndex = 2;
            this.btnYour.Text = "Your Requests";
            this.btnYour.UseVisualStyleBackColor = true;
            this.btnYour.Click += new System.EventHandler(this.btnYour_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(663, 32);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(85, 23);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Requests";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dataGdRequestHistory
            // 
            this.dataGdRequestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGdRequestHistory.Location = new System.Drawing.Point(0, 3);
            this.dataGdRequestHistory.Name = "dataGdRequestHistory";
            this.dataGdRequestHistory.Size = new System.Drawing.Size(765, 319);
            this.dataGdRequestHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "To Get Donations You First Have To Upload A PDF Detailing What Your\r\nNGO Is About" +
    " and What The Donation Is For";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(679, 298);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NGO_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.tabNGO);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NGO_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMS-NGO";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.tabNGO.ResumeLayout(false);
            this.tabPRequests.ResumeLayout(false);
            this.tabPRequests.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGdRequestHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabControl tabNGO;
        private System.Windows.Forms.TabPage tabPRequests;
        private System.Windows.Forms.TabPage tabPHistory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.DataGridView dataGdRequestHistory;
        private System.Windows.Forms.Button btnYour;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}