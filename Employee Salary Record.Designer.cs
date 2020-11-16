namespace Pre_School_Managment_System
{
    partial class Employee_Salary_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Salary_Record));
            this.system_DatabaseDataSet = new Pre_School_Managment_System.System_DatabaseDataSet();
            this.employee_Salary_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Salary_tblTableAdapter = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.Employee_Salary_tblTableAdapter();
            this.tableAdapterManager = new Pre_School_Managment_System.System_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.employee_Salary_tblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employee_Salary_tblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employee_Salary_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Salary_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Salary_tblBindingNavigator)).BeginInit();
            this.employee_Salary_tblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Salary_tblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // system_DatabaseDataSet
            // 
            this.system_DatabaseDataSet.DataSetName = "System_DatabaseDataSet";
            this.system_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_Salary_tblBindingSource
            // 
            this.employee_Salary_tblBindingSource.DataMember = "Employee_Salary_tbl";
            this.employee_Salary_tblBindingSource.DataSource = this.system_DatabaseDataSet;
            // 
            // employee_Salary_tblTableAdapter
            // 
            this.employee_Salary_tblTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Employee_Salary_tblTableAdapter = this.employee_Salary_tblTableAdapter;
            this.tableAdapterManager.Fees_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Fees_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Project_Directed_Expenses_tblTableAdapter = null;
            this.tableAdapterManager.Project_Income_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Project_Managment_tblTableAdapter = null;
            this.tableAdapterManager.Student_Fees_Payment_tblTableAdapter = null;
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
            // employee_Salary_tblBindingNavigator
            // 
            this.employee_Salary_tblBindingNavigator.AddNewItem = null;
            this.employee_Salary_tblBindingNavigator.BindingSource = this.employee_Salary_tblBindingSource;
            this.employee_Salary_tblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employee_Salary_tblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employee_Salary_tblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.employee_Salary_tblBindingNavigatorSaveItem});
            this.employee_Salary_tblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employee_Salary_tblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employee_Salary_tblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employee_Salary_tblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employee_Salary_tblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employee_Salary_tblBindingNavigator.Name = "employee_Salary_tblBindingNavigator";
            this.employee_Salary_tblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employee_Salary_tblBindingNavigator.Size = new System.Drawing.Size(1533, 26);
            this.employee_Salary_tblBindingNavigator.TabIndex = 0;
            this.employee_Salary_tblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 23);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // employee_Salary_tblBindingNavigatorSaveItem
            // 
            this.employee_Salary_tblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employee_Salary_tblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employee_Salary_tblBindingNavigatorSaveItem.Image")));
            this.employee_Salary_tblBindingNavigatorSaveItem.Name = "employee_Salary_tblBindingNavigatorSaveItem";
            this.employee_Salary_tblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.employee_Salary_tblBindingNavigatorSaveItem.Text = "Save Data";
            this.employee_Salary_tblBindingNavigatorSaveItem.Click += new System.EventHandler(this.Employee_Salary_tblBindingNavigatorSaveItem_Click);
            // 
            // employee_Salary_tblDataGridView
            // 
            this.employee_Salary_tblDataGridView.AllowUserToAddRows = false;
            this.employee_Salary_tblDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employee_Salary_tblDataGridView.AutoGenerateColumns = false;
            this.employee_Salary_tblDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employee_Salary_tblDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employee_Salary_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_Salary_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.employee_Salary_tblDataGridView.DataSource = this.employee_Salary_tblBindingSource;
            this.employee_Salary_tblDataGridView.Location = new System.Drawing.Point(0, 29);
            this.employee_Salary_tblDataGridView.Name = "employee_Salary_tblDataGridView";
            this.employee_Salary_tblDataGridView.Size = new System.Drawing.Size(1533, 631);
            this.employee_Salary_tblDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Employee_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 188;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pay_Day";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pay_Day";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 114;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pay_Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pay_Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 184;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pay_Period";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pay_Period";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 139;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cash_Amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cash_Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 162;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Transfer_Amount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Transfer_Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 193;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Bank_Amount";
            this.dataGridViewTextBoxColumn9.HeaderText = "Bank_Amount";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 163;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Total_Amount_Paid";
            this.dataGridViewTextBoxColumn10.HeaderText = "Total_Amount_Paid";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 213;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Outstanding_Balance";
            this.dataGridViewTextBoxColumn11.HeaderText = "Outstanding_Balance";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 231;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Accountant";
            this.dataGridViewTextBoxColumn12.HeaderText = "Accountant";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 140;
            // 
            // Employee_Salary_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1533, 657);
            this.Controls.Add(this.employee_Salary_tblDataGridView);
            this.Controls.Add(this.employee_Salary_tblBindingNavigator);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Employee_Salary_Record";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Salary Record";
            this.Load += new System.EventHandler(this.Accounting_Employee_Salary_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.system_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Salary_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Salary_tblBindingNavigator)).EndInit();
            this.employee_Salary_tblBindingNavigator.ResumeLayout(false);
            this.employee_Salary_tblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Salary_tblDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System_DatabaseDataSet system_DatabaseDataSet;
        private System.Windows.Forms.BindingSource employee_Salary_tblBindingSource;
        private System_DatabaseDataSetTableAdapters.Employee_Salary_tblTableAdapter employee_Salary_tblTableAdapter;
        private System_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employee_Salary_tblBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employee_Salary_tblBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employee_Salary_tblDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}