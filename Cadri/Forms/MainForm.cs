using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadri.UI.Forms
{
    public partial class MainForm : Form
    {
        EmployeesListForm employeesListForm ;
        OfficesListForm officesListForm ;
        TreeViewForm treeViewForm ;
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmployeesList_bt_Click(object sender, EventArgs e)
        {
            if (employeesListForm == null || employeesListForm.IsDisposed)
            {
                employeesListForm = new();
            }
            employeesListForm.Show();
            employeesListForm.Focus();
        }

        private void OfficesList_bt_Click(object sender, EventArgs e)
        {
            if (officesListForm == null || officesListForm.IsDisposed)
            {
                officesListForm = new();
            }
            officesListForm.Show();
            officesListForm.Focus();
        }

        private void CompanyTree_bt_Click(object sender, EventArgs e)
        {
            if (treeViewForm == null || treeViewForm.IsDisposed)
            {
                treeViewForm = new();
            }
            treeViewForm.Show();
            treeViewForm.Focus();
        }
    }
}
