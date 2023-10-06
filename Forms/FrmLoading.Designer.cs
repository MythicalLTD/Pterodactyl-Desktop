namespace Pterodactyl.Forms
{
    partial class FrmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            appicon = new PictureBox();
            lblexit = new Label();
            lblappname = new Label();
            drag = new Guna.UI2.WinForms.Guna2DragControl(components);
            tm = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            LoaderElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)appicon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // appicon
            // 
            appicon.Image = (Image)resources.GetObject("appicon.Image");
            appicon.Location = new Point(316, 14);
            appicon.Margin = new Padding(4, 3, 4, 3);
            appicon.Name = "appicon";
            appicon.Size = new Size(128, 130);
            appicon.SizeMode = PictureBoxSizeMode.StretchImage;
            appicon.TabIndex = 9;
            appicon.TabStop = false;
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.BackColor = Color.Transparent;
            lblexit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblexit.ForeColor = Color.FromArgb(236, 240, 243);
            lblexit.Location = new Point(728, 14);
            lblexit.Margin = new Padding(4, 0, 4, 0);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(20, 19);
            lblexit.TabIndex = 10;
            lblexit.Text = "X";
            lblexit.Click += lblexit_Click;
            // 
            // lblappname
            // 
            lblappname.BackColor = Color.Transparent;
            lblappname.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblappname.ForeColor = Color.FromArgb(236, 240, 243);
            lblappname.Location = new Point(107, 158);
            lblappname.Margin = new Padding(4, 0, 4, 0);
            lblappname.Name = "lblappname";
            lblappname.Size = new Size(558, 32);
            lblappname.TabIndex = 12;
            lblappname.Text = "Pterodactyl Desktop";
            lblappname.TextAlign = ContentAlignment.MiddleCenter;
            lblappname.Click += lblappname_Click;
            // 
            // drag
            // 
            drag.DockIndicatorTransparencyValue = 0.6D;
            drag.TargetControl = this;
            drag.UseTransparentDrag = true;
            // 
            // tm
            // 
            tm.Interval = 15;
            tm.Tick += tm_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(44, 253);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 29);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 110, 179);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 29);
            panel2.TabIndex = 14;
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 20;
            Elipse.TargetControl = this;
            // 
            // LoaderElipse
            // 
            LoaderElipse.BorderRadius = 20;
            LoaderElipse.TargetControl = panel1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(236, 240, 243);
            label1.Location = new Point(83, 302);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(640, 20);
            label1.TabIndex = 14;
            label1.Text = "We not affiliated with pterodactyl this is not an official product released by pterodactyl";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 28, 46);
            ClientSize = new Size(765, 331);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblappname);
            Controls.Add(lblexit);
            Controls.Add(appicon);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLoading";
            Opacity = 0.9D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pterodactyl";
            Load += FrmLoading_Load;
            ((System.ComponentModel.ISupportInitialize)appicon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox appicon;
        private Label lblexit;
        private Label lblappname;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private System.Windows.Forms.Timer tm;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2Elipse LoaderElipse;
        private Label label1;
    }
}