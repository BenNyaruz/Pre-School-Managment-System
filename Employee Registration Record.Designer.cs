namespace Pre_School_Managment_System
{
    partial class Employee_Registration_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Registration_Record));
            this.User_txt = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Employee_Managment_dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeRegistrationRecordtblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.systemDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Employee_Registration_Record_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Managment_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(21, 589);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 84;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.BackColor = System.Drawing.Color.Gold;
            this.Close_btn.ForeColor = System.Drawing.Color.Black;
            this.Close_btn.Location = new System.Drawing.Point(1417, 598);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(100, 36);
            this.Close_btn.TabIndex = 83;
            this.Close_btn.Text = "&Closs";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Employee_Managment_dataGridView
            // 
            this.Employee_Managment_dataGridView.AllowUserToAddRows = false;
            this.Employee_Managment_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Employee_Managment_dataGridView.AutoGenerateColumns = false;
            this.Employee_Managment_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Employee_Managment_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Employee_Managment_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Employee_Managment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_Managment_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.houseAddressDataGridViewTextBoxColumn,
            this.contactDetailsDataGridViewTextBoxColumn,
            this.nationalIdDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.employeeDescriptionDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.accountantDataGridViewTextBoxColumn});
            this.Employee_Managment_dataGridView.DataSource = this.employeeRegistrationRecordtblBindingSource1;
            this.Employee_Managment_dataGridView.Location = new System.Drawing.Point(1, 0);
            this.Employee_Managment_dataGridView.Name = "Employee_Managment_dataGridView";
            this.Employee_Managment_dataGridView.Size = new System.Drawing.Size(1362, 576);
            this.Employee_Managment_dataGridView.TabIndex = 82;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 53;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 139;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 117;
            // 
            // houseAddressDataGridViewTextBoxColumn
            // 
            this.houseAddressDataGridViewTextBoxColumn.DataPropertyName = "House_Address";
            this.houseAddressDataGridViewTextBoxColumn.HeaderText = "House_Address";
            this.houseAddressDataGridViewTextBoxColumn.Name = "houseAddressDataGridViewTextBoxColumn";
            this.houseAddressDataGridViewTextBoxColumn.Width = 179;
            // 
            // contactDetailsDataGridViewTextBoxColumn
            // 
            this.contactDetailsDataGridViewTextBoxColumn.DataPropertyName = "Contact_Details";
            this.contactDetailsDataGridViewTextBoxColumn.HeaderText = "Contact_Details";
            this.contactDetailsDataGridViewTextBoxColumn.Name = "contactDetailsDataGridViewTextBoxColumn";
            this.contactDetailsDataGridViewTextBoxColumn.Width = 180;
            // 
            // nationalIdDataGridViewTextBoxColumn
            // 
            this.nationalIdDataGridViewTextBoxColumn.DataPropertyName = "National_Id";
            this.nationalIdDataGridViewTextBoxColumn.HeaderText = "National_Id";
            this.nationalIdDataGridViewTextBoxColumn.Name = "nationalIdDataGridViewTextBoxColumn";
            this.nationalIdDataGridViewTextBoxColumn.Width = 138;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital_Status";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital_Status";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.Width = 167;
            // 
            // employeeDescriptionDataGridViewTextBoxColumn
            // 
            this.employeeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Employee_Description";
            this.employeeDescriptionDataGridViewTextBoxColumn.HeaderText = "Employee_Description";
            this.employeeDescriptionDataGridViewTextBoxColumn.Name = "employeeDescriptionDataGridViewTextBoxColumn";
            this.employeeDescriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 69;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 98;
            // 
            // accountantDataGridViewTextBoxColumn
            // 
            this.accountantDataGridViewTextBoxColumn.DataPropertyName = "Accountant";
            this.accountantDataGridViewTextBoxColumn.HeaderText = "Accountant";
            this.accountantDataGridViewTextBoxColumn.Name = "accountantDataGridViewTextBoxColumn";
            this.accountantDataGridViewTextBoxColumn.Width = 140;
            // 
            // employeeRegistrationRecordtblBindingSource1
            // 
            this.employeeRegistrationRecordtblBindingSource1.DataMember = "Employee_Registration_Record_tbl";
            this.employeeRegistrationRecordtblBindingSource1.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemDatabaseDataSetBindingSource
            // 
            this.systemDatabaseDataSetBindingSource.DataSource = this.system_DatabaseDataSet;
            this.systemDatabaseDataSetBindingSource.Position = 0;
            // 
            // employeeRegistrationRecordtblBindingSource
            // 
            this.employeeRegistrationRecordtblBindingSource.DataMember = "Employee_Registration_Record_tbl";
            this.employeeRegistrationRecordtblBindingSource.DataSource = this.systemDatabaseDataSetBindingSource;
            // 
            // employee_Registration_Record_tblTableAdapter
            // 
            this.employee_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_Registration_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1364, 658);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Employee_Managment_dataGridView);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Employee_Registration_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Registration Record";
            this.Load += new System.EventHandler(this.Employee_Registration_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Managment_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRegistrationRecordtblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.DataGridView Employee_Managment_dataGridView;
        private System.Windows.Forms.BindingSource systemDatabaseDataSetBindingSource;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource employeeRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Employee_Registration_Record_tblTableAdapter employee_Registration_Record_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeRegistrationRecordtblBindingSource1;
    }
}