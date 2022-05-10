using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITPO_KR
{
  internal class Test
  {
    public String testName { get; set; }

    public TeacherAccount testOwner { get; set; }

    public List<Question> answersByQuestions { get; set; }

    public Test(String testName, TeacherAccount testOwner)
    {
      this.testName = testName;
      this.testOwner = testOwner;
      answersByQuestions = new List<Question>();
    }

    public void addQuestion(Question question)
    {
      answersByQuestions.Add(question);
    }
  }
}
