using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessApplication.BL;
using BusinessApplication.DL;
using BusinessApplication.UI;
namespace BusinessApplication.UI
{
    internal class PersonUI
    {
        public static Person TakeInputForSignUP()
        {
            SystemUI.Interface_of_application();
            string name = getInputForName();
            string password = getInputForPassword();
            string role = getInputForRole();
            bool check4 = Person.isUserAlreadyPresent(name, password);
            if (check4 == true)
            {
                AdminBL p = new AdminBL(name, role, password);
                return p;
            }
            return null;
        
        }
        public static Person getInputForPerson()
        {
            string name = getInputForName();
            string password = getInputForPassword();
            string role = getInputForRole();
            Person p =new Person(name, password,role);
            return p;
        }
        public static void SignUpIterface()
        {
            bool check = Person.Sign_up();

            if (check)
            {
                Console.WriteLine("Successfully sign up");
            }
            else
            {
                Console.WriteLine("Invalid user!");
            }
        }
        public static string getInputForName()
        {
            string name="";
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
                isValid = Person.Name_check(name);
            }
            return name;
        }
        public static string getInputForRole()
        {
            bool isValid = false;
            string role = "";
            while (isValid == false)
            {
                Console.WriteLine("Enter your role(customer/admin/employee): ");
                role = Console.ReadLine();
                isValid = Person.Role_check(role);
            }
            return role;
        }
        public static string getInputForPassword()
        {
            bool isValid = false;
            string password = "";
            while (isValid == false)
            {
                Console.WriteLine("Enter your password(must contains 8 letterrs): ");
                password = Console.ReadLine();
                isValid = Person.Password_validation(password);
            }
            return password;
        }
        public static void Login_in()
        {

            string name = getInputForName();
            string password = getInputForPassword();
            string role = AdminBL.Return_role(name, password);

            if (role != null)
            {
                Console.WriteLine("Welcome");
                if(role =="admin")
                {
                    AdminUI.Admin_functionality();
                }
                else if (role =="customer")
                {
                    CustomerUI.Customer_functionality();
                }
            }
            else
            {
                Console.WriteLine("Go and first sign up!");
            }
        }
        public static void viewUsers()
        {
            foreach(Person person in PersonDL.person)
            {
                Console.WriteLine(person.getUserName()+" "+person.getPassword()+" "+person.getUserRole());
            }
        }
    }
}
