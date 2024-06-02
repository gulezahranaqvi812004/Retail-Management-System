using BusinessApplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    internal class Items
    {
        protected string Item_name;
        protected int Item_price;
        protected int Item_quantity;
        public string toString()
        {
            return Item_name.ToString() + " " + Item_price.ToString() + " " + Item_quantity.ToString();
        }
        public Items() { }
        public Items(string item_collections, int item_price, int item_quantity)
        {
            Item_name = item_collections;
            Item_price = item_price;
            Item_quantity = item_quantity;
        }
        public void setItemName(string name)
        {
            Item_name = name;
        }
        public void setItemPrice(int price)
        {
            Item_price = price;
        }
        public void setItemQuantity(int quantity)
        {
            Item_quantity = quantity;
        }
        public string getItemName()
        {
            return Item_name;
        }
        public int getItemPrice()
        {
            return Item_price;
        }
        public int getItemQuantity()
        {
            return Item_quantity;
        }
        public static bool is_item_already_exist(string device_name)
        {
            bool find = false;
            foreach (Items i in ItemsDL.GetItems())
            {
                if (i.getItemName() == device_name)
                {
                    find = true;
                }
            }
            return find;
        }
        public static void AddNewItem(Items item)
        {
            ItemsDL.AddItemIntoList(item);
        }
        public static int FindIndexToDelete(string Item_collections)
        {
            int index = 0;
            foreach (Items i in ItemsDL.GetItems())
            {
                if (i.getItemName() == Item_collections)
                {
                    return index;
                }
                index++;
            }
            return 0;
        }
        public static void Update_stock(string item_name, int updated_stock)
        {
            foreach (Items i in ItemsDL.GetItems())
            {
                if (i.getItemName() == item_name)
                {
                    i.setItemQuantity(updated_stock);
                }
            }
        }
        public static void cartOption(string i)
        {
            bool exist = is_item_already_exist(i);
            if(exist)
            {
                Purchase_a_device(i);
                int ppr=Find_price(i);
            }
            
        }
        public static Items Check_stock(string name)
        {
           
            foreach (Items i in ItemsDL.GetItems())
            {
                if (i.getItemName() == name && i.getItemQuantity() != 0)
                {
                    return i;
                }
            }

            return null;
        }
        public static int Find_price(string name)
        {
            int price = 0;
            foreach (Items i in ItemsDL.GetItems())
            {
                if (i.getItemName() == name)
                {
                    return i.getItemPrice();
                }
            }
            return price;
        }
        public static void Purchase_a_device(string name)
        {
            foreach(Items i in ItemsDL.GetItems())
            {

                if (i.getItemName()== name && i.getItemQuantity() != 0)
                {
                    i.setItemQuantity(i.getItemQuantity() - 1);
                }
            }
        }
    }
}
