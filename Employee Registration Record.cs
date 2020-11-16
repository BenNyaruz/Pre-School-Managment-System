using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Pre_School_Managment_System
{
    public partial class Employee_Registration_Record : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Employee_Registration_Record()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Employee_Registration_Record_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Employee_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.employee_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Employee_Registration_Record_tbl);
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [Employee_Registration_Record_tbl]";
                command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command);
                adapt.Fill(dta);
                Employee_Managment_dataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
