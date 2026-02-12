using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScannerToEmail
{
    public partial class EmailAdresse : Form
    {
        DialogResult result = DialogResult.Cancel;

        Boolean cbCarstenDone = false;
        Boolean cbBirgitDone = false;
        Boolean cbGabiDone = false;
        Boolean cbErwinDone = false;

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


        public string getDestAddress()
        {
            return (tbMailAddress.Text);
        }

        public void setDestAddress(string address)
        {
            tbMailAddress.Text = address;
        }

     
        private void cbCarsten_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCarsten.Checked & cbCarstenDone == false) 
            { 
                tbMailAddress.Text = tbMailAddress.Text + "CarstenLueck@outlook.com;";
                cbCarstenDone = true;
            }
        }

        private void cbBirgit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBirgit.Checked & cbBirgitDone == false)
            {
                tbMailAddress.Text = tbMailAddress.Text + "birgit.collmer@gmx.de;";
                cbBirgitDone = true;
            }

        }

        private void cbGabi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGabi.Checked & cbGabiDone == false)
            {
                tbMailAddress.Text = tbMailAddress.Text + "g.lueck64@web.de;";
                cbGabiDone = true;
            }

        }

        private void cbErwin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbErwin.Checked & cbErwinDone == false)
            {
                tbMailAddress.Text = tbMailAddress.Text + "erwin-majer@t-online.de;";
                cbErwinDone = true;
            }

        }
    }
}
