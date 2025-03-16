using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WebTest;
using jonas;
using WIA;

namespace ScannerDemo
{
    public partial class Form1 : Form
    {
        string document_image_path = "";
        string output_path;
        string image_filename;
        int color_mode = 4;
        DateTime dt = new DateTime();
        string DestMailAddress = "carsten.lueck@outlook.com";

        public Form1()
        {
            InitializeComponent();
            jonas.logger.init("scan2wia.log",false);
            jonas.logger.writeline("APP", "*************");
            jonas.logger.writeline("APP", "Program start");
            jonas.logger.writeline("APP", "*************");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnListScanners.Visible = false;
            btnSendemail.Visible = true;
            btnSendemail.Visible = false;

            if (ListScanners() == false)
            {
                btnListScanners.Visible = true;
                timer1.Enabled = true;
                InfoDialog info = new InfoDialog();
                info.InfoText("Es wurde kein Scanner gefunden. \n\nDrucker einschalten und mit Computer verbinden");
                info.showInfoDialog(true);
                info.Close();
            }

            // Set start output folder TMP
            output_path = Path.GetTempPath();
            image_filename = "scan2wia";
            // Set JPEG as default
            //comboBox1.SelectedIndex = 1;

            // delete old scan files
            DirectoryInfo dir = new DirectoryInfo(output_path);
            dir.EnumerateFiles("scan2wia*.jpeg").ToList().ForEach(f => f.Delete());

        }

        public void log(string text)
        {
            jonas.logger.writeline("APP",text);
        }


        /// <summary>
        /// list available scanner in a listbox
        /// 
        /// </summary>
        /// <returns>true if scanner found</returns>

        private Boolean ListScanners()
        {
            Boolean result = false;
            // Clear the ListBox.
            listBoxScannerList.Items.Clear();
            log("listScanners");

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                Scanner der = new Scanner(deviceManager.DeviceInfos[i]);
                listBoxScannerList.Items.Add(der);
                // Property property = deviceManager.DeviceInfos[i].Properties[0];

                string scanner_name = (string) deviceManager.DeviceInfos[i].Properties["Name"].get_Value();
                log("Found scanner : " + scanner_name);

            }

            if (deviceManager.DeviceInfos.Count == 0)
            {
                btnListScanners.Enabled = true;
            }
            else
            {
                btnListScanners.Enabled = false;
                timer1.Enabled = false;
                result = true;
            }
            return (result);
        }

        /// <summary>
        /// called by WIA api after scan completed.
        /// </summary>

        private void AfterScan()
        {
            log("AfterScan");
            sendScanAsEmail();
        }

        /// <summary>
        /// start scanning and save scanned image. Display image as preview
        /// </summary>

        public void StartScanning()
        {
            Scanner device = null;

            log("StartScanning");
            this.Invoke(new MethodInvoker(delegate ()
            {
                //device = listBox1.SelectedItem as Scanner;
                if (listBoxScannerList.Items.Count > 0) device = listBoxScannerList.Items[0] as Scanner;
            }));

            if (listBoxScannerList.Items.Count == 0)
            {
                //MessageBox.Show("Bitte Scanner einschalten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            device.setColorMode(color_mode);

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {

                image = device.ScanImage(WIA.FormatID.wiaFormatJPEG);
                imageExtension = ".jpeg";

                //switch (comboBox1.SelectedIndex)
                //{
                //    case 0:
                //        image = device.ScanImage(WIA.FormatID.wiaFormatPNG);
                //        imageExtension = ".png";
                //        break;
                //    case 1:
                //        image = device.ScanImage(WIA.FormatID.wiaFormatJPEG);
                //        imageExtension = ".jpeg";
                //        break;
                //    case 2:
                //        image = device.ScanImage(WIA.FormatID.wiaFormatBMP);
                //        imageExtension = ".bmp";
                //        break;
                //    case 3:
                //        image = device.ScanImage(WIA.FormatID.wiaFormatGIF);
                //        imageExtension = ".gif";
                //        break;
                //    case 4:
                //        image = device.ScanImage(WIA.FormatID.wiaFormatTIFF);
                //        imageExtension = ".tiff";
                //        break;
                //}
            }));

            //pictureBox1.Image = null;

            // Save the image
            document_image_path = Path.Combine(output_path, image_filename + imageExtension);

            if (File.Exists(document_image_path))
            {
                File.Delete(document_image_path);
            }
            
            image.SaveFile(document_image_path);

            log("scan saved : " + document_image_path);

            scanPreviewPicture.Image = new Bitmap(document_image_path);
        }

        /// <summary>
        /// send the scanned image file as email
        /// </summary>

        private void sendScanAsEmail()
        {
            Boolean mail_send = false;
            InfoDialog info = new InfoDialog();
            InfoDialog infoMailSend = new InfoDialog();

            if (String.IsNullOrEmpty(document_image_path))
            {
                info.InfoText("Bitte Dokument scannen");
                info.showInfoDialog(true);
                //MessageBox.Show("Bitte Dokument scannen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sendmail_outlook mail = new sendmail_outlook();

            info.InfoText("Sende Email an " + DestMailAddress);
            info.Show();
            Application.DoEvents();
            //mail_send = mail.sentOutlookMail(DestMailAddress, "Scanned Document", "Angefügtes Dokument beachten", document_image_path);
            mail_send = mail.SendEmailFromAccount("send from ScanHilde", "Bitte Anhang beachten", document_image_path, DestMailAddress, "df3xc@web.de");

            Thread.Sleep(3000);
            info.Close();

            if (mail_send == true)
            {
                log("mail has been sent to "+ DestMailAddress);
                infoMailSend.InfoText("Email wurde gesendet\n\nEine Kopie befindet sich in GESENDETE ELEMENTE in Outlook");
                infoMailSend.showInfoDialog(true);
                infoMailSend.Close();
            }
            else
            {
                log("Mail konnte nicht gesendet werden");
                MessageBox.Show("Mail konnte nicht gesendet werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            sendScanAsEmail();
        }


        private void btnScan_Click(object sender, EventArgs e)
        {

            log("btnScan_Click");

            if (ListScanners() == false)
            {
                timer1.Enabled = true;
                InfoDialog info = new InfoDialog();
                info.InfoText("Es wurde kein Scanner gefunden. \n\nDrucker einschalten und mit Computer verbinden");
                info.showInfoDialog(true);
                info.Close();
                return;
            }

            dt = DateTime.Now;
            string time = dt.ToString("yy-MM-dd HH-mm-ss");
            image_filename = "scan2wia " + time;
            Task.Factory.StartNew(StartScanning).ContinueWith(result => AfterScan());
        }

        private void btnListDevices_Click(object sender, EventArgs e)
        {

            log("btnListDevices_Click");

            if (ListScanners() == false)
            {
                timer1.Enabled = true;
                InfoDialog info = new InfoDialog();
                info.InfoText("Es wurde kein Scanner gefunden. \n\nDrucker einschalten und mit Computer verbinden");
                info.showInfoDialog(true);
                info.Close();
            }
        }

        private void btnSetMailAddress_Click(object sender, EventArgs e)
        {
            EmailAdresse mailAdress = new EmailAdresse();
            DialogResult result = new DialogResult();

            mailAdress.setAddress(DestMailAddress);
            result = mailAdress.showDialogBox();

            if(result == DialogResult.OK)
            {
                DestMailAddress = mailAdress.getAddress();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbScanColored_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScanColored.Checked == true)
            { color_mode = 1; }
            else
            { color_mode = 4; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ListScanners() == true)
            {
                btnListScanners.Visible = false;
                timer1.Enabled = false;
                InfoDialog info = new InfoDialog();
                info.InfoText ("Scanner wurde gefunden. Jetzt Dokument scannen.");
                info.showInfoDialog(true);
                info.Close();
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            // test PASSED 08.03.2025

            sendmail_outlook mail = new sendmail_outlook();
            mail.SendEmailFromAccount("sendEmailFromAccount", "this is just for test", document_image_path, DestMailAddress , "df3xc@web.de");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log("Program exit");
        }
    }
}
