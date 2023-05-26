namespace PteroControler
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
            this.separator = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnshutdown
            // 
            resources.ApplyResources(this.btnshutdown, "btnshutdown");
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // btnstart
            // 
            resources.ApplyResources(this.btnstart, "btnstart");
            this.btnstart.Name = "btnstart";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnrestart
            // 
            resources.ApplyResources(this.btnrestart, "btnrestart");
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnkill
            // 
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
            // separator
            // 
            resources.ApplyResources(this.separator, "separator");
            this.separator.Name = "separator";
            // 
            // consoleTextBox
            // 
            resources.ApplyResources(this.consoleTextBox, "consoleTextBox");
            this.consoleTextBox.Name = "consoleTextBox";
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
            // FrmServerControler
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.svnode);
            this.Controls.Add(this.svdescription);
            this.Controls.Add(this.svname);
            this.Controls.Add(this.btnsendcmd);
            this.Controls.Add(this.btnkill);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnshutdown);
            this.Name = "FrmServerControler";
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

