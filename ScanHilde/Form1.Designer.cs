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
            this.scanPicture = new System.Windows.Forms.PictureBox();
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
            this.cbToBirgit = new System.Windows.Forms.CheckBox();
            this.lbDruckerEinschalten = new System.Windows.Forms.Label();
            this.lbDokument = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scanPicture
            // 
            this.scanPicture.BackColor = System.Drawing.SystemColors.Control;
            this.scanPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanPicture.Location = new System.Drawing.Point(710, 56);
            this.scanPicture.Margin = new System.Windows.Forms.Padding(7);
            this.scanPicture.Name = "scanPicture";
            this.scanPicture.Size = new System.Drawing.Size(799, 928);
            this.scanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scanPicture.TabIndex = 15;
            this.scanPicture.TabStop = false;
            this.scanPicture.Visible = false;
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.Location = new System.Drawing.Point(72, 1057);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(1437, 322);
            this.logBox.TabIndex = 16;
            this.logBox.Text = "";
            // 
            // btnSendemail
            // 
            this.btnSendemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendemail.Location = new System.Drawing.Point(65, 951);
            this.btnSendemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendemail.Name = "btnSendemail";
            this.btnSendemail.Size = new System.Drawing.Size(298, 65);
            this.btnSendemail.TabIndex = 20;
            this.btnSendemail.Text = "Email senden";
            this.btnSendemail.UseVisualStyleBackColor = true;
            // 
            // cbScanColored
            // 
            this.cbScanColored.AutoSize = true;
            this.cbScanColored.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScanColored.Location = new System.Drawing.Point(65, 566);
            this.cbScanColored.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btnExit.Location = new System.Drawing.Point(63, 792);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(450, 67);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Program beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 635);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bei Bedarf Email Adresse ändern";
            // 
            // btnSetMailAddress
            // 
            this.btnSetMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMailAddress.Location = new System.Drawing.Point(63, 693);
            this.btnSetMailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetMailAddress.Name = "btnSetMailAddress";
            this.btnSetMailAddress.Size = new System.Drawing.Size(450, 67);
            this.btnSetMailAddress.TabIndex = 24;
            this.btnSetMailAddress.Text = "Email Adresse ändern";
            this.btnSetMailAddress.UseVisualStyleBackColor = true;
            this.btnSetMailAddress.Click += new System.EventHandler(this.btnSetMailAddress_Click);
            // 
            // btnListScanners
            // 
            this.btnListScanners.FlatAppearance.BorderSize = 3;
            this.btnListScanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListScanners.Location = new System.Drawing.Point(63, 873);
            this.btnListScanners.Margin = new System.Windows.Forms.Padding(7);
            this.btnListScanners.Name = "btnListScanners";
            this.btnListScanners.Size = new System.Drawing.Size(300, 67);
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
            this.btnScan.Location = new System.Drawing.Point(70, 364);
            this.btnScan.Margin = new System.Windows.Forms.Padding(7);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(450, 67);
            this.btnScan.TabIndex = 22;
            this.btnScan.Text = "Dokument scannen";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
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
            this.listBoxScannerList.Location = new System.Drawing.Point(65, 144);
            this.listBoxScannerList.Margin = new System.Windows.Forms.Padding(7);
            this.listBoxScannerList.Name = "listBoxScannerList";
            this.listBoxScannerList.Size = new System.Drawing.Size(450, 76);
            this.listBoxScannerList.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 1472);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            // 
            // cbToBirgit
            // 
            this.cbToBirgit.AutoSize = true;
            this.cbToBirgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToBirgit.Location = new System.Drawing.Point(72, 291);
            this.cbToBirgit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbToBirgit.Name = "cbToBirgit";
            this.cbToBirgit.Size = new System.Drawing.Size(478, 40);
            this.cbToBirgit.TabIndex = 29;
            this.cbToBirgit.Text = "Dokument auch an Birgit senden";
            this.cbToBirgit.UseVisualStyleBackColor = true;
            // 
            // lbDruckerEinschalten
            // 
            this.lbDruckerEinschalten.AutoSize = true;
            this.lbDruckerEinschalten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDruckerEinschalten.Location = new System.Drawing.Point(541, 165);
            this.lbDruckerEinschalten.Name = "lbDruckerEinschalten";
            this.lbDruckerEinschalten.Size = new System.Drawing.Size(442, 40);
            this.lbDruckerEinschalten.TabIndex = 30;
            this.lbDruckerEinschalten.Text = "Ist Drucker eingeschaltet ?";
            // 
            // lbDokument
            // 
            this.lbDokument.AutoSize = true;
            this.lbDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDokument.Location = new System.Drawing.Point(550, 375);
            this.lbDokument.Name = "lbDokument";
            this.lbDokument.Size = new System.Drawing.Size(618, 40);
            this.lbDokument.TabIndex = 31;
            this.lbDokument.Text = "Ist Dokument in den Scanner gelegt ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1594, 1552);
            this.Controls.Add(this.lbDokument);
            this.Controls.Add(this.lbDruckerEinschalten);
            this.Controls.Add(this.cbToBirgit);
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
            this.Controls.Add(this.scanPicture);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Sende Dokument als Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox scanPicture;
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
        private System.Windows.Forms.CheckBox cbToBirgit;
        private System.Windows.Forms.Label lbDruckerEinschalten;
        private System.Windows.Forms.Label lbDokument;
    }
}

