using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KidsLock
{
    public partial class FormLock : Form
    {
        private DateTime dtUnlock;

        public FormLock(int nLockSeconds = 20 * 60)
        {
            InitializeComponent();
            dtUnlock = DateTime.Now.AddSeconds(nLockSeconds);
            timerCountDown.Enabled = true;

            this.DoubleBuffered = true;
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now < dtUnlock)
            {
                Invalidate();
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (DateTime.Now >= dtUnlock)
            {
                Close();
                return;
            }

            if (new FormQuestion().ShowDialog(this) == DialogResult.OK)
            {
                Close();
                return;
            }

            Invalidate();
        }

        private void FormLock_Paint(object sender, PaintEventArgs e)
        {
            DateTime dtNow = DateTime.Now;

            if (dtNow < dtUnlock)
            {
                TimeSpan ts = dtUnlock - dtNow;

                string strText = string.Format("Please wait for {0:D2}:{1:D2}:{2:D2}:{3:D3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                SizeF s = e.Graphics.MeasureString(strText, Font);

                e.Graphics.DrawString(strText, this.Font, Brushes.Blue, new Point(
                    (Width - (int)s.Width) / 2,
                    (Height - (int)s.Height) / 2));
            }
        }
    }
}
