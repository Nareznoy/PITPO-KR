using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITPO_KR
{
  internal class TeacherAccount : UserAccount
  {
    public List<Test> tests { get; set; }

    public List<StudentAccount> students { get; set; }

    public TeacherAccount(String userLogin, String userPassword, String userName, String userSecondName) : base(userLogin, userPassword, userName, userSecondName,UserType.Teacher)
    {

    }


    public override string ToString()
    {
      return "Преподаватель: " + userName + " " + userSecondName + " ";
    }
  }
}
