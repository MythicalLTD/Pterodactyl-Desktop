using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pterodactyl.Forms
{
    public partial class FrmSettings : Form
    {
        public bool hasSession;
        public FrmSettings(bool session)
        {
            InitializeComponent();
            this.hasSession = session;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            if (hasSession == true)
            {
                FrmServerSelector x = new FrmServerSelector();
                x.Show();
                this.Hide();
            }
            else
            {
                FrmSessions x = new FrmSessions();
                x.Show();
                this.Hide();
            }
        }

        private void btnsvlist_Click(object sender, EventArgs e)
        {
            FrmServerSelector x = new FrmServerSelector();
            x.Show();
            this.Hide();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            if (hasSession == true)
            {
                btnsvlist.Enabled = true;
                btnprofile.Enabled = true;
            }
            else
            {
                btnsvlist.Enabled = false;
                btnprofile.Enabled = false;
            }
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
