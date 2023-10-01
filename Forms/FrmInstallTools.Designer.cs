namespace PteroController.Forms
{
    partial class FrmInstallTools
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstallTools));
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            lblinstallinfo = new Label();
            lblinstalldesc = new Label();
            btnaccpetinstall = new Guna.UI2.WinForms.Guna2Button();
            btndeny = new Guna.UI2.WinForms.Guna2Button();
            lbldonotclose = new Label();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            SuspendLayout();
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
            navbar.Size = new Size(1018, 28);
            navbar.TabIndex = 2;
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
            // lblinstallinfo
            // 
            lblinstallinfo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblinstallinfo.ForeColor = Color.WhiteSmoke;
            lblinstallinfo.Location = new Point(12, 45);
            lblinstallinfo.Name = "lblinstallinfo";
            lblinstallinfo.Size = new Size(982, 37);
            lblinstallinfo.TabIndex = 5;
            lblinstallinfo.Text = "Additional software installation";
            lblinstallinfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblinstalldesc
            // 
            lblinstalldesc.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblinstalldesc.ForeColor = Color.WhiteSmoke;
            lblinstalldesc.Location = new Point(12, 82);
            lblinstalldesc.Name = "lblinstalldesc";
            lblinstalldesc.Size = new Size(992, 25);
            lblinstalldesc.TabIndex = 6;
            lblinstalldesc.Text = "To use the PteroController, we will have to install additional packages for a smooth and up-to-date experience!";
            lblinstalldesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnaccpetinstall
            // 
            btnaccpetinstall.BorderColor = Color.Transparent;
            btnaccpetinstall.BorderRadius = 12;
            btnaccpetinstall.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnaccpetinstall.BorderThickness = 2;
            btnaccpetinstall.CustomizableEdges = customizableEdges3;
            btnaccpetinstall.DisabledState.BorderColor = Color.DarkGray;
            btnaccpetinstall.DisabledState.CustomBorderColor = Color.DarkGray;
            btnaccpetinstall.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnaccpetinstall.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnaccpetinstall.FillColor = Color.FromArgb(59, 130, 246);
            btnaccpetinstall.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnaccpetinstall.ForeColor = Color.White;
            btnaccpetinstall.Location = new Point(400, 153);
            btnaccpetinstall.Name = "btnaccpetinstall";
            btnaccpetinstall.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnaccpetinstall.Size = new Size(85, 30);
            btnaccpetinstall.TabIndex = 7;
            btnaccpetinstall.Text = "Accept";
            btnaccpetinstall.Click += btnaccpetinstall_Click;
            // 
            // btndeny
            // 
            btndeny.BorderColor = Color.Transparent;
            btndeny.BorderRadius = 12;
            btndeny.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btndeny.BorderThickness = 2;
            btndeny.CustomizableEdges = customizableEdges1;
            btndeny.DisabledState.BorderColor = Color.DarkGray;
            btndeny.DisabledState.CustomBorderColor = Color.DarkGray;
            btndeny.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btndeny.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btndeny.FillColor = Color.FromArgb(59, 130, 246);
            btndeny.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btndeny.ForeColor = Color.White;
            btndeny.Location = new Point(517, 153);
            btndeny.Name = "btndeny";
            btndeny.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btndeny.Size = new Size(85, 30);
            btndeny.TabIndex = 8;
            btndeny.Text = "Deny";
            btndeny.Click += guna2Button1_Click;
            // 
            // lbldonotclose
            // 
            lbldonotclose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldonotclose.ForeColor = Color.WhiteSmoke;
            lbldonotclose.Location = new Point(11, 107);
            lbldonotclose.Name = "lbldonotclose";
            lbldonotclose.Size = new Size(992, 25);
            lbldonotclose.TabIndex = 9;
            lbldonotclose.Text = "Please do not close the app or shut down the computer.";
            lbldonotclose.TextAlign = ContentAlignment.MiddleCenter;
            lbldonotclose.Visible = false;
            // 
            // FrmInstallTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 59);
            ClientSize = new Size(1018, 209);
            Controls.Add(lbldonotclose);
            Controls.Add(btndeny);
            Controls.Add(btnaccpetinstall);
            Controls.Add(lblinstalldesc);
            Controls.Add(lblinstallinfo);
            Controls.Add(navbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInstallTools";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PteroController";
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Label lblappname;
        private Label lblminimize;
        private Label lblexit;
        private PictureBox pbappicon;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Label lblinstalldesc;
        private Label lblinstallinfo;
        private Guna.UI2.WinForms.Guna2Button btnaccpetinstall;
        private Guna.UI2.WinForms.Guna2Button btndeny;
        private Label lbldonotclose;
    }
}