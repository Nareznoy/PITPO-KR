namespace PITPO_KR
{
  partial class StudentForm
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
      this.btnMyMarks = new System.Windows.Forms.Button();
      this.btnTests = new System.Windows.Forms.Button();
      this.btnModules = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(66, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ученик";
      // 
      // btnMyMarks
      // 
      this.btnMyMarks.Location = new System.Drawing.Point(12, 25);
      this.btnMyMarks.Name = "btnMyMarks";
      this.btnMyMarks.Size = new System.Drawing.Size(151, 23);
      this.btnMyMarks.TabIndex = 2;
      this.btnMyMarks.Text = "Мои оценки";
      this.btnMyMarks.UseVisualStyleBackColor = true;
      this.btnMyMarks.Click += new System.EventHandler(this.btnMyMarks_Click);
      // 
      // btnTests
      // 
      this.btnTests.Location = new System.Drawing.Point(12, 83);
      this.btnTests.Name = "btnTests";
      this.btnTests.Size = new System.Drawing.Size(151, 23);
      this.btnTests.TabIndex = 4;
      this.btnTests.Text = "Тесты";
      this.btnTests.UseVisualStyleBackColor = true;
      this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
      // 
      // btnModules
      // 
      this.btnModules.Location = new System.Drawing.Point(12, 54);
      this.btnModules.Name = "btnModules";
      this.btnModules.Size = new System.Drawing.Size(151, 23);
      this.btnModules.TabIndex = 3;
      this.btnModules.Text = "Модули";
      this.btnModules.UseVisualStyleBackColor = true;
      this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
      // 
      // StudentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(181, 117);
      this.Controls.Add(this.btnTests);
      this.Controls.Add(this.btnModules);
      this.Controls.Add(this.btnMyMarks);
      this.Controls.Add(this.label1);
      this.Name = "StudentForm";
      this.Text = "StudentForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnMyMarks;
    private System.Windows.Forms.Button btnTests;
    private System.Windows.Forms.Button btnModules;
  }
}