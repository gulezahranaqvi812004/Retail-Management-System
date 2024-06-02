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
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {



        }
        private void clearData()
        {
            name.Text = string.Empty;
            password.Text = string.Empty;
            salary.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string username = name.Text;
            string Role = "employee";
            string Password = password.Text;
            string inputsalary = salaryBox.Text;
            double Salary = double.Parse(inputsalary);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Role)||string.IsNullOrEmpty(inputsalary))
            {
                MessageBox.Show("Please enter  username ,password and salary.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Person.ValidateInputForSignUp(username, Password) == true)
            {

                if (Person.isUserAlreadyPresent(username, Password))
                {
                    Employee p = new Employee(username, Password, Role, Salary);
                    PersonDL.AddUserIntoList(p);
                    PersonDL.Store_to_file();
                    MessageBox.Show("User successfully added");
                }
                else
                {
                    MessageBox.Show("User already present");
                }
            }
            else
            {
                MessageBox.Show("Enter correct input!");
            }
            clearData();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AdminMenu();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
