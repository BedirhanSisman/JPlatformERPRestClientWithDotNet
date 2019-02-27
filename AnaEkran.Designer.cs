namespace JPlatformRestClientInC
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginRequestButton = new System.Windows.Forms.Button();
            this.portEntry = new System.Windows.Forms.TextBox();
            this.hostEntry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.languageEntry = new System.Windows.Forms.TextBox();
            this.firmEntry = new System.Windows.Forms.TextBox();
            this.userEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.clientTokenEntry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.responseArea = new System.Windows.Forms.RichTextBox();
            this.statusCodeArea = new System.Windows.Forms.TextBox();
            this.responseLabel = new System.Windows.Forms.Label();
            this.statusCodeResponse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.loginRequestButton);
            this.panel1.Controls.Add(this.portEntry);
            this.panel1.Controls.Add(this.hostEntry);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.languageEntry);
            this.panel1.Controls.Add(this.firmEntry);
            this.panel1.Controls.Add(this.userEntry);
            this.panel1.Controls.Add(this.passwordEntry);
            this.panel1.Controls.Add(this.clientTokenEntry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 182);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(373, 149);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(320, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SwaggerUI Dökümanlarına Erişmek için Tıklayınız.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginRequestButton
            // 
            this.loginRequestButton.Location = new System.Drawing.Point(306, 81);
            this.loginRequestButton.Name = "loginRequestButton";
            this.loginRequestButton.Size = new System.Drawing.Size(391, 49);
            this.loginRequestButton.TabIndex = 14;
            this.loginRequestButton.Text = "Send LOGIN Request";
            this.loginRequestButton.UseVisualStyleBackColor = true;
            this.loginRequestButton.Click += new System.EventHandler(this.loginRequestButton_Click);
            // 
            // portEntry
            // 
            this.portEntry.Location = new System.Drawing.Point(357, 39);
            this.portEntry.Name = "portEntry";
            this.portEntry.Size = new System.Drawing.Size(340, 22);
            this.portEntry.TabIndex = 13;
            this.portEntry.Text = "8080";
            // 
            // hostEntry
            // 
            this.hostEntry.Location = new System.Drawing.Point(357, 10);
            this.hostEntry.Name = "hostEntry";
            this.hostEntry.Size = new System.Drawing.Size(340, 22);
            this.hostEntry.TabIndex = 12;
            this.hostEntry.Text = "localhost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Port :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Host :";
            // 
            // languageEntry
            // 
            this.languageEntry.Location = new System.Drawing.Point(105, 130);
            this.languageEntry.Name = "languageEntry";
            this.languageEntry.Size = new System.Drawing.Size(155, 22);
            this.languageEntry.TabIndex = 9;
            this.languageEntry.Text = "TRTR";
            // 
            // firmEntry
            // 
            this.firmEntry.Location = new System.Drawing.Point(105, 100);
            this.firmEntry.Name = "firmEntry";
            this.firmEntry.Size = new System.Drawing.Size(155, 22);
            this.firmEntry.TabIndex = 8;
            this.firmEntry.Text = "1";
            // 
            // userEntry
            // 
            this.userEntry.Location = new System.Drawing.Point(105, 11);
            this.userEntry.Name = "userEntry";
            this.userEntry.Size = new System.Drawing.Size(155, 22);
            this.userEntry.TabIndex = 7;
            this.userEntry.Text = "admin";
            // 
            // passwordEntry
            // 
            this.passwordEntry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordEntry.Location = new System.Drawing.Point(105, 39);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.PasswordChar = '•';
            this.passwordEntry.Size = new System.Drawing.Size(155, 22);
            this.passwordEntry.TabIndex = 6;
            this.passwordEntry.Text = "logo12";
            // 
            // clientTokenEntry
            // 
            this.clientTokenEntry.Location = new System.Drawing.Point(105, 69);
            this.clientTokenEntry.Name = "clientTokenEntry";
            this.clientTokenEntry.Size = new System.Drawing.Size(155, 22);
            this.clientTokenEntry.TabIndex = 5;
            this.clientTokenEntry.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Language :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Token :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.responseArea);
            this.panel2.Controls.Add(this.statusCodeArea);
            this.panel2.Controls.Add(this.responseLabel);
            this.panel2.Controls.Add(this.statusCodeResponse);
            this.panel2.Location = new System.Drawing.Point(13, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 229);
            this.panel2.TabIndex = 1;
            // 
            // responseArea
            // 
            this.responseArea.Location = new System.Drawing.Point(105, 40);
            this.responseArea.Name = "responseArea";
            this.responseArea.Size = new System.Drawing.Size(592, 177);
            this.responseArea.TabIndex = 4;
            this.responseArea.Text = "";
            // 
            // statusCodeArea
            // 
            this.statusCodeArea.Location = new System.Drawing.Point(105, 11);
            this.statusCodeArea.Name = "statusCodeArea";
            this.statusCodeArea.Size = new System.Drawing.Size(592, 22);
            this.statusCodeArea.TabIndex = 3;
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(3, 40);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(80, 17);
            this.responseLabel.TabIndex = 2;
            this.responseLabel.Text = "Response :";
            // 
            // statusCodeResponse
            // 
            this.statusCodeResponse.AutoSize = true;
            this.statusCodeResponse.Location = new System.Drawing.Point(3, 11);
            this.statusCodeResponse.Name = "statusCodeResponse";
            this.statusCodeResponse.Size = new System.Drawing.Size(93, 17);
            this.statusCodeResponse.TabIndex = 1;
            this.statusCodeResponse.Text = "Status Code :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(0, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(739, 10);
            this.label8.TabIndex = 3;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(13, 437);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(113, 39);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "LOGOUT";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 488);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.Text = "J-Platform Rest LOGIN Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginRequestButton;
        private System.Windows.Forms.TextBox portEntry;
        private System.Windows.Forms.TextBox hostEntry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox languageEntry;
        private System.Windows.Forms.TextBox firmEntry;
        private System.Windows.Forms.TextBox userEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.TextBox clientTokenEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox responseArea;
        private System.Windows.Forms.TextBox statusCodeArea;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.Label statusCodeResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LogOutButton;
    }
}

