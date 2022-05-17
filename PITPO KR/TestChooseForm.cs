using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace PITPO_KR
{
  public partial class TestChooseForm : Form
  {
    private const String COUNTER_FORMAT = "{0}/{1}";

    private int _currentQuestIndex = -1;
    private Test _currentTest;
    private Dictionary<Question, int> _answersByQuestions = new Dictionary<Question, int> ();

    public TestChooseForm()
    {
      InitializeComponent();
      cmbTestList.DataSource = AppInstance.tests;
      
    }

    private void loadTest(Test test)
    {
      _currentTest = test;
      _currentQuestIndex = 0;

      lblTestName.Text = test.testName;

      printQusetion(test.questions[_currentQuestIndex]);
    }

    private void printQusetion(Question question)
    {
      lblQuestName.Text = question.questionText;

      chkQ1.Text = question.answers[0];
      chkQ2.Text = question.answers[1];
      chkQ3.Text = question.answers[2];
      chkQ4.Text = question.answers[3];

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
      if ((sender as Button).Text == "Завершить тест")
      {
        int rightAnswersCount = 0;
        foreach (Question question in _answersByQuestions.Keys)
        {
          if (_answersByQuestions[question] == question.rightAnswerIndex)
          {
            rightAnswersCount++;
          }
        }

        try
        {
          ((StudentAccount) AppInstance.currentUser).progressByTests.Add(_currentTest, rightAnswersCount);
        }
        catch
        {
          MessageBox.Show("Тест уже пройден!!!!!!!!!!!!!!!!!!", "ОШИБКА");
        }
        
        return;
      }

      if (chkQ1.Checked)
      {
        _answersByQuestions.Add(_currentTest.questions[_currentQuestIndex], 0);
      }
      else if (chkQ2.Checked)
      {
        _answersByQuestions.Add(_currentTest.questions[_currentQuestIndex], 1);
      }
      else if (chkQ3.Checked)
      {
        _answersByQuestions.Add(_currentTest.questions[_currentQuestIndex], 2);
      }
      else if (chkQ4.Checked)
      {
        _answersByQuestions.Add(_currentTest.questions[_currentQuestIndex], 3);
      }

      printQusetion(_currentTest.questions[++_currentQuestIndex]);

      if (_currentQuestIndex == _currentTest.questions.Count - 1)
      {
        (sender as Button).Text = "Завершить тест";
      }
    }

    private void btnPrevQuest_Click(object sender, EventArgs e)
    {
      printQusetion(_currentTest.questions[--_currentQuestIndex]);
    }
  }
}
