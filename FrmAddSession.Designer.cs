namespace PteroController
{
    partial class FrmAddSession
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
            btnlogin = new Button();
            txtpanelpwd = new TextBox();
            label2 = new Label();
            txtpanelapikey = new TextBox();
            label1 = new Label();
            txtpanelurl = new TextBox();
            lblPanelUrl = new Label();
            txtpanelname = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(75, 188);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 13;
            btnlogin.Text = "Add Session";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpanelpwd
            // 
            txtpanelpwd.Location = new Point(12, 159);
            txtpanelpwd.MaxLength = 64;
            txtpanelpwd.Name = "txtpanelpwd";
            txtpanelpwd.Size = new Size(208, 23);
            txtpanelpwd.TabIndex = 4;
            txtpanelpwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 11;
            label2.Text = "Panel Password:";
            // 
            // txtpanelapikey
            // 
            txtpanelapikey.Location = new Point(12, 115);
            txtpanelapikey.MaxLength = 48;
            txtpanelapikey.Name = "txtpanelapikey";
            txtpanelapikey.Size = new Size(208, 23);
            txtpanelapikey.TabIndex = 3;
            txtpanelapikey.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 9;
            label1.Text = "Panel API Key:";
            // 
            // txtpanelurl
            // 
            txtpanelurl.Location = new Point(12, 71);
            txtpanelurl.MaxLength = 64;
            txtpanelurl.Name = "txtpanelurl";
            txtpanelurl.Size = new Size(208, 23);
            txtpanelurl.TabIndex = 2;
            // 
            // lblPanelUrl
            // 
            lblPanelUrl.AutoSize = true;
            lblPanelUrl.Location = new Point(12, 53);
            lblPanelUrl.Name = "lblPanelUrl";
            lblPanelUrl.Size = new Size(63, 15);
            lblPanelUrl.TabIndex = 7;
            lblPanelUrl.Text = "Panel URL:";
            // 
            // txtpanelname
            // 
            txtpanelname.Location = new Point(12, 27);
            txtpanelname.MaxLength = 16;
            txtpanelname.Name = "txtpanelname";
            txtpanelname.Size = new Size(208, 23);
            txtpanelname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 14;
            label3.Text = "Panel Name:";
            // 
            // FrmAddSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 215);
            Controls.Add(txtpanelname);
            Controls.Add(label3);
            Controls.Add(btnlogin);
            Controls.Add(txtpanelpwd);
            Controls.Add(label2);
            Controls.Add(txtpanelapikey);
            Controls.Add(label1);
            Controls.Add(txtpanelurl);
            Controls.Add(lblPanelUrl);
            Name = "FrmAddSession";
            Text = "FrmAddSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox txtpanelpwd;
        private Label label2;
        private TextBox txtpanelapikey;
        private Label label1;
        private TextBox txtpanelurl;
        private Label lblPanelUrl;
        private TextBox txtpanelname;
        private Label label3;
    }
}