namespace PteroController
{
    partial class FrmFirstRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstRun));
            this.navbar = new System.Windows.Forms.Panel();
            this.lblappname = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtagree = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbagreeeula = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnsend = new Guna.UI2.WinForms.Guna2Button();
            this.appicon = new System.Windows.Forms.PictureBox();
            this.navbar.SuspendLayout();
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
            this.navbar.Size = new System.Drawing.Size(618, 27);
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
            this.lblmin.Location = new System.Drawing.Point(564, 5);
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
            this.lblexit.Location = new System.Drawing.Point(587, 5);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(153, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome to PteroController";
            // 
            // txtagree
            // 
            this.txtagree.Location = new System.Drawing.Point(36, 106);
            this.txtagree.Name = "txtagree";
            this.txtagree.ReadOnly = true;
            this.txtagree.ShortcutsEnabled = false;
            this.txtagree.Size = new System.Drawing.Size(547, 249);
            this.txtagree.TabIndex = 12;
            this.txtagree.Text = resources.GetString("txtagree.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "To install this application you will have to agree with the MythicalSystems EULA." +
    "\r\n";
            // 
            // cbagreeeula
            // 
            this.cbagreeeula.AutoSize = true;
            this.cbagreeeula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbagreeeula.CheckedState.BorderRadius = 2;
            this.cbagreeeula.CheckedState.BorderThickness = 0;
            this.cbagreeeula.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbagreeeula.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbagreeeula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.cbagreeeula.Location = new System.Drawing.Point(36, 372);
            this.cbagreeeula.Name = "cbagreeeula";
            this.cbagreeeula.Size = new System.Drawing.Size(309, 18);
            this.cbagreeeula.TabIndex = 14;
            this.cbagreeeula.Text = "I agree with MythicalSystems terms and conditions";
            this.cbagreeeula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbagreeeula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbagreeeula.UncheckedState.BorderRadius = 2;
            this.cbagreeeula.UncheckedState.BorderThickness = 0;
            this.cbagreeeula.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbagreeeula.UseVisualStyleBackColor = true;
            // 
            // btnsend
            // 
            this.btnsend.Animated = true;
            this.btnsend.BackColor = System.Drawing.Color.Transparent;
            this.btnsend.BorderColor = System.Drawing.Color.Transparent;
            this.btnsend.BorderRadius = 10;
            this.btnsend.CheckedState.Parent = this.btnsend;
            this.btnsend.CustomImages.Parent = this.btnsend;
            this.btnsend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.btnsend.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.HoverState.Parent = this.btnsend;
            this.btnsend.Location = new System.Drawing.Point(458, 393);
            this.btnsend.Name = "btnsend";
            this.btnsend.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(240)))));
            this.btnsend.ShadowDecoration.Parent = this.btnsend;
            this.btnsend.Size = new System.Drawing.Size(125, 31);
            this.btnsend.TabIndex = 24;
            this.btnsend.Text = "Next";
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
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
            // FrmFirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.cbagreeeula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtagree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFirstRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PteroController";
            this.Load += new System.EventHandler(this.FrmFirstRun_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label lblappname;
        private System.Windows.Forms.PictureBox appicon;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblexit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.RichTextBox txtagree;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox cbagreeeula;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnsend;
    }
}