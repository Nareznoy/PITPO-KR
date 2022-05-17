using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PITPO_KR
{
  public partial class AuthForm : Form
  {
    public AuthForm()
    {
      InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      foreach (TeacherAccount teacher in AppInstance.teachers)
      {
        if (String.Equals(txtLogin.Text, teacher.userLogin)
          && String.Equals(txtPassword.Text, teacher.userPassword))
        {
          AppInstance.currentUser = teacher;
          AdminForm adminForm = new AdminForm();
          adminForm.Show();
          this.Hide();
          return;
        }
      }

      foreach (StudentAccount student in AppInstance.students)
      {
        if (String.Equals(txtLogin.Text, student.userLogin)
          && String.Equals(txtPassword.Text, student.userPassword))
        {
          AppInstance.currentUser = student;
          StudentForm studentForm = new StudentForm();
          studentForm.Show();
          this.Hide();
          return;
        }
      }

      MessageBox.Show("Неверный логин или пароль!");
    }
  }
}
