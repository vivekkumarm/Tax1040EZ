using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuildNotification
{
    public partial class BuildNotification : System.Web.UI.Page
    {
        public string SmokeLogOffSubject = "Smoke Log Off Notification";
        public string QALogOffSubject = "Info: QA Log Off Notification";
        public string SmokeLoginSubject = "Info: Smoke Server Release";
        public string QALoginSubject = "Info: QA Server Release";
        private string emailer = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnSmokeLogin_Click(object sender, EventArgs e)
        {
            emailer = File.ReadAllText(Server.MapPath("~/Template/SmokeLogInNotification.html"));
            bool status = SendMail(SmokeLoginSubject, emailer);
            if (status)
                dvsuccess.Visible = true;
        }

        protected void btnSmokeLogOff_Click(object sender, EventArgs e)
        {
            emailer = File.ReadAllText(Server.MapPath("~/Template/SmokeLogOffNotification.html"));
            bool status = SendMail(SmokeLogOffSubject, emailer);
            if (status)
                dvsuccess.Visible = true;
        }

        protected void btnQaLogin_Click(object sender, EventArgs e)
        {
            emailer = File.ReadAllText(Server.MapPath("~/Template/QALogInNotification.html"));
            bool status = SendMail(QALoginSubject, emailer);
            if (status)
                dvsuccess.Visible = true;
        }

        protected void btnQaLogOff_Click(object sender, EventArgs e)
        {
            emailer = File.ReadAllText(Server.MapPath("~/Template/QALogOffNotification.html"));
            bool status = SendMail(QALogOffSubject, emailer);
            if (status)
                dvsuccess.Visible = true;
        }

        private bool SendMail(string subject, string emailer)
        {
            bool status=false;
            SmtpClient smtpClient = new SmtpClient();
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("Ilakiyaa.Sambath@jeevantechnologies.com");
                mailMessage.To.Add("Sureshkumar.Veeradhas@jeevantechnologies.com");
                mailMessage.From = new MailAddress(txtBuildManagerEmail.Text);
                mailMessage.IsBodyHtml = true;
                mailMessage.Subject = subject;
                mailMessage.CC.Add("Ashok.Martin@jeevantechnologies.com");
                mailMessage.CC.Add("Rajadurai.Shanmugadurai@jeevantechnologies.com");
                mailMessage.CC.Add("Praveen.thangaraja@jeevantechnologies.com");
                mailMessage.CC.Add("Shanmugaraju.Perumal@jeevantechnologies.com");
                mailMessage.CC.Add("Saravanan.Natarajan@jeevantechnologies.com");
                mailMessage.CC.Add("Swapnesh.Prakash@jeevantechnologies.com");
                mailMessage.CC.Add("Ashokkumar.Narsaiah@jeevantechnologies.com");
                mailMessage.CC.Add("Balasubramanian.Velmurugan@jeevantechnologies.com");
                mailMessage.Body = emailer;
                if (fpReleaseNotes.PostedFile != null)
                {
                    string strFileName =
                        Path.GetFileName(fpReleaseNotes.PostedFile.FileName);
                    var attachFile =
                        new Attachment(fpReleaseNotes.PostedFile.InputStream, strFileName);
                    mailMessage.Attachments.Add(attachFile);
                }
                smtpClient = new SmtpClient("192.168.4.4");
                smtpClient.Send(mailMessage);
                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
        }
    }
}