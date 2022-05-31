namespace Lab05_Bai05
{
    partial class Menu_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnListMail = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(344, 113);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(115, 51);
            this.btnSendMail.TabIndex = 4;
            this.btnSendMail.TabStop = false;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnListMail
            // 
            this.btnListMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMail.Location = new System.Drawing.Point(344, 189);
            this.btnListMail.Name = "btnListMail";
            this.btnListMail.Size = new System.Drawing.Size(115, 51);
            this.btnListMail.TabIndex = 3;
            this.btnListMail.TabStop = false;
            this.btnListMail.Text = "Receive Mail";
            this.btnListMail.UseVisualStyleBackColor = true;
            this.btnListMail.Click += new System.EventHandler(this.btnReceiveMail_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(344, 274);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 51);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnListMail);
            this.Controls.Add(this.btnLogout);
            this.Name = "Menu_Form";
            this.Text = "Menu_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_Form_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnListMail;
        private System.Windows.Forms.Button btnLogout;
    }
}