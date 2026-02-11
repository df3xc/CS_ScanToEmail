
namespace ScannerToEmail
{
    partial class EmailAdresse
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
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCarsten = new System.Windows.Forms.CheckBox();
            this.cbBirgit = new System.Windows.Forms.CheckBox();
            this.cbGabi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbErwin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMailAddress.Location = new System.Drawing.Point(66, 361);
            this.tbMailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(883, 48);
            this.tbMailAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empfänger der Email auswählen";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(107, 494);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(317, 49);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(656, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(293, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCarsten
            // 
            this.cbCarsten.AutoSize = true;
            this.cbCarsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarsten.Location = new System.Drawing.Point(72, 111);
            this.cbCarsten.Name = "cbCarsten";
            this.cbCarsten.Size = new System.Drawing.Size(175, 44);
            this.cbCarsten.TabIndex = 4;
            this.cbCarsten.Text = "Carsten";
            this.cbCarsten.UseVisualStyleBackColor = true;
            this.cbCarsten.CheckedChanged += new System.EventHandler(this.cbCarsten_CheckedChanged);
            // 
            // cbBirgit
            // 
            this.cbBirgit.AutoSize = true;
            this.cbBirgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBirgit.Location = new System.Drawing.Point(317, 111);
            this.cbBirgit.Name = "cbBirgit";
            this.cbBirgit.Size = new System.Drawing.Size(131, 44);
            this.cbBirgit.TabIndex = 5;
            this.cbBirgit.Text = "Birgit";
            this.cbBirgit.UseVisualStyleBackColor = true;
            this.cbBirgit.CheckedChanged += new System.EventHandler(this.cbBirgit_CheckedChanged);
            // 
            // cbGabi
            // 
            this.cbGabi.AutoSize = true;
            this.cbGabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGabi.Location = new System.Drawing.Point(528, 111);
            this.cbGabi.Name = "cbGabi";
            this.cbGabi.Size = new System.Drawing.Size(125, 44);
            this.cbGabi.TabIndex = 6;
            this.cbGabi.Text = "Gabi";
            this.cbGabi.UseVisualStyleBackColor = true;
            this.cbGabi.CheckedChanged += new System.EventHandler(this.cbGabi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "oder Email Adresse hier eingeben";
            // 
            // cbErwin
            // 
            this.cbErwin.AutoSize = true;
            this.cbErwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbErwin.Location = new System.Drawing.Point(728, 111);
            this.cbErwin.Name = "cbErwin";
            this.cbErwin.Size = new System.Drawing.Size(139, 44);
            this.cbErwin.TabIndex = 8;
            this.cbErwin.Text = "Erwin";
            this.cbErwin.UseVisualStyleBackColor = true;
            // 
            // EmailAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1017, 582);
            this.Controls.Add(this.cbErwin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGabi);
            this.Controls.Add(this.cbBirgit);
            this.Controls.Add(this.cbCarsten);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMailAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailAdresse";
            this.Text = "EmailAdresse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbCarsten;
        private System.Windows.Forms.CheckBox cbBirgit;
        private System.Windows.Forms.CheckBox cbGabi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbErwin;
    }
}