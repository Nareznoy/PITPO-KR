using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITPO_KR
{
  internal class StudentAccount : UserAccount
  {
    public Dictionary<Test, int> marksByTests { get; set; }

    public Dictionary<Test, int> progressByTests { get; set; }

    public List<TeacherAccount> teachers { get; set; }

    public String group { get; set; }

    public StudentAccount(String userLogin, String userPassword, String userName, String userSecondName, String group) : base(userLogin, userPassword, userName, userSecondName, UserType.Student)
    {
      marksByTests = new Dictionary<Test, int>();
      progressByTests = new Dictionary<Test, int>();
      teachers = new List<TeacherAccount>();
      this.group = group;
    }

    public override string ToString()
    {
      return userName + " " + userSecondName + " " + "Группа: " + group;
    }
  }
}
