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
    public partial class FrmServerSelector : Form
    {
        public FrmServerSelector()
        {
            InitializeComponent();
        }

        private void FrmServerSelector_Load(object sender, EventArgs e)
        {
            label1.Text = FrmLogin.panel_admin + FrmLogin.panel_api_key + FrmLogin.panel_id + FrmLogin.panel_first_name;
        }
    }
}
