﻿
namespace PITPO_KR
{
  partial class TestChooseForm
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
      this.cmbTestList = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkQ4 = new System.Windows.Forms.CheckBox();
      this.chkQ3 = new System.Windows.Forms.CheckBox();
      this.chkQ2 = new System.Windows.Forms.CheckBox();
      this.chkQ1 = new System.Windows.Forms.CheckBox();
      this.btnNextQuest = new System.Windows.Forms.Button();
      this.btnPrevQuest = new System.Windows.Forms.Button();
      this.lbl = new System.Windows.Forms.Label();
      this.lblTestName = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmbTestList
      // 
      this.cmbTestList.FormattingEnabled = true;
      this.cmbTestList.Location = new System.Drawing.Point(15, 34);
      this.cmbTestList.Name = "cmbTestList";
      this.cmbTestList.Size = new System.Drawing.Size(342, 21);
      this.cmbTestList.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(169, 266);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "0/0";
      // 
      // chkQ4
      // 
      this.chkQ4.AutoSize = true;
      this.chkQ4.Location = new System.Drawing.Point(16, 204);
      this.chkQ4.Name = "chkQ4";
      this.chkQ4.Size = new System.Drawing.Size(72, 17);
      this.chkQ4.TabIndex = 16;
      this.chkQ4.Text = "Вопрос 4";
      this.chkQ4.UseVisualStyleBackColor = true;
      // 
      // chkQ3
      // 
      this.chkQ3.AutoSize = true;
      this.chkQ3.Location = new System.Drawing.Point(16, 181);
      this.chkQ3.Name = "chkQ3";
      this.chkQ3.Size = new System.Drawing.Size(72, 17);
      this.chkQ3.TabIndex = 15;
      this.chkQ3.Text = "Вопрос 3";
      this.chkQ3.UseVisualStyleBackColor = true;
      // 
      // chkQ2
      // 
      this.chkQ2.AutoSize = true;
      this.chkQ2.Location = new System.Drawing.Point(16, 158);
      this.chkQ2.Name = "chkQ2";
      this.chkQ2.Size = new System.Drawing.Size(72, 17);
      this.chkQ2.TabIndex = 14;
      this.chkQ2.Text = "Вопрос 2";
      this.chkQ2.UseVisualStyleBackColor = true;
      // 
      // chkQ1
      // 
      this.chkQ1.AutoSize = true;
      this.chkQ1.Location = new System.Drawing.Point(16, 135);
      this.chkQ1.Name = "chkQ1";
      this.chkQ1.Size = new System.Drawing.Size(72, 17);
      this.chkQ1.TabIndex = 13;
      this.chkQ1.Text = "Вопрос 1";
      this.chkQ1.UseVisualStyleBackColor = true;
      // 
      // btnNextQuest
      // 
      this.btnNextQuest.Location = new System.Drawing.Point(282, 261);
      this.btnNextQuest.Name = "btnNextQuest";
      this.btnNextQuest.Size = new System.Drawing.Size(75, 23);
      this.btnNextQuest.TabIndex = 12;
      this.btnNextQuest.Text = ">";
      this.btnNextQuest.UseVisualStyleBackColor = true;
      // 
      // btnPrevQuest
      // 
      this.btnPrevQuest.Location = new System.Drawing.Point(12, 261);
      this.btnPrevQuest.Name = "btnPrevQuest";
      this.btnPrevQuest.Size = new System.Drawing.Size(75, 23);
      this.btnPrevQuest.TabIndex = 11;
      this.btnPrevQuest.Text = "<";
      this.btnPrevQuest.UseVisualStyleBackColor = true;
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.Location = new System.Drawing.Point(13, 107);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(44, 13);
      this.lbl.TabIndex = 10;
      this.lbl.Text = "Вопрос";
      // 
      // lblTestName
      // 
      this.lblTestName.AutoSize = true;
      this.lblTestName.Location = new System.Drawing.Point(12, 76);
      this.lblTestName.Name = "lblTestName";
      this.lblTestName.Size = new System.Drawing.Size(88, 13);
      this.lblTestName.TabIndex = 9;
      this.lblTestName.Text = "Название теста";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Выбрать тест";
      // 
      // TestChooseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(369, 296);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.chkQ4);
      this.Controls.Add(this.chkQ3);
      this.Controls.Add(this.chkQ2);
      this.Controls.Add(this.chkQ1);
      this.Controls.Add(this.btnNextQuest);
      this.Controls.Add(this.btnPrevQuest);
      this.Controls.Add(this.lbl);
      this.Controls.Add(this.lblTestName);
      this.Controls.Add(this.cmbTestList);
      this.Name = "TestChooseForm";
      this.Text = "TestChooseForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbTestList;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chkQ4;
    private System.Windows.Forms.CheckBox chkQ3;
    private System.Windows.Forms.CheckBox chkQ2;
    private System.Windows.Forms.CheckBox chkQ1;
    private System.Windows.Forms.Button btnNextQuest;
    private System.Windows.Forms.Button btnPrevQuest;
    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.Label lblTestName;
    private System.Windows.Forms.Label label2;
  }
}