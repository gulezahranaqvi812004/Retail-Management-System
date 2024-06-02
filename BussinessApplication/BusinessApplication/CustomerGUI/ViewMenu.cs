using BusinessApplication.BL;
using BusinessApplication.CustomerGUI;
using BusinessApplication.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication
{
    public partial class ViewMenu : Form
    {
        int index;

        public ViewMenu()
        {
           InitializeComponent();
            dataGridView1.DataSource = null;

            DisplayStock();
            ClearFields();


        }

        private void ViewMenu_Load(object sender, EventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {
            string cart = namee.Text;
            Items.cartOption(cart);
            MessageBox.Show("Successfully purchased!");

        }
        private void DisplayStock()
        {
            dataGridView1.Rows.Clear();
            foreach (Items i in ItemsDL.GetItems())
            {
                dataGridView1.Rows.Add(i.getItemName(), i.getItemQuantity().ToString(), i.getItemPrice().ToString());
            }
        }
        private void ClearFields()
        {
            namee.Clear();
            ppr.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            namee.Text = row.Cells[0].Value.ToString();
            ppr.Text = row.Cells[1].Value.ToString();
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
    }
}
