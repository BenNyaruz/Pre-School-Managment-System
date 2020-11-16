namespace Pre_School_Managment_System
{
    partial class Accounting_Student_Transport_Payment_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting_Student_Transport_Payment_Record));
            this.View_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.View_Student_radioButton = new System.Windows.Forms.RadioButton();
            this.View_All_radioButton = new System.Windows.Forms.RadioButton();
            this.transportManagmenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.School_Term_lbl = new System.Windows.Forms.Label();
            this.School_Term_txt_Std = new System.Windows.Forms.ComboBox();
            this.Student_Name_txt = new System.Windows.Forms.ComboBox();
            this.studentRegistrationRecordtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Transport_Payment_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Transport_Payment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Transport_Payment_tblTableAdapter();
            this.tableAdapterManager = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.student_Registration_Record_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter();
            this.transport_Managment_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Transport_Managment_tblTableAdapter();
            this.student_Transport_Payment_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportManagmenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Transport_Payment_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Transport_Payment_tblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // View_btn
            // 
            this.View_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.View_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.View_btn.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_btn.Location = new System.Drawing.Point(120, 349);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(173, 48);
            this.View_btn.TabIndex = 95;
            this.View_btn.Text = "&View";
            this.View_btn.UseVisualStyleBackColor = false;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Update_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Update_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(85, 456);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(228, 78);
            this.Update_btn.TabIndex = 94;
            this.Update_btn.Text = "&Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.View_Student_radioButton);
            this.groupBox3.Controls.Add(this.View_All_radioButton);
            this.groupBox3.Location = new System.Drawing.Point(0, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 71);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            // 
            // View_Student_radioButton
            // 
            this.View_Student_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View_Student_radioButton.AutoSize = true;
            this.View_Student_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_Student_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.View_Student_radioButton.Location = new System.Drawing.Point(210, 28);
            this.View_Student_radioButton.Name = "View_Student_radioButton";
            this.View_Student_radioButton.Size = new System.Drawing.Size(148, 26);
            this.View_Student_radioButton.TabIndex = 8;
            this.View_Student_radioButton.TabStop = true;
            this.View_Student_radioButton.Text = "View Student";
            this.View_Student_radioButton.UseVisualStyleBackColor = true;
            this.View_Student_radioButton.CheckedChanged += new System.EventHandler(this.View_Student_radioButton_CheckedChanged);
            // 
            // View_All_radioButton
            // 
            this.View_All_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View_All_radioButton.AutoSize = true;
            this.View_All_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_All_radioButton.ForeColor = System.Drawing.Color.Blue;
            this.View_All_radioButton.Location = new System.Drawing.Point(12, 28);
            this.View_All_radioButton.Name = "View_All_radioButton";
            this.View_All_radioButton.Size = new System.Drawing.Size(100, 26);
            this.View_All_radioButton.TabIndex = 7;
            this.View_All_radioButton.TabStop = true;
            this.View_All_radioButton.Text = "View All";
            this.View_All_radioButton.UseVisualStyleBackColor = true;
            this.View_All_radioButton.CheckedChanged += new System.EventHandler(this.View_All_radioButton_CheckedChanged);
            // 
            // transportManagmenttblBindingSource
            // 
            this.transportManagmenttblBindingSource.DataMember = "Transport_Managment_tbl";
            this.transportManagmenttblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.School_Term_lbl);
            this.groupBox1.Controls.Add(this.School_Term_txt_Std);
            this.groupBox1.Controls.Add(this.Student_Name_txt);
            this.groupBox1.Location = new System.Drawing.Point(1, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 243);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Student";
            // 
            // School_Term_lbl
            // 
            this.School_Term_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Term_lbl.AutoSize = true;
            this.School_Term_lbl.Location = new System.Drawing.Point(137, 110);
            this.School_Term_lbl.Name = "School_Term_lbl";
            this.School_Term_lbl.Size = new System.Drawing.Size(136, 22);
            this.School_Term_lbl.TabIndex = 82;
            this.School_Term_lbl.Text = "School Term :";
            // 
            // School_Term_txt_Std
            // 
            this.School_Term_txt_Std.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.School_Term_txt_Std.DataSource = this.transportManagmenttblBindingSource;
            this.School_Term_txt_Std.DisplayMember = "School_Term";
            this.School_Term_txt_Std.FormattingEnabled = true;
            this.School_Term_txt_Std.Location = new System.Drawing.Point(54, 144);
            this.School_Term_txt_Std.Name = "School_Term_txt_Std";
            this.School_Term_txt_Std.Size = new System.Drawing.Size(303, 30);
            this.School_Term_txt_Std.TabIndex = 5;
            // 
            // Student_Name_txt
            // 
            this.Student_Name_txt.DataSource = this.studentRegistrationRecordtblBindingSource;
            this.Student_Name_txt.DisplayMember = "First_Name";
            this.Student_Name_txt.FormattingEnabled = true;
            this.Student_Name_txt.Location = new System.Drawing.Point(53, 48);
            this.Student_Name_txt.Name = "Student_Name_txt";
            this.Student_Name_txt.Size = new System.Drawing.Size(304, 30);
            this.Student_Name_txt.TabIndex = 4;
            // 
            // studentRegistrationRecordtblBindingSource
            // 
            this.studentRegistrationRecordtblBindingSource.DataMember = "Student_Registration_Record_tbl";
            this.studentRegistrationRecordtblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // student_Transport_Payment_tblBindingSource
            // 
            this.student_Transport_Payment_tblBindingSource.DataMember = "Student_Transport_Payment_tbl";
            this.student_Transport_Payment_tblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // student_Transport_Payment_tblTableAdapter
            // 
            this.student_Transport_Payment_tblTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Student_Fees_Payment_tblTableAdapter = null;
            this.tableAdapterManager.Student_Registration_Record_tblTableAdapter = this.student_Registration_Record_tblTableAdapter;
            this.tableAdapterManager.Student_Transport_Payment_tblTableAdapter = this.student_Transport_Payment_tblTableAdapter;
            this.tableAdapterManager.Student_Uniform_Payment_tblTableAdapter = null;
            this.tableAdapterManager.System_Exchange_Rates_tblTableAdapter = null;
            this.tableAdapterManager.System_Log_tblTableAdapter = null;
            this.tableAdapterManager.System_Users_tblTableAdapter = null;
            this.tableAdapterManager.Transport_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Transport_Managment_tblTableAdapter = this.transport_Managment_tblTableAdapter;
            this.tableAdapterManager.Uniform_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Uniform_Managment_tblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_Registration_Record_tblTableAdapter
            // 
            this.student_Registration_Record_tblTableAdapter.ClearBeforeFill = true;
            // 
            // transport_Managment_tblTableAdapter
            // 
            this.transport_Managment_tblTableAdapter.ClearBeforeFill = true;
            // 
            // student_Transport_Payment_tblDataGridView
            // 
            this.student_Transport_Payment_tblDataGridView.AllowUserToAddRows = false;
            this.student_Transport_Payment_tblDataGridView.AutoGenerateColumns = false;
            this.student_Transport_Payment_tblDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.student_Transport_Payment_tblDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.student_Transport_Payment_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_Transport_Payment_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.student_Transport_Payment_tblDataGridView.DataSource = this.student_Transport_Payment_tblBindingSource;
            this.student_Transport_Payment_tblDataGridView.Location = new System.Drawing.Point(364, 2);
            this.student_Transport_Payment_tblDataGridView.Name = "student_Transport_Payment_tblDataGridView";
            this.student_Transport_Payment_tblDataGridView.Size = new System.Drawing.Size(1155, 660);
            this.student_Transport_Payment_tblDataGridView.TabIndex = 96;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 53;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 139;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 117;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "School_Term";
            this.dataGridViewTextBoxColumn4.HeaderText = "School_Term";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 155;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Payment_Method";
            this.dataGridViewTextBoxColumn6.HeaderText = "Payment_Method";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 193;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount_Paid";
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount_Paid";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 157;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Total_Cash_Paid";
            this.dataGridViewTextBoxColumn8.HeaderText = "Total_Cash_Paid";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 188;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Amount_Owing";
            this.dataGridViewTextBoxColumn9.HeaderText = "Amount_Owing";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 174;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Accountant";
            this.dataGridViewTextBoxColumn10.HeaderText = "Accountant";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 140;
            // 
            // Accounting_Student_Transport_Payment_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1531, 661);
            this.Controls.Add(this.student_Transport_Payment_tblDataGridView);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Accounting_Student_Transport_Payment_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Transport Payment Record";
            this.Load += new System.EventHandler(this.Accounting_Student_Transport_Payment_Record_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportManagmenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationRecordtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Transport_Payment_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Transport_Payment_tblDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button View_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton View_Student_radioButton;
        private System.Windows.Forms.RadioButton View_All_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label School_Term_lbl;
        private System.Windows.Forms.ComboBox School_Term_txt_Std;
        private System.Windows.Forms.ComboBox Student_Name_txt;
        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource student_Transport_Payment_tblBindingSource;
        private System_DatabaseDataSetTableAdapters.Student_Transport_Payment_tblTableAdapter student_Transport_Payment_tblTableAdapter;
        private System_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System_DatabaseDataSetTableAdapters.Transport_Managment_tblTableAdapter transport_Managment_tblTableAdapter;
        private System.Windows.Forms.DataGridView student_Transport_Payment_tblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource transportManagmenttblBindingSource;
        private System_DatabaseDataSetTableAdapters.Student_Registration_Record_tblTableAdapter student_Registration_Record_tblTableAdapter;
        private System.Windows.Forms.BindingSource studentRegistrationRecordtblBindingSource;
    }
}