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
    public partial class changePin : Form
    {
        public changePin()
        {
            InitializeComponent();
        }

        private void changePin_Load(object sender, EventArgs e)
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
                    string newPassword = newPin.Text;
                    Person p = new Person(username, newPassword, "customer");
                    PersonDL.AddUserIntoList(p);
                    PersonDL.Store_to_file();
                    MessageBox.Show("Successfully updated password!");
                }
                else
                {
                    MessageBox.Show("Invalid User");
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
