namespace Project4
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
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.lb = new System.Windows.Forms.Label();
            this.lbSc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 50;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(333, 7);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(37, 15);
            this.lb.TabIndex = 0;
            this.lb.Text = "Score";
            // 
            // lbSc
            // 
            this.lbSc.AutoSize = true;
            this.lbSc.Location = new System.Drawing.Point(376, 7);
            this.lbSc.Name = "lbSc";
            this.lbSc.Size = new System.Drawing.Size(14, 15);
            this.lbSc.TabIndex = 1;
            this.lbSc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.lbSc);
            this.Controls.Add(this.lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer myTimer;
        private Label lb;
        private Label lbSc;
    }
}