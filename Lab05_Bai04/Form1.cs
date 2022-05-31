using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab05_Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("From", 100);
            listView1.Columns.Add("Thời gian", 100);
            listView1.View = View.Details;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    string email = tbEmail.Text.ToString().Trim();
                    string pass = tbPass.Text.ToString().Trim();
                    client.Authenticate(email, pass);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    tb_Total.Text = inbox.Count.ToString();
                    tbRecent.Text = inbox.Count.ToString();
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem name = new ListViewItem(message.Subject);
                        ListViewItem.ListViewSubItem from = new
                        ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);
                        ListViewItem.ListViewSubItem date = new
                        ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                        name.SubItems.Add(date);
                        listView1.Items.Add(name);
                    }
                    client.Disconnect(true);
                }
            }
            catch
            {
                MessageBox.Show("Sai Email hoặc Password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
