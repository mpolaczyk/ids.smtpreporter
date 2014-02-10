namespace ids.smtpreport
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pokażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPublicIpReportLastDate = new System.Windows.Forms.Label();
            this.txtPublicIpReportLastReport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPublicIpReportTest = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSmtpTest = new System.Windows.Forms.Button();
            this.txtSmtpPass = new System.Windows.Forms.MaskedTextBox();
            this.numSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.txtSmtpReceiver = new System.Windows.Forms.TextBox();
            this.txtSmtpUser = new System.Windows.Forms.TextBox();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTipHello = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.context.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSmtpPort)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.BalloonTipTitle = "Powiadamiacz";
            this.notify.ContextMenuStrip = this.context;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(118, 48);
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Image = global::ids.smtpreport.Properties.Resources._16;
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pokażToolStripMenuItem.Text = "Pokaż";
            this.pokażToolStripMenuItem.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Image = global::ids.smtpreport.Properties.Resources._011;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Controls.Add(this.tabPage3);
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.HotTrack = true;
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(571, 519);
            this.tabContainer.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPublicIpReportLastDate);
            this.tabPage1.Controls.Add(this.txtPublicIpReportLastReport);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmdPublicIpReportTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(563, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Publiczny adres IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPublicIpReportLastDate
            // 
            this.lblPublicIpReportLastDate.AutoSize = true;
            this.lblPublicIpReportLastDate.Location = new System.Drawing.Point(222, 14);
            this.lblPublicIpReportLastDate.Name = "lblPublicIpReportLastDate";
            this.lblPublicIpReportLastDate.Size = new System.Drawing.Size(29, 18);
            this.lblPublicIpReportLastDate.TabIndex = 5;
            this.lblPublicIpReportLastDate.Text = "???";
            // 
            // txtPublicIpReportLastReport
            // 
            this.txtPublicIpReportLastReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublicIpReportLastReport.Location = new System.Drawing.Point(111, 42);
            this.txtPublicIpReportLastReport.Multiline = true;
            this.txtPublicIpReportLastReport.Name = "txtPublicIpReportLastReport";
            this.txtPublicIpReportLastReport.ReadOnly = true;
            this.txtPublicIpReportLastReport.Size = new System.Drawing.Size(445, 366);
            this.txtPublicIpReportLastReport.TabIndex = 4;
            this.txtPublicIpReportLastReport.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ostatnie dane:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data ostatniego powiadomienia:";
            // 
            // cmdPublicIpReportTest
            // 
            this.cmdPublicIpReportTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPublicIpReportTest.Image = global::ids.smtpreport.Properties.Resources._47;
            this.cmdPublicIpReportTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPublicIpReportTest.Location = new System.Drawing.Point(288, 414);
            this.cmdPublicIpReportTest.Name = "cmdPublicIpReportTest";
            this.cmdPublicIpReportTest.Size = new System.Drawing.Size(268, 34);
            this.cmdPublicIpReportTest.TabIndex = 1;
            this.cmdPublicIpReportTest.Text = "Sprawdź adres i wyślij powiadomienie";
            this.cmdPublicIpReportTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdPublicIpReportTest.UseVisualStyleBackColor = true;
            this.cmdPublicIpReportTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdRead);
            this.tabPage2.Controls.Add(this.cmdSave);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(563, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ustawienia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdRead
            // 
            this.cmdRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRead.Image = global::ids.smtpreport.Properties.Resources._27;
            this.cmdRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRead.Location = new System.Drawing.Point(396, 441);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(85, 39);
            this.cmdRead.TabIndex = 10;
            this.cmdRead.Text = "Odczytaj";
            this.cmdRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Image = global::ids.smtpreport.Properties.Resources._47;
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(487, 441);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(69, 39);
            this.cmdSave.TabIndex = 11;
            this.cmdSave.Text = "Zapisz";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblTimer);
            this.groupBox2.Controls.Add(this.txtInstance);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chkEnabled);
            this.groupBox2.Controls.Add(this.numDelay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 170);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ogólne";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Czas do następnego powiadomienia:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(247, 136);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(29, 18);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "???";
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(217, 31);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(180, 26);
            this.txtInstance.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nazwa instancji:";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Location = new System.Drawing.Point(20, 98);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(123, 22);
            this.chkEnabled.TabIndex = 2;
            this.chkEnabled.Text = "Powiadamianie";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(217, 63);
            this.numDelay.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(120, 26);
            this.numDelay.TabIndex = 3;
            this.numDelay.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Co ile minut powiadamiać ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdSmtpTest);
            this.groupBox1.Controls.Add(this.txtSmtpPass);
            this.groupBox1.Controls.Add(this.numSmtpPort);
            this.groupBox1.Controls.Add(this.txtSmtpReceiver);
            this.groupBox1.Controls.Add(this.txtSmtpUser);
            this.groupBox1.Controls.Add(this.txtSmtpHost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP (SSL)";
            // 
            // cmdSmtpTest
            // 
            this.cmdSmtpTest.Location = new System.Drawing.Point(157, 188);
            this.cmdSmtpTest.Name = "cmdSmtpTest";
            this.cmdSmtpTest.Size = new System.Drawing.Size(212, 34);
            this.cmdSmtpTest.TabIndex = 9;
            this.cmdSmtpTest.Text = "Wyślij wiadomość testową";
            this.cmdSmtpTest.UseVisualStyleBackColor = true;
            this.cmdSmtpTest.Click += new System.EventHandler(this.cmdSmtpTest_Click);
            // 
            // txtSmtpPass
            // 
            this.txtSmtpPass.Location = new System.Drawing.Point(157, 120);
            this.txtSmtpPass.Name = "txtSmtpPass";
            this.txtSmtpPass.PasswordChar = '*';
            this.txtSmtpPass.Size = new System.Drawing.Size(212, 26);
            this.txtSmtpPass.TabIndex = 7;
            // 
            // numSmtpPort
            // 
            this.numSmtpPort.Location = new System.Drawing.Point(157, 56);
            this.numSmtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSmtpPort.Name = "numSmtpPort";
            this.numSmtpPort.Size = new System.Drawing.Size(120, 26);
            this.numSmtpPort.TabIndex = 5;
            // 
            // txtSmtpReceiver
            // 
            this.txtSmtpReceiver.Location = new System.Drawing.Point(157, 152);
            this.txtSmtpReceiver.Name = "txtSmtpReceiver";
            this.txtSmtpReceiver.Size = new System.Drawing.Size(212, 26);
            this.txtSmtpReceiver.TabIndex = 8;
            // 
            // txtSmtpUser
            // 
            this.txtSmtpUser.Location = new System.Drawing.Point(157, 88);
            this.txtSmtpUser.Name = "txtSmtpUser";
            this.txtSmtpUser.Size = new System.Drawing.Size(212, 26);
            this.txtSmtpUser.TabIndex = 6;
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.Location = new System.Drawing.Point(157, 24);
            this.txtSmtpHost.Name = "txtSmtpHost";
            this.txtSmtpHost.Size = new System.Drawing.Size(212, 26);
            this.txtSmtpHost.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Odbiorca raportów:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hasło:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serwer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Użytkownik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(563, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informacje";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wersja 1.1 z dnia 10.02.2014r";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 456);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Licencja";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(538, 413);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // toolTipHello
            // 
            this.toolTipHello.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHello.ToolTipTitle = "Jestem tutaj!";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 519);
            this.Controls.Add(this.tabContainer);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Powiadamiacz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.context.ResumeLayout(false);
            this.tabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSmtpPort)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem pokażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTipHello;
        private System.Windows.Forms.Button cmdPublicIpReportTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublicIpReportLastReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPublicIpReportLastDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtSmtpPass;
        private System.Windows.Forms.NumericUpDown numSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpReceiver;
        private System.Windows.Forms.TextBox txtSmtpUser;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.Button cmdSmtpTest;
        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;

    }
}

