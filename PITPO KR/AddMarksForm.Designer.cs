namespace PITPO_KR
{
  partial class AddMarksForm
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
      this.btnPutMark = new System.Windows.Forms.Button();
      this.txtMark = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.listBoxStudents = new System.Windows.Forms.ListBox();
      this.listBoxTests = new System.Windows.Forms.ListBox();
      this.label7 = new System.Windows.Forms.Label();
      this.lblGroup = new System.Windows.Forms.Label();
      this.lblTestName = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lblQuestNumbers = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.lblRightAnswers = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Студент:";
      // 
      // btnPutMark
      // 
      this.btnPutMark.Location = new System.Drawing.Point(270, 328);
      this.btnPutMark.Name = "btnPutMark";
      this.btnPutMark.Size = new System.Drawing.Size(88, 23);
      this.btnPutMark.TabIndex = 4;
      this.btnPutMark.Text = "Выставить оценку";
      this.btnPutMark.UseVisualStyleBackColor = true;
      this.btnPutMark.Click += new System.EventHandler(this.btnPutMark_Click);
      // 
      // txtMark
      // 
      this.txtMark.Location = new System.Drawing.Point(149, 328);
      this.txtMark.Name = "txtMark";
      this.txtMark.Size = new System.Drawing.Size(115, 20);
      this.txtMark.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(95, 331);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Оценка:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 168);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Тест:";
      // 
      // listBoxStudents
      // 
      this.listBoxStudents.FormattingEnabled = true;
      this.listBoxStudents.Location = new System.Drawing.Point(15, 31);
      this.listBoxStudents.Name = "listBoxStudents";
      this.listBoxStudents.Size = new System.Drawing.Size(222, 121);
      this.listBoxStudents.TabIndex = 7;
      this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
      // 
      // listBoxTests
      // 
      this.listBoxTests.FormattingEnabled = true;
      this.listBoxTests.Location = new System.Drawing.Point(15, 184);
      this.listBoxTests.Name = "listBoxTests";
      this.listBoxTests.Size = new System.Drawing.Size(222, 121);
      this.listBoxTests.TabIndex = 8;
      this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(243, 31);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(45, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Группа:";
      // 
      // lblGroup
      // 
      this.lblGroup.AutoSize = true;
      this.lblGroup.Location = new System.Drawing.Point(342, 31);
      this.lblGroup.Name = "lblGroup";
      this.lblGroup.Size = new System.Drawing.Size(16, 13);
      this.lblGroup.TabIndex = 13;
      this.lblGroup.Text = "...";
      // 
      // lblTestName
      // 
      this.lblTestName.AutoSize = true;
      this.lblTestName.Location = new System.Drawing.Point(393, 184);
      this.lblTestName.Name = "lblTestName";
      this.lblTestName.Size = new System.Drawing.Size(16, 13);
      this.lblTestName.TabIndex = 15;
      this.lblTestName.Text = "...";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(243, 184);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(60, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Название:";
      // 
      // lblQuestNumbers
      // 
      this.lblQuestNumbers.AutoSize = true;
      this.lblQuestNumbers.Location = new System.Drawing.Point(393, 208);
      this.lblQuestNumbers.Name = "lblQuestNumbers";
      this.lblQuestNumbers.Size = new System.Drawing.Size(16, 13);
      this.lblQuestNumbers.TabIndex = 17;
      this.lblQuestNumbers.Text = "...";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(243, 208);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(95, 13);
      this.label9.TabIndex = 16;
      this.label9.Text = "Кол-во вопросов:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(243, 232);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(113, 13);
      this.label10.TabIndex = 18;
      this.label10.Text = "Правильные ответы:";
      // 
      // lblRightAnswers
      // 
      this.lblRightAnswers.AutoSize = true;
      this.lblRightAnswers.Location = new System.Drawing.Point(393, 232);
      this.lblRightAnswers.Name = "lblRightAnswers";
      this.lblRightAnswers.Size = new System.Drawing.Size(16, 13);
      this.lblRightAnswers.TabIndex = 19;
      this.lblRightAnswers.Text = "...";
      // 
      // AddMarksForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 365);
      this.Controls.Add(this.lblRightAnswers);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.lblQuestNumbers);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.lblTestName);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.lblGroup);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.listBoxTests);
      this.Controls.Add(this.listBoxStudents);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtMark);
      this.Controls.Add(this.btnPutMark);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "AddMarksForm";
      this.Text = "AddMarksForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnPutMark;
    private System.Windows.Forms.TextBox txtMark;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox listBoxStudents;
    private System.Windows.Forms.ListBox listBoxTests;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblGroup;
    private System.Windows.Forms.Label lblTestName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblQuestNumbers;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lblRightAnswers;
  }
}