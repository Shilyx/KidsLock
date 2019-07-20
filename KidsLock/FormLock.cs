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
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {

            Invalidate();
        }
    }
}
