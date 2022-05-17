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

    public List<Question> questions { get; set; }

    public Test(String testName, TeacherAccount testOwner)
    {
      this.testName = testName;
      this.testOwner = testOwner;
      questions = new List<Question>();
    }

    public void addQuestion(Question question)
    {
      questions.Add(question);
    }

    public override string ToString()
    {
      return testName + ". " + testOwner;
    }
  }
}
