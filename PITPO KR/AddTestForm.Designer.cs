namespace PITPO_KR
{
  partial class AddTestForm
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
      this.textTestName = new System.Windows.Forms.TextBox();
      this.textQuestText = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textQ1 = new System.Windows.Forms.TextBox();
      this.textQ2 = new System.Windows.Forms.TextBox();
      this.textQ4 = new System.Windows.Forms.TextBox();
      this.textQ3 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.btnAddQuest = new System.Windows.Forms.Button();
      this.btnAddTest = new System.Windows.Forms.Button();
      this.chkQ1 = new System.Windows.Forms.CheckBox();
      this.chkQ3 = new System.Windows.Forms.CheckBox();
      this.chkQ2 = new System.Windows.Forms.CheckBox();
      this.chkQ4 = new System.Windows.Forms.CheckBox();
      this.lblHint = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Название теста:";
      // 
      // textTestName
      // 
      this.textTestName.Location = new System.Drawing.Point(109, 9);
      this.textTestName.Name = "textTestName";
      this.textTestName.Size = new System.Drawing.Size(167, 20);
      this.textTestName.TabIndex = 1;
      // 
      // textQuestText
      // 
      this.textQuestText.Location = new System.Drawing.Point(109, 35);
      this.textQuestText.Name = "textQuestText";
      this.textQuestText.Size = new System.Drawing.Size(167, 20);
      this.textQuestText.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Вопрос:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(16, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "a:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(163, 75);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(16, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "b:";
      // 
      // textQ1
      // 
      this.textQ1.Location = new System.Drawing.Point(34, 72);
      this.textQ1.Name = "textQ1";
      this.textQ1.Size = new System.Drawing.Size(96, 20);
      this.textQ1.TabIndex = 6;
      // 
      // textQ2
      // 
      this.textQ2.Location = new System.Drawing.Point(185, 72);
      this.textQ2.Name = "textQ2";
      this.textQ2.Size = new System.Drawing.Size(91, 20);
      this.textQ2.TabIndex = 7;
      // 
      // textQ4
      // 
      this.textQ4.Location = new System.Drawing.Point(185, 98);
      this.textQ4.Name = "textQ4";
      this.textQ4.Size = new System.Drawing.Size(91, 20);
      this.textQ4.TabIndex = 11;
      // 
      // textQ3
      // 
      this.textQ3.Location = new System.Drawing.Point(34, 98);
      this.textQ3.Name = "textQ3";
      this.textQ3.Size = new System.Drawing.Size(96, 20);
      this.textQ3.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(163, 101);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(16, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "d:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 101);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(16, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "c:";
      // 
      // btnAddQuest
      // 
      this.btnAddQuest.Location = new System.Drawing.Point(91, 124);
      this.btnAddQuest.Name = "btnAddQuest";
      this.btnAddQuest.Size = new System.Drawing.Size(128, 23);
      this.btnAddQuest.TabIndex = 12;
      this.btnAddQuest.Text = "Добавить вопрос";
      this.btnAddQuest.UseVisualStyleBackColor = true;
      this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
      // 
      // btnAddTest
      // 
      this.btnAddTest.Location = new System.Drawing.Point(91, 153);
      this.btnAddTest.Name = "btnAddTest";
      this.btnAddTest.Size = new System.Drawing.Size(128, 23);
      this.btnAddTest.TabIndex = 13;
      this.btnAddTest.Text = "Добавить тест";
      this.btnAddTest.UseVisualStyleBackColor = true;
      this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
      // 
      // chkQ1
      // 
      this.chkQ1.AutoSize = true;
      this.chkQ1.Location = new System.Drawing.Point(136, 74);
      this.chkQ1.Name = "chkQ1";
      this.chkQ1.Size = new System.Drawing.Size(15, 14);
      this.chkQ1.TabIndex = 14;
      this.chkQ1.UseVisualStyleBackColor = true;
      // 
      // chkQ3
      // 
      this.chkQ3.AutoSize = true;
      this.chkQ3.Location = new System.Drawing.Point(136, 101);
      this.chkQ3.Name = "chkQ3";
      this.chkQ3.Size = new System.Drawing.Size(15, 14);
      this.chkQ3.TabIndex = 15;
      this.chkQ3.UseVisualStyleBackColor = true;
      // 
      // chkQ2
      // 
      this.chkQ2.AutoSize = true;
      this.chkQ2.Location = new System.Drawing.Point(282, 74);
      this.chkQ2.Name = "chkQ2";
      this.chkQ2.Size = new System.Drawing.Size(15, 14);
      this.chkQ2.TabIndex = 16;
      this.chkQ2.UseVisualStyleBackColor = true;
      // 
      // chkQ4
      // 
      this.chkQ4.AutoSize = true;
      this.chkQ4.Location = new System.Drawing.Point(282, 101);
      this.chkQ4.Name = "chkQ4";
      this.chkQ4.Size = new System.Drawing.Size(15, 14);
      this.chkQ4.TabIndex = 17;
      this.chkQ4.UseVisualStyleBackColor = true;
      // 
      // lblHint
      // 
      this.lblHint.AutoSize = true;
      this.lblHint.Location = new System.Drawing.Point(119, 186);
      this.lblHint.Name = "lblHint";
      this.lblHint.Size = new System.Drawing.Size(0, 13);
      this.lblHint.TabIndex = 18;
      // 
      // AddTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(327, 208);
      this.Controls.Add(this.lblHint);
      this.Controls.Add(this.chkQ4);
      this.Controls.Add(this.chkQ2);
      this.Controls.Add(this.chkQ3);
      this.Controls.Add(this.chkQ1);
      this.Controls.Add(this.btnAddTest);
      this.Controls.Add(this.btnAddQuest);
      this.Controls.Add(this.textQ4);
      this.Controls.Add(this.textQ3);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textQ2);
      this.Controls.Add(this.textQ1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textQuestText);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textTestName);
      this.Controls.Add(this.label1);
      this.Name = "AddTestForm";
      this.Text = "AddTestForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textTestName;
    private System.Windows.Forms.TextBox textQuestText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textQ1;
    private System.Windows.Forms.TextBox textQ2;
    private System.Windows.Forms.TextBox textQ4;
    private System.Windows.Forms.TextBox textQ3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnAddQuest;
    private System.Windows.Forms.Button btnAddTest;
    private System.Windows.Forms.CheckBox chkQ1;
    private System.Windows.Forms.CheckBox chkQ3;
    private System.Windows.Forms.CheckBox chkQ2;
    private System.Windows.Forms.CheckBox chkQ4;
    private System.Windows.Forms.Label lblHint;
  }
}