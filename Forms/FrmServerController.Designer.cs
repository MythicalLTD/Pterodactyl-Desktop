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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerController));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Pages = new Guna.UI2.WinForms.Guna2TabControl();
            PageHome = new TabPage();
            panelpowers = new Panel();
            btnstartconsole = new Guna.UI2.WinForms.Guna2Button();
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
            PageDatabases = new TabPage();
            btnnewdb = new Guna.UI2.WinForms.Guna2Button();
            dataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            lbldbsub = new Label();
            label1 = new Label();
            lbldbs = new Label();
            PageBackups = new TabPage();
            navbar = new Panel();
            lblappname = new Label();
            pbappicon = new PictureBox();
            lblminimize = new Label();
            lblexit = new Label();
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebar = new Panel();
            btndbs = new Guna.UI2.WinForms.Guna2Button();
            btnserverlist = new Guna.UI2.WinForms.Guna2Button();
            btnfilemanager = new Guna.UI2.WinForms.Guna2Button();
            btnhome = new Guna.UI2.WinForms.Guna2Button();
            lblpanelname = new Label();
            pbpanellogo = new PictureBox();
            ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
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
            PageDatabases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpanellogo).BeginInit();
            SuspendLayout();
            // 
            // Pages
            // 
            Pages.Controls.Add(PageHome);
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
            PageHome.Click += PageHome_Click;
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
            // PageDatabases
            // 
            PageDatabases.BackColor = Color.FromArgb(27, 28, 46);
            PageDatabases.Controls.Add(btnnewdb);
            PageDatabases.Controls.Add(dataTable);
            PageDatabases.Controls.Add(lbldbsub);
            PageDatabases.Controls.Add(label1);
            PageDatabases.Controls.Add(lbldbs);
            PageDatabases.Location = new Point(4, 5);
            PageDatabases.Name = "PageDatabases";
            PageDatabases.Size = new Size(937, 781);
            PageDatabases.TabIndex = 2;
            PageDatabases.Text = "Databases";
            PageDatabases.Click += PageDatabases_Click;
            // 
            // btnnewdb
            // 
            btnnewdb.BorderColor = Color.Transparent;
            btnnewdb.BorderRadius = 10;
            btnnewdb.CustomizableEdges = customizableEdges3;
            btnnewdb.DisabledState.BorderColor = Color.DarkGray;
            btnnewdb.DisabledState.CustomBorderColor = Color.DarkGray;
            btnnewdb.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnnewdb.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnnewdb.FillColor = Color.FromArgb(0, 110, 179);
            btnnewdb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnnewdb.ForeColor = Color.White;
            btnnewdb.Location = new Point(772, 20);
            btnnewdb.Name = "btnnewdb";
            btnnewdb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnnewdb.Size = new Size(144, 30);
            btnnewdb.TabIndex = 10;
            btnnewdb.Text = "New Database";
            btnnewdb.Click += btnnewdb_Click;
            // 
            // dataTable
            // 
            dataTable.AllowUserToAddRows = false;
            dataTable.AllowUserToDeleteRows = false;
            dataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 48, 52);
            dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataTable.BackgroundColor = Color.FromArgb(19, 26, 32);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 16, 18);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataTable.ColumnHeadersHeight = 4;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(114, 117, 119);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            dataTable.GridColor = Color.FromArgb(50, 56, 62);
            dataTable.Location = new Point(12, 65);
            dataTable.Name = "dataTable";
            dataTable.ReadOnly = true;
            dataTable.RowHeadersVisible = false;
            dataTable.RowHeadersWidth = 45;
            dataTable.RowTemplate.Height = 30;
            dataTable.Size = new Size(910, 650);
            dataTable.TabIndex = 0;
            dataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            dataTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(44, 48, 52);
            dataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataTable.ThemeStyle.BackColor = Color.FromArgb(19, 26, 32);
            dataTable.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            dataTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(15, 16, 18);
            dataTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataTable.ThemeStyle.HeaderStyle.Height = 4;
            dataTable.ThemeStyle.ReadOnly = true;
            dataTable.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(33, 37, 41);
            dataTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataTable.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dataTable.ThemeStyle.RowsStyle.Height = 30;
            dataTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(114, 117, 119);
            dataTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dataTable.CellDoubleClick += dataTable_CellDoubleClick;
            // 
            // lbldbsub
            // 
            lbldbsub.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbldbsub.ForeColor = Color.WhiteSmoke;
            lbldbsub.Location = new Point(12, 40);
            lbldbsub.Name = "lbldbsub";
            lbldbsub.Size = new Size(298, 22);
            lbldbsub.TabIndex = 9;
            lbldbsub.Text = "Create databases for your application.";
            lbldbsub.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(349, 374);
            label1.Name = "label1";
            label1.Size = new Size(239, 33);
            label1.TabIndex = 8;
            label1.Text = "Databases";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldbs
            // 
            lbldbs.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbldbs.ForeColor = Color.WhiteSmoke;
            lbldbs.Location = new Point(12, 7);
            lbldbs.Name = "lbldbs";
            lbldbs.Size = new Size(239, 33);
            lbldbs.TabIndex = 7;
            lbldbs.Text = "Databases";
            lbldbs.TextAlign = ContentAlignment.MiddleLeft;
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
            // Elipse
            // 
            Elipse.BorderRadius = 20;
            Elipse.TargetControl = this;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 39, 57);
            sidebar.Controls.Add(btndbs);
            sidebar.Controls.Add(btnserverlist);
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
            // btndbs
            // 
            btndbs.BorderColor = Color.Transparent;
            btndbs.BorderRadius = 10;
            btndbs.CustomizableEdges = customizableEdges5;
            btndbs.DisabledState.BorderColor = Color.DarkGray;
            btndbs.DisabledState.CustomBorderColor = Color.DarkGray;
            btndbs.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btndbs.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btndbs.FillColor = Color.FromArgb(0, 110, 179);
            btndbs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndbs.ForeColor = Color.White;
            btndbs.Location = new Point(12, 316);
            btndbs.Name = "btndbs";
            btndbs.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btndbs.Size = new Size(230, 45);
            btndbs.TabIndex = 10;
            btndbs.Text = "Databases";
            btndbs.Click += btndbs_Click;
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
            btnserverlist.Location = new Point(12, 724);
            btnserverlist.Name = "btnserverlist";
            btnserverlist.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnserverlist.Size = new Size(230, 48);
            btnserverlist.TabIndex = 9;
            btnserverlist.Text = "Server List";
            btnserverlist.Click += btnserverlist_Click;
            // 
            // btnfilemanager
            // 
            btnfilemanager.BorderColor = Color.Transparent;
            btnfilemanager.BorderRadius = 10;
            btnfilemanager.CustomizableEdges = customizableEdges9;
            btnfilemanager.DisabledState.BorderColor = Color.DarkGray;
            btnfilemanager.DisabledState.CustomBorderColor = Color.DarkGray;
            btnfilemanager.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnfilemanager.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnfilemanager.FillColor = Color.FromArgb(0, 110, 179);
            btnfilemanager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfilemanager.ForeColor = Color.White;
            btnfilemanager.Location = new Point(12, 265);
            btnfilemanager.Name = "btnfilemanager";
            btnfilemanager.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnfilemanager.Size = new Size(230, 45);
            btnfilemanager.TabIndex = 8;
            btnfilemanager.Text = "File Manager";
            btnfilemanager.Click += btnfilemanager_Click;
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
            btnhome.Location = new Point(12, 214);
            btnhome.Name = "btnhome";
            btnhome.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            // ToolTip
            // 
            ToolTip.AllowLinksHandling = true;
            ToolTip.MaximumSize = new Size(0, 0);
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
            Text = "Pterodactyl";
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
            PageDatabases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
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
        private Panel navbar;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private PictureBox pbappicon;
        private Label lblminimize;
        private Label lblexit;
        private Label lblappname;
        private TabPage PageDatabases;
        private TabPage PageBackups;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2RadialGauge statscpu;
        private Label lblcpu;
        private Label lblram;
        private Guna.UI2.WinForms.Guna2RadialGauge statsram;
        private Panel sidebar;
        private PictureBox pbpanellogo;
        private Label lblpanelname;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button btnserverlist;
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
        private Label lbldbsub;
        private Label label1;
        private Label lbldbs;
        private Guna.UI2.WinForms.Guna2DataGridView dataTable;
        private Guna.UI2.WinForms.Guna2Button btndbs;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2Button btnnewdb;
    }
}