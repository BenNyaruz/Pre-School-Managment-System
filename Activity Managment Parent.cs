using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Activity_Managment_Parent : Form
    {
        
        public Activity_Managment_Parent()
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

        private void activityCostManagmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_Cost_Managment_Form ActivityCostForm = new Activity_Cost_Managment_Form();
            ActivityCostForm.MdiParent = this;
            ActivityCostForm.Show();
            ((Form)ActivityCostForm).Controls["User_txt"].Text = User_txt.Text;
        }

        private void activityCreationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_Creation_Form ActivityCreationForm = new Activity_Creation_Form();
            ActivityCreationForm.MdiParent = this;
            ActivityCreationForm.Show();
            ((Form)ActivityCreationForm).Controls["User_txt"].Text = User_txt.Text;
        }

        private void activityRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity_Registration_Form ActivityRegistration = new Activity_Registration_Form();
            ActivityRegistration.MdiParent = this;
            ActivityRegistration.Show();
            ((Form)ActivityRegistration).Controls["User_txt"].Text = User_txt.Text;
        }

    }
}
