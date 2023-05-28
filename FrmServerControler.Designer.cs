namespace PteroController
{
    partial class FrmServerControler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerControler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.svname = new System.Windows.Forms.Label();
            this.svnode = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.navbar = new System.Windows.Forms.Panel();
            this.lblappname = new System.Windows.Forms.Label();
            this.appicon = new System.Windows.Forms.PictureBox();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.sidenav = new System.Windows.Forms.Panel();
            this.btnsftp = new Guna.UI2.WinForms.Guna2Button();
            this.btnconsole = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.commandTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsend = new Guna.UI2.WinForms.Guna2Button();
            this.lblsvip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.psvkill = new System.Windows.Forms.PictureBox();
            this.svshutdown = new System.Windows.Forms.PictureBox();
            this.svrestart = new System.Windows.Forms.PictureBox();
            this.svstart = new System.Windows.Forms.PictureBox();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.lblcopy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsvinfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbldisk = new System.Windows.Forms.Label();
            this.lblcpu = new System.Windows.Forms.Label();
            this.lblram = new System.Windows.Forms.Label();
            this.lblsvlimit = new System.Windows.Forms.Label();
            this.pcsvimg = new System.Windows.Forms.PictureBox();
            this.Pages = new Manina.Windows.Forms.TabControl();
            this.tab1 = new Manina.Windows.Forms.Tab();
            this.tab2 = new Manina.Windows.Forms.Tab();
            this.btndbs = new Guna.UI2.WinForms.Guna2Button();
            this.dataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).BeginInit();
            this.sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.psvkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svshutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svstart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcsvimg)).BeginInit();
            this.Pages.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // svname
            // 
            resources.ApplyResources(this.svname, "svname");
            this.svname.Name = "svname";
            // 
            // svnode
            // 
            resources.ApplyResources(this.svnode, "svnode");
            this.svnode.Name = "svnode";
            // 
            // timer1
            // 
            this.timer1.Interval = 840000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.navbar.Controls.Add(this.lblappname);
            this.navbar.Controls.Add(this.appicon);
            this.navbar.Controls.Add(this.lblmin);
            this.navbar.Controls.Add(this.lblexit);
            resources.ApplyResources(this.navbar, "navbar");
            this.navbar.Name = "navbar";
            // 
            // lblappname
            // 
            resources.ApplyResources(this.lblappname, "lblappname");
            this.lblappname.BackColor = System.Drawing.Color.Transparent;
            this.lblappname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblappname.Name = "lblappname";
            // 
            // appicon
            // 
            this.appicon.Image = global::PteroController.Properties.Resources.pterry;
            resources.ApplyResources(this.appicon, "appicon");
            this.appicon.Name = "appicon";
            this.appicon.TabStop = false;
            // 
            // lblmin
            // 
            resources.ApplyResources(this.lblmin, "lblmin");
            this.lblmin.BackColor = System.Drawing.Color.Transparent;
            this.lblmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblmin.Name = "lblmin";
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            resources.ApplyResources(this.lblexit, "lblexit");
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblexit.Name = "lblexit";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // sidenav
            // 
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.sidenav.Controls.Add(this.btndbs);
            this.sidenav.Controls.Add(this.btnsftp);
            this.sidenav.Controls.Add(this.btnconsole);
            this.sidenav.Controls.Add(this.guna2Separator2);
            this.sidenav.Controls.Add(this.guna2Button1);
            this.sidenav.Controls.Add(this.btnlogin);
            this.sidenav.Controls.Add(this.pictureBox4);
            this.sidenav.Controls.Add(this.pictureBox3);
            this.sidenav.Controls.Add(this.pictureBox2);
            this.sidenav.Controls.Add(this.guna2Separator1);
            this.sidenav.Controls.Add(this.label2);
            this.sidenav.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.sidenav, "sidenav");
            this.sidenav.Name = "sidenav";
            // 
            // btnsftp
            // 
            this.btnsftp.Animated = true;
            this.btnsftp.BackColor = System.Drawing.Color.Transparent;
            this.btnsftp.BorderColor = System.Drawing.Color.Transparent;
            this.btnsftp.BorderRadius = 10;
            this.btnsftp.CheckedState.Parent = this.btnsftp;
            this.btnsftp.CustomImages.Parent = this.btnsftp;
            this.btnsftp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btnsftp, "btnsftp");
            this.btnsftp.ForeColor = System.Drawing.Color.White;
            this.btnsftp.HoverState.Parent = this.btnsftp;
            this.btnsftp.Image = ((System.Drawing.Image)(resources.GetObject("btnsftp.Image")));
            this.btnsftp.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnsftp.ImageSize = new System.Drawing.Size(28, 28);
            this.btnsftp.Name = "btnsftp";
            this.btnsftp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnsftp.ShadowDecoration.Parent = this.btnsftp;
            this.btnsftp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsftp.TextOffset = new System.Drawing.Point(30, 0);
            this.btnsftp.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnconsole
            // 
            this.btnconsole.Animated = true;
            this.btnconsole.BackColor = System.Drawing.Color.Transparent;
            this.btnconsole.BorderColor = System.Drawing.Color.Transparent;
            this.btnconsole.BorderRadius = 10;
            this.btnconsole.CheckedState.Parent = this.btnconsole;
            this.btnconsole.CustomImages.Parent = this.btnconsole;
            this.btnconsole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            resources.ApplyResources(this.btnconsole, "btnconsole");
            this.btnconsole.ForeColor = System.Drawing.Color.White;
            this.btnconsole.HoverState.Parent = this.btnconsole;
            this.btnconsole.Image = ((System.Drawing.Image)(resources.GetObject("btnconsole.Image")));
            this.btnconsole.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnconsole.ImageSize = new System.Drawing.Size(28, 28);
            this.btnconsole.Name = "btnconsole";
            this.btnconsole.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnconsole.ShadowDecoration.Parent = this.btnconsole;
            this.btnconsole.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsole.TextOffset = new System.Drawing.Point(30, 0);
            this.btnconsole.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Separator2
            // 
            resources.ApplyResources(this.guna2Separator2, "guna2Separator2");
            this.guna2Separator2.Name = "guna2Separator2";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-75, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(30, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.BorderRadius = 10;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnlogin.ImageSize = new System.Drawing.Size(28, 28);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.TextOffset = new System.Drawing.Point(30, 0);
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PteroController.Properties.Resources.pterry;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            resources.ApplyResources(this.consoleTextBox, "consoleTextBox");
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.navbar;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // commandTextBox
            // 
            this.commandTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.commandTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.commandTextBox.BorderRadius = 12;
            this.commandTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commandTextBox.DefaultText = "";
            this.commandTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.commandTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.commandTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commandTextBox.DisabledState.Parent = this.commandTextBox;
            this.commandTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commandTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.commandTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commandTextBox.FocusedState.Parent = this.commandTextBox;
            this.commandTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.commandTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.commandTextBox.HoverState.Parent = this.commandTextBox;
            resources.ApplyResources(this.commandTextBox, "commandTextBox");
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.PasswordChar = '\0';
            this.commandTextBox.PlaceholderText = "";
            this.commandTextBox.SelectedText = "";
            this.commandTextBox.ShadowDecoration.Parent = this.commandTextBox;
            // 
            // btnsend
            // 
            this.btnsend.Animated = true;
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.btnsend.BorderColor = System.Drawing.Color.Transparent;
            this.btnsend.BorderRadius = 10;
            this.btnsend.CheckedState.Parent = this.btnsend;
            this.btnsend.CustomImages.Parent = this.btnsend;
            this.btnsend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            resources.ApplyResources(this.btnsend, "btnsend");
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.HoverState.Parent = this.btnsend;
            this.btnsend.Name = "btnsend";
            this.btnsend.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnsend.ShadowDecoration.Parent = this.btnsend;
            this.guna2HtmlToolTip1.SetToolTip(this.btnsend, resources.GetString("btnsend.ToolTip"));
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblsvip
            // 
            resources.ApplyResources(this.lblsvip, "lblsvip");
            this.lblsvip.Name = "lblsvip";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.consoleTextBox);
            this.panel1.Controls.Add(this.psvkill);
            this.panel1.Controls.Add(this.svshutdown);
            this.panel1.Controls.Add(this.btnsend);
            this.panel1.Controls.Add(this.svrestart);
            this.panel1.Controls.Add(this.commandTextBox);
            this.panel1.Controls.Add(this.svstart);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // psvkill
            // 
            resources.ApplyResources(this.psvkill, "psvkill");
            this.psvkill.Name = "psvkill";
            this.psvkill.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.psvkill, resources.GetString("psvkill.ToolTip"));
            this.psvkill.Click += new System.EventHandler(this.svkill_Click);
            // 
            // svshutdown
            // 
            resources.ApplyResources(this.svshutdown, "svshutdown");
            this.svshutdown.Name = "svshutdown";
            this.svshutdown.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.svshutdown, resources.GetString("svshutdown.ToolTip"));
            this.svshutdown.Click += new System.EventHandler(this.svshutdown_Click);
            // 
            // svrestart
            // 
            resources.ApplyResources(this.svrestart, "svrestart");
            this.svrestart.Name = "svrestart";
            this.svrestart.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.svrestart, resources.GetString("svrestart.ToolTip"));
            this.svrestart.Click += new System.EventHandler(this.svrestart_Click);
            // 
            // svstart
            // 
            resources.ApplyResources(this.svstart, "svstart");
            this.svstart.Name = "svstart";
            this.svstart.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.svstart, resources.GetString("svstart.ToolTip"));
            this.svstart.Click += new System.EventHandler(this.svstart_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // lblcopy
            // 
            resources.ApplyResources(this.lblcopy, "lblcopy");
            this.lblcopy.BackColor = System.Drawing.Color.Transparent;
            this.lblcopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblcopy.Name = "lblcopy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.lblsvinfo);
            this.panel2.Controls.Add(this.svname);
            this.panel2.Controls.Add(this.lblsvip);
            this.panel2.Controls.Add(this.svnode);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblsvinfo
            // 
            resources.ApplyResources(this.lblsvinfo, "lblsvinfo");
            this.lblsvinfo.Name = "lblsvinfo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.lbldisk);
            this.panel3.Controls.Add(this.lblcpu);
            this.panel3.Controls.Add(this.lblram);
            this.panel3.Controls.Add(this.lblsvlimit);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbldisk
            // 
            resources.ApplyResources(this.lbldisk, "lbldisk");
            this.lbldisk.Name = "lbldisk";
            // 
            // lblcpu
            // 
            resources.ApplyResources(this.lblcpu, "lblcpu");
            this.lblcpu.Name = "lblcpu";
            // 
            // lblram
            // 
            resources.ApplyResources(this.lblram, "lblram");
            this.lblram.Name = "lblram";
            // 
            // lblsvlimit
            // 
            resources.ApplyResources(this.lblsvlimit, "lblsvlimit");
            this.lblsvlimit.Name = "lblsvlimit";
            // 
            // pcsvimg
            // 
            resources.ApplyResources(this.pcsvimg, "pcsvimg");
            this.pcsvimg.Name = "pcsvimg";
            this.pcsvimg.TabStop = false;
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.tab1);
            this.Pages.Controls.Add(this.tab2);
            resources.ApplyResources(this.Pages, "Pages");
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 1;
            this.Pages.TabLocation = ((Manina.Windows.Forms.TabLocation)((Manina.Windows.Forms.TabLocation.Near | Manina.Windows.Forms.TabLocation.Bottom)));
            this.Pages.Tabs.Add(this.tab1);
            this.Pages.Tabs.Add(this.tab2);
            this.Pages.TabSizing = Manina.Windows.Forms.TabSizing.Fixed;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.tab1.Controls.Add(this.panel2);
            this.tab1.Controls.Add(this.lblcopy);
            this.tab1.Controls.Add(this.pcsvimg);
            this.tab1.Controls.Add(this.panel3);
            this.tab1.Controls.Add(this.panel1);
            resources.ApplyResources(this.tab1, "tab1");
            this.tab1.Name = "tab1";
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.tab2.Controls.Add(this.dataTable);
            resources.ApplyResources(this.tab2, "tab2");
            this.tab2.Name = "tab2";
            // 
            // btndbs
            // 
            this.btndbs.Animated = true;
            this.btndbs.BackColor = System.Drawing.Color.Transparent;
            this.btndbs.BorderColor = System.Drawing.Color.Transparent;
            this.btndbs.BorderRadius = 10;
            this.btndbs.CheckedState.Parent = this.btndbs;
            this.btndbs.CustomImages.Parent = this.btndbs;
            this.btndbs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btndbs, "btndbs");
            this.btndbs.ForeColor = System.Drawing.Color.White;
            this.btndbs.HoverState.Parent = this.btndbs;
            this.btndbs.Image = ((System.Drawing.Image)(resources.GetObject("btndbs.Image")));
            this.btndbs.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btndbs.ImageSize = new System.Drawing.Size(28, 28);
            this.btndbs.Name = "btndbs";
            this.btndbs.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btndbs.ShadowDecoration.Parent = this.btndbs;
            this.btndbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndbs.TextOffset = new System.Drawing.Point(30, 0);
            this.btndbs.Click += new System.EventHandler(this.btndbs_Click);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataTable, "dataTable");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.dataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTable.ThemeStyle.HeaderStyle.Height = 25;
            this.dataTable.ThemeStyle.ReadOnly = true;
            this.dataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.dataTable.ThemeStyle.RowsStyle.Height = 22;
            this.dataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellDoubleClick);
            this.dataTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTable_CellMouseClick);
            // 
            // FrmServerControler
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.sidenav);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServerControler";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).EndInit();
            this.sidenav.ResumeLayout(false);
            this.sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.psvkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svshutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svstart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcsvimg)).EndInit();
            this.Pages.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label svname;
        private System.Windows.Forms.Label svnode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label lblappname;
        private System.Windows.Forms.PictureBox appicon;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Panel sidenav;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private Guna.UI2.WinForms.Guna2Button btnconsole;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnsftp;
        private Guna.UI2.WinForms.Guna2TextBox commandTextBox;
        private Guna.UI2.WinForms.Guna2Button btnsend;
        private System.Windows.Forms.Label lblsvip;
        private System.Windows.Forms.PictureBox svshutdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox psvkill;
        private System.Windows.Forms.PictureBox svrestart;
        private System.Windows.Forms.PictureBox svstart;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Label lblcopy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsvinfo;
        private System.Windows.Forms.Label lblsvlimit;
        private System.Windows.Forms.Label lblram;
        private System.Windows.Forms.Label lbldisk;
        private System.Windows.Forms.Label lblcpu;
        private System.Windows.Forms.PictureBox pcsvimg;
        private Manina.Windows.Forms.TabControl Pages;
        private Manina.Windows.Forms.Tab tab1;
        private Manina.Windows.Forms.Tab tab2;
        private Guna.UI2.WinForms.Guna2Button btndbs;
        private Guna.UI2.WinForms.Guna2DataGridView dataTable;
    }
}

