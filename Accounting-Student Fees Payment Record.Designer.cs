namespace Pre_School_Managment_System
{
    partial class Accounting_Student_Fees_Payment_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Student_Fees_Payment_Record));
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.student_Fees_Payment_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Fees_Payment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Fees_Payment_tblTableAdapter();
            this.tableAdapterManager = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.student_Fees_Payment_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCashPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOwingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.School_Term_txt_Std = new System.Windows.Forms.ComboBox();
            this.feesManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Student_Name_txt = new System.Windows.Forms.ComboBox();
            this.studentRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_All_radioButton = new System.Windows.Forms.RadioButton();
            this.View_Student_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Update_btn = new System.Windows.Forms.Button();
            this.View_btn = new System.Windows.Forms.Button();
            this.fees_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter();
            this.student_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Fees_Payment_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Fees_Payment_tblDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_Fees_Payment_tblBindingSource
            // 
            this.student_Fees_Payment_tblBindingSource.DataMember = "Student_Fees_Payment_tbl";
            this.student_Fees_Payment_tblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // student_Fees_Payment_tblTableAdapter
            // 
            this.student_Fees_Payment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Activity_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Activity_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Activity_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Activity_Registration_tblTableAdapter = null;
            this.tableAdapterManager.Assert_Managment_tblTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employee_Registration_Record_tblTableAdapter = null;
            this.tableAdapterManager.Employee_Salaries_Wages_Allawance_Record_tblTableAdapter = null;
            this.tableAdapterManager.Employee_Salary_tblTableAdapter = null;
            this.tableAdapterManager.Fees_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Fees_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Project_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Project_Income_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Project_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Student_Fees_Payment_tblTableAdapter = this.student_Fees_Payment_tblTableAdapter;
            this.tableAdapterManager.Student_Registration_Record_tblTableAdapter = null;
            this.tableAdapterManager.Student_Transport_Payment_tblTableAdapter = null;
            this.tableAdapterManager.Student_Uniform_Payment_tblTableAdapter = null;
            this.tableAdapterManager.System_Exchange_Rates_tblTableAdapter = null;
            this.tableAdapterManager.System_Log_tblTableAdapter = null;
            this.tableAdapterManager.System_Users_tblTableAdapter = null;
            this.tableAdapterManager.Transport_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Transport_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Uniform_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Uniform_Managment_tblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_Fees_Payment_tblDataGridView
            // 
            this.student_Fees_Payment_tblDataGridView.AllowUserToAddRows = false;
            this.student_Fees_Payment_tblDataGridView.AutoGenerateColumns = false;
            this.student_Fees_Payment_tblDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.student_Fees_Payment_tblDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.student_Fees_Payment_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_Fees_Payment_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.schoolTermDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.totalCashPaidDataGridViewTextBoxColumn,
            this.amountOwingDataGridViewTextBoxColumn,
            this.accountantDataGridViewTextBoxColumn});
            this.student_Fees_Payment_tblDataGridView.DataSource = this.student_Fees_Payment_tblBindingSource;
            this.student_Fees_Payment_tblDataGridView.Location = new System.Drawing.Point(372, -2);
            this.student_Fees_Payment_tblDataGridView.Name = "student_Fees_Payment_tblDataGridView";
            this.student_Fees_Payment_tblDataGridView.Size = new System.Drawing.Size(1157, 661);
            this.student_Fees_Payment_tblDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // schoolTermDataGridViewTextBoxColumn
            // 
            this.schoolTermDataGridViewTextBoxColumn.DataPropertyName = "School_Term";
            this.schoolTermDataGridViewTextBoxColumn.HeaderText = "School_Term";
            this.schoolTermDataGridViewTextBoxColumn.Name = "schoolTermDataGridViewTextBoxColumn";
            this.schoolTermDataGridViewTextBoxColumn.Width = 155;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment_Method";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment_Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.Width = 193;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.Width = 157;
            // 
            // totalCashPaidDataGridViewTextBoxColumn
            // 
            this.totalCashPaidDataGridViewTextBoxColumn.DataPropertyName = "Total_Cash_Paid";
            this.totalCashPaidDataGridViewTextBoxColumn.HeaderText = "Total_Cash_Paid";
            this.totalCashPaidDataGridViewTextBoxColumn.Name = "totalCashPaidDataGridViewTextBoxColumn";
            this.totalCashPaidDataGridViewTextBoxColumn.Width = 188;
            // 
            // amountOwingDataGridViewTextBoxColumn
            // 
            this.amountOwingDataGridViewTextBoxColumn.DataPropertyName = "Amount_Owing";
            this.amountOwingDataGridViewTextBoxColumn.HeaderText = "Amount_Owing";
            this.amountOwingDataGridViewTextBoxColumn.Name = "amountOwingDataGridViewTextBoxColumn";
            this.amountOwingDataGridViewTextBoxColumn.Width = 174;
            // 
            // accountantDataGridViewTextBoxColumn
            // 
            this.accountantDataGridViewTextBoxColumn.DataPropertyName = "Accountant";
            this.accountantDataGridViewTextBoxColumn.HeaderText = "Accountant";
            this.accountantDataGridViewTextBoxColumn.Name = "accountantDataGridViewTextBoxColumn";
            this.accountantDataGridViewTextBoxColumn.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.School_Term_lbl);
            this.groupBox1.Controls.Add(this.School_Term_txt_Std);
            this.groupBox1.Controls.Add(this.Student_Name_txt);
            this.groupBox1.Location = new System.Drawing.Point(1, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Student";
            // 
            // School_Term_lbl
            // 
            this.School_Term_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(145, 110);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 82;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // School_Term_txt_Std
            // 
            this.School_Term_txt_Std.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Term_txt_Std.DataSource = this.feesManagmenttblBindingSource;
            this.School_Term_txt_Std.DisplayMember = "School_Term";
            this.School_Term_txt_Std.FormattingEnabled = true;
            this.School_Term_txt_Std.Location = new System.Drawing.Point(62, 144);
            this.School_Term_txt_Std.Name = "School_Term_txt_Std";
            this.School_Term_txt_Std.Size = new System.Drawing.Size(303, 30);
            this.School_Term_txt_Std.TabIndex = 5;
            // 
            // feesManagmenttblBindingSource
            // 
            this.feesManagmenttblBindingSource.DataMember = "Fees_Managment_tbl";
            this.feesManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // Student_Name_txt
            // 
            this.Student_Name_txt.DataSource = this.studentRegistrationRecordtblBindingSource;
            this.Student_Name_txt.DisplayMember = "First_Name";
            this.Student_Name_txt.FormattingEnabled = true;
            this.Student_Name_txt.Location = new System.Drawing.Point(61, 45);
            this.Student_Name_txt.Name = "Student_Name_txt";
            this.Student_Name_txt.Size = new System.Drawing.Size(304, 30);
            this.Student_Name_txt.TabIndex = 4;
            // 
            // studentRegistrationRecordtblBindingSource
            // 
            this.studentRegistrationRecordtblBindingSource.DataMember = "Student_Registration_Record_tbl";
            this.studentRegistrationRecordtblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // View_All_radioButton
            // 
            this.View_All_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View_All_radioButton.AutoSize = true;
            this.View_All_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_All_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.View_All_radioButton.Location = new System.Drawing.Point(8, 28);
            this.View_All_radioButton.Name = "View_All_radioButton";
            this.View_All_radioButton.Size = new System.Drawing.Size(100, 26);
            this.View_All_radioButton.TabIndex = 7;
            this.View_All_radioButton.TabStop = true;
            this.View_All_radioButton.Text = "View All";
            this.View_All_radioButton.UseVisualStyleBackColor = true;
            this.View_All_radioButton.CheckedChanged += new System.EventHandler(this.View_All_radioButton_CheckedChanged);
            // 
            // View_Student_radioButton
            // 
            this.View_Student_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View_Student_radioButton.AutoSize = true;
            this.View_Student_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_Student_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.View_Student_radioButton.Location = new System.Drawing.Point(169, 28);
            this.View_Student_radioButton.Name = "View_Student_radioButton";
            this.View_Student_radioButton.Size = new System.Drawing.Size(148, 26);
            this.View_Student_radioButton.TabIndex = 8;
            this.View_Student_radioButton.TabStop = true;
            this.View_Student_radioButton.Text = "View Student";
            this.View_Student_radioButton.UseVisualStyleBackColor = true;
            this.View_Student_radioButton.CheckedChanged += new System.EventHandler(this.View_Student_radioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.View_Student_radioButton);
            this.groupBox3.Controls.Add(this.View_All_radioButton);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 71);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Update_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Update_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(107, 473);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(235, 78);
            this.Update_btn.TabIndex = 88;
            this.Update_btn.Text = "&Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // View_btn
            // 
            this.View_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.View_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.View_btn.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_btn.Location = new System.Drawing.Point(138, 356);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(173, 48);
            this.View_btn.TabIndex = 89;
            this.View_btn.Text = "&View";
            this.View_btn.UseVisualStyleBackColor = false;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // fees_Managment_tblTableAdapter
            // 
            this.fees_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // student_Registration_Record_tblTableAdapter
            // 
            this.student_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Accounting_Student_Fees_Payment_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1529, 659);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.student_Fees_Payment_tblDataGridView);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Accounting_Student_Fees_Payment_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Fees Payment Record";
            this.Load += new System.EventHandler(this.Accounting_Student_Fees_Payment_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Fees_Payment_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Fees_Payment_tblDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feesManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource student_Fees_Payment_tblBindingSource;
        private System_DatabaseDataSet System_DatabaseDataSet;
        private System_DatabaseDataSetTableAdapters.Student_Fees_Payment_tblTableAdapter student_Fees_Payment_tblTableAdapter;
        private System_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView student_Fees_Payment_tblDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Student_Name_txt;
        private System.Windows.Forms.ComboBox School_Term_txt_Std;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.RadioButton View_All_radioButton;
        private System.Windows.Forms.RadioButton View_Student_radioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button View_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCashPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOwingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource feesManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Fees_Managment_tblTableAdapter fees_Managment_tblTableAdapter;
        private System.Windows.Forms.BindingSource studentRegistrationRecordtblBindingSource;
        private System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter student_Registration_Record_tblTableAdapter;
    }
}