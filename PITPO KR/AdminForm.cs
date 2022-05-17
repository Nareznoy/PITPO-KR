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
  public partial class AdminForm : Form
  {
    public AdminForm()
    {
      InitializeComponent();
    }

    private void btnAddTest_Click(object sender, EventArgs e)
    {
      AddTestForm addTestForm = new AddTestForm();
      addTestForm.ShowDialog();
    }

    private void btnAddMark_Click(object sender, EventArgs e)
    {
      AddMarksForm addMarksForm = new AddMarksForm();
      addMarksForm.Show();
    }

    private void btnLookTests_Click(object sender, EventArgs e)
    {
      LookTestForm lookTestForm = new LookTestForm();
      lookTestForm.Show();
    }
  }
}
