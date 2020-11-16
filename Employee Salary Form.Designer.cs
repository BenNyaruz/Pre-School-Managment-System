namespace Pre_School_Managment_System
{
    partial class Employee_Salary_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Salary_Form));
            this.Payment_groupBox = new System.Windows.Forms.GroupBox();
            this.Bank_lbl = new System.Windows.Forms.Label();
            this.Transfer_lbl = new System.Windows.Forms.Label();
            this.Cash_lbl = new System.Windows.Forms.Label();
            this.Bank_txt = new System.Windows.Forms.NumericUpDown();
            this.Transfer_txt = new System.Windows.Forms.NumericUpDown();
            this.Cash_txt = new System.Windows.Forms.NumericUpDown();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Pay_Period_lbl = new System.Windows.Forms.Label();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.Employee_Name_lbl = new System.Windows.Forms.Label();
            this.Employee_Name_txt = new System.Windows.Forms.ComboBox();
            this.employeeRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.Salary_radioButton = new System.Windows.Forms.RadioButton();
            this.Allawance_radioButton = new System.Windows.Forms.RadioButton();
            this.Wage_radioButton = new System.Windows.Forms.RadioButton();
            this.User_txt = new System.Windows.Forms.Label();
            this.Salary_Due_lbl = new System.Windows.Forms.Label();
            this.Pay_Period_txt = new System.Windows.Forms.ComboBox();
            this.employeeSalariesWagesAllawanceRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Salary_Due_txt = new System.Windows.Forms.NumericUpDown();
            this.employee_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Employee_Registration_Record_tblTableAdapter();
            this.employee_Salaries_Wages_Allawance_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Employee_Salaries_Wages_Allawance_Record_tblTableAdapter();
            this.Payment_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalariesWagesAllawanceRecordtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary_Due_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Payment_groupBox
            // 
            this.Payment_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Payment_groupBox.Controls.Add(this.Bank_lbl);
            this.Payment_groupBox.Controls.Add(this.Transfer_lbl);
            this.Payment_groupBox.Controls.Add(this.Cash_lbl);
            this.Payment_groupBox.Controls.Add(this.Bank_txt);
            this.Payment_groupBox.Controls.Add(this.Transfer_txt);
            this.Payment_groupBox.Controls.Add(this.Cash_txt);
            this.Payment_groupBox.Location = new System.Drawing.Point(952, 178);
            this.Payment_groupBox.Name = "Payment_groupBox";
            this.Payment_groupBox.Size = new System.Drawing.Size(486, 267);
            this.Payment_groupBox.TabIndex = 75;
            this.Payment_groupBox.TabStop = false;
            this.Payment_groupBox.Text = "Payment";
            // 
            // Bank_lbl
            // 
            this.Bank_lbl.AutoSize = true;
            this.Bank_lbl.Location = new System.Drawing.Point(71, 197);
            this.Bank_lbl.Name = "Bank_lbl";
            this.Bank_lbl.Size = new System.Drawing.Size(68, 22);
            this.Bank_lbl.TabIndex = 5;
            this.Bank_lbl.Text = "Bank :";
            // 
            // Transfer_lbl
            // 
            this.Transfer_lbl.AutoSize = true;
            this.Transfer_lbl.Location = new System.Drawing.Point(41, 128);
            this.Transfer_lbl.Name = "Transfer_lbl";
            this.Transfer_lbl.Size = new System.Drawing.Size(98, 22);
            this.Transfer_lbl.TabIndex = 4;
            this.Transfer_lbl.Text = "Transfer :";
            // 
            // Cash_lbl
            // 
            this.Cash_lbl.AutoSize = true;
            this.Cash_lbl.Location = new System.Drawing.Point(72, 59);
            this.Cash_lbl.Name = "Cash_lbl";
            this.Cash_lbl.Size = new System.Drawing.Size(67, 22);
            this.Cash_lbl.TabIndex = 3;
            this.Cash_lbl.Text = "Cash :";
            // 
            // Bank_txt
            // 
            this.Bank_txt.DecimalPlaces = 2;
            this.Bank_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Bank_txt.Location = new System.Drawing.Point(300, 195);
            this.Bank_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Bank_txt.Name = "Bank_txt";
            this.Bank_txt.Size = new System.Drawing.Size(162, 29);
            this.Bank_txt.TabIndex = 10;
            this.Bank_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bank_txt.ThousandsSeparator = true;
            // 
            // Transfer_txt
            // 
            this.Transfer_txt.DecimalPlaces = 2;
            this.Transfer_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Transfer_txt.Location = new System.Drawing.Point(300, 126);
            this.Transfer_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Transfer_txt.Name = "Transfer_txt";
            this.Transfer_txt.Size = new System.Drawing.Size(162, 29);
            this.Transfer_txt.TabIndex = 9;
            this.Transfer_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Transfer_txt.ThousandsSeparator = true;
            // 
            // Cash_txt
            // 
            this.Cash_txt.DecimalPlaces = 2;
            this.Cash_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Cash_txt.Location = new System.Drawing.Point(300, 57);
            this.Cash_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Cash_txt.Name = "Cash_txt";
            this.Cash_txt.Size = new System.Drawing.Size(162, 29);
            this.Cash_txt.TabIndex = 8;
            this.Cash_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cash_txt.ThousandsSeparator = true;
            // 
            // Pay_btn
            // 
            this.Pay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pay_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_btn.Location = new System.Drawing.Point(788, 543);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(153, 76);
            this.Pay_btn.TabIndex = 11;
            this.Pay_btn.Text = "&Pay";
            this.Pay_btn.UseVisualStyleBackColor = false;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // Surname_txt
            // 
            this.Surname_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(337, 230);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(453, 26);
            this.Surname_txt.TabIndex = 2;
            // 
            // Pay_Period_lbl
            // 
            this.Pay_Period_lbl.AutoSize = true;
            this.Pay_Period_lbl.Location = new System.Drawing.Point(187, 336);
            this.Pay_Period_lbl.Name = "Pay_Period_lbl";
            this.Pay_Period_lbl.Size = new System.Drawing.Size(120, 22);
            this.Pay_Period_lbl.TabIndex = 66;
            this.Pay_Period_lbl.Text = "Pay Period :";
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Location = new System.Drawing.Point(204, 234);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(103, 22);
            this.Surname_lbl.TabIndex = 65;
            this.Surname_lbl.Text = "Surname :";
            // 
            // Employee_Name_lbl
            // 
            this.Employee_Name_lbl.AutoSize = true;
            this.Employee_Name_lbl.Location = new System.Drawing.Point(138, 130);
            this.Employee_Name_lbl.Name = "Employee_Name_lbl";
            this.Employee_Name_lbl.Size = new System.Drawing.Size(169, 22);
            this.Employee_Name_lbl.TabIndex = 64;
            this.Employee_Name_lbl.Text = "Employee Name :";
            // 
            // Employee_Name_txt
            // 
            this.Employee_Name_txt.DataSource = this.employeeRegistrationRecordtblBindingSource;
            this.Employee_Name_txt.DisplayMember = "First_Name";
            this.Employee_Name_txt.FormattingEnabled = true;
            this.Employee_Name_txt.Location = new System.Drawing.Point(337, 127);
            this.Employee_Name_txt.Name = "Employee_Name_txt";
            this.Employee_Name_txt.Size = new System.Drawing.Size(453, 30);
            this.Employee_Name_txt.TabIndex = 1;
            this.Employee_Name_txt.SelectedIndexChanged += new System.EventHandler(this.Employee_Name_txt_SelectedIndexChanged);
            // 
            // employeeRegistrationRecordtblBindingSource
            // 
            this.employeeRegistrationRecordtblBindingSource.DataMember = "Employee_Registration_Record_tbl";
            this.employeeRegistrationRecordtblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Salary_radioButton
            // 
            this.Salary_radioButton.AutoSize = true;
            this.Salary_radioButton.Location = new System.Drawing.Point(337, 418);
            this.Salary_radioButton.Name = "Salary_radioButton";
            this.Salary_radioButton.Size = new System.Drawing.Size(86, 26);
            this.Salary_radioButton.TabIndex = 4;
            this.Salary_radioButton.TabStop = true;
            this.Salary_radioButton.Text = "Salary";
            this.Salary_radioButton.UseVisualStyleBackColor = true;
            this.Salary_radioButton.CheckedChanged += new System.EventHandler(this.Salary_radioButton_CheckedChanged);
            // 
            // Allawance_radioButton
            // 
            this.Allawance_radioButton.AutoSize = true;
            this.Allawance_radioButton.Location = new System.Drawing.Point(667, 418);
            this.Allawance_radioButton.Name = "Allawance_radioButton";
            this.Allawance_radioButton.Size = new System.Drawing.Size(122, 26);
            this.Allawance_radioButton.TabIndex = 6;
            this.Allawance_radioButton.TabStop = true;
            this.Allawance_radioButton.Text = "Allawance";
            this.Allawance_radioButton.UseVisualStyleBackColor = true;
            this.Allawance_radioButton.CheckedChanged += new System.EventHandler(this.Allawance_radioButton_CheckedChanged);
            // 
            // Wage_radioButton
            // 
            this.Wage_radioButton.AutoSize = true;
            this.Wage_radioButton.Location = new System.Drawing.Point(505, 418);
            this.Wage_radioButton.Name = "Wage_radioButton";
            this.Wage_radioButton.Size = new System.Drawing.Size(80, 26);
            this.Wage_radioButton.TabIndex = 5;
            this.Wage_radioButton.TabStop = true;
            this.Wage_radioButton.Text = "Wage";
            this.Wage_radioButton.UseVisualStyleBackColor = true;
            this.Wage_radioButton.CheckedChanged += new System.EventHandler(this.Wage_radioButton_CheckedChanged);
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(12, 9);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 80;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // Salary_Due_lbl
            // 
            this.Salary_Due_lbl.AutoSize = true;
            this.Salary_Due_lbl.Location = new System.Drawing.Point(948, 127);
            this.Salary_Due_lbl.Name = "Salary_Due_lbl";
            this.Salary_Due_lbl.Size = new System.Drawing.Size(115, 22);
            this.Salary_Due_lbl.TabIndex = 81;
            this.Salary_Due_lbl.Text = "Salary Due:";
            this.Salary_Due_lbl.Visible = false;
            // 
            // Pay_Period_txt
            // 
            this.Pay_Period_txt.DataSource = this.employeeSalariesWagesAllawanceRecordtblBindingSource;
            this.Pay_Period_txt.DisplayMember = "Pay_Period";
            this.Pay_Period_txt.FormattingEnabled = true;
            this.Pay_Period_txt.Location = new System.Drawing.Point(337, 328);
            this.Pay_Period_txt.Name = "Pay_Period_txt";
            this.Pay_Period_txt.Size = new System.Drawing.Size(453, 30);
            this.Pay_Period_txt.TabIndex = 3;
            // 
            // employeeSalariesWagesAllawanceRecordtblBindingSource
            // 
            this.employeeSalariesWagesAllawanceRecordtblBindingSource.DataMember = "Employee_Salaries_Wages_Allawance_Record_tbl";
            this.employeeSalariesWagesAllawanceRecordtblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // Salary_Due_txt
            // 
            this.Salary_Due_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Salary_Due_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salary_Due_txt.DecimalPlaces = 2;
            this.Salary_Due_txt.Enabled = false;
            this.Salary_Due_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_Due_txt.ForeColor = System.Drawing.Color.Red;
            this.Salary_Due_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Salary_Due_txt.Location = new System.Drawing.Point(1149, 120);
            this.Salary_Due_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Salary_Due_txt.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.Salary_Due_txt.Name = "Salary_Due_txt";
            this.Salary_Due_txt.Size = new System.Drawing.Size(162, 31);
            this.Salary_Due_txt.TabIndex = 83;
            this.Salary_Due_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Salary_Due_txt.ThousandsSeparator = true;
            // 
            // employee_Registration_Record_tblTableAdapter
            // 
            this.employee_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // employee_Salaries_Wages_Allawance_Record_tblTableAdapter
            // 
            this.employee_Salaries_Wages_Allawance_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_Salary_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1529, 660);
            this.Controls.Add(this.Salary_Due_txt);
            this.Controls.Add(this.Pay_Period_txt);
            this.Controls.Add(this.Salary_Due_lbl);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Wage_radioButton);
            this.Controls.Add(this.Allawance_radioButton);
            this.Controls.Add(this.Salary_radioButton);
            this.Controls.Add(this.Employee_Name_txt);
            this.Controls.Add(this.Payment_groupBox);
            this.Controls.Add(this.Pay_btn);
            this.Controls.Add(this.Surname_txt);
            this.Controls.Add(this.Pay_Period_lbl);
            this.Controls.Add(this.Surname_lbl);
            this.Controls.Add(this.Employee_Name_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Employee_Salary_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Salary Form";
            this.Load += new System.EventHandler(this.Employee_Salary_Form_Load);
            this.Payment_groupBox.ResumeLayout(false);
            this.Payment_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cash_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalariesWagesAllawanceRecordtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary_Due_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Payment_groupBox;
        private System.Windows.Forms.Label Bank_lbl;
        private System.Windows.Forms.Label Transfer_lbl;
        private System.Windows.Forms.Label Cash_lbl;
        private System.Windows.Forms.NumericUpDown Bank_txt;
        private System.Windows.Forms.NumericUpDown Transfer_txt;
        private System.Windows.Forms.NumericUpDown Cash_txt;
        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.Label Pay_Period_lbl;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.Label Employee_Name_lbl;
        private System.Windows.Forms.ComboBox Employee_Name_txt;
        private System.Windows.Forms.RadioButton Salary_radioButton;
        private System.Windows.Forms.RadioButton Allawance_radioButton;
        private System.Windows.Forms.RadioButton Wage_radioButton;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.Label Salary_Due_lbl;
        private System.Windows.Forms.ComboBox Pay_Period_txt;
        private System.Windows.Forms.NumericUpDown Salary_Due_txt;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Employee_Registration_Record_tblTableAdapter employee_Registration_Record_tblTableAdapter;
        private System.Windows.Forms.BindingSource employeeSalariesWagesAllawanceRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Employee_Salaries_Wages_Allawance_Record_tblTableAdapter employee_Salaries_Wages_Allawance_Record_tblTableAdapter;
    }
}