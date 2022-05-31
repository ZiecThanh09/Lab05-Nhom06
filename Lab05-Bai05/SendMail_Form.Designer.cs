namespace Lab05_Bai05
{
    partial class SendMail_Form
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.tbAttachments = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(97, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSubject.Location = new System.Drawing.Point(162, 136);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(389, 24);
            this.tbSubject.TabIndex = 18;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBrowse.Location = new System.Drawing.Point(557, 175);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 41);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSend.Location = new System.Drawing.Point(656, 380);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 42);
            this.btnSend.TabIndex = 20;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtbMessage.Location = new System.Drawing.Point(64, 222);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(586, 200);
            this.rtbMessage.TabIndex = 21;
            this.rtbMessage.Text = "";
            // 
            // tbAttachments
            // 
            this.tbAttachments.Enabled = false;
            this.tbAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbAttachments.Location = new System.Drawing.Point(162, 183);
            this.tbAttachments.Name = "tbAttachments";
            this.tbAttachments.ReadOnly = true;
            this.tbAttachments.Size = new System.Drawing.Size(389, 24);
            this.tbAttachments.TabIndex = 19;
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbTo.Location = new System.Drawing.Point(162, 90);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(389, 24);
            this.tbTo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(66, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Attachments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(128, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "SEND MAIL";
            // 
            // SendMail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.tbAttachments);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SendMail_Form";
            this.Text = "SendMail_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SendMail_Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.TextBox tbAttachments;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}