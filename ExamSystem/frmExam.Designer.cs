namespace ExamSystem
{
    partial class frmExam
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.lblQuestionName = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tableQuestions = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbD);
            this.panel1.Controls.Add(this.rbC);
            this.panel1.Controls.Add(this.rbB);
            this.panel1.Controls.Add(this.rbA);
            this.panel1.Controls.Add(this.lblQuestionName);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 267);
            this.panel1.TabIndex = 0;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Font = new System.Drawing.Font("宋体", 14F);
            this.rbD.Location = new System.Drawing.Point(17, 212);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(37, 23);
            this.rbD.TabIndex = 1;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("宋体", 14F);
            this.rbC.Location = new System.Drawing.Point(17, 164);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(37, 23);
            this.rbC.TabIndex = 1;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Font = new System.Drawing.Font("宋体", 14F);
            this.rbB.Location = new System.Drawing.Point(17, 116);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(37, 23);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Font = new System.Drawing.Font("宋体", 14F);
            this.rbA.Location = new System.Drawing.Point(17, 68);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(37, 23);
            this.rbA.TabIndex = 1;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
            // 
            // lblQuestionName
            // 
            this.lblQuestionName.AutoSize = true;
            this.lblQuestionName.Font = new System.Drawing.Font("宋体", 20F);
            this.lblQuestionName.Location = new System.Drawing.Point(12, 9);
            this.lblQuestionName.Name = "lblQuestionName";
            this.lblQuestionName.Size = new System.Drawing.Size(337, 27);
            this.lblQuestionName.TabIndex = 0;
            this.lblQuestionName.Text = "1、计算机有那几部分组成?";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("宋体", 20F);
            this.btnPrevious.Location = new System.Drawing.Point(200, 288);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(151, 45);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "上一题";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 20F);
            this.btnNext.Location = new System.Drawing.Point(399, 288);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 45);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tableQuestions
            // 
            this.tableQuestions.ColumnCount = 5;
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.Location = new System.Drawing.Point(1, 3);
            this.tableQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.tableQuestions.Name = "tableQuestions";
            this.tableQuestions.RowCount = 5;
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableQuestions.Size = new System.Drawing.Size(198, 264);
            this.tableQuestions.TabIndex = 3;
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 367);
            this.Controls.Add(this.tableQuestions);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "咸鱼考试";
            this.Load += new System.EventHandler(this.frmExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lblQuestionName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TableLayoutPanel tableQuestions;
    }
}

