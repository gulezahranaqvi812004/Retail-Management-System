using BusinessApplication.BL;
using BusinessApplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.UI
{
    internal class AdminUI
    {
        public static int Admin_menu()
        {
            Console.WriteLine("Press 1 to add an employee");
            Console.WriteLine("Press 2 to view yours employee");
            Console.WriteLine("Press 3 to delete an employee");
            Console.WriteLine("Press 4 to update salary of any employee ");
            Console.WriteLine("Press 5 to add a device");
            Console.WriteLine("Press 6 to delete a device");
            Console.WriteLine("Press 7 to view your devices");
            Console.WriteLine("Press 0 to exit ");
            Console.WriteLine("Enter your choice: ");
            int admin_choice = int.Parse(Console.ReadLine());

            return admin_choice;
        }
        public static void Admin_functionality()
        {
            int returned_choice = -1;
            while (true)
            {
                SystemUI.Interface_of_application();
                returned_choice = Admin_menu();
                if (returned_choice == 1)
                {
                    /*AddAnEmployee();*/
                    Console.WriteLine("add emp");
                }
                else if (returned_choice == 2)
                {
                    viewEmployees();
                }
                else if (returned_choice == 3)
                {
                    /* DeleteEmployee();*/
                    Console.WriteLine("del emp");
                }
                else if (returned_choice == 4)
                {
                    /* UpdateSalaryOfEmployee();*/
                    Console.WriteLine("update salary");
                }
                else if (returned_choice == 5)
                {
                    /* AddAnItem();*/
                    Console.WriteLine("add item");
                }
                else if (returned_choice == 6)
                {
                    DeleteAnItem();
                }
                else if (returned_choice == 7)
                {
                    ViewAllItems();
                }
                /* else if (returned_choice == 8)
                 {
                     Admin_choice_8(item);
                 }*/
                else if (returned_choice == 0)
                {
                    break;
                }
                Console.ReadLine();
            }

        }
        public static void AddAnEmployee()
        {
            string name = PersonUI.getInputForName();
            string password = PersonUI.getInputForPassword();
            string role = "employee";

            int salary;
            Console.WriteLine("Enter the salary of employee: ");
            salary = int.Parse(Console.ReadLine());
            Employee emp = new Employee(name, role, password, salary);
            Employee.AddEmployee(emp);

        }
        public static void DeleteEmployee()
        {

            Console.WriteLine();
            Console.WriteLine("________________Menu 3_________________");
            Person p = PersonUI.getInputForPerson();
            bool check = Person.isUserAlreadyPresent(p.getUserName(), p.getPassword());
            if (check != false)
            {
               /* int index = AdminBL.FindIndex(p.getUserName(), p.getPassword(), p.getUserRole());
                PersonDL.DeleteUser(index);
                PersonDL.Store_to_file();*/
                Console.WriteLine("Succesfully deleted");
            }
            else
            {
                Console.WriteLine("User does not exist");
            }
        }
        public static void viewEmployees()
        {
            foreach (Person person in PersonDL.person)
            {
                if (person.getUserRole() == "employee")
                {
                    Console.WriteLine(person.toString());

                }
            }
        }
        public static void ViewAllItems()
        {
            foreach (Items i in ItemsDL.GetItems())
            {
                Console.WriteLine(i.toString());
            }
        }
        public static void AddAnItem()
        {
            Console.WriteLine("________________Menu 4_________________");
            bool check;
            Items item = ItemsUI.getInputForItem();


            check = Items.is_item_already_exist(item.getItemName());
            if (check == true)
            {
                Console.WriteLine("Your entered item is already present. ");
            }
            else
            {

                ItemsDL.AddItemIntoList(item);
                ItemsDL.Store_data_of_items_to_file();
                Console.WriteLine("Successfully added ");
            }


        }
        public static void UpdateSalaryOfEmployee()
        {
            int salary;
            Person p = PersonUI.getInputForPerson();
            Console.WriteLine("Enter the updated salary: ");
            salary = int.Parse((Console.ReadLine()));

            bool check = Person.isUserAlreadyPresent(p.getUserName(), p.getPassword());
            if (check == false)
            {
           /*     Employee.Update_salary(p.getUserName(), p.getPassword(), p.getUserRole(), salary);
                Console.WriteLine("Successfully updated ");*/
            }
            else
            {
                Console.WriteLine("Can't find your entered employee!");
            }

        }
        public static void DeleteAnItem()
        {
            Console.WriteLine("________________Menu 5_________________");
            string name = "";
            bool check;
            Console.WriteLine("Enter the name of device you want to delete: ");
            name = Console.ReadLine();
            check = Items.is_item_already_exist(name);
            if (check == true)
            {
                int index = Items.FindIndexToDelete(name);
                ItemsDL.RemoveItemIntoList( index);
                ItemsDL.Store_data_of_items_to_file();
                Console.WriteLine("Successfully deleted");
            }
            else
            {
                Console.WriteLine("Device does not exist");
            }

        }
        public static void Admin_choice_8(List<Items> item)
        {
            string item_name = "";
            int updated_stock;
            Console.WriteLine("Enter the name of the device of which you wanted to add stock: ");
            item_name = Console.ReadLine();
            Console.WriteLine("Enter the updated stock: ");
            updated_stock = int.Parse(Console.ReadLine());
            Items i1 = new Items();
            Items.Update_stock(item_name, updated_stock);
            ItemsDL.Store_data_of_items_to_file();
        }
    }
}
