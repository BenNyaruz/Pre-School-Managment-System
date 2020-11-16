using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Employee_Salaries_Wages_Allawance_Form : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Employee_Salaries_Wages_Allawance_Form()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Employee_Name_txt.Text == "")
                {
                    MessageBox.Show("Employee Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Employee_Name_txt.Focus();
                }
                else if (Surname_txt.Text == "")
                {
                    MessageBox.Show("Surname is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Surname_txt.Focus();
                }
                else if (Salary_txt.Value == 0 && Wage_txt.Value == 0 && Allawance_txt.Value == 0)
                {
                    MessageBox.Show("Payment is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Salary_txt.Focus();
                }
                else
                {

                    connection.Open();
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into [Employee_Salaries_Wages_Allawance_Record_tbl] (Employee_Name,Employee_Surname,Pay_Period,Date,Salary,Wage,Allawance,Accountant) values ('" + Employee_Name_txt.Text.Trim() + "','" + Surname_txt.Text.Trim() + "','" + Pay_Period_txt.Text.Trim() + "','" + DateTime.Now + "','" + Salary_txt.Value + "','" + Wage_txt.Value + "','" + Allawance_txt.Value + "','" + User_txt.Text.Trim() + "')";
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show(Employee_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " is expected to receive ;\n\n" + "$" + Salary_txt.Value + "\t\tas Salary\n" + "$" + Wage_txt.Value + "\t\tas Wage\n" + "$" + Allawance_txt.Value + "\t\tas Allawance ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Employee_Name_txt.Text = "";
                    Surname_txt.Text = "";
                    Salary_txt.Value = 0;
                    Wage_txt.Value = 0;
                    Allawance_txt.Value = 0;
                    Employee_Name_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Employee_Salaries_Wages_Allawance_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Employee_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.employee_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Employee_Registration_Record_tbl);
            Employee_Name_txt.Text = "";
            Surname_txt.Text = "";
        }

        private void Employee_Name_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select [Surname] FROM [Employee_Registration_Record_tbl] WHERE First_Name = '" + Employee_Name_txt.Text.Trim() + "'";
            OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                Surname_txt.Text = dtbl.Rows[(dtbl.Rows.Count) - 1][0].ToString();
            }
        }
    }
}
