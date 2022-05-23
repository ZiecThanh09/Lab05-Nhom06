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
using System.IO;

namespace Lab05_Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có nhập đủ thông tin hay chưa
            if (tbFrom.Text == "" || tbPassword.Text == "" || tbTo.Text == "" || tbSubject.Text == "" || rtbBody.Text == "")
            {
                MessageBox.Show("There are some blanks. Please enter all the information!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
                {
                    string mailfrom = tbFrom.Text.ToString().Trim();
                    string mailto = tbTo.Text.ToString().Trim();
                    string password = tbPassword.Text.ToString().Trim();
                    var basicCredential = new NetworkCredential(mailfrom, password);
                    using (MailMessage message = new MailMessage())
                    {
                        MailAddress fromAddress = new MailAddress(mailfrom);
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;
                        message.From = fromAddress;
                        message.Subject = tbSubject.Text.ToString().Trim();
                        // Set IsBodyHtml to true means you can send HTML email.
                        message.IsBodyHtml = true;
                        message.Body = rtbBody.Text.ToString();
                        message.To.Add(mailto);
                        if (lbAttachFile.Items.Count > 0)
                        {
                            foreach (var filename in lbAttachFile.Items)
                            {
                                //Kiểm tra file có tồn tại trong ổ đĩa không
                                if (File.Exists(filename.ToString()))
                                {
                                    //Thêm file đính kèm vào tin nhắn
                                    message.Attachments.Add(new Attachment(filename.ToString()));
                                }
                            }
                        }
                        smtpClient.Send(message);
                        MessageBox.Show("The mail is sent to " + tbTo.Text + " successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There are some errors, so the mail can't be sent to " + tbTo.Text + "!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbFrom.Text = "";
            tbTo.Text = "";
            tbPassword.Text = "";
            tbSubject.Text = "";
            rtbBody.Text = "";
            lbAttachFile.Items.Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPassword.Checked==true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in ofd.FileNames)
                {
                    //Thêm các file đã chọn vào lbAttachFile
                    lbAttachFile.Items.Add(filename.ToString());
                }
            }
        }
    }
}
