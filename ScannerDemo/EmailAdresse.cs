using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScannerDemo
{
    public partial class EmailAdresse : Form
    {
        DialogResult result = DialogResult.Cancel;

        public EmailAdresse()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }

        public DialogResult showDialogBox()
        {
            this.ShowDialog();
            return (result);
        }


        public string getAddress()
        {
            return (tbMailAddress.Text);
        }

        public void setAddress(string address)
        {
            tbMailAddress.Text = address;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            tbMailAddress.Text = "carsten.lueck@outlook.com";
            Application.DoEvents();
            Thread.Sleep(1000);
            result = DialogResult.OK;
            this.Close();

        }
    }
}
