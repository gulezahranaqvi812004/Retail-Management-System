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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BusinessApplication
{
    public partial class DeleteDevice : Form
    {
        public DeleteDevice()
        {
            InitializeComponent();
        }

        private void DeleteDevice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
          
            bool check = Items.is_item_already_exist(Name);
            if (check == true)
            {
                int index = Items.FindIndexToDelete(Name);
                ItemsDL.RemoveItemIntoList(index);
             /*   ItemsDL.Store_data_of_items_to_file();*/
               MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Device does not exist");
            }
            clearData();
        }
        private void clearData()
        {
            name.Text = string.Empty;
        }
    }
}
