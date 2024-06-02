using BusinessApplication.BL;
using BusinessApplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.UI
{
    internal class ItemsUI
    {
        public static Items getInputForItem()
        {
            Console.WriteLine("Enter name of device");
            string name=Console.ReadLine();
            Console.WriteLine("Enter price of device");
            int price=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity of the device");
            int quantity=int.Parse(Console.ReadLine());
            Items items = new Items(name,price,quantity);
            return items;

        }
        public static int View_price(string name)
        {
            foreach (Items i in ItemsDL.GetItems())
            {
                if (i.getItemName().Equals(name))
                {
                    return i.getItemPrice();
                }
            }
            return 0;
        }
    }
}
