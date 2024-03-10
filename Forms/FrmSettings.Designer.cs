using Pterodactyl.Properties;
using Pterodactyl;


namespace Pterodactyl.Forms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
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
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            sidebar = new Panel();
            btnsettings = new Guna.UI2.WinForms.Guna2Button();
            btnprofile = new Guna.UI2.WinForms.Guna2Button();
            btnexit = new Guna.UI2.WinForms.Guna2Button();
            btnsvlist = new Guna.UI2.WinForms.Guna2Button();
            btnhome = new Guna.UI2.WinForms.Guna2Button();
            lblpanelname = new Label();
            pbpanellogo = new PictureBox();
            lblsettings = new Label();
            btnsavesettings = new Guna.UI2.WinForms.Guna2Button();
            cbalwaysontop = new Guna.UI2.WinForms.Guna2CheckBox();
            lblappsettings = new Label();
            cbdisableunstablemode = new Guna.UI2.WinForms.Guna2CheckBox();
            cbdisabletlmtry = new Guna.UI2.WinForms.Guna2CheckBox();
            cberrorreport = new Guna.UI2.WinForms.Guna2CheckBox();
            disablerpc = new Guna.UI2.WinForms.Guna2CheckBox();
            lblexperimentalsettings = new Label();
            lblappinfo = new Label();
            lblappversion = new Label();
            lblbranch = new Label();
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            cbnoicon = new Guna.UI2.WinForms.Guna2CheckBox();
            label1 = new Label();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
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
            navbar.TabIndex = 4;
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            lblminimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblminimize.ForeColor = Color.WhiteSmoke;
            lblminimize.Location = new Point(1056, 0);
            lblminimize.Name = "lblminimize";
            lblminimize.Size = new Size(15, 19);
            lblminimize.TabIndex = 3;
            lblminimize.Text = "-";
            lblminimize.Click += lblminimize_Click;
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblexit.ForeColor = Color.WhiteSmoke;
            lblexit.Location = new Point(1074, 3);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(18, 19);
            lblexit.TabIndex = 2;
            lblexit.Text = "X";
            lblexit.Click += lblexit_Click;
            // 
            // pbappicon
            // 
            pbappicon.Image = (Image)resources.GetObject("pbappicon.Image");
            pbappicon.Location = new Point(3, 3);
            pbappicon.Name = "pbappicon";
            pbappicon.Size = new Size(23, 23);
            pbappicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbappicon.TabIndex = 1;
            pbappicon.TabStop = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 39, 57);
            sidebar.Controls.Add(btnsettings);
            sidebar.Controls.Add(btnprofile);
            sidebar.Controls.Add(btnexit);
            sidebar.Controls.Add(btnsvlist);
            sidebar.Controls.Add(btnhome);
            sidebar.Controls.Add(lblpanelname);
            sidebar.Controls.Add(pbpanellogo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 26);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(283, 669);
            sidebar.TabIndex = 11;
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
            btnsettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsettings.ForeColor = Color.White;
            btnsettings.Location = new Point(12, 301);
            btnsettings.Name = "btnsettings";
            btnsettings.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnsettings.Size = new Size(262, 40);
            btnsettings.TabIndex = 12;
            btnsettings.Text = "Settings";
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
            btnprofile.FillColor = Color.FromArgb(0, 110, 179);
            btnprofile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnprofile.ForeColor = Color.White;
            btnprofile.Location = new Point(14, 393);
            btnprofile.Name = "btnprofile";
            btnprofile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnprofile.Size = new Size(262, 40);
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
            btnexit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(12, 617);
            btnexit.Name = "btnexit";
            btnexit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnexit.Size = new Size(262, 40);
            btnexit.TabIndex = 10;
            btnexit.Text = "Exit";
            btnexit.Click += btnexit_Click;
            // 
            // btnsvlist
            // 
            btnsvlist.BorderColor = Color.Transparent;
            btnsvlist.BorderRadius = 10;
            btnsvlist.CustomizableEdges = customizableEdges7;
            btnsvlist.DisabledState.BorderColor = Color.DarkGray;
            btnsvlist.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsvlist.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsvlist.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsvlist.FillColor = Color.FromArgb(0, 110, 179);
            btnsvlist.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsvlist.ForeColor = Color.White;
            btnsvlist.Location = new Point(12, 347);
            btnsvlist.Name = "btnsvlist";
            btnsvlist.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnsvlist.Size = new Size(262, 40);
            btnsvlist.TabIndex = 8;
            btnsvlist.Text = "Server List";
            btnsvlist.Click += btnsvlist_Click;
            // 
            // btnhome
            // 
            btnhome.BorderColor = Color.Transparent;
            btnhome.BorderRadius = 10;
            btnhome.CustomizableEdges = customizableEdges9;
            btnhome.DisabledState.BorderColor = Color.DarkGray;
            btnhome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnhome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnhome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnhome.FillColor = Color.FromArgb(0, 110, 179);
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnhome.ForeColor = Color.White;
            btnhome.Location = new Point(12, 255);
            btnhome.Name = "btnhome";
            btnhome.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnhome.Size = new Size(262, 40);
            btnhome.TabIndex = 7;
            btnhome.Text = "Home";
            btnhome.Click += btnhome_Click;
            // 
            // lblpanelname
            // 
            lblpanelname.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
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
            pbpanellogo.Image = (Image)resources.GetObject("pbpanellogo.Image");
            pbpanellogo.Location = new Point(64, 14);
            pbpanellogo.Name = "pbpanellogo";
            pbpanellogo.Size = new Size(151, 150);
            pbpanellogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpanellogo.TabIndex = 5;
            pbpanellogo.TabStop = false;
            // 
            // lblsettings
            // 
            lblsettings.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblsettings.ForeColor = Color.WhiteSmoke;
            lblsettings.Location = new Point(299, 29);
            lblsettings.Name = "lblsettings";
            lblsettings.Size = new Size(383, 44);
            lblsettings.TabIndex = 12;
            lblsettings.Text = "Welcome to the settings page.";
            lblsettings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnsavesettings
            // 
            btnsavesettings.BorderColor = Color.Transparent;
            btnsavesettings.BorderRadius = 10;
            btnsavesettings.CustomizableEdges = customizableEdges11;
            btnsavesettings.DisabledState.BorderColor = Color.DarkGray;
            btnsavesettings.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsavesettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsavesettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsavesettings.FillColor = Color.FromArgb(0, 110, 179);
            btnsavesettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsavesettings.ForeColor = Color.White;
            btnsavesettings.Location = new Point(922, 643);
            btnsavesettings.Name = "btnsavesettings";
            btnsavesettings.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnsavesettings.Size = new Size(161, 40);
            btnsavesettings.TabIndex = 13;
            btnsavesettings.Text = "Save";
            btnsavesettings.Click += btnsavesettings_Click;
            // 
            // cbalwaysontop
            // 
            cbalwaysontop.AutoSize = true;
            cbalwaysontop.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbalwaysontop.CheckedState.BorderRadius = 0;
            cbalwaysontop.CheckedState.BorderThickness = 0;
            cbalwaysontop.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbalwaysontop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbalwaysontop.Location = new Point(307, 118);
            cbalwaysontop.Name = "cbalwaysontop";
            cbalwaysontop.Size = new Size(103, 19);
            cbalwaysontop.TabIndex = 14;
            cbalwaysontop.Text = "Always on top";
            cbalwaysontop.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbalwaysontop.UncheckedState.BorderRadius = 0;
            cbalwaysontop.UncheckedState.BorderThickness = 0;
            cbalwaysontop.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // lblappsettings
            // 
            lblappsettings.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblappsettings.ForeColor = Color.WhiteSmoke;
            lblappsettings.Location = new Point(299, 86);
            lblappsettings.Name = "lblappsettings";
            lblappsettings.Size = new Size(160, 29);
            lblappsettings.TabIndex = 15;
            lblappsettings.Text = "App Settings:";
            lblappsettings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbdisableunstablemode
            // 
            cbdisableunstablemode.AutoSize = true;
            cbdisableunstablemode.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbdisableunstablemode.CheckedState.BorderRadius = 0;
            cbdisableunstablemode.CheckedState.BorderThickness = 0;
            cbdisableunstablemode.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbdisableunstablemode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbdisableunstablemode.Location = new Point(307, 143);
            cbdisableunstablemode.Name = "cbdisableunstablemode";
            cbdisableunstablemode.Size = new Size(151, 19);
            cbdisableunstablemode.TabIndex = 16;
            cbdisableunstablemode.Text = "Disable unstable mode";
            cbdisableunstablemode.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbdisableunstablemode.UncheckedState.BorderRadius = 0;
            cbdisableunstablemode.UncheckedState.BorderThickness = 0;
            cbdisableunstablemode.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbdisabletlmtry
            // 
            cbdisabletlmtry.AutoSize = true;
            cbdisabletlmtry.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbdisabletlmtry.CheckedState.BorderRadius = 0;
            cbdisabletlmtry.CheckedState.BorderThickness = 0;
            cbdisabletlmtry.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbdisabletlmtry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbdisabletlmtry.Location = new Point(307, 168);
            cbdisabletlmtry.Name = "cbdisabletlmtry";
            cbdisabletlmtry.Size = new Size(126, 19);
            cbdisabletlmtry.TabIndex = 17;
            cbdisabletlmtry.Text = "Disable Telemetry";
            cbdisabletlmtry.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbdisabletlmtry.UncheckedState.BorderRadius = 0;
            cbdisabletlmtry.UncheckedState.BorderThickness = 0;
            cbdisabletlmtry.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cberrorreport
            // 
            cberrorreport.AutoSize = true;
            cberrorreport.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cberrorreport.CheckedState.BorderRadius = 0;
            cberrorreport.CheckedState.BorderThickness = 0;
            cberrorreport.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cberrorreport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cberrorreport.Location = new Point(307, 193);
            cberrorreport.Name = "cberrorreport";
            cberrorreport.Size = new Size(156, 19);
            cberrorreport.TabIndex = 18;
            cberrorreport.Text = "Disable Error Reporting";
            cberrorreport.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cberrorreport.UncheckedState.BorderRadius = 0;
            cberrorreport.UncheckedState.BorderThickness = 0;
            cberrorreport.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // disablerpc
            // 
            disablerpc.AutoSize = true;
            disablerpc.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            disablerpc.CheckedState.BorderRadius = 0;
            disablerpc.CheckedState.BorderThickness = 0;
            disablerpc.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            disablerpc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            disablerpc.Location = new Point(307, 218);
            disablerpc.Name = "disablerpc";
            disablerpc.Size = new Size(136, 19);
            disablerpc.TabIndex = 19;
            disablerpc.Text = "Disable Discord RPC";
            disablerpc.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            disablerpc.UncheckedState.BorderRadius = 0;
            disablerpc.UncheckedState.BorderThickness = 0;
            disablerpc.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // lblexperimentalsettings
            // 
            lblexperimentalsettings.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblexperimentalsettings.ForeColor = Color.WhiteSmoke;
            lblexperimentalsettings.Location = new Point(299, 397);
            lblexperimentalsettings.Name = "lblexperimentalsettings";
            lblexperimentalsettings.Size = new Size(292, 29);
            lblexperimentalsettings.TabIndex = 20;
            lblexperimentalsettings.Text = "Experimental Settings: (SOON)";
            lblexperimentalsettings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblappinfo
            // 
            lblappinfo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblappinfo.ForeColor = Color.WhiteSmoke;
            lblappinfo.Location = new Point(303, 589);
            lblappinfo.Name = "lblappinfo";
            lblappinfo.Size = new Size(292, 29);
            lblappinfo.TabIndex = 21;
            lblappinfo.Text = "App Info:";
            lblappinfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblappversion
            // 
            lblappversion.AutoSize = true;
            lblappversion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblappversion.ForeColor = Color.WhiteSmoke;
            lblappversion.Location = new Point(307, 618);
            lblappversion.Name = "lblappversion";
            lblappversion.Size = new Size(139, 19);
            lblappversion.TabIndex = 22;
            lblappversion.Text = "Version: %version%";
            lblappversion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblbranch
            // 
            lblbranch.AutoSize = true;
            lblbranch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblbranch.ForeColor = Color.WhiteSmoke;
            lblbranch.Location = new Point(307, 637);
            lblbranch.Name = "lblbranch";
            lblbranch.Size = new Size(133, 19);
            lblbranch.TabIndex = 23;
            lblbranch.Text = "Branch: %branch%";
            lblbranch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DragController
            // 
            DragController.DockIndicatorTransparencyValue = 0.6D;
            DragController.DragStartTransparencyValue = 0.6D;
            DragController.TargetControl = navbar;
            DragController.UseTransparentDrag = true;
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 20;
            Elipse.TargetControl = this;
            // 
            // cbnoicon
            // 
            cbnoicon.AutoSize = true;
            cbnoicon.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbnoicon.CheckedState.BorderRadius = 0;
            cbnoicon.CheckedState.BorderThickness = 0;
            cbnoicon.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbnoicon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbnoicon.Location = new Point(307, 302);
            cbnoicon.Name = "cbnoicon";
            cbnoicon.Size = new Size(200, 19);
            cbnoicon.TabIndex = 24;
            cbnoicon.Text = "Disable Server Icon (Minecraft)";
            cbnoicon.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbnoicon.UncheckedState.BorderRadius = 0;
            cbnoicon.UncheckedState.BorderThickness = 0;
            cbnoicon.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(299, 259);
            label1.Name = "label1";
            label1.Size = new Size(292, 29);
            label1.TabIndex = 25;
            label1.Text = "Server Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2CheckBox1.Location = new Point(307, 327);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(49, 19);
            guna2CheckBox1.TabIndex = 26;
            guna2CheckBox1.Text = "Test";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 28, 46);
            ClientSize = new Size(1095, 695);
            Controls.Add(guna2CheckBox1);
            Controls.Add(label1);
            Controls.Add(cbnoicon);
            Controls.Add(lblbranch);
            Controls.Add(lblappversion);
            Controls.Add(lblappinfo);
            Controls.Add(lblexperimentalsettings);
            Controls.Add(disablerpc);
            Controls.Add(cberrorreport);
            Controls.Add(cbdisabletlmtry);
            Controls.Add(cbdisableunstablemode);
            Controls.Add(lblappsettings);
            Controls.Add(cbalwaysontop);
            Controls.Add(btnsavesettings);
            Controls.Add(lblsettings);
            Controls.Add(sidebar);
            Controls.Add(navbar);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pterodactyl";
            Load += FrmSettings_Load;
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
        private Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnsettings;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnsvlist;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Label lblpanelname;
        private PictureBox pbpanellogo;
        private Label lblsettings;
        private Guna.UI2.WinForms.Guna2Button btnsavesettings;
        private Guna.UI2.WinForms.Guna2CheckBox cbalwaysontop;
        private Label lblappsettings;
        private Guna.UI2.WinForms.Guna2CheckBox cbdisableunstablemode;
        private Guna.UI2.WinForms.Guna2CheckBox cbdisabletlmtry;
        private Guna.UI2.WinForms.Guna2CheckBox cberrorreport;
        private Guna.UI2.WinForms.Guna2CheckBox disablerpc;
        private Label lblexperimentalsettings;
        private Label lblappinfo;
        private Label lblappversion;
        private Label lblbranch;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox cbnoicon;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
    }
}