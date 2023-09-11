namespace PteroController
{
    partial class FrmServerSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServerSelector));
            lblwlc = new Label();
            serverListBox = new ListBox();
            SuspendLayout();
            // 
            // lblwlc
            // 
            lblwlc.AutoSize = true;
            lblwlc.Location = new Point(12, 9);
            lblwlc.Name = "lblwlc";
            lblwlc.Size = new Size(129, 15);
            lblwlc.TabIndex = 0;
            lblwlc.Text = "Hello <dummyname>.";
            // 
            // serverListBox
            // 
            serverListBox.FormattingEnabled = true;
            serverListBox.ItemHeight = 15;
            serverListBox.Location = new Point(12, 27);
            serverListBox.Name = "serverListBox";
            serverListBox.Size = new Size(776, 409);
            serverListBox.TabIndex = 1;
            serverListBox.SelectedIndexChanged += serverListBox_SelectedIndexChanged;
            serverListBox.KeyDown += serverListBox_KeyDown;
            // 
            // FrmServerSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(serverListBox);
            Controls.Add(lblwlc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServerSelector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmServerSelector";
            Load += FrmServerSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwlc;
        private ListBox serverListBox;
    }
}