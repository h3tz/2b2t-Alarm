namespace _2B2TWinAlarm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelToolState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Log = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.clearDebug = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenMLog = new System.Windows.Forms.ToolStripButton();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonQuality = new System.Windows.Forms.Button();
            this.labelDateToConnect = new System.Windows.Forms.Label();
            this.labelTimeToConnect = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrometheus = new System.Windows.Forms.CheckBox();
            this.buttonPlayAlarm = new System.Windows.Forms.Button();
            this.Alarm = new System.Windows.Forms.Label();
            this.comboBox_alarm = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Log.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 340);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelToolState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1444, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 25);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 25);
            this.toolStripStatusLabel2.Text = "   State:";
            // 
            // toolStripStatusLabelToolState
            // 
            this.toolStripStatusLabelToolState.Name = "toolStripStatusLabelToolState";
            this.toolStripStatusLabelToolState.Size = new System.Drawing.Size(19, 25);
            this.toolStripStatusLabelToolState.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Log);
            this.tabControl1.Location = new System.Drawing.Point(0, 989);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 220);
            this.tabControl1.TabIndex = 3;
            // 
            // Log
            // 
            this.Log.Controls.Add(this.toolStrip2);
            this.Log.Controls.Add(this.richTextBox_log);
            this.Log.Location = new System.Drawing.Point(4, 29);
            this.Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log.Size = new System.Drawing.Size(1424, 187);
            this.Log.TabIndex = 0;
            this.Log.Text = "DebugLog";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDebug,
            this.toolStripButtonOpenMLog});
            this.toolStrip2.Location = new System.Drawing.Point(3, 2);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1418, 31);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // clearDebug
            // 
            this.clearDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearDebug.Image = global::_2B2TQueAlarm.Properties.Resources.textfield_delete;
            this.clearDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearDebug.Name = "clearDebug";
            this.clearDebug.Size = new System.Drawing.Size(28, 28);
            this.clearDebug.ToolTipText = "Clear Debug Log window";
            this.clearDebug.Click += new System.EventHandler(this.clearDebug_Click);
            // 
            // toolStripButtonOpenMLog
            // 
            this.toolStripButtonOpenMLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenMLog.Image = global::_2B2TQueAlarm.Properties.Resources.application_go;
            this.toolStripButtonOpenMLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenMLog.Name = "toolStripButtonOpenMLog";
            this.toolStripButtonOpenMLog.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonOpenMLog.ToolTipText = "Open minecraft .minecraft\\logs\\latest.log";
            this.toolStripButtonOpenMLog.Click += new System.EventHandler(this.toolStripButtonOpenMLog_Click);
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_log.Location = new System.Drawing.Point(3, 44);
            this.richTextBox_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(1403, 129);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(26, 102);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(254, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Start alarm noise reaching pos:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Options);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 924);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonQuality);
            this.groupBox2.Controls.Add(this.labelDateToConnect);
            this.groupBox2.Controls.Add(this.labelTimeToConnect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 582);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(868, 318);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potential connection time";
            // 
            // buttonQuality
            // 
            this.buttonQuality.Location = new System.Drawing.Point(763, 273);
            this.buttonQuality.Name = "buttonQuality";
            this.buttonQuality.Size = new System.Drawing.Size(85, 32);
            this.buttonQuality.TabIndex = 8;
            this.buttonQuality.Text = "Quality";
            this.buttonQuality.UseVisualStyleBackColor = true;
            // 
            // labelDateToConnect
            // 
            this.labelDateToConnect.AutoSize = true;
            this.labelDateToConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateToConnect.Location = new System.Drawing.Point(248, 273);
            this.labelDateToConnect.Name = "labelDateToConnect";
            this.labelDateToConnect.Size = new System.Drawing.Size(24, 32);
            this.labelDateToConnect.TabIndex = 7;
            this.labelDateToConnect.Text = "-";
            // 
            // labelTimeToConnect
            // 
            this.labelTimeToConnect.AutoSize = true;
            this.labelTimeToConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeToConnect.Location = new System.Drawing.Point(209, 50);
            this.labelTimeToConnect.Name = "labelTimeToConnect";
            this.labelTimeToConnect.Size = new System.Drawing.Size(145, 204);
            this.labelTimeToConnect.TabIndex = 6;
            this.labelTimeToConnect.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(483, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(868, 521);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position in queue";
            // 
            // Options
            // 
            this.Options.Controls.Add(this.checkBox4);
            this.Options.Controls.Add(this.checkBoxPrometheus);
            this.Options.Controls.Add(this.buttonPlayAlarm);
            this.Options.Controls.Add(this.Alarm);
            this.Options.Controls.Add(this.comboBox_alarm);
            this.Options.Controls.Add(this.checkBox3);
            this.Options.Controls.Add(this.checkBox2);
            this.Options.Controls.Add(this.numericUpDown1);
            this.Options.Controls.Add(this.checkBox1);
            this.Options.Location = new System.Drawing.Point(31, 40);
            this.Options.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Options.Size = new System.Drawing.Size(430, 860);
            this.Options.TabIndex = 5;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(26, 162);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(81, 24);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Speak";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrometheus
            // 
            this.checkBoxPrometheus.AutoSize = true;
            this.checkBoxPrometheus.Checked = true;
            this.checkBoxPrometheus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrometheus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxPrometheus.Location = new System.Drawing.Point(26, 134);
            this.checkBoxPrometheus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPrometheus.Name = "checkBoxPrometheus";
            this.checkBoxPrometheus.Size = new System.Drawing.Size(218, 24);
            this.checkBoxPrometheus.TabIndex = 11;
            this.checkBoxPrometheus.Text = "Expose prometheus client";
            this.checkBoxPrometheus.UseVisualStyleBackColor = true;
            // 
            // buttonPlayAlarm
            // 
            this.buttonPlayAlarm.Image = global::_2B2TQueAlarm.Properties.Resources.control_play_blue;
            this.buttonPlayAlarm.Location = new System.Drawing.Point(341, 50);
            this.buttonPlayAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlayAlarm.Name = "buttonPlayAlarm";
            this.buttonPlayAlarm.Size = new System.Drawing.Size(43, 30);
            this.buttonPlayAlarm.TabIndex = 10;
            this.buttonPlayAlarm.UseVisualStyleBackColor = true;
            this.buttonPlayAlarm.Click += new System.EventHandler(this.buttonPlayAlarm_Click);
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(22, 54);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(98, 20);
            this.Alarm.TabIndex = 9;
            this.Alarm.Text = "Alarm sound";
            // 
            // comboBox_alarm
            // 
            this.comboBox_alarm.FormattingEnabled = true;
            this.comboBox_alarm.Location = new System.Drawing.Point(127, 50);
            this.comboBox_alarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_alarm.Name = "comboBox_alarm";
            this.comboBox_alarm.Size = new System.Drawing.Size(206, 28);
            this.comboBox_alarm.TabIndex = 8;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(26, 190);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(230, 24);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Update Arduino Dashboard";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(26, 218);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(239, 24);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Sent smartphone notification";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 101);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 26);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1444, 32);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 29);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 1253);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "2B2T Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            this.Log.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label Alarm;
        private System.Windows.Forms.ComboBox comboBox_alarm;
        private System.Windows.Forms.Button buttonPlayAlarm;
        private System.Windows.Forms.CheckBox checkBoxPrometheus;
        private System.Windows.Forms.TabPage Log;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton clearDebug;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenMLog;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelToolState;
        private System.Windows.Forms.Label labelTimeToConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDateToConnect;
        private System.Windows.Forms.Button buttonQuality;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

