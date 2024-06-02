using BusinessApplication.AdminGUI;
using BusinessApplication.BL;
using BusinessApplication.CustomerGUI;
using BusinessApplication.DL;
using BusinessApplication.UI;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearData()
        {
            name.Text = " ";
            password.Text = " ";

        }


        private void ok_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Password = password.Text;
           
            string Role = AdminBL.Return_role(Name, Password);
            MessageBox.Show("We welcome our "+Role+"!");
            if (Person.ValidateInputForSignIn(Name, Password))
            {
                if (Role == "admin" || Role == "customer"|| Role == "employee")
                {
                    
                    if (Role == "admin")
                    {
                        this.Hide();
                        Form form = new another();
                        form.Show();
                    }
                    else if (Role == "customer")
                    {
                        this.Hide();
                        Form form = new CustomerMenu();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Go and first sign up!");
                }
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            clearData();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new SignInSignUpDesktop();
            form.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
