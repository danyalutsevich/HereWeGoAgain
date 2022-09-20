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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // labelNewYorkTIme
            // 
            resources.ApplyResources(this.labelNewYorkTIme, "labelNewYorkTIme");
            this.labelNewYorkTIme.Name = "labelNewYorkTIme";
            // 
            // labelLondonTime
            // 
            resources.ApplyResources(this.labelLondonTime, "labelLondonTime");
            this.labelLondonTime.Name = "labelLondonTime";
            // 
            // labelCaliforniaTime
            // 
            resources.ApplyResources(this.labelCaliforniaTime, "labelCaliforniaTime");
            this.labelCaliforniaTime.Name = "labelCaliforniaTime";
            // 
            // labelTokyoTime
            // 
            resources.ApplyResources(this.labelTokyoTime, "labelTokyoTime");
            this.labelTokyoTime.Name = "labelTokyoTime";
            // 
            // labelKyivTime
            // 
            resources.ApplyResources(this.labelKyivTime, "labelKyivTime");
            this.labelKyivTime.Name = "labelKyivTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

