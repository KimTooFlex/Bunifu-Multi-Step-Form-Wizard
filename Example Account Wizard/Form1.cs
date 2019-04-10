using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Account_Wizard
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //add shadows
           (new Core.DropShaddow()).ApplyShadows(this);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToProfile_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Profile");
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Login");
        }

        private void btnNextBilling_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Billing");
        }

        private void btnPrevToProfile_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Profile");
        }

        private void btnNextFinish_Click(object sender, EventArgs e)
        {
            //upload info here



            bunifuPages1.SetPage("Finish");
            c4.Checked = c4.Enabled = true;
            l4.ForeColor = Color.Indigo;

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update steps
            switch (bunifuPages1.SelectedIndex)
            {
                case 1:
                    c1.Checked =  c1.Enabled = true;
                    l1.ForeColor = Color.Indigo; 
                    break;
                case 2:
                    c2.Checked = c2.Enabled = true;
                    l2.ForeColor = Color.Indigo;
                    break;
                case 3:
                    c3.Checked = c3.Enabled = true;
                    l3.ForeColor = Color.Indigo;
                    break;
                 
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
