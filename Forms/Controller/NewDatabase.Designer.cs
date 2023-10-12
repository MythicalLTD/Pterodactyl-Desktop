namespace Pterodactyl.Forms.Controller
{
    partial class NewDatabase
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDatabase));
            btnadddb = new Guna.UI2.WinForms.Guna2Button();
            btncancel = new Guna.UI2.WinForms.Guna2Button();
            lblsvinfo = new Label();
            txtpanelname = new Guna.UI2.WinForms.Guna2TextBox();
            lbldbname = new Label();
            lblconfrom = new Label();
            txtconfrom = new Guna.UI2.WinForms.Guna2TextBox();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblclose = new Label();
            lblconwarning = new Label();
            SuspendLayout();
            // 
            // btnadddb
            // 
            btnadddb.BorderColor = Color.Transparent;
            btnadddb.BorderRadius = 10;
            btnadddb.CustomizableEdges = customizableEdges1;
            btnadddb.DisabledState.BorderColor = Color.DarkGray;
            btnadddb.DisabledState.CustomBorderColor = Color.DarkGray;
            btnadddb.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnadddb.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnadddb.FillColor = Color.FromArgb(0, 110, 179);
            btnadddb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnadddb.ForeColor = Color.White;
            btnadddb.Location = new Point(516, 270);
            btnadddb.Name = "btnadddb";
            btnadddb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnadddb.Size = new Size(219, 41);
            btnadddb.TabIndex = 8;
            btnadddb.Text = "Add database";
            btnadddb.Click += btnadddb_Click;
            // 
            // btncancel
            // 
            btncancel.BorderColor = Color.Transparent;
            btncancel.BorderRadius = 10;
            btncancel.CustomizableEdges = customizableEdges3;
            btncancel.DisabledState.BorderColor = Color.DarkGray;
            btncancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btncancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncancel.FillColor = Color.Transparent;
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.ForeColor = Color.White;
            btncancel.Location = new Point(12, 270);
            btncancel.Name = "btncancel";
            btncancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btncancel.Size = new Size(219, 41);
            btncancel.TabIndex = 9;
            btncancel.Text = "Cancel";
            btncancel.Click += btncancel_Click;
            // 
            // lblsvinfo
            // 
            lblsvinfo.AutoSize = true;
            lblsvinfo.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lblsvinfo.ForeColor = Color.WhiteSmoke;
            lblsvinfo.Location = new Point(12, 9);
            lblsvinfo.Name = "lblsvinfo";
            lblsvinfo.Size = new Size(269, 30);
            lblsvinfo.TabIndex = 10;
            lblsvinfo.Text = "Create new database";
            lblsvinfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtpanelname
            // 
            txtpanelname.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtpanelname.BackColor = Color.Transparent;
            txtpanelname.BorderColor = Color.FromArgb(42, 47, 65);
            txtpanelname.BorderRadius = 12;
            txtpanelname.Cursor = Cursors.IBeam;
            txtpanelname.CustomizableEdges = customizableEdges5;
            txtpanelname.DefaultText = "";
            txtpanelname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpanelname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpanelname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpanelname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpanelname.FillColor = Color.FromArgb(42, 47, 65);
            txtpanelname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtpanelname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpanelname.Location = new Point(12, 101);
            txtpanelname.MaxLength = 32;
            txtpanelname.Name = "txtpanelname";
            txtpanelname.PasswordChar = '\0';
            txtpanelname.PlaceholderText = "authme";
            txtpanelname.SelectedText = "";
            txtpanelname.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtpanelname.Size = new Size(723, 45);
            txtpanelname.TabIndex = 11;
            // 
            // lbldbname
            // 
            lbldbname.AutoSize = true;
            lbldbname.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbldbname.ForeColor = Color.WhiteSmoke;
            lbldbname.Location = new Point(12, 82);
            lbldbname.Name = "lbldbname";
            lbldbname.Size = new Size(123, 16);
            lbldbname.TabIndex = 12;
            lbldbname.Text = "DATABASE NAME";
            lbldbname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblconfrom
            // 
            lblconfrom.AutoSize = true;
            lblconfrom.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblconfrom.ForeColor = Color.WhiteSmoke;
            lblconfrom.Location = new Point(12, 161);
            lblconfrom.Name = "lblconfrom";
            lblconfrom.Size = new Size(156, 16);
            lblconfrom.TabIndex = 14;
            lblconfrom.Text = "CONNECTIONS FROM";
            lblconfrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtconfrom
            // 
            txtconfrom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtconfrom.BackColor = Color.Transparent;
            txtconfrom.BorderColor = Color.FromArgb(42, 47, 65);
            txtconfrom.BorderRadius = 12;
            txtconfrom.Cursor = Cursors.IBeam;
            txtconfrom.CustomizableEdges = customizableEdges7;
            txtconfrom.DefaultText = "";
            txtconfrom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtconfrom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtconfrom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtconfrom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtconfrom.FillColor = Color.FromArgb(42, 47, 65);
            txtconfrom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtconfrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtconfrom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtconfrom.Location = new Point(12, 180);
            txtconfrom.MaxLength = 32;
            txtconfrom.Name = "txtconfrom";
            txtconfrom.PasswordChar = '\0';
            txtconfrom.PlaceholderText = "%";
            txtconfrom.SelectedText = "";
            txtconfrom.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtconfrom.Size = new Size(723, 45);
            txtconfrom.TabIndex = 13;
            // 
            // DragControl
            // 
            DragControl.DockIndicatorTransparencyValue = 0.6D;
            DragControl.TargetControl = this;
            DragControl.UseTransparentDrag = true;
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 20;
            Elipse.TargetControl = this;
            // 
            // lblclose
            // 
            lblclose.AutoSize = true;
            lblclose.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblclose.ForeColor = Color.WhiteSmoke;
            lblclose.Location = new Point(715, 9);
            lblclose.Name = "lblclose";
            lblclose.Size = new Size(20, 19);
            lblclose.TabIndex = 15;
            lblclose.Text = "X";
            lblclose.TextAlign = ContentAlignment.MiddleCenter;
            lblclose.Click += lblclose_Click;
            // 
            // lblconwarning
            // 
            lblconwarning.AutoSize = true;
            lblconwarning.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblconwarning.ForeColor = Color.WhiteSmoke;
            lblconwarning.Location = new Point(12, 228);
            lblconwarning.Name = "lblconwarning";
            lblconwarning.Size = new Size(528, 14);
            lblconwarning.TabIndex = 16;
            lblconwarning.Text = "Where connections should be allowed from. Leave blank to allow connections from anywhere.";
            lblconwarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 57);
            ClientSize = new Size(747, 323);
            Controls.Add(lblconwarning);
            Controls.Add(lblclose);
            Controls.Add(lblconfrom);
            Controls.Add(txtconfrom);
            Controls.Add(lbldbname);
            Controls.Add(txtpanelname);
            Controls.Add(lblsvinfo);
            Controls.Add(btncancel);
            Controls.Add(btnadddb);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewDatabase";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pterodactyl";
            Load += NewDatabase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnadddb;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private Label lblsvinfo;
        private Guna.UI2.WinForms.Guna2TextBox txtpanelname;
        private Label lbldbname;
        private Label lblconfrom;
        private Guna.UI2.WinForms.Guna2TextBox txtconfrom;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Label lblclose;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Label lblconwarning;
    }
}