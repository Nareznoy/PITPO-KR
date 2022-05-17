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
      AppInstance.students.Add(new StudentAccount("Denis", "0910", "Денис", "Северин", "220681"));
      AppInstance.students.Add(new StudentAccount("Grig", "0910", "Григорий", "Шмелев", "220682"));
      AppInstance.students.Add(new StudentAccount("Maria", "0910", "Мария", "Пахоменкова", "220681"));

      AppInstance.teachers.Add(new TeacherAccount("Admin", "admin", "Дмитрий", "Дроздов"));

      Test test1 = new Test("Математика", AppInstance.teachers[0]);
      test1.addQuestion(new Question("2+2", new List<string>() { "2", "4", "6", "8" }, 1 ));
      test1.addQuestion(new Question("Формула дискриминанта", new List<string>() { "a + b + c", "b^2-4ac", "b^2+4ac", "(a + b)^2" }, 1));
      AppInstance.tests.Add(test1);

      Test test2 = new Test("Геометрия", AppInstance.teachers[0]);
      test2.addQuestion(new Question("Квадрат гипотенузы равен сумме квадратов катета", new List<string>() { "Теорема Эйнштейна", "Теорема Гука", "Теорема Пифагора", "Теорема Ломоносова" }, 2));
      test2.addQuestion(new Question("Сумма углов треугольника", new List<string>() { "90", "60", "80", "180" }, 3));
      AppInstance.tests.Add(test2);

      AppInstance.students.First().progressByTests.Add(test1, 1);
      AppInstance.students.First().progressByTests.Add(test2, 2);

    }
  }
}
