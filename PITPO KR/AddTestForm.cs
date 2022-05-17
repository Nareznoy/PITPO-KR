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
  public partial class AddTestForm : Form
  {
    public AddTestForm()
    {
      InitializeComponent();
    }

    private void btnAddQuest_Click(object sender, EventArgs e)
    {
      Test currentTest = AppInstance.tests.Find(test => test.testName == textTestName.Text);

      List<String> answers = new List<String>();
      answers.Add(textQ1.Text);
      answers.Add(textQ2.Text);
      answers.Add(textQ3.Text);
      answers.Add(textQ4.Text);

      int rightAnswer = 0;
      if (chkQ1.Checked)
      {
        rightAnswer = 1;
      }
      else if (chkQ2.Checked)
      {
        rightAnswer = 2;
      }
      else if (chkQ3.Checked)
      {
        rightAnswer = 3;
      }
      else if (chkQ4.Checked)
      {
        rightAnswer = 4;
      }

      Question question = new Question(textQuestText.Text, answers, rightAnswer);
      currentTest.addQuestion(question);

      textQuestText.Text = "";
      chkQ1.Checked = false;
      chkQ2.Checked = false;
      chkQ3.Checked = false;
      chkQ4.Checked = false;
      textQ1.Text = "";
      textQ2.Text = "";
      textQ3.Text = "";
      textQ4.Text = "";

      lblHint.Text = "Вопрос добавлен!";
    }

    private void btnAddTest_Click(object sender, EventArgs e)
    {
      AppInstance.tests.Add(new Test(textTestName.Text, (TeacherAccount)AppInstance.currentUser));
      lblHint.Text = "Тест добавлен!";
    }

    private void textQ3_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
