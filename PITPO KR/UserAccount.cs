using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITPO_KR
{
  enum UserType
  {
    Student,
    Teacher
  }

  internal class UserAccount
  {
    public String userName { get; set; }

    public String userPassword { get; set; }

    public UserType userType { get; set; }

    public UserAccount(String userName, String userPassword, UserType userType)
    {
      this.userName = userName;
      this.userPassword = userPassword;
      this.userType = userType;
    }
  }
}
