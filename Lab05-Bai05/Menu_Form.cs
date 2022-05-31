using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Bai05
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        public Menu_Form(string userName, string password)
        {
            InitializeComponent();
            this.Username = userName;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }


        private void btnSendMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendMail_Form sendMail_Form = new SendMail_Form(this.Username, this.Password);
            sendMail_Form.Show();
        }

        private void btnReceiveMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceivedMail_Form receiveMail_Form = new ReceivedMail_Form(this.Username, this.Password);
            receiveMail_Form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }

        private void Menu_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }
    }
}