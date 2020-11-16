using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Login_Form : Form
    {
        readonly OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Pre_School_Managment_System.Properties.Settings.System_DatabaseConnectionString"].ConnectionString);
        private string role;

        public Login_Form()
        {
            InitializeComponent();            
        }

        private void Accept_btn_Click(object sender, EventArgs e)
        {    
            
            try
            {
                if (UserName_txt.Text == "")
                {
                    MessageBox.Show("Please enter your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserName_txt.Focus();
                }
                else if (Password_txt.Text == "")
                {
                    MessageBox.Show("Please enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Password_txt.Focus();
                }
                else if (UserName_txt.Text == "admin" && Password_txt.Text == "admin3092")
                {
                    role = "System Administrator";

                    MessageBox.Show("Welcome " + role, "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Main_Menu mainfrm = new Main_Menu();
                    this.Hide();
                    mainfrm.Show();

                    ((Form)mainfrm).Controls["User_txt"].Text = role;
                    ((Form)mainfrm).Controls["Username_lbl"].Text = role;
                    ((Form)mainfrm).Controls["Password_lbl"].Text = Convert.ToString(DateTime.Now);


                    connection.Open();
                    OleDbCommand command = connection.CreateCommand();
                    command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into [System_Log_tbl] (Username,Login_DateTime) values ('" + role + "','" + DateTime.Now + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    string query = "Select [Role] FROM [System_Users_tbl] WHERE Username = '" + UserName_txt.Text.Trim() + "' and Password = '" + Password_txt.Text.Trim() + "'";
                    OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    role = dtbl.Rows[0][0].ToString();

                    if (role !="")
                    {
                        MessageBox.Show("Welcome " + role, "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                
                        Main_Menu mainfrm = new Main_Menu();
                        this.Hide();
                        mainfrm.Show();

                        ((Form)mainfrm).Controls["User_txt"].Text = role;
                        ((Form)mainfrm).Controls["Username_lbl"].Text = UserName_txt.Text.Trim();
                        ((Form)mainfrm).Controls["Password_lbl"].Text = Convert.ToString(DateTime.Now);


                        connection.Open();
                        OleDbCommand command = connection.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into [System_Log_tbl] (Username,Login_DateTime) values ('" + UserName_txt.Text.Trim() + "','" + DateTime.Now + "')";
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username and/or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserName_txt.Text = "";
                        Password_txt.Text = "";
                        UserName_txt.Focus();
                    }                   
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                UserName_txt.Text = "";
                Password_txt.Text = "";
                UserName_txt.Focus();
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPass_chbox_CheckedChanged(object sender, EventArgs e)
        {
            Password_txt.PasswordChar = ShowPass_chbox.Checked ? '\0' : '*';
        }
    }
}
