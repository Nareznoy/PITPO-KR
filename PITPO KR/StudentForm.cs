using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PITPO_KR
{
  public partial class StudentForm : Form
  {
    public StudentForm()
    {
      InitializeComponent();

      
    }

    private void btnTests_Click(object sender, EventArgs e)
    {
      TestChooseForm testChooseForm = new TestChooseForm();
      testChooseForm.ShowDialog();
    }

    private void btnMyMarks_Click(object sender, EventArgs e)
    {
      StudentViewMarksForm studentViewMarksForm = new StudentViewMarksForm();
      studentViewMarksForm.Show();
    }

    private void btnModules_Click(object sender, EventArgs e)
    {
      Oleg oleg = new Oleg();
      oleg.ShowDialog();
    }
  }
}
