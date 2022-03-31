namespace Cadri.UI.Forms
{
    partial class OfficeForm
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
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parentOffice_cb = new System.Windows.Forms.ComboBox();
            this.AddOffice = new System.Windows.Forms.Button();
            this.EditOffice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(12, 35);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(192, 23);
            this.name_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название подразделения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание подразделения";
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(12, 93);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(490, 129);
            this.description_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Головное подразделение";
            // 
            // parentOffice_cb
            // 
            this.parentOffice_cb.FormattingEnabled = true;
            this.parentOffice_cb.Location = new System.Drawing.Point(310, 35);
            this.parentOffice_cb.Name = "parentOffice_cb";
            this.parentOffice_cb.Size = new System.Drawing.Size(192, 23);
            this.parentOffice_cb.TabIndex = 5;
            // 
            // AddOffice
            // 
            this.AddOffice.Location = new System.Drawing.Point(310, 228);
            this.AddOffice.Name = "AddOffice";
            this.AddOffice.Size = new System.Drawing.Size(192, 23);
            this.AddOffice.TabIndex = 6;
            this.AddOffice.Text = "Добавить подразделение";
            this.AddOffice.UseVisualStyleBackColor = true;
            // 
            // EditOffice
            // 
            this.EditOffice.Location = new System.Drawing.Point(310, 228);
            this.EditOffice.Name = "EditOffice";
            this.EditOffice.Size = new System.Drawing.Size(192, 23);
            this.EditOffice.TabIndex = 7;
            this.EditOffice.Text = "Редактировать подразделение";
            this.EditOffice.UseVisualStyleBackColor = true;
            // 
            // OfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 259);
            this.Controls.Add(this.EditOffice);
            this.Controls.Add(this.AddOffice);
            this.Controls.Add(this.parentOffice_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_tb);
            this.Name = "OfficeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OfficeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OfficeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox name_tb;
        private Label label1;
        private Label label2;
        private TextBox description_tb;
        private Label label3;
        private ComboBox parentOffice_cb;
        private Button AddOffice;
        private Button EditOffice;
    }
}