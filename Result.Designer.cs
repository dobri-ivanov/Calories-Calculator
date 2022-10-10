namespace CaloriesCalculator
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelCarbs = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelFats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(101, 323);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(166, 52);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(315, 323);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(166, 52);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelCalories
            // 
            this.labelCalories.BackColor = System.Drawing.Color.Transparent;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalories.ForeColor = System.Drawing.Color.White;
            this.labelCalories.Location = new System.Drawing.Point(448, 80);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(140, 38);
            this.labelCalories.TabIndex = 21;
            this.labelCalories.Text = "1878.53";
            // 
            // labelCarbs
            // 
            this.labelCarbs.BackColor = System.Drawing.Color.Transparent;
            this.labelCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarbs.ForeColor = System.Drawing.Color.White;
            this.labelCarbs.Location = new System.Drawing.Point(448, 142);
            this.labelCarbs.Name = "labelCarbs";
            this.labelCarbs.Size = new System.Drawing.Size(140, 39);
            this.labelCarbs.TabIndex = 22;
            this.labelCarbs.Text = "1878.53";
            // 
            // labelProteins
            // 
            this.labelProteins.BackColor = System.Drawing.Color.Transparent;
            this.labelProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProteins.ForeColor = System.Drawing.Color.White;
            this.labelProteins.Location = new System.Drawing.Point(458, 203);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(140, 39);
            this.labelProteins.TabIndex = 23;
            this.labelProteins.Text = "35.21 g";
            // 
            // labelFats
            // 
            this.labelFats.BackColor = System.Drawing.Color.Transparent;
            this.labelFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFats.ForeColor = System.Drawing.Color.White;
            this.labelFats.Location = new System.Drawing.Point(448, 263);
            this.labelFats.Name = "labelFats";
            this.labelFats.Size = new System.Drawing.Size(140, 39);
            this.labelFats.TabIndex = 24;
            this.labelFats.Text = "1878.53";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.labelFats);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelCarbs);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelCarbs;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelFats;
    }
}