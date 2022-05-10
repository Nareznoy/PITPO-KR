using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITPO_KR
{
  static internal class AppInstance
  {
    static public UserAccount currentUser;

    static public List<Test> tests = new List<Test>();

    static public List<TeacherAccount> teachers = new List<TeacherAccount>();

    static public List<StudentAccount> students = new List<StudentAccount>();
  }
}
