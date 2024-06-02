using BusinessApplication.AdminGUI;
using BusinessApplication.BL;
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
    public partial class ViewEmp : Form
    {
        DataTable table = new DataTable();
        int index;

        public ViewEmp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            n.Text = row.Cells[0].Value.ToString();
            q.Text = row.Cells[1].Value.ToString();
            pp.Text = row.Cells[2].Value.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Save data grid view", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
                Form f = new another();
                f.Show();
            }
        }

        private void ViewEmp_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Items.is_item_already_exist(n.Text))
            {
                MessageBox.Show("Item is already present");
            }
            else
            {

                if (string.IsNullOrEmpty(n.Text) || string.IsNullOrEmpty(q.Text) || string.IsNullOrEmpty(pp.Text))
                {
                    MessageBox.Show("Please enter  device name ,quantity and price.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Add(n.Text, q.Text, pp.Text);

                Items items = new Items(n.Text, int.Parse(pp.Text), int.Parse(q.Text));
                ItemsDL.AddItemIntoList(items);
                ItemsDL.Store_data_of_items_to_file();


            }
            clearData();
        }
        private void clearData()
        {
            pp.Text = string.Empty;
            q.Text = string.Empty;
            n.Text = string.Empty;

        }

        private void update_Click(object sender, EventArgs e)
        {

          /*  Items it = new Items(n.Text, int.Parse(pp.Text), int.Parse(q.Text));
            int i = Items.FindIndexToDelete(n.Text);*/
            Items.Update_stock(n.Text, int.Parse(q.Text));
            ItemsDL.Store_data_of_items_to_file();
            MessageBox.Show("Successfully updated");
            DataGridViewRow rows = dataGridView1.Rows[index];
            rows.Cells[0].Value = n.Text;
            rows.Cells[1].Value = q.Text;
            rows.Cells[2].Value = pp.Text;
            
         
            DisplayStock();
            ClearFields();















           /* if (Items.is_item_already_exist(n.Text))
            {
                MessageBox.Show("Device already present");
            }
            else
            {

                Items.Update_stock(Name, int.Parse(q.Text));
                ItemsDL.Store_data_of_items_to_file();


                DataGridViewRow row = dataGridView1.Rows[index];
                row.Cells[0].Value = n.Text;
                row.Cells[1].Value = q.Text;
                row.Cells[2].Value = pp.Text;
            }


            DisplayStock();
            clearData();
*/
        }
        private void DisplayStock()
        {
            dataGridView1.Rows.Clear();
            foreach (Items i in ItemsDL.GetItems())
            {
                dataGridView1.Rows.Add(i.getItemName(), i.getItemQuantity().ToString(), i.getItemPrice().ToString());
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Items.is_item_already_exist(n.Text))
            {
             /*   int i = Items.FindIndexToDelete(n.Text);
                ItemsDL.RemoveItemIntoList(i);
                PersonDL.Store_to_file();*/
                index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Item successfully deleted");
            }
            else
            {
                MessageBox.Show("User is not present");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* dataGridView1.DataSource = null;

             List<Items> list = ItemsDL.GetItems();
             dataGridView1.DataSource = list;
             *//*dataGridView1.DataSource = ItemsDL.GetItems().Select(c => (c.getItemName(), c.getItemQuantity(), c.getItemPrice()));*//*
             dataGridView1.Refresh();*/

            dataGridView1.DataSource = null;
            
            DisplayStock();
            ClearFields();
        }
        private void ClearFields()
        {
            n.Clear();
            q.Clear();
            pp.Clear();
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
