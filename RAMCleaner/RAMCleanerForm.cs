using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using RAMCleaner.Properties;
using Timer = System.Timers.Timer;

namespace RAMCleaner
{
    public partial class RAMCleanerForm : Form
    {
        private Timer _timer;

        public RAMCleanerForm()
        {
            InitializeComponent();
            this.Text = $"{Application.ProductName} {Application.ProductVersion}";
            notifyIcon.Text = $"{Application.ProductName} {Application.ProductVersion}";
            notifyIcon.Icon = Resources.DefaultIcon;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            Initialize();
        }

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        private static extern bool SetWorkingSet(IntPtr handle, int minimum, int maximum);

        private void FreeMemory()
        {
            ChangeIcon(IconType.WORKING_ICON);

            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    SetWorkingSet(process.Handle, -1, -1);
                }
                catch
                {
                    // ignored (just in case we don't have access to that process)
                }
            }

            ChangeIcon(IconType.DEFAULT_ICON);
        }

        public void ChangeIcon(IconType iconType)
        {
            switch (iconType)
            {
                case IconType.DEFAULT_ICON:
                    notifyIcon.Icon = Resources.DefaultIcon;
                    Icon = Resources.DefaultIcon;
                    break;
                case IconType.WORKING_ICON:
                    notifyIcon.Icon = Resources.WorkingIcon;
                    Icon = Resources.WorkingIcon;
                    break;
            }
        }

        private void Initialize()
        {
            if (_timer == null)
            {
                _timer = new Timer { AutoReset = true };
                _timer.Elapsed += TimerTick;
            }
            else
            {
                _timer.Stop();
            }

            _timer.Interval = Settings.Default.CleanInterval * 60 * 1000;
            _timer.Start();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
                Refresh();
                Visible = false;
            }
            else
            {
                nud_interval.Value = Settings.Default.CleanInterval;
                Visible = true;
                Refresh();
                WindowState = FormWindowState.Normal;
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Settings.Default.CleanInterval = (int)nud_interval.Value;
            Initialize();
        }

        private void menuItem_exit_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Environment.Exit(0);
        }

        private void menuItem_clearNow_Click(object sender, EventArgs e)
        {
            FreeMemory();
        }

        private void menuItem_settings_Click(object sender, EventArgs e)
        {
            nud_interval.Value = Settings.Default.CleanInterval;
            Visible = true;
            Refresh();
            WindowState = FormWindowState.Normal;
        }

        private void menuItem_changeInterval_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem selectedItem 
                && int.TryParse(selectedItem.Tag as string, out var minutesInterval))
            {
                Settings.Default.CleanInterval = minutesInterval;
                nud_interval.Value = Settings.Default.CleanInterval;
            }
        }

        private void RAMCleanerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            Refresh();
            Visible = false;
        }

        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            FreeMemory();
        }
    }
}