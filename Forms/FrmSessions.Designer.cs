namespace PteroController.Forms
{
    partial class FrmSessions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSessions));
            navbar = new Panel();
            lblappname = new Label();
            lblminimize = new Label();
            lblexit = new Label();
            pbappicon = new PictureBox();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            DragController = new Guna.UI2.WinForms.Guna2DragControl(components);
            AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            SessionListBox = new ListBox();
            lblwlc = new Label();
            btnaddsession = new Guna.UI2.WinForms.Guna2Button();
            btnsession = new Guna.UI2.WinForms.Guna2Button();
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
            navbar.Size = new Size(671, 28);
            navbar.TabIndex = 3;
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
            lblminimize.Location = new Point(624, 1);
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
            lblexit.Location = new Point(640, 3);
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
            // SessionListBox
            // 
            SessionListBox.BackColor = Color.FromArgb(30, 49, 65);
            SessionListBox.BorderStyle = BorderStyle.FixedSingle;
            SessionListBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SessionListBox.ForeColor = Color.White;
            SessionListBox.FormattingEnabled = true;
            SessionListBox.ItemHeight = 17;
            SessionListBox.Location = new Point(29, 84);
            SessionListBox.Name = "SessionListBox";
            SessionListBox.Size = new Size(620, 257);
            SessionListBox.TabIndex = 4;
            SessionListBox.SelectedIndexChanged += SessionListBox_SelectedIndexChanged;
            SessionListBox.KeyDown += SessionListBox_KeyDown;
            // 
            // lblwlc
            // 
            lblwlc.AutoSize = true;
            lblwlc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblwlc.ForeColor = Color.WhiteSmoke;
            lblwlc.Location = new Point(41, 49);
            lblwlc.Name = "lblwlc";
            lblwlc.Size = new Size(588, 21);
            lblwlc.TabIndex = 5;
            lblwlc.Text = "Welcome to PteroController! Please select your panel to start using our app!";
            // 
            // btnaddsession
            // 
            btnaddsession.BorderColor = Color.Transparent;
            btnaddsession.BorderRadius = 12;
            btnaddsession.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnaddsession.BorderThickness = 2;
            btnaddsession.CustomizableEdges = customizableEdges3;
            btnaddsession.DisabledState.BorderColor = Color.DarkGray;
            btnaddsession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnaddsession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnaddsession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnaddsession.FillColor = Color.FromArgb(59, 130, 246);
            btnaddsession.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddsession.ForeColor = Color.White;
            btnaddsession.Location = new Point(41, 359);
            btnaddsession.Name = "btnaddsession";
            btnaddsession.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnaddsession.Size = new Size(160, 30);
            btnaddsession.TabIndex = 8;
            btnaddsession.Text = "Add a new session";
            btnaddsession.Click += btnaddsession_Click;
            // 
            // btnsession
            // 
            btnsession.BorderColor = Color.Transparent;
            btnsession.BorderRadius = 12;
            btnsession.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnsession.BorderThickness = 2;
            btnsession.CustomizableEdges = customizableEdges1;
            btnsession.DisabledState.BorderColor = Color.DarkGray;
            btnsession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsession.FillColor = Color.FromArgb(59, 130, 246);
            btnsession.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnsession.ForeColor = Color.White;
            btnsession.Location = new Point(479, 359);
            btnsession.Name = "btnsession";
            btnsession.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnsession.Size = new Size(160, 30);
            btnsession.TabIndex = 9;
            btnsession.Text = "Direct Session";
            btnsession.Click += btnsession_Click;
            // 
            // FrmSessions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 59);
            ClientSize = new Size(671, 410);
            Controls.Add(btnsession);
            Controls.Add(btnaddsession);
            Controls.Add(lblwlc);
            Controls.Add(SessionListBox);
            Controls.Add(navbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSessions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PteroController";
            Load += FrmSessions_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbappicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ListBox SessionListBox;
        private Label lblwlc;
        private Guna.UI2.WinForms.Guna2Button btnsession;
        private Guna.UI2.WinForms.Guna2Button btnaddsession;
    }
}