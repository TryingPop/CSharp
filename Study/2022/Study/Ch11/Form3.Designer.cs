namespace Ch11
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnO1 = new System.Windows.Forms.Button();
            this.btnO2 = new System.Windows.Forms.Button();
            this.btnO3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "윈도우 그래픽 실습";
            // 
            // btnO1
            // 
            this.btnO1.Location = new System.Drawing.Point(12, 27);
            this.btnO1.Name = "btnO1";
            this.btnO1.Size = new System.Drawing.Size(75, 23);
            this.btnO1.TabIndex = 1;
            this.btnO1.Text = "모형 출력1";
            this.btnO1.UseVisualStyleBackColor = true;
            this.btnO1.Click += new System.EventHandler(this.btnO1_Click);
            // 
            // btnO2
            // 
            this.btnO2.Location = new System.Drawing.Point(93, 27);
            this.btnO2.Name = "btnO2";
            this.btnO2.Size = new System.Drawing.Size(75, 23);
            this.btnO2.TabIndex = 2;
            this.btnO2.Text = "모형 출력";
            this.btnO2.UseVisualStyleBackColor = true;
            this.btnO2.Click += new System.EventHandler(this.btnO2_Click);
            // 
            // btnO3
            // 
            this.btnO3.Location = new System.Drawing.Point(174, 27);
            this.btnO3.Name = "btnO3";
            this.btnO3.Size = new System.Drawing.Size(75, 23);
            this.btnO3.TabIndex = 3;
            this.btnO3.Text = "모형 출력";
            this.btnO3.UseVisualStyleBackColor = true;
            this.btnO3.Click += new System.EventHandler(this.btnO3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnO3);
            this.Controls.Add(this.btnO2);
            this.Controls.Add(this.btnO1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnO1;
        private Button btnO2;
        private Button btnO3;
    }
}