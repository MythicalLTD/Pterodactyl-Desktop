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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
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
            lblexit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
            pbappicon.Image = Properties.Resources.pterry1;
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
            btnsettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnsettings.ForeColor = Color.White;
            btnsettings.Location = new Point(12, 301);
            btnsettings.Name = "btnsettings";
            btnsettings.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnsettings.Size = new Size(262, 40);
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
            btnprofile.FillColor = Color.FromArgb(0, 110, 179);
            btnprofile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnprofile.ForeColor = Color.White;
            btnprofile.Location = new Point(14, 393);
            btnprofile.Name = "btnprofile";
            btnprofile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnprofile.Size = new Size(262, 40);
            btnprofile.TabIndex = 11;
            btnprofile.Text = "Profile";
            btnprofile.Click += btnprofile_Click;
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
            btnsvlist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 28, 46);
            ClientSize = new Size(1095, 695);
            Controls.Add(sidebar);
            Controls.Add(navbar);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
    }
}