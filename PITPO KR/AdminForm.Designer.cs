namespace PITPO_KR
{
  partial class AdminForm
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
      this.btnLookTests = new System.Windows.Forms.Button();
      this.btnAddTest = new System.Windows.Forms.Button();
      this.btnLookProgress = new System.Windows.Forms.Button();
      this.btnAddMark = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Панель Администратора";
      // 
      // btnLookTests
      // 
      this.btnLookTests.Location = new System.Drawing.Point(12, 34);
      this.btnLookTests.Name = "btnLookTests";
      this.btnLookTests.Size = new System.Drawing.Size(156, 23);
      this.btnLookTests.TabIndex = 1;
      this.btnLookTests.Text = "Посмотреть тесты";
      this.btnLookTests.UseVisualStyleBackColor = true;
      // 
      // btnAddTest
      // 
      this.btnAddTest.Location = new System.Drawing.Point(12, 63);
      this.btnAddTest.Name = "btnAddTest";
      this.btnAddTest.Size = new System.Drawing.Size(156, 23);
      this.btnAddTest.TabIndex = 2;
      this.btnAddTest.Text = "Добавить тест";
      this.btnAddTest.UseVisualStyleBackColor = true;
      this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
      // 
      // btnLookProgress
      // 
      this.btnLookProgress.Location = new System.Drawing.Point(12, 121);
      this.btnLookProgress.Name = "btnLookProgress";
      this.btnLookProgress.Size = new System.Drawing.Size(156, 23);
      this.btnLookProgress.TabIndex = 4;
      this.btnLookProgress.Text = "Посмотреть прогресс";
      this.btnLookProgress.UseVisualStyleBackColor = true;
      // 
      // btnAddMark
      // 
      this.btnAddMark.Location = new System.Drawing.Point(12, 92);
      this.btnAddMark.Name = "btnAddMark";
      this.btnAddMark.Size = new System.Drawing.Size(156, 23);
      this.btnAddMark.TabIndex = 3;
      this.btnAddMark.Text = "Выставить оценки";
      this.btnAddMark.UseVisualStyleBackColor = true;
      // 
      // AdminForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(183, 173);
      this.Controls.Add(this.btnLookProgress);
      this.Controls.Add(this.btnAddMark);
      this.Controls.Add(this.btnAddTest);
      this.Controls.Add(this.btnLookTests);
      this.Controls.Add(this.label1);
      this.Name = "AdminForm";
      this.Text = "AdminForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnLookTests;
    private System.Windows.Forms.Button btnAddTest;
    private System.Windows.Forms.Button btnLookProgress;
    private System.Windows.Forms.Button btnAddMark;
  }
}