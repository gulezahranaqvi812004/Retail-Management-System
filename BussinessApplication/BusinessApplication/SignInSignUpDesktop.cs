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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BusinessApplication
{
    public partial class SignInSignUpDesktop : Form
    {
        public SignInSignUpDesktop()
        {
            InitializeComponent();
        }
        public SignInSignUpDesktop(string load)
        {
            InitializeComponent();
            if (PersonDL.LoadDataFromFile() == true)
            {
                MessageBox.Show("Data successfully loaded! ");
            }
            else { MessageBox.Show("Unable to load data! "); }
            if (ItemsDL.load_data_of_items())
            {

                MessageBox.Show("Data of devices is successfully loaded! ");
            }
            else { MessageBox.Show("Unable to load data of items! "); }
        }
        private void signIn_Click(object sender, EventArgs e)
        {

        }

        private void signUp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form more = new SignIn();
            more.Show();

        }

        private void SignInSignUpDesktop_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form more = new SignUp();
            more.Show();
        }
    }
}
