using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Assert_Registration_Form : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Assert_Registration_Form()
        {
            InitializeComponent();
            Assert_dateTimePicker.Value = DateTime.Now;
        }

        private void Add_Assert_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Assert_Name_txt.Text == "")
                {
                    MessageBox.Show("Assert Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Assert_Name_txt.Focus();
                }
                else if (Assert_Decription_txt.Text == "")
                {
                    MessageBox.Show("Assert Decription is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Assert_Decription_txt.Focus();
                }
                else if (Assert_Value_txt.Value == 0 )
                {
                    MessageBox.Show("Assert Value is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Assert_Value_txt.Focus();
                }
                else if (Depriciation_Value_txt.Value == 0 )
                {
                    MessageBox.Show("Depriciation Value is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Depriciation_Value_txt.Focus();
                }
                else
                {
                    try
                    {
                        OleDbCommand Assert_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Assert_Managment_tbl] ([Assert_Name],[Assert_Description],[Purchase_Date],[Disposal_Date],[Assert_Value],[Depriciation_Value],[Accountant])" + "VALUES (?,?,?,?,?,?,?)"
                        };
                        Assert_Command.Parameters.AddWithValue("@Assert_Name", Assert_Name_txt.Text.Trim());
                        Assert_Command.Parameters.AddWithValue("@Assert_Description", Assert_Decription_txt.Text.Trim());
                        Assert_Command.Parameters.AddWithValue("@Purchase_Date", Assert_dateTimePicker.Text.Trim());
                        Assert_Command.Parameters.AddWithValue("@Disposal_Date", Disposal_dateTimePicker.Text.Trim());
                        Assert_Command.Parameters.AddWithValue("@Assert_Value", Assert_Value_txt.Value);
                        Assert_Command.Parameters.AddWithValue("@Depriciation_Value", Depriciation_Value_txt.Value);
                        Assert_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Assert_Command.Connection = connection;
                        connection.Open();
                        Assert_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    MessageBox.Show(Assert_Name_txt.Text.Trim() + " is now School Property till " + Disposal_dateTimePicker.Value + ".\nIt will be depriciating by $" + Depriciation_Value_txt.Value, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Assert_Name_txt.Text = "";
                    Assert_Decription_txt.Text = "";                   
                    Assert_Value_txt.Value = 0;
                    Depriciation_Value_txt.Value = 0;
                    Assert_Name_txt.Focus();
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
