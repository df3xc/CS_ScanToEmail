//*******************************************************************
// Carsten Lueck
// 2025/26
//
// Scan a document and send the scanned document as email attachment.
// Email application is Outlook
//
// Source control https://github.com/df3xc/CS_ScanToEmail
// clone : https://github.com/df3xc/CS_ScanToEmail.git
//*******************************************************************

using GuiThread;
using jonas;
using SharpCompress;
using SharpCompress.Archives.Zip;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using WIA;
using static System.Net.Mime.MediaTypeNames;

namespace ScannerToEmail
{
    public partial class Form1 : Form
    {
        ImageFile imageFile = new ImageFile();
        int scanDPI = 300;
        string document_image_file = "";
        string small_image_file = "";
        string output_path = "udef";
        string user_name = "udef";
        string image_filename = "scan2wia";
        string imageExtension = ".jpeg";

        //string zip_filename = "udef";
        int color_mode = 4;
        DateTime dt = new DateTime();
        string DestMailAddress = "carsten.lueck@outlook.com";
        string FromMailAddress = "h.lehniger@t-online.de";

        guiThreadClass GUI = new guiThreadClass();

        Device scanner_device = null;

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
            this.Height = this.Height + 100;

            user_name = Environment.UserName;

            if (user_name.Contains("car"))
            {
                output_path = @"c:\Users\" + user_name + @"\OneDrive\Dokumente\Programme\";
                FromMailAddress = "carsten.lueck@outlook.com";
            }
            else
            {
                output_path = @"c:\Users\" + user_name + @"\OneDrive\Documentos\Programme\"; // bei Hilde heisst es documentos
                FromMailAddress = "h.lehniger@t-online.de";
            }

            if (Directory.Exists(output_path) == false)
            {
                InfoDialog info = new InfoDialog();
                info.InfoText("Directory nicht gefunden \n" + output_path);
                log("Directory nicht gefunden \n" + output_path);
                info.showInfoDialog(true);

                Directory.CreateDirectory(output_path);
                info.InfoText("Directory neu erstellt \n" + output_path);
                log("Directory neu erstellt \n" + output_path);
                info.showInfoDialog(true);

                info.Close();
            }

            if (ListScanners() == false)
            {
                btnListScanners.Visible = true;
                timer1.Enabled = true;
                InfoDialog info = new InfoDialog();
                info.InfoText("Es wurde kein Scanner gefunden. \n\nDrucker einschalten und mit Computer verbinden");
                info.showInfoDialog(true);
                log("Es wurde kein Scanner gefunden. \n\nDrucker einschalten und mit Computer verbinden");
                info.Close();
            }

            // delete old scan files
            //DirectoryInfo dir = new DirectoryInfo(output_path);
            //dir.EnumerateFiles("scan2wia*.jpeg").ToList().ForEach(f => f.Delete());

        }

        public void log(string text)
        {
            jonas.logger.writeline("APP",text);
        }

        public void notify(string text)
        {
            GUI.RichTextBoxWrite(logBox, text);
            log(text);
        }


        /// <summary>
        /// compress a file using SharpCompress
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="archiveFile"></param>
        /// <returns></returns>
        public int SharpCompressToZip(string filename,string sourceFilePath, string archiveFile)
        {
            int result = 0;

            try
            {
                FileStream fileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);
                FileStream outputStream = new FileStream(archiveFile, FileMode.Create);

                using (var archive = ZipArchive.Create())
                {
                    archive.AddEntry(filename, fileStream);
                    archive.SaveTo(outputStream);
                }
                fileStream.Close();
                outputStream.Close();
            }
            catch (Exception e)
            {
                notify("EXCEPTION:"+ e.Message);
                result = -1;
            }

            return (result);

        }

        /// <summary>
        /// compress a file using 7Zip.exe
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="archiveFile"></param>
        /// <returns></returns>
        public int Compress_7Zip(string sourceFile, string archiveFile)
        {
            String app = @"C:\Program Files\7-Zip\7z.exe";
            int result = -1;

            if (File.Exists(app))
            {
                 result = jonas.process_util.process_exec(app, "a " + archiveFile + " " + sourceFile);
                 log("7Zip return code : " + result.ToString());
                 //GUI.RichTextBoxWrite(logBox, result + "\n");
            }
            else
            {
                notify("warning : 7-ZIP not found. \n");
                //InfoDialog info = new InfoDialog();
                //info.InfoText("Das Program " + app + " wurde nicht gefunden");
                //log("Das Program " + app + " wurde nicht gefunden");
                //info.showInfoDialog(true);
                //info.Close();
            }
            return result;
        }

        static void resizeImage(string sourcePath, string targetPath, int width, int height)
        {
            // We use a series of nested using statments to encapsualte the opening
            // the image file and creating a new bitmap
            // and then writing the new resized image onto it
            // and then finally saving it to the output folder.
            using (System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(sourcePath))
            using (var resizedImage = new Bitmap(width, height))
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(sourceImage, 0, 0, width, height);
                resizedImage.Save(targetPath);
            }
        }

        /// <summary>
        /// list available scanner in a listbox
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
                Scanner derScanner = new Scanner(deviceManager.DeviceInfos[i]);
                listBoxScannerList.Items.Add(derScanner);

                string scanner_name = (string) deviceManager.DeviceInfos[i].Properties["Name"].get_Value();
                log("Found scanner : " + scanner_name);

                scanner_device = deviceManager.DeviceInfos[i].Connect();

            }

            if(listBoxScannerList.Items.Count == 0)
            { 
                btnListScanners.Enabled = true;
                timer1.Enabled = true;
                result = false;
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
        /// called by WIA api after scan completed or canceled
        /// </summary>

        private void AfterScan()
        {

            long filesize;
            //long zipFileSize;
            float float_size;

            notify("Scan ist beendet \n");

            document_image_file = output_path + image_filename + imageExtension;
            document_image_file = document_image_file.Replace(" ", "_");
            //zip_filename = output_path + image_filename + ".zip";
            //zip_filename = zip_filename.Replace(" ", "_");

            try
            {

                if (File.Exists(document_image_file))
                {
                    File.Delete(document_image_file);
                }

                
                imageFile.SaveFile(document_image_file);

                notify("Dokument gespeichert in : \n" + document_image_file + "\n");

                scanPicture.Image = new Bitmap(document_image_file);

                // TODO: check filesize of document image. Is compression needed ?
                // T-Online : attachement size must be less than 10MByte
                // if fromAdress contains t-online then resize the image file



                filesize = new FileInfo(document_image_file).Length;
                float_size = (filesize / 1000000f);
                notify("Größe des Dokuments : " + float_size.ToString("F2") + " MByte \n");


                if (float_size > 9) // megabyte
                {
                    // DIN A4 : Verhältnis der Seitenlängen ist 1.41428
                    // DIN A4 ist 210x297 mm gross
                    int newWidth = 2500;
                    int newHeigth = 3500;

                    small_image_file = output_path + image_filename + " small" + imageExtension;
                    small_image_file = small_image_file.Replace(" ", "_");

                    do
                    {
                        resizeImage(document_image_file, small_image_file, newWidth, newHeigth);

                        filesize = new FileInfo(small_image_file).Length;
                        float_size = (filesize / 1000000f);
                        notify("Größe des kleinen Dokuments : " + float_size.ToString("F2") + " MByte \n");

                        newWidth = (int)(newWidth * 100) / 110; 
                        newHeigth = (int)(newHeigth * 100) / 110;

                    } while (float_size > 8);

                    sendScanAsEmail(small_image_file);
                }
                else
                {
                    sendScanAsEmail(document_image_file);
                }

                // TODO: compression needed if file size > 10MByte for t-online

                //if (float_size > 3) // megabyte
                //{
                //    notify("Dokument wird komprimiert \n");

                //    result = SharpCompressToZip(image_filename + imageExtension, document_image_file, zip_filename);

                //    if (result < 0)
                //    {
                //        notify("File compression failed");
                //        return;
                //    }

                //    if (File.Exists(zip_filename))
                //    {
                //        zipFileSize = new FileInfo(zip_filename).Length;
                //        float_size = zipFileSize / 1000000f;
                //        notify("Größe des komprimierten Dokuments : " + float_size.ToString("F2") + " MByte \n");
                //    }
                //    else
                //    {
                //        MessageBox.Show("ZIP file nicht gefunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        notify("Error : ZIP file nicht gefunden \n");
                //        notify("Datei nicht gefunden : " + zip_filename + "\n");
                //        return;
                //    }
                //    sendScanAsEmail(zip_filename);
                //}
                //else
                //{
                //    sendScanAsEmail(document_image_file);
                //}
            }
            catch(Exception ex)
            {
                notify("Warnung : scan wurde abgebrochen \n");
            }
        }

        /// <summary>
        /// start scanning
        /// </summary>

        public void StartScanning()
        {
            Scanner device = null;

            log("StartScanning");


            this.Invoke(new MethodInvoker(delegate ()
            {
                if (listBoxScannerList.Items.Count > 0) device = listBoxScannerList.Items[0] as Scanner;
            }));

            if (listBoxScannerList.Items.Count == 0)
            {
                return;
            }

            device.setColorMode(color_mode);

            // set DPI Scanner Resolution



            this.Invoke(new MethodInvoker(delegate ()
            {
                imageFile = device.ScanImage(WIA.FormatID.wiaFormatJPEG,scanDPI);
                imageExtension = ".jpeg";
            }));


        }

        /// <summary>
        /// send the scanned image file as email
        /// </summary>

        private void sendScanAsEmail(string attachmentFileName)
        {
            Boolean mail_send = false;
            string mailbody = "Bitte Anlage beachten";
            InfoDialog info = new InfoDialog();
            InfoDialog infoMailSend = new InfoDialog();

            if (String.IsNullOrEmpty(document_image_file))
            {
                info.InfoText("Bitte Dokument scannen");
                info.showInfoDialog(true);
                return;
            }

            if (File.Exists("mailbody.txt"))
            {
                mailbody = File.ReadAllText("mailbody.txt");
            }
            else
            {
                notify("Datei <mailbody.txt> nicht gefunden");
            }

            if (user_name.Contains("car")) mailbody = mailbody + "\nCarsten";
            else mailbody = mailbody + "\nHilde";

            sendmail_outlook mail = new sendmail_outlook();

            System.Windows.Forms.Application.DoEvents();
            // INFO : es können mehrere addressen angegeben werden. Jeweils durch ein Semikolon getrennt
            
            if(cbToBirgit.Checked == true)
            {
                DestMailAddress = DestMailAddress + ";birgit.collmer@gmx.de";
            }

            mail_send = mail.SendEmailFromAccount("send from ScanHilde", mailbody, attachmentFileName, DestMailAddress, FromMailAddress);

            Thread.Sleep(3000);

            if (mail_send == true)
            {
                notify("Email has been sent to "+ DestMailAddress);
                infoMailSend.InfoText("Email wurde gesendet an " + DestMailAddress + "\n\nEine Kopie befindet sich in GESENDETE ELEMENTE in Outlook");
                infoMailSend.showInfoDialog(true);
                infoMailSend.Close();
            }
            else
            {
                notify("EMail konnte nicht gesendet werden");
                MessageBox.Show("Mail konnte nicht gesendet werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            sendScanAsEmail(image_filename);
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

            lbDokument.Visible = false;
            lbDruckerEinschalten.Visible = false;   
            scanPicture.Visible = true; 

            dt = DateTime.Now;
            string time = dt.ToString("yy-MM-dd HH-mm-ss");
            image_filename = "scan2wia " + time;

            notify("Scan wird durchgeführt \n");
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

            //mailAdress.setDestAddress(DestMailAddress);
            result = mailAdress.showDialogBox();

            if(result == DialogResult.OK)
            {
                DestMailAddress = mailAdress.getDestAddress();
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
                notify("Scanner wurde gefunden. Jetzt Dokument scannen.");
                btnListScanners.Visible = false;
                timer1.Enabled = false;
                InfoDialog info = new InfoDialog();
                info.InfoText ("Scanner wurde gefunden. Jetzt Dokument scannen.\n");
                info.showInfoDialog(true);
                info.Close();
            }
            else
            {
                notify("Suche nach einem Scanner ...\n");
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            // test PASSED 08.03.2025

            sendmail_outlook mail = new sendmail_outlook();
            mail.SendEmailFromAccount("sendEmailFromAccount", "this is just for test", document_image_file, DestMailAddress , "df3xc@web.de");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log("Program exit");
        }
    }
}
