/*using BusinessApplication.BL;
using BusinessApplication.DL;
using BusinessApplication.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            *//*PersonDL.LoadDataFromFile();
            ItemsDL.load_data_of_items();
            int choice = 0;
            while (choice != 3)
            {
                choice = SystemUI.Login_page();
                if (choice == 1)
                {
                    PersonUI.SignUpIterface();
                }
                else if (choice == 2)
                {
                    PersonUI.Login_in();
                }
                *//*else if (choice == 3)
                {
                    PersonUI.viewUsers();
                }*//*
                else
                {
                    break;
                }
                Console.ReadLine();
            }*//*
            Console.ReadKey();
        }
    }
}
*/
using BusinessApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInSignUpDesktop("load"));
        }
    }
}