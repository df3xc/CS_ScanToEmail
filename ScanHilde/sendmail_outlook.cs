using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Mail;
using jonas;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;

namespace ScannerToEmail
{
    public class sendmail_outlook
    {

        private string readFromAddress(string filename)
        {
            string[] content = new string[10];
            string address = "address not found";

            jonas.logger.writeline("EMAIL", "readFromAddress from file " + filename);

            if (File.Exists(filename))
            {
              content = File.ReadAllLines(filename);
            }
            else
            { jonas.logger.writeline("EMAIL","File not found " + filename + " not found"); }

            foreach(string s in content)
            {
                if (s.Contains("#")) continue;
                address = s;
            }

            return (address);
        }

        /// <summary>
        /// send email using outlook
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="file_name"></param>
        /// <returns></returns>

        public Boolean sentOutlookMail(string to, string subject, string body, string file_name)
        {
            Boolean result = false;
            DateTime dt = DateTime.Now;
            string date = dt.ToString("dd.MM.yyyy hh:mm");

            try
            {
                jonas.logger.writeline("EMAIL", "sentOutlookMail");
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                // Set the properties of the mail item.
                mailItem.Subject = subject;
                mailItem.To = to;
                mailItem.Body = dt + " " + body;
                mailItem.Attachments.Add(file_name, Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);

                // Send the email.
                mailItem.Send();
                Thread.Sleep(2000);
                result = true;
            }
            catch(System.Exception ex)
            { 
                jonas.logger.writeline("EXCEPTION", ex.Message);
                MessageBox.Show(ex.Message,"Fehler",MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return (result);
        }

        /// <summary>
        /// send email using an exisiting account = emailfrom
        /// </summary>
        /// <param name="application"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="to"></param>
        /// <param name="from"></param>

        public Boolean SendEmailFromAccount(string subject, string body, string file_name, string to, string from)
        {
            Boolean result = false;
            try
            {

                //from = readFromAddress("fromAddress.txt");
                jonas.logger.writeline("EMAIL","from mail address is "+from);

                Outlook.Application outlookApp = new Outlook.Application();
                // Create a new MailItem and set the To, Subject, and Body properties.
                Outlook.MailItem newMail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                newMail.To = to;
                newMail.Subject = subject;
                newMail.Body = body;

                jonas.logger.writeline("EMAIL", "attached file :" +file_name);
                newMail.Attachments.Add(file_name, Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);

                // Retrieve the account that has the specific SMTP address.
                Outlook.Account account = GetAccountForEmailAddress(outlookApp, from);
                // Use this account to send the email.
                newMail.SendUsingAccount = account;
                newMail.Send();
                jonas.logger.writeline("EMAIL", "mail has been send");
                result = true;
            }
            catch (System.Exception ex)
            {
                jonas.logger.writeline("EXCEPTION", ex.Message);
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return (result);

        }


        public Outlook.Account GetAccountForEmailAddress(Outlook.Application application, string smtpAddress)
        {

            // Loop over the Accounts collection of the current Outlook session.
            Outlook.Accounts accounts = application.Session.Accounts;
            foreach (Outlook.Account account in accounts)
            {
                // When the email address matches, return the account.
                if (account.SmtpAddress == smtpAddress)
                {
                    return account;
                }
            }
            throw new System.Exception(string.Format("No Account with SmtpAddress: {0} exists!", smtpAddress));
        }


    }
}
