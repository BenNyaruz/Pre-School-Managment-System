using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class School_Uniform_Record : Form
    {
        public School_Uniform_Record()
        {
            InitializeComponent();
        }

        private void uniform_Managment_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uniform_Managment_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);

        }

        private void School_Uniform_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Uniform_Managment_tbl' table. You can move, or remove it, as needed.
            this.uniform_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Uniform_Managment_tbl);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uniform_Managment_tblBindingSource.RemoveCurrent();
            this.uniform_Managment_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);
        }
    }
}
