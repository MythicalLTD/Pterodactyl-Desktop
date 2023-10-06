namespace Pterodactyl.Forms
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblpanelname = new Label();
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            btnaddsession = new Guna.UI2.WinForms.Guna2Button();
            txtpanelname = new Guna.UI2.WinForms.Guna2TextBox();
            cbdirectlogin = new Guna.UI2.WinForms.Guna2CheckBox();
            LoginPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblpanelpwd = new Label();
            lblpanelapikey = new Label();
            lblpanelurl = new Label();
            txtpanelapikey = new Guna.UI2.WinForms.Guna2TextBox();
            txtpanelpwd = new Guna.UI2.WinForms.Guna2TextBox();
            txtpanelurl = new Guna.UI2.WinForms.Guna2TextBox();
            lbladdsession = new Label();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblpanelname
            // 
            lblpanelname.AutoSize = true;
            lblpanelname.BackColor = Color.Transparent;
            lblpanelname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelname.Location = new Point(21, 18);
            lblpanelname.Name = "lblpanelname";
            lblpanelname.Size = new Size(94, 19);
            lblpanelname.TabIndex = 14;
            lblpanelname.Text = "Panel Name:";
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(26, 21, 44);
            navbar.Controls.Add(lblappname);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblexit);
            navbar.Controls.Add(pbappicon);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(770, 28);
            navbar.TabIndex = 15;
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblappname.ForeColor = Color.WhiteSmoke;
            lblappname.Location = new Point(29, 3);
            lblappname.Name = "lblappname";
            lblappname.Size = new Size(192, 19);
            lblappname.TabIndex = 4;
            lblappname.Text = "Pterodactyl Desktop (1.0.0)";
            // 
            // lblminimize
            // 
            lblminimize.AutoSize = true;
            lblminimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblminimize.ForeColor = Color.WhiteSmoke;
            lblminimize.Location = new Point(724, 2);
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
            lblexit.Location = new Point(740, 4);
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
            // btnaddsession
            // 
            btnaddsession.Animated = true;
            btnaddsession.BackColor = Color.Transparent;
            btnaddsession.BorderColor = Color.Transparent;
            btnaddsession.BorderRadius = 12;
            btnaddsession.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnaddsession.BorderThickness = 2;
            btnaddsession.CustomBorderColor = Color.Transparent;
            btnaddsession.CustomizableEdges = customizableEdges7;
            btnaddsession.DisabledState.BorderColor = Color.DarkGray;
            btnaddsession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnaddsession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnaddsession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnaddsession.FillColor = Color.FromArgb(0, 110, 179);
            btnaddsession.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddsession.ForeColor = Color.White;
            btnaddsession.Location = new Point(21, 330);
            btnaddsession.Name = "btnaddsession";
            btnaddsession.PressedColor = Color.FromArgb(0, 212, 240);
            btnaddsession.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnaddsession.Size = new Size(455, 45);
            btnaddsession.TabIndex = 6;
            btnaddsession.Text = "Connect";
            btnaddsession.Click += btnaddsession_Click;
            // 
            // txtpanelname
            // 
            txtpanelname.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtpanelname.BackColor = Color.Transparent;
            txtpanelname.BorderColor = Color.FromArgb(42, 47, 65);
            txtpanelname.BorderRadius = 12;
            txtpanelname.Cursor = Cursors.IBeam;
            txtpanelname.CustomizableEdges = customizableEdges9;
            txtpanelname.DefaultText = "";
            txtpanelname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelname.FillColor = Color.FromArgb(42, 47, 65);
            txtpanelname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtpanelname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelname.Location = new Point(17, 41);
            txtpanelname.MaxLength = 32;
            txtpanelname.Name = "txtpanelname";
            txtpanelname.PasswordChar = '\0';
            txtpanelname.PlaceholderText = "MythicalSystems";
            txtpanelname.SelectedText = "";
            txtpanelname.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtpanelname.Size = new Size(460, 45);
            txtpanelname.TabIndex = 1;
            // 
            // cbdirectlogin
            // 
            cbdirectlogin.AutoSize = true;
            cbdirectlogin.BackColor = Color.Transparent;
            cbdirectlogin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbdirectlogin.CheckedState.BorderRadius = 0;
            cbdirectlogin.CheckedState.BorderThickness = 0;
            cbdirectlogin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbdirectlogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbdirectlogin.Location = new Point(21, 301);
            cbdirectlogin.Name = "cbdirectlogin";
            cbdirectlogin.Size = new Size(288, 23);
            cbdirectlogin.TabIndex = 5;
            cbdirectlogin.Text = "Do not save sessions on the session list.";
            cbdirectlogin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbdirectlogin.UncheckedState.BorderRadius = 0;
            cbdirectlogin.UncheckedState.BorderThickness = 0;
            cbdirectlogin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            cbdirectlogin.UseVisualStyleBackColor = false;
            // 
            // LoginPanel
            // 
            LoginPanel.BorderColor = Color.FromArgb(34, 39, 57);
            LoginPanel.BorderRadius = 20;
            LoginPanel.Controls.Add(lblpanelpwd);
            LoginPanel.Controls.Add(lblpanelapikey);
            LoginPanel.Controls.Add(lblpanelurl);
            LoginPanel.Controls.Add(txtpanelapikey);
            LoginPanel.Controls.Add(txtpanelpwd);
            LoginPanel.Controls.Add(txtpanelurl);
            LoginPanel.Controls.Add(btnaddsession);
            LoginPanel.Controls.Add(cbdirectlogin);
            LoginPanel.Controls.Add(txtpanelname);
            LoginPanel.Controls.Add(lblpanelname);
            LoginPanel.CustomBorderColor = Color.FromArgb(34, 39, 57);
            LoginPanel.CustomizableEdges = customizableEdges11;
            LoginPanel.FillColor = Color.FromArgb(34, 39, 57);
            LoginPanel.FillColor2 = Color.FromArgb(34, 39, 57);
            LoginPanel.Location = new Point(135, 94);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            LoginPanel.Size = new Size(496, 402);
            LoginPanel.TabIndex = 23;
            // 
            // lblpanelpwd
            // 
            lblpanelpwd.AutoSize = true;
            lblpanelpwd.BackColor = Color.Transparent;
            lblpanelpwd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelpwd.Location = new Point(21, 228);
            lblpanelpwd.Name = "lblpanelpwd";
            lblpanelpwd.Size = new Size(118, 19);
            lblpanelpwd.TabIndex = 21;
            lblpanelpwd.Text = "Panel Password:";
            // 
            // lblpanelapikey
            // 
            lblpanelapikey.AutoSize = true;
            lblpanelapikey.BackColor = Color.Transparent;
            lblpanelapikey.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelapikey.Location = new Point(21, 158);
            lblpanelapikey.Name = "lblpanelapikey";
            lblpanelapikey.Size = new Size(121, 19);
            lblpanelapikey.TabIndex = 20;
            lblpanelapikey.Text = "Panel Client Key:";
            // 
            // lblpanelurl
            // 
            lblpanelurl.AutoSize = true;
            lblpanelurl.BackColor = Color.Transparent;
            lblpanelurl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelurl.Location = new Point(21, 88);
            lblpanelurl.Name = "lblpanelurl";
            lblpanelurl.Size = new Size(80, 19);
            lblpanelurl.TabIndex = 19;
            lblpanelurl.Text = "Panel URL:";
            // 
            // txtpanelapikey
            // 
            txtpanelapikey.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtpanelapikey.BackColor = Color.Transparent;
            txtpanelapikey.BorderColor = Color.FromArgb(42, 47, 65);
            txtpanelapikey.BorderRadius = 12;
            txtpanelapikey.Cursor = Cursors.IBeam;
            txtpanelapikey.CustomizableEdges = customizableEdges1;
            txtpanelapikey.DefaultText = "";
            txtpanelapikey.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelapikey.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelapikey.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelapikey.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelapikey.FillColor = Color.FromArgb(42, 47, 65);
            txtpanelapikey.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelapikey.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtpanelapikey.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelapikey.Location = new Point(17, 180);
            txtpanelapikey.MaxLength = 64;
            txtpanelapikey.Name = "txtpanelapikey";
            txtpanelapikey.PasswordChar = '●';
            txtpanelapikey.PlaceholderText = "●●●●●●●●●●●●●●●●●●●";
            txtpanelapikey.SelectedText = "";
            txtpanelapikey.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtpanelapikey.Size = new Size(460, 45);
            txtpanelapikey.TabIndex = 3;
            txtpanelapikey.UseSystemPasswordChar = true;
            // 
            // txtpanelpwd
            // 
            txtpanelpwd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtpanelpwd.BackColor = Color.Transparent;
            txtpanelpwd.BorderColor = Color.FromArgb(42, 47, 65);
            txtpanelpwd.BorderRadius = 12;
            txtpanelpwd.Cursor = Cursors.IBeam;
            txtpanelpwd.CustomizableEdges = customizableEdges3;
            txtpanelpwd.DefaultText = "";
            txtpanelpwd.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelpwd.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelpwd.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelpwd.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelpwd.FillColor = Color.FromArgb(42, 47, 65);
            txtpanelpwd.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelpwd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtpanelpwd.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelpwd.Location = new Point(17, 250);
            txtpanelpwd.MaxLength = 64;
            txtpanelpwd.Name = "txtpanelpwd";
            txtpanelpwd.PasswordChar = '●';
            txtpanelpwd.PlaceholderText = "●●●●●●●●●●●●●●●●●●●";
            txtpanelpwd.SelectedText = "";
            txtpanelpwd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtpanelpwd.Size = new Size(460, 45);
            txtpanelpwd.TabIndex = 4;
            txtpanelpwd.UseSystemPasswordChar = true;
            // 
            // txtpanelurl
            // 
            txtpanelurl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtpanelurl.BackColor = Color.Transparent;
            txtpanelurl.BorderColor = Color.FromArgb(42, 47, 65);
            txtpanelurl.BorderRadius = 12;
            txtpanelurl.Cursor = Cursors.IBeam;
            txtpanelurl.CustomizableEdges = customizableEdges5;
            txtpanelurl.DefaultText = "";
            txtpanelurl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelurl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelurl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelurl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelurl.FillColor = Color.FromArgb(42, 47, 65);
            txtpanelurl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelurl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtpanelurl.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelurl.Location = new Point(17, 110);
            txtpanelurl.MaxLength = 64;
            txtpanelurl.Name = "txtpanelurl";
            txtpanelurl.PasswordChar = '\0';
            txtpanelurl.PlaceholderText = "https://devpanel.mythicalsystems.me";
            txtpanelurl.SelectedText = "";
            txtpanelurl.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtpanelurl.Size = new Size(460, 45);
            txtpanelurl.TabIndex = 2;
            // 
            // lbladdsession
            // 
            lbladdsession.AutoSize = true;
            lbladdsession.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbladdsession.ForeColor = Color.WhiteSmoke;
            lbladdsession.Location = new Point(274, 46);
            lbladdsession.Name = "lbladdsession";
            lbladdsession.Size = new Size(222, 29);
            lbladdsession.TabIndex = 5;
            lbladdsession.Text = "Login to Continue";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 28, 46);
            ClientSize = new Size(770, 550);
            Controls.Add(lbladdsession);
            Controls.Add(LoginPanel);
            Controls.Add(navbar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pterodactyl";
            Load += FrmAddSession_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button btnaddsession;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelname;
        private Guna.UI2.WinForms.Guna2CheckBox cbdirectlogin;
        private Guna.UI2.WinForms.Guna2GradientPanel LoginPanel;
        private Label lbladdsession;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelurl;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelpwd;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelapikey;
        private Label lblpanelpwd;
        private Label lblpanelapikey;
        private Label lblpanelurl;
    }
}