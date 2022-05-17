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

    public String userSecondName { get; set; }

    public String userLogin { get; set; }

    public String userPassword { get; set; }

    public UserType userType { get; set; }

    public UserAccount(String userLogin, String userPassword, String userName, String userSecondName, UserType userType)
    {
      this.userLogin = userLogin;
      this.userPassword = userPassword;
      this.userName = userName;
      this.userSecondName = userSecondName;
      this.userType = userType;
    }
  }
}
