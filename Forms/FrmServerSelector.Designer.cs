namespace PteroController.Forms
{
    partial class FrmServerSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerSelector));
            lblwlc = new Label();
            serverListBox = new ListBox();
            navbar = new Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            subnavbar = new Panel();
            pblblpanellogo = new PictureBox();
            txtpanelname = new Label();
            btnservers = new PictureBox();
            btnlogout = new PictureBox();
            pbavatar = new PictureBox();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            lblwlcdsc = new Label();
            navbar.SuspendLayout();
            subnavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblblpanellogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnservers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnlogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbavatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbappicon).BeginInit();
            SuspendLayout();
            // 
            // lblwlc
            // 
            lblwlc.AutoSize = true;
            lblwlc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblwlc.ForeColor = Color.White;
            lblwlc.Location = new Point(12, 76);
            lblwlc.Name = "lblwlc";
            lblwlc.Size = new Size(183, 21);
            lblwlc.TabIndex = 0;
            lblwlc.Text = "Hello <dummyname>.";
            lblwlc.Click += lblwlc_Click;
            // 
            // serverListBox
            // 
            serverListBox.BackColor = Color.FromArgb(30, 49, 65);
            serverListBox.BorderStyle = BorderStyle.FixedSingle;
            serverListBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            serverListBox.ForeColor = Color.White;
            serverListBox.FormattingEnabled = true;
            serverListBox.ItemHeight = 17;
            serverListBox.Location = new Point(12, 119);
            serverListBox.Name = "serverListBox";
            serverListBox.Size = new Size(994, 495);
            serverListBox.TabIndex = 1;
            serverListBox.SelectedIndexChanged += serverListBox_SelectedIndexChanged;
            serverListBox.KeyDown += serverListBox_KeyDown;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(29, 37, 49);
            navbar.Controls.Add(guna2Separator1);
            navbar.Controls.Add(subnavbar);
            navbar.Controls.Add(lblappname);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblexit);
            navbar.Controls.Add(pbappicon);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1018, 63);
            navbar.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(-149, 20);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1180, 10);
            guna2Separator1.TabIndex = 8;
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
            subnavbar.Location = new Point(0, 25);
            subnavbar.Name = "subnavbar";
            subnavbar.Size = new Size(1018, 38);
            subnavbar.TabIndex = 7;
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
            btnlogout.Click += btnlogout_Click;
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
            pbavatar.Click += pbavatar_Click;
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
            lblminimize.Location = new Point(981, 1);
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
            lblexit.Location = new Point(997, 3);
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
            // AnimateWindow
            // 
            AnimateWindow.TargetForm = this;
            // 
            // lblwlcdsc
            // 
            lblwlcdsc.AutoSize = true;
            lblwlcdsc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblwlcdsc.ForeColor = Color.White;
            lblwlcdsc.Location = new Point(12, 97);
            lblwlcdsc.Name = "lblwlcdsc";
            lblwlcdsc.Size = new Size(596, 19);
            lblwlcdsc.TabIndex = 5;
            lblwlcdsc.Text = "Welcome to PteroController! Let's start by selecting the server that you want to control.";
            // 
            // FrmServerSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 59);
            ClientSize = new Size(1018, 635);
            Controls.Add(lblwlcdsc);
            Controls.Add(navbar);
            Controls.Add(serverListBox);
            Controls.Add(lblwlc);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServerSelector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PteroController";
            Load += FrmServerSelector_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            subnavbar.ResumeLayout(false);
            subnavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblblpanellogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnservers).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnlogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbavatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwlc;
        private ListBox serverListBox;
        private Panel navbar;
        private Label lblappname;
        private Label lblminimize;
        private Label lblexit;
        private PictureBox pbappicon;
        private Guna.UI2.WinForms.Guna2DragControl DragController;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Label lblwlcdsc;
        private Panel subnavbar;
        private PictureBox pblblpanellogo;
        private Label txtpanelname;
        private PictureBox btnservers;
        private PictureBox btnlogout;
        private PictureBox pbavatar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}