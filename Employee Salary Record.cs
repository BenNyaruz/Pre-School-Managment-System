using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Employee_Salary_Record : Form
    {
        public Employee_Salary_Record()
        {
            InitializeComponent();
        }

        private void Employee_Salary_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_Salary_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);

        }

        private void Accounting_Employee_Salary_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Employee_Salary_tbl' table. You can move, or remove it, as needed.
            this.employee_Salary_tblTableAdapter.Fill(this.system_DatabaseDataSet.Employee_Salary_tbl);

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_Salary_tblBindingSource.RemoveCurrent();
            this.employee_Salary_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);

        }
    }
}
