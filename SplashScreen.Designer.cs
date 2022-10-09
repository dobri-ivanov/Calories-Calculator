namespace CaloriesCalculator
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelProgression = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelProgression.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(105)))), ((int)(((byte)(101)))));
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(56, 22);
            this.panelStart.TabIndex = 0;
            this.panelStart.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelProgression
            // 
            this.panelProgression.BackColor = System.Drawing.Color.Transparent;
            this.panelProgression.Controls.Add(this.panelStart);
            this.panelProgression.Location = new System.Drawing.Point(0, 429);
            this.panelProgression.Name = "panelProgression";
            this.panelProgression.Size = new System.Drawing.Size(800, 22);
            this.panelProgression.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.BackgroundImage = global::CaloriesCalculator.Properties.Resources.splashScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelProgression);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калориен Калкулатор";
            this.panelProgression.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelProgression;
        private System.Windows.Forms.Timer timer;
    }
}