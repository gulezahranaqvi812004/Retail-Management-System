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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessApplication
{
    public partial class updateSalary : Form
    {
        public updateSalary()
        {
            InitializeComponent();
        }

        private void updateSalary_Load(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void header_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AdminMenu();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = name.Text;
            string Password = password.Text;
            string Role = "employee";
            /*  string input = salary.Text;
              int Salary=int.Parse(input);  
           */
            string inputsalary = salaryBox.Text;
            double Salary = double.Parse(inputsalary);
            if (Person.ValidateInputForSignUp(username, Password) == true)
            {
                Employee p = new Employee(username,  Role, Password, Salary);
                if (!(Person.isUserAlreadyPresent(username, Password)))
                {
                    int i = AdminBL.FindIndex(p);
                    Employee.Update_salary(p,i);
                    PersonDL.Store_to_file();
                    MessageBox.Show("Successfully updated");
                    
                }
                else
                {
                    MessageBox.Show("Can't find employee!");
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
            salaryBox.Text = string.Empty;
        }
    }
}
