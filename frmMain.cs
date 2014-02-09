using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ids.smtpreport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        public void SayHello()
        {
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.BalloonTipText = "Jestem tutaj !" + Environment.NewLine + "Kliknij prawym przyciskiem aby dowiedzieć się więcej.";
            notify.BalloonTipTitle = "Powiadamiacz";
            notify.ShowBalloonTip(3000);
        }

        private void ShowWindow()
        {
            this.Show();
        }

        private void HideWindow()
        {
            this.Hide();
        }




        private void frmMain_Load(object sender, EventArgs e)
        {
            SayHello();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                HideWindow();
                SayHello();
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            HideWindow();
        }
    }
}
