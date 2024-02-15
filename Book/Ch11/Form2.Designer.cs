namespace Ch11
{
    partial class Form2
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
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.lbCombo = new System.Windows.Forms.Label();
            this.btnPos = new System.Windows.Forms.Button();
            this.lbPos = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.btnCity = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lbGrid = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터를 공급해줘야 하는 컨트롤";
            // 
            // cbPos
            // 
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Location = new System.Drawing.Point(12, 68);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(126, 23);
            this.cbPos.TabIndex = 1;
            this.cbPos.SelectedIndexChanged += new System.EventHandler(this.cbPos_SelectedIndexChanged);
            // 
            // lbCombo
            // 
            this.lbCombo.AutoSize = true;
            this.lbCombo.Location = new System.Drawing.Point(15, 50);
            this.lbCombo.Name = "lbCombo";
            this.lbCombo.Size = new System.Drawing.Size(123, 15);
            this.lbCombo.TabIndex = 2;
            this.lbCombo.Text = "콤보박스 컨트롤 실습";
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(144, 68);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 23);
            this.btnPos.TabIndex = 3;
            this.btnPos.Text = "확인";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(225, 71);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(38, 15);
            this.lbPos.TabIndex = 4;
            this.lbPos.Text = "결과 :";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(225, 111);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(38, 15);
            this.lbCity.TabIndex = 7;
            this.lbCity.Text = "결과 :";
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(144, 108);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(75, 23);
            this.btnCity.TabIndex = 6;
            this.btnCity.Text = "확인";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(12, 108);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(126, 23);
            this.cbCity.TabIndex = 5;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lbGrid
            // 
            this.lbGrid.AutoSize = true;
            this.lbGrid.Location = new System.Drawing.Point(15, 168);
            this.lbGrid.Name = "lbGrid";
            this.lbGrid.Size = new System.Drawing.Size(159, 15);
            this.lbGrid.TabIndex = 8;
            this.lbGrid.Text = "데이터그리드뷰 컨트롤 실습";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 196);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(331, 150);
            this.gridView.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.lbGrid);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.lbCombo);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbPos;
        private Label lbCombo;
        private Button btnPos;
        private Label lbPos;
        private Label lbCity;
        private Button btnCity;
        private ComboBox cbCity;
        private Label lbGrid;
        private DataGridView gridView;
    }
}