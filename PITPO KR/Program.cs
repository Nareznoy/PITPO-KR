using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PITPO_KR
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      InitStartAppInstance();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new AuthForm());
    }

    static void InitStartAppInstance()
    {
      AppInstance.students.Add(new StudentAccount("Denis", "0910"));
      AppInstance.teachers.Add(new TeacherAccount("Admin", "admin"));

      Test test = new Test("Викторина автомобильная", AppInstance.teachers[0]);
      test.addQuestion("");
      AppInstance.tests.Add();

    }
  }
}
