using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadri.DataLayer.DataBase;
using Cadri.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cadri.UI.Forms
{
    public partial class EmployeeForm : Form
    {
        private bool edit;
        private Employee employee;
        private EmployeeRepository employeeRepository = new ();
        private OfficeRepository officeRepository = new ();
        public EmployeeForm(bool edit = false, Employee? editEmployee = null)
        {
            InitializeComponent();
            Subscribe();
            firstname_tb.Enabled = !edit;
            lastname_tb.Enabled = !edit;
            thirdname_tb.Enabled = !edit;
            Employ.Visible = !edit;
            Transfer.Visible = edit;
            employee = editEmployee??new();
            Binding();
        }

        public void Binding()
        {
            firstname_tb.DataBindings.Add(nameof(TextBox.Text), employee, nameof(Employee.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);
            lastname_tb.DataBindings.Add(nameof(TextBox.Text), employee, nameof(Employee.LastName), true, DataSourceUpdateMode.OnPropertyChanged);
            thirdname_tb.DataBindings.Add(nameof(TextBox.Text), employee, nameof(Employee.ThirdName), true, DataSourceUpdateMode.OnPropertyChanged);
            office_cm.DataBindings.Add(nameof(ComboBox.SelectedValue), employee, nameof(Employee.CurrentOfficeId), true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Subscribe()
        {
            Transfer.Click += async (s, e) => await Transfer_ClickAsync(s, e);
            Load += async (s, e) => await AddEmployeeForm_LoadAsync(s, e);
            Employ.Click += async (s, e) => await Employ_ClickAsync(s, e);
        }

        private async Task Employ_ClickAsync(object sender, EventArgs e)
        {
            bool error = false;
            if (string.IsNullOrWhiteSpace(firstname_tb.Text))
            {
                error = true;
                firstNameLabel.ForeColor = Color.Red;
            }
            else
            {
                firstNameLabel.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(lastname_tb.Text))
            {
                error = true;
                lastNameLabel.ForeColor = Color.Red;
            }
            else
            {
                lastNameLabel.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(thirdname_tb.Text))
            {
                error = true;
                thirdNameLabel.ForeColor = Color.Red;
            }
            else
            {
                thirdNameLabel.ForeColor = Color.Black;
            }
            if (error)
            {
                return;
            }
            await employeeRepository.CreateEmployee(employee);
            Close();
            
        }

        private async Task AddEmployeeForm_LoadAsync(object sender, EventArgs e)
        {
            office_cm.DataSource = (await officeRepository.GetBindingOfficesAsync()).Where(x=>!x.Closed).ToList();
            office_cm.DisplayMember = nameof(Office.Name);
            office_cm.ValueMember = nameof(Office.Id);
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private async Task Transfer_ClickAsync(object sender, EventArgs e)
        {
            await employeeRepository.TransferEmployeeAsync(employee);
            Close();
        }
    }
}
