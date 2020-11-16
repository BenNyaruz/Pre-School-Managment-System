using System;
using System.Windows.Forms;

namespace Pre_School_Managment_System
{
    public partial class Accounting_System_Parent : Form
    {
        
        public Accounting_System_Parent()
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

        private void profitAndLossAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounting_Profit_n_Loss_Acc ProfitNLossAcc = new Accounting_Profit_n_Loss_Acc();
            ProfitNLossAcc.MdiParent = this;
            ProfitNLossAcc.Show();
            ((Form)ProfitNLossAcc).Controls["User_txt"].Text = User_txt.Text;
        }

        private void studentFeesPaymentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounting_Student_Fees_Payment_Record StudentFeesPayment = new Accounting_Student_Fees_Payment_Record();
            StudentFeesPayment.MdiParent = this;
            StudentFeesPayment.Show();
        }

        private void studentUniformPaymentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounting_Student_Uniform_Payment_Record StudentUniformPayment = new Accounting_Student_Uniform_Payment_Record();
            StudentUniformPayment.MdiParent = this;
            StudentUniformPayment.Show();
        }

        private void studentTransportPaymentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounting_Student_Transport_Payment_Record StudentTransportPayment = new Accounting_Student_Transport_Payment_Record();
            StudentTransportPayment.MdiParent = this;
            StudentTransportPayment.Show();
        }
    }
}
