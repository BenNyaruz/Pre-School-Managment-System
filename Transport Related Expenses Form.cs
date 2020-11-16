using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Transport_Related_Expenses_Form : Form
    {
        OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);
        private decimal Total_Cash_Before_Expense;
        private decimal Total_Expenses_Before_Expense;
        private decimal Total_Profit_Before_Expense;
        private string Expense_Method;
        private decimal Total_Cash_Expense_Before_Expense;
        private decimal Total_Bank_Expense_Before_Expense;
        private decimal Total_Transfer_Expense_Before_Expense;
        private decimal Total_Other_Expense_Before_Expense;
        private decimal Total_Cash_Expenses_After_Expense;
        private decimal Total_Transfer_Expenses_After_Expense;
        private decimal Total_Bank_Expenses_After_Expense;
        private decimal Total_Other_Expenses_After_Expense;
        private decimal Total_Expense_After_Expense;
        private decimal Total_Profit_After_Expense;

        public Transport_Related_Expenses_Form()
        {
            InitializeComponent();
            Expense_Date_dateTimePicker.Value = DateTime.Now;
        }

        private void Transport_Related_Expenses_Form_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Transport_Managment_tbl' table. You can move, or remove it, as needed.
            this.transport_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Transport_Managment_tbl);
            #region Rates
            try
            {
                string TransferQuery = "Select [Transfer_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Expense_Date_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter TransferAdapt = new OleDbDataAdapter(TransferQuery, connection);
                DataTable TransferTbl = new DataTable();
                TransferAdapt.Fill(TransferTbl);
                Transfer_Rate_lbl.Text = TransferTbl.Rows[(TransferTbl.Rows.Count) - 1][0].ToString();


                string BankQuery = "Select [Bank_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Expense_Date_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter BankAdapt = new OleDbDataAdapter(BankQuery, connection);
                DataTable BankTbl = new DataTable();
                BankAdapt.Fill(BankTbl);
                Bank_Rate_lbl.Text = BankTbl.Rows[(BankTbl.Rows.Count) - 1][0].ToString();


                string OtherQuery = "Select [US_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Expense_Date_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter OtherAdapt = new OleDbDataAdapter(OtherQuery, connection);
                DataTable OtherTbl = new DataTable();
                OtherAdapt.Fill(OtherTbl);
                Other_Rate_lbl.Text = OtherTbl.Rows[(OtherTbl.Rows.Count) - 1][0].ToString();
            }
            catch
            {
                MessageBox.Show("Please go to your Settings and enter today's Exchange Rates.\n\t\t :(", "Exchange Rates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Table Load
            try
            {
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [Transport_Directed_Expenses_tbl]";
                command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(command);
                adapt.Fill(dta);
                Expense_Managment_dataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            School_Term_txt.Text = "";
            Expense_Date_dateTimePicker.Value = DateTime.Now;
        }

        private void School_Term_txt_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            #region Total Cash Before Expense
            try
            {
                string School_Transport_Query = "Select [Total_Received] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Transport_Adapt = new OleDbDataAdapter(School_Transport_Query, connection);
                DataTable School_Transport_Tbl = new DataTable();
                School_Transport_Adapt.Fill(School_Transport_Tbl);

                if (School_Transport_Tbl.Rows.Count > 0)
                {
                    Total_Received_txt.Value = Convert.ToDecimal(School_Transport_Tbl.Rows[(School_Transport_Tbl.Rows.Count) - 1][0].ToString());
                    Total_Cash_Before_Expense = Total_Received_txt.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Expenses Before Expense
            try
            {
                string School_Expense_Query = "Select [Total_Expenses] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    Total_Expenses_txt.Value = Convert.ToDecimal(School_Expense_Tbl.Rows[(School_Expense_Tbl.Rows.Count) - 1][0].ToString());
                    Total_Expenses_Before_Expense = Total_Expenses_txt.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Profit Before Expense
            try
            {
                string Transport_Profit_Query = "Select [Total_Profit] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Transport_Profit_Adapt = new OleDbDataAdapter(Transport_Profit_Query, connection);
                DataTable Transport_Profit_Tbl = new DataTable();
                Transport_Profit_Adapt.Fill(Transport_Profit_Tbl);

                if (Transport_Profit_Tbl.Rows.Count > 0)
                {
                    Transport_Profit_txt.Text = Transport_Profit_Tbl.Rows[(Transport_Profit_Tbl.Rows.Count) - 1][0].ToString();
                    Total_Profit_Before_Expense = Convert.ToDecimal(Transport_Profit_txt.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion
        }

        private void Add_Expense_btn_Click(object sender, EventArgs e)
        {
            #region Previous Values
            try
            {
                string Transport_Query = "Select [Total_Cash_Expenses],[Total_Transfer_Expenses],[Total_Bank_Expenses],[Total_Other_Expenses],[Total_Expenses],[Total_Profit] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                DataTable Transport_Tbl = new DataTable();
                Transport_Adapt.Fill(Transport_Tbl);

                Total_Cash_Expense_Before_Expense = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][0].ToString());
                Total_Transfer_Expense_Before_Expense = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][1].ToString());
                Total_Bank_Expense_Before_Expense = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][2].ToString());
                Total_Other_Expense_Before_Expense = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][3].ToString());
                Total_Expenses_Before_Expense = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][4].ToString());
                Total_Profit_Before_Expense = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][5].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Cash
            if (Cash_radioButton.Checked == true)
            {
                Expense_Method = Cash_radioButton.Text;

                Total_Cash_Expenses_After_Expense = Total_Cash_Expense_Before_Expense + Expense_Amount_txt.Value;
                Total_Expense_After_Expense = Total_Expenses_Before_Expense + Expense_Amount_txt.Value;
                Total_Profit_After_Expense = Total_Cash_Before_Expense - Total_Expense_After_Expense;

                #region Transport Update
                try
                {
                    connection.Open();
                    OleDbCommand Total_Cash_Expense_Command = connection.CreateCommand();
                    Total_Cash_Expense_Command.CommandType = CommandType.Text;
                    Total_Cash_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Cash_Expenses = '" + Total_Cash_Expenses_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Cash_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Expense_Command = connection.CreateCommand();
                    Total_Expense_Command.CommandType = CommandType.Text;
                    Total_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Expenses = '" + Total_Expense_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Profit_Command = connection.CreateCommand();
                    Total_Profit_Command.CommandType = CommandType.Text;
                    Total_Profit_Command.CommandText = "update [Transport_Managment_tbl] set Total_Profit = '" + Total_Profit_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Profit_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion
            }
            #endregion

            #region Transfer
            else if (Transfer_radioButton.Checked == true)
            {
                Expense_Method = Transfer_radioButton.Text;

                Total_Transfer_Expenses_After_Expense = Total_Transfer_Expense_Before_Expense + Expense_Amount_txt.Value;
                Total_Expense_After_Expense = Total_Expenses_Before_Expense + (Expense_Amount_txt.Value * Convert.ToDecimal(Transfer_Rate_lbl.Text));
                Total_Profit_After_Expense = Total_Cash_Before_Expense - Total_Expense_After_Expense;

                #region Transport Update
                try
                {
                    connection.Open();
                    OleDbCommand Total_Transfer_Expense_Command = connection.CreateCommand();
                    Total_Transfer_Expense_Command.CommandType = CommandType.Text;
                    Total_Transfer_Expense_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Transfer_Expenses = '" + Total_Transfer_Expenses_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Transfer_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Expense_Command = connection.CreateCommand();
                    Total_Expense_Command.CommandType = CommandType.Text;
                    Total_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Expenses = '" + Total_Expense_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Profit_Command = connection.CreateCommand();
                    Total_Profit_Command.CommandType = CommandType.Text;
                    Total_Profit_Command.CommandText = "update [Transport_Managment_tbl] set Total_Profit = '" + Total_Profit_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Profit_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion
            }
            #endregion

            #region Bank
            else if (Bank_radioButton.Checked == true)
            {
                Expense_Method = Bank_radioButton.Text;

                Total_Bank_Expenses_After_Expense = Total_Bank_Expense_Before_Expense + Expense_Amount_txt.Value;
                Total_Expense_After_Expense = Total_Expenses_Before_Expense + (Expense_Amount_txt.Value * Convert.ToDecimal(Bank_Rate_lbl.Text));
                Total_Profit_After_Expense = Total_Cash_Before_Expense - Expense_Amount_txt.Value;

                #region Transport Update
                try
                {
                    connection.Open();
                    OleDbCommand Total_Bank_Expense_Command = connection.CreateCommand();
                    Total_Bank_Expense_Command.CommandType = CommandType.Text;
                    Total_Bank_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Bank_Expenses = '" + Total_Bank_Expenses_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Bank_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Expense_Command = connection.CreateCommand();
                    Total_Expense_Command.CommandType = CommandType.Text;
                    Total_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Expenses = '" + Total_Expense_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Profit_Command = connection.CreateCommand();
                    Total_Profit_Command.CommandType = CommandType.Text;
                    Total_Profit_Command.CommandText = "update [Transport_Managment_tbl] set Total_Profit = '" + Total_Profit_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Profit_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion
            }
            #endregion

            #region Other
            else if (Other_radioButton.Checked == true)
            {
                Expense_Method = Other_radioButton.Text;

                Total_Other_Expenses_After_Expense = Total_Other_Expense_Before_Expense + Expense_Amount_txt.Value;
                Total_Expense_After_Expense = Total_Expenses_Before_Expense + (Expense_Amount_txt.Value * Convert.ToDecimal(Other_Rate_lbl.Text));
                Total_Profit_After_Expense = Total_Cash_Before_Expense - Total_Expense_After_Expense;

                #region Transport Update
                try
                {
                    connection.Open();
                    OleDbCommand Total_Other_Expense_Command = connection.CreateCommand();
                    Total_Other_Expense_Command.CommandType = CommandType.Text;
                    Total_Other_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Other_Expenses = '" + Total_Other_Expenses_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Other_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Expense_Command = connection.CreateCommand();
                    Total_Expense_Command.CommandType = CommandType.Text;
                    Total_Expense_Command.CommandText = "update [Transport_Managment_tbl] set Total_Expenses = '" + Total_Expense_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Expense_Command.ExecuteNonQuery();

                    OleDbCommand Total_Profit_Command = connection.CreateCommand();
                    Total_Profit_Command.CommandType = CommandType.Text;
                    Total_Profit_Command.CommandText = "update [Transport_Managment_tbl] set Total_Profit = '" + Total_Profit_After_Expense + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Profit_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion
            }
            #endregion

            #region Insert Into Expense Record
            try
            {
                OleDbCommand Transport_Command = new OleDbCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = "INSERT INTO [Transport_Directed_Expenses_tbl] ([School_Term],[Transport_Date],[Expense_Description],[Expense_Type],[Expense_Amount],[Accountant])" + "VALUES (?,?,?,?,?,?)"
                };
                Transport_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                Transport_Command.Parameters.AddWithValue("@Transport_Date", Expense_Date_dateTimePicker.Text.Trim());
                Transport_Command.Parameters.AddWithValue("@Expense_Description", Expense_Description_txt.Text.Trim());
                Transport_Command.Parameters.AddWithValue("@Expense_Type", Expense_Method);
                Transport_Command.Parameters.AddWithValue("@Expense_Amount", Expense_Amount_txt.Value);
                Transport_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                Transport_Command.Connection = connection;
                connection.Open();
                Transport_Command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Table Load
            try
            {
                connection.Open();
                OleDbCommand Table_Load_command = connection.CreateCommand();
                Table_Load_command.CommandType = CommandType.Text;
                Table_Load_command.CommandText = "select * from [Transport_Directed_Expenses_tbl]";
                Table_Load_command.ExecuteNonQuery();
                DataTable dta = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(Table_Load_command);
                adapt.Fill(dta);
                Expense_Managment_dataGridView.DataSource = dta;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            Expense_Description_txt.Text = "";
            School_Term_txt.Text = "";
            School_Term_txt.Focus();
            Expense_Amount_txt.Value = 0;
            Total_Received_txt.Value = Total_Cash_Before_Expense;
            Total_Expenses_txt.Value = Total_Expense_After_Expense;
            Transport_Profit_txt.Text = Total_Profit_After_Expense.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (School_Term_txt.Text == "")
            {
                Add_Expense_btn.Enabled = false;
            }
            else
            {
                Add_Expense_btn.Enabled = true;
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
