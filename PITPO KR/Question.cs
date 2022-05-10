using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITPO_KR
{
  internal class Question
  {
    public String questionText { get; set; }

    public List<String> answers { get; set; }

    public int rightAnswerIndex { get; set; }

    public Question(String questionText, List<String> answers, int rightAnswerIndex)
    {
      this.questionText = questionText;
      this.answers = answers;
      this.rightAnswerIndex = rightAnswerIndex;
    }
  }
}
