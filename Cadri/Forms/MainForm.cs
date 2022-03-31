using Cadri.DataLayer.DataBase;
using Cadri.DataLayer.Repository;
using Cadri.UI.Forms;
using Microsoft.EntityFrameworkCore;

namespace Cadri.UI
{
    public partial class MainForm : Form
    {
        private EmployeeRepository employeeRepository = new();
        private EmployeeForm _employeeForm;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ReloadDataGridAsync();
        }

        private async Task ReloadDataGridAsync()
        {
            dataGridView1.DataSource = await employeeRepository.GetBindingEmployeesAsync();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            (new TreeViewForm()).ShowDialog();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditEmployee((Employee) dataGridView1.SelectedRows[0].DataBoundItem);
        }

        private void Employ_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void TransferEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee((Employee)dataGridView1.SelectedRows[0].DataBoundItem);
        }

        private async void Dismiss_Click(object sender, EventArgs e)
        {
            var employee = (Employee) dataGridView1.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Вы уверены, что хотите уволить {employee.FIO}", "Внимание",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await DismissEmployeeAsync(employee);
            }
        }

        private void Offices_Click(object sender, EventArgs e)
        {
            (new OfficesListForm()).ShowDialog();
        }
        public void AddEmployee()
        {
            if (_employeeForm == null || _employeeForm.IsDisposed)
                _employeeForm = new();
            _employeeForm.Disposed += async (s, e) => await ReloadDataGridAsync();
            _employeeForm.ShowDialog();
            _employeeForm.Focus();
        }

        public void EditEmployee(Employee employee)
        {
            if (_employeeForm == null || _employeeForm.IsDisposed)
                _employeeForm = new(true, employee);
            _employeeForm.Disposed += async (s, e) => await ReloadDataGridAsync();
            _employeeForm.ShowDialog();
            _employeeForm.Focus();
        }

        public async Task DismissEmployeeAsync(Employee employee)
        {
            await employeeRepository.DismissEmployeeAsync(employee);
        }
    }
}