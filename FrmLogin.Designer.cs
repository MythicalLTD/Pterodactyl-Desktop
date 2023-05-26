namespace PteroControler
{
    partial class FrmLogin
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
            this.txtapikey = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.cbsavelogin = new System.Windows.Forms.CheckBox();
            this.txtpanelurl = new System.Windows.Forms.TextBox();
            this.lblapi_key = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtapikey
            // 
            this.txtapikey.Location = new System.Drawing.Point(9, 19);
            this.txtapikey.Name = "txtapikey";
            this.txtapikey.Size = new System.Drawing.Size(221, 20);
            this.txtapikey.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(85, 109);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // cbsavelogin
            // 
            this.cbsavelogin.AutoSize = true;
            this.cbsavelogin.Location = new System.Drawing.Point(9, 83);
            this.cbsavelogin.Name = "cbsavelogin";
            this.cbsavelogin.Size = new System.Drawing.Size(114, 17);
            this.cbsavelogin.TabIndex = 2;
            this.cbsavelogin.Text = "Keep me logged in";
            this.cbsavelogin.UseVisualStyleBackColor = true;
            // 
            // txtpanelurl
            // 
            this.txtpanelurl.Location = new System.Drawing.Point(9, 57);
            this.txtpanelurl.Name = "txtpanelurl";
            this.txtpanelurl.Size = new System.Drawing.Size(221, 20);
            this.txtpanelurl.TabIndex = 3;
            // 
            // lblapi_key
            // 
            this.lblapi_key.AutoSize = true;
            this.lblapi_key.Location = new System.Drawing.Point(12, 3);
            this.lblapi_key.Name = "lblapi_key";
            this.lblapi_key.Size = new System.Drawing.Size(51, 13);
            this.lblapi_key.TabIndex = 4;
            this.lblapi_key.Text = "API KEY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PANEL URL:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblapi_key);
            this.Controls.Add(this.txtpanelurl);
            this.Controls.Add(this.cbsavelogin);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtapikey);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtapikey;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox cbsavelogin;
        private System.Windows.Forms.TextBox txtpanelurl;
        private System.Windows.Forms.Label lblapi_key;
        private System.Windows.Forms.Label label1;
    }
}