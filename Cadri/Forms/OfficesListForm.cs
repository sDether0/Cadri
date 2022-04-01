using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadri.DataLayer.DataBase;
using Cadri.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cadri.UI.Forms
{
    public partial class OfficesListForm : Form
    {
        private OfficeRepository officeRepository = new();
        private EmployeeRepository employeeRepository = new();
        private OfficeForm officeForm;
        private DateRange dateRange = new();

        public OfficesListForm()
        {
            InitializeComponent();
            Subscribe();
            Binding();
            employees_listbox.DisplayMember = nameof(Employee.FIO);
        }

        private void Binding()
        {
            fromDatePicker.MaxDate = DateTime.Today;
            toDatePicker.MaxDate = DateTime.Today;
            fromDatePicker.DataBindings.Add(nameof(DateTimePicker.Value), dateRange, nameof(DateRange.FromDate), true,
                DataSourceUpdateMode.OnPropertyChanged);
            fromDatePicker.DataBindings.Add(nameof(DateTimePicker.MaxDate), dateRange, nameof(DateRange.ToDate), true,
                DataSourceUpdateMode.OnPropertyChanged);
            toDatePicker.DataBindings.Add(nameof(DateTimePicker.MinDate), dateRange, nameof(DateRange.FromDate), true,
                DataSourceUpdateMode.OnPropertyChanged);
            toDatePicker.DataBindings.Add(nameof(DateTimePicker.Value), dateRange, nameof(DateRange.ToDate), true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Subscribe()
        {
            EditOffice.Click += async (s, e) => await EditOffice_ClickAsync(s, e);
            Load += async (s, e) => await Offices_LoadAsync(s, e);
            CloseOffice.Click += async (s, e) => await CloseOffice_Click(s,e);
            RestoreOffice.Click += async (s, e) => await RestoreOffice_ClickAsync(s,e);
            officesGridView.SelectionChanged += async (s, e) => await FilterChangedAsync();
            fromDatePicker.ValueChanged += async (s, e) => await FilterChangedAsync();
            toDatePicker.ValueChanged+= async(s, e) => await FilterChangedAsync();
        }


        private async Task Offices_LoadAsync(object sender, EventArgs e)
        {
            await ReloadDataGridAsync();
        }

        private void AddOffice_Click(object sender, EventArgs e)
        {
            if (officesGridView.RowCount < 1)
                MessageBox.Show("Первым подразделением должно быть главное руководство", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (officeForm == null || officeForm.IsDisposed)
            {
                officeForm = new OfficeForm();
            }
            officeForm.Disposed += async (s, e) => await ReloadDataGridAsync();
            officeForm.ShowDialog();
            officeForm.Focus();
        }

        private async Task ReloadDataGridAsync()
        {
            officesGridView.DataSource = await officeRepository.GetBindingOfficesAsync();
        }

        private async Task EditOffice_ClickAsync(object sender, EventArgs e)
        {
            if (officesGridView.RowCount < 1)
            {
                MessageBox.Show("Отсутствуют подразделения для редактирования");
                return;
            }
            if (officeForm == null || officeForm.IsDisposed)
            {
                officeForm = new OfficeForm(true, (Office) officesGridView.SelectedRows[0].DataBoundItem);
            }

            officeForm.Disposed += async (s, e) => await ReloadDataGridAsync();
            officeForm.ShowDialog();
            officeForm.Focus();
        }

        private async Task FilterChangedAsync()
        {
            if (officesGridView.SelectedRows.Count < 1) return;
            await FilterEmployeesListAsync();
        }
        

        private async Task FilterEmployeesListAsync()
        {
            var office = (Office) officesGridView.SelectedRows[0].DataBoundItem;
            List<Employee> result = new();
            if (office != null)
            {
                if (dateRange.FromDate == DateTime.Today)
                {
                    result= await employeeRepository.GetEmployeeByOfficeAsync(office);
                }
                else
                {
                    if (dateRange.ToDate == DateTime.Today)
                    {
                        result= await employeeRepository.GetEmployeeByOfficeAndDateAsync(office,dateRange.fromDate);
                    }
                    else
                    {
                        result= await employeeRepository.GetEmployeeByOfficeAndDateAsync(office,dateRange.fromDate, dateRange.toDate);
                    }
                }

                employees_listbox.DataSource = result;
            }
        }

        private async Task CloseOffice_Click(object sender, EventArgs e)
        {
            if (officesGridView.RowCount < 1)
            {
                MessageBox.Show("Отсутствуют подразделения для закрытия");
                return;
            }
            try
            {
                await officeRepository.CloseOfficeAsync((Office) officesGridView.SelectedRows[0].DataBoundItem);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private async Task RestoreOffice_ClickAsync(object sender, EventArgs e)
        {
            if (officesGridView.RowCount < 1)
            {
                MessageBox.Show("Отсутствуют подразделения для восстановления работы");
                return;
            }
            var office = (Office) officesGridView.SelectedRows[0].DataBoundItem;
            if (office.Closed)
                await officeRepository.RestoreOfficeAsync(office);
            else
            {
                MessageBox.Show("Подразделение не закрыто и не нуждается в восстановлении.");
            }
        }
    }

    public class DateRange
    {
        public DateOnly fromDate = DateOnly.FromDateTime(DateTime.Today);
        public DateOnly toDate = DateOnly.FromDateTime(DateTime.Today);

        public DateTime FromDate
        {
            get => fromDate.ToDateTime(TimeOnly.Parse("00:00")); 
            set => fromDate = DateOnly.FromDateTime(value);
        }
        public DateTime ToDate
        {
            get => toDate.ToDateTime(TimeOnly.Parse("00:00")); 
            set => toDate = DateOnly.FromDateTime(value); 
        }
    }
}
