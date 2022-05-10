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

    public TeacherAccount(String userName, String userPassword) : base(userName, userPassword, UserType.Teacher)
    {

    }
  }
}
