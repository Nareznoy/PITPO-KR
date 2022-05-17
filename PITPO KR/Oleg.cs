using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PITPO_KR
{
  public partial class Oleg : Form
  {
    private const String DIRECTORY_PATH = "Методические материалы";

    public Oleg()
    {
      InitializeComponent();
      renderFiles();
    }

    private void renderFiles()
    {
      listBoxFiles.DataSource = Directory.GetFiles(DIRECTORY_PATH);
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
      //FileStream myStream = File.Open(listBoxFiles.SelectedItem.ToString(), FileMode.Open);

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        File.Copy(listBoxFiles.SelectedItem.ToString(), saveFileDialog1.FileName);
        //saveStreamAsFile(saveFileDialog1.FileName, myStream, myStream.Name);
      }
    }

    private void saveStreamAsFile(string filePath, Stream inputStream, string fileName)
    {
      DirectoryInfo info = new DirectoryInfo(filePath);
      if (!info.Exists)
      {
        info.Create();
      }

      string path = Path.Combine(filePath, fileName);
      using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
      {
        inputStream.CopyTo(outputFileStream);
      }
    }

    private void btnUpload_Click(object sender, EventArgs e)
    {

    }
  }
}
