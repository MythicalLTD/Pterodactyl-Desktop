using PteroController.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace PteroController
{
    public partial class FrmAlert : Form
    {
        public FrmAlert()
        {
            InitializeComponent();
        }

        private void FrmAlert_Load(object sender, EventArgs e)
        {

        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Succes,
            Warning,
            Error,
            Info
        }
        private FrmAlert.enmAction action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 2000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;

            }

        }

        public void showAlert(string msg, enmType type)
        {
            try
            {
                this.Opacity = 0.0;
                this.StartPosition = FormStartPosition.Manual;
                string fname;
                for (int i = 1; i < 10; i++)
                {
                    fname = "alert" + i.ToString();
                    FrmAlert frm = (FrmAlert)Application.OpenForms[fname];

                    if (frm == null)
                    {

                        this.Name = fname;
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                        this.Location = new Point(this.x, this.y);
                        break;
                    }
                }
                this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


                switch (type)
                {
                    case enmType.Succes:
                        this.icontype.Image = Resources.happycloud;
                        this.BackColor = Color.SeaGreen;
                        break;
                    case enmType.Warning:
                        this.icontype.Image = Resources.warning;
                        this.BackColor = Color.DarkOrange;
                        break;
                    case enmType.Error:
                        this.icontype.Image = Resources.error;
                        this.BackColor = Color.DarkRed;
                        break;
                    case enmType.Info:
                        this.icontype.Image = Resources.info;
                        this.BackColor = Color.RoyalBlue;
                        break;
                }



                this.lblMsg.Text = msg;

                this.Show();
                this.action = enmAction.start;
                this.timer1.Interval = 1;
                timer1.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (Alert) An error occurred: "+ex.Message,DateTime.Now);
            }
        }
    }
}
