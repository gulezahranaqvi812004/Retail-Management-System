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
    public partial class delEmp : Form
    {
        public delEmp()
        {
            InitializeComponent();
        }

        private void delEmp_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string Role = "employee";
            string Password = password.Text;
         
            Person p = new Person(username, Password, Role);
            if (Person.ValidateInputForSignUp(Name, Password) == true)
            {

                if (!(Person.isUserAlreadyPresent(p.getUserName(), p.getPassword())))
                {
                    int i = AdminBL.FindIndex(p);
                    PersonDL.DeleteUser(i);
                    PersonDL.Store_to_file();
                    MessageBox.Show("User successfully deleted");
                }
                else
                {
                    MessageBox.Show("User is not present");
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
            name.Text = string.Empty;
            password.Text = string.Empty;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AdminMenu();
            f.Show();
        }
    }
}
