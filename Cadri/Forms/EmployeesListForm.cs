using Cadri.DataLayer.DataBase;
using Cadri.DataLayer.Repository;
using Cadri.UI.Forms;
using Microsoft.EntityFrameworkCore;

namespace Cadri.UI
{
    public partial class EmployeesListForm : Form
    {
        private EmployeeRepository employeeRepository = new();
        private OfficeRepository officeRepository = new();
        private EmployeeForm _employeeForm;
        
        public EmployeesListForm()
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.RowCount < 1) return;
                EditEmployee((Employee) dataGridView1.SelectedRows[0].DataBoundItem);
        }

        private async void Employ_Click(object sender, EventArgs e)
        {
            if (!(await officeRepository.CheckAnyOfficeAsync()))
            {
                MessageBox.Show("Невозможно устроить нового работника.\nНет подразделений.");
                return;
            }
            AddEmployee();
        }

        private void TransferEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("Некого переводить");
                return;
            }
            EditEmployee((Employee)dataGridView1.SelectedRows[0].DataBoundItem);
        }

        private async void Dismiss_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("Некого увольнять");
                return;
            }
            var employee = (Employee) dataGridView1.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Вы уверены, что хотите уволить {employee.FIO}", "Внимание",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await employeeRepository.DismissEmployeeAsync(employee);
            }
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

        private void Restore_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("Некого возвращать");
                return;
            }
            var employee = (Employee) dataGridView1.SelectedRows[0].DataBoundItem;
            if (employee.WorkNow)
            {
                MessageBox.Show("Сотрудник уже работает");
                return;
            }
            EditEmployee(employee);
        }
    }
}