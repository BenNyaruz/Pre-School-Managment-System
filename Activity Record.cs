using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Activity_Record : Form
    {
        public Activity_Record()
        {
            InitializeComponent();
        }

        private void Activity_Managment_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activity_Managment_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);

        }

        private void Activity_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Activity_Managment_tbl' table. You can move, or remove it, as needed.
            this.activity_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Activity_Managment_tbl);

        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activity_Managment_tblBindingSource.RemoveCurrent();
            this.activity_Managment_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);
        }
    }
}
