using System;
using System.Net;
using System.Net.Mail;

namespace T8SMTP
{
    public partial class Mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendBtn_Click(object sender, EventArgs e)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("");
            mailMessage.To.Add(txtTo.Text);
            mailMessage.Subject = txtSub.Text;
            mailMessage.Body = txtBody.Text;
            

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("cvr@gmail.com", "pass");
            smtpClient.Send(mailMessage);

            txtTo.Text = "";
            txtSub.Text = "";
            txtBody.Text = "";
            lbl.Text = "Sent";
        }
    }
}
