using BusinessApplication.BL;
using BusinessApplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.UI
{
    internal class CustomerUI
    {
        public static int Customer_menu()
        {
            int choice;
            Console.WriteLine("Press 1 to view mneu ");
            Console.WriteLine("Press 2 to check the availability of your desired device");
            Console.WriteLine("Press 3 to purchase phone");
            Console.WriteLine("Press 4 to change your pin code");
            Console.WriteLine("Press 5 to change your name");
            Console.WriteLine("Press 6 to add anything to your wish list");
            Console.WriteLine("Press 7 to see your wish list");
            Console.WriteLine("Press 8 to give feedback ");
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void Customer_functionality()
        {
            int customer_choice;


            while (true)
            {
                SystemUI.Interface_of_application();
                customer_choice = Customer_menu();
                if (customer_choice == 1)
                {
                    ViewAllItems();
                }
                else if (customer_choice == 2)
                {
                    CheckAvailability();
                }
                else if (customer_choice == 3)
                {
                    PurchaseDevice();
                }
                else if (customer_choice == 4)
                {
                    UpdatePassword();
                }
                else if (customer_choice == 5)
                {
                    UpdateName();
                }
                else if (customer_choice == 0)
                {
                    break;

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
        public static void CheckAvailability()
        {
            string name = "";
            bool is_found;
            Items i1 = new Items();
            Console.WriteLine("Enter the name of the device you wanted to purchase: ");
            name = Console.ReadLine();
            is_found = Items.is_item_already_exist(name);
            if (is_found == true)
            {
                Console.WriteLine("Your desired device is available! ");
            }
            else
            {
                Console.WriteLine("Sorry for inconvinience your desired device is not available! ");
            }
        }
        public static void PurchaseDevice()
        {

            char confirm;
            string name;
            int price;
            bool is_found;

            Console.WriteLine("Enter the name of the device you wanted to purchase: ");
            name = Console.ReadLine();
            is_found = Items.is_item_already_exist(name);
            Items i = Items.Check_stock(name);
            if (is_found == true)
            {
                if (i != null)
                {
                    price = Items.Find_price(name);
                    Console.WriteLine("Price of your desired device is: {0} , price ");
                    Console.WriteLine("Press y to confirm your choice and 'n' to cancel it: ");
                    confirm = char.Parse(Console.ReadLine());
                    if (confirm == 'y')
                    {
                        Items.Purchase_a_device(name);
                        ItemsDL.Store_data_of_items_to_file();
                        Console.WriteLine("Thank you for purchasing!");
                    }
                }
                else
                {
                    int index = Items.FindIndexToDelete(name);
                    ItemsDL.RemoveItemIntoList(index);
                    ItemsDL.Store_data_of_items_to_file();
                    Console.WriteLine("Out of stock");
                }
            }
            else
            {
                Console.WriteLine("You have entered a wrong device!");
            }
        }
        public static void UpdatePassword()
        {
            Person p = PersonUI.getInputForPerson();
            bool isfound = Person.isUserAlreadyPresent(p.getUserName(), p.getPassword());
            if (isfound == true)
            {
                Console.WriteLine("You have entered wrong credentials! ");
            }
            else
            {
                string updatedPassword = PersonUI.getInputForPassword();
                PersonDL.Update_password(p.getUserName(), updatedPassword);
                PersonDL.Store_to_file();
            }

        }
        public static void UpdateName()
        {


            Person p = PersonUI.getInputForPerson();
            bool isfound = Person.isUserAlreadyPresent(p.getUserName(), p.getPassword());
            if (isfound == true)
            {
                Console.WriteLine("You have entered wrong credentials! ");
            }
            else
            {
                Console.WriteLine("Enter your new name: ");
                string newName = Console.ReadLine();
                PersonDL.Update_name(p.getUserName(), newName);
                PersonDL.Store_to_file() ;
            }
        }


    }
}
