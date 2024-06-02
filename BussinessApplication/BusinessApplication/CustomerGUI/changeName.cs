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
using BusinessApplication.CustomerGUI;
namespace BusinessApplication
{
    public partial class changeName : Form
    {
        public changeName()
        {
            InitializeComponent();
        }

        private void changeName_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            
            string Password = password.Text;
            
          
            if (Person.ValidateInputForSignUp(Name, Password) == true)
            {

                if (!(Person.isUserAlreadyPresent(Name, Password)))
                {
                    string Name = newName.Text;
                    Person p = new Person(Name, Password, "customer");
                    PersonDL.AddUserIntoList(p);
                    PersonDL.Store_to_file();
                    MessageBox.Show("Successfully updated your user_name!");
                }
                else
                {
                    MessageBox.Show("Invalid user!");
                }
            }
            else
            {
                MessageBox.Show("Enter correct input");
            }
            clearData();
        }
        private void clearData()
        {
            this.Hide();
            Form f = new CustomerMenu();
            f.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
          
        }

        private void exit_Click_1(object sender, EventArgs e)
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
