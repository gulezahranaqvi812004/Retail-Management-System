using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessApplication.DL;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.IO;
using BusinessApplication.AdminGUI;

namespace BusinessApplication
{
    public partial class ViewDevices : Form
    {
        /*DataTable table = new DataTable();*/
        int index;

        public ViewDevices()
        {
            InitializeComponent();
        }

        private void ViewDevices_Load(object sender, EventArgs e)
        {
            /*DataGridView datagridview = new DataGridView();
            ObservableCollection<Person> persons = new ObservableCollection<Person>();
            *//* List<Person> list = PersonDL.GetUsers();*//*
            dataGridView1.DataSource = table;

            Person p = new Person(Uname.Text, Urole.Text, uPassword.Text);
            persons.Add(p);*/
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Save data grid view", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
                Form f = new another();
                f.Show();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            Uname.Text = row.Cells[0].Value.ToString();
            Urole.Text = row.Cells[1].Value.ToString();
            uPassword.Text = row.Cells[2].Value.ToString();
            uSalary.Text = row.Cells[3].Value.ToString();

        }

        private void ok_Click_1(object sender, EventArgs e)
        {


            if ((Person.isUserAlreadyPresent(Uname.Text, uPassword.Text)))
            {
                MessageBox.Show("User already present");
            }
            else
            {

                if (string.IsNullOrEmpty(Uname.Text) || string.IsNullOrEmpty(uPassword.Text) || string.IsNullOrEmpty(Urole.Text))
                {
                    MessageBox.Show("Please enter  username ,password and salary.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Person.ValidateInputForSignUp(Uname.Text, uPassword.Text) == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Add(Uname.Text, Urole.Text, uPassword.Text, uSalary.Text);


                    Employee p = new Employee(Uname.Text, uPassword.Text, Urole.Text, double.Parse(uSalary.Text));
                    PersonDL.AddUserIntoList(p);
                    PersonDL.Store_to_file();
                }
                else
                {
                    MessageBox.Show("Enter correct input!");
                }

            }
            clearData();
            /* ObservableCollection<Person> persons = new ObservableCollection<Person>();
             List<Person> list = PersonDL.GetUsers();

             Person p = new Person(Uname.Text, Urole.Text, uPassword.Text);
             list.Add(p);
             dataGridView1.DataSource = list;*/


            /*    int n = dataGridView1.Rows.Add();*//*
            dataGridView1.Rows[n].Cells[0].Value=Uname.Text;
            dataGridView1.Rows[n].Cells[1].Value = Urole.Text;
            dataGridView1.Rows[n].Cells[2].Value = uPassword.Text;*/


        }
        private void clearData()
        {
            Uname.Text = string.Empty;
            uPassword.Text = string.Empty;
            uSalary.Text = string.Empty;
            Urole.Text = string.Empty;

        }
        private void DisplayStock()
        {
            dataGridView1.Rows.Clear();
            foreach (Person p in PersonDL.GetUsers())
            {
                dataGridView1.Rows.Add(p.getUserName(), p.getUserRole(), p.getPassword(), p.getSalary().ToString());
            }
        }
        private void ClearFields()
        {
            Uname.Clear();
            Urole.Clear();
            uPassword.Clear();
            uSalary.Clear();
        }

        private void update_Click(object sender, EventArgs e)
        {

            /*  if (Person.ValidateInputForSignUp(Uname.Text, uPassword.Text, Urole.Text) == true)
              {*/
            Employee p = new Employee(Uname.Text, uPassword.Text, Urole.Text, double.Parse(uSalary.Text));
            /* if (Person.isUserAlreadyPresent(Uname.Text, uPassword.Text))
             {*/
            int i = AdminBL.FindIndex(p);
            Employee.Update_salary(p, i);
            PersonDL.Store_to_file();
            MessageBox.Show("Successfully updated");
            DataGridViewRow row = dataGridView1.Rows[index];
            row.Cells[0].Value = Uname.Text;
            row.Cells[1].Value = Urole.Text;
            row.Cells[2].Value = uPassword.Text;
            row.Cells[3].Value = uSalary.Text;
            /*  }
              else
              {
                  MessageBox.Show("Can't find employee!");
              }*/
            /* }
             else
             {
                 MessageBox.Show("Enter correct input");
             }*/
            DisplayStock();
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {

            Employee p = new Employee(Uname.Text, uPassword.Text, Urole.Text, double.Parse(uSalary.Text));
            /*int i = AdminBL.FindIndex(p);
            PersonDL.DeleteUser(i);
            PersonDL.Store_to_file();*/
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            MessageBox.Show("User successfully deleted");

        }

        private void import_Click(object sender, EventArgs e)
        {
            /*string[] lines=File.ReadAllLines("D:\\Semester2\\OOP\\BakaEid\\BusinessApplication\\Person.txt");
            string[] values;
            for(int i=0;  i<lines.Length; i++)
            {
                values = lines[i].Split(',');
                string[] row = new string[values.Length];

                for(int j=0; j<values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);    


            }*/

            /*   List<Person> people = PersonDL.GetUsers();
               foreach(Person p in people)
               {
                   table.Rows.Add(p.getUserName(),p.getUserRole(),p.getPassword(),p.getSalary().ToString());


               }*/
            /*List<Person> people = PersonDL.GetUsers();*/
            dataGridView1.DataSource = null;
            /*  dataGridView1.DataSource = people;*/
            DisplayStock();
            ClearFields();
            /*  dataGridView1.Refresh();*/



        }

        private void header_Click(object sender, EventArgs e)
        {

        }
    }
}





















