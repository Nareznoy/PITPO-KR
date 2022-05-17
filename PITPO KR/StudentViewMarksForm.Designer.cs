
namespace PITPO_KR
{
  partial class StudentViewMarksForm
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
      this.listBoxTests = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblTestName = new System.Windows.Forms.Label();
      this.lblTeacherName = new System.Windows.Forms.Label();
      this.lblQuestNumber = new System.Windows.Forms.Label();
      this.lblRightAnswersNumber = new System.Windows.Forms.Label();
      this.lblMark = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBoxTests
      // 
      this.listBoxTests.FormattingEnabled = true;
      this.listBoxTests.Location = new System.Drawing.Point(12, 12);
      this.listBoxTests.Name = "listBoxTests";
      this.listBoxTests.Size = new System.Drawing.Size(231, 199);
      this.listBoxTests.TabIndex = 0;
      this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(249, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Название теста:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(249, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Преподаватель:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(251, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(95, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Кол-во вопросов:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(251, 105);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(108, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Кол-во правильных:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(251, 135);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Оценка:";
      // 
      // lblTestName
      // 
      this.lblTestName.AutoSize = true;
      this.lblTestName.Location = new System.Drawing.Point(394, 12);
      this.lblTestName.Name = "lblTestName";
      this.lblTestName.Size = new System.Drawing.Size(16, 13);
      this.lblTestName.TabIndex = 6;
      this.lblTestName.Text = "...";
      // 
      // lblTeacherName
      // 
      this.lblTeacherName.AutoSize = true;
      this.lblTeacherName.Location = new System.Drawing.Point(394, 43);
      this.lblTeacherName.Name = "lblTeacherName";
      this.lblTeacherName.Size = new System.Drawing.Size(16, 13);
      this.lblTeacherName.TabIndex = 7;
      this.lblTeacherName.Text = "...";
      // 
      // lblQuestNumber
      // 
      this.lblQuestNumber.AutoSize = true;
      this.lblQuestNumber.Location = new System.Drawing.Point(394, 74);
      this.lblQuestNumber.Name = "lblQuestNumber";
      this.lblQuestNumber.Size = new System.Drawing.Size(16, 13);
      this.lblQuestNumber.TabIndex = 8;
      this.lblQuestNumber.Text = "...";
      // 
      // lblRightAnswersNumber
      // 
      this.lblRightAnswersNumber.AutoSize = true;
      this.lblRightAnswersNumber.Location = new System.Drawing.Point(394, 105);
      this.lblRightAnswersNumber.Name = "lblRightAnswersNumber";
      this.lblRightAnswersNumber.Size = new System.Drawing.Size(16, 13);
      this.lblRightAnswersNumber.TabIndex = 9;
      this.lblRightAnswersNumber.Text = "...";
      // 
      // lblMark
      // 
      this.lblMark.AutoSize = true;
      this.lblMark.Location = new System.Drawing.Point(394, 135);
      this.lblMark.Name = "lblMark";
      this.lblMark.Size = new System.Drawing.Size(16, 13);
      this.lblMark.TabIndex = 10;
      this.lblMark.Text = "...";
      // 
      // StudentViewMarksForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(494, 221);
      this.Controls.Add(this.lblMark);
      this.Controls.Add(this.lblRightAnswersNumber);
      this.Controls.Add(this.lblQuestNumber);
      this.Controls.Add(this.lblTeacherName);
      this.Controls.Add(this.lblTestName);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBoxTests);
      this.Name = "StudentViewMarksForm";
      this.Text = "StudentViewMarksForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxTests;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblTestName;
    private System.Windows.Forms.Label lblTeacherName;
    private System.Windows.Forms.Label lblQuestNumber;
    private System.Windows.Forms.Label lblRightAnswersNumber;
    private System.Windows.Forms.Label lblMark;
  }
}