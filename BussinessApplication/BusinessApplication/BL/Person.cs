using BusinessApplication.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication.DL;
using System.Runtime.CompilerServices;

namespace BusinessApplication.BL
{
    internal class Person
    {
        private string user_name;
        private string role;
        private string password;

        protected string User_name { get => user_name; set => user_name = value; }
        protected string Role { get => role; set => role = value; }
        protected string Password { get => password; set => password = value; }

        public Person() { }
        public Person(string user_name, string password, string role)
        {
            this.User_name = user_name;
            this.Role = role;
            this.Password = password;
        }
        public Person(string user_name, string password, string role, double salary)
        {
           /* this.user_name = user_name;
            this.role = role;
            this.password = password;*/
            Employee e = new Employee(user_name, password, role, salary);

        }
        public virtual string toString()
        {
            return getUserName() + " " + getPassword() + " " + getUserRole();
        }
        public virtual void setSalary(Double salary)
        {

        }
        public virtual string getUserName()
        {
            return User_name;
        }
        public virtual string getUserRole()
        {
            return Role;
        }
        public virtual string getPassword()
        {
            return Password;
        }
        public virtual double getSalary()
        {
            return 0;
        }
        public void setPassword(string password)
        {
            this.Password = password;
        }
        public void setName(string name)
        {
            User_name = name;
        }

        public static bool Name_check(string name)
        {
            bool flag = false;
            int i = 0;
            while (i < name.Length)
            {
                if (name.Length <= 2)
                {
                    Console.WriteLine("Your Name Should  Be Atleast 3 Characters Long");

                    break;
                }
                if ((name[i] > 63 && name[i] < 91) || (name[i] > 96 && name[i] < 123) || name[i] == ' ')
                {
                    i++;

                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static bool ValidateInputForSignIn(string name, string password)
        {
            if (Name_check(name) && Password_validation(password))
                {
                return true;
            }
            return false;

        }
        public static bool ValidateInputForSignUp(string name,string password)
        {
            if (Name_check(name) && Password_validation(password) )
            {
                return true;
            }
            return false;

        }
        public static bool Password_validation(string password)
        {
            bool flag = false;
            if (password.Length >= 3)
            {
                flag = true;
            }
            return flag;
        }
        public static bool Role_check(string role)
        {
            bool value = false;
            if (role == "customer" || role == "admin" || role == "employee")
            {
                value = true;
            }
            return value;
        }
        public static bool Sign_up()
        {
            Person p;
            p = PersonUI.TakeInputForSignUP();
            if (p != null)
            {
                PersonDL.AddUserIntoList(p);
                PersonDL.Store_to_file();
                return true;
            }
            return false;
        }
        public static bool isUserAlreadyPresent(string userName, string password)
        {

            bool flag = false;
            foreach (Person p in PersonDL.GetUsers())
            {

                if (p.getUserName() == userName && p.getPassword() == password)
                {
                    flag = true;

                }
            }
            return flag;
        }

    }
}
