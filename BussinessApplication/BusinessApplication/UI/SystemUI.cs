using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.UI
{
    internal class SystemUI
    {
        public static void Header()
        {
            Console.WriteLine("             *****************************************                 ");
            Console.WriteLine("             *^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*                 ");
            Console.WriteLine("             *^                                     ^*                 ");
            Console.WriteLine("             *^          MOBILE SHOP                ^*                 ");
            Console.WriteLine("             *^        Management System            ^*                 ");
            Console.WriteLine("             *^                                     ^*                 ");
            Console.WriteLine("             *^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*                 ");
            Console.WriteLine("             *****************************************                 ");
        }
        public static int Login_page()
        {
            Interface_of_application();
            int login_choice;
            Console.WriteLine("Press 1 for sign up");
            Console.WriteLine("Press 2 for sign in");
            Console.WriteLine("Press 0 to exit");
            Console.WriteLine("Enter your choice: ");
            login_choice = int.Parse(Console.ReadLine());
            return login_choice;
        }
        public static void Interface_of_application()
        {
            Console.Clear();
            Header();
        }
    }
}
