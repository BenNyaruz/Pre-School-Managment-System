using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Activity_Creation_Form : Form
    {
        private readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);

        public Activity_Creation_Form()
        {
            InitializeComponent();
            From_Date_dateTimePicker.Value = DateTime.Now;
            To_Date_dateTimePicker.Value = DateTime.Now;
        }

        private void Build_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Activity_Name_txt.Text == "")
                {
                    MessageBox.Show("Activity Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Activity_Name_txt.Focus();
                }
                else if (Location_txt.Text == "")
                {
                    MessageBox.Show("Location is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Location_txt.Focus();
                }
                else if (School_Term_txt.Text == "")
                {
                    MessageBox.Show("School Term is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    School_Term_txt.Focus();
                }                
                else if (Activity_Description_txt.Text == "")
                {
                    MessageBox.Show(" Activity Description is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Activity_Description_txt.Focus();
                }
                else if (Cash_txt.Value == 0)
                {
                    MessageBox.Show("Cash Payment is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cash_txt.Focus();
                }
                else
                { 
                    connection.Open();
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into [Activity_Managment_tbl] (Activity_Name,Location,School_Term,From_Date,To_Date,Activity_Description,Cash_Fees,Accountant) values ('" + Activity_Name_txt.Text.Trim() + "','" + Location_txt.Text.Trim() + "','" + School_Term_txt.Text.Trim() + "','" + From_Date_dateTimePicker.Text.Trim() + "','" + To_Date_dateTimePicker.Text.Trim() + "','" + Activity_Description_txt.Text.Trim() + "','" + Cash_txt.Value + "','" + User_txt.Text.Trim() + "')";
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show(Activity_Name_txt.Text.Trim() + " will be at " + Location_txt.Text.Trim() + ".\nFrom ;\t\t" + From_Date_dateTimePicker.Value + "\nTo ;\t\t" + To_Date_dateTimePicker.Value + "\n\n\t*****Enjoy Yourself :)*****", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Activity_Name_txt.Text = "";
                    Location_txt.Text = "";
                    School_Term_txt.Text = "";
                    Activity_Description_txt.Text = "";
                    Cash_txt.Value = 0;
                    Activity_Name_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.StackTrace, "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Activity_Creation_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'system_DatabaseDataSet.Fees_Managment_tbl' table. You can move, or remove it, as needed.
            this.fees_Managment_tblTableAdapter.Fill(this.system_DatabaseDataSet.Fees_Managment_tbl);
            From_Date_dateTimePicker.Value = DateTime.Now;
            To_Date_dateTimePicker.Value = DateTime.Now;
            School_Term_txt.Text = "";
        }
    }
}
