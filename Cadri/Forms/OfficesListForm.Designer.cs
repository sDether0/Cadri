namespace Cadri.UI.Forms
{
    partial class OfficesListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.officesGridView = new System.Windows.Forms.DataGridView();
            this.OfficeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Closed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentOfficeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChildOffices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentOfficeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Offices = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.EditOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.employees_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.officesGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // officesGridView
            // 
            this.officesGridView.AllowUserToAddRows = false;
            this.officesGridView.AllowUserToDeleteRows = false;
            this.officesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.officesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.officesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfficeId,
            this.Closed,
            this.ParentOfficeId,
            this.ParentOffice,
            this.ChildOffices,
            this.OfficeName,
            this.OfficeDescription,
            this.ParentOfficeName,
            this.IsClosed});
            this.officesGridView.GridColor = System.Drawing.SystemColors.Control;
            this.officesGridView.Location = new System.Drawing.Point(0, 85);
            this.officesGridView.MultiSelect = false;
            this.officesGridView.Name = "officesGridView";
            this.officesGridView.ReadOnly = true;
            this.officesGridView.RowTemplate.Height = 25;
            this.officesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.officesGridView.Size = new System.Drawing.Size(838, 483);
            this.officesGridView.TabIndex = 0;
            // 
            // OfficeId
            // 
            this.OfficeId.DataPropertyName = "Id";
            this.OfficeId.HeaderText = "Id";
            this.OfficeId.Name = "OfficeId";
            this.OfficeId.ReadOnly = true;
            this.OfficeId.Visible = false;
            // 
            // Closed
            // 
            this.Closed.DataPropertyName = "Closed";
            this.Closed.HeaderText = "Closed";
            this.Closed.Name = "Closed";
            this.Closed.ReadOnly = true;
            this.Closed.Visible = false;
            // 
            // ParentOfficeId
            // 
            this.ParentOfficeId.DataPropertyName = "ParentId";
            this.ParentOfficeId.HeaderText = "ParentId";
            this.ParentOfficeId.Name = "ParentOfficeId";
            this.ParentOfficeId.ReadOnly = true;
            this.ParentOfficeId.Visible = false;
            // 
            // ParentOffice
            // 
            this.ParentOffice.DataPropertyName = "ParentOffice";
            this.ParentOffice.HeaderText = "ParentOffice";
            this.ParentOffice.Name = "ParentOffice";
            this.ParentOffice.ReadOnly = true;
            this.ParentOffice.Visible = false;
            // 
            // ChildOffices
            // 
            this.ChildOffices.DataPropertyName = "ChildOffices";
            this.ChildOffices.HeaderText = "ChildOffices";
            this.ChildOffices.Name = "ChildOffices";
            this.ChildOffices.ReadOnly = true;
            this.ChildOffices.Visible = false;
            // 
            // OfficeName
            // 
            this.OfficeName.DataPropertyName = "Name";
            this.OfficeName.HeaderText = "Название";
            this.OfficeName.MinimumWidth = 130;
            this.OfficeName.Name = "OfficeName";
            this.OfficeName.ReadOnly = true;
            this.OfficeName.Width = 130;
            // 
            // OfficeDescription
            // 
            this.OfficeDescription.DataPropertyName = "Description";
            this.OfficeDescription.HeaderText = "Описание";
            this.OfficeDescription.MinimumWidth = 360;
            this.OfficeDescription.Name = "OfficeDescription";
            this.OfficeDescription.ReadOnly = true;
            this.OfficeDescription.Width = 360;
            // 
            // ParentOfficeName
            // 
            this.ParentOfficeName.DataPropertyName = "ParentOfficeName";
            this.ParentOfficeName.HeaderText = "Управляющее подразделение";
            this.ParentOfficeName.MinimumWidth = 202;
            this.ParentOfficeName.Name = "ParentOfficeName";
            this.ParentOfficeName.ReadOnly = true;
            this.ParentOfficeName.Width = 202;
            // 
            // IsClosed
            // 
            this.IsClosed.DataPropertyName = "IsClosed";
            this.IsClosed.HeaderText = "Состояние";
            this.IsClosed.Name = "IsClosed";
            this.IsClosed.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Offices});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1321, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Offices
            // 
            this.Offices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOffice,
            this.EditOffice,
            this.CloseOffice,
            this.RestoreOffice});
            this.Offices.Name = "Offices";
            this.Offices.Size = new System.Drawing.Size(104, 20);
            this.Offices.Text = "Подразделения";
            // 
            // AddOffice
            // 
            this.AddOffice.Name = "AddOffice";
            this.AddOffice.Size = new System.Drawing.Size(235, 22);
            this.AddOffice.Text = "Добавить подразделение";
            this.AddOffice.Click += new System.EventHandler(this.AddOffice_Click);
            // 
            // EditOffice
            // 
            this.EditOffice.Name = "EditOffice";
            this.EditOffice.Size = new System.Drawing.Size(235, 22);
            this.EditOffice.Text = "Изменить подразделение";
            // 
            // CloseOfficeAsync
            // 
            this.CloseOffice.Name = "CloseOffice";
            this.CloseOffice.Size = new System.Drawing.Size(235, 22);
            this.CloseOffice.Text = "Закрыть подразделение";
            // 
            // RestoreOfficeAsync
            // 
            this.RestoreOffice.Name = "RestoreOffice";
            this.RestoreOffice.Size = new System.Drawing.Size(235, 22);
            this.RestoreOffice.Text = "Восстановить подразделение";
            // 
            // employees_listbox
            // 
            this.employees_listbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employees_listbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employees_listbox.FormattingEnabled = true;
            this.employees_listbox.ItemHeight = 20;
            this.employees_listbox.Location = new System.Drawing.Point(844, 84);
            this.employees_listbox.Name = "employees_listbox";
            this.employees_listbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.employees_listbox.Size = new System.Drawing.Size(470, 484);
            this.employees_listbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список всех подразделений";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "";
            this.fromDatePicker.Location = new System.Drawing.Point(638, 53);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 23);
            this.fromDatePicker.TabIndex = 4;
            this.fromDatePicker.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "";
            this.toDatePicker.Location = new System.Drawing.Point(878, 53);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 23);
            this.toDatePicker.TabIndex = 5;
            this.toDatePicker.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(610, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(844, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "До";
            // 
            // OfficesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employees_listbox);
            this.Controls.Add(this.officesGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OfficesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficesListForm";
            ((System.ComponentModel.ISupportInitialize)(this.officesGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView officesGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Offices;
        private ToolStripMenuItem AddOffice;
        private ToolStripMenuItem EditOffice;
        private ListBox employees_listbox;
        private Label label1;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem CloseOffice;
        private DataGridViewTextBoxColumn OfficeId;
        private DataGridViewTextBoxColumn Closed;
        private DataGridViewTextBoxColumn ParentOfficeId;
        private DataGridViewTextBoxColumn ParentOffice;
        private DataGridViewTextBoxColumn ChildOffices;
        private DataGridViewTextBoxColumn OfficeName;
        private DataGridViewTextBoxColumn OfficeDescription;
        private DataGridViewTextBoxColumn ParentOfficeName;
        private DataGridViewTextBoxColumn IsClosed;
        private ToolStripMenuItem RestoreOffice;
    }
}