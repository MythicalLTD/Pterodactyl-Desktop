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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerController));
            Pages = new Guna.UI2.WinForms.Guna2TabControl();
            PageHome = new TabPage();
            pcsvimg = new PictureBox();
            panel1 = new Panel();
            lblsvcpu = new Label();
            lblsvdisk = new Label();
            lblsvram = new Label();
            lblsvlimitations = new Label();
            pnlsvinfo = new Panel();
            lblsvnode = new Label();
            lblsvip = new Label();
            lblsvname = new Label();
            lblsvinfo = new Label();
            lblram = new Label();
            statsram = new Guna.UI2.WinForms.Guna2RadialGauge();
            lblcpu = new Label();
            statscpu = new Guna.UI2.WinForms.Guna2RadialGauge();
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
            panel2 = new Panel();
            panel3 = new Panel();
            lblsvstatus = new Label();
            Pages.SuspendLayout();
            PageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcsvimg).BeginInit();
            panel1.SuspendLayout();
            pnlsvinfo.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            PageHome.Controls.Add(panel3);
            PageHome.Controls.Add(panel2);
            PageHome.Controls.Add(pcsvimg);
            PageHome.Controls.Add(panel1);
            PageHome.Controls.Add(pnlsvinfo);
            PageHome.Location = new Point(4, 5);
            PageHome.Name = "PageHome";
            PageHome.Padding = new Padding(3);
            PageHome.Size = new Size(937, 781);
            PageHome.TabIndex = 0;
            PageHome.Text = "Home";
            // 
            // pcsvimg
            // 
            pcsvimg.Location = new Point(419, 11);
            pcsvimg.Name = "pcsvimg";
            pcsvimg.Size = new Size(64, 64);
            pcsvimg.TabIndex = 6;
            pcsvimg.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 39, 57);
            panel1.Controls.Add(lblsvcpu);
            panel1.Controls.Add(lblsvdisk);
            panel1.Controls.Add(lblsvram);
            panel1.Controls.Add(lblsvlimitations);
            panel1.ForeColor = Color.FromArgb(236, 240, 243);
            panel1.Location = new Point(684, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 105);
            panel1.TabIndex = 5;
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
            lblsvdisk.Click += lblsvdisk_Click;
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
            pnlsvinfo.Size = new Size(245, 105);
            pnlsvinfo.TabIndex = 4;
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
            btntest.CustomizableEdges = customizableEdges1;
            btntest.DisabledState.BorderColor = Color.DarkGray;
            btntest.DisabledState.CustomBorderColor = Color.DarkGray;
            btntest.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btntest.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btntest.FillColor = Color.FromArgb(0, 110, 179);
            btntest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntest.ForeColor = Color.White;
            btntest.Location = new Point(12, 316);
            btntest.Name = "btntest";
            btntest.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btntest.Size = new Size(230, 48);
            btntest.TabIndex = 9;
            btntest.Text = "Home";
            // 
            // btnfilemanager
            // 
            btnfilemanager.BorderColor = Color.Transparent;
            btnfilemanager.BorderRadius = 10;
            btnfilemanager.CustomizableEdges = customizableEdges3;
            btnfilemanager.DisabledState.BorderColor = Color.DarkGray;
            btnfilemanager.DisabledState.CustomBorderColor = Color.DarkGray;
            btnfilemanager.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnfilemanager.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnfilemanager.FillColor = Color.FromArgb(0, 110, 179);
            btnfilemanager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfilemanager.ForeColor = Color.White;
            btnfilemanager.Location = new Point(12, 265);
            btnfilemanager.Name = "btnfilemanager";
            btnfilemanager.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnfilemanager.Size = new Size(230, 45);
            btnfilemanager.TabIndex = 8;
            btnfilemanager.Text = "File Manager";
            btnfilemanager.Click += btnfilemanager_Click;
            // 
            // btnhome
            // 
            btnhome.BorderColor = Color.Transparent;
            btnhome.BorderRadius = 10;
            btnhome.CustomizableEdges = customizableEdges5;
            btnhome.DisabledState.BorderColor = Color.DarkGray;
            btnhome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnhome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnhome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnhome.FillColor = Color.FromArgb(0, 110, 179);
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnhome.ForeColor = Color.White;
            btnhome.Location = new Point(12, 214);
            btnhome.Name = "btnhome";
            btnhome.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 39, 57);
            panel2.Controls.Add(statsram);
            panel2.Controls.Add(lblcpu);
            panel2.ForeColor = Color.FromArgb(236, 240, 243);
            panel2.Location = new Point(12, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 318);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(34, 39, 57);
            panel3.Controls.Add(lblram);
            panel3.Controls.Add(statscpu);
            panel3.ForeColor = Color.FromArgb(236, 240, 243);
            panel3.Location = new Point(590, 455);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 318);
            panel3.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)pcsvimg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlsvinfo.ResumeLayout(false);
            pnlsvinfo.PerformLayout();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel1;
        private Label lblsvcpu;
        private Label lblsvdisk;
        private Label lblsvram;
        private Label lblsvlimitations;
        private Label lblsvnode;
        private Label lblsvip;
        private PictureBox pcsvimg;
        private Panel panel2;
        private Panel panel3;
        private Label lblsvstatus;
    }
}