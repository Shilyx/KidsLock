namespace KidsLock
{
    partial class FormLock
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
            this.btnUnlock = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnUnlock
            // 
            this.btnUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnlock.Location = new System.Drawing.Point(359, 230);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(256, 71);
            this.btnUnlock.TabIndex = 0;
            this.btnUnlock.Text = "&Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 7;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // FormLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 66F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 313);
            this.ControlBox = false;
            this.Controls.Add(this.btnUnlock);
            this.Font = new System.Drawing.Font("Consolas", 42F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Name = "FormLock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormLock";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLock_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Timer timerCountDown;
    }
}