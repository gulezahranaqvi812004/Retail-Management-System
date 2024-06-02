using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessApplication.BL;
using BusinessApplication.CustomerGUI;

namespace BusinessApplication
{
    public partial class isAvailable : Form
    {
        public isAvailable()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Save data grid view", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
                Form f = new CustomerMenu();
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string na = "";
            bool is_found;
            Items i1 = new Items();
            na= n.Text;
            is_found = Items.is_item_already_exist(na);
            if (is_found == true)
            {
              MessageBox.Show("Your desired device is available! ");
            }
            else
            {
                MessageBox.Show("Sorry for inconvinience your desired device is not available!");
            }
        }
    }
}
