using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Activity_Registration_Form : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);
        private decimal Total_Cash_Before_Payment;
        private string Payment_Method;
        private decimal Cash_Balance_Before_Payment;
        private decimal Total_Transfer_Before_Payment;
        private decimal Total_Bank_Before_Payment;
        private decimal Total_Other_Before_Payment;
        private decimal Cash_Balance_After_Payment;
        private decimal Total_Transfer_After_Payment;
        private decimal Total_Bank_After_Payment;
        private decimal Total_Other_After_Payment;
        private decimal Total_Cash_After_Payment;
        private decimal Total_Cash_Debts_After_Payment;
        private decimal Activity_Fees;
        private int Student_Counter;
        private int Number_Of_Students_Before_Payment;
        private decimal Total_Cash_Paid;

        public Activity_Registration_Form()
        {
            InitializeComponent();
            Student_dateTimePicker.Value = DateTime.Now;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {   
            string ActivityQuery = "Select [Cash_Fees],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Student_Suppoort] FROM [Activity_Managment_tbl] WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
            OleDbDataAdapter ActivityAdapt = new OleDbDataAdapter(ActivityQuery, connection);
            DataTable ActivityTbl = new DataTable();
            ActivityAdapt.Fill(ActivityTbl);

            Activity_Fees = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][0].ToString());
            Total_Transfer_Before_Payment = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][1].ToString());
            Total_Bank_Before_Payment = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][2].ToString());
            Total_Other_Before_Payment = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][3].ToString());
            Total_Cash_Before_Payment = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][4].ToString());
            Number_Of_Students_Before_Payment = Convert.ToInt32(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][5].ToString());
            Payment_Method = "";


            if (Cash_Balance_Before_Payment == Activity_Fees)
            {
                Student_Counter = 1;
            }
            else
            {
                Student_Counter = 0;   
            }

            
            if (Cash_radioButton.Checked == true)
            {
                Payment_Method = Cash_radioButton.Text.Trim();
                this.Cash_Balance_After_Payment = Convert.ToDecimal(Cash_Balance_Before_Payment) - Activity_Fee_txt.Value;
                Total_Cash_After_Payment = Total_Cash_Before_Payment + Activity_Fee_txt.Value;
                Total_Cash_Paid = Activity_Fee_txt.Value;
                Number_Of_Students_Before_Payment += Student_Counter;
                Total_Cash_Debts_After_Payment = (Activity_Fees * Number_Of_Students_Before_Payment) - Total_Cash_After_Payment;


                try
                {   
                    connection.Open();
                    OleDbCommand Total_Cash_Command = connection.CreateCommand();
                    Total_Cash_Command.CommandType = CommandType.Text;
                    Total_Cash_Command.CommandText = "update [Activity_Managment_tbl] set Total_Received = '" + Total_Cash_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Cash_Command.ExecuteNonQuery();

                    OleDbCommand Total_Debts_Command = connection.CreateCommand();
                    Total_Debts_Command.CommandType = CommandType.Text;
                    Total_Debts_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Debts = '" + Total_Cash_Debts_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Debts_Command.ExecuteNonQuery();

                    OleDbCommand Total_Students_Command = connection.CreateCommand();
                    Total_Students_Command.CommandType = CommandType.Text;
                    Total_Students_Command.CommandText = "update [Activity_Managment_tbl] set Total_Student_Suppoort = '" + Number_Of_Students_Before_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Students_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Transfer_radioButton.Checked == true)
            {
                Payment_Method = Transfer_radioButton.Text.Trim();
                double Transfer_Value = Convert.ToDouble(Activity_Fee_txt.Value);
                double Rate = Convert.ToDouble(Transfer_Rate_lbl.Text);
                double Transfer_To_Cash_Total = Transfer_Value * Rate;
                Total_Cash_Paid = Convert.ToDecimal(Transfer_To_Cash_Total);
                this.Cash_Balance_After_Payment = Cash_Balance_Before_Payment - Convert.ToDecimal(Transfer_To_Cash_Total);
                Total_Transfer_After_Payment = Total_Transfer_Before_Payment + Activity_Fee_txt.Value;
                Total_Cash_After_Payment = Convert.ToDecimal(Total_Cash_Before_Payment) + Convert.ToDecimal(Transfer_To_Cash_Total);
                Number_Of_Students_Before_Payment += Student_Counter;
                Total_Cash_Debts_After_Payment = (Activity_Fees * Number_Of_Students_Before_Payment) - Total_Cash_After_Payment;


                try
                {
                    connection.Open();
                    OleDbCommand Total_Cash_Command = connection.CreateCommand();
                    Total_Cash_Command.CommandType = CommandType.Text;
                    Total_Cash_Command.CommandText = "update [Activity_Managment_tbl] set Total_Received = '" + Total_Cash_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Cash_Command.ExecuteNonQuery();

                    OleDbCommand Total_Transfer_Command = connection.CreateCommand();
                    Total_Transfer_Command.CommandType = CommandType.Text;
                    Total_Transfer_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Transfer_Received = '" + Total_Transfer_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Transfer_Command.ExecuteNonQuery();

                    OleDbCommand Total_Debts_Command = connection.CreateCommand();
                    Total_Debts_Command.CommandType = CommandType.Text;
                    Total_Debts_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Debts = '" + Total_Cash_Debts_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Debts_Command.ExecuteNonQuery();

                    OleDbCommand Total_Students_Command = connection.CreateCommand();
                    Total_Students_Command.CommandType = CommandType.Text;
                    Total_Students_Command.CommandText = "update [Activity_Managment_tbl] set Total_Student_Suppoort = '" + Number_Of_Students_Before_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Students_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Bank_radioButton.Checked == true)
            {
                Payment_Method = Bank_radioButton.Text.Trim();
                double Bank_Value = Convert.ToDouble(Activity_Fee_txt.Value);
                double Rate = Convert.ToDouble(Bank_Rate_lbl.Text);
                double Bank_To_Cash_Total = Bank_Value * Rate;
                Total_Cash_Paid = Convert.ToDecimal(Bank_To_Cash_Total);
                this.Cash_Balance_After_Payment = Cash_Balance_Before_Payment - Convert.ToDecimal(Bank_To_Cash_Total);
                Total_Cash_After_Payment = Convert.ToDecimal(Total_Cash_Before_Payment) + Convert.ToDecimal(Bank_To_Cash_Total);
                Total_Bank_After_Payment = Total_Bank_Before_Payment + Activity_Fee_txt.Value;
                Number_Of_Students_Before_Payment += Student_Counter;
                Total_Cash_Debts_After_Payment = (Activity_Fees * Number_Of_Students_Before_Payment) - Total_Cash_After_Payment;


                try
                {
                    connection.Open();
                    OleDbCommand Total_Cash_Command = connection.CreateCommand();
                    Total_Cash_Command.CommandType = CommandType.Text;
                    Total_Cash_Command.CommandText = "update [Activity_Managment_tbl] set Total_Received = '" + Total_Cash_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Cash_Command.ExecuteNonQuery();

                    OleDbCommand Total_Bank_Command = connection.CreateCommand();
                    Total_Bank_Command.CommandType = CommandType.Text;
                    Total_Bank_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Bank_Received = '" + Total_Bank_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Bank_Command.ExecuteNonQuery();

                    OleDbCommand Total_Debts_Command = connection.CreateCommand();
                    Total_Debts_Command.CommandType = CommandType.Text;
                    Total_Debts_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Debts = '" + Total_Cash_Debts_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Debts_Command.ExecuteNonQuery();

                    OleDbCommand Total_Students_Command = connection.CreateCommand();
                    Total_Students_Command.CommandType = CommandType.Text;
                    Total_Students_Command.CommandText = "update [Activity_Managment_tbl] set Total_Student_Suppoort = '" + Number_Of_Students_Before_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Students_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Other_radioButton.Checked == true)
            {
                Payment_Method = Other_radioButton.Text.Trim();
                double Other_Value = Convert.ToDouble(Activity_Fee_txt.Value);
                double Rate = Convert.ToDouble(Other_Rate_lbl.Text);
                double Other_To_Cash_Total = Other_Value * Rate;
                Total_Cash_Paid = Convert.ToDecimal(Other_To_Cash_Total);
                this.Cash_Balance_After_Payment = Cash_Balance_Before_Payment - Convert.ToDecimal(Other_To_Cash_Total);
                Total_Cash_After_Payment = Convert.ToDecimal(Total_Cash_Before_Payment) + Convert.ToDecimal(Other_To_Cash_Total);
                Total_Other_After_Payment = Total_Other_Before_Payment + Activity_Fee_txt.Value;
                Number_Of_Students_Before_Payment += Student_Counter;
                Total_Cash_Debts_After_Payment = (Activity_Fees * Number_Of_Students_Before_Payment) - Total_Cash_After_Payment;


                try
                {
                    connection.Open();
                    OleDbCommand Total_Cash_Command = connection.CreateCommand();
                    Total_Cash_Command.CommandType = CommandType.Text;
                    Total_Cash_Command.CommandText = "update [Activity_Managment_tbl] set Total_Received = '" + Total_Cash_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Cash_Command.ExecuteNonQuery();

                    OleDbCommand Total_Other_Command = connection.CreateCommand();
                    Total_Other_Command.CommandType = CommandType.Text;
                    Total_Other_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Other_Received = '" + Total_Other_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Other_Command.ExecuteNonQuery();

                    OleDbCommand Total_Debts_Command = connection.CreateCommand();
                    Total_Debts_Command.CommandType = CommandType.Text;
                    Total_Debts_Command.CommandText = "update [Activity_Managment_tbl]  set Total_Debts = '" + Total_Cash_Debts_After_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Debts_Command.ExecuteNonQuery();

                    OleDbCommand Total_Students_Command = connection.CreateCommand();
                    Total_Students_Command.CommandType = CommandType.Text;
                    Total_Students_Command.CommandText = "update [Activity_Managment_tbl] set Total_Student_Suppoort = '" + Number_Of_Students_Before_Payment + "' WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    Total_Students_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            try
            {
                try
                {
                    OleDbCommand Activity_Command = new OleDbCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO [Activity_Registration_tbl] ([First_Name],[Surname],[Activity_Name],[School_Term],[Activity_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?,?)"
                    };
                    Activity_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                    Activity_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                    Activity_Command.Parameters.AddWithValue("@Activity_Name", Activity_Name_txt.Text.Trim());
                    Activity_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                    Activity_Command.Parameters.AddWithValue("@Activity_Date", Student_dateTimePicker.Text.Trim());
                    Activity_Command.Parameters.AddWithValue("@Payment_Method", Payment_Method);
                    Activity_Command.Parameters.AddWithValue("@Amount_Paid", Activity_Fee_txt.Value);
                    Activity_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Paid);
                    Activity_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Balance_After_Payment);
                    Activity_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                    Activity_Command.Connection = connection;
                    connection.Open();
                    Activity_Command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n " + "\t\t$" + Total_Cash_Paid + " in " + Payment_Method, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                Payment_Method = "";
                Cash_Balance_Before_Payment = 0;
                Cash_Balance_After_Payment = 0;
                Activity_Name_txt.Text = "";
                Activity_Fee_txt.Value = 0;
                Total_Cash_Paid = 0;
                Student_Counter = 0;
                School_Term_txt.Text = "";
                Activity_Balance_txt.Value = 0;
                Activity_Balance_lbl.Text = "Activity Balance :";
                Student_dateTimePicker.Value = DateTime.Now;
                Cash_radioButton.Checked = false;
                Transfer_radioButton.Checked = false;
                Bank_radioButton.Checked = false;
                Other_radioButton.Checked = false;
                Save_btn.Enabled = false;
                Accept_checkBox.Checked = false;
                Student_Name_txt.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cash_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cash_radioButton.Checked == true)
            {
                Activity_Balance_lbl.Text = "Cash Balance :";
                                
                try
                {
                    string ActivityQuery = "Select [Cash_Fees] FROM [Activity_Managment_tbl] WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter ActivityAdapt = new OleDbDataAdapter(ActivityQuery, connection);
                    DataTable ActivityTbl = new DataTable();
                    ActivityAdapt.Fill(ActivityTbl);


                    if (ActivityTbl.Rows.Count > 0)
                    {
                        string CashQuery = "Select [Amount_Owing] FROM [Activity_Registration_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        OleDbDataAdapter CashAdapt = new OleDbDataAdapter(CashQuery, connection);
                        DataTable CashTbl = new DataTable();
                        CashAdapt.Fill(CashTbl);

                        if (CashTbl.Rows.Count > 0)
                        {
                            Activity_Balance_txt.Value = Convert.ToDecimal(CashTbl.Rows[(CashTbl.Rows.Count) - 1][0].ToString());
                            Cash_Balance_Before_Payment = Activity_Balance_txt.Value;
                        }
                        else
                        {
                            Activity_Balance_txt.Value = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][0].ToString());
                            Cash_Balance_Before_Payment = Activity_Balance_txt.Value;
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Transfer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Transfer_radioButton.Checked == true)
            {                
                Activity_Balance_lbl.Text = "Transfer Balance :";
                
                try
                {
                    Activity_Balance_txt.Value = Cash_Balance_Before_Payment / Convert.ToDecimal(Transfer_Rate_lbl.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        }

        private void Bank_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Bank_radioButton.Checked == true)
            {
                Activity_Balance_lbl.Text = "Bank Balance :";
                
                try
                {
                    Activity_Balance_txt.Value = Cash_Balance_Before_Payment / Convert.ToDecimal(Bank_Rate_lbl.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          string query = "Select [Surname] FROM [Student_Registration_Record_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "'";
          OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
          DataTable dtbl = new DataTable();
          sda.Fill(dtbl);

            if (dtbl.Rows.Count > 0)
            {
                Surname_txt.Text = dtbl.Rows[(dtbl.Rows.Count) - 1][0].ToString();
            }
        }

        private void Other_radioButton1_CheckedChanged(object sender, EventArgs e)
        {            
            if (Other_radioButton.Checked == true)
            {
                Activity_Balance_lbl.Text = "Other Balance : ";
                
                try
                {
                    Activity_Balance_txt.Value = Cash_Balance_Before_Payment / Convert.ToDecimal(Other_Rate_lbl.Text); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Activity_Registration_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Fees_Managment_tbl' table. You can move, or remove it, as needed.
            this.fees_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Fees_Managment_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Activity_Managment_tbl' table. You can move, or remove it, as needed.
            this.activity_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Activity_Managment_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Student_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.student_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Student_Registration_Record_tbl);
            try
            {
                string TransferQuery = "Select [Transfer_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Student_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter TransferAdapt = new OleDbDataAdapter(TransferQuery, connection);
                DataTable TransferTbl = new DataTable();
                TransferAdapt.Fill(TransferTbl);
                Transfer_Rate_lbl.Text = TransferTbl.Rows[(TransferTbl.Rows.Count)-1][0].ToString();


                string BankQuery = "Select [Bank_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Student_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter BankAdapt = new OleDbDataAdapter(BankQuery, connection);
                DataTable BankTbl = new DataTable();
                BankAdapt.Fill(BankTbl);
                Bank_Rate_lbl.Text = BankTbl.Rows[(BankTbl.Rows.Count)-1][0].ToString();


                string OtherQuery = "Select [US_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Student_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter OtherAdapt = new OleDbDataAdapter(OtherQuery, connection);
                DataTable OtherTbl = new DataTable();
                OtherAdapt.Fill(OtherTbl);
                Other_Rate_lbl.Text = OtherTbl.Rows[(OtherTbl.Rows.Count)-1][0].ToString();
            }
            catch
            {
                MessageBox.Show("Please go to your Settings and enter today's Exchange Rates.\n\t\t :(", "Exchange Rates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            }

            Student_Name_txt.Text = "";
            Surname_txt.Text = "";
            Payment_Method = "";
            Cash_Balance_Before_Payment = 0;
            Activity_Name_txt.Text = "";
            Activity_Fee_txt.Value = 0;
            School_Term_txt.Text = "";
            Activity_Balance_txt.Value = 0;
            Activity_Balance_lbl.Text = "Activity Balance :";
            Student_dateTimePicker.Value = DateTime.Now;
            Cash_radioButton.Checked = false;
            Transfer_radioButton.Checked = false;
            Bank_radioButton.Checked = false;
            Other_radioButton.Checked = false;
            Save_btn.Enabled = false;
            Accept_checkBox.Checked = false;
            Student_Name_txt.Focus();
            timer1.Start();

        }

        private void School_Term_txt_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string ActivityQuery = "Select [Cash_Fees] FROM [Activity_Managment_tbl] WHERE Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
            OleDbDataAdapter ActivityAdapt = new OleDbDataAdapter(ActivityQuery, connection);
            DataTable ActivityTbl = new DataTable();
            ActivityAdapt.Fill(ActivityTbl);


            if (ActivityTbl.Rows.Count > 0)
            {
                string CashQuery = "Select [Amount_Owing] FROM [Activity_Registration_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and Activity_Name = '" + Activity_Name_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter CashAdapt = new OleDbDataAdapter(CashQuery, connection);
                DataTable CashTbl = new DataTable();
                CashAdapt.Fill(CashTbl);

                if (CashTbl.Rows.Count > 0)
                {
                    Activity_Balance_txt.Value = Convert.ToDecimal(CashTbl.Rows[(CashTbl.Rows.Count) - 1][0].ToString());
                    Cash_Balance_Before_Payment = Activity_Balance_txt.Value;
                }
                else
                {
                    Activity_Balance_txt.Value = Convert.ToDecimal(ActivityTbl.Rows[(ActivityTbl.Rows.Count) - 1][0].ToString());
                    Cash_Balance_Before_Payment = Activity_Balance_txt.Value;
                }
            }             
        }

        private void Activity_Name_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            School_Term_txt.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Student_Name_txt.Text == "" || Surname_txt.Text == "" || Activity_Name_txt.Text == "" || School_Term_txt.Text == "")
            {
                Save_btn.Enabled = false;
                REGISTERED_lbl.Visible = false;
            }
            else if (Activity_Balance_txt.Value == 0)
            {
                Save_btn.Enabled = false;
                REGISTERED_lbl.Visible = true;
            }
            else if (Accept_checkBox.Checked == false || Cash_radioButton.Checked == false && Transfer_radioButton.Checked == false && Bank_radioButton.Checked == false && Other_radioButton.Checked == false)
            {
                Save_btn.Enabled = false;
                REGISTERED_lbl.Visible = false;
            }
            else
            {
                Save_btn.Enabled = true;
                REGISTERED_lbl.Visible = false;
            }
        }
    }
}
