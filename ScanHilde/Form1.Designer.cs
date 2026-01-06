namespace ScannerDemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendemail = new System.Windows.Forms.Button();
            this.cbScanColored = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetMailAddress = new System.Windows.Forms.Button();
            this.btnListScanners = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxScannerList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scanPreviewPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanPreviewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendemail);
            this.groupBox1.Controls.Add(this.cbScanColored);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSetMailAddress);
            this.groupBox1.Controls.Add(this.btnListScanners);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxScannerList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(287, 796);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSendemail
            // 
            this.btnSendemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendemail.Location = new System.Drawing.Point(16, 212);
            this.btnSendemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendemail.Name = "btnSendemail";
            this.btnSendemail.Size = new System.Drawing.Size(251, 36);
            this.btnSendemail.TabIndex = 4;
            this.btnSendemail.Text = "Email senden";
            this.btnSendemail.UseVisualStyleBackColor = true;
            this.btnSendemail.Click += new System.EventHandler(this.btntest_Click);
            // 
            // cbScanColored
            // 
            this.cbScanColored.AutoSize = true;
            this.cbScanColored.Location = new System.Drawing.Point(12, 290);
            this.cbScanColored.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbScanColored.Name = "cbScanColored";
            this.cbScanColored.Size = new System.Drawing.Size(236, 20);
            this.cbScanColored.TabIndex = 18;
            this.cbScanColored.Text = "in Farbe scannen (nicht empfohlen)";
            this.cbScanColored.UseVisualStyleBackColor = true;
            this.cbScanColored.CheckedChanged += new System.EventHandler(this.cbScanColored_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(11, 415);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(257, 37);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Program beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bei Bedarf Email Adresse ändern";
            // 
            // btnSetMailAddress
            // 
            this.btnSetMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMailAddress.Location = new System.Drawing.Point(11, 360);
            this.btnSetMailAddress.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSetMailAddress.Name = "btnSetMailAddress";
            this.btnSetMailAddress.Size = new System.Drawing.Size(257, 37);
            this.btnSetMailAddress.TabIndex = 14;
            this.btnSetMailAddress.Text = "Email Addresse ändern";
            this.btnSetMailAddress.UseVisualStyleBackColor = true;
            this.btnSetMailAddress.Click += new System.EventHandler(this.btnSetMailAddress_Click);
            // 
            // btnListScanners
            // 
            this.btnListScanners.FlatAppearance.BorderSize = 3;
            this.btnListScanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListScanners.Location = new System.Drawing.Point(16, 483);
            this.btnListScanners.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListScanners.Name = "btnListScanners";
            this.btnListScanners.Size = new System.Drawing.Size(257, 37);
            this.btnListScanners.TabIndex = 13;
            this.btnListScanners.Text = "Scanner suchen";
            this.btnListScanners.UseVisualStyleBackColor = true;
            this.btnListScanners.Click += new System.EventHandler(this.btnListDevices_Click);
            // 
            // btnScan
            // 
            this.btnScan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnScan.FlatAppearance.BorderSize = 2;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(13, 138);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(257, 37);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "Dokument scannen";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Verfügbare Scanner / Drucker";
            // 
            // listBoxScannerList
            // 
            this.listBoxScannerList.FormattingEnabled = true;
            this.listBoxScannerList.ItemHeight = 16;
            this.listBoxScannerList.Location = new System.Drawing.Point(12, 57);
            this.listBoxScannerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxScannerList.Name = "listBoxScannerList";
            this.listBoxScannerList.Size = new System.Drawing.Size(259, 52);
            this.listBoxScannerList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 623F));
            this.tableLayoutPanel1.Controls.Add(this.scanPreviewPicture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 804);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // scanPreviewPicture
            // 
            this.scanPreviewPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanPreviewPicture.Location = new System.Drawing.Point(299, 4);
            this.scanPreviewPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanPreviewPicture.Name = "scanPreviewPicture";
            this.scanPreviewPicture.Size = new System.Drawing.Size(615, 796);
            this.scanPreviewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scanPreviewPicture.TabIndex = 14;
            this.scanPreviewPicture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 804);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Dokument als Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scanPreviewPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxScannerList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnListScanners;
        private System.Windows.Forms.PictureBox scanPreviewPicture;
        private System.Windows.Forms.Button btnSetMailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbScanColored;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSendemail;
    }
}

