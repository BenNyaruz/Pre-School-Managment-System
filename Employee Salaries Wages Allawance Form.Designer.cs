namespace Pre_School_Managment_System
{
    partial class Employee_Salaries_Wages_Allawance_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Salaries_Wages_Allawance_Form));
            this.Employee_Name_txt = new System.Windows.Forms.ComboBox();
            this.employeeRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.Payment_groupBox = new System.Windows.Forms.GroupBox();
            this.Allawance_lbl = new System.Windows.Forms.Label();
            this.Wage_lbl = new System.Windows.Forms.Label();
            this.Salary_lbl = new System.Windows.Forms.Label();
            this.Allawance_txt = new System.Windows.Forms.NumericUpDown();
            this.Wage_txt = new System.Windows.Forms.NumericUpDown();
            this.Salary_txt = new System.Windows.Forms.NumericUpDown();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.Pay_Period_lbl = new System.Windows.Forms.Label();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.Employee_Name_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Pay_Period_txt = new System.Windows.Forms.TextBox();
            this.employee_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Employee_Registration_Record_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            this.Payment_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Allawance_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wage_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_Name_txt
            // 
            this.Employee_Name_txt.DataSource = this.employeeRegistrationRecordtblBindingSource;
            this.Employee_Name_txt.DisplayMember = "First_Name";
            this.Employee_Name_txt.FormattingEnabled = true;
            this.Employee_Name_txt.Location = new System.Drawing.Point(292, 145);
            this.Employee_Name_txt.Name = "Employee_Name_txt";
            this.Employee_Name_txt.Size = new System.Drawing.Size(423, 30);
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
            // Payment_groupBox
            // 
            this.Payment_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Payment_groupBox.Controls.Add(this.Allawance_lbl);
            this.Payment_groupBox.Controls.Add(this.Wage_lbl);
            this.Payment_groupBox.Controls.Add(this.Salary_lbl);
            this.Payment_groupBox.Controls.Add(this.Allawance_txt);
            this.Payment_groupBox.Controls.Add(this.Wage_txt);
            this.Payment_groupBox.Controls.Add(this.Salary_txt);
            this.Payment_groupBox.Location = new System.Drawing.Point(945, 145);
            this.Payment_groupBox.Name = "Payment_groupBox";
            this.Payment_groupBox.Size = new System.Drawing.Size(486, 267);
            this.Payment_groupBox.TabIndex = 82;
            this.Payment_groupBox.TabStop = false;
            this.Payment_groupBox.Text = "Payment";
            // 
            // Allawance_lbl
            // 
            this.Allawance_lbl.AutoSize = true;
            this.Allawance_lbl.Location = new System.Drawing.Point(71, 202);
            this.Allawance_lbl.Name = "Allawance_lbl";
            this.Allawance_lbl.Size = new System.Drawing.Size(115, 22);
            this.Allawance_lbl.TabIndex = 5;
            this.Allawance_lbl.Text = "Allawance :";
            // 
            // Wage_lbl
            // 
            this.Wage_lbl.AutoSize = true;
            this.Wage_lbl.Location = new System.Drawing.Point(113, 133);
            this.Wage_lbl.Name = "Wage_lbl";
            this.Wage_lbl.Size = new System.Drawing.Size(73, 22);
            this.Wage_lbl.TabIndex = 4;
            this.Wage_lbl.Text = "Wage :";
            // 
            // Salary_lbl
            // 
            this.Salary_lbl.AutoSize = true;
            this.Salary_lbl.Location = new System.Drawing.Point(107, 64);
            this.Salary_lbl.Name = "Salary_lbl";
            this.Salary_lbl.Size = new System.Drawing.Size(79, 22);
            this.Salary_lbl.TabIndex = 3;
            this.Salary_lbl.Text = "Salary :";
            // 
            // Allawance_txt
            // 
            this.Allawance_txt.DecimalPlaces = 2;
            this.Allawance_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Allawance_txt.Location = new System.Drawing.Point(300, 195);
            this.Allawance_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Allawance_txt.Name = "Allawance_txt";
            this.Allawance_txt.Size = new System.Drawing.Size(162, 29);
            this.Allawance_txt.TabIndex = 6;
            this.Allawance_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Allawance_txt.ThousandsSeparator = true;
            // 
            // Wage_txt
            // 
            this.Wage_txt.DecimalPlaces = 2;
            this.Wage_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Wage_txt.Location = new System.Drawing.Point(300, 126);
            this.Wage_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Wage_txt.Name = "Wage_txt";
            this.Wage_txt.Size = new System.Drawing.Size(162, 29);
            this.Wage_txt.TabIndex = 5;
            this.Wage_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wage_txt.ThousandsSeparator = true;
            // 
            // Salary_txt
            // 
            this.Salary_txt.DecimalPlaces = 2;
            this.Salary_txt.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Salary_txt.Location = new System.Drawing.Point(300, 57);
            this.Salary_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Salary_txt.Name = "Salary_txt";
            this.Salary_txt.Size = new System.Drawing.Size(162, 29);
            this.Salary_txt.TabIndex = 4;
            this.Salary_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Salary_txt.ThousandsSeparator = true;
            // 
            // Surname_txt
            // 
            this.Surname_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(292, 266);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(423, 26);
            this.Surname_txt.TabIndex = 2;
            // 
            // Pay_Period_lbl
            // 
            this.Pay_Period_lbl.AutoSize = true;
            this.Pay_Period_lbl.Location = new System.Drawing.Point(142, 390);
            this.Pay_Period_lbl.Name = "Pay_Period_lbl";
            this.Pay_Period_lbl.Size = new System.Drawing.Size(120, 22);
            this.Pay_Period_lbl.TabIndex = 81;
            this.Pay_Period_lbl.Text = "Pay Period :";
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Location = new System.Drawing.Point(159, 269);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(103, 22);
            this.Surname_lbl.TabIndex = 80;
            this.Surname_lbl.Text = "Surname :";
            // 
            // Employee_Name_lbl
            // 
            this.Employee_Name_lbl.AutoSize = true;
            this.Employee_Name_lbl.Location = new System.Drawing.Point(93, 148);
            this.Employee_Name_lbl.Name = "Employee_Name_lbl";
            this.Employee_Name_lbl.Size = new System.Drawing.Size(169, 22);
            this.Employee_Name_lbl.TabIndex = 79;
            this.Employee_Name_lbl.Text = "Employee Name :";
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(12, 9);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 83;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(705, 528);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(242, 97);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "&SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Pay_Period_txt
            // 
            this.Pay_Period_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_Period_txt.Location = new System.Drawing.Point(292, 386);
            this.Pay_Period_txt.Name = "Pay_Period_txt";
            this.Pay_Period_txt.Size = new System.Drawing.Size(423, 26);
            this.Pay_Period_txt.TabIndex = 3;
            // 
            // employee_Registration_Record_tblTableAdapter
            // 
            this.employee_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_Salaries_Wages_Allawance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1530, 662);
            this.Controls.Add(this.Pay_Period_txt);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Employee_Name_txt);
            this.Controls.Add(this.Payment_groupBox);
            this.Controls.Add(this.Surname_txt);
            this.Controls.Add(this.Pay_Period_lbl);
            this.Controls.Add(this.Surname_lbl);
            this.Controls.Add(this.Employee_Name_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Employee_Salaries_Wages_Allawance_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Salaries Wages Allawance ";
            this.Load += new System.EventHandler(this.Employee_Salaries_Wages_Allawance_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            this.Payment_groupBox.ResumeLayout(false);
            this.Payment_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Allawance_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wage_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Employee_Name_txt;
        private System.Windows.Forms.GroupBox Payment_groupBox;
        private System.Windows.Forms.Label Allawance_lbl;
        private System.Windows.Forms.Label Wage_lbl;
        private System.Windows.Forms.Label Salary_lbl;
        private System.Windows.Forms.NumericUpDown Allawance_txt;
        private System.Windows.Forms.NumericUpDown Wage_txt;
        private System.Windows.Forms.NumericUpDown Salary_txt;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.Label Pay_Period_lbl;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.Label Employee_Name_lbl;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.TextBox Pay_Period_txt;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Employee_Registration_Record_tblTableAdapter employee_Registration_Record_tblTableAdapter;
    }
}