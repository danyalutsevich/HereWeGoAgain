namespace Culture
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNewYorkTIme = new System.Windows.Forms.Label();
            this.labelLondonTime = new System.Windows.Forms.Label();
            this.labelCaliforniaTime = new System.Windows.Forms.Label();
            this.labelTokyoTime = new System.Windows.Forms.Label();
            this.labelKyivTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New York";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "London";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "California";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tokyo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kyiv";
            // 
            // labelNewYorkTIme
            // 
            this.labelNewYorkTIme.AutoSize = true;
            this.labelNewYorkTIme.Location = new System.Drawing.Point(136, 62);
            this.labelNewYorkTIme.Name = "labelNewYorkTIme";
            this.labelNewYorkTIme.Size = new System.Drawing.Size(54, 13);
            this.labelNewYorkTIme.TabIndex = 0;
            this.labelNewYorkTIme.Text = "New York";
            // 
            // labelLondonTime
            // 
            this.labelLondonTime.AutoSize = true;
            this.labelLondonTime.Location = new System.Drawing.Point(136, 92);
            this.labelLondonTime.Name = "labelLondonTime";
            this.labelLondonTime.Size = new System.Drawing.Size(43, 13);
            this.labelLondonTime.TabIndex = 0;
            this.labelLondonTime.Text = "London";
            // 
            // labelCaliforniaTime
            // 
            this.labelCaliforniaTime.AutoSize = true;
            this.labelCaliforniaTime.Location = new System.Drawing.Point(136, 118);
            this.labelCaliforniaTime.Name = "labelCaliforniaTime";
            this.labelCaliforniaTime.Size = new System.Drawing.Size(50, 13);
            this.labelCaliforniaTime.TabIndex = 0;
            this.labelCaliforniaTime.Text = "California";
            // 
            // labelTokyoTime
            // 
            this.labelTokyoTime.AutoSize = true;
            this.labelTokyoTime.Location = new System.Drawing.Point(136, 142);
            this.labelTokyoTime.Name = "labelTokyoTime";
            this.labelTokyoTime.Size = new System.Drawing.Size(37, 13);
            this.labelTokyoTime.TabIndex = 0;
            this.labelTokyoTime.Text = "Tokyo";
            // 
            // labelKyivTime
            // 
            this.labelKyivTime.AutoSize = true;
            this.labelKyivTime.Location = new System.Drawing.Point(136, 166);
            this.labelKyivTime.Name = "labelKyivTime";
            this.labelKyivTime.Size = new System.Drawing.Size(27, 13);
            this.labelKyivTime.TabIndex = 0;
            this.labelKyivTime.Text = "Kyiv";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKyivTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTokyoTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCaliforniaTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLondonTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNewYorkTIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNewYorkTIme;
        private System.Windows.Forms.Label labelLondonTime;
        private System.Windows.Forms.Label labelCaliforniaTime;
        private System.Windows.Forms.Label labelTokyoTime;
        private System.Windows.Forms.Label labelKyivTime;
        private System.Windows.Forms.Timer timer1;
    }
}

