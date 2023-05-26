namespace PteroController
{
    partial class FrmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfile));
            this.navbar = new System.Windows.Forms.Panel();
            this.lblappname = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.sidenav = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lbllang = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appicon = new System.Windows.Forms.PictureBox();
            this.btnsettings = new Guna.UI2.WinForms.Guna2Button();
            this.navbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.navbar.Controls.Add(this.lblappname);
            this.navbar.Controls.Add(this.appicon);
            this.navbar.Controls.Add(this.lblmin);
            this.navbar.Controls.Add(this.lblexit);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(942, 27);
            this.navbar.TabIndex = 9;
            // 
            // lblappname
            // 
            this.lblappname.AutoSize = true;
            this.lblappname.BackColor = System.Drawing.Color.Transparent;
            this.lblappname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblappname.Location = new System.Drawing.Point(29, 7);
            this.lblappname.Name = "lblappname";
            this.lblappname.Size = new System.Drawing.Size(116, 16);
            this.lblappname.TabIndex = 9;
            this.lblappname.Text = "PteroController";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.BackColor = System.Drawing.Color.Transparent;
            this.lblmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblmin.Location = new System.Drawing.Point(887, 5);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(19, 19);
            this.lblmin.TabIndex = 8;
            this.lblmin.Text = "--";
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblexit.Location = new System.Drawing.Point(910, 5);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(20, 19);
            this.lblexit.TabIndex = 7;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.navbar;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lbllang);
            this.panel1.Controls.Add(this.lbladmin);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Controls.Add(this.lblfirstname);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(226, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 476);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "PteroController";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(8, 467);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(191, 10);
            this.guna2Separator1.TabIndex = 11;
            // 
            // sidenav
            // 
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.sidenav.Controls.Add(this.btnsettings);
            this.sidenav.Controls.Add(this.guna2Button1);
            this.sidenav.Controls.Add(this.btnlogin);
            this.sidenav.Controls.Add(this.pictureBox4);
            this.sidenav.Controls.Add(this.pictureBox3);
            this.sidenav.Controls.Add(this.pictureBox2);
            this.sidenav.Controls.Add(this.guna2Separator1);
            this.sidenav.Controls.Add(this.label2);
            this.sidenav.Controls.Add(this.pictureBox1);
            this.sidenav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidenav.Location = new System.Drawing.Point(0, 27);
            this.sidenav.Name = "sidenav";
            this.sidenav.Size = new System.Drawing.Size(206, 519);
            this.sidenav.TabIndex = 10;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblusername.Location = new System.Drawing.Point(18, 281);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(111, 22);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "Username:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblemail.Location = new System.Drawing.Point(18, 303);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(68, 22);
            this.lblemail.TabIndex = 18;
            this.lblemail.Text = "Email:";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.BackColor = System.Drawing.Color.Transparent;
            this.lbllastname.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lbllastname.Location = new System.Drawing.Point(18, 259);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(114, 22);
            this.lbllastname.TabIndex = 20;
            this.lbllastname.Text = "Last Name:";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstname.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblfirstname.Location = new System.Drawing.Point(18, 237);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(116, 22);
            this.lblfirstname.TabIndex = 19;
            this.lblfirstname.Text = "First Name:";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.BackColor = System.Drawing.Color.Transparent;
            this.lbladmin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lbladmin.Location = new System.Drawing.Point(18, 325);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(76, 22);
            this.lbladmin.TabIndex = 21;
            this.lbladmin.Text = "Admin:";
            // 
            // lbllang
            // 
            this.lbllang.AutoSize = true;
            this.lbllang.BackColor = System.Drawing.Color.Transparent;
            this.lbllang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lbllang.Location = new System.Drawing.Point(18, 347);
            this.lbllang.Name = "lbllang";
            this.lbllang.Size = new System.Drawing.Size(110, 22);
            this.lbllang.TabIndex = 22;
            this.lbllang.Text = "Language:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(690, 234);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
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
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-75, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2Button1.Location = new System.Drawing.Point(12, 230);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(187, 45);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Servers";
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
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnlogin.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnlogin.ImageSize = new System.Drawing.Size(28, 28);
            this.btnlogin.Location = new System.Drawing.Point(12, 179);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(187, 45);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "Account";
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(89, 480);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 480);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 480);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PteroController.Properties.Resources.pterry;
            this.pictureBox1.Location = new System.Drawing.Point(49, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // appicon
            // 
            this.appicon.Image = global::PteroController.Properties.Resources.pterry;
            this.appicon.Location = new System.Drawing.Point(3, 4);
            this.appicon.Name = "appicon";
            this.appicon.Size = new System.Drawing.Size(20, 20);
            this.appicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appicon.TabIndex = 8;
            this.appicon.TabStop = false;
            // 
            // btnsettings
            // 
            this.btnsettings.Animated = true;
            this.btnsettings.BackColor = System.Drawing.Color.Transparent;
            this.btnsettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnsettings.BorderRadius = 10;
            this.btnsettings.CheckedState.Parent = this.btnsettings;
            this.btnsettings.CustomImages.Parent = this.btnsettings;
            this.btnsettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.btnsettings.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.HoverState.Parent = this.btnsettings;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnsettings.ImageSize = new System.Drawing.Size(28, 28);
            this.btnsettings.Location = new System.Drawing.Point(12, 277);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnsettings.ShadowDecoration.Parent = this.btnsettings;
            this.btnsettings.Size = new System.Drawing.Size(187, 45);
            this.btnsettings.TabIndex = 18;
            this.btnsettings.Text = "Settings";
            this.btnsettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsettings.TextOffset = new System.Drawing.Point(30, 0);
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(942, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidenav);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pterodactyl";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidenav.ResumeLayout(false);
            this.sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label lblappname;
        private System.Windows.Forms.PictureBox appicon;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Panel sidenav;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Label lbllang;
        private Guna.UI2.WinForms.Guna2Button btnsettings;
    }
}