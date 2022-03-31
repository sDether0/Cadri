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

namespace Cadri.UI.Forms
{
    public partial class OfficeForm : Form
    {
        private OfficeRepository officeRepository = new();
        private Office? office;
        private bool edit;
        private bool main;
        public OfficeForm(bool edit = false, Office? editOffice = null)
        {
            InitializeComponent();
            Subscribe();
            office = editOffice??new();
            main = office.ParentId==null;
            this.edit = edit;
            AddOffice.Visible = !edit;
            EditOffice.Visible = edit;
            Binding();
        }

        private async Task OfficeForm_LoadAsync(object sender, EventArgs e)
        {
            parentOffice_cb.DataSource = (await officeRepository.GetBindingOfficesAsync()).Where(x=>x.Id!=office.Id && !x.Closed).ToList();
            parentOffice_cb.DisplayMember = nameof(Office.Name);
            parentOffice_cb.ValueMember = nameof(Office.Id);
        }

        private void Binding()
        {
            name_tb.DataBindings.Add(nameof(TextBox.Text), office, nameof(Office.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            description_tb.DataBindings.Add(nameof(TextBox.Text), office, nameof(Office.Description), true, DataSourceUpdateMode.OnPropertyChanged);
            parentOffice_cb.DataBindings.Add(nameof(ComboBox.SelectedValue), office, nameof(Office.ParentId), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void Subscribe()
        {
            Load += async(s,e)=> await OfficeForm_LoadAsync(s,e);
            AddOffice.Click += async(s,e)=> await AddOffice_ClickAsync(s,e);
            EditOffice.Click += async(s,e)=>await EditOffice_ClickAsync(s,e);
        }

        private async Task AddOffice_ClickAsync(object sender, EventArgs e)
        {
            await officeRepository.AddOfficeAsync(office);
            Close();
        }

        private void OfficeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private async Task EditOffice_ClickAsync(object sender, EventArgs e)
        {
            if (main)
                office.ParentId = null;
            await officeRepository.UpdateOfficeAsync(office);
            Close();
        }
    }
}
