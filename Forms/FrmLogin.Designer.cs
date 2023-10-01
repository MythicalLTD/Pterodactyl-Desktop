namespace PteroController.Forms
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblpanelname = new Label();
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            btnaddsession = new Guna.UI2.WinForms.Guna2Button();
            txtpanelname = new Guna.UI2.WinForms.Guna2TextBox();
            txtpanelurl = new Guna.UI2.WinForms.Guna2TextBox();
            lblpanelurl = new Label();
            txtpanelapikey = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            txtpanelpwd = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            cbdirectlogin = new Guna.UI2.WinForms.Guna2CheckBox();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            SuspendLayout();
            // 
            // lblpanelname
            // 
            lblpanelname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelname.Location = new Point(29, 50);
            lblpanelname.Name = "lblpanelname";
            lblpanelname.Size = new Size(293, 15);
            lblpanelname.TabIndex = 14;
            lblpanelname.Text = "Panel Name:";
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(29, 37, 49);
            navbar.Controls.Add(lblappname);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblexit);
            navbar.Controls.Add(pbappicon);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(350, 28);
            navbar.TabIndex = 15;
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblappname.ForeColor = Color.WhiteSmoke;
            lblappname.Location = new Point(29, 3);
            lblappname.Name = "lblappname";
            lblappname.Size = new Size(160, 19);
            lblappname.TabIndex = 4;
            lblappname.Text = "PteroController (1.0.0)";
            // 
            // lblminimize
            // 
            lblminimize.AutoSize = true;
            lblminimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblminimize.ForeColor = Color.WhiteSmoke;
            lblminimize.Location = new Point(309, 2);
            lblminimize.Name = "lblminimize";
            lblminimize.Size = new Size(15, 19);
            lblminimize.TabIndex = 3;
            lblminimize.Text = "-";
            lblminimize.Click += lblminimize_Click;
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblexit.ForeColor = Color.WhiteSmoke;
            lblexit.Location = new Point(325, 4);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(18, 19);
            lblexit.TabIndex = 2;
            lblexit.Text = "X";
            lblexit.Click += lblexit_Click;
            // 
            // pbappicon
            // 
            pbappicon.Image = Properties.Resources.pterry1;
            pbappicon.Location = new Point(3, 3);
            pbappicon.Name = "pbappicon";
            pbappicon.Size = new Size(20, 20);
            pbappicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbappicon.TabIndex = 1;
            pbappicon.TabStop = false;
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 20;
            Elipse.TargetControl = this;
            // 
            // DragController
            // 
            DragController.DockIndicatorTransparencyValue = 0.6D;
            DragController.DragStartTransparencyValue = 0.6D;
            DragController.TargetControl = navbar;
            DragController.UseTransparentDrag = true;
            // 
            // AnimateWindow
            // 
            AnimateWindow.TargetForm = this;
            // 
            // btnaddsession
            // 
            btnaddsession.BorderColor = Color.Transparent;
            btnaddsession.BorderRadius = 12;
            btnaddsession.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnaddsession.BorderThickness = 2;
            btnaddsession.CustomizableEdges = customizableEdges19;
            btnaddsession.DisabledState.BorderColor = Color.DarkGray;
            btnaddsession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnaddsession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnaddsession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnaddsession.FillColor = Color.FromArgb(59, 130, 246);
            btnaddsession.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddsession.ForeColor = Color.White;
            btnaddsession.Location = new Point(130, 269);
            btnaddsession.Name = "btnaddsession";
            btnaddsession.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnaddsession.Size = new Size(92, 30);
            btnaddsession.TabIndex = 6;
            btnaddsession.Text = "Connect";
            btnaddsession.Click += btnaddsession_Click;
            // 
            // txtpanelname
            // 
            txtpanelname.CustomizableEdges = customizableEdges17;
            txtpanelname.DefaultText = "";
            txtpanelname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpanelname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelname.Location = new Point(29, 68);
            txtpanelname.Name = "txtpanelname";
            txtpanelname.PasswordChar = '\0';
            txtpanelname.PlaceholderText = "MythicalSystems";
            txtpanelname.SelectedText = "";
            txtpanelname.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtpanelname.Size = new Size(295, 26);
            txtpanelname.TabIndex = 1;
            // 
            // txtpanelurl
            // 
            txtpanelurl.CustomizableEdges = customizableEdges15;
            txtpanelurl.DefaultText = "";
            txtpanelurl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelurl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelurl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelurl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelurl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelurl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpanelurl.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelurl.Location = new Point(29, 115);
            txtpanelurl.Name = "txtpanelurl";
            txtpanelurl.PasswordChar = '\0';
            txtpanelurl.PlaceholderText = "https://panel.mythicalsystems.me";
            txtpanelurl.SelectedText = "";
            txtpanelurl.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtpanelurl.Size = new Size(295, 26);
            txtpanelurl.TabIndex = 2;
            // 
            // lblpanelurl
            // 
            lblpanelurl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelurl.Location = new Point(29, 97);
            lblpanelurl.Name = "lblpanelurl";
            lblpanelurl.Size = new Size(295, 15);
            lblpanelurl.TabIndex = 18;
            lblpanelurl.Text = "Panel URL:";
            // 
            // txtpanelapikey
            // 
            txtpanelapikey.CustomizableEdges = customizableEdges13;
            txtpanelapikey.DefaultText = "";
            txtpanelapikey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelapikey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelapikey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelapikey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelapikey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelapikey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpanelapikey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelapikey.Location = new Point(29, 162);
            txtpanelapikey.Name = "txtpanelapikey";
            txtpanelapikey.PasswordChar = '\0';
            txtpanelapikey.PlaceholderText = "*************";
            txtpanelapikey.SelectedText = "";
            txtpanelapikey.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtpanelapikey.Size = new Size(295, 26);
            txtpanelapikey.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 144);
            label4.Name = "label4";
            label4.Size = new Size(295, 15);
            label4.TabIndex = 20;
            label4.Text = "Panel Client Key:";
            // 
            // txtpanelpwd
            // 
            txtpanelpwd.CustomizableEdges = customizableEdges11;
            txtpanelpwd.DefaultText = "";
            txtpanelpwd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelpwd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelpwd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelpwd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelpwd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelpwd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpanelpwd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelpwd.Location = new Point(29, 209);
            txtpanelpwd.Name = "txtpanelpwd";
            txtpanelpwd.PasswordChar = '●';
            txtpanelpwd.PlaceholderText = "*************";
            txtpanelpwd.SelectedText = "";
            txtpanelpwd.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtpanelpwd.Size = new Size(295, 26);
            txtpanelpwd.TabIndex = 4;
            txtpanelpwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 191);
            label5.Name = "label5";
            label5.Size = new Size(295, 15);
            label5.TabIndex = 22;
            label5.Text = "Panel Client Password:";
            // 
            // cbdirectlogin
            // 
            cbdirectlogin.AutoSize = true;
            cbdirectlogin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbdirectlogin.CheckedState.BorderRadius = 0;
            cbdirectlogin.CheckedState.BorderThickness = 0;
            cbdirectlogin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbdirectlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbdirectlogin.Location = new Point(29, 241);
            cbdirectlogin.Name = "cbdirectlogin";
            cbdirectlogin.Size = new Size(94, 19);
            cbdirectlogin.TabIndex = 5;
            cbdirectlogin.Text = "Direct Login";
            cbdirectlogin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbdirectlogin.UncheckedState.BorderRadius = 0;
            cbdirectlogin.UncheckedState.BorderThickness = 0;
            cbdirectlogin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // FrmAddSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 59);
            ClientSize = new Size(350, 311);
            Controls.Add(cbdirectlogin);
            Controls.Add(txtpanelpwd);
            Controls.Add(label5);
            Controls.Add(txtpanelapikey);
            Controls.Add(label4);
            Controls.Add(txtpanelurl);
            Controls.Add(lblpanelurl);
            Controls.Add(txtpanelname);
            Controls.Add(btnaddsession);
            Controls.Add(navbar);
            Controls.Add(lblpanelname);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAddSession";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAddSession";
            Load += FrmAddSession_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblpanelname;
        private Panel navbar;
        private Label lblappname;
        private Label lblminimize;
        private Label lblexit;
        private PictureBox pbappicon;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Guna.UI2.WinForms.Guna2Button btnaddsession;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelapikey;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelurl;
        private Label lblpanelurl;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelname;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelpwd;
        private Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox cbdirectlogin;
    }
}