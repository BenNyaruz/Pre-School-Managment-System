using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Student_Registration_Record : Form
    {
        OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Student_Registration_Record()
        {
            InitializeComponent();
        }

        private void Student_Registration_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Student_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.student_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Student_Registration_Record_tbl);
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [Student_Registration_Record_tbl]";
                command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command);
                adapt.Fill(dta);
                Student_Registration_Record_dataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
