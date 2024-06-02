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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void ok_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string Password = password.Text;
           /* string Role = role.Text;*/
            string Role=comboBox1.SelectedItem.ToString();
           /* MessageBox.Show(Role);
            MessageBox.Show(comboBox1.SelectedItem.ToString());*/
            Person p = new Person(username, Password, Role);
            if (Person.ValidateInputForSignUp(username, Password))
            {

                if (Person.isUserAlreadyPresent(p.getUserName(), p.getPassword()))
                {
                    MessageBox.Show("User already present");
                }
                else
                {
                    PersonDL.AddUserIntoList(p);
                    PersonDL.Store_to_file();
                    MessageBox.Show("User successfully added");
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
            name.Text = " ";
            password.Text = " ";
              }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new SignInSignUpDesktop();
            form.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
