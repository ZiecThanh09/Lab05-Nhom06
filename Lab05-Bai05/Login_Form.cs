using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;

namespace Lab05_Bai05
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Please provide Email and Password");
                return;
            }
            ImapClient imap = new ImapClient();
            imap.Connect("imap.gmail.com", 993, true);
            try
            {
                imap.Authenticate(tbEmail.Text, tbPass.Text);
                MessageBox.Show("Login Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu_Form mainMenu = new Menu_Form(tbEmail.Text, tbPass.Text);
                mainMenu.Show();
            }
            catch
            {
                MessageBox.Show("Login Failed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
