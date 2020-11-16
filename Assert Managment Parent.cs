using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Assert_Managment_Parent : Form
    {
       
        public Assert_Managment_Parent()
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

        private void assertManagmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assert_Registration_Form AssertForm = new Assert_Registration_Form();
            AssertForm.MdiParent = this;
            AssertForm.Show();
            ((Form)AssertForm).Controls["User_txt"].Text = User_txt.Text;
        }
    }
}
