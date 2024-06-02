using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication.AdminGUI
{
    public partial class another : Form
    {
        public another()
        {
            InitializeComponent();
        }

        private void viewDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new ViewDevices();
            m.Show();
        }

        private void viewEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new ViewEmp();
            m.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Save data grid view", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
                Form f = new SignInSignUpDesktop();
                f.Show();
            }
        }
    }
}
