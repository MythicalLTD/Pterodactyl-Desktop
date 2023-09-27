namespace PteroController
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
            button1 = new Button();
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
            navbar.Size = new Size(1016, 28);
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
            // SessionListBox
            // 
            SessionListBox.BackColor = Color.FromArgb(30, 49, 65);
            SessionListBox.BorderStyle = BorderStyle.None;
            SessionListBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SessionListBox.ForeColor = Color.White;
            SessionListBox.FormattingEnabled = true;
            SessionListBox.ItemHeight = 17;
            SessionListBox.Location = new Point(12, 46);
            SessionListBox.Name = "SessionListBox";
            SessionListBox.Size = new Size(992, 357);
            SessionListBox.TabIndex = 4;
            SessionListBox.SelectedIndexChanged += SessionListBox_SelectedIndexChanged;
            SessionListBox.KeyDown += SessionListBox_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(453, 415);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 5;
            button1.Text = "Add session";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmSessions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 59);
            ClientSize = new Size(1016, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}