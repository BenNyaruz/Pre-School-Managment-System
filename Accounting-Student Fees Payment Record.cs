using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Accounting_Student_Fees_Payment_Record : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);
        private string Current_School_Term;

        public Accounting_Student_Fees_Payment_Record()
        {
            InitializeComponent();
        }

        private void Accounting_Student_Fees_Payment_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Student_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.student_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Student_Registration_Record_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Fees_Managment_tbl' table. You can move, or remove it, as needed.
            this.fees_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Fees_Managment_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Student_Fees_Payment_tbl' table. You can move, or remove it, as needed.
            //            this.student_Fees_Payment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Student_Fees_Payment_tbl);
            try
            {
                string Current_School_Term_Query = "Select [School_Term] FROM [Fees_Managment_tbl]";
                OleDbDataAdapter Current_School_Term_Adapt = new OleDbDataAdapter(Current_School_Term_Query, connection);
                DataTable Current_School_Term_Tbl = new DataTable();
                Current_School_Term_Adapt.Fill(Current_School_Term_Tbl);
                Current_School_Term = Current_School_Term_Tbl.Rows[(Current_School_Term_Tbl.Rows.Count) - 1][0].ToString();
            }
            catch
            {
                MessageBox.Show("Please add a School Term into the system.\n\t\t :(", "School Term Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #region Table Load
            try
            {
                connection.Open();
                OleDbCommand Table_Load_command = connection.CreateCommand();
                Table_Load_command.CommandType = CommandType.Text;
                Table_Load_command.CommandText = "select * from [Student_Fees_Payment_tbl] WHERE School_Term = '" + Current_School_Term + "'";
                Table_Load_command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(Table_Load_command);
                adapt.Fill(dta);
                student_Fees_Payment_tblDataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            groupBox1.Enabled = false;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_Fees_Payment_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.system_DatabaseDataSet);
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            if (View_All_radioButton.Checked==true)
            {
                #region Table Load
                try
                {
                    connection.Open();
                    OleDbCommand Table_Load_command = connection.CreateCommand();
                    Table_Load_command.CommandType = CommandType.Text;
                    Table_Load_command.CommandText = "select * from [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt_Std.Text.Trim() + "'";
                    Table_Load_command.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    OleDbDataAdapter adapt = new OleDbDataAdapter(Table_Load_command);
                    adapt.Fill(dta);
                    student_Fees_Payment_tblDataGridView.DataSource = dta;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }            
            else if (View_Student_radioButton.Checked == true)
            {
                #region Table Load
                try
                {
                    connection.Open();
                    OleDbCommand Table_Load_command = connection.CreateCommand();
                    Table_Load_command.CommandType = CommandType.Text;
                    Table_Load_command.CommandText = "select * from [Student_Fees_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt_Std.Text.Trim() + "'";
                    Table_Load_command.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    OleDbDataAdapter adapt = new OleDbDataAdapter(Table_Load_command);
                    adapt.Fill(dta);
                    student_Fees_Payment_tblDataGridView.DataSource = dta;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }

        }

        private void View_All_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            #region Table Load
            try
            {
                connection.Open();
                OleDbCommand Table_Load_command = connection.CreateCommand();
                Table_Load_command.CommandType = CommandType.Text;
                Table_Load_command.CommandText = "select * from [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt_Std.Text.Trim() + "'";
                Table_Load_command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(Table_Load_command);
                adapt.Fill(dta);
                student_Fees_Payment_tblDataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
            #endregion

            groupBox1.Enabled = false;
        }

        private void View_Student_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
