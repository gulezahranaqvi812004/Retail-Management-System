using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void empAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new AddEmp();
            m.Show();
        }

        private void delEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new delEmp();
            m.Show();
        }

        private void updateEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new updateSalary();
            m.Show();
        }

        private void viewEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new ViewEmp();
            m.Show();
        }

        private void addDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new AddDevice();
            m.Show();
        }

        private void delDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new DeleteDevice();
            m.Show();
        }

        private void viewDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new ViewDevices();
            m.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form m = new SignInSignUpDesktop();
            m.Show();
        }
    }
}
