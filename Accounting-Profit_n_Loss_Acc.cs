using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Accounting_Profit_n_Loss_Acc : Form
    {
        OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);
        private decimal Fees_Income;
        private decimal  Balance_BB;
        private decimal Transport_Income;
        private decimal Uniform_Income;
        private decimal Activity_Income;
        private decimal Total_Income;
        private decimal Fees_Expenses;
        private decimal Uniform_Expenses;
        private decimal Activity_Expenses;
        private decimal Salaries;
        private decimal Wages;
        private decimal Transport_Expenses;
        private decimal Allawance;
        private decimal Total_Expenses;
        private decimal Net_Profit;
        private decimal Total_Fees_Bad_Debts;
        private decimal Total_Transport_Bad_Debts;
        private decimal Total_Uniform_Bad_Debts;
        private decimal Total_Activity_Bad_Debts;
        private decimal Total_Bad_Debts;
        private decimal Profit_Brought_Forward;
        private decimal Total_Fees_Received;
        private decimal Total_Transport_Received;
        private decimal Total_Uniform_Received;
        private decimal Total_Activity_Received;
        private decimal Total_Salary_Expenses;
        private decimal Total_Wage_Expenses;
        private decimal Total_Allawance_Expenses;
        private decimal Total_Fees_Expenses;
        private decimal Total_Transport_Expenses;
        private decimal Total_Uniform_Expenses;
        private decimal Total_Activity_Expenses;

        public Accounting_Profit_n_Loss_Acc()
        {
            InitializeComponent();
        }

        private void Accounting_Profit_n_Loss_Acc_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'system_DatabaseDataSet.Fees_Managment_tbl' table. You can move, or remove it, as needed.
                this.fees_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Fees_Managment_tbl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (School_Term_txt.Text=="")
            {
                Load_btn.Enabled = false;
                Print_btn.Enabled = false;
            }
            else
            {
                Load_btn.Enabled = true;
                Print_btn.Enabled = true;
            }
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private async void Print_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog() {Filter = "Text Documents|*.txt", ValidateNames=true};
            SaveFile.FileName = "Profit n Loss Account " + DateTime.Today.ToShortDateString();

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SR = new StreamWriter(SaveFile.FileName);
                await SR.WriteAsync(Profit_n_Loss_txt.Text);
                SR.Close();

                MessageBox.Show(SaveFile.FileName + "has been saved", "Saved As txt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            #region Total Fees Received
            try
            {
                string School_Fees_Query = "Select [Total_Received] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Fees_Adapt = new OleDbDataAdapter(School_Fees_Query, connection);
                DataTable School_Fees_Tbl = new DataTable();
                School_Fees_Adapt.Fill(School_Fees_Tbl);

                if (School_Fees_Tbl.Rows.Count > 0)
                {
                    Total_Fees_Received = Convert.ToDecimal(School_Fees_Tbl.Rows[(School_Fees_Tbl.Rows.Count) - 1][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Fees Expenses 
            try
            {
                string School_Expense_Query = "Select [Total_Expenses] FROM [Fees_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    Total_Fees_Expenses = Convert.ToDecimal(School_Expense_Tbl.Rows[(School_Expense_Tbl.Rows.Count) - 1][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Transport Received
            try
            {
                string School_Transport_Query = "Select [Total_Received] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Transport_Adapt = new OleDbDataAdapter(School_Transport_Query, connection);
                DataTable School_Transport_Tbl = new DataTable();
                School_Transport_Adapt.Fill(School_Transport_Tbl);

                if (School_Transport_Tbl.Rows.Count > 0)
                {
                    Total_Transport_Received = Convert.ToDecimal(School_Transport_Tbl.Rows[(School_Transport_Tbl.Rows.Count) - 1][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Transport Expenses 
            try
            {
                string School_Expense_Query = "Select [Total_Expenses] FROM [Transport_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    Total_Transport_Expenses = Convert.ToDecimal(School_Expense_Tbl.Rows[(School_Expense_Tbl.Rows.Count) - 1][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Uniform Received
            try
            {
                string School_Uniform_Query = "Select [Total_Received] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Uniform_Adapt = new OleDbDataAdapter(School_Uniform_Query, connection);
                DataTable School_Uniform_Tbl = new DataTable();
                School_Uniform_Adapt.Fill(School_Uniform_Tbl);

                if (School_Uniform_Tbl.Rows.Count > 0)
                {
                    Total_Uniform_Received = Convert.ToDecimal(School_Uniform_Tbl.Rows[(School_Uniform_Tbl.Rows.Count) - 1][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Uniform Expenses
            try
            {
                string School_Expense_Query = "Select [Total_Expenses] FROM [Uniform_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    Total_Uniform_Expenses = Convert.ToDecimal(School_Expense_Tbl.Rows[(School_Expense_Tbl.Rows.Count) - 1][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Activity Received
            try
            {
                string School_Uniform_Query = "Select [Total_Received] FROM [Activity_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Uniform_Adapt = new OleDbDataAdapter(School_Uniform_Query, connection);
                DataTable School_Uniform_Tbl = new DataTable();
                School_Uniform_Adapt.Fill(School_Uniform_Tbl);

                if (School_Uniform_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= School_Uniform_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Activity_Received = Total_Activity_Received + Convert.ToDecimal(School_Uniform_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Activity Expenses
            try
            {
                string School_Expense_Query = "Select [Total_Expenses] FROM [Activity_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    for(int x = 1 ; x <= School_Expense_Tbl.Rows.Count ; x=x+1)
                    {
                        Total_Activity_Expenses = Total_Activity_Bad_Debts + Convert.ToDecimal(School_Expense_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Salary Expenses
            try
            {
                string School_Expense_Query = "Select [Salary] FROM [Employee_Salaries_Wages_Allawance_Record_tbl] WHERE Pay_Period = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= School_Expense_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Salary_Expenses = Total_Salary_Expenses + Convert.ToDecimal(School_Expense_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Wage Expenses
            try
            {
                string School_Expense_Query = "Select [Wage] FROM [Employee_Salaries_Wages_Allawance_Record_tbl] WHERE Pay_Period = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= School_Expense_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Wage_Expenses = Total_Wage_Expenses + Convert.ToDecimal(School_Expense_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Allawance Expenses
            try
            {
                string School_Expense_Query = "Select [Allawance] FROM [Employee_Salaries_Wages_Allawance_Record_tbl] WHERE Pay_Period = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= School_Expense_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Allawance_Expenses = Total_Allawance_Expenses + Convert.ToDecimal(School_Expense_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Fees Bad Debts
            try
            {
                string Total_Fees_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Fees_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Total_Fees_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Fees_Bad_Debts_Query, connection);
                DataTable Total_Fees_Bad_Debts_Tbl = new DataTable();
                Total_Fees_Bad_Debts_Adapt.Fill(Total_Fees_Bad_Debts_Tbl);

                if (Total_Fees_Bad_Debts_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= Total_Fees_Bad_Debts_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Fees_Bad_Debts = Total_Fees_Bad_Debts + Convert.ToDecimal(Total_Fees_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Transport Bad Debts
            try
            {
                string Total_Transport_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Transport_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Total_Transport_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Transport_Bad_Debts_Query, connection);
                DataTable Total_Transport_Bad_Debts_Tbl = new DataTable();
                Total_Transport_Bad_Debts_Adapt.Fill(Total_Transport_Bad_Debts_Tbl);

                if (Total_Transport_Bad_Debts_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= Total_Transport_Bad_Debts_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Transport_Bad_Debts = Total_Transport_Bad_Debts + Convert.ToDecimal(Total_Transport_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Uniform Bad Debts
            try
            {
                string Total_Uniform_Bad_Debts_Query = "Select [Amount_Owing] FROM [Student_Uniform_Payment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter Total_Uniform_Bad_Debts_Adapt = new OleDbDataAdapter(Total_Uniform_Bad_Debts_Query, connection);
                DataTable Total_Uniform_Bad_Debts_Tbl = new DataTable();
                Total_Uniform_Bad_Debts_Adapt.Fill(Total_Uniform_Bad_Debts_Tbl);

                if (Total_Uniform_Bad_Debts_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= Total_Uniform_Bad_Debts_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Uniform_Bad_Debts = Total_Uniform_Bad_Debts + Convert.ToDecimal(Total_Uniform_Bad_Debts_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Total Activity Bad Debts
            try
            {
                string School_Expense_Query = "Select [Total_Debts] FROM [Activity_Managment_tbl] WHERE School_Term = '" + School_Term_txt.Text.Trim() + "'";
                OleDbDataAdapter School_Expense_Adapt = new OleDbDataAdapter(School_Expense_Query, connection);
                DataTable School_Expense_Tbl = new DataTable();
                School_Expense_Adapt.Fill(School_Expense_Tbl);

                if (School_Expense_Tbl.Rows.Count > 0)
                {
                    for (int x = 1; x <= School_Expense_Tbl.Rows.Count; x = x + 1)
                    {
                        Total_Activity_Bad_Debts = Total_Activity_Bad_Debts + Convert.ToDecimal(School_Expense_Tbl.Rows[(x) - 1][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            #region Incomes
            Balance_BB = Balance_BB_txt.Value;
            Fees_Income = Total_Fees_Received;
            Transport_Income = Total_Transport_Received;
            Uniform_Income = Total_Uniform_Received;
            Activity_Income = Total_Activity_Received;
            Total_Income = Balance_BB + Fees_Income + Transport_Income + Uniform_Income + Activity_Income;
            #endregion

            #region Expenses
            Fees_Expenses = Total_Fees_Expenses;
            Transport_Expenses = Total_Transport_Expenses;
            Uniform_Expenses = Total_Uniform_Expenses;
            Activity_Expenses = Total_Activity_Expenses;
            Salaries = Total_Salary_Expenses;
            Wages = Total_Wage_Expenses;
            Allawance = Total_Allawance_Expenses;
            Total_Expenses = Fees_Expenses + Transport_Expenses + Uniform_Expenses + Activity_Expenses + Salaries + Wages + Allawance;
            #endregion

            Net_Profit = Total_Income - Total_Expenses;          
            Total_Bad_Debts = Total_Fees_Bad_Debts + Total_Transport_Bad_Debts + Total_Uniform_Bad_Debts + Total_Activity_Bad_Debts;
            Profit_Brought_Forward = Net_Profit - Total_Bad_Debts;



            Profit_n_Loss_txt.Text = "\n***********************************  " + "Account Period  \"" + School_Term_txt.Text.ToUpper() + "\"   ***********************************\n\n" +
                                    "\t\t" + "Balance Brought Back" + "\t\t"        + Balance_BB.ToString("C2")      + "\n" +
                                    "\t\t" + "Fees Income"          + "\t\t\t\t"    + Fees_Income.ToString("C2")     + "\n" +
                                    "\t\t" + "Transport Income"     + "\t\t\t"      + Transport_Income.ToString("C2")+ "\n" +
                                    "\t\t" + "Uniform Income"       + "\t\t\t"      + Uniform_Income.ToString("C2")  + "\n" +
                                    "\t\t" + "Activity Income"      + "\t\t\t\t"    + Activity_Income.ToString("C2") + "\n" +
                                    "\t\t" + "Total Income"         + "\t\t\t\t\t\t" + Total_Income.ToString("C2")   + "\n\n" +

                                    "\t\t" + "*****Less Expenses*****"        + "\n" +
                                    "\t\t" + "Fees Expenses"        + "\t\t\t\t"    + Fees_Expenses.ToString("C2") + "\n" +
                                    "\t\t" + "Transport Expenses"   + "\t\t\t"      + Transport_Expenses.ToString("C2") + "\n" +
                                    "\t\t" + "Uniform Expenses"     + "\t\t\t"      + Uniform_Expenses.ToString("C2") + "\n" +
                                    "\t\t" + "Activity Expenses"    + "\t\t\t"      + Activity_Expenses.ToString("C2") + "\n" +
                                    "\t\t" + "Salaries"             + "\t\t\t\t\t"  + Salaries.ToString("C2") + "\n" +
                                    "\t\t" + "Wages"                + "\t\t\t\t\t"  + Wages.ToString("C2") + "\n" +
                                    "\t\t" + "Allawances"           + "\t\t\t\t"    + Allawance.ToString("C2") + "\n" +
                                    "\t\t" + "Total Expenses"       + "\t\t\t\t\t\t"   + Total_Expenses.ToString("C2") + "\n" +
                                    "\t\t" + "Net Profit"           + "\t\t\t\t\t\t\t" + Net_Profit.ToString("C2") + "\n\n" +

                                    "\t\t" + "*****Less Bad Debts*****" + "\n" +
                                    "\t\t" + "Fees Bad Debts"       + "\t\t\t" + Total_Fees_Bad_Debts.ToString("C2") + "\n" +
                                    "\t\t" + "Transport Bad Debts"  + "\t\t\t" + Total_Transport_Bad_Debts.ToString("C2") + "\n" +
                                    "\t\t" + "Uniforms Bad Debts"   + "\t\t\t" + Total_Uniform_Bad_Debts.ToString("C2") + "\n" +
                                    "\t\t" + "Activity Bad Debts"   + "\t\t\t" + Total_Activity_Bad_Debts.ToString("C2") + "\n" +
                                    "\t\t" + "Total Bad Debts"      +   "\t\t\t\t\t" + Total_Bad_Debts.ToString("C2") + "\n" +
                                    "\t\t" + "Profit Brought Forward" + "\t\t\t\t"   + Profit_Brought_Forward.ToString("C2") + "\n\n" +

                                    "****************************************** " + DateTime.Today.ToLongDateString() + " *****************************************"
                                    ;


            Fees_Income = 0;
            Balance_BB = 0;
            Transport_Income = 0;
            Uniform_Income = 0;
            Activity_Income = 0;
            Total_Income = 0;
            Fees_Expenses = 0;
            Uniform_Expenses = 0;
            Activity_Expenses = 0;
            Salaries = 0;
            Wages = 0;
            Transport_Expenses = 0;
            Allawance = 0;
            Total_Expenses = 0;
            Net_Profit = 0;
            Total_Fees_Bad_Debts = 0;
            Total_Transport_Bad_Debts = 0;
            Total_Uniform_Bad_Debts = 0;
            Total_Activity_Bad_Debts = 0;
            Total_Bad_Debts = 0;
            Profit_Brought_Forward = 0;
            Total_Fees_Received = 0;
            Total_Transport_Received = 0;
            Total_Uniform_Received = 0;
            Total_Activity_Received = 0;
            Total_Salary_Expenses = 0;
            Total_Wage_Expenses = 0;
            Total_Allawance_Expenses = 0;
            Total_Fees_Expenses = 0;
            Total_Transport_Expenses = 0;
            Total_Uniform_Expenses = 0;
            Total_Activity_Expenses = 0;
    }
    }
}
