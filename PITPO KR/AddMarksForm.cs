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
  public partial class AddMarksForm : Form
  {
    public AddMarksForm()
    {
      InitializeComponent();
      listBoxStudents.DataSource = AppInstance.students;
      listBoxTests.DataSource = AppInstance.tests;
      updateView();
    }

    private void updateView()
    {
      StudentAccount student = (StudentAccount)listBoxStudents.SelectedItem;
      lblGroup.Text = student.group;

      Test test = (Test) listBoxTests.SelectedItem;
      lblTestName.Text = test.testName;
      lblQuestNumbers.Text = test.questions.Count.ToString();

      lblRightAnswers.Text = student.progressByTests.TryGetValue(test, out int progress) 
        ? progress.ToString() 
        : "Не пройден";
    }

    private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateView();
    }

    private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateView();
    }

    private void btnPutMark_Click(object sender, EventArgs e)
    {
      StudentAccount student = (StudentAccount)listBoxStudents.SelectedItem;
      Test test = (Test)listBoxTests.SelectedItem;

      student.marksByTests[test] = int.Parse(txtMark.Text);
    }
  }
}
