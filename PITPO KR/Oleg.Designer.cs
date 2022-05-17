
namespace PITPO_KR
{
  partial class Oleg
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
      this.listBoxFiles = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnDownload = new System.Windows.Forms.Button();
      this.btnUpload = new System.Windows.Forms.Button();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.SuspendLayout();
      // 
      // listBoxFiles
      // 
      this.listBoxFiles.FormattingEnabled = true;
      this.listBoxFiles.Location = new System.Drawing.Point(12, 36);
      this.listBoxFiles.Name = "listBoxFiles";
      this.listBoxFiles.Size = new System.Drawing.Size(317, 277);
      this.listBoxFiles.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Методические материалы";
      // 
      // btnDownload
      // 
      this.btnDownload.Location = new System.Drawing.Point(335, 36);
      this.btnDownload.Name = "btnDownload";
      this.btnDownload.Size = new System.Drawing.Size(177, 63);
      this.btnDownload.TabIndex = 2;
      this.btnDownload.Text = "Скачать документ";
      this.btnDownload.UseVisualStyleBackColor = true;
      this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
      // 
      // btnUpload
      // 
      this.btnUpload.Location = new System.Drawing.Point(335, 105);
      this.btnUpload.Name = "btnUpload";
      this.btnUpload.Size = new System.Drawing.Size(177, 63);
      this.btnUpload.TabIndex = 3;
      this.btnUpload.Text = "Загрузить документ";
      this.btnUpload.UseVisualStyleBackColor = true;
      this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
      // 
      // Oleg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(521, 326);
      this.Controls.Add(this.btnUpload);
      this.Controls.Add(this.btnDownload);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBoxFiles);
      this.Name = "Oleg";
      this.Text = "Oleg";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxFiles;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnDownload;
    private System.Windows.Forms.Button btnUpload;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}