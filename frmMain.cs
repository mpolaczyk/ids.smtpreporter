using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ids.smtpreport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            settingsManager = new SettingsManager();
        }

        ~frmMain()
        {
            if (notify != null)
            {
                notify.Dispose();
            }
        }

        SettingsManager settingsManager;

        PublicIpEntity publicIpEntity;
        GeneralEntity generalEntity;
        SmtpEntity smtpEntity;

        private static void log(Exception ex)
        {
            if (ex != null)
            {
                string error = ex.Message;
                string details = ex.StackTrace;
                if (ex.InnerException != null)
                {
                    error += Environment.NewLine + ex.InnerException.Message;
                }
                MessageBox.Show(error + Environment.NewLine + Environment.NewLine + details, "Powiadamiacz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SmallTick()
        {
            // Check if last date exists
            if (publicIpEntity != null && publicIpEntity.LastReportTime != null)
            {
                // check if general settings exist and ticking is enabled
                if (generalEntity != null && generalEntity.Enabled)
                {
                    // Check if it's time to send reports
                    TimeSpan diff = DateTime.Now - publicIpEntity.LastReportTime;
                    TimeSpan delay = new TimeSpan(0, generalEntity.MinuteDelay, 0);
                    lblTimer.Text = (delay-diff).ToString();
                    if (diff >= delay)
                    {
                        Sync();
                    }
                }
                else
                {
                    lblTimer.Text = "???";
                }
            }
        }

        public void Sync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.SuspendLayout();
                lblPublicIpReportLastDate.Text = "???";
                txtPublicIpReportLastReport.Text = "Proszę czekać...";
                this.ResumeLayout();
                this.Refresh();

                string report;
                PublicIpCheck p = new PublicIpCheck();
                SayWorking(p.Name);
                p.TryGenerateCheck(out report);

                SayWorking("Wysyłanie maila");
                SmtpHelper.SendReport(smtpEntity, generalEntity, p.Name, report);

                if (publicIpEntity == null)
                {
                    publicIpEntity = new PublicIpEntity();
                }
                publicIpEntity.LastReportTime = DateTime.Now;
                publicIpEntity.LastReport = report;

                SavePublicIp();
                RedrawPublicIp();
            }
            catch (Exception ex) { log(ex); }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        public void SayHello()
        {
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.BalloonTipText = "Jestem tutaj !" + Environment.NewLine + "Kliknij prawym przyciskiem aby dowiedzieć się więcej.";
            notify.BalloonTipTitle = "Powiadamiacz";
            notify.ShowBalloonTip(3000);
        }

        public void SayWorking(string description)
        {
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.BalloonTipText = "Pracuję nad: " + description;
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

        private void SendTestMail()
        {
            try
            {
                SayWorking("Wysyłanie maila");
                SmtpHelper.SendTest(smtpEntity, generalEntity);
            }
            catch (Exception ex) { log(ex); }
        }

        private void SaveAll()
        {
            // Save generals ettings
            SaveGeneral();

            // Save smtp settings
            SaveSmtp();

            // Public ip state
            SavePublicIp();

            SmallTick();
        }

        private void SavePublicIp()
        {
            if (publicIpEntity != null)
            {
                try
                {
                    settingsManager.Save(publicIpEntity);
                }
                catch (Exception ex) { log(ex); }
            }
        }

        private void SaveSmtp()
        {
            SmtpEntity smtp = new SmtpEntity()
            {
                Host = string.IsNullOrEmpty(txtSmtpHost.Text) ? "" : txtSmtpHost.Text,
                Port = (int)numSmtpPort.Value,
                User = string.IsNullOrEmpty(txtSmtpUser.Text) ? "" : txtSmtpUser.Text,
                Pass = string.IsNullOrEmpty(txtSmtpPass.Text) ? "" : txtSmtpPass.Text,
                Receiver = string.IsNullOrEmpty(txtSmtpReceiver.Text) ? "" : txtSmtpReceiver.Text
            };
            try
            {
                settingsManager.Save(smtp);
                smtpEntity = smtp;
            }
            catch (Exception ex) { log(ex); }
        }

        private void SaveGeneral()
        {
            GeneralEntity general = new GeneralEntity()
            {
                Enabled = chkEnabled.Enabled,
                InstanceName = string.IsNullOrEmpty(txtInstance.Text) ? "" : txtInstance.Text,
                MinuteDelay = (int)numDelay.Value
            };
            try
            {
                settingsManager.Save(general);
                generalEntity = general;
            }
            catch (Exception ex) { log(ex); }
        }

        private void LoadAll()
        {
            LoadGeneral();

            LoadSmtp();

            LoadPublicIp();
        }

        private void LoadPublicIp()
        {
            try
            {
                PublicIpEntity publicIp = settingsManager.Load<PublicIpEntity>();
                publicIpEntity = publicIp;
                RedrawPublicIp();
            }
            catch (FileNotFoundException ex) { publicIpEntity = null; RedrawPublicIp(); }
            catch (Exception ex) { log(ex); }
        }

        private void LoadSmtp()
        {
            try
            {
                SmtpEntity smtp = settingsManager.Load<SmtpEntity>();
                smtpEntity = smtp;
                RedrawSmtp();
            }
            catch (FileNotFoundException ex) { }
            catch (Exception ex) { log(ex); }
        }

        private void LoadGeneral()
        {
            try
            {
                GeneralEntity general = settingsManager.Load<GeneralEntity>();
                generalEntity = general;
                RedrawGeneral();
            }
            catch (FileNotFoundException ex) { }
            catch (Exception ex) { log(ex); }
        }

        private void RedrawGeneral()
        {
            if (generalEntity != null)
            {
                txtInstance.Text = generalEntity.InstanceName;
                numDelay.Value = generalEntity.MinuteDelay;
                chkEnabled.Checked = generalEntity.Enabled;
            }
        }

        private void RedrawSmtp()
        {
            if (smtpEntity != null)
            {
                txtSmtpHost.Text = smtpEntity.Host;
                numSmtpPort.Value = smtpEntity.Port;
                txtSmtpUser.Text = smtpEntity.User;
                txtSmtpPass.Text = smtpEntity.Pass;
                txtSmtpReceiver.Text = smtpEntity.Receiver;
            }
        }

        private void RedrawPublicIp()
        {
            if (publicIpEntity != null)
            {
                lblPublicIpReportLastDate.Text = publicIpEntity.LastReportTime.ToString();
                txtPublicIpReportLastReport.Text = publicIpEntity.LastReport;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Sync();
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
            LoadAll();
            HideWindow();
        }

        private void cmdSmtpTest_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SendTestMail();
            Cursor.Current = Cursors.Arrow;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveAll();

        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            LoadAll();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            SmallTick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
