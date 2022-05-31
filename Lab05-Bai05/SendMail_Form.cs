using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Lab05_Bai05
{
    public partial class SendMail_Form : Form
    {
        public SendMail_Form()
        {
            InitializeComponent();
        }

        public SendMail_Form(string userName, string password)
        {
            InitializeComponent();
            this.Username = userName;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage myMail = new MailMessage();
                MailAddress mailAddress = new MailAddress(this.Username);
                myMail.Priority = MailPriority.High;
                myMail.From = mailAddress;
                myMail.To.Add(tbTo.Text);
                myMail.Subject = tbSubject.Text;
                myMail.Body = rtbMessage.Text;
                if (tbAttachments.Text.Length > 0)
                {
                    Attachment mailAttachment = new Attachment(tbAttachments.Text);
                    myMail.Attachments.Add(mailAttachment);
                }
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(this.Username, this.Password);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(myMail);
                MessageBox.Show("Send Successful!");
                tbTo.Clear();
                tbSubject.Clear();
                tbAttachments.Clear();
                rtbMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbAttachments.Text = ofd.FileName;
            }
        }

        private void SendMail_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu_Form mainMenu_Form = new Menu_Form(this.Username, this.Password);
            mainMenu_Form.Show();
        }
    }
}
