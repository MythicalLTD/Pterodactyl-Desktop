namespace Pterodactyl.Forms
{
    partial class FrmServerController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerController));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Pages = new Guna.UI2.WinForms.Guna2TabControl();
            PageHome = new TabPage();
            panelpowers = new Panel();
            pbkill = new PictureBox();
            pbrestart = new PictureBox();
            pbstop = new PictureBox();
            pbstart = new PictureBox();
            panelramgr = new Panel();
            lblram = new Label();
            statscpu = new Guna.UI2.WinForms.Guna2RadialGauge();
            panelcpugr = new Panel();
            statsram = new Guna.UI2.WinForms.Guna2RadialGauge();
            lblcpu = new Label();
            pcsvimg = new PictureBox();
            panellimitations = new Panel();
            lblsvcpu = new Label();
            lblsvdisk = new Label();
            lblsvram = new Label();
            lblsvlimitations = new Label();
            pnlsvinfo = new Panel();
            lblsvstatus = new Label();
            lblsvnode = new Label();
            lblsvip = new Label();
            lblsvname = new Label();
            lblsvinfo = new Label();
            PageFiles = new TabPage();
            PageDatabases = new TabPage();
            PageBackups = new TabPage();
            navbar = new Panel();
            lblappname = new Label();
            pbappicon = new PictureBox();
            lblminimize = new Label();
            lblexit = new Label();
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebar = new Panel();
            btntest = new Guna.UI2.WinForms.Guna2Button();
            btnfilemanager = new Guna.UI2.WinForms.Guna2Button();
            btnhome = new Guna.UI2.WinForms.Guna2Button();
            lblpanelname = new Label();
            pbpanellogo = new PictureBox();
            btnstartconsole = new Guna.UI2.WinForms.Guna2Button();
            Pages.SuspendLayout();
            PageHome.SuspendLayout();
            panelpowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbkill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbrestart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbstop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbstart).BeginInit();
            panelramgr.SuspendLayout();
            panelcpugr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcsvimg).BeginInit();
            panellimitations.SuspendLayout();
            pnlsvinfo.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).BeginInit();
            SuspendLayout();
            // 
            // Pages
            // 
            Pages.Controls.Add(PageHome);
            Pages.Controls.Add(PageFiles);
            Pages.Controls.Add(PageDatabases);
            Pages.Controls.Add(PageBackups);
            Pages.Dock = DockStyle.Fill;
            Pages.ItemSize = new Size(180, 40);
            Pages.Location = new Point(248, 31);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new Size(945, 790);
            Pages.TabButtonHoverState.BorderColor = Color.Empty;
            Pages.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            Pages.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Pages.TabButtonHoverState.ForeColor = Color.White;
            Pages.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            Pages.TabButtonIdleState.BorderColor = Color.Empty;
            Pages.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            Pages.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Pages.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            Pages.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            Pages.TabButtonSelectedState.BorderColor = Color.Empty;
            Pages.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            Pages.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Pages.TabButtonSelectedState.ForeColor = Color.White;
            Pages.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            Pages.TabButtonSize = new Size(180, 40);
            Pages.TabIndex = 0;
            Pages.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            Pages.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            Pages.TabMenuVisible = false;
            // 
            // PageHome
            // 
            PageHome.BackColor = Color.FromArgb(27, 28, 46);
            PageHome.Controls.Add(panelpowers);
            PageHome.Controls.Add(panelramgr);
            PageHome.Controls.Add(panelcpugr);
            PageHome.Controls.Add(pcsvimg);
            PageHome.Controls.Add(panellimitations);
            PageHome.Controls.Add(pnlsvinfo);
            PageHome.Location = new Point(4, 5);
            PageHome.Name = "PageHome";
            PageHome.Padding = new Padding(3);
            PageHome.Size = new Size(937, 781);
            PageHome.TabIndex = 0;
            PageHome.Text = "Home";
            // 
            // panelpowers
            // 
            panelpowers.BackColor = Color.FromArgb(34, 39, 57);
            panelpowers.Controls.Add(btnstartconsole);
            panelpowers.Controls.Add(pbkill);
            panelpowers.Controls.Add(pbrestart);
            panelpowers.Controls.Add(pbstop);
            panelpowers.Controls.Add(pbstart);
            panelpowers.ForeColor = Color.FromArgb(236, 240, 243);
            panelpowers.Location = new Point(357, 665);
            panelpowers.Name = "panelpowers";
            panelpowers.Size = new Size(227, 105);
            panelpowers.TabIndex = 9;
            // 
            // pbkill
            // 
            pbkill.Image = (Image)resources.GetObject("pbkill.Image");
            pbkill.Location = new Point(155, 3);
            pbkill.Name = "pbkill";
            pbkill.Size = new Size(32, 32);
            pbkill.SizeMode = PictureBoxSizeMode.StretchImage;
            pbkill.TabIndex = 3;
            pbkill.TabStop = false;
            pbkill.Click += pbkill_Click;
            // 
            // pbrestart
            // 
            pbrestart.Image = (Image)resources.GetObject("pbrestart.Image");
            pbrestart.Location = new Point(117, 3);
            pbrestart.Name = "pbrestart";
            pbrestart.Size = new Size(32, 32);
            pbrestart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbrestart.TabIndex = 2;
            pbrestart.TabStop = false;
            pbrestart.Click += pbrestart_Click;
            // 
            // pbstop
            // 
            pbstop.Image = (Image)resources.GetObject("pbstop.Image");
            pbstop.Location = new Point(79, 3);
            pbstop.Name = "pbstop";
            pbstop.Size = new Size(32, 32);
            pbstop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbstop.TabIndex = 1;
            pbstop.TabStop = false;
            pbstop.Click += pbstop_Click;
            // 
            // pbstart
            // 
            pbstart.Image = (Image)resources.GetObject("pbstart.Image");
            pbstart.Location = new Point(41, 3);
            pbstart.Name = "pbstart";
            pbstart.Size = new Size(32, 32);
            pbstart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbstart.TabIndex = 0;
            pbstart.TabStop = false;
            pbstart.Click += pbstart_Click;
            // 
            // panelramgr
            // 
            panelramgr.BackColor = Color.FromArgb(34, 39, 57);
            panelramgr.Controls.Add(lblram);
            panelramgr.Controls.Add(statscpu);
            panelramgr.ForeColor = Color.FromArgb(236, 240, 243);
            panelramgr.Location = new Point(590, 455);
            panelramgr.Name = "panelramgr";
            panelramgr.Size = new Size(339, 318);
            panelramgr.TabIndex = 8;
            // 
            // lblram
            // 
            lblram.AutoSize = true;
            lblram.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblram.ForeColor = Color.White;
            lblram.Location = new Point(14, 7);
            lblram.Name = "lblram";
            lblram.Size = new Size(162, 28);
            lblram.TabIndex = 3;
            lblram.Text = "Memory Status:";
            // 
            // statscpu
            // 
            statscpu.ArrowThickness = 3;
            statscpu.BackColor = Color.Transparent;
            statscpu.Font = new Font("Verdana", 8.2F, FontStyle.Regular, GraphicsUnit.Point);
            statscpu.ForeColor = Color.FromArgb(139, 152, 166);
            statscpu.Location = new Point(43, 50);
            statscpu.MinimumSize = new Size(34, 34);
            statscpu.Name = "statscpu";
            statscpu.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            statscpu.ProgressEndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            statscpu.ProgressStartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            statscpu.ProgressThickness = 10;
            statscpu.ShowPercentage = false;
            statscpu.Size = new Size(265, 265);
            statscpu.TabIndex = 0;
            // 
            // panelcpugr
            // 
            panelcpugr.BackColor = Color.FromArgb(34, 39, 57);
            panelcpugr.Controls.Add(statsram);
            panelcpugr.Controls.Add(lblcpu);
            panelcpugr.ForeColor = Color.FromArgb(236, 240, 243);
            panelcpugr.Location = new Point(12, 455);
            panelcpugr.Name = "panelcpugr";
            panelcpugr.Size = new Size(339, 318);
            panelcpugr.TabIndex = 7;
            // 
            // statsram
            // 
            statsram.ArrowThickness = 3;
            statsram.BackColor = Color.Transparent;
            statsram.Font = new Font("Verdana", 8.2F, FontStyle.Regular, GraphicsUnit.Point);
            statsram.ForeColor = Color.FromArgb(139, 152, 166);
            statsram.Location = new Point(43, 50);
            statsram.MinimumSize = new Size(34, 34);
            statsram.Name = "statsram";
            statsram.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            statsram.ProgressEndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            statsram.ProgressStartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            statsram.ProgressThickness = 10;
            statsram.ShowPercentage = false;
            statsram.Size = new Size(265, 265);
            statsram.TabIndex = 2;
            // 
            // lblcpu
            // 
            lblcpu.AutoSize = true;
            lblcpu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblcpu.ForeColor = Color.White;
            lblcpu.Location = new Point(14, 7);
            lblcpu.Name = "lblcpu";
            lblcpu.Size = new Size(173, 28);
            lblcpu.TabIndex = 1;
            lblcpu.Text = "Processor Status:";
            // 
            // pcsvimg
            // 
            pcsvimg.Location = new Point(419, 26);
            pcsvimg.Name = "pcsvimg";
            pcsvimg.Size = new Size(64, 64);
            pcsvimg.TabIndex = 6;
            pcsvimg.TabStop = false;
            // 
            // panellimitations
            // 
            panellimitations.BackColor = Color.FromArgb(34, 39, 57);
            panellimitations.Controls.Add(lblsvcpu);
            panellimitations.Controls.Add(lblsvdisk);
            panellimitations.Controls.Add(lblsvram);
            panellimitations.Controls.Add(lblsvlimitations);
            panellimitations.ForeColor = Color.FromArgb(236, 240, 243);
            panellimitations.Location = new Point(489, 11);
            panellimitations.Name = "panellimitations";
            panellimitations.Size = new Size(440, 105);
            panellimitations.TabIndex = 5;
            // 
            // lblsvcpu
            // 
            lblsvcpu.AutoSize = true;
            lblsvcpu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvcpu.ForeColor = Color.WhiteSmoke;
            lblsvcpu.Location = new Point(3, 42);
            lblsvcpu.Name = "lblsvcpu";
            lblsvcpu.Size = new Size(94, 19);
            lblsvcpu.TabIndex = 10;
            lblsvcpu.Text = "Processor:";
            lblsvcpu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvdisk
            // 
            lblsvdisk.AutoSize = true;
            lblsvdisk.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvdisk.ForeColor = Color.WhiteSmoke;
            lblsvdisk.Location = new Point(3, 61);
            lblsvdisk.Name = "lblsvdisk";
            lblsvdisk.Size = new Size(49, 19);
            lblsvdisk.TabIndex = 9;
            lblsvdisk.Text = "Disk:";
            lblsvdisk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvram
            // 
            lblsvram.AutoSize = true;
            lblsvram.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvram.ForeColor = Color.WhiteSmoke;
            lblsvram.Location = new Point(3, 23);
            lblsvram.Name = "lblsvram";
            lblsvram.Size = new Size(76, 19);
            lblsvram.TabIndex = 8;
            lblsvram.Text = "Memory:";
            lblsvram.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvlimitations
            // 
            lblsvlimitations.AutoSize = true;
            lblsvlimitations.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvlimitations.ForeColor = Color.WhiteSmoke;
            lblsvlimitations.Location = new Point(3, 1);
            lblsvlimitations.Name = "lblsvlimitations";
            lblsvlimitations.Size = new Size(186, 22);
            lblsvlimitations.TabIndex = 7;
            lblsvlimitations.Text = "Server Limitations:";
            lblsvlimitations.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlsvinfo
            // 
            pnlsvinfo.BackColor = Color.FromArgb(34, 39, 57);
            pnlsvinfo.Controls.Add(lblsvstatus);
            pnlsvinfo.Controls.Add(lblsvnode);
            pnlsvinfo.Controls.Add(lblsvip);
            pnlsvinfo.Controls.Add(lblsvname);
            pnlsvinfo.Controls.Add(lblsvinfo);
            pnlsvinfo.ForeColor = Color.FromArgb(236, 240, 243);
            pnlsvinfo.Location = new Point(12, 11);
            pnlsvinfo.Name = "pnlsvinfo";
            pnlsvinfo.Size = new Size(401, 105);
            pnlsvinfo.TabIndex = 4;
            // 
            // lblsvstatus
            // 
            lblsvstatus.AutoSize = true;
            lblsvstatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvstatus.ForeColor = Color.WhiteSmoke;
            lblsvstatus.Location = new Point(3, 41);
            lblsvstatus.Name = "lblsvstatus";
            lblsvstatus.Size = new Size(64, 19);
            lblsvstatus.TabIndex = 11;
            lblsvstatus.Text = "Status:";
            lblsvstatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvnode
            // 
            lblsvnode.AutoSize = true;
            lblsvnode.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvnode.ForeColor = Color.WhiteSmoke;
            lblsvnode.Location = new Point(3, 60);
            lblsvnode.Name = "lblsvnode";
            lblsvnode.Size = new Size(56, 19);
            lblsvnode.TabIndex = 10;
            lblsvnode.Text = "Node:";
            lblsvnode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvip
            // 
            lblsvip.AutoSize = true;
            lblsvip.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvip.ForeColor = Color.WhiteSmoke;
            lblsvip.Location = new Point(3, 79);
            lblsvip.Name = "lblsvip";
            lblsvip.Size = new Size(30, 19);
            lblsvip.TabIndex = 9;
            lblsvip.Text = "IP:";
            lblsvip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvname
            // 
            lblsvname.AutoSize = true;
            lblsvname.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvname.ForeColor = Color.WhiteSmoke;
            lblsvname.Location = new Point(3, 22);
            lblsvname.Name = "lblsvname";
            lblsvname.Size = new Size(59, 19);
            lblsvname.TabIndex = 8;
            lblsvname.Text = "Name:";
            lblsvname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsvinfo
            // 
            lblsvinfo.AutoSize = true;
            lblsvinfo.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvinfo.ForeColor = Color.WhiteSmoke;
            lblsvinfo.Location = new Point(3, 0);
            lblsvinfo.Name = "lblsvinfo";
            lblsvinfo.Size = new Size(190, 22);
            lblsvinfo.TabIndex = 7;
            lblsvinfo.Text = "Server Information:";
            lblsvinfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PageFiles
            // 
            PageFiles.Location = new Point(4, 5);
            PageFiles.Name = "PageFiles";
            PageFiles.Padding = new Padding(3);
            PageFiles.Size = new Size(937, 781);
            PageFiles.TabIndex = 1;
            PageFiles.Text = "Files";
            PageFiles.UseVisualStyleBackColor = true;
            // 
            // PageDatabases
            // 
            PageDatabases.Location = new Point(4, 5);
            PageDatabases.Name = "PageDatabases";
            PageDatabases.Size = new Size(937, 781);
            PageDatabases.TabIndex = 2;
            PageDatabases.Text = "Databases";
            PageDatabases.UseVisualStyleBackColor = true;
            // 
            // PageBackups
            // 
            PageBackups.Location = new Point(4, 5);
            PageBackups.Name = "PageBackups";
            PageBackups.Size = new Size(937, 781);
            PageBackups.TabIndex = 3;
            PageBackups.Text = "Backups";
            PageBackups.UseVisualStyleBackColor = true;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(26, 21, 44);
            navbar.Controls.Add(lblappname);
            navbar.Controls.Add(pbappicon);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblexit);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1193, 31);
            navbar.TabIndex = 1;
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
            // lblminimize
            // 
            lblminimize.AutoSize = true;
            lblminimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblminimize.ForeColor = Color.WhiteSmoke;
            lblminimize.Location = new Point(1153, 4);
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
            lblexit.Location = new Point(1172, 7);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(18, 19);
            lblexit.TabIndex = 2;
            lblexit.Text = "X";
            lblexit.Click += lblexit_Click;
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
            // Elipse
            // 
            Elipse.BorderRadius = 20;
            Elipse.TargetControl = this;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 39, 57);
            sidebar.Controls.Add(btntest);
            sidebar.Controls.Add(btnfilemanager);
            sidebar.Controls.Add(btnhome);
            sidebar.Controls.Add(lblpanelname);
            sidebar.Controls.Add(pbpanellogo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 31);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(248, 790);
            sidebar.TabIndex = 2;
            // 
            // btntest
            // 
            btntest.BorderColor = Color.Transparent;
            btntest.BorderRadius = 10;
            btntest.CustomizableEdges = customizableEdges3;
            btntest.DisabledState.BorderColor = Color.DarkGray;
            btntest.DisabledState.CustomBorderColor = Color.DarkGray;
            btntest.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btntest.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btntest.FillColor = Color.FromArgb(0, 110, 179);
            btntest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntest.ForeColor = Color.White;
            btntest.Location = new Point(12, 316);
            btntest.Name = "btntest";
            btntest.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btntest.Size = new Size(230, 48);
            btntest.TabIndex = 9;
            btntest.Text = "Home";
            // 
            // btnfilemanager
            // 
            btnfilemanager.BorderColor = Color.Transparent;
            btnfilemanager.BorderRadius = 10;
            btnfilemanager.CustomizableEdges = customizableEdges5;
            btnfilemanager.DisabledState.BorderColor = Color.DarkGray;
            btnfilemanager.DisabledState.CustomBorderColor = Color.DarkGray;
            btnfilemanager.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnfilemanager.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnfilemanager.FillColor = Color.FromArgb(0, 110, 179);
            btnfilemanager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfilemanager.ForeColor = Color.White;
            btnfilemanager.Location = new Point(12, 265);
            btnfilemanager.Name = "btnfilemanager";
            btnfilemanager.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnfilemanager.Size = new Size(230, 45);
            btnfilemanager.TabIndex = 8;
            btnfilemanager.Text = "File Manager";
            btnfilemanager.Click += btnfilemanager_Click;
            // 
            // btnhome
            // 
            btnhome.BorderColor = Color.Transparent;
            btnhome.BorderRadius = 10;
            btnhome.CustomizableEdges = customizableEdges7;
            btnhome.DisabledState.BorderColor = Color.DarkGray;
            btnhome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnhome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnhome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnhome.FillColor = Color.FromArgb(0, 110, 179);
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnhome.ForeColor = Color.White;
            btnhome.Location = new Point(12, 214);
            btnhome.Name = "btnhome";
            btnhome.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnhome.Size = new Size(230, 45);
            btnhome.TabIndex = 7;
            btnhome.Text = "Home";
            btnhome.Click += btnhome_Click;
            // 
            // lblpanelname
            // 
            lblpanelname.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblpanelname.ForeColor = Color.WhiteSmoke;
            lblpanelname.Location = new Point(3, 147);
            lblpanelname.Name = "lblpanelname";
            lblpanelname.Size = new Size(239, 33);
            lblpanelname.TabIndex = 6;
            lblpanelname.Text = "Pterodactyl Desktop";
            lblpanelname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbpanellogo
            // 
            pbpanellogo.Image = Properties.Resources.pterry1;
            pbpanellogo.Location = new Point(56, 12);
            pbpanellogo.Name = "pbpanellogo";
            pbpanellogo.Size = new Size(132, 132);
            pbpanellogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpanellogo.TabIndex = 5;
            pbpanellogo.TabStop = false;
            // 
            // btnstartconsole
            // 
            btnstartconsole.BorderColor = Color.Transparent;
            btnstartconsole.BorderRadius = 10;
            btnstartconsole.CustomizableEdges = customizableEdges1;
            btnstartconsole.DisabledState.BorderColor = Color.DarkGray;
            btnstartconsole.DisabledState.CustomBorderColor = Color.DarkGray;
            btnstartconsole.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnstartconsole.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnstartconsole.FillColor = Color.FromArgb(0, 110, 179);
            btnstartconsole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnstartconsole.ForeColor = Color.White;
            btnstartconsole.Location = new Point(28, 54);
            btnstartconsole.Name = "btnstartconsole";
            btnstartconsole.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnstartconsole.Size = new Size(171, 29);
            btnstartconsole.TabIndex = 8;
            btnstartconsole.Text = "Console";
            btnstartconsole.Click += btnstartconsole_Click;
            // 
            // FrmServerController
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 28, 46);
            ClientSize = new Size(1193, 821);
            Controls.Add(Pages);
            Controls.Add(sidebar);
            Controls.Add(navbar);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServerController";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmServerController";
            Load += FrmServerController_Load;
            Pages.ResumeLayout(false);
            PageHome.ResumeLayout(false);
            panelpowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbkill).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbrestart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbstop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbstart).EndInit();
            panelramgr.ResumeLayout(false);
            panelramgr.PerformLayout();
            panelcpugr.ResumeLayout(false);
            panelcpugr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcsvimg).EndInit();
            panellimitations.ResumeLayout(false);
            panellimitations.PerformLayout();
            pnlsvinfo.ResumeLayout(false);
            pnlsvinfo.PerformLayout();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl Pages;
        private TabPage PageHome;
        private TabPage PageFiles;
        private Panel navbar;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private PictureBox pbappicon;
        private Label lblminimize;
        private Label lblexit;
        private Label lblappname;
        private TabPage PageDatabases;
        private TabPage PageBackups;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2RadialGauge statscpu;
        private Label lblcpu;
        private Label lblram;
        private Guna.UI2.WinForms.Guna2RadialGauge statsram;
        private Panel sidebar;
        private PictureBox pbpanellogo;
        private Label lblpanelname;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button btntest;
        private Guna.UI2.WinForms.Guna2Button btnfilemanager;
        private Panel pnlsvinfo;
        private Label lblsvname;
        private Label lblsvinfo;
        private Panel panellimitations;
        private Label lblsvcpu;
        private Label lblsvdisk;
        private Label lblsvram;
        private Label lblsvlimitations;
        private Label lblsvnode;
        private Label lblsvip;
        private PictureBox pcsvimg;
        private Panel panelcpugr;
        private Panel panelramgr;
        private Label lblsvstatus;
        private Panel panelpowers;
        private PictureBox pbstop;
        private PictureBox pbrestart;
        private PictureBox pbkill;
        private PictureBox pbstart;
        private Guna.UI2.WinForms.Guna2Button btnstartconsole;
    }
}