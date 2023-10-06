using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pterodactyl.Forms.Controller
{
    public partial class NewDatabase : Form
    {
        public NewDatabase()
        {
            InitializeComponent();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadddb_Click(object sender, EventArgs e)
        {
            if (txtpanelname.Text == "" && txtconfrom.Text == "")
            {

            }
        }
    }
}
