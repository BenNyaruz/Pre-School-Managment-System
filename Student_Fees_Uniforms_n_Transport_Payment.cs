using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Student_Fees_Uniforms_n_Transport_Payment : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);
        private decimal Cash_Fees_Balance_Before_Payment;
        private decimal Cash_Transport_Balance_Before_Payment;
        private decimal Cash_Uniform_Balance_Before_Payment;
        private string Fees_Payment_Method;
        private decimal Fees_Price;
        private int Number_Of_Fees_Students_Before_Payment;
        private decimal Cash_Fees_Balance_After_Payment;
        private int Fees_Student_Counter;
        private decimal Total_Cash_Fees_Received_After_Payment;
        private decimal Total_Cash_Fees_Received_Before_Payment;
        private decimal Total_Transfer_Fees_Received_Before_Payment;
        private decimal Total_Bank_Fees_Received_Before_Payment;
        private decimal Total_Other_Fees_Received_Before_Payment;
        private decimal Total_Received_Fees_Before_Payment;
        private decimal Total_Cash_Fees_Paid;
        private int Number_Of_Fees_Students_After_Payment;
        private decimal Total_Fees_Debts_After_Payment;
        private decimal Total_Received_Fees_After_Payment;
        private decimal Total_Transfer_Fees_Paid;
        private decimal Total_Transfer_Fees_Received_After_Payment;
        private decimal Total_Bank_Fees_Paid;
        private decimal Total_Bank_Fees_Received_After_Payment;
        private decimal Total_Other_Fees_Paid;
        private decimal Total_Other_Fees_Received_After_Payment;
        private decimal Uniform_Price;
        private decimal Total_Cash_Uniform_Received_Before_Payment;
        private decimal Total_Transfer_Uniform_Received_Before_Payment;
        private decimal Total_Bank_Uniform_Received_Before_Payment;
        private decimal Total_Other_Uniform_Received_Before_Payment;
        private decimal Total_Received_Uniform_Before_Payment;
        private int Number_Of_Uniform_Students_Before_Payment;
        private string Uniform_Payment_Method;
        private int Uniform_Student_Counter;
        private decimal Cash_Uniform_Balance_After_Payment;
        private decimal Total_Cash_Uniform_Paid;
        private decimal Total_Cash_Uniform_Received_After_Payment;
        private int Number_Of_Uniform_Students_After_Payment;
        private decimal Total_Uniform_Debts_After_Payment;
        private decimal Total_Received_Uniform_After_Payment;
        private decimal Total_Transfer_Uniform_Paid;
        private decimal Total_Transfer_Uniform_Received_After_Payment;
        private decimal Total_Bank_Uniform_Paid;
        private decimal Total_Bank_Uniform_Received_After_Payment;
        private decimal Total_Other_Uniform_Paid;
        private decimal Total_Other_Uniform_Received_After_Payment;
        private decimal Transport_Price;
        private decimal Total_Cash_Transport_Received_Before_Payment;
        private decimal Total_Transfer_Transport_Received_Before_Payment;
        private decimal Total_Bank_Transport_Received_Before_Payment;
        private decimal Total_Other_Transport_Received_Before_Payment;
        private decimal Total_Received_Transport_Before_Payment;
        private int Number_Of_Transport_Students_Before_Payment;
        private string Transport_Payment_Method;
        private int Transport_Student_Counter;
        private decimal Cash_Transport_Balance_After_Payment;
        private decimal Total_Cash_Transport_Paid;
        private decimal Total_Cash_Transport_Received_After_Payment;
        private int Number_Of_Transport_Students_After_Payment;
        private decimal Total_Transfer_Transport_Paid;
        private decimal Total_Transfer_Transport_Received_After_Payment;
        private decimal Total_Received_Transport_After_Payment;
        private decimal Total_Transport_Debts_After_Payment;
        private decimal Total_Bank_Transport_Paid;
        private decimal Total_Bank_Transport_Received_After_Payment;
        private decimal Total_Other_Transport_Paid;
        private decimal Total_Other_Transport_Received_After_Payment;
        private decimal Total_Transport_Debts_Before_Payment;
        private decimal Total_Fees_Debts_Before_Payment;
        private decimal Total_Uniform_Debts_Before_Payment;

        public Student_Fees_Uniforms_n_Transport_Payment()
        {
            InitializeComponent();
            Payment_Date_dateTimePicker.Value = DateTime.Now;
            Save_btn.Enabled = false;
            Student_Name_txt.Focus();
        }

        private void Save_btn_Click(object sender, System.EventArgs e)
        {
            Total_Fees_Debts_Before_Payment = Fees_Balance_txt.Value;
            Total_Transport_Debts_Before_Payment = Transport_Balance_txt.Value;
            Total_Uniform_Debts_Before_Payment = Uniform_Balance_txt.Value;


            if (School_Fees_txt.Value != 0 && Transport_Fees_txt.Value != 0 && Uniforms_Prices_txt.Value != 0)
            {
                try
                {
                    #region Transport
                    string Transport_Query = "Select [Transport_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                    DataTable Transport_Tbl = new DataTable();
                    Transport_Adapt.Fill(Transport_Tbl);

                    Transport_Price = Convert.ToDecimal(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][0].ToString());
                    Total_Cash_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][1].ToString());
                    Total_Transfer_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][2].ToString());
                    Total_Bank_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][3].ToString());
                    Total_Other_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][4].ToString());
                    Total_Received_Transport_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][5].ToString());
                    Number_Of_Transport_Students_Before_Payment = Convert.ToInt32(Transport_Tbl.Rows[Transport_Tbl.Rows.Count - 1][6].ToString());


                    string Total_Transport_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Transport_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Transport_Bad_Debts_Query, connection);
                    DataTable Total_Transport_Bad_Debts_Tbl = new DataTable();
                    Total_Transport_Bad_Debts_Adapt.Fill(Total_Transport_Bad_Debts_Tbl);

                    if (Total_Transport_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Transport_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Transport_Debts_Before_Payment += Convert.ToDecimal(Total_Transport_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }

                    Transport_Payment_Method = "";


                    if (Cash_Transport_Balance_Before_Payment == Transport_Price)
                    {
                        Transport_Student_Counter = 1;
                    }
                    else
                    {
                        Transport_Student_Counter = 0;
                    }


                    if (Cash_Transport_radioButton.Checked == true)
                    {
                        Transport_Payment_Method = Cash_Transport_radioButton.Text.Trim();

                        Cash_Transport_Balance_After_Payment = Convert.ToDecimal(Cash_Transport_Balance_Before_Payment) - Transport_Fees_txt.Value;

                        Total_Cash_Transport_Paid = Transport_Fees_txt.Value;
                        Total_Cash_Transport_Received_After_Payment = Total_Cash_Transport_Received_Before_Payment + Total_Cash_Transport_Paid;
                        Number_Of_Transport_Students_After_Payment = Number_Of_Transport_Students_Before_Payment + Transport_Student_Counter;
                        Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;
                        Total_Received_Transport_After_Payment = Total_Received_Transport_Before_Payment + Total_Cash_Transport_Paid;

                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Cash_Transport_Received_Command = connection.CreateCommand();
                            Total_Cash_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Cash_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Transport_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                            Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Uniform_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                            Total_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transport_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Transport_Transfer_radioButton.Checked == true)
                    {
                        Transport_Payment_Method = Transport_Transfer_radioButton.Text.Trim();

                        Total_Transfer_Transport_Paid = Transport_Fees_txt.Value;
                        Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                        Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                        Total_Transfer_Transport_Received_After_Payment = Total_Transfer_Transport_Received_Before_Payment + Total_Transfer_Transport_Paid;
                        Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                        Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Transfer_Transport_Received_Command = connection.CreateCommand();
                            Total_Transfer_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Transfer_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transfer_Transport_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                            Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                            Total_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transport_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Transport_Bank_radioButton.Checked == true)
                    {
                        Transport_Payment_Method = Transport_Bank_radioButton.Text.Trim();

                        Total_Bank_Transport_Paid = Transport_Fees_txt.Value;
                        Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                        Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                        Total_Bank_Transport_Received_After_Payment = Total_Bank_Transport_Received_Before_Payment + Total_Bank_Transport_Paid;
                        Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                        Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Bank_Transport_Received_Command = connection.CreateCommand();
                            Total_Bank_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Bank_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Bank_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Bank_Transport_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                            Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                            Total_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transport_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Transport_Other_radioButton.Checked == true)
                    {
                        Transport_Payment_Method = Transport_Other_radioButton.Text.Trim();

                        Total_Other_Transport_Paid = Transport_Fees_txt.Value;
                        Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                        Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                        Total_Other_Transport_Received_After_Payment = Total_Other_Transport_Received_Before_Payment + Total_Other_Transport_Paid;
                        Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                        Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Other_Transport_Received_Command = connection.CreateCommand();
                            Total_Other_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Other_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Other_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Other_Transport_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                            Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                            Total_Transport_Received_Command.CommandType = CommandType.Text;
                            Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transport_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Transport_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Transport_Payment_tbl] ([First_Name],[Surname],[School_Term],[Transport_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Transport_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Transport_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Payment_Method", Transport_Payment_Method);
                        Transport_Command.Parameters.AddWithValue("@Amount_Paid", Transport_Fees_txt.Value);
                        Transport_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Transport_Paid);
                        Transport_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Transport_Balance_After_Payment);
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
                    #endregion //**********************************************************************************************************************************************TRANSPORT*********************************************************************************************************************************

                    #region Fees
                    //****************************************************************************************************************FEES*******************************************************************************************************************************
                    string Fees_Query = "Select [Fees_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Fees_Adapt = new OleDbDataAdapter(Fees_Query, connection);
                    DataTable Fees_Tbl = new DataTable();
                    Fees_Adapt.Fill(Fees_Tbl);

                    Fees_Price = Convert.ToDecimal(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][0].ToString());
                    Total_Cash_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][1].ToString());
                    Total_Transfer_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][2].ToString());
                    Total_Bank_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][3].ToString());
                    Total_Other_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][4].ToString());
                    Total_Received_Fees_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][5].ToString());
                    Number_Of_Fees_Students_Before_Payment = Convert.ToInt32(Fees_Tbl.Rows[Fees_Tbl.Rows.Count - 1][6].ToString());


                    string Total_Fees_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Fees_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Fees_Bad_Debts_Query, connection);
                    DataTable Total_Fees_Bad_Debts_Tbl = new DataTable();
                    Total_Fees_Bad_Debts_Adapt.Fill(Total_Fees_Bad_Debts_Tbl);

                    if (Total_Fees_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Fees_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Fees_Debts_Before_Payment += Convert.ToDecimal(Total_Fees_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Fees_Payment_Method = "";


                    if (Cash_Fees_Balance_Before_Payment == Fees_Price)
                    {
                        Fees_Student_Counter = 1;
                    }
                    else
                    {
                        Fees_Student_Counter = 0;
                    }


                    if (Cash_Fees_radioButton.Checked == true)
                    {
                        Fees_Payment_Method = Cash_Fees_radioButton.Text.Trim();

                        this.Cash_Fees_Balance_After_Payment = Convert.ToDecimal(Cash_Fees_Balance_Before_Payment) - School_Fees_txt.Value;

                        Total_Cash_Fees_Paid = School_Fees_txt.Value;
                        Total_Cash_Fees_Received_After_Payment = Total_Cash_Fees_Received_Before_Payment + Total_Cash_Fees_Paid;
                        Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                        Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;
                        Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;

                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Cash_Fees_Received_Command = connection.CreateCommand();
                            Total_Cash_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Cash_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Fees_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                            Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                            Total_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Fees_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Fees_Transfer_radioButton.Checked == true)
                    {
                        Fees_Payment_Method = Fees_Transfer_radioButton.Text.Trim();

                        Total_Transfer_Fees_Paid = School_Fees_txt.Value;
                        Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                        this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                        Total_Transfer_Fees_Received_After_Payment = Total_Transfer_Fees_Received_Before_Payment + Total_Transfer_Fees_Paid;
                        Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                        Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                        Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Transfer_Fees_Received_Command = connection.CreateCommand();
                            Total_Transfer_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Transfer_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transfer_Fees_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                            Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                            Total_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Fees_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Fees_Bank_radioButton.Checked == true)
                    {
                        Fees_Payment_Method = Fees_Bank_radioButton.Text.Trim();

                        Total_Bank_Fees_Paid = School_Fees_txt.Value;
                        Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                        this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                        Total_Bank_Fees_Received_After_Payment = Total_Bank_Fees_Received_Before_Payment + Total_Bank_Fees_Paid;
                        Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                        Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                        Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Bank_Fees_Received_Command = connection.CreateCommand();
                            Total_Bank_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Bank_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Bank_Fees_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                            Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                            Total_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Fees_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Fees_Other_radioButton.Checked == true)
                    {
                        Fees_Payment_Method = Fees_Other_radioButton.Text.Trim();

                        Total_Other_Fees_Paid = School_Fees_txt.Value;
                        Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                        this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                        Total_Other_Fees_Received_After_Payment = Total_Other_Fees_Received_Before_Payment + Total_Other_Fees_Paid;
                        Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                        Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                        Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;

                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Other_Fees_Received_Command = connection.CreateCommand();
                            Total_Other_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Other_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Other_Received = '" + Total_Other_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Other_Fees_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                            Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                            Total_Fees_Received_Command.CommandType = CommandType.Text;
                            Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Fees_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Fees_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Fees_Payment_tbl] ([First_Name],[Surname],[School_Term],[Fees_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Fees_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Fees_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Payment_Method", Fees_Payment_Method);
                        Fees_Command.Parameters.AddWithValue("@Amount_Paid", School_Fees_txt.Value);
                        Fees_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Fees_Paid);
                        Fees_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Fees_Balance_After_Payment);
                        Fees_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Fees_Command.Connection = connection;
                        connection.Open();
                        Fees_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    #endregion

                    #region Uniforms
                    //***********************************************************************************************************************UNIFORMS**************************************************************************************

                    string Uniform_Query = "Select [Uniform_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Uniform_Adapt = new OleDbDataAdapter(Uniform_Query, connection);
                    DataTable Uniform_Tbl = new DataTable();
                    Uniform_Adapt.Fill(Uniform_Tbl);

                    Uniform_Price = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][0].ToString());
                    Total_Cash_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[Uniform_Tbl.Rows.Count - 1][1].ToString());
                    Total_Transfer_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[Uniform_Tbl.Rows.Count - 1][2].ToString());
                    Total_Bank_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[Uniform_Tbl.Rows.Count - 1][3].ToString());
                    Total_Other_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[Uniform_Tbl.Rows.Count - 1][4].ToString());
                    Total_Received_Uniform_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[Uniform_Tbl.Rows.Count - 1][5].ToString());
                    Number_Of_Uniform_Students_Before_Payment = Convert.ToInt32(Uniform_Tbl.Rows[Uniform_Tbl.Rows.Count - 1][6].ToString());


                    string Total_Uniform_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Uniform_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Uniform_Bad_Debts_Query, connection);
                    DataTable Total_Uniform_Bad_Debts_Tbl = new DataTable();
                    Total_Uniform_Bad_Debts_Adapt.Fill(Total_Uniform_Bad_Debts_Tbl);

                    if (Total_Uniform_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Uniform_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Uniform_Debts_Before_Payment += Convert.ToDecimal(Total_Uniform_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Uniform_Payment_Method = "";


                    if (Cash_Uniform_Balance_Before_Payment == Uniform_Price)
                    {
                        Uniform_Student_Counter = 1;
                    }
                    else
                    {
                        Uniform_Student_Counter = 0;
                    }


                    if (Cash_Uniforms_radioButton.Checked == true)
                    {
                        Uniform_Payment_Method = Cash_Uniforms_radioButton.Text.Trim();

                        Cash_Uniform_Balance_After_Payment = Convert.ToDecimal(Cash_Uniform_Balance_Before_Payment) - Uniforms_Prices_txt.Value;

                        Total_Cash_Uniform_Paid = Uniforms_Prices_txt.Value;
                        Total_Cash_Uniform_Received_After_Payment = Total_Cash_Uniform_Received_Before_Payment + Total_Cash_Uniform_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                        Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;
                        Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;

                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Cash_Uniform_Received_Command = connection.CreateCommand();
                            Total_Cash_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Cash_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Uniform_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                            Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                            Total_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Uniform_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Uniforms_Transfer_radioButton.Checked == true)
                    {
                        Uniform_Payment_Method = Uniforms_Transfer_radioButton.Text.Trim();

                        Total_Transfer_Uniform_Paid = Uniforms_Prices_txt.Value;
                        Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                        Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                        Total_Transfer_Uniform_Received_After_Payment = Total_Transfer_Uniform_Received_Before_Payment + Total_Transfer_Uniform_Paid;
                        Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                        Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Transfer_Uniform_Received_Command = connection.CreateCommand();
                            Total_Transfer_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Transfer_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Transfer_Uniform_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                            Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                            Total_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Uniform_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Uniforms_Bank_radioButton.Checked == true)
                    {
                        Uniform_Payment_Method = Uniforms_Bank_radioButton.Text.Trim();

                        Total_Bank_Uniform_Paid = Uniforms_Prices_txt.Value;
                        Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                        Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                        Total_Bank_Uniform_Received_After_Payment = Total_Bank_Uniform_Received_Before_Payment + Total_Bank_Uniform_Paid;
                        Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                        Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Bank_Uniform_Received_Command = connection.CreateCommand();
                            Total_Bank_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Bank_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Bank_Uniform_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                            Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                            Total_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Uniform_Received_Command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (Uniforms_Other_radioButton.Checked == true)
                    {
                        Uniform_Payment_Method = Uniforms_Other_radioButton.Text.Trim();

                        Total_Other_Uniform_Paid = Uniforms_Prices_txt.Value;
                        Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                        Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                        Total_Other_Uniform_Received_After_Payment = Total_Other_Uniform_Received_Before_Payment + Total_Other_Uniform_Paid;
                        Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                        Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                        Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                        try
                        {
                            connection.Open();
                            OleDbCommand Total_Other_Uniform_Received_Command = connection.CreateCommand();
                            Total_Other_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Other_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Other_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Other_Uniform_Received_Command.ExecuteNonQuery();

                            OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                            Number_Of_Students_Command.CommandType = CommandType.Text;
                            Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Number_Of_Students_Command.ExecuteNonQuery();

                            OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                            Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                            Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                            OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                            Total_Uniform_Received_Command.CommandType = CommandType.Text;
                            Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                            Total_Uniform_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Uniform_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Uniform_Payment_tbl] ([First_Name],[Surname],[School_Term],[Uniform_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Uniform_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Uniform_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Payment_Method", Uniform_Payment_Method);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Paid", Uniforms_Prices_txt.Value);
                        Uniform_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Uniform_Paid);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Uniform_Balance_After_Payment);
                        Uniform_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Uniform_Command.Connection = connection;
                        connection.Open();
                        Uniform_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    #endregion

                    MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n Transport, Fees and Uniforms.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #region Clear

                    Student_Name_txt.Text = "";
                    Surname_txt.Text = "";
                    School_Term_txt.Text = "";

                    Fees_Payment_Method = "";

                    Payment_Date_dateTimePicker.Value = DateTime.Now;

                    Fees_Balance_lbl.Text = "Fees Balance :";
                    Transport_Balance_lbl.Text = "Transport Balance :";
                    Uniform_Balance_lbl.Text = "Uniform Balance :";

                    Fees_Balance_txt.Value = 0;
                    Transport_Balance_txt.Value = 0;
                    Uniform_Balance_txt.Value = 0;

                    School_Fees_txt.Value = 0;
                    Transport_Fees_txt.Value = 0;
                    Uniforms_Prices_txt.Value = 0;

                    Cash_Fees_radioButton.Checked = false;
                    Fees_Transfer_radioButton.Checked = false;
                    Fees_Bank_radioButton.Checked = false;
                    Fees_Other_radioButton.Checked = false;

                    Cash_Transport_radioButton.Checked = false;
                    Transport_Transfer_radioButton.Checked = false;
                    Transport_Bank_radioButton.Checked = false;
                    Transport_Other_radioButton.Checked = false;

                    Cash_Uniforms_radioButton.Checked = false;
                    Uniforms_Transfer_radioButton.Checked = false;
                    Uniforms_Bank_radioButton.Checked = false;
                    Uniforms_Other_radioButton.Checked = false;

                    Save_btn.Enabled = false;
                    Student_Name_txt.Focus();

                    #endregion
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (School_Fees_txt.Value != 0 && Transport_Fees_txt.Value != 0)
            {
                try
                { 
                #region Fees              
                //****************************************************************************************************************************************FEES**************************************************************************************************************************
                string Fees_Query = "Select [Fees_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Fees_Adapt = new OleDbDataAdapter(Fees_Query, connection);
                DataTable Fees_Tbl = new DataTable();
                Fees_Adapt.Fill(Fees_Tbl);

                Fees_Price = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Fees_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Fees_Students_Before_Payment = Convert.ToInt32(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][6].ToString());


                    string Total_Fees_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Fees_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Fees_Bad_Debts_Query, connection);
                    DataTable Total_Fees_Bad_Debts_Tbl = new DataTable();
                    Total_Fees_Bad_Debts_Adapt.Fill(Total_Fees_Bad_Debts_Tbl);

                    if (Total_Fees_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Fees_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Fees_Debts_Before_Payment += Convert.ToDecimal(Total_Fees_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }

                        Fees_Payment_Method = "";


                if (Cash_Fees_Balance_Before_Payment == Fees_Price)
                {
                    Fees_Student_Counter = 1;
                }
                else
                {
                    Fees_Student_Counter = 0;
                }


                if (Cash_Fees_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Cash_Fees_radioButton.Text.Trim();

                    this.Cash_Fees_Balance_After_Payment = Convert.ToDecimal(Cash_Fees_Balance_Before_Payment) - School_Fees_txt.Value;

                    Total_Cash_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Received_After_Payment = Total_Cash_Fees_Received_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Fees_Received_Command = connection.CreateCommand();
                        Total_Cash_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Transfer_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Transfer_Fees_Received_After_Payment = Total_Transfer_Fees_Received_Before_Payment + Total_Transfer_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Fees_Received_Command = connection.CreateCommand();
                        Total_Transfer_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Bank_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Bank_radioButton.Text.Trim();

                    Total_Bank_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Bank_Fees_Received_After_Payment = Total_Bank_Fees_Received_Before_Payment + Total_Bank_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Fees_Received_Command = connection.CreateCommand();
                        Total_Bank_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Other_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Other_radioButton.Text.Trim();

                    Total_Other_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Other_Fees_Received_After_Payment = Total_Other_Fees_Received_Before_Payment + Total_Other_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Fees_Received_Command = connection.CreateCommand();
                        Total_Other_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Other_Received = '" + Total_Other_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Fees_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Fees_Payment_tbl] ([First_Name],[Surname],[School_Term],[Fees_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Fees_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Fees_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Payment_Method", Fees_Payment_Method);
                        Fees_Command.Parameters.AddWithValue("@Amount_Paid", School_Fees_txt.Value);
                        Fees_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Fees_Paid);
                        Fees_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Fees_Balance_After_Payment);
                        Fees_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Fees_Command.Connection = connection;
                        connection.Open();
                        Fees_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion

                #region Transport
                //**********************************************************************************************************************************************TRANSPORT*********************************************************************************************************************************
                string Transport_Query = "Select [Transport_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                DataTable Transport_Tbl = new DataTable();
                Transport_Adapt.Fill(Transport_Tbl);

                Transport_Price = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Transport_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Transport_Students_Before_Payment = Convert.ToInt32(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][6].ToString());



                    string Total_Transport_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Transport_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Transport_Bad_Debts_Query, connection);
                    DataTable Total_Transport_Bad_Debts_Tbl = new DataTable();
                    Total_Transport_Bad_Debts_Adapt.Fill(Total_Transport_Bad_Debts_Tbl);

                    if (Total_Transport_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Transport_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Transport_Debts_Before_Payment += Convert.ToDecimal(Total_Transport_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }



                    Transport_Payment_Method = "";


                if (Cash_Transport_Balance_Before_Payment == Transport_Price)
                {
                    Transport_Student_Counter = 1;
                }
                else
                {
                    Transport_Student_Counter = 0;
                }


                if (Cash_Transport_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Cash_Transport_radioButton.Text.Trim();

                    Cash_Transport_Balance_After_Payment = Convert.ToDecimal(Cash_Transport_Balance_Before_Payment) - Transport_Fees_txt.Value;

                    Total_Cash_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Received_After_Payment = Total_Cash_Transport_Received_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Transport_Students_After_Payment = Number_Of_Transport_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;
                    Total_Received_Transport_After_Payment = Total_Received_Transport_Before_Payment + Total_Cash_Transport_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Transport_Received_Command = connection.CreateCommand();
                        Total_Cash_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Transfer_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Transfer_Transport_Received_After_Payment = Total_Transfer_Transport_Received_Before_Payment + Total_Transfer_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Transport_Received_Command = connection.CreateCommand();
                        Total_Transfer_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Bank_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Bank_radioButton.Text.Trim();

                    Total_Bank_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Bank_Transport_Received_After_Payment = Total_Bank_Transport_Received_Before_Payment + Total_Bank_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Transport_Received_Command = connection.CreateCommand();
                        Total_Bank_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Bank_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Other_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Other_radioButton.Text.Trim();

                    Total_Other_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Other_Transport_Received_After_Payment = Total_Other_Transport_Received_Before_Payment + Total_Other_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Transport_Received_Command = connection.CreateCommand();
                        Total_Other_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Other_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Transport_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Transport_Payment_tbl] ([First_Name],[Surname],[School_Term],[Transport_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Transport_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Transport_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Payment_Method", Transport_Payment_Method);
                        Transport_Command.Parameters.AddWithValue("@Amount_Paid", Transport_Fees_txt.Value);
                        Transport_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Transport_Paid);
                        Transport_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Transport_Balance_After_Payment);
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

                MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n Transport and Fees.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #region Clear
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                School_Term_txt.Text = "";

                Fees_Payment_Method = "";

                Payment_Date_dateTimePicker.Value = DateTime.Now;

                Fees_Balance_lbl.Text = "Fees Balance :";
                Transport_Balance_lbl.Text = "Transport Balance :";
                Uniform_Balance_lbl.Text = "Uniform Balance :";

                Fees_Balance_txt.Value = 0;
                Transport_Balance_txt.Value = 0;
                Uniform_Balance_txt.Value = 0;

                School_Fees_txt.Value = 0;
                Transport_Fees_txt.Value = 0;
                Uniforms_Prices_txt.Value = 0;

                Cash_Fees_radioButton.Checked = false;
                Fees_Transfer_radioButton.Checked = false;
                Fees_Bank_radioButton.Checked = false;
                Fees_Other_radioButton.Checked = false;

                Cash_Transport_radioButton.Checked = false;
                Transport_Transfer_radioButton.Checked = false;
                Transport_Bank_radioButton.Checked = false;
                Transport_Other_radioButton.Checked = false;

                Cash_Uniforms_radioButton.Checked = false;
                Uniforms_Transfer_radioButton.Checked = false;
                Uniforms_Bank_radioButton.Checked = false;
                Uniforms_Other_radioButton.Checked = false;

                Save_btn.Enabled = false;
                Student_Name_txt.Focus();

                #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }
            else if (School_Fees_txt.Value != 0 && Uniforms_Prices_txt.Value != 0)
            {
                try
                { 
                #region Fees
                //********************************************************************FEES**************************************************************************************
                string Fees_Query = "Select [Fees_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Fees_Adapt = new OleDbDataAdapter(Fees_Query, connection);
                DataTable Fees_Tbl = new DataTable();
                Fees_Adapt.Fill(Fees_Tbl);

                Fees_Price = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Fees_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Fees_Students_Before_Payment = Convert.ToInt32(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][6].ToString());



                    string Total_Fees_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Fees_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Fees_Bad_Debts_Query, connection);
                    DataTable Total_Fees_Bad_Debts_Tbl = new DataTable();
                    Total_Fees_Bad_Debts_Adapt.Fill(Total_Fees_Bad_Debts_Tbl);

                    if (Total_Fees_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Fees_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Fees_Debts_Before_Payment += Convert.ToDecimal(Total_Fees_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Fees_Payment_Method = "";


                if (Cash_Fees_Balance_Before_Payment == Fees_Price)
                {
                    Fees_Student_Counter = 1;
                }
                else
                {
                    Fees_Student_Counter = 0;
                }


                if (Cash_Fees_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Cash_Fees_radioButton.Text.Trim();

                    this.Cash_Fees_Balance_After_Payment = Convert.ToDecimal(Cash_Fees_Balance_Before_Payment) - School_Fees_txt.Value;

                    Total_Cash_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Received_After_Payment = Total_Cash_Fees_Received_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Fees_Received_Command = connection.CreateCommand();
                        Total_Cash_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Transfer_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Transfer_Fees_Received_After_Payment = Total_Transfer_Fees_Received_Before_Payment + Total_Transfer_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Fees_Received_Command = connection.CreateCommand();
                        Total_Transfer_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Bank_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Bank_radioButton.Text.Trim();

                    Total_Bank_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Bank_Fees_Received_After_Payment = Total_Bank_Fees_Received_Before_Payment + Total_Bank_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Fees_Received_Command = connection.CreateCommand();
                        Total_Bank_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Other_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Other_radioButton.Text.Trim();

                    Total_Other_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Other_Fees_Received_After_Payment = Total_Other_Fees_Received_Before_Payment + Total_Other_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Fees_Received_Command = connection.CreateCommand();
                        Total_Other_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Other_Received = '" + Total_Other_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Fees_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Fees_Payment_tbl] ([First_Name],[Surname],[School_Term],[Fees_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Fees_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Fees_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Payment_Method", Fees_Payment_Method);
                        Fees_Command.Parameters.AddWithValue("@Amount_Paid", School_Fees_txt.Value);
                        Fees_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Fees_Paid);
                        Fees_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Fees_Balance_After_Payment);
                        Fees_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Fees_Command.Connection = connection;
                        connection.Open();
                        Fees_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion
                
                #region Uniforms
                //*********************************************************************UNIFORMS******************************************************************************                        
                string Uniform_Query = "Select [Uniform_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Uniform_Adapt = new OleDbDataAdapter(Uniform_Query, connection);
                DataTable Uniform_Tbl = new DataTable();
                Uniform_Adapt.Fill(Uniform_Tbl);

                Uniform_Price = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Uniform_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Uniform_Students_Before_Payment = Convert.ToInt32(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][6].ToString());


                    string Total_Uniform_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Uniform_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Uniform_Bad_Debts_Query, connection);
                    DataTable Total_Uniform_Bad_Debts_Tbl = new DataTable();
                    Total_Uniform_Bad_Debts_Adapt.Fill(Total_Uniform_Bad_Debts_Tbl);

                    if (Total_Uniform_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Uniform_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Uniform_Debts_Before_Payment += Convert.ToDecimal(Total_Uniform_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Uniform_Payment_Method = "";


                if (Cash_Uniform_Balance_Before_Payment == Uniform_Price)
                {
                    Uniform_Student_Counter = 1;
                }
                else
                {
                    Uniform_Student_Counter = 0;
                }


                if (Cash_Uniforms_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Cash_Uniforms_radioButton.Text.Trim();

                    Cash_Uniform_Balance_After_Payment = Convert.ToDecimal(Cash_Uniform_Balance_Before_Payment) - Uniforms_Prices_txt.Value;

                    Total_Cash_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Received_After_Payment = Total_Cash_Uniform_Received_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Uniform_Received_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Transfer_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Transfer_Uniform_Received_After_Payment = Total_Transfer_Uniform_Received_Before_Payment + Total_Transfer_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Uniform_Received_Command = connection.CreateCommand();
                        Total_Transfer_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Bank_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Bank_radioButton.Text.Trim();

                    Total_Bank_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Bank_Uniform_Received_After_Payment = Total_Bank_Uniform_Received_Before_Payment + Total_Bank_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Uniform_Received_Command = connection.CreateCommand();
                        Total_Bank_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Other_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Other_radioButton.Text.Trim();

                    Total_Other_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Other_Uniform_Received_After_Payment = Total_Other_Uniform_Received_Before_Payment + Total_Other_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Uniform_Received_Command = connection.CreateCommand();
                        Total_Other_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Other_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Uniform_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Uniform_Payment_tbl] ([First_Name],[Surname],[School_Term],[Uniform_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Uniform_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Uniform_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Payment_Method", Uniform_Payment_Method);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Paid", Uniforms_Prices_txt.Value);
                        Uniform_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Uniform_Paid);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Uniform_Balance_After_Payment);
                        Uniform_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Uniform_Command.Connection = connection;
                        connection.Open();
                        Uniform_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion

                MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n Fees and Uniforms.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #region Clear
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                School_Term_txt.Text = "";

                Fees_Payment_Method = "";

                Payment_Date_dateTimePicker.Value = DateTime.Now;

                Fees_Balance_lbl.Text = "Fees Balance :";
                Transport_Balance_lbl.Text = "Transport Balance :";
                Uniform_Balance_lbl.Text = "Uniform Balance :";

                Fees_Balance_txt.Value = 0;
                Transport_Balance_txt.Value = 0;
                Uniform_Balance_txt.Value = 0;

                School_Fees_txt.Value = 0;
                Transport_Fees_txt.Value = 0;
                Uniforms_Prices_txt.Value = 0;

                Cash_Fees_radioButton.Checked = false;
                Fees_Transfer_radioButton.Checked = false;
                Fees_Bank_radioButton.Checked = false;
                Fees_Other_radioButton.Checked = false;

                Cash_Transport_radioButton.Checked = false;
                Transport_Transfer_radioButton.Checked = false;
                Transport_Bank_radioButton.Checked = false;
                Transport_Other_radioButton.Checked = false;

                Cash_Uniforms_radioButton.Checked = false;
                Uniforms_Transfer_radioButton.Checked = false;
                Uniforms_Bank_radioButton.Checked = false;
                Uniforms_Other_radioButton.Checked = false;

                Save_btn.Enabled = false;
                Student_Name_txt.Focus();

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Transport_Fees_txt.Value != 0 && Uniforms_Prices_txt.Value != 0)
            {
                try
                { 
                #region Uniforms
                //*********************************************************************UNIFORMS******************************************************************************                        
                string Uniform_Query = "Select [Uniform_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Uniform_Adapt = new OleDbDataAdapter(Uniform_Query, connection);
                DataTable Uniform_Tbl = new DataTable();
                Uniform_Adapt.Fill(Uniform_Tbl);

                Uniform_Price = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Uniform_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Uniform_Students_Before_Payment = Convert.ToInt32(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][6].ToString());


                    string Total_Uniform_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Uniform_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Uniform_Bad_Debts_Query, connection);
                    DataTable Total_Uniform_Bad_Debts_Tbl = new DataTable();
                    Total_Uniform_Bad_Debts_Adapt.Fill(Total_Uniform_Bad_Debts_Tbl);

                    if (Total_Uniform_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Uniform_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Uniform_Debts_Before_Payment += Convert.ToDecimal(Total_Uniform_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Uniform_Payment_Method = "";


                if (Cash_Uniform_Balance_Before_Payment == Uniform_Price)
                {
                    Uniform_Student_Counter = 1;
                }
                else
                {
                    Uniform_Student_Counter = 0;
                }


                if (Cash_Uniforms_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Cash_Uniforms_radioButton.Text.Trim();

                    Cash_Uniform_Balance_After_Payment = Convert.ToDecimal(Cash_Uniform_Balance_Before_Payment) - Uniforms_Prices_txt.Value;

                    Total_Cash_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Received_After_Payment = Total_Cash_Uniform_Received_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Uniform_Received_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Transfer_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Transfer_Uniform_Received_After_Payment = Total_Transfer_Uniform_Received_Before_Payment + Total_Transfer_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Uniform_Received_Command = connection.CreateCommand();
                        Total_Transfer_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Bank_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Bank_radioButton.Text.Trim();

                    Total_Bank_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Bank_Uniform_Received_After_Payment = Total_Bank_Uniform_Received_Before_Payment + Total_Bank_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Uniform_Received_Command = connection.CreateCommand();
                        Total_Bank_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Other_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Other_radioButton.Text.Trim();

                    Total_Other_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Other_Uniform_Received_After_Payment = Total_Other_Uniform_Received_Before_Payment + Total_Other_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Uniform_Received_Command = connection.CreateCommand();
                        Total_Other_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Other_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Uniform_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Uniform_Payment_tbl] ([First_Name],[Surname],[School_Term],[Uniform_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Uniform_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Uniform_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Payment_Method", Uniform_Payment_Method);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Paid", Uniforms_Prices_txt.Value);
                        Uniform_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Uniform_Paid);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Uniform_Balance_After_Payment);
                        Uniform_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Uniform_Command.Connection = connection;
                        connection.Open();
                        Uniform_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion
                
                #region Transport
                //***********************************************************************TRANSPORT*************************************************************************************
                string Transport_Query = "Select [Transport_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                DataTable Transport_Tbl = new DataTable();
                Transport_Adapt.Fill(Transport_Tbl);

                Transport_Price = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Transport_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Transport_Students_Before_Payment = Convert.ToInt32(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][6].ToString());



                    string Total_Transport_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Transport_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Transport_Bad_Debts_Query, connection);
                    DataTable Total_Transport_Bad_Debts_Tbl = new DataTable();
                    Total_Transport_Bad_Debts_Adapt.Fill(Total_Transport_Bad_Debts_Tbl);

                    if (Total_Transport_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Transport_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Transport_Debts_Before_Payment += Convert.ToDecimal(Total_Transport_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }



                    Transport_Payment_Method = "";


                if (Cash_Transport_Balance_Before_Payment == Transport_Price)
                {
                    Transport_Student_Counter = 1;
                }
                else
                {
                    Transport_Student_Counter = 0;
                }


                if (Cash_Transport_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Cash_Transport_radioButton.Text.Trim();

                    Cash_Transport_Balance_After_Payment = Convert.ToDecimal(Cash_Transport_Balance_Before_Payment) - Transport_Fees_txt.Value;

                    Total_Cash_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Received_After_Payment = Total_Cash_Transport_Received_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Transport_Students_After_Payment = Number_Of_Transport_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;
                    Total_Received_Transport_After_Payment = Total_Received_Transport_Before_Payment + Total_Cash_Transport_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Transport_Received_Command = connection.CreateCommand();
                        Total_Cash_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Transfer_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Transfer_Transport_Received_After_Payment = Total_Transfer_Transport_Received_Before_Payment + Total_Transfer_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Transport_Received_Command = connection.CreateCommand();
                        Total_Transfer_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Bank_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Bank_radioButton.Text.Trim();

                    Total_Bank_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Bank_Transport_Received_After_Payment = Total_Bank_Transport_Received_Before_Payment + Total_Bank_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Transport_Received_Command = connection.CreateCommand();
                        Total_Bank_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Bank_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Other_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Other_radioButton.Text.Trim();

                    Total_Other_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Other_Transport_Received_After_Payment = Total_Other_Transport_Received_Before_Payment + Total_Other_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Transport_Received_Command = connection.CreateCommand();
                        Total_Other_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Other_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Transport_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Transport_Payment_tbl] ([First_Name],[Surname],[School_Term],[Transport_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Transport_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Transport_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Payment_Method", Transport_Payment_Method);
                        Transport_Command.Parameters.AddWithValue("@Amount_Paid", Transport_Fees_txt.Value);
                        Transport_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Transport_Paid);
                        Transport_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Transport_Balance_After_Payment);
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

                MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n Transport and Uniforms.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #region Clear
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                School_Term_txt.Text = "";

                Fees_Payment_Method = "";

                Payment_Date_dateTimePicker.Value = DateTime.Now;

                Fees_Balance_lbl.Text = "Fees Balance :";
                Transport_Balance_lbl.Text = "Transport Balance :";
                Uniform_Balance_lbl.Text = "Uniform Balance :";

                Fees_Balance_txt.Value = 0;
                Transport_Balance_txt.Value = 0;
                Uniform_Balance_txt.Value = 0;

                School_Fees_txt.Value = 0;
                Transport_Fees_txt.Value = 0;
                Uniforms_Prices_txt.Value = 0;

                Cash_Fees_radioButton.Checked = false;
                Fees_Transfer_radioButton.Checked = false;
                Fees_Bank_radioButton.Checked = false;
                Fees_Other_radioButton.Checked = false;

                Cash_Transport_radioButton.Checked = false;
                Transport_Transfer_radioButton.Checked = false;
                Transport_Bank_radioButton.Checked = false;
                Transport_Other_radioButton.Checked = false;

                Cash_Uniforms_radioButton.Checked = false;
                Uniforms_Transfer_radioButton.Checked = false;
                Uniforms_Bank_radioButton.Checked = false;
                Uniforms_Other_radioButton.Checked = false;

                Save_btn.Enabled = false;
                Student_Name_txt.Focus();

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (School_Fees_txt.Value != 0)
            {
                try
                { 
                #region Fees
                string Fees_Query = "Select [Fees_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Fees_Adapt = new OleDbDataAdapter(Fees_Query, connection);
                DataTable Fees_Tbl = new DataTable();
                Fees_Adapt.Fill(Fees_Tbl);

                Fees_Price = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Fees_Received_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Fees_Before_Payment = Convert.ToDecimal(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Fees_Students_Before_Payment = Convert.ToInt32(Fees_Tbl.Rows[(Fees_Tbl.Rows.Count) - 1][6].ToString());


                    string Total_Fees_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Fees_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Fees_Bad_Debts_Query, connection);
                    DataTable Total_Fees_Bad_Debts_Tbl = new DataTable();
                    Total_Fees_Bad_Debts_Adapt.Fill(Total_Fees_Bad_Debts_Tbl);

                    if (Total_Fees_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Fees_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Fees_Debts_Before_Payment += Convert.ToDecimal(Total_Fees_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Fees_Payment_Method = "";


                if (Cash_Fees_Balance_Before_Payment == Fees_Price)
                {
                    Fees_Student_Counter = 1;
                }
                else
                {
                    Fees_Student_Counter = 0;
                }


                if (Cash_Fees_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Cash_Fees_radioButton.Text.Trim();

                    this.Cash_Fees_Balance_After_Payment = Convert.ToDecimal(Cash_Fees_Balance_Before_Payment) - School_Fees_txt.Value;

                    Total_Cash_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Received_After_Payment = Total_Cash_Fees_Received_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Fees_Received_Command = connection.CreateCommand();
                        Total_Cash_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Transfer_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Transfer_Fees_Received_After_Payment = Total_Transfer_Fees_Received_Before_Payment + Total_Transfer_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Fees_Received_Command = connection.CreateCommand();
                        Total_Transfer_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Bank_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Bank_radioButton.Text.Trim();

                    Total_Bank_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Bank_Fees_Received_After_Payment = Total_Bank_Fees_Received_Before_Payment + Total_Bank_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Fees_Received_Command = connection.CreateCommand();
                        Total_Bank_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Fees_Other_radioButton.Checked == true)
                {
                    Fees_Payment_Method = Fees_Other_radioButton.Text.Trim();

                    Total_Other_Fees_Paid = School_Fees_txt.Value;
                    Total_Cash_Fees_Paid = Convert.ToDecimal(Convert.ToDouble(School_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    this.Cash_Fees_Balance_After_Payment = Cash_Fees_Balance_Before_Payment - Total_Cash_Fees_Paid;
                    Total_Other_Fees_Received_After_Payment = Total_Other_Fees_Received_Before_Payment + Total_Other_Fees_Paid;
                    Total_Received_Fees_After_Payment = Total_Received_Fees_Before_Payment + Total_Cash_Fees_Paid;
                    Number_Of_Fees_Students_After_Payment = Number_Of_Fees_Students_Before_Payment + Fees_Student_Counter;
                    Total_Fees_Debts_After_Payment = Total_Fees_Debts_Before_Payment - Total_Cash_Fees_Received_After_Payment;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Fees_Received_Command = connection.CreateCommand();
                        Total_Other_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Other_Received = '" + Total_Other_Fees_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Fees_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Fees_Managment_tbl]  set Total_Students = '" + Number_Of_Fees_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Fees_Debts_Command = connection.CreateCommand();
                        Total_Cash_Fees_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Fees_Debts_Command.CommandText = "update [Fees_Managment_tbl] set Total_Debts = '" + Total_Fees_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Fees_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Fees_Received_Command = connection.CreateCommand();
                        Total_Fees_Received_Command.CommandType = CommandType.Text;
                        Total_Fees_Received_Command.CommandText = "update [Fees_Managment_tbl] set Total_Received = '" + Total_Received_Fees_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Fees_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Fees_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Fees_Payment_tbl] ([First_Name],[Surname],[School_Term],[Fees_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Fees_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Fees_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Fees_Command.Parameters.AddWithValue("@Payment_Method", Fees_Payment_Method);
                        Fees_Command.Parameters.AddWithValue("@Amount_Paid", School_Fees_txt.Value);
                        Fees_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Fees_Paid);
                        Fees_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Fees_Balance_After_Payment);
                        Fees_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Fees_Command.Connection = connection;
                        connection.Open();
                        Fees_Command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n " + "\t\t$" + Total_Cash_Fees_Paid + " in " + Fees_Payment_Method, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion

                #region Clear
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                School_Term_txt.Text = "";

                Fees_Payment_Method = "";

                Payment_Date_dateTimePicker.Value = DateTime.Now;

                Fees_Balance_lbl.Text = "Fees Balance :";
                Transport_Balance_lbl.Text = "Transport Balance :";
                Uniform_Balance_lbl.Text = "Uniform Balance :";

                Fees_Balance_txt.Value = 0;
                Transport_Balance_txt.Value = 0;
                Uniform_Balance_txt.Value = 0;

                School_Fees_txt.Value = 0;
                Transport_Fees_txt.Value = 0;
                Uniforms_Prices_txt.Value = 0;

                Cash_Fees_radioButton.Checked = false;
                Fees_Transfer_radioButton.Checked = false;
                Fees_Bank_radioButton.Checked = false;
                Fees_Other_radioButton.Checked = false;

                Cash_Transport_radioButton.Checked = false;
                Transport_Transfer_radioButton.Checked = false;
                Transport_Bank_radioButton.Checked = false;
                Transport_Other_radioButton.Checked = false;

                Cash_Uniforms_radioButton.Checked = false;
                Uniforms_Transfer_radioButton.Checked = false;
                Uniforms_Bank_radioButton.Checked = false;
                Uniforms_Other_radioButton.Checked = false;

                Save_btn.Enabled = false;
                Student_Name_txt.Focus();

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Uniforms_Prices_txt.Value != 0)
            {
                try
                { 
                #region Uniforms
                //********************************************************************UNIFORMS**************************************************************************************
                string Uniform_Query = "Select [Uniform_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Uniform_Adapt = new OleDbDataAdapter(Uniform_Query, connection);
                DataTable Uniform_Tbl = new DataTable();
                Uniform_Adapt.Fill(Uniform_Tbl);

                Uniform_Price = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Uniform_Received_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Uniform_Before_Payment = Convert.ToDecimal(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Uniform_Students_Before_Payment = Convert.ToInt32(Uniform_Tbl.Rows[(Uniform_Tbl.Rows.Count) - 1][6].ToString());


                    string Total_Uniform_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Uniform_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Uniform_Bad_Debts_Query, connection);
                    DataTable Total_Uniform_Bad_Debts_Tbl = new DataTable();
                    Total_Uniform_Bad_Debts_Adapt.Fill(Total_Uniform_Bad_Debts_Tbl);

                    if (Total_Uniform_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Uniform_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Uniform_Debts_Before_Payment += Convert.ToDecimal(Total_Uniform_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }


                    Uniform_Payment_Method = "";


                if (Cash_Uniform_Balance_Before_Payment == Uniform_Price)
                {
                    Uniform_Student_Counter = 1;
                }
                else
                {
                    Uniform_Student_Counter = 0;
                }


                if (Cash_Uniforms_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Cash_Uniforms_radioButton.Text.Trim();

                    Cash_Uniform_Balance_After_Payment = Convert.ToDecimal(Cash_Uniform_Balance_Before_Payment) - Uniforms_Prices_txt.Value;

                    Total_Cash_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Received_After_Payment = Total_Cash_Uniform_Received_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Uniform_Received_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Transfer_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Transfer_Uniform_Received_After_Payment = Total_Transfer_Uniform_Received_Before_Payment + Total_Transfer_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Uniform_Received_Command = connection.CreateCommand();
                        Total_Transfer_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Bank_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Bank_radioButton.Text.Trim();

                    Total_Bank_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Bank_Uniform_Received_After_Payment = Total_Bank_Uniform_Received_Before_Payment + Total_Bank_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Uniform_Received_Command = connection.CreateCommand();
                        Total_Bank_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Bank_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Uniforms_Other_radioButton.Checked == true)
                {
                    Uniform_Payment_Method = Uniforms_Other_radioButton.Text.Trim();

                    Total_Other_Uniform_Paid = Uniforms_Prices_txt.Value;
                    Total_Cash_Uniform_Paid = Convert.ToDecimal(Convert.ToDouble(Uniforms_Prices_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    Cash_Uniform_Balance_After_Payment = Cash_Uniform_Balance_Before_Payment - Total_Cash_Uniform_Paid;
                    Total_Other_Uniform_Received_After_Payment = Total_Other_Uniform_Received_Before_Payment + Total_Other_Uniform_Paid;
                    Total_Received_Uniform_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Uniform_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Uniform_Student_Counter;
                    Total_Uniform_Debts_After_Payment = Total_Uniform_Debts_Before_Payment - Total_Cash_Uniform_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Uniform_Received_Command = connection.CreateCommand();
                        Total_Other_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Bank_Received = '" + Total_Other_Uniform_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Uniform_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Uniform_Managment_tbl]  set Total_Students = '" + Number_Of_Uniform_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Debts = '" + Total_Uniform_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Uniform_Received_Command = connection.CreateCommand();
                        Total_Uniform_Received_Command.CommandType = CommandType.Text;
                        Total_Uniform_Received_Command.CommandText = "update [Uniform_Managment_tbl] set Total_Received = '" + Total_Received_Uniform_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Uniform_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Uniform_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Uniform_Payment_tbl] ([First_Name],[Surname],[School_Term],[Uniform_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Uniform_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Uniform_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Uniform_Command.Parameters.AddWithValue("@Payment_Method", Uniform_Payment_Method);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Paid", Uniforms_Prices_txt.Value);
                        Uniform_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Uniform_Paid);
                        Uniform_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Uniform_Balance_After_Payment);
                        Uniform_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Uniform_Command.Connection = connection;
                        connection.Open();
                        Uniform_Command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n " + "\t\t$" + Total_Cash_Uniform_Paid + " in " + Uniform_Payment_Method, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Student_Name_txt.Text = "";
                        Surname_txt.Text = "";
                        School_Term_txt.Text = "";

                        Fees_Payment_Method = "";

                        Payment_Date_dateTimePicker.Value = DateTime.Now;

                        Fees_Balance_lbl.Text = "Fees Balance :";
                        Transport_Balance_lbl.Text = "Transport Balance :";
                        Uniform_Balance_lbl.Text = "Uniform Balance :";

                        Fees_Balance_txt.Value = 0;
                        Transport_Balance_txt.Value = 0;
                        Uniform_Balance_txt.Value = 0;

                        School_Fees_txt.Value = 0;
                        Transport_Fees_txt.Value = 0;
                        Uniforms_Prices_txt.Value = 0;

                        Cash_Fees_radioButton.Checked = false;
                        Fees_Transfer_radioButton.Checked = false;
                        Fees_Bank_radioButton.Checked = false;
                        Fees_Other_radioButton.Checked = false;

                        Cash_Transport_radioButton.Checked = false;
                        Transport_Transfer_radioButton.Checked = false;
                        Transport_Bank_radioButton.Checked = false;
                        Transport_Other_radioButton.Checked = false;

                        Cash_Uniforms_radioButton.Checked = false;
                        Uniforms_Transfer_radioButton.Checked = false;
                        Uniforms_Bank_radioButton.Checked = false;
                        Uniforms_Other_radioButton.Checked = false;

                        Save_btn.Enabled = false;
                        Student_Name_txt.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                #endregion

                #region Clear
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                School_Term_txt.Text = "";

                Fees_Payment_Method = "";

                Payment_Date_dateTimePicker.Value = DateTime.Now;

                Fees_Balance_lbl.Text = "Fees Balance :";
                Transport_Balance_lbl.Text = "Transport Balance :";
                Uniform_Balance_lbl.Text = "Uniform Balance :";

                Fees_Balance_txt.Value = 0;
                Transport_Balance_txt.Value = 0;
                Uniform_Balance_txt.Value = 0;

                School_Fees_txt.Value = 0;
                Transport_Fees_txt.Value = 0;
                Uniforms_Prices_txt.Value = 0;

                Cash_Fees_radioButton.Checked = false;
                Fees_Transfer_radioButton.Checked = false;
                Fees_Bank_radioButton.Checked = false;
                Fees_Other_radioButton.Checked = false;

                Cash_Transport_radioButton.Checked = false;
                Transport_Transfer_radioButton.Checked = false;
                Transport_Bank_radioButton.Checked = false;
                Transport_Other_radioButton.Checked = false;

                Cash_Uniforms_radioButton.Checked = false;
                Uniforms_Transfer_radioButton.Checked = false;
                Uniforms_Bank_radioButton.Checked = false;
                Uniforms_Other_radioButton.Checked = false;

                Save_btn.Enabled = false;
                Student_Name_txt.Focus();

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Transport_Fees_txt.Value != 0)
            {
                try
                { 
                #region Transport
                //********************************************************************TRANSPORT**************************************************************************************
                string Transport_Query = "Select [Transport_Cash],[Total_Cash_Received],[Total_Transfer_Received],[Total_Bank_Received],[Total_Other_Received],[Total_Received],[Total_Students] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                DataTable Transport_Tbl = new DataTable();
                Transport_Adapt.Fill(Transport_Tbl);

                Transport_Price = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][0].ToString());
                Total_Cash_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][1].ToString());
                Total_Transfer_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][2].ToString());
                Total_Bank_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][3].ToString());
                Total_Other_Transport_Received_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][4].ToString());
                Total_Received_Transport_Before_Payment = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][5].ToString());
                Number_Of_Transport_Students_Before_Payment = Convert.ToInt32(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][6].ToString());


                    string Total_Transport_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Total_Transport_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Transport_Bad_Debts_Query, connection);
                    DataTable Total_Transport_Bad_Debts_Tbl = new DataTable();
                    Total_Transport_Bad_Debts_Adapt.Fill(Total_Transport_Bad_Debts_Tbl);

                    if (Total_Transport_Bad_Debts_Tbl.Rows.Count > 0)
                    {
                        for (int x = 1; x <= Total_Transport_Bad_Debts_Tbl.Rows.Count; x += 1)
                        {
                            Total_Transport_Debts_Before_Payment += Convert.ToDecimal(Total_Transport_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                        }
                    }



                    Transport_Payment_Method = "";


                if (Cash_Transport_Balance_Before_Payment == Transport_Price)
                {
                    Transport_Student_Counter = 1;
                }
                else
                {
                    Transport_Student_Counter = 0;
                }


                if (Cash_Transport_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Cash_Transport_radioButton.Text.Trim();

                    Cash_Transport_Balance_After_Payment = Convert.ToDecimal(Cash_Transport_Balance_Before_Payment) - Transport_Fees_txt.Value;

                    Total_Cash_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Received_After_Payment = Total_Cash_Transport_Received_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Transport_Students_After_Payment = Number_Of_Transport_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;
                    Total_Received_Transport_After_Payment = Total_Received_Transport_Before_Payment + Total_Cash_Transport_Paid;

                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Cash_Transport_Received_Command = connection.CreateCommand();
                        Total_Cash_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Cash_Received = '" + Total_Cash_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Uniform_Debts_Command = connection.CreateCommand();
                        Total_Cash_Uniform_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Uniform_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Uniform_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Transfer_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Transfer_radioButton.Text.Trim();

                    Total_Transfer_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Transfer_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Transfer_Transport_Received_After_Payment = Total_Transfer_Transport_Received_Before_Payment + Total_Transfer_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Transfer_Transport_Received_Command = connection.CreateCommand();
                        Total_Transfer_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transfer_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Transfer_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transfer_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Bank_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Bank_radioButton.Text.Trim();

                    Total_Bank_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Bank_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Bank_Transport_Received_After_Payment = Total_Bank_Transport_Received_Before_Payment + Total_Bank_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Bank_Transport_Received_Command = connection.CreateCommand();
                        Total_Bank_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Bank_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Bank_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Bank_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (Transport_Other_radioButton.Checked == true)
                {
                    Transport_Payment_Method = Transport_Other_radioButton.Text.Trim();

                    Total_Other_Transport_Paid = Transport_Fees_txt.Value;
                    Total_Cash_Transport_Paid = Convert.ToDecimal(Convert.ToDouble(Transport_Fees_txt.Value) * Convert.ToDouble(Other_Rate_lbl.Text));
                    Cash_Transport_Balance_After_Payment = Cash_Transport_Balance_Before_Payment - Total_Cash_Transport_Paid;
                    Total_Other_Transport_Received_After_Payment = Total_Other_Transport_Received_Before_Payment + Total_Other_Transport_Paid;
                    Total_Received_Transport_After_Payment = Total_Received_Uniform_Before_Payment + Total_Cash_Transport_Paid;
                    Number_Of_Uniform_Students_After_Payment = Number_Of_Uniform_Students_Before_Payment + Transport_Student_Counter;
                    Total_Transport_Debts_After_Payment = Total_Transport_Debts_Before_Payment - Total_Cash_Transport_Received_After_Payment;


                    try
                    {
                        connection.Open();
                        OleDbCommand Total_Other_Transport_Received_Command = connection.CreateCommand();
                        Total_Other_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Other_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Transfer_Received = '" + Total_Other_Transport_Received_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Other_Transport_Received_Command.ExecuteNonQuery();

                        OleDbCommand Number_Of_Students_Command = connection.CreateCommand();
                        Number_Of_Students_Command.CommandType = CommandType.Text;
                        Number_Of_Students_Command.CommandText = "update [Transport_Managment_tbl]  set Total_Students = '" + Number_Of_Transport_Students_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Number_Of_Students_Command.ExecuteNonQuery();

                        OleDbCommand Total_Cash_Transport_Debts_Command = connection.CreateCommand();
                        Total_Cash_Transport_Debts_Command.CommandType = CommandType.Text;
                        Total_Cash_Transport_Debts_Command.CommandText = "update [Transport_Managment_tbl] set Total_Debts = '" + Total_Transport_Debts_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Cash_Transport_Debts_Command.ExecuteNonQuery();

                        OleDbCommand Total_Transport_Received_Command = connection.CreateCommand();
                        Total_Transport_Received_Command.CommandType = CommandType.Text;
                        Total_Transport_Received_Command.CommandText = "update [Transport_Managment_tbl] set Total_Received = '" + Total_Received_Transport_After_Payment + "' WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        Total_Transport_Received_Command.ExecuteNonQuery();
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
                        OleDbCommand Transport_Command = new OleDbCommand
                        {
                            CommandType = CommandType.Text,
                            CommandText = "INSERT INTO [Student_Transport_Payment_tbl] ([First_Name],[Surname],[School_Term],[Transport_Date],[Payment_Method],[Amount_Paid],[Total_Cash_Paid],[Amount_Owing],[Accountant])" + "VALUES (?,?,?,?,?,?,?,?,?)"
                        };
                        Transport_Command.Parameters.AddWithValue("@First_Name", Student_Name_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Surname", Surname_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@School_Term", School_Term_txt.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Transport_Date", Payment_Date_dateTimePicker.Text.Trim());
                        Transport_Command.Parameters.AddWithValue("@Payment_Method", Transport_Payment_Method);
                        Transport_Command.Parameters.AddWithValue("@Amount_Paid", Transport_Fees_txt.Value);
                        Transport_Command.Parameters.AddWithValue("@Total_Cash_Paid", Total_Cash_Transport_Paid);
                        Transport_Command.Parameters.AddWithValue("@Amount_Owing", Cash_Transport_Balance_After_Payment);
                        Transport_Command.Parameters.AddWithValue("@Accountant", User_txt.Text.Trim());
                        Transport_Command.Connection = connection;
                        connection.Open();
                        Transport_Command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show(Student_Name_txt.Text.Trim() + " " + Surname_txt.Text.Trim() + " has paid;\n\n " + "\t\t$" + Total_Cash_Transport_Paid + " in " + Transport_Payment_Method, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Student_Name_txt.Text = "";
                        Surname_txt.Text = "";
                        School_Term_txt.Text = "";

                        Fees_Payment_Method = "";

                        Payment_Date_dateTimePicker.Value = DateTime.Now;

                        Fees_Balance_lbl.Text = "Fees Balance :";
                        Transport_Balance_lbl.Text = "Transport Balance :";
                        Uniform_Balance_lbl.Text = "Uniform Balance :";

                        Fees_Balance_txt.Value = 0;
                        Transport_Balance_txt.Value = 0;
                        Uniform_Balance_txt.Value = 0;

                        School_Fees_txt.Value = 0;
                        Transport_Fees_txt.Value = 0;
                        Uniforms_Prices_txt.Value = 0;

                        Cash_Fees_radioButton.Checked = false;
                        Fees_Transfer_radioButton.Checked = false;
                        Fees_Bank_radioButton.Checked = false;
                        Fees_Other_radioButton.Checked = false;

                        Cash_Transport_radioButton.Checked = false;
                        Transport_Transfer_radioButton.Checked = false;
                        Transport_Bank_radioButton.Checked = false;
                        Transport_Other_radioButton.Checked = false;

                        Cash_Uniforms_radioButton.Checked = false;
                        Uniforms_Transfer_radioButton.Checked = false;
                        Uniforms_Bank_radioButton.Checked = false;
                        Uniforms_Other_radioButton.Checked = false;

                        Save_btn.Enabled = false;
                        Student_Name_txt.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                #endregion

                #region Clear
                Student_Name_txt.Text = "";
                Surname_txt.Text = "";
                School_Term_txt.Text = "";

                Fees_Payment_Method = "";

                Payment_Date_dateTimePicker.Value = DateTime.Now;

                Fees_Balance_lbl.Text = "Fees Balance :";
                Transport_Balance_lbl.Text = "Transport Balance :";
                Uniform_Balance_lbl.Text = "Uniform Balance :";

                Fees_Balance_txt.Value = 0;
                Transport_Balance_txt.Value = 0;
                Uniform_Balance_txt.Value = 0;

                School_Fees_txt.Value = 0;
                Transport_Fees_txt.Value = 0;
                Uniforms_Prices_txt.Value = 0;

                Cash_Fees_radioButton.Checked = false;
                Fees_Transfer_radioButton.Checked = false;
                Fees_Bank_radioButton.Checked = false;
                Fees_Other_radioButton.Checked = false;

                Cash_Transport_radioButton.Checked = false;
                Transport_Transfer_radioButton.Checked = false;
                Transport_Bank_radioButton.Checked = false;
                Transport_Other_radioButton.Checked = false;

                Cash_Uniforms_radioButton.Checked = false;
                Uniforms_Transfer_radioButton.Checked = false;
                Uniforms_Bank_radioButton.Checked = false;
                Uniforms_Other_radioButton.Checked = false;

                Save_btn.Enabled = false;
                Student_Name_txt.Focus();

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Student_Fees_Uniforms_n_Transport_Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Fees_Managment_tbl' table. You can move, or remove it, as needed.
            this.fees_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Fees_Managment_tbl);
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Student_Registration_Record_tbl' table. You can move, or remove it, as needed.
            this.student_Registration_Record_tblTableAdapter.Fill(this.system_DatabaseDataSet.Student_Registration_Record_tbl);
            try
            {
                connection.Open();
                string TransferQuery = "Select [Transfer_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Payment_Date_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter TransferAdapt = new OleDbDataAdapter(TransferQuery, connection);
                DataTable TransferTbl = new DataTable();
                TransferAdapt.Fill(TransferTbl);
                Transfer_Rate_lbl.Text = TransferTbl.Rows[(TransferTbl.Rows.Count) - 1][0].ToString();


                string BankQuery = "Select [Bank_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Payment_Date_dateTimePicker.Text.Trim()) + "'";
                OleDbDataAdapter BankAdapt = new OleDbDataAdapter(BankQuery, connection);
                DataTable BankTbl = new DataTable();
                BankAdapt.Fill(BankTbl);
                Bank_Rate_lbl.Text = BankTbl.Rows[(BankTbl.Rows.Count) - 1][0].ToString();


                string OtherQuery = "Select [US_To_Cash] FROM [System_Exchange_Rates_tbl] WHERE Rate_Date = '" + Convert.ToString(Payment_Date_dateTimePicker.Text.Trim())+ "'";
                OleDbDataAdapter OtherAdapt = new OleDbDataAdapter(OtherQuery, connection);
                DataTable OtherTbl = new DataTable();
                OtherAdapt.Fill(OtherTbl);
                Other_Rate_lbl.Text = OtherTbl.Rows[(OtherTbl.Rows.Count) - 1][0].ToString();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                MessageBox.Show("Please go to your Settings and enter today's Exchange Rates.\n\t\t :(", "Exchange Rates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Payment_Date_dateTimePicker.Value = DateTime.Now;
            Save_btn.Enabled = false;
            Student_Name_txt.Text = "";
            Surname_txt.Text = "";
            School_Term_txt.Text = "";
            Student_Name_txt.Focus();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Student_Name_txt.Text == "" || Surname_txt.Text == "" || School_Term_txt.Text == "")
            {
                Save_btn.Enabled = false;
            }
            
            else if (Fees_Balance_txt.Value == 0 && Transport_Balance_txt.Value == 0 && Uniform_Balance_txt.Value == 0)
            {
                Save_btn.Enabled = false;
                REGISTERED_lbl.Visible = true;
            }
            else
            {
                Save_btn.Enabled = true;
                School_Fees_txt.Enabled = true;
                Transport_Fees_txt.Enabled = true;
                Uniforms_Prices_txt.Enabled = true;
                REGISTERED_lbl.Visible = false;
            }
        }

        private void Cash_Fees_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cash_Fees_radioButton.Checked == true)
            {
                Fees_Balance_lbl.Text = "Cash Balance :";

                try
                {
                    string School_Fees_Query = "Select [Fees_Cash] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter School_Fees_Adapt = new OleDbDataAdapter(School_Fees_Query, connection);
                    DataTable School_Fees_Tbl = new DataTable();
                    School_Fees_Adapt.Fill(School_Fees_Tbl);


                    if (School_Fees_Tbl.Rows.Count > 0)
                    {
                        string Fees_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        OleDbDataAdapter Fees_Adapt = new OleDbDataAdapter(Fees_Query, connection);
                        DataTable FeesTbl = new DataTable();
                        Fees_Adapt.Fill(FeesTbl);

                        if (FeesTbl.Rows.Count > 0)
                        {
                            Fees_Balance_txt.Value = Convert.ToDecimal(FeesTbl.Rows[(FeesTbl.Rows.Count) - 1][0].ToString());
                            Cash_Fees_Balance_Before_Payment = Fees_Balance_txt.Value;
                        }
                        else
                        {
                            Fees_Balance_txt.Value = Convert.ToDecimal(School_Fees_Tbl.Rows[(School_Fees_Tbl.Rows.Count) - 1][0].ToString());
                            Cash_Fees_Balance_Before_Payment = Fees_Balance_txt.Value;
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

        private void Student_Name_txt_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Fees_Transfer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Fees_Transfer_radioButton.Checked == true)
            {
                Fees_Balance_lbl.Text = "Transfer Balance :";

                try
                {
                    Fees_Balance_txt.Value = Cash_Fees_Balance_Before_Payment / Convert.ToDecimal(Transfer_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Fees_Bank_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Fees_Bank_radioButton.Checked == true)
            {
                Fees_Balance_lbl.Text = "Bank Balance :";

                try
                {
                    Fees_Balance_txt.Value = Cash_Fees_Balance_Before_Payment / Convert.ToDecimal(Bank_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Fees_Other_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Fees_Other_radioButton.Checked == true)
            {
                Fees_Balance_lbl.Text = "Other Balance :";

                try
                {
                    Fees_Balance_txt.Value = Cash_Fees_Balance_Before_Payment / Convert.ToDecimal(Other_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void School_Term_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string School_Fees_Query = "Select [Fees_Cash] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Fees_Adapt = new OleDbDataAdapter(School_Fees_Query, connection);
                DataTable School_Fees_Tbl = new DataTable();
                School_Fees_Adapt.Fill(School_Fees_Tbl);


                if (School_Fees_Tbl.Rows.Count > 0)
                {
                    string Fees_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Fees_Adapt = new OleDbDataAdapter(Fees_Query, connection);
                    DataTable FeesTbl = new DataTable();
                    Fees_Adapt.Fill(FeesTbl);

                    if (FeesTbl.Rows.Count > 0)
                    {
                        Fees_Balance_txt.Value = Convert.ToDecimal(FeesTbl.Rows[(FeesTbl.Rows.Count) - 1][0].ToString());
                        Cash_Fees_Balance_Before_Payment = Fees_Balance_txt.Value;
                    }
                    else
                    {
                        Fees_Balance_txt.Value = Convert.ToDecimal(School_Fees_Tbl.Rows[(School_Fees_Tbl.Rows.Count) - 1][0].ToString());
                        Cash_Fees_Balance_Before_Payment = Fees_Balance_txt.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            try
            {
                string School_Transport_Query = "Select [Transport_Cash] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Transport_Adapt = new OleDbDataAdapter(School_Transport_Query, connection);
                DataTable School_Transport_Tbl = new DataTable();
                School_Transport_Adapt.Fill(School_Transport_Tbl);


                if (School_Transport_Tbl.Rows.Count > 0)
                {
                    string Transport_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                    DataTable Transport_Tbl = new DataTable();
                    Transport_Adapt.Fill(Transport_Tbl);

                    if (Transport_Tbl.Rows.Count > 0)
                    {
                        Transport_Balance_txt.Value = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][0].ToString());
                        Cash_Transport_Balance_Before_Payment = Transport_Balance_txt.Value;
                    }
                    else
                    {
                        Transport_Balance_txt.Value = Convert.ToDecimal(School_Transport_Tbl.Rows[(School_Transport_Tbl.Rows.Count) - 1][0].ToString());
                        Cash_Transport_Balance_Before_Payment = Transport_Balance_txt.Value;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            try
            {
                string School_Uniforms_Query = "Select [Uniform_Cash] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Uniforms_Adapt = new OleDbDataAdapter(School_Uniforms_Query, connection);
                DataTable School_Uniforms_Tbl = new DataTable();
                School_Uniforms_Adapt.Fill(School_Uniforms_Tbl);


                if (School_Uniforms_Tbl.Rows.Count > 0)
                {
                    string Uniforms_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter Uniforms_Adapt = new OleDbDataAdapter(Uniforms_Query, connection);
                    DataTable Uniforms_Tbl = new DataTable();
                    Uniforms_Adapt.Fill(Uniforms_Tbl);

                    if (Uniforms_Tbl.Rows.Count > 0)
                    {
                        Uniform_Balance_txt.Value = Convert.ToDecimal(Uniforms_Tbl.Rows[(Uniforms_Tbl.Rows.Count) - 1][0].ToString());
                        Cash_Uniform_Balance_Before_Payment = Uniform_Balance_txt.Value;
                    }
                    else
                    {
                        Uniform_Balance_txt.Value = Convert.ToDecimal(School_Uniforms_Tbl.Rows[(School_Uniforms_Tbl.Rows.Count) - 1][0].ToString());
                        Cash_Uniform_Balance_Before_Payment = Uniform_Balance_txt.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    
        private void Cash_Transport_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cash_Transport_radioButton.Checked == true)
            {
                Transport_Balance_lbl.Text = "Cash Balance :";
                try
                {
                    string School_Transport_Query = "Select [Transport_Cash] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter School_Transport_Adapt = new OleDbDataAdapter(School_Transport_Query, connection);
                    DataTable School_Transport_Tbl = new DataTable();
                    School_Transport_Adapt.Fill(School_Transport_Tbl);


                    if (School_Transport_Tbl.Rows.Count > 0)
                    {
                        string Transport_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        OleDbDataAdapter Transport_Adapt = new OleDbDataAdapter(Transport_Query, connection);
                        DataTable Transport_Tbl = new DataTable();
                        Transport_Adapt.Fill(Transport_Tbl);

                        if (Transport_Tbl.Rows.Count > 0)
                        {
                            Transport_Balance_txt.Value = Convert.ToDecimal(Transport_Tbl.Rows[(Transport_Tbl.Rows.Count) - 1][0].ToString());
                            Cash_Transport_Balance_Before_Payment = Transport_Balance_txt.Value;
                        }
                        else
                        {
                            Transport_Balance_txt.Value = Convert.ToDecimal(School_Transport_Tbl.Rows[(School_Transport_Tbl.Rows.Count) - 1][0].ToString());
                            Cash_Transport_Balance_Before_Payment = Transport_Balance_txt.Value;
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

        private void Transport_Transfer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Transport_Transfer_radioButton.Checked == true)
            {
                Transport_Balance_lbl.Text = "Transfer Balance :";

                try
                {
                    Transport_Balance_txt.Value = Cash_Transport_Balance_Before_Payment / Convert.ToDecimal(Transfer_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Transport_Bank_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Transport_Bank_radioButton.Checked == true)
            {
                Transport_Balance_lbl.Text = "Bank Balance :";

                try
                {
                    Transport_Balance_txt.Value = Cash_Transport_Balance_Before_Payment / Convert.ToDecimal(Bank_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Transport_Other_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Transport_Other_radioButton.Checked == true)
            {
                Transport_Balance_lbl.Text = "Other Balance :";

                try
                {
                    Transport_Balance_txt.Value = Cash_Transport_Balance_Before_Payment / Convert.ToDecimal(Other_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Cash_Uniforms_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cash_Uniforms_radioButton.Checked == true)
            {
                Uniform_Balance_lbl.Text = "Cash Balance :";

                try
                {
                    string School_Uniforms_Query = "Select [Uniform_Cash] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                    OleDbDataAdapter School_Uniforms_Adapt = new OleDbDataAdapter(School_Uniforms_Query, connection);
                    DataTable School_Uniforms_Tbl = new DataTable();
                    School_Uniforms_Adapt.Fill(School_Uniforms_Tbl);


                    if (School_Uniforms_Tbl.Rows.Count > 0)
                    {
                        string Uniforms_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE First_Name = '" + Student_Name_txt.Text.Trim() + "' and Surname = '" + Surname_txt.Text.Trim() + "' and School_Term = '" + School_Term_txt.Text.Trim() + "'";
                        OleDbDataAdapter Uniforms_Adapt = new OleDbDataAdapter(Uniforms_Query, connection);
                        DataTable Uniforms_Tbl = new DataTable();
                        Uniforms_Adapt.Fill(Uniforms_Tbl);

                        if (Uniforms_Tbl.Rows.Count > 0)
                        {
                            Uniform_Balance_txt.Value = Convert.ToDecimal(Uniforms_Tbl.Rows[(Uniforms_Tbl.Rows.Count) - 1][0].ToString());
                            Cash_Uniform_Balance_Before_Payment = Uniform_Balance_txt.Value; 
                        }
                        else
                        {
                            Uniform_Balance_txt.Value = Convert.ToDecimal(School_Uniforms_Tbl.Rows[(School_Uniforms_Tbl.Rows.Count) - 1][0].ToString());
                            Cash_Uniform_Balance_Before_Payment = Uniform_Balance_txt.Value;
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

        private void Uniforms_Transfer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Uniforms_Transfer_radioButton.Checked == true)
            {
                Uniform_Balance_lbl.Text = "Transfer Balance :";

                try
                {
                    Uniform_Balance_txt.Value = Cash_Uniform_Balance_Before_Payment / Convert.ToDecimal(Transfer_Rate_lbl.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Uniforms_Bank_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Uniforms_Bank_radioButton.Checked == true)
            {
                Uniform_Balance_lbl.Text = "Bank Balance :";

                try
                {
                    Uniform_Balance_txt.Value = Cash_Uniform_Balance_Before_Payment / Convert.ToDecimal(Bank_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Uniforms_Other_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Uniforms_Other_radioButton.Checked == true)
            {
                Uniform_Balance_lbl.Text = "Other Balance :";

                try
                {
                    Uniform_Balance_txt.Value = Cash_Uniform_Balance_Before_Payment / Convert.ToDecimal(Other_Rate_lbl.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
    
