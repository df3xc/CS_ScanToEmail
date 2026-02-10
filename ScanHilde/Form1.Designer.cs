namespace ScannerToEmail
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scanPreviewPicture = new System.Windows.Forms.PictureBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.btnSendemail = new System.Windows.Forms.Button();
            this.cbScanColored = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetMailAddress = new System.Windows.Forms.Button();
            this.btnListScanners = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxScannerList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanPreviewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scanPreviewPicture
            // 
            this.scanPreviewPicture.BackColor = System.Drawing.SystemColors.Control;
            this.scanPreviewPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanPreviewPicture.Location = new System.Drawing.Point(609, 48);
            this.scanPreviewPicture.Margin = new System.Windows.Forms.Padding(6);
            this.scanPreviewPicture.Name = "scanPreviewPicture";
            this.scanPreviewPicture.Size = new System.Drawing.Size(685, 800);
            this.scanPreviewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scanPreviewPicture.TabIndex = 15;
            this.scanPreviewPicture.TabStop = false;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(62, 911);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(1232, 278);
            this.logBox.TabIndex = 16;
            this.logBox.Text = "";
            // 
            // btnSendemail
            // 
            this.btnSendemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendemail.Location = new System.Drawing.Point(56, 344);
            this.btnSendemail.Name = "btnSendemail";
            this.btnSendemail.Size = new System.Drawing.Size(376, 56);
            this.btnSendemail.TabIndex = 20;
            this.btnSendemail.Text = "Email senden";
            this.btnSendemail.UseVisualStyleBackColor = true;
            // 
            // cbScanColored
            // 
            this.cbScanColored.AutoSize = true;
            this.cbScanColored.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScanColored.Location = new System.Drawing.Point(56, 488);
            this.cbScanColored.Name = "cbScanColored";
            this.cbScanColored.Size = new System.Drawing.Size(515, 40);
            this.cbScanColored.TabIndex = 27;
            this.cbScanColored.Text = "in Farbe scannen (nicht empfohlen)";
            this.cbScanColored.UseVisualStyleBackColor = true;
            this.cbScanColored.Click += new System.EventHandler(this.cbScanColored_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(54, 683);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(386, 58);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Program beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 547);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bei Bedarf Email Adresse ändern";
            // 
            // btnSetMailAddress
            // 
            this.btnSetMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMailAddress.Location = new System.Drawing.Point(54, 597);
            this.btnSetMailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetMailAddress.Name = "btnSetMailAddress";
            this.btnSetMailAddress.Size = new System.Drawing.Size(386, 58);
            this.btnSetMailAddress.TabIndex = 24;
            this.btnSetMailAddress.Text = "Email Adresse ändern";
            this.btnSetMailAddress.UseVisualStyleBackColor = true;
            this.btnSetMailAddress.Click += new System.EventHandler(this.btnSetMailAddress_Click);
            // 
            // btnListScanners
            // 
            this.btnListScanners.FlatAppearance.BorderSize = 3;
            this.btnListScanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListScanners.Location = new System.Drawing.Point(62, 790);
            this.btnListScanners.Margin = new System.Windows.Forms.Padding(6);
            this.btnListScanners.Name = "btnListScanners";
            this.btnListScanners.Size = new System.Drawing.Size(386, 58);
            this.btnListScanners.TabIndex = 23;
            this.btnListScanners.Text = "Scanner suchen";
            this.btnListScanners.UseVisualStyleBackColor = true;
            this.btnListScanners.Click += new System.EventHandler(this.btnListDevices_Click);
            // 
            // btnScan
            // 
            this.btnScan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnScan.FlatAppearance.BorderSize = 2;
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(56, 241);
            this.btnScan.Margin = new System.Windows.Forms.Padding(6);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(386, 58);
            this.btnScan.TabIndex = 22;
            this.btnScan.Text = "Dokument scannen";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "Verfügbare Scanner / Drucker";
            // 
            // listBoxScannerList
            // 
            this.listBoxScannerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxScannerList.FormattingEnabled = true;
            this.listBoxScannerList.ItemHeight = 36;
            this.listBoxScannerList.Location = new System.Drawing.Point(56, 124);
            this.listBoxScannerList.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxScannerList.Name = "listBoxScannerList";
            this.listBoxScannerList.Size = new System.Drawing.Size(386, 76);
            this.listBoxScannerList.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 1269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1366, 1338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendemail);
            this.Controls.Add(this.cbScanColored);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetMailAddress);
            this.Controls.Add(this.btnListScanners);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxScannerList);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.scanPreviewPicture);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Sende Dokument als Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanPreviewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox scanPreviewPicture;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button btnSendemail;
        private System.Windows.Forms.CheckBox cbScanColored;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetMailAddress;
        private System.Windows.Forms.Button btnListScanners;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxScannerList;
        private System.Windows.Forms.Label label2;
    }
}

