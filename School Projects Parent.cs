using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class School_Projects_Parent : Form
    {
        public School_Projects_Parent()
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

        private void schoolProjectIncomeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Project_Income_Form ProjectIncome = new School_Project_Income_Form();
            ProjectIncome.MdiParent = this;
            ProjectIncome.Show();
            ((Form)ProjectIncome).Controls["User_txt"].Text = User_txt.Text;
        }

        private void schoolProjectManagmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Project_Managment_Form ProjectManagmentForm = new School_Project_Managment_Form();
            ProjectManagmentForm.MdiParent = this;
            ProjectManagmentForm.Show();
            ((Form)ProjectManagmentForm).Controls["User_txt"].Text = User_txt.Text;
        }

        private void schoolProjectCreationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            School_Projects_Form ProjectCreationForm = new School_Projects_Form();
            ProjectCreationForm.MdiParent = this;
            ProjectCreationForm.Show();
            ((Form)ProjectCreationForm).Controls["User_txt"].Text = User_txt.Text;
        }
    }
}
