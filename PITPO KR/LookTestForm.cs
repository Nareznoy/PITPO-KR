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
  public partial class LookTestForm : Form
  {
    private const String COUNTER_FORMAT = "{0}/{1}";

    private Test _currentTest;
    private int _currentQuestIndex = -1;

    public LookTestForm()
    {
      InitializeComponent();
      cmbTestList.DataSource = AppInstance.tests;
    }

    private void loadTest(Test test)
    {
      _currentTest = test;
      _currentQuestIndex = 0;

      txtTestName.Text = test.testName;

      printQusetion(test.questions[_currentQuestIndex]);
    }

    private void printQusetion(Question question)
    {
      txtQuestText.Text = question.questionText;

      txtQ1.Text = question.answers[0];
      txtQ2.Text = question.answers[1];
      txtQ3.Text = question.answers[2];
      txtQ4.Text = question.answers[3];

      String rightAnswerChkName = "chkQ" + (question.rightAnswerIndex + 1);
      (Controls.Find(rightAnswerChkName, false).First() as CheckBox).Checked = true;

      lblCounter.Text = String.Format(COUNTER_FORMAT
        , _currentQuestIndex + 1
        , _currentTest.questions.Count);
    }

    private void cmbTestList_SelectionChangeCommitted(object sender, EventArgs e)
    {
      loadTest((Test)((sender as ComboBox).SelectedItem));
    }

    private void btnNextQuest_Click(object sender, EventArgs e)
    {
      printQusetion(_currentTest.questions[++_currentQuestIndex]);
    }

    private void btnPrevQuest_Click(object sender, EventArgs e)
    {
      printQusetion(_currentTest.questions[--_currentQuestIndex]);
    }
  }
}
