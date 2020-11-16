using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Student_Registraton_Form : Form
    {
        OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Student_Registraton_Form()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, System.EventArgs e)
        {            
            string Sex = "";
            if (Boy_radioButton.Checked == true)
            {
                Sex = Boy_radioButton.Text.Trim();
            }
            else if (Girl_radioButton.Checked == true)
            {
                Sex = Girl_radioButton.Text.Trim();
            }


            try
            {
                if (First_Name_txt.Text == "")
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
                else if (Parent_Gaurdian_txt.Text == "")
                {
                    MessageBox.Show("Parent or Gaurdian is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Parent_Gaurdian_txt.Focus();
                }
                else if (Health_Record_txt.Text == "")
                {
                    MessageBox.Show("Health Record is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Health_Record_txt.Focus();
                }
                else if (Description_and_Special_needs_txt.Text == "")
                {
                    MessageBox.Show("Description and Special Needs is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Description_and_Special_needs_txt.Focus();
                }
                else
                {                    
                    try
                    {
                        OleDbCommand Student_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Registration_Record_tbl] ([First_Name],[Surname],[House_Address],[Contact_Details],[Parent_Gaurdian],[Health_Record],[Description_Special_Needs],[Sex],[D_O_B],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?,?)"
                        };
                        Student_Command.Parameters.AddWithValue("@First_Name", First_Name_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@House_Address", House_Address_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Contact_Details", Contact_Details_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Parent_Gaurdian", Parent_Gaurdian_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Health_Record", Health_Record_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Description_Special_Needs", Description_and_Special_needs_txt.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Sex", Sex.Trim());
                        Student_Command.Parameters.AddWithValue("@D_O_B", Student_dateTimePicker.Text.Trim());
                        Student_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Student_Command.Connection = connection;
                        connection.Open();
                        Student_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    MessageBox.Show(First_Name_txt.Text.Trim() +" " + Surname_txt.Text.Trim() + " has been successfully added into the School Database", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    First_Name_txt.Text = "";
                    Surname_txt.Text = "";
                    House_Address_txt.Text = "";
                    Contact_Details_txt.Text = "";
                    Parent_Gaurdian_txt.Text = "";
                    Health_Record_txt.Text = "";
                    Description_and_Special_needs_txt.Text = "";
                    Boy_radioButton.Checked = false;
                    Girl_radioButton.Checked = false;
                    Student_dateTimePicker.Value = DateTime.Now;
                    First_Name_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
