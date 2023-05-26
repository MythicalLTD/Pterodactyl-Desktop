namespace PteroController
{
    partial class FrmServerControler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerControler));
            this.btnshutdown = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnkill = new System.Windows.Forms.Button();
            this.btnsendcmd = new System.Windows.Forms.Button();
            this.svname = new System.Windows.Forms.Label();
            this.svdescription = new System.Windows.Forms.Label();
            this.svnode = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.navbar = new System.Windows.Forms.Panel();
            this.lblappname = new System.Windows.Forms.Label();
            this.appicon = new System.Windows.Forms.PictureBox();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.sidenav = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).BeginInit();
            this.sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshutdown
            // 
            this.btnshutdown.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnshutdown, "btnshutdown");
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // btnstart
            // 
            this.btnstart.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnstart, "btnstart");
            this.btnstart.Name = "btnstart";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnrestart, "btnrestart");
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnkill
            // 
            this.btnkill.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnkill, "btnkill");
            this.btnkill.Name = "btnkill";
            this.btnkill.UseVisualStyleBackColor = true;
            this.btnkill.Click += new System.EventHandler(this.btnkill_Click);
            // 
            // btnsendcmd
            // 
            resources.ApplyResources(this.btnsendcmd, "btnsendcmd");
            this.btnsendcmd.Name = "btnsendcmd";
            this.btnsendcmd.UseVisualStyleBackColor = true;
            this.btnsendcmd.Click += new System.EventHandler(this.btnopenconsole_Click);
            // 
            // svname
            // 
            resources.ApplyResources(this.svname, "svname");
            this.svname.Name = "svname";
            // 
            // svdescription
            // 
            resources.ApplyResources(this.svdescription, "svdescription");
            this.svdescription.Name = "svdescription";
            // 
            // svnode
            // 
            resources.ApplyResources(this.svnode, "svnode");
            this.svnode.Name = "svnode";
            // 
            // commandTextBox
            // 
            resources.ApplyResources(this.commandTextBox, "commandTextBox");
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandTextBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 840000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.navbar.Controls.Add(this.lblappname);
            this.navbar.Controls.Add(this.appicon);
            this.navbar.Controls.Add(this.lblmin);
            this.navbar.Controls.Add(this.lblexit);
            resources.ApplyResources(this.navbar, "navbar");
            this.navbar.Name = "navbar";
            // 
            // lblappname
            // 
            resources.ApplyResources(this.lblappname, "lblappname");
            this.lblappname.BackColor = System.Drawing.Color.Transparent;
            this.lblappname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblappname.Name = "lblappname";
            // 
            // appicon
            // 
            this.appicon.Image = global::PteroController.Properties.Resources.pterry;
            resources.ApplyResources(this.appicon, "appicon");
            this.appicon.Name = "appicon";
            this.appicon.TabStop = false;
            // 
            // lblmin
            // 
            resources.ApplyResources(this.lblmin, "lblmin");
            this.lblmin.BackColor = System.Drawing.Color.Transparent;
            this.lblmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblmin.Name = "lblmin";
            this.lblmin.Click += new System.EventHandler(this.lblmin_Click);
            // 
            // lblexit
            // 
            resources.ApplyResources(this.lblexit, "lblexit");
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblexit.Name = "lblexit";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // sidenav
            // 
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.sidenav.Controls.Add(this.guna2Separator2);
            this.sidenav.Controls.Add(this.guna2Button1);
            this.sidenav.Controls.Add(this.btnlogin);
            this.sidenav.Controls.Add(this.pictureBox4);
            this.sidenav.Controls.Add(this.pictureBox3);
            this.sidenav.Controls.Add(this.pictureBox2);
            this.sidenav.Controls.Add(this.guna2Separator1);
            this.sidenav.Controls.Add(this.label2);
            this.sidenav.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.sidenav, "sidenav");
            this.sidenav.Name = "sidenav";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-75, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnlogin.BorderRadius = 10;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            resources.ApplyResources(this.btnlogin, "btnlogin");
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageOffset = new System.Drawing.Point(-75, 0);
            this.btnlogin.ImageSize = new System.Drawing.Size(28, 28);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.TextOffset = new System.Drawing.Point(30, 0);
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PteroController.Properties.Resources.pterry;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // guna2Separator2
            // 
            resources.ApplyResources(this.guna2Separator2, "guna2Separator2");
            this.guna2Separator2.Name = "guna2Separator2";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            resources.ApplyResources(this.consoleTextBox, "consoleTextBox");
            this.consoleTextBox.Name = "consoleTextBox";
            // 
            // FrmServerControler
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.sidenav);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.svnode);
            this.Controls.Add(this.svdescription);
            this.Controls.Add(this.svname);
            this.Controls.Add(this.btnsendcmd);
            this.Controls.Add(this.btnkill);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnshutdown);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServerControler";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).EndInit();
            this.sidenav.ResumeLayout(false);
            this.sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshutdown;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnkill;
        private System.Windows.Forms.Button btnsendcmd;
        private System.Windows.Forms.Label svname;
        private System.Windows.Forms.Label svdescription;
        private System.Windows.Forms.Label svnode;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label lblappname;
        private System.Windows.Forms.PictureBox appicon;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Panel sidenav;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox consoleTextBox;
    }
}

