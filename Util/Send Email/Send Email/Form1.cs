using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using EASendMail;

namespace Send_Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool _ValidateEmail(string EmailAddress)
        {
            var Pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            var regex = new Regex(Pattern);
            return regex.IsMatch(EmailAddress);
        }

        private void txtToEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!_ValidateEmail(txtToEmail.Text.Trim()))
            {
                e.Cancel = true;
                txtToEmail.Focus();
                errorProvider1.SetError(txtToEmail,"Invalide Formate Email (yourmail.gmail.com)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtToEmail,null);
            }
        }

        private bool _SendEmail(string ToEmail,string Subject,string Body)
        {
            string FromEmail = "karimguendouz1000@gmail.com";
            string Password = "ahqe pykt nvjq nzog";
            try
            {
                SmtpMail Mail = new SmtpMail("TryIt");
                Mail.From = FromEmail;// إميل الشخص الذي يرسل الرسالة 
                Mail.To = ToEmail; // إميل الشخص الذي يستقبل الرسالة
                Mail.Subject = Subject;// موضوع الرسالة  
                Mail.TextBody = Body;// محتوى الرسالة 

                SmtpServer Server = new SmtpServer("smtp.gmail.com");// smtp.live.com  ------> @hotmail///smtp.gmail.com---->@gmail
                Server.User = FromEmail;// إميل الشخص الذي يرسل الرسالة
                Server.Password = Password;  // كلمة السر  
                Server.ConnectType = SmtpConnectType.ConnectTryTLS;
                Server.Port = 587;  //  25 or 587 or 465
                Server.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient smtp = new SmtpClient();
                smtp.SendMail(Server, Mail);
            }
            catch (Exception Ex)
            {
                return false;
            }
            return true;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_SendEmail(txtToEmail.Text.Trim(),txtSubject.Text.Trim(),txtBody.Text.Trim()))
            {
                MessageBox.Show("Email Send Successfully ", "Send",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Email is not Send Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
