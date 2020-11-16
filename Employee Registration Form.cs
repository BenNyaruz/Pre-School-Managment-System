using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Pre_School_Managment_System
{
    public partial class Employee_Registration_Form : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Employee_Registration_Form()
        {
            InitializeComponent();
            Student_dateTimePicker.Value = DateTime.Now;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

            string Marital_Status;
            if (Single_radioButton.Checked == true)
            {
                Marital_Status = Single_radioButton.Text.Trim();
            }
            else if (Married_radioButton.Checked == true)
            {
                Marital_Status = Married_radioButton.Text.Trim();
            }
            else if (Divoced_radioButton.Checked == true)
            {
                Marital_Status = Divoced_radioButton.Text.Trim();
            }
            else
            {
                Marital_Status = "Personal and Complicated";
            }

            string Sex;
            if (Male_radioButton.Checked == true)
            {
                Sex = Male_radioButton.Text.Trim();
            }
            else if (Female_radioButton.Checked == true)
            {
                Sex = Female_radioButton.Text.Trim();
            }
            else
            {
                Sex = "Too Complicated";
            }

            
                                   
            try
            {
                if (National_ID_txt.Text == "" || National_ID_txt.Text == "NULL")
                {
                    MessageBox.Show("National ID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    National_ID_txt.Focus();
                }
                else if (First_Name_txt.Text == "")
                {
                    MessageBox.Show("First Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    First_Name_txt.Focus();
                }
                else if (Surname_txt.Text == "")
                {
                    MessageBox.Show("Surname is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Surname_txt.Focus();
                }
                else if (House_Address_txt.Text == "")
                {
                    MessageBox.Show("House Address is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    House_Address_txt.Focus();
                }
                else if (Contact_Details_txt.Text == "")
                {
                    MessageBox.Show("Contact Details is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Contact_Details_txt.Focus();
                }
                else if (Description_and_Criminal_Record_txt.Text == "")
                {
                    MessageBox.Show("Description and Criminal Record is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Description_and_Criminal_Record_txt.Focus();
                }
                else
                {
                    try
                    {
                        OleDbCommand Employee_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Employee_Registration_Record_tbl] ([First_Name],[Surname],[House_Address],[Contact_Details],[National_Id],[Marital_Status],[Employee_Description],[Sex],[D_O_B],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?,?)"
                        };
                        Employee_Command.Parameters.AddWithValue("@First_Name", First_Name_txt.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@House_Address", House_Address_txt.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@Contact_Details", Contact_Details_txt.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@National_Id", National_ID_txt.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@Marital_Status", Marital_Status.Trim());
                        Employee_Command.Parameters.AddWithValue("@Employee_Description", Description_and_Criminal_Record_txt.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@Sex", Sex.Trim());
                        Employee_Command.Parameters.AddWithValue("@D_O_B", Student_dateTimePicker.Text.Trim());
                        Employee_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Employee_Command.Connection = connection;
                        connection.Open();
                        Employee_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    MessageBox.Show(First_Name_txt.Text.Trim() + " has been successfully added into the School Database", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    First_Name_txt.Text = "";
                    Surname_txt.Text = "";
                    House_Address_txt.Text = "";
                    Contact_Details_txt.Text = "";
                    National_ID_txt.Text = "";
                    Married_radioButton.Checked = false;
                    Single_radioButton.Checked = false;
                    Divoced_radioButton.Checked = false;
                    Description_and_Criminal_Record_txt.Text = "";
                    Male_radioButton.Checked = false;
                    Female_radioButton.Checked = false;
                    Student_dateTimePicker.Value = DateTime.Now;
                    National_ID_txt.Focus();
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace,"Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }
    }
}
