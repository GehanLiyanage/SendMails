using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace SendMails
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void btnSendmail_Click(object sender, EventArgs e)
        {

            try
            {

                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(txtportNo.Text.Trim());
                clientDetails.Host = txtSMPTServer.Text.Trim();
                clientDetails.EnableSsl = cbxSSl.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(txtsender.Text.Trim(), txtpassword.Text.Trim());

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(txtsender.Text.Trim());
                mailDetails.To.Add(txtreceiver.Text.Trim());
                mailDetails.Subject = txtsubject.Text.Trim();
                mailDetails.IsBodyHtml = cbxSSl.Checked;
                mailDetails.Body = txtbody.Text.Trim();

                clientDetails.Send(mailDetails);

                MessageBox.Show("Mail Send !!");
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }


        }
    }
}