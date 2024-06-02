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

namespace BusinessApplication
{
    public partial class AddDevice : Form
    {
        public AddDevice()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void salary_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDevice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name=name.Text;
            string enteredQuantity = stock.Text;
            string p = pp.Text;
            bool check=Items.is_item_already_exist(Name);
            int price = int.Parse(p);
            int quantity = int.Parse(enteredQuantity);
            Items items = new Items(Name,price,quantity);
     
            if(check)
            {
                MessageBox.Show("Your entered item is already present. ");
            }
            else
            {
                ItemsDL.AddItemIntoList(items);
                MessageBox.Show("Successfully added ");
            }
            clearData();
        }
        private void clearData()
        {
            name.Text=string.Empty;
            stock.Text=string.Empty;
            pp.Text = string.Empty;
        }
    }
}
