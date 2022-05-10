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
  }
}
