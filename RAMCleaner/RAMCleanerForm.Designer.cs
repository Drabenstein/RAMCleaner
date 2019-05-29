namespace RAMCleaner
{
    partial class RAMCleanerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RAMCleanerForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_changeInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_fiveMinInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_tenMinInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_fifteenMinInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_thirtyMinInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_oneHourInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_threeHoursInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_sixHoursInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_twelveHoursInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_clearNow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label_intervalInfo = new System.Windows.Forms.Label();
            this.nud_interval = new System.Windows.Forms.NumericUpDown();
            this.label_minutes = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.iconContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconContextMenuStrip;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // iconContextMenuStrip
            // 
            this.iconContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_changeInterval,
            this.menuItem_clearNow,
            this.menuItem_settings,
            this.menuItem_exit});
            this.iconContextMenuStrip.Name = "contextMenuStrip1";
            this.iconContextMenuStrip.Size = new System.Drawing.Size(219, 128);
            // 
            // menuItem_changeInterval
            // 
            this.menuItem_changeInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_fiveMinInterval,
            this.menuItem_tenMinInterval,
            this.menuItem_fifteenMinInterval,
            this.menuItem_thirtyMinInterval,
            this.menuItem_oneHourInterval,
            this.menuItem_threeHoursInterval,
            this.menuItem_sixHoursInterval,
            this.menuItem_twelveHoursInterval});
            this.menuItem_changeInterval.Name = "menuItem_changeInterval";
            this.menuItem_changeInterval.Size = new System.Drawing.Size(218, 24);
            this.menuItem_changeInterval.Text = "Zmień interwał";
            // 
            // menuItem_fiveMinInterval
            // 
            this.menuItem_fiveMinInterval.Name = "menuItem_fiveMinInterval";
            this.menuItem_fiveMinInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_fiveMinInterval.Tag = "5";
            this.menuItem_fiveMinInterval.Text = "5 minut";
            this.menuItem_fiveMinInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_tenMinInterval
            // 
            this.menuItem_tenMinInterval.Name = "menuItem_tenMinInterval";
            this.menuItem_tenMinInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_tenMinInterval.Tag = "10";
            this.menuItem_tenMinInterval.Text = "10 minut";
            this.menuItem_tenMinInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_fifteenMinInterval
            // 
            this.menuItem_fifteenMinInterval.Name = "menuItem_fifteenMinInterval";
            this.menuItem_fifteenMinInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_fifteenMinInterval.Tag = "15";
            this.menuItem_fifteenMinInterval.Text = "15 minut";
            this.menuItem_fifteenMinInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_thirtyMinInterval
            // 
            this.menuItem_thirtyMinInterval.Name = "menuItem_thirtyMinInterval";
            this.menuItem_thirtyMinInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_thirtyMinInterval.Tag = "30";
            this.menuItem_thirtyMinInterval.Text = "30 minut";
            this.menuItem_thirtyMinInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_oneHourInterval
            // 
            this.menuItem_oneHourInterval.Name = "menuItem_oneHourInterval";
            this.menuItem_oneHourInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_oneHourInterval.Tag = "60";
            this.menuItem_oneHourInterval.Text = "1 godzina";
            this.menuItem_oneHourInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_threeHoursInterval
            // 
            this.menuItem_threeHoursInterval.Name = "menuItem_threeHoursInterval";
            this.menuItem_threeHoursInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_threeHoursInterval.Tag = "180";
            this.menuItem_threeHoursInterval.Text = "3 godziny";
            this.menuItem_threeHoursInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_sixHoursInterval
            // 
            this.menuItem_sixHoursInterval.Name = "menuItem_sixHoursInterval";
            this.menuItem_sixHoursInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_sixHoursInterval.Tag = "360";
            this.menuItem_sixHoursInterval.Text = "6 godzin";
            this.menuItem_sixHoursInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_twelveHoursInterval
            // 
            this.menuItem_twelveHoursInterval.Name = "menuItem_twelveHoursInterval";
            this.menuItem_twelveHoursInterval.Size = new System.Drawing.Size(224, 26);
            this.menuItem_twelveHoursInterval.Tag = "720";
            this.menuItem_twelveHoursInterval.Text = "12 godzin";
            this.menuItem_twelveHoursInterval.Click += new System.EventHandler(this.menuItem_changeInterval_Click);
            // 
            // menuItem_clearNow
            // 
            this.menuItem_clearNow.Name = "menuItem_clearNow";
            this.menuItem_clearNow.Size = new System.Drawing.Size(218, 24);
            this.menuItem_clearNow.Text = "Uruchom czyszczenie";
            this.menuItem_clearNow.Click += new System.EventHandler(this.menuItem_clearNow_Click);
            // 
            // menuItem_settings
            // 
            this.menuItem_settings.Name = "menuItem_settings";
            this.menuItem_settings.Size = new System.Drawing.Size(218, 24);
            this.menuItem_settings.Text = "Ustawienia";
            this.menuItem_settings.Click += new System.EventHandler(this.menuItem_settings_Click);
            // 
            // menuItem_exit
            // 
            this.menuItem_exit.Name = "menuItem_exit";
            this.menuItem_exit.Size = new System.Drawing.Size(218, 24);
            this.menuItem_exit.Text = "Zakończ";
            this.menuItem_exit.Click += new System.EventHandler(this.menuItem_exit_Click);
            // 
            // label_intervalInfo
            // 
            this.label_intervalInfo.AutoSize = true;
            this.label_intervalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_intervalInfo.Location = new System.Drawing.Point(12, 9);
            this.label_intervalInfo.Name = "label_intervalInfo";
            this.label_intervalInfo.Size = new System.Drawing.Size(220, 18);
            this.label_intervalInfo.TabIndex = 0;
            this.label_intervalInfo.Text = "Przerwa między czyszczeniami:";
            // 
            // nud_interval
            // 
            this.nud_interval.Location = new System.Drawing.Point(258, 9);
            this.nud_interval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nud_interval.Name = "nud_interval";
            this.nud_interval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nud_interval.Size = new System.Drawing.Size(71, 22);
            this.nud_interval.TabIndex = 1;
            this.nud_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_minutes
            // 
            this.label_minutes.AutoSize = true;
            this.label_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_minutes.Location = new System.Drawing.Point(335, 9);
            this.label_minutes.Name = "label_minutes";
            this.label_minutes.Size = new System.Drawing.Size(36, 18);
            this.label_minutes.TabIndex = 2;
            this.label_minutes.Text = "min.";
            // 
            // button_apply
            // 
            this.button_apply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_apply.Location = new System.Drawing.Point(377, 7);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 3;
            this.button_apply.Text = "Zastosuj";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // RAMCleanerForm
            // 
            this.AcceptButton = this.button_apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 42);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.label_minutes);
            this.Controls.Add(this.nud_interval);
            this.Controls.Add(this.label_intervalInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RAMCleanerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAMCleaner v1.0.0 - Ustawienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RAMCleanerForm_FormClosing);
            this.iconContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label_intervalInfo;
        private System.Windows.Forms.NumericUpDown nud_interval;
        private System.Windows.Forms.Label label_minutes;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.ContextMenuStrip iconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_changeInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_fiveMinInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_tenMinInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_fifteenMinInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_thirtyMinInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_oneHourInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_threeHoursInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_sixHoursInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_twelveHoursInterval;
        private System.Windows.Forms.ToolStripMenuItem menuItem_clearNow;
        private System.Windows.Forms.ToolStripMenuItem menuItem_settings;
        private System.Windows.Forms.ToolStripMenuItem menuItem_exit;
    }
}