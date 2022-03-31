namespace Cadri.UI.Forms
{
    partial class MainForm
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
            this.EmployeesList_bt = new System.Windows.Forms.Button();
            this.OfficesList_bt = new System.Windows.Forms.Button();
            this.CompanyTree_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesList_bt
            // 
            this.EmployeesList_bt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeesList_bt.Location = new System.Drawing.Point(12, 12);
            this.EmployeesList_bt.Name = "EmployeesList_bt";
            this.EmployeesList_bt.Size = new System.Drawing.Size(274, 69);
            this.EmployeesList_bt.TabIndex = 0;
            this.EmployeesList_bt.Text = "Список сотрудников";
            this.EmployeesList_bt.UseVisualStyleBackColor = true;
            this.EmployeesList_bt.Click += new System.EventHandler(this.EmployeesList_bt_Click);
            // 
            // OfficesList_bt
            // 
            this.OfficesList_bt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OfficesList_bt.Location = new System.Drawing.Point(12, 87);
            this.OfficesList_bt.Name = "OfficesList_bt";
            this.OfficesList_bt.Size = new System.Drawing.Size(274, 69);
            this.OfficesList_bt.TabIndex = 1;
            this.OfficesList_bt.Text = "Список подразделений";
            this.OfficesList_bt.UseVisualStyleBackColor = true;
            this.OfficesList_bt.Click += new System.EventHandler(this.OfficesList_bt_Click);
            // 
            // CompanyTree_bt
            // 
            this.CompanyTree_bt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompanyTree_bt.Location = new System.Drawing.Point(12, 162);
            this.CompanyTree_bt.Name = "CompanyTree_bt";
            this.CompanyTree_bt.Size = new System.Drawing.Size(274, 69);
            this.CompanyTree_bt.TabIndex = 2;
            this.CompanyTree_bt.Text = "\"Дерево\" компании";
            this.CompanyTree_bt.UseVisualStyleBackColor = true;
            this.CompanyTree_bt.Click += new System.EventHandler(this.CompanyTree_bt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 253);
            this.Controls.Add(this.CompanyTree_bt);
            this.Controls.Add(this.OfficesList_bt);
            this.Controls.Add(this.EmployeesList_bt);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button EmployeesList_bt;
        private Button OfficesList_bt;
        private Button CompanyTree_bt;
    }
}