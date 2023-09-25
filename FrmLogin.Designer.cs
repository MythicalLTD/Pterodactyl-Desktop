namespace PteroController
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblPanelUrl = new Label();
            txtpanelurl = new TextBox();
            txtpanelapikey = new TextBox();
            label1 = new Label();
            txtpanelpwd = new TextBox();
            label2 = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lblPanelUrl
            // 
            lblPanelUrl.AutoSize = true;
            lblPanelUrl.Location = new Point(12, 9);
            lblPanelUrl.Name = "lblPanelUrl";
            lblPanelUrl.Size = new Size(63, 15);
            lblPanelUrl.TabIndex = 0;
            lblPanelUrl.Text = "Panel URL:";
            // 
            // txtpanelurl
            // 
            txtpanelurl.Location = new Point(12, 27);
            txtpanelurl.Name = "txtpanelurl";
            txtpanelurl.Size = new Size(208, 23);
            txtpanelurl.TabIndex = 1;
            // 
            // txtpanelapikey
            // 
            txtpanelapikey.Location = new Point(12, 71);
            txtpanelapikey.Name = "txtpanelapikey";
            txtpanelapikey.Size = new Size(208, 23);
            txtpanelapikey.TabIndex = 3;
            txtpanelapikey.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Panel API Key:";
            // 
            // txtpanelpwd
            // 
            txtpanelpwd.Location = new Point(12, 115);
            txtpanelpwd.Name = "txtpanelpwd";
            txtpanelpwd.Size = new Size(208, 23);
            txtpanelpwd.TabIndex = 5;
            txtpanelpwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 4;
            label2.Text = "Panel Password:";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(75, 144);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 170);
            Controls.Add(btnlogin);
            Controls.Add(txtpanelpwd);
            Controls.Add(label2);
            Controls.Add(txtpanelapikey);
            Controls.Add(label1);
            Controls.Add(txtpanelurl);
            Controls.Add(lblPanelUrl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PteroController";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPanelUrl;
        private TextBox txtpanelurl;
        private TextBox txtpanelapikey;
        private Label label1;
        private TextBox txtpanelpwd;
        private Label label2;
        private Button btnlogin;
    }
}