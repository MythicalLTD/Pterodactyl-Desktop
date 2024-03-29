﻿namespace Pterodactyl.Forms
{
    partial class FrmSessions
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSessions));
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            SessionListBox = new ListBox();
            lblwlc = new Label();
            btnaddsession = new Guna.UI2.WinForms.Guna2Button();
            btnsession = new Guna.UI2.WinForms.Guna2Button();
            sidebar = new Panel();
            btnsettings = new Guna.UI2.WinForms.Guna2Button();
            btnprofile = new Guna.UI2.WinForms.Guna2Button();
            btnexit = new Guna.UI2.WinForms.Guna2Button();
            btnserverlist = new Guna.UI2.WinForms.Guna2Button();
            btnsvlist = new Guna.UI2.WinForms.Guna2Button();
            btnhome = new Guna.UI2.WinForms.Guna2Button();
            lblpanelname = new Label();
            pbpanellogo = new PictureBox();
            HtmlToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).BeginInit();
            SuspendLayout();
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
            navbar.Size = new Size(1095, 26);
            navbar.TabIndex = 3;
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblappname.ForeColor = Color.WhiteSmoke;
            lblappname.Location = new Point(33, 3);
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
            lblminimize.Location = new Point(1047, 0);
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
            lblexit.Location = new Point(1065, 3);
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
            pbappicon.Size = new Size(23, 23);
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
            // SessionListBox
            // 
            SessionListBox.BackColor = Color.FromArgb(34, 39, 57);
            SessionListBox.BorderStyle = BorderStyle.FixedSingle;
            SessionListBox.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SessionListBox.ForeColor = Color.FromArgb(236, 240, 243);
            SessionListBox.FormattingEnabled = true;
            SessionListBox.ItemHeight = 18;
            SessionListBox.Location = new Point(303, 78);
            SessionListBox.Name = "SessionListBox";
            SessionListBox.Size = new Size(780, 542);
            SessionListBox.TabIndex = 4;
            SessionListBox.SelectedIndexChanged += SessionListBox_SelectedIndexChanged;
            SessionListBox.KeyDown += SessionListBox_KeyDown;
            // 
            // lblwlc
            // 
            lblwlc.AutoSize = true;
            lblwlc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblwlc.ForeColor = Color.WhiteSmoke;
            lblwlc.Location = new Point(303, 40);
            lblwlc.Name = "lblwlc";
            lblwlc.Size = new Size(558, 21);
            lblwlc.TabIndex = 5;
            lblwlc.Text = "Welcome to Pterodactyl! Please select your panel to start using our app!";
            // 
            // btnaddsession
            // 
            btnaddsession.BorderColor = Color.Transparent;
            btnaddsession.BorderRadius = 12;
            btnaddsession.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnaddsession.BorderThickness = 2;
            btnaddsession.CustomizableEdges = customizableEdges15;
            btnaddsession.DisabledState.BorderColor = Color.DarkGray;
            btnaddsession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnaddsession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnaddsession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnaddsession.FillColor = Color.FromArgb(0, 110, 179);
            btnaddsession.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddsession.ForeColor = Color.White;
            btnaddsession.Location = new Point(303, 644);
            btnaddsession.Name = "btnaddsession";
            btnaddsession.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnaddsession.Size = new Size(183, 34);
            btnaddsession.TabIndex = 8;
            btnaddsession.Text = "Add a new session";
            btnaddsession.Click += btnaddsession_Click;
            // 
            // btnsession
            // 
            btnsession.BorderColor = Color.Transparent;
            btnsession.BorderRadius = 12;
            btnsession.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnsession.BorderThickness = 2;
            btnsession.CustomizableEdges = customizableEdges13;
            btnsession.DisabledState.BorderColor = Color.DarkGray;
            btnsession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsession.FillColor = Color.FromArgb(0, 110, 179);
            btnsession.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnsession.ForeColor = Color.White;
            btnsession.Location = new Point(900, 644);
            btnsession.Name = "btnsession";
            btnsession.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnsession.Size = new Size(183, 34);
            btnsession.TabIndex = 9;
            btnsession.Text = "Direct Session";
            btnsession.Click += btnsession_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 39, 57);
            sidebar.Controls.Add(btnsettings);
            sidebar.Controls.Add(btnprofile);
            sidebar.Controls.Add(btnexit);
            sidebar.Controls.Add(btnserverlist);
            sidebar.Controls.Add(btnsvlist);
            sidebar.Controls.Add(btnhome);
            sidebar.Controls.Add(lblpanelname);
            sidebar.Controls.Add(pbpanellogo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 26);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(283, 669);
            sidebar.TabIndex = 10;
            // 
            // btnsettings
            // 
            btnsettings.BorderColor = Color.Transparent;
            btnsettings.BorderRadius = 10;
            btnsettings.CustomizableEdges = customizableEdges1;
            btnsettings.DisabledState.BorderColor = Color.DarkGray;
            btnsettings.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsettings.FillColor = Color.FromArgb(0, 110, 179);
            btnsettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsettings.ForeColor = Color.White;
            btnsettings.Location = new Point(12, 299);
            btnsettings.Name = "btnsettings";
            btnsettings.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnsettings.Size = new Size(263, 51);
            btnsettings.TabIndex = 12;
            btnsettings.Text = "Settings";
            btnsettings.Click += btnsettings_Click;
            // 
            // btnprofile
            // 
            btnprofile.BorderColor = Color.Transparent;
            btnprofile.BorderRadius = 10;
            btnprofile.CustomizableEdges = customizableEdges3;
            btnprofile.DisabledState.BorderColor = Color.DarkGray;
            btnprofile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnprofile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnprofile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnprofile.Enabled = false;
            btnprofile.FillColor = Color.FromArgb(0, 110, 179);
            btnprofile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnprofile.ForeColor = Color.White;
            btnprofile.Location = new Point(12, 415);
            btnprofile.Name = "btnprofile";
            btnprofile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnprofile.Size = new Size(263, 51);
            btnprofile.TabIndex = 11;
            btnprofile.Text = "Profile";
            // 
            // btnexit
            // 
            btnexit.BorderColor = Color.Transparent;
            btnexit.BorderRadius = 10;
            btnexit.CustomizableEdges = customizableEdges5;
            btnexit.DisabledState.BorderColor = Color.DarkGray;
            btnexit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnexit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnexit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnexit.FillColor = Color.FromArgb(0, 110, 179);
            btnexit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(14, 601);
            btnexit.Name = "btnexit";
            btnexit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnexit.Size = new Size(263, 51);
            btnexit.TabIndex = 10;
            btnexit.Text = "Exit";
            btnexit.Click += btnexit_Click;
            // 
            // btnserverlist
            // 
            btnserverlist.BorderColor = Color.Transparent;
            btnserverlist.BorderRadius = 10;
            btnserverlist.CustomizableEdges = customizableEdges7;
            btnserverlist.DisabledState.BorderColor = Color.DarkGray;
            btnserverlist.DisabledState.CustomBorderColor = Color.DarkGray;
            btnserverlist.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnserverlist.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnserverlist.FillColor = Color.FromArgb(0, 110, 179);
            btnserverlist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnserverlist.ForeColor = Color.White;
            btnserverlist.Location = new Point(14, 821);
            btnserverlist.Name = "btnserverlist";
            btnserverlist.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnserverlist.Size = new Size(263, 54);
            btnserverlist.TabIndex = 9;
            btnserverlist.Text = "Server List";
            // 
            // btnsvlist
            // 
            btnsvlist.BorderColor = Color.Transparent;
            btnsvlist.BorderRadius = 10;
            btnsvlist.CustomizableEdges = customizableEdges9;
            btnsvlist.DisabledState.BorderColor = Color.DarkGray;
            btnsvlist.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsvlist.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsvlist.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsvlist.Enabled = false;
            btnsvlist.FillColor = Color.FromArgb(0, 110, 179);
            btnsvlist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsvlist.ForeColor = Color.White;
            btnsvlist.Location = new Point(12, 357);
            btnsvlist.Name = "btnsvlist";
            btnsvlist.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnsvlist.Size = new Size(263, 51);
            btnsvlist.TabIndex = 8;
            btnsvlist.Text = "Server List";
            // 
            // btnhome
            // 
            btnhome.BorderColor = Color.Transparent;
            btnhome.BorderRadius = 10;
            btnhome.CustomizableEdges = customizableEdges11;
            btnhome.DisabledState.BorderColor = Color.DarkGray;
            btnhome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnhome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnhome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnhome.FillColor = Color.FromArgb(0, 110, 179);
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnhome.ForeColor = Color.White;
            btnhome.Location = new Point(12, 242);
            btnhome.Name = "btnhome";
            btnhome.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnhome.Size = new Size(263, 51);
            btnhome.TabIndex = 7;
            btnhome.Text = "Home";
            HtmlToolTip.SetToolTip(btnhome, "See the home page");
            btnhome.Click += btnhome_Click;
            // 
            // lblpanelname
            // 
            lblpanelname.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelname.ForeColor = Color.WhiteSmoke;
            lblpanelname.Location = new Point(3, 167);
            lblpanelname.Name = "lblpanelname";
            lblpanelname.Size = new Size(273, 37);
            lblpanelname.TabIndex = 6;
            lblpanelname.Text = "Pterodactyl Desktop";
            lblpanelname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbpanellogo
            // 
            pbpanellogo.Image = Properties.Resources.pterry1;
            pbpanellogo.Location = new Point(64, 14);
            pbpanellogo.Name = "pbpanellogo";
            pbpanellogo.Size = new Size(151, 150);
            pbpanellogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpanellogo.TabIndex = 5;
            pbpanellogo.TabStop = false;
            // 
            // HtmlToolTip
            // 
            HtmlToolTip.AllowLinksHandling = true;
            HtmlToolTip.MaximumSize = new Size(0, 0);
            // 
            // FrmSessions
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 28, 46);
            ClientSize = new Size(1095, 695);
            Controls.Add(sidebar);
            Controls.Add(btnsession);
            Controls.Add(btnaddsession);
            Controls.Add(lblwlc);
            Controls.Add(SessionListBox);
            Controls.Add(navbar);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSessions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pterodactyl";
            Load += FrmSessions_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel navbar;
        private Label lblappname;
        private Label lblminimize;
        private Label lblexit;
        private PictureBox pbappicon;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private ListBox SessionListBox;
        private Label lblwlc;
        private Guna.UI2.WinForms.Guna2Button btnsession;
        private Guna.UI2.WinForms.Guna2Button btnaddsession;
        private Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnserverlist;
        private Guna.UI2.WinForms.Guna2Button btnsvlist;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Label lblpanelname;
        private PictureBox pbpanellogo;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Button btnsettings;
        private Guna.UI2.WinForms.Guna2HtmlToolTip HtmlToolTip;
    }
}