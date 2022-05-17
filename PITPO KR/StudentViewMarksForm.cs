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
  public partial class StudentViewMarksForm : Form
  {
    public StudentViewMarksForm()
    {
      InitializeComponent();
      listBoxTests.DataSource = AppInstance.tests;
      updateView();
    }

    private void updateView()
    {
      Test currentTest = (Test)listBoxTests.SelectedItem;

      lblTestName.Text = currentTest.testName;
      lblTeacherName.Text = currentTest.testOwner.ToString();
      lblQuestNumber.Text = currentTest.questions.Count.ToString();

      ((StudentAccount) AppInstance.currentUser).progressByTests.TryGetValue(currentTest, out int rightAnswersNumber);
      lblRightAnswersNumber.Text = rightAnswersNumber.ToString();

      ((StudentAccount)AppInstance.currentUser).marksByTests.TryGetValue(currentTest, out int mark);
      lblMark.Text = mark.ToString();
    }

    private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateView();
    }
  }
}
