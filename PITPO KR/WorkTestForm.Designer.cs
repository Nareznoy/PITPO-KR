
namespace PITPO_KR
{
  partial class WorkTestForm
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
      this.lblTestName = new System.Windows.Forms.Label();
      this.lbl = new System.Windows.Forms.Label();
      this.btnPrevQuest = new System.Windows.Forms.Button();
      this.btnNextQuest = new System.Windows.Forms.Button();
      this.chkQ1 = new System.Windows.Forms.CheckBox();
      this.chkQ2 = new System.Windows.Forms.CheckBox();
      this.chkQ3 = new System.Windows.Forms.CheckBox();
      this.chkQ4 = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTestName
      // 
      this.lblTestName.AutoSize = true;
      this.lblTestName.Location = new System.Drawing.Point(130, 9);
      this.lblTestName.Name = "lblTestName";
      this.lblTestName.Size = new System.Drawing.Size(88, 13);
      this.lblTestName.TabIndex = 0;
      this.lblTestName.Text = "Название теста";
      // 
      // lbl
      // 
      this.lbl.AutoSize = true;
      this.lbl.Location = new System.Drawing.Point(22, 42);
      this.lbl.Name = "lbl";
      this.lbl.Size = new System.Drawing.Size(44, 13);
      this.lbl.TabIndex = 1;
      this.lbl.Text = "Вопрос";
      // 
      // btnPrevQuest
      // 
      this.btnPrevQuest.Location = new System.Drawing.Point(25, 189);
      this.btnPrevQuest.Name = "btnPrevQuest";
      this.btnPrevQuest.Size = new System.Drawing.Size(75, 23);
      this.btnPrevQuest.TabIndex = 2;
      this.btnPrevQuest.Text = "<";
      this.btnPrevQuest.UseVisualStyleBackColor = true;
      // 
      // btnNextQuest
      // 
      this.btnNextQuest.Location = new System.Drawing.Point(264, 189);
      this.btnNextQuest.Name = "btnNextQuest";
      this.btnNextQuest.Size = new System.Drawing.Size(75, 23);
      this.btnNextQuest.TabIndex = 3;
      this.btnNextQuest.Text = ">";
      this.btnNextQuest.UseVisualStyleBackColor = true;
      // 
      // chkQ1
      // 
      this.chkQ1.AutoSize = true;
      this.chkQ1.Location = new System.Drawing.Point(25, 70);
      this.chkQ1.Name = "chkQ1";
      this.chkQ1.Size = new System.Drawing.Size(72, 17);
      this.chkQ1.TabIndex = 4;
      this.chkQ1.Text = "Вопрос 1";
      this.chkQ1.UseVisualStyleBackColor = true;
      // 
      // chkQ2
      // 
      this.chkQ2.AutoSize = true;
      this.chkQ2.Location = new System.Drawing.Point(25, 93);
      this.chkQ2.Name = "chkQ2";
      this.chkQ2.Size = new System.Drawing.Size(72, 17);
      this.chkQ2.TabIndex = 5;
      this.chkQ2.Text = "Вопрос 2";
      this.chkQ2.UseVisualStyleBackColor = true;
      // 
      // chkQ3
      // 
      this.chkQ3.AutoSize = true;
      this.chkQ3.Location = new System.Drawing.Point(25, 116);
      this.chkQ3.Name = "chkQ3";
      this.chkQ3.Size = new System.Drawing.Size(72, 17);
      this.chkQ3.TabIndex = 6;
      this.chkQ3.Text = "Вопрос 3";
      this.chkQ3.UseVisualStyleBackColor = true;
      // 
      // chkQ4
      // 
      this.chkQ4.AutoSize = true;
      this.chkQ4.Location = new System.Drawing.Point(25, 139);
      this.chkQ4.Name = "chkQ4";
      this.chkQ4.Size = new System.Drawing.Size(72, 17);
      this.chkQ4.TabIndex = 7;
      this.chkQ4.Text = "Вопрос 4";
      this.chkQ4.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(162, 194);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "0/0";
      // 
      // WorkTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 231);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.chkQ4);
      this.Controls.Add(this.chkQ3);
      this.Controls.Add(this.chkQ2);
      this.Controls.Add(this.chkQ1);
      this.Controls.Add(this.btnNextQuest);
      this.Controls.Add(this.btnPrevQuest);
      this.Controls.Add(this.lbl);
      this.Controls.Add(this.lblTestName);
      this.Name = "WorkTestForm";
      this.Text = "WorkTestForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTestName;
    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.Button btnPrevQuest;
    private System.Windows.Forms.Button btnNextQuest;
    private System.Windows.Forms.CheckBox chkQ1;
    private System.Windows.Forms.CheckBox chkQ2;
    private System.Windows.Forms.CheckBox chkQ3;
    private System.Windows.Forms.CheckBox chkQ4;
    private System.Windows.Forms.Label label1;
  }
}