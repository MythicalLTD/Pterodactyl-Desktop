namespace PteroController
{
    partial class FrmAlert
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.icontype = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icontype)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.lblMsg.Location = new System.Drawing.Point(65, 37);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(175, 26);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "An alert message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // icontype
            // 
            this.icontype.Image = global::PteroController.Properties.Resources.happycloud;
            this.icontype.Location = new System.Drawing.Point(12, 29);
            this.icontype.Name = "icontype";
            this.icontype.Size = new System.Drawing.Size(47, 43);
            this.icontype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icontype.TabIndex = 0;
            this.icontype.TabStop = false;
            // 
            // FrmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(537, 99);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.icontype);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icontype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox icontype;
        private System.Windows.Forms.Timer timer1;
    }
}