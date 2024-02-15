namespace Ch11
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.btnUid = new System.Windows.Forms.Button();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHp = new System.Windows.Forms.Button();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHp = new System.Windows.Forms.Label();
            this.lbUid = new System.Windows.Forms.Label();
            this.lbchkbox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFruit1 = new System.Windows.Forms.CheckBox();
            this.chkFruit2 = new System.Windows.Forms.CheckBox();
            this.chkFruit3 = new System.Windows.Forms.CheckBox();
            this.chkFruit4 = new System.Windows.Forms.CheckBox();
            this.btnChkFruit = new System.Windows.Forms.Button();
            this.btnChkColor = new System.Windows.Forms.Button();
            this.chkColor4 = new System.Windows.Forms.CheckBox();
            this.chkColor3 = new System.Windows.Forms.CheckBox();
            this.chkColor2 = new System.Windows.Forms.CheckBox();
            this.chkColor1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFruitResult = new System.Windows.Forms.Label();
            this.lbColorResult = new System.Windows.Forms.Label();
            this.btnSF = new System.Windows.Forms.Button();
            this.btnSF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(88, 15);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Hello WinForm";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 24);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(71, 15);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "버튼 컨트롤";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(8, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "버튼1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(89, 42);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "버튼2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(170, 42);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "버튼3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 68);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(111, 15);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "텍스트 박스 컨트롤";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(68, 86);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(96, 23);
            this.txtUid.TabIndex = 6;
            // 
            // btnUid
            // 
            this.btnUid.Location = new System.Drawing.Point(170, 86);
            this.btnUid.Name = "btnUid";
            this.btnUid.Size = new System.Drawing.Size(75, 23);
            this.btnUid.TabIndex = 7;
            this.btnUid.Text = "확인";
            this.btnUid.UseVisualStyleBackColor = true;
            this.btnUid.Click += new System.EventHandler(this.btnUid_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(12, 90);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(50, 15);
            this.lb4.TabIndex = 8;
            this.lb4.Text = "아이디 :";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(12, 119);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(38, 15);
            this.lb5.TabIndex = 11;
            this.lb5.Text = "이름 :";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(170, 115);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 10;
            this.btnName.Text = "확인";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 23);
            this.txtName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "H P : ";
            // 
            // btnHp
            // 
            this.btnHp.Location = new System.Drawing.Point(170, 144);
            this.btnHp.Name = "btnHp";
            this.btnHp.Size = new System.Drawing.Size(75, 23);
            this.btnHp.TabIndex = 13;
            this.btnHp.Text = "확인";
            this.btnHp.UseVisualStyleBackColor = true;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(68, 144);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(96, 23);
            this.txtHp.TabIndex = 12;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(251, 118);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 15);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "결과 :";
            // 
            // lbHp
            // 
            this.lbHp.AutoSize = true;
            this.lbHp.Location = new System.Drawing.Point(251, 147);
            this.lbHp.Name = "lbHp";
            this.lbHp.Size = new System.Drawing.Size(38, 15);
            this.lbHp.TabIndex = 17;
            this.lbHp.Text = "결과 :";
            // 
            // lbUid
            // 
            this.lbUid.AutoSize = true;
            this.lbUid.Location = new System.Drawing.Point(251, 90);
            this.lbUid.Name = "lbUid";
            this.lbUid.Size = new System.Drawing.Size(38, 15);
            this.lbUid.TabIndex = 18;
            this.lbUid.Text = "결과 :";
            // 
            // lbchkbox
            // 
            this.lbchkbox.AutoSize = true;
            this.lbchkbox.Location = new System.Drawing.Point(12, 181);
            this.lbchkbox.Name = "lbchkbox";
            this.lbchkbox.Size = new System.Drawing.Size(127, 15);
            this.lbchkbox.TabIndex = 19;
            this.lbchkbox.Text = "체크 박스 컨트롤 실습";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "좋아하는 과일을 모두 선택하세요";
            // 
            // chkFruit1
            // 
            this.chkFruit1.AutoSize = true;
            this.chkFruit1.Location = new System.Drawing.Point(13, 218);
            this.chkFruit1.Name = "chkFruit1";
            this.chkFruit1.Size = new System.Drawing.Size(50, 19);
            this.chkFruit1.TabIndex = 21;
            this.chkFruit1.Text = "사과";
            this.chkFruit1.UseVisualStyleBackColor = true;
            // 
            // chkFruit2
            // 
            this.chkFruit2.AutoSize = true;
            this.chkFruit2.Location = new System.Drawing.Point(68, 218);
            this.chkFruit2.Name = "chkFruit2";
            this.chkFruit2.Size = new System.Drawing.Size(50, 19);
            this.chkFruit2.TabIndex = 22;
            this.chkFruit2.Text = "딸기";
            this.chkFruit2.UseVisualStyleBackColor = true;
            // 
            // chkFruit3
            // 
            this.chkFruit3.AutoSize = true;
            this.chkFruit3.Location = new System.Drawing.Point(124, 218);
            this.chkFruit3.Name = "chkFruit3";
            this.chkFruit3.Size = new System.Drawing.Size(50, 19);
            this.chkFruit3.TabIndex = 23;
            this.chkFruit3.Text = "포도";
            this.chkFruit3.UseVisualStyleBackColor = true;
            // 
            // chkFruit4
            // 
            this.chkFruit4.AutoSize = true;
            this.chkFruit4.Location = new System.Drawing.Point(180, 218);
            this.chkFruit4.Name = "chkFruit4";
            this.chkFruit4.Size = new System.Drawing.Size(50, 19);
            this.chkFruit4.TabIndex = 25;
            this.chkFruit4.Text = "수박";
            this.chkFruit4.UseVisualStyleBackColor = true;
            // 
            // btnChkFruit
            // 
            this.btnChkFruit.Location = new System.Drawing.Point(236, 214);
            this.btnChkFruit.Name = "btnChkFruit";
            this.btnChkFruit.Size = new System.Drawing.Size(75, 23);
            this.btnChkFruit.TabIndex = 26;
            this.btnChkFruit.Text = "확인";
            this.btnChkFruit.UseVisualStyleBackColor = true;
            this.btnChkFruit.Click += new System.EventHandler(this.btnChkFruit_Click);
            // 
            // btnChkColor
            // 
            this.btnChkColor.Location = new System.Drawing.Point(236, 306);
            this.btnChkColor.Name = "btnChkColor";
            this.btnChkColor.Size = new System.Drawing.Size(75, 23);
            this.btnChkColor.TabIndex = 32;
            this.btnChkColor.Text = "확인";
            this.btnChkColor.UseVisualStyleBackColor = true;
            this.btnChkColor.Click += new System.EventHandler(this.btnChkColor_Click);
            // 
            // chkColor4
            // 
            this.chkColor4.AutoSize = true;
            this.chkColor4.Location = new System.Drawing.Point(180, 310);
            this.chkColor4.Name = "chkColor4";
            this.chkColor4.Size = new System.Drawing.Size(50, 19);
            this.chkColor4.TabIndex = 31;
            this.chkColor4.Text = "검정";
            this.chkColor4.UseVisualStyleBackColor = true;
            // 
            // chkColor3
            // 
            this.chkColor3.AutoSize = true;
            this.chkColor3.Location = new System.Drawing.Point(124, 310);
            this.chkColor3.Name = "chkColor3";
            this.chkColor3.Size = new System.Drawing.Size(50, 19);
            this.chkColor3.TabIndex = 30;
            this.chkColor3.Text = "노랑";
            this.chkColor3.UseVisualStyleBackColor = true;
            // 
            // chkColor2
            // 
            this.chkColor2.AutoSize = true;
            this.chkColor2.Location = new System.Drawing.Point(68, 310);
            this.chkColor2.Name = "chkColor2";
            this.chkColor2.Size = new System.Drawing.Size(50, 19);
            this.chkColor2.TabIndex = 29;
            this.chkColor2.Text = "파랑";
            this.chkColor2.UseVisualStyleBackColor = true;
            // 
            // chkColor1
            // 
            this.chkColor1.AutoSize = true;
            this.chkColor1.Location = new System.Drawing.Point(13, 310);
            this.chkColor1.Name = "chkColor1";
            this.chkColor1.Size = new System.Drawing.Size(50, 19);
            this.chkColor1.TabIndex = 28;
            this.chkColor1.Text = "빨강";
            this.chkColor1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "좋아하는 색깔 모두 선택하세요";
            // 
            // lbFruitResult
            // 
            this.lbFruitResult.AutoSize = true;
            this.lbFruitResult.Location = new System.Drawing.Point(8, 250);
            this.lbFruitResult.Name = "lbFruitResult";
            this.lbFruitResult.Size = new System.Drawing.Size(38, 15);
            this.lbFruitResult.TabIndex = 33;
            this.lbFruitResult.Text = "결과 :";
            // 
            // lbColorResult
            // 
            this.lbColorResult.AutoSize = true;
            this.lbColorResult.Location = new System.Drawing.Point(13, 348);
            this.lbColorResult.Name = "lbColorResult";
            this.lbColorResult.Size = new System.Drawing.Size(38, 15);
            this.lbColorResult.TabIndex = 34;
            this.lbColorResult.Text = "결과 :";
            // 
            // btnSF
            // 
            this.btnSF.Location = new System.Drawing.Point(8, 382);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(131, 23);
            this.btnSF.TabIndex = 35;
            this.btnSF.Text = "Sub Form 띄우기";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSF_Click);
            // 
            // btnSF2
            // 
            this.btnSF2.Location = new System.Drawing.Point(158, 382);
            this.btnSF2.Name = "btnSF2";
            this.btnSF2.Size = new System.Drawing.Size(131, 23);
            this.btnSF2.TabIndex = 36;
            this.btnSF2.Text = "Sub Form2 띄우기";
            this.btnSF2.UseVisualStyleBackColor = true;
            this.btnSF2.Click += new System.EventHandler(this.btnSF2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSF2);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.lbColorResult);
            this.Controls.Add(this.lbFruitResult);
            this.Controls.Add(this.btnChkColor);
            this.Controls.Add(this.chkColor4);
            this.Controls.Add(this.chkColor3);
            this.Controls.Add(this.chkColor2);
            this.Controls.Add(this.chkColor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChkFruit);
            this.Controls.Add(this.chkFruit4);
            this.Controls.Add(this.chkFruit3);
            this.Controls.Add(this.chkFruit2);
            this.Controls.Add(this.chkFruit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbchkbox);
            this.Controls.Add(this.lbUid);
            this.Controls.Add(this.lbHp);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.btnUid);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb1;
        private Label lb2;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label lb3;
        private TextBox txtUid;
        private Button btnUid;
        private Label lb4;
        private Label lb5;
        private Button btnName;
        private TextBox txtName;
        private Label label2;
        private Button btnHp;
        private TextBox txtHp;
        private Label lbName;
        private Label lbHp;
        private Label lbUid;
        private Label lbchkbox;
        private Label label1;
        private CheckBox chkFruit1;
        private CheckBox chkFruit2;
        private CheckBox chkFruit3;
        private CheckBox chkFruit4;
        private Button btnChkFruit;
        private Button btnChkColor;
        private CheckBox chkColor4;
        private CheckBox chkColor3;
        private CheckBox chkColor2;
        private CheckBox chkColor1;
        private Label label3;
        private Label lbFruitResult;
        private Label lbColorResult;
        private Button btnSF;
        private Button btnSF2;
    }
}