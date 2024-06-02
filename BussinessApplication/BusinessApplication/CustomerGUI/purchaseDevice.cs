using BusinessApplication.BL;
using BusinessApplication.CustomerGUI;
using BusinessApplication.DL;
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
    public partial class purchaseDevice : Form
    {
        public purchaseDevice()
        {
            InitializeComponent();
        }

        private void purchaseDevice_Load(object sender, EventArgs e)
        {

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

        private void ok_Click(object sender, EventArgs e)
        {
            int price;
            bool is_found;


            string name = deviceName.Text;
            is_found = Items.is_item_already_exist(name);
            Items i = Items.Check_stock(name);
            if (is_found == true)
            {
                if (i != null)
                {
                    // should be modify

                    DialogResult iExit;
                    price = Items.Find_price(name);
                    MessageBox.Show("Price of your desired device is: {0} , price ");
                    iExit = MessageBox.Show("Confirm if you want to purchase device", "Save data grid view", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (iExit == DialogResult.Yes)
                    {
                        Items.Purchase_a_device(name);
                        ItemsDL.Store_data_of_items_to_file();
                        MessageBox.Show("Thank you for purchasing!");
                    }
                }
                else
                {
                    int index = Items.FindIndexToDelete(name);
                    ItemsDL.RemoveItemIntoList(index);
                    ItemsDL.Store_data_of_items_to_file();
                    MessageBox.Show("Out of stock");
                }
            }
            else
            {
                MessageBox.Show("Device is not present!");
            }
        }
    }
}
