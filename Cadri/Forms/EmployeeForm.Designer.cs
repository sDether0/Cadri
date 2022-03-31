namespace Cadri.UI.Forms
{
    partial class EmployeeForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstname_tb = new System.Windows.Forms.TextBox();
            this.lastname_tb = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.thirdname_tb = new System.Windows.Forms.TextBox();
            this.thirdNameLabel = new System.Windows.Forms.Label();
            this.office_cm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(31, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Имя";
            // 
            // firstname_tb
            // 
            this.firstname_tb.Location = new System.Drawing.Point(76, 44);
            this.firstname_tb.Name = "firstname_tb";
            this.firstname_tb.Size = new System.Drawing.Size(100, 23);
            this.firstname_tb.TabIndex = 3;
            // 
            // lastname_tb
            // 
            this.lastname_tb.Location = new System.Drawing.Point(76, 15);
            this.lastname_tb.Name = "lastname_tb";
            this.lastname_tb.Size = new System.Drawing.Size(100, 23);
            this.lastname_tb.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 18);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 15);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // thirdname_tb
            // 
            this.thirdname_tb.Location = new System.Drawing.Point(76, 73);
            this.thirdname_tb.Name = "thirdname_tb";
            this.thirdname_tb.Size = new System.Drawing.Size(100, 23);
            this.thirdname_tb.TabIndex = 5;
            // 
            // thirdNameLabel
            // 
            this.thirdNameLabel.AutoSize = true;
            this.thirdNameLabel.Location = new System.Drawing.Point(12, 76);
            this.thirdNameLabel.Name = "thirdNameLabel";
            this.thirdNameLabel.Size = new System.Drawing.Size(58, 15);
            this.thirdNameLabel.TabIndex = 4;
            this.thirdNameLabel.Text = "Отчество";
            // 
            // office_cm
            // 
            this.office_cm.FormattingEnabled = true;
            this.office_cm.Location = new System.Drawing.Point(294, 15);
            this.office_cm.Name = "office_cm";
            this.office_cm.Size = new System.Drawing.Size(121, 23);
            this.office_cm.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Подразделение";
            // 
            // Submit_bt
            // 
            this.Submit_bt.Location = new System.Drawing.Point(331, 73);
            this.Submit_bt.Name = "Submit_bt";
            this.Submit_bt.Size = new System.Drawing.Size(82, 23);
            this.Submit_bt.TabIndex = 8;
            this.Submit_bt.Text = "Устроить";
            this.Submit_bt.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 120);
            this.Controls.Add(this.Submit_bt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.office_cm);
            this.Controls.Add(this.thirdname_tb);
            this.Controls.Add(this.thirdNameLabel);
            this.Controls.Add(this.lastname_tb);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstname_tb);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о сотруднике";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEmployeeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstname_tb;
        private TextBox lastname_tb;
        private Label lastNameLabel;
        private TextBox thirdname_tb;
        private Label thirdNameLabel;
        private ComboBox office_cm;
        private Label label4;
        private Button Submit_bt;
    }
}