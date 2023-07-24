namespace PteroController
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            this.appicon = new System.Windows.Forms.PictureBox();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblappname = new System.Windows.Forms.Label();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appicon
            // 
            this.appicon.Image = ((System.Drawing.Image)(resources.GetObject("appicon.Image")));
            this.appicon.Location = new System.Drawing.Point(271, 12);
            this.appicon.Name = "appicon";
            this.appicon.Size = new System.Drawing.Size(110, 113);
            this.appicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appicon.TabIndex = 9;
            this.appicon.TabStop = false;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblexit.Location = new System.Drawing.Point(624, 12);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(20, 19);
            this.lblexit.TabIndex = 10;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // lblappname
            // 
            this.lblappname.AutoSize = true;
            this.lblappname.BackColor = System.Drawing.Color.Transparent;
            this.lblappname.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.lblappname.Location = new System.Drawing.Point(220, 135);
            this.lblappname.Name = "lblappname";
            this.lblappname.Size = new System.Drawing.Size(217, 32);
            this.lblappname.TabIndex = 12;
            this.lblappname.Text = "PteroController";
            // 
            // drag
            // 
            this.drag.TargetControl = this;
            // 
            // tm
            // 
            this.tm.Interval = 15;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(38, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 25);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 14;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 16;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(656, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblappname);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.appicon);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoading";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PteroController";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appicon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox appicon;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label lblappname;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}