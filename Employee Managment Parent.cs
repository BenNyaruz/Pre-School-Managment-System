using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Employee_Managment_Parent : Form
    {
  
        public Employee_Managment_Parent()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {      
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Menu mainfrm = new Main_Menu();
            ((Form)mainfrm).Controls["User_txt"].Text = User_txt.Text;
            ((Form)mainfrm).Controls["Username_lbl"].Text = Username_lbl.Text.Trim();
            ((Form)mainfrm).Controls["Password_lbl"].Text = Password_lbl.Text.Trim();
            mainfrm.Show();
            this.Close();
        }
        
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
                Main_Menu mainfrm = new Main_Menu();
                ((Form)mainfrm).Controls["User_txt"].Text = User_txt.Text;
                ((Form)mainfrm).Controls["Username_lbl"].Text = Username_lbl.Text.Trim();
                ((Form)mainfrm).Controls["Password_lbl"].Text = Password_lbl.Text.Trim();
                mainfrm.Show();
                this.Close();                
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void EmployeeSalaryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Salary_Form EmployeeSalary = new Employee_Salary_Form
            {
                MdiParent = this
            };
            EmployeeSalary.Show();
            ((Form)EmployeeSalary).Controls["User_txt"].Text = User_txt.Text;
        }

        private void EmployeeRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Registration_Form EmployeeRegistration = new Employee_Registration_Form
            {
                MdiParent = this
            };
            EmployeeRegistration.Show();
            ((Form)EmployeeRegistration).Controls["User_txt"].Text = User_txt.Text;
        }

        private void EmployeeRegistrationRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Registration_Record EmployeeRegistrationRecord = new Employee_Registration_Record
            {
                MdiParent = this
            };
            EmployeeRegistrationRecord.Show();
            ((Form)EmployeeRegistrationRecord).Controls["User_txt"].Text = User_txt.Text;
        }

        private void EmployeeSalaryWageNAllawanceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Salaries_Wages_Allawance_Form EmployeeSalaryWageAllawance = new Employee_Salaries_Wages_Allawance_Form
            {
                MdiParent = this
            };
            EmployeeSalaryWageAllawance.Show();
            ((Form)EmployeeSalaryWageAllawance).Controls["User_txt"].Text = User_txt.Text;
        }
    }
}
