namespace PteroController
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
            Pages = new Guna.UI2.WinForms.Guna2TabControl();
            PageHome = new TabPage();
            PageFiles = new TabPage();
            PageDatabases = new TabPage();
            PageBackups = new TabPage();
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            subnavbar = new Panel();
            pblblpanellogo = new PictureBox();
            txtpanelname = new Label();
            btnservers = new PictureBox();
            btnlogout = new PictureBox();
            pbavatar = new PictureBox();
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            Pages.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            subnavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblblpanellogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnservers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnlogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbavatar).BeginInit();
            SuspendLayout();
            // 
            // Pages
            // 
            Pages.Alignment = TabAlignment.Left;
            Pages.Controls.Add(PageHome);
            Pages.Controls.Add(PageFiles);
            Pages.Controls.Add(PageDatabases);
            Pages.Controls.Add(PageBackups);
            Pages.Dock = DockStyle.Fill;
            Pages.ItemSize = new Size(180, 40);
            Pages.Location = new Point(0, 62);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new Size(1018, 590);
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
            // 
            // PageHome
            // 
            PageHome.BackColor = Color.FromArgb(30, 45, 59);
            PageHome.Location = new Point(184, 4);
            PageHome.Name = "PageHome";
            PageHome.Padding = new Padding(3);
            PageHome.Size = new Size(830, 582);
            PageHome.TabIndex = 0;
            PageHome.Text = "Home";
            // 
            // PageFiles
            // 
            PageFiles.Location = new Point(184, 4);
            PageFiles.Name = "PageFiles";
            PageFiles.Padding = new Padding(3);
            PageFiles.Size = new Size(830, 582);
            PageFiles.TabIndex = 1;
            PageFiles.Text = "Files";
            PageFiles.UseVisualStyleBackColor = true;
            // 
            // PageDatabases
            // 
            PageDatabases.Location = new Point(184, 4);
            PageDatabases.Name = "PageDatabases";
            PageDatabases.Size = new Size(830, 581);
            PageDatabases.TabIndex = 2;
            PageDatabases.Text = "Databases";
            PageDatabases.UseVisualStyleBackColor = true;
            // 
            // PageBackups
            // 
            PageBackups.Location = new Point(184, 4);
            PageBackups.Name = "PageBackups";
            PageBackups.Size = new Size(830, 581);
            PageBackups.TabIndex = 3;
            PageBackups.Text = "Backups";
            PageBackups.UseVisualStyleBackColor = true;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(29, 37, 49);
            navbar.Controls.Add(lblappname);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblexit);
            navbar.Controls.Add(pbappicon);
            navbar.Controls.Add(subnavbar);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1018, 62);
            navbar.TabIndex = 1;
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
            lblminimize.Location = new Point(980, 0);
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
            lblexit.Location = new Point(996, 2);
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
            // subnavbar
            // 
            subnavbar.BackColor = Color.FromArgb(33, 42, 57);
            subnavbar.Controls.Add(pblblpanellogo);
            subnavbar.Controls.Add(txtpanelname);
            subnavbar.Controls.Add(btnservers);
            subnavbar.Controls.Add(btnlogout);
            subnavbar.Controls.Add(pbavatar);
            subnavbar.Dock = DockStyle.Bottom;
            subnavbar.Location = new Point(0, 24);
            subnavbar.Name = "subnavbar";
            subnavbar.Size = new Size(1018, 38);
            subnavbar.TabIndex = 0;
            // 
            // pblblpanellogo
            // 
            pblblpanellogo.Image = Properties.Resources.pterry1;
            pblblpanellogo.Location = new Point(8, 3);
            pblblpanellogo.Name = "pblblpanellogo";
            pblblpanellogo.Size = new Size(32, 32);
            pblblpanellogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pblblpanellogo.TabIndex = 6;
            pblblpanellogo.TabStop = false;
            // 
            // txtpanelname
            // 
            txtpanelname.AutoSize = true;
            txtpanelname.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtpanelname.ForeColor = Color.WhiteSmoke;
            txtpanelname.Location = new Point(46, 3);
            txtpanelname.Name = "txtpanelname";
            txtpanelname.Size = new Size(179, 28);
            txtpanelname.TabIndex = 5;
            txtpanelname.Text = "Pterodactyl Panel";
            // 
            // btnservers
            // 
            btnservers.Image = (Image)resources.GetObject("btnservers.Image");
            btnservers.Location = new Point(898, 4);
            btnservers.Name = "btnservers";
            btnservers.Size = new Size(32, 32);
            btnservers.SizeMode = PictureBoxSizeMode.StretchImage;
            btnservers.TabIndex = 2;
            btnservers.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(974, 4);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(32, 32);
            btnlogout.SizeMode = PictureBoxSizeMode.StretchImage;
            btnlogout.TabIndex = 1;
            btnlogout.TabStop = false;
            // 
            // pbavatar
            // 
            pbavatar.Image = Properties.Resources.test;
            pbavatar.Location = new Point(936, 4);
            pbavatar.Name = "pbavatar";
            pbavatar.Size = new Size(32, 32);
            pbavatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbavatar.TabIndex = 0;
            pbavatar.TabStop = false;
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
            // FrmServerController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 652);
            Controls.Add(Pages);
            Controls.Add(navbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServerController";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmServerController";
            Load += FrmServerController_Load;
            Pages.ResumeLayout(false);
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            subnavbar.ResumeLayout(false);
            subnavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblblpanellogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnservers).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnlogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbavatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl Pages;
        private TabPage PageHome;
        private TabPage PageFiles;
        private Panel navbar;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private Panel subnavbar;
        private PictureBox pbappicon;
        private Label lblminimize;
        private Label lblexit;
        private Label lblappname;
        private TabPage PageDatabases;
        private TabPage PageBackups;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private PictureBox pbavatar;
        private PictureBox btnlogout;
        private PictureBox btnservers;
        private Label txtpanelname;
        private PictureBox pblblpanellogo;
    }
}