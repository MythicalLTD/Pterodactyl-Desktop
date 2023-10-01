namespace PteroController
{
    partial class FrmLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoader));
            lblwlc = new Label();
            btncnt = new Button();
            btnexit = new Button();
            btngithub = new Button();
            cbunstblmode = new CheckBox();
            SuspendLayout();
            // 
            // lblwlc
            // 
            lblwlc.AutoSize = true;
            lblwlc.Location = new Point(55, 9);
            lblwlc.Name = "lblwlc";
            lblwlc.Size = new Size(690, 45);
            lblwlc.TabIndex = 0;
            lblwlc.Text = resources.GetString("lblwlc.Text");
            lblwlc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncnt
            // 
            btncnt.Location = new Point(280, 70);
            btncnt.Name = "btncnt";
            btncnt.Size = new Size(75, 23);
            btncnt.TabIndex = 1;
            btncnt.Text = "Continue";
            btncnt.UseVisualStyleBackColor = true;
            btncnt.Click += btncnt_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(442, 70);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 2;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btngithub
            // 
            btngithub.Location = new Point(361, 70);
            btngithub.Name = "btngithub";
            btngithub.Size = new Size(75, 23);
            btngithub.TabIndex = 3;
            btngithub.Text = "Github";
            btngithub.UseVisualStyleBackColor = true;
            btngithub.Click += btngithub_Click;
            // 
            // cbunstblmode
            // 
            cbunstblmode.AutoSize = true;
            cbunstblmode.Location = new Point(12, 74);
            cbunstblmode.Name = "cbunstblmode";
            cbunstblmode.Size = new Size(143, 19);
            cbunstblmode.TabIndex = 4;
            cbunstblmode.Text = "Enable unstable mode";
            cbunstblmode.UseVisualStyleBackColor = true;
            // 
            // FrmLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 105);
            Controls.Add(cbunstblmode);
            Controls.Add(btngithub);
            Controls.Add(btnexit);
            Controls.Add(btncnt);
            Controls.Add(lblwlc);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLoader";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PteroController";
            TopMost = true;
            Load += FrmLoader_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwlc;
        private Button btncnt;
        private Button btnexit;
        private Button btngithub;
        private CheckBox cbunstblmode;
    }
}