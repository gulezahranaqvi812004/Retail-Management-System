using BusinessApplication.BL;
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

namespace BusinessApplication.AdminGUI
{
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string quantity=label1.Text;
            int updated_stock=int.Parse(quantity);
     
            bool check=Items.is_item_already_exist(Name);
            if (check)
            {
                Items i1 = new Items();
                Items.Update_stock(Name, updated_stock);
              /*  ItemsDL.Store_data_of_items_to_file();*/
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Item does not exist!");
            }
        }
    }
}
