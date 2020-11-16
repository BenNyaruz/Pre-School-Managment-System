using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Pre_School_Managment_System
{
    public partial class System_Settings : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public System_Settings()
        {
            InitializeComponent();
            User_dateTimePicker.Value = DateTime.Now;
            Rate_dateTimePicker.Value = DateTime.Now;
        }

        private void System_Accessibility_Settings_Tab_Click(object sender, System.EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [System_Users_tbl]";
                command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command);
                adapt.Fill(dta);
                Users_dataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username_txt.Text == "")
                {
                    MessageBox.Show("Username is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Username_txt.Focus();
                }
                else if (Password_txt.Text == "")
                {
                    MessageBox.Show("Password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Password_txt.Focus();
                }
                else if (Full_Name_txt.Text == "")
                {
                    MessageBox.Show("Role is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Full_Name_txt.Focus();
                }
                else
                {
                    OleDbCommand command = new OleDbCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO [System_Users_tbl] ([Role],[Username],[Password],[Creation_Date],[Accountant])" + "VALUES (?,?,?,?,?)"
                    };
                    command.Parameters.AddWithValue("@Role", Full_Name_txt.Text.Trim());
                    command.Parameters.AddWithValue("@Username", Username_txt.Text.Trim());
                    command.Parameters.AddWithValue("@Password", Password_txt.Text.Trim());
                    command.Parameters.AddWithValue("@Creation_Date", Convert.ToString(User_dateTimePicker.Text.Trim()));
                    command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show(Username_txt.Text.Trim() + " is now a System User, with\n" + Full_Name_txt.Text.Trim() + " privillages", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Username_txt.Text = "";
                    Password_txt.Text = "";
                    Full_Name_txt.Text = "";
                    User_dateTimePicker.Value = DateTime.Now;
                    Full_Name_txt.Focus();

                    connection.Open();
                    OleDbCommand ViewCommand = connection.CreateCommand();
                    ViewCommand.CommandType = CommandType.Text;
                    ViewCommand.CommandText = "select * from [System_Users_tbl]";
                    ViewCommand.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    OleDbDataAdapter adapt = new OleDbDataAdapter(ViewCommand);
                    adapt.Fill(dta);
                    Users_dataGridView.DataSource = dta;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main_Menu mainfrm = new Main_Menu();
            ((Form)mainfrm).Controls["User_txt"].Text = User_txt.Text;
            ((Form)mainfrm).Controls["Username_lbl"].Text = Username_lbl.Text.Trim();
            ((Form)mainfrm).Controls["Password_lbl"].Text = Password_lbl.Text.Trim();
            mainfrm.Show();
            this.Close();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Main_Menu mainfrm = new Main_Menu();
            ((Form)mainfrm).Controls["User_txt"].Text = User_txt.Text;
            ((Form)mainfrm).Controls["Username_lbl"].Text = Username_lbl.Text.Trim();
            ((Form)mainfrm).Controls["Password_lbl"].Text = Password_lbl.Text.Trim();
            mainfrm.Show();
            this.Close();
        }

        private void System_Log_tab_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [System_Log_tbl]";
                command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command);
                adapt.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Done_btn_Click_1(object sender, EventArgs e)
        {
            Main_Menu mainfrm = new Main_Menu();
            ((Form)mainfrm).Controls["User_txt"].Text = User_txt.Text;
            ((Form)mainfrm).Controls["Username_lbl"].Text = Username_lbl.Text.Trim();
            ((Form)mainfrm).Controls["Password_lbl"].Text = Password_lbl.Text.Trim();
            mainfrm.Show();
            this.Close();
        }

        private void System_Settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.System_Exchange_Rates_tbl' table. You can move, or remove it, as needed.
            this.system_Exchange_Rates_tblTableAdapter.Fill(this.system_DatabaseDataSet.System_Exchange_Rates_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.System_Users_tbl' table. You can move, or remove it, as needed.
            this.system_Users_tblTableAdapter.Fill(this.system_DatabaseDataSet.System_Users_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.System_Log_tbl' table. You can move, or remove it, as needed.
            this.system_Log_tblTableAdapter.Fill(this.system_DatabaseDataSet.System_Log_tbl);
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [System_Users_tbl]";
                command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command);
                adapt.Fill(dta);
                Users_dataGridView.DataSource = dta;
                connection.Close();


                connection.Open();
                OleDbCommand LogCommand = connection.CreateCommand();
                LogCommand.CommandType = CommandType.Text;
                LogCommand.CommandText = "select * from [System_Log_tbl]";
                LogCommand.ExecuteNonQuery();
                DataTable dtaLog = new DataTable();
                OleDbDataAdapter adaptLog = new OleDbDataAdapter(LogCommand);
                adaptLog.Fill(dtaLog);
                dataGridView1.DataSource = dtaLog;
                connection.Close();

                connection.Open();
                OleDbCommand ViewCommand = connection.CreateCommand();
                ViewCommand.CommandType = CommandType.Text;
                ViewCommand.CommandText = "select * from [System_Exchange_Rates_tbl]";
                ViewCommand.ExecuteNonQuery();
                DataTable dtaRate = new DataTable();
                OleDbDataAdapter adaptRate = new OleDbDataAdapter(ViewCommand);
                adaptRate.Fill(dtaRate);
                Exchange_Rate_dataGridView1.DataSource = dtaRate;
                connection.Close();
            }          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (US_To_Cash_numericUpDown.Value == 0)
                {
                    MessageBox.Show("Us$ to cash rate is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    US_To_Cash_numericUpDown.Focus();
                }
                else if (Bank_To_Cash_numericUpDown.Value == 0)
                {
                    MessageBox.Show("Bank to cash rate is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Bank_To_Cash_numericUpDown.Focus();
                }
                else if (Tranfer_To_Cash_numericUpDown.Value == 0)
                {
                    MessageBox.Show("Transfer to cash rate is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Tranfer_To_Cash_numericUpDown.Focus();
                }
                else
                {
                    OleDbCommand command = new OleDbCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO [System_Exchange_Rates_tbl] ([Rate_Date],[US_To_Cash],[Transfer_To_Cash],[Bank_To_Cash],[Accountant])" + "VALUES (?,?,?,?,?)"
                    };
                    command.Parameters.AddWithValue("@Rate_Date", Convert.ToString(Rate_dateTimePicker.Text.Trim()));
                    command.Parameters.AddWithValue("@US_To_Cash", US_To_Cash_numericUpDown.Value);
                    command.Parameters.AddWithValue("@Transfer_To_Cash", Bank_To_Cash_numericUpDown.Value);
                    command.Parameters.AddWithValue("@Bank_To_Cash", Tranfer_To_Cash_numericUpDown.Value);
                    command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("All is set.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    US_To_Cash_numericUpDown.Value = 0;
                    Bank_To_Cash_numericUpDown.Value = 0;
                    Tranfer_To_Cash_numericUpDown.Value = 0;
                    Rate_dateTimePicker.Value = DateTime.Now;
                    US_To_Cash_numericUpDown.Focus();

                    connection.Open();
                    OleDbCommand ViewCommand = connection.CreateCommand();
                    ViewCommand.CommandType = CommandType.Text;
                    ViewCommand.CommandText = "select * from [System_Exchange_Rates_tbl]";
                    ViewCommand.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    OleDbDataAdapter adapt = new OleDbDataAdapter(ViewCommand);
                    adapt.Fill(dta);
                    Exchange_Rate_dataGridView1.DataSource = dta;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
