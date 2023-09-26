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
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            Pages.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
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
            Pages.Size = new Size(1018, 589);
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
            PageHome.Location = new Point(184, 4);
            PageHome.Name = "PageHome";
            PageHome.Padding = new Padding(3);
            PageHome.Size = new Size(830, 581);
            PageHome.TabIndex = 0;
            PageHome.Text = "Home";
            PageHome.UseVisualStyleBackColor = true;
            // 
            // PageFiles
            // 
            PageFiles.Location = new Point(184, 4);
            PageFiles.Name = "PageFiles";
            PageFiles.Padding = new Padding(3);
            PageFiles.Size = new Size(830, 581);
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
            subnavbar.Dock = DockStyle.Bottom;
            subnavbar.Location = new Point(0, 24);
            subnavbar.Name = "subnavbar";
            subnavbar.Size = new Size(1018, 38);
            subnavbar.TabIndex = 0;
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
            ClientSize = new Size(1018, 651);
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
    }
}