namespace Pterodactyl.Forms
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlert));
            lblMsg = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            icontype = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)icontype).BeginInit();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMsg.Location = new Point(76, 45);
            lblMsg.Margin = new Padding(4, 0, 4, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(139, 22);
            lblMsg.TabIndex = 1;
            lblMsg.Text = "An alert message";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // icontype
            // 
            icontype.Image = Properties.Resources.happycloud;
            icontype.Location = new Point(14, 33);
            icontype.Margin = new Padding(4, 3, 4, 3);
            icontype.Name = "icontype";
            icontype.Size = new Size(55, 50);
            icontype.SizeMode = PictureBoxSizeMode.StretchImage;
            icontype.TabIndex = 0;
            icontype.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // FrmAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(626, 114);
            Controls.Add(lblMsg);
            Controls.Add(icontype);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAlert";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Launcher";
            TopMost = true;
            Load += FrmAlert_Load;
            ((System.ComponentModel.ISupportInitialize)icontype).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMsg;
        private PictureBox icontype;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}