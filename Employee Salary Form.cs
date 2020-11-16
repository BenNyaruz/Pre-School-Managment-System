using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Employee_Salary_Form : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Employee_Salary_Form()
        {
            InitializeComponent();                     
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            string Payment_Type = "";
            
            if (Salary_radioButton.Checked == true)
            {
                Payment_Type = Salary_radioButton.Text.Trim();
            }
            else if (Wage_radioButton.Checked == true)
            {
                Payment_Type = Wage_radioButton.Text.Trim();
            }                
            else if (Allawance_radioButton.Checked == true)
            {
                Payment_Type = Allawance_radioButton.Text.Trim();                
            }            
            else
            {
                MessageBox.Show("\tSalary, Wage and/or Allawance is empty.\t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        
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
                else if (Pay_Period_txt.Text == "")
                {
                    MessageBox.Show("Pay Period is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Pay_Period_txt.Focus();
                }
                else if (Cash_txt.Value == 0 && Transfer_txt.Value == 0 && Bank_txt.Value == 0)
                {
                    MessageBox.Show("Payment is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cash_txt.Focus();
                }            
                else 
                {
                    decimal Total = 0;
                    decimal Outstanding_Balance = 0;
                    Total = Cash_txt.Value + Transfer_txt.Value + Bank_txt.Value;
                    Outstanding_Balance = Salary_Due_txt.Value - Total;

                    connection.Open();
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into [Employee_Salary_tbl] (Employee_Name,Surname,Pay_Day,Pay_Description,Pay_Period,Cash_Amount,Transfer_Amount,Bank_Amount,Total_Amount_Paid,Outstanding_Balance,Accountant) values ('" + Employee_Name_txt.Text.Trim() + "','" + Surname_txt.Text.Trim() + "','"+ DateTime.Now + "','" + Payment_Type + "','" + Pay_Period_txt.Text.Trim() + "','" + Cash_txt.Value + "','" + Transfer_txt.Value + "','" + Bank_txt.Value + "','" + Total + "','" + Outstanding_Balance + "','" + User_txt.Text.Trim() + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                    MessageBox.Show(Employee_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has received;\n\n " + "\t\t$" + Total + " as " + Payment_Type, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Employee_Name_txt.Text = "";
                    Surname_txt.Text = "";
                    Payment_Type = "";
                    Pay_Period_txt.Text = "";
                    Cash_txt.Value = 0;
                    Transfer_txt.Value = 0;
                    Bank_txt.Value = 0;
                    Salary_radioButton.Checked = false;
                    Wage_radioButton.Checked = false;
                    Allawance_radioButton.Checked = false;
                    Employee_Name_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Salary_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Salary_radioButton.Checked == true)
            {
                Salary_Due_lbl.Visible = true;
                Salary_Due_txt.Visible = true;
                Salary_Due_lbl.Text = "Salary Due : ";

                string Payment_Type = Salary_radioButton.Text.Trim();
                try
                {
                    string query = "Select [Salary] FROM [Employee_Salaries_Wages_Allawance_Record_tbl] WHERE Employee_Name = '" + Employee_Name_txt.Text.Trim() + "' and Pay_Period = '" + Pay_Period_txt.Text.Trim() + "'";
                    OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);


                    if (dtbl.Rows.Count > 0)
                    {
                        string query2 = "Select [Outstanding_Balance] FROM [Employee_Salary_tbl] WHERE Employee_Name = '" + Employee_Name_txt.Text.Trim() + "' and Pay_Period = '" + Pay_Period_txt.Text.Trim() + "'and Pay_Description = '" + Payment_Type + "'";
                        OleDbDataAdapter sda2 = new OleDbDataAdapter(query2, connection);
                        DataTable dtbl2 = new DataTable();
                        sda2.Fill(dtbl2);

                        if (dtbl2.Rows.Count > 0)
                        {
                            decimal Outstanding = Convert.ToDecimal(dtbl2.Rows[(dtbl2.Rows.Count) - 1][0].ToString());
                            Salary_Due_txt.Value = Outstanding;                                                        
                        }
                        else
                        {
                            decimal Promised = Convert.ToDecimal(dtbl.Rows[0][0].ToString());
                            Salary_Due_txt.Value = Promised;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Salary_Due_lbl.Visible = false;
                Salary_Due_txt.Visible = false;
            }
        }

        private void Employee_Name_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select [Surname] FROM [Employee_Registration_Record_tbl] WHERE First_Name = '" + Employee_Name_txt.Text.Trim() + "'";
                OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Surname_txt.Text = dtbl.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Wage_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Wage_radioButton.Checked == true)
            {
                Salary_Due_lbl.Visible = true;
                Salary_Due_txt.Visible = true;
                Salary_Due_lbl.Text = "Wage Due : ";

                string Payment_Type = Wage_radioButton.Text.Trim();
                try
                {
                    string query = "Select [Wage] FROM [Employee_Salaries_Wages_Allawance_Record_tbl] WHERE Employee_Name = '" + Employee_Name_txt.Text.Trim() + "' and Pay_Period = '" + Pay_Period_txt.Text.Trim() + "'";
                    OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);


                    if (dtbl.Rows.Count > 0)
                    {
                        string query2 = "Select [Outstanding_Balance] FROM [Employee_Salary_tbl] WHERE Employee_Name = '" + Employee_Name_txt.Text.Trim() + "' and Pay_Period = '" + Pay_Period_txt.Text.Trim() + "'and Pay_Description = '" + Payment_Type + "'";
                        OleDbDataAdapter sda2 = new OleDbDataAdapter(query2, connection);
                        DataTable dtbl2 = new DataTable();
                        sda2.Fill(dtbl2);

                        if (dtbl2.Rows.Count > 0)
                        {
                            decimal Outstanding = Convert.ToDecimal(dtbl2.Rows[(dtbl2.Rows.Count) - 1][0].ToString());
                            Salary_Due_txt.Value = Outstanding;
                        }
                        else
                        {
                            decimal Promised = Convert.ToDecimal(dtbl.Rows[0][0].ToString());
                            Salary_Due_txt.Value = Promised;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Salary_Due_lbl.Visible = false;
                Salary_Due_txt.Visible = false;
            }
        }

        private void Allawance_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Allawance_radioButton.Checked == true)
            {
                Salary_Due_lbl.Visible = true;
                Salary_Due_txt.Visible = true;
                Salary_Due_lbl.Text = "Allawance Due : ";

                string Payment_Type = Allawance_radioButton.Text.Trim();
                try
                {
                    string query = "Select [Allawance] FROM [Employee_Salaries_Wages_Allawance_Record_tbl] WHERE Employee_Name = '" + Employee_Name_txt.Text.Trim() + "' and Pay_Period = '" + Pay_Period_txt.Text.Trim() + "'";
                    OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);


                    if (dtbl.Rows.Count > 0)
                    {
                        string query2 = "Select [Outstanding_Balance] FROM [Employee_Salary_tbl] WHERE Employee_Name = '" + Employee_Name_txt.Text.Trim() + "' and Pay_Period = '" + Pay_Period_txt.Text.Trim() + "'and Pay_Description = '" + Payment_Type + "'";
                        OleDbDataAdapter sda2 = new OleDbDataAdapter(query2, connection);
                        DataTable dtbl2 = new DataTable();
                        sda2.Fill(dtbl2);

                        if (dtbl2.Rows.Count > 0)
                        {
                            decimal Outstanding = Convert.ToDecimal(dtbl2.Rows[(dtbl2.Rows.Count) - 1][0].ToString());
                            Salary_Due_txt.Value = Outstanding;
                        }
                        else
                        {
                            decimal Promised = Convert.ToDecimal(dtbl.Rows[0][0].ToString());
                            Salary_Due_txt.Value = Promised;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Salary_Due_lbl.Visible = false;
                Salary_Due_txt.Visible = false;
            }
        }

        private void Employee_Salary_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Employee_Salaries_Wages_Allawance_Record_tbl' table. You can move, or remove it, as needed.
            this.employee_Salaries_Wages_Allawance_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Employee_Salaries_Wages_Allawance_Record_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Employee_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.employee_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Employee_Registration_Record_tbl);
            Employee_Name_txt.Text = "";
            Surname_txt.Text = "";
            Pay_Period_txt.Text = "";
        }
    }
}
