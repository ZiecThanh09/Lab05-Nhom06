using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;

namespace Lab05_Bai05
{
    public partial class ReceivedMail_Form : Form
    {
        public ReceivedMail_Form()
        {
            InitializeComponent();
        }

        public ReceivedMail_Form(string userName, string password)
        {
            InitializeComponent();
            this.Username = userName;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        DataTable table;
        private void ReceivedMail_Form_Load(object sender, EventArgs e)
        {
            ImapClient imap = new ImapClient();
            imap.Connect("imap.gmail.com", 993, true);
            try
            {
                imap.Authenticate(this.Username, this.Password);
                var inbox = imap.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                table = new DataTable();
                table.Columns.Add("Subject", typeof(string));
                table.Columns.Add("Sender", typeof(string));
                table.Columns.Add("Body", typeof(string));

                dgvReceivedMail.DataSource = table;
                foreach (var item in inbox)
                {
                    table.Rows.Add(new object[] { item.Subject, item.From, item.HtmlBody });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReceivedMail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < table.Rows.Count && e.RowIndex >= 0)
            {
                webBrowser.DocumentText = table.Rows[e.RowIndex]["Body"].ToString();
            }
        }
    }
}
