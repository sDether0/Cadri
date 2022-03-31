namespace Cadri.UI
{
    partial class EmployeesListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOfficeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentOfficeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Infos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Employees = new System.Windows.Forms.ToolStripMenuItem();
            this.Employ = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.Dismiss = new System.Windows.Forms.ToolStripMenuItem();
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.thirdNameDataGridViewTextBoxColumn,
            this.WorkNow,
            this.dataGridViewTextBoxColumn1,
            this.CurrentOffice,
            this.CurrentOfficeId,
            this.CurrentOfficeName,
            this.Infos,
            this.FIO});
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // thirdNameDataGridViewTextBoxColumn
            // 
            this.thirdNameDataGridViewTextBoxColumn.DataPropertyName = "ThirdName";
            this.thirdNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.thirdNameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.thirdNameDataGridViewTextBoxColumn.Name = "thirdNameDataGridViewTextBoxColumn";
            this.thirdNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.thirdNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // WorkNow
            // 
            this.WorkNow.DataPropertyName = "WorkNowString";
            this.WorkNow.HeaderText = "Сейчас работает";
            this.WorkNow.MinimumWidth = 20;
            this.WorkNow.Name = "WorkNow";
            this.WorkNow.ReadOnly = true;
            this.WorkNow.Width = 160;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WorkNow";
            this.dataGridViewTextBoxColumn1.HeaderText = "WorkNow";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // CurrentOffice
            // 
            this.CurrentOffice.DataPropertyName = "CurrentOffice";
            this.CurrentOffice.HeaderText = "CurrentOffice";
            this.CurrentOffice.Name = "CurrentOffice";
            this.CurrentOffice.ReadOnly = true;
            this.CurrentOffice.Visible = false;
            // 
            // CurrentOfficeId
            // 
            this.CurrentOfficeId.DataPropertyName = "CurrentOfficeId";
            this.CurrentOfficeId.HeaderText = "CurrentOfficeId";
            this.CurrentOfficeId.Name = "CurrentOfficeId";
            this.CurrentOfficeId.ReadOnly = true;
            this.CurrentOfficeId.Visible = false;
            // 
            // CurrentOfficeName
            // 
            this.CurrentOfficeName.DataPropertyName = "CurrentOfficeName";
            this.CurrentOfficeName.HeaderText = "Текущее подразделение";
            this.CurrentOfficeName.MinimumWidth = 190;
            this.CurrentOfficeName.Name = "CurrentOfficeName";
            this.CurrentOfficeName.ReadOnly = true;
            this.CurrentOfficeName.Width = 190;
            // 
            // Infos
            // 
            this.Infos.DataPropertyName = "Infos";
            this.Infos.HeaderText = "Infos";
            this.Infos.Name = "Infos";
            this.Infos.ReadOnly = true;
            this.Infos.Visible = false;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "FIO";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список всех работников";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Employees});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Employees
            // 
            this.Employees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Employ,
            this.TransferEmployee,
            this.Dismiss,
            this.Restore});
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(85, 20);
            this.Employees.Text = "Сотрудники";
            // 
            // Employ
            // 
            this.Employ.Name = "Employ";
            this.Employ.Size = new System.Drawing.Size(269, 22);
            this.Employ.Text = "Устроить нового сотрудника";
            this.Employ.Click += new System.EventHandler(this.Employ_Click);
            // 
            // TransferEmployee
            // 
            this.TransferEmployee.Name = "TransferEmployee";
            this.TransferEmployee.Size = new System.Drawing.Size(269, 22);
            this.TransferEmployee.Text = "Перевести выбранного сотрудника";
            this.TransferEmployee.Click += new System.EventHandler(this.TransferEmployee_Click);
            // 
            // Dismiss
            // 
            this.Dismiss.Name = "Dismiss";
            this.Dismiss.Size = new System.Drawing.Size(269, 22);
            this.Dismiss.Text = "Уволить выбранного сотрудника";
            this.Dismiss.Click += new System.EventHandler(this.Dismiss_Click);
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(269, 22);
            this.Restore.Text = "Устроить уволенного сотрудника";
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesListForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn workNowDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn currentOfficeDataGridViewTextBoxColumn;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Employees;
        private ToolStripMenuItem Employ;
        private ToolStripMenuItem TransferEmployee;
        private ToolStripMenuItem Dismiss;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn WorkNow;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CurrentOffice;
        private DataGridViewTextBoxColumn CurrentOfficeId;
        private DataGridViewTextBoxColumn CurrentOfficeName;
        private DataGridViewTextBoxColumn Infos;
        private DataGridViewTextBoxColumn FIO;
        private ToolStripMenuItem Restore;
    }
}