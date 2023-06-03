using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PteroController
{
    public partial class FrmFirstRun : Form
    {
        public FrmFirstRun()
        {
            InitializeComponent();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmFirstRun_Load(object sender, EventArgs e)
        {
            
        }
        private void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            if (cbagreeeula.Checked == false) {
                Alert("Please agree with our EULA", FrmAlert.enmType.Warning);
            }
            else
            {
                Alert("Please wait while we install PteroController", FrmAlert.enmType.Succes);
                FrmInstall x = new FrmInstall();
                x.Show();
                this.Hide();
            }
        }
    }
}
