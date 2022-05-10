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

    public StudentAccount(String userName, String userPassword) : base(userName, userPassword, UserType.Student)
    {

    }
  }
}
