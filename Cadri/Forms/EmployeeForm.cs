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
        private bool _edit;
        private Employee employee;
        private EmployeeRepository employeeRepository = new ();
        private OfficeRepository officeRepository = new ();
        public EmployeeForm(bool edit = false, Employee? editEmployee = null)
        {
            InitializeComponent();
            Subscribe();
            employee = editEmployee??new();
            SetFields(edit);
            Binding();
        }

        private void SetFields(bool edit)
        {
            _edit = edit;
            firstname_tb.Enabled = !edit;
            lastname_tb.Enabled = !edit;
            thirdname_tb.Enabled = !edit;
            Submit_bt.Text = edit&&employee.WorkNow ? "Перевести" : "Устроить";
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
            Load += async (s, e) => await AddEmployeeForm_LoadAsync(s, e);
            Submit_bt.Click += async (s, e) => await Employ_ClickAsync(s, e);
        }

        private async Task Employ_ClickAsync(object sender, EventArgs e)
        {
            if (!_edit)
            {
                bool error = false;
                error = CheckValid(error);
                if (error) return;
                await employeeRepository.CreateEmployeeAsync(employee);
            }
            else
            {
                if (employee.WorkNow)
                {
                    await employeeRepository.TransferEmployeeAsync(employee);
                }
                else
                {
                    await employeeRepository.RestoreEmployeeAsync(employee);
                }
            }
            Close();
        }

        private bool CheckValid(bool error)
        {
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

            return error;
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
        
    }
}
