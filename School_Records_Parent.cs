using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class School_Records_Parent : Form
    {

        public School_Records_Parent()
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

        private void schoolFeesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Fees_Record FeesRecord = new School_Fees_Record();
            FeesRecord.MdiParent = this;
            FeesRecord.Show();
        }

        private void schoolTransportRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Transport_Record TransportRecord = new School_Transport_Record();
            TransportRecord.MdiParent = this;
            TransportRecord.Show();
        }

        private void schoolUniformRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Uniform_Record UniformRecord = new School_Uniform_Record();
            UniformRecord.MdiParent = this;
            UniformRecord.Show();
        }

        private void schoolActivityRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_Record ActivityRecord = new Activity_Record();
            ActivityRecord.MdiParent = this;
            ActivityRecord.Show();
        }

        private void schoolProjectRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Project_Record ProjectRecord = new School_Project_Record();
            ProjectRecord.MdiParent = this;
            ProjectRecord.Show();
        }

        private void salaryRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Salary_Record SalaryRecord = new Employee_Salary_Record();
            SalaryRecord.MdiParent = this;
            SalaryRecord.Show();
        }
    }
}
