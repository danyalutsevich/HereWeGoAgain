namespace KeyboardEvents
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCounter = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerRainbow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonCounter
            // 
            this.buttonCounter.Location = new System.Drawing.Point(413, 12);
            this.buttonCounter.Name = "buttonCounter";
            this.buttonCounter.Size = new System.Drawing.Size(112, 52);
            this.buttonCounter.TabIndex = 0;
            this.buttonCounter.TabStop = false;
            this.buttonCounter.Text = "button1";
            this.buttonCounter.UseVisualStyleBackColor = true;
            this.buttonCounter.Visible = false;
            this.buttonCounter.Click += new System.EventHandler(this.button1_Click);
            this.buttonCounter.MouseEnter += new System.EventHandler(this.buttonCounter_MouseEnter);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Helvetica", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(186, 475);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 35);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRainbow
            // 
            this.timerRainbow.Enabled = true;
            this.timerRainbow.Tick += new System.EventHandler(this.timerRainbow_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 519);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonCounter);
            this.Name = "Form1";
            this.Text = "Form1a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCounter;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerRainbow;
    }
}
