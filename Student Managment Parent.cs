using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Student_Managment_Parent : Form
    {
        public Student_Managment_Parent()
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

        private void studentPaymentsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Fees_Uniforms_n_Transport_Payment StudentPayments = new Student_Fees_Uniforms_n_Transport_Payment();
            StudentPayments.MdiParent = this;
            StudentPayments.Show();
            ((Form)StudentPayments).Controls["User_txt"].Text = User_txt.Text;
        }

        private void studentRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Registraton_Form StudentRegistration = new Student_Registraton_Form();
            StudentRegistration.MdiParent = this;
            StudentRegistration.Show();
            ((Form)StudentRegistration).Controls["User_txt"].Text = User_txt.Text;
        }

        private void studentRegistrationRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Registration_Record StudentRegistrationRecord = new Student_Registration_Record();
            StudentRegistrationRecord.MdiParent = this;
            StudentRegistrationRecord.Show();
            ((Form)StudentRegistrationRecord).Controls["User_txt"].Text = User_txt.Text;
        }
    }
}
