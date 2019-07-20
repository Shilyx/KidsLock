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
    public partial class FormQuestion : Form
    {
        private Button[] btnAnswers;
        private Random rand;
        private string strQuestion = string.Empty;
        private string strAnswer = string.Empty;
        private int nSleepSeconds = 0;
        private int nSleepPlanSeconds = 0;

        public FormQuestion()
        {
            InitializeComponent();
            btnCancel.Location = new Point(100000, 100000);
            Text = "Question";

            rand = new Random((int)Handle);
            btnAnswers = new Button[]
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12,
            };

            foreach (Button btn in btnAnswers)
            {
                btn.Click += Btn_Click;
            }

            timerSleep.Enabled = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if ((sender as Control).Text == strAnswer)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                sleepForWhile();
            }
        }

        private void FormQuestion_Load(object sender, EventArgs e)
        {
            createQuestion();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void createQuestion()
        {
            int a = rand.Next(10, 50);
            int b = rand.Next(10, 50);

            foreach (Button btn in btnAnswers)
            {
                btn.Text = rand.Next(20, 100).ToString();
            }

            strAnswer = (a + b).ToString();
            strQuestion = string.Format("{0} + {1} = ?", a, b);

            btnAnswers[rand.Next(btnAnswers.Length)].Text = strAnswer;

            Invalidate();
        }

        private void FormQuestion_Paint(object sender, PaintEventArgs e)
        {
            SizeF s = e.Graphics.MeasureString(strQuestion, Font);
            int nLeft = (int)(((float)Width - s.Width) / 2);

            e.Graphics.DrawString(strQuestion, Font, Brushes.Black, new Point(nLeft, 40));
        }

        private void sleepForWhile()
        {
            this.ControlBox = false;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Enabled = false;
                }
            }

            if (nSleepPlanSeconds > 10)
            {
                nSleepSeconds = (nSleepPlanSeconds += 10);
            }
            else
            {
                nSleepSeconds = (nSleepPlanSeconds += 3);
            }
        }

        private void timerSleep_Tick(object sender, EventArgs e)
        {
            if (nSleepSeconds <= 0)
            {
                return;
            }

            if (--nSleepSeconds == 0)
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is Button)
                    {
                        ctrl.Enabled = true;
                    }
                }
                createQuestion();
                Text = "Question";
                this.ControlBox = true;
            }
            else
            {
                Text = string.Format("Question - Plase wait for {0} seconds", nSleepSeconds);
            }
        }

        private void FormQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnCancel.Enabled)
            {
                e.Cancel = true;
            }
        }
    }
}
