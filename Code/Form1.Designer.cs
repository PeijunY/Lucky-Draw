namespace 抽奖
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.comboCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxInvalid = new System.Windows.Forms.ListBox();
            this.btnClearInvalid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(382, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始(&S)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMax.Location = new System.Drawing.Point(89, 14);
            this.txtMax.Name = "txtMax";
            this.txtMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMax.Size = new System.Drawing.Size(56, 26);
            this.txtMax.TabIndex = 1;
            this.txtMax.Text = "222";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(524, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMin.Location = new System.Drawing.Point(20, 14);
            this.txtMin.Name = "txtMin";
            this.txtMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMin.Size = new System.Drawing.Size(53, 26);
            this.txtMin.TabIndex = 1;
            this.txtMin.Text = "1";
            // 
            // comboCount
            // 
            this.comboCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboCount.FormattingEnabled = true;
            this.comboCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboCount.Location = new System.Drawing.Point(287, 14);
            this.comboCount.Name = "comboCount";
            this.comboCount.Size = new System.Drawing.Size(55, 28);
            this.comboCount.TabIndex = 2;
            this.comboCount.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(163, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "每次抽取个数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(75, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // lblResult1
            // 
            this.lblResult1.BackColor = System.Drawing.Color.Cornsilk;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.lblResult1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblResult1.Location = new System.Drawing.Point(20, 77);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(125, 70);
            this.lblResult1.TabIndex = 4;
            this.lblResult1.Text = "-";
            this.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult2
            // 
            this.lblResult2.BackColor = System.Drawing.Color.Cornsilk;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.lblResult2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblResult2.Location = new System.Drawing.Point(181, 77);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(125, 70);
            this.lblResult2.TabIndex = 4;
            this.lblResult2.Text = "-";
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult3
            // 
            this.lblResult3.BackColor = System.Drawing.Color.Cornsilk;
            this.lblResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.lblResult3.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblResult3.Location = new System.Drawing.Point(342, 77);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(125, 70);
            this.lblResult3.TabIndex = 4;
            this.lblResult3.Text = "-";
            this.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(20, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(125, 314);
            this.listBox1.TabIndex = 5;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(181, 169);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(125, 314);
            this.listBox2.TabIndex = 5;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 31;
            this.listBox3.Location = new System.Drawing.Point(342, 169);
            this.listBox3.Name = "listBox3";
            this.listBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(125, 314);
            this.listBox3.TabIndex = 5;
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSort.Location = new System.Drawing.Point(503, 89);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(97, 40);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "结果排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(503, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "无效号码：";
            // 
            // listBoxInvalid
            // 
            this.listBoxInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBoxInvalid.ForeColor = System.Drawing.Color.Red;
            this.listBoxInvalid.FormattingEnabled = true;
            this.listBoxInvalid.ItemHeight = 31;
            this.listBoxInvalid.Location = new System.Drawing.Point(503, 169);
            this.listBoxInvalid.Name = "listBoxInvalid";
            this.listBoxInvalid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxInvalid.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxInvalid.Size = new System.Drawing.Size(125, 314);
            this.listBoxInvalid.TabIndex = 5;
            // 
            // btnClearInvalid
            // 
            this.btnClearInvalid.Location = new System.Drawing.Point(589, 146);
            this.btnClearInvalid.Name = "btnClearInvalid";
            this.btnClearInvalid.Size = new System.Drawing.Size(39, 23);
            this.btnClearInvalid.TabIndex = 8;
            this.btnClearInvalid.Text = "Clear";
            this.btnClearInvalid.UseVisualStyleBackColor = true;
            this.btnClearInvalid.Click += new System.EventHandler(this.btnClearInvalid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 490);
            this.Controls.Add(this.btnClearInvalid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.listBoxInvalid);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCount);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.ComboBox comboCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxInvalid;
        private System.Windows.Forms.Button btnClearInvalid;
    }
}

