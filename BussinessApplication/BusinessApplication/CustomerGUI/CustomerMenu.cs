using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication.CustomerGUI
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void changeName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new changeName();
            this.Hide();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form f = new changePin();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new isAvailable();
            this.Hide();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form f = new purchaseDevice();
            this.Hide();
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new ViewMenu();
            this.Hide();
            f.Show();
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
