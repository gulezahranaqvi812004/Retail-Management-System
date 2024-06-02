using BusinessApplication.BL;
using BusinessApplication.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessApplication.DL
{
    internal class ItemsDL
    {
        public static List<Items> items = new List<Items>();

        public static void AddItemIntoList(Items item)
        {
            items.Add(item);
            Store_data_of_items_to_file();
        }
        public static void RemoveItemIntoList(int i)
        {
            items.RemoveAt(i);
        }
        public static void Update_stock(string item_name, int updated_stock)
        {
            foreach (Items i in items)
            {
                if (i.getItemName() == item_name)
                {
                    i.setItemQuantity(updated_stock);
                }
            }
        }
        public static List<Items> GetItems() { return items; }
        public void Purchase_a_device(string name)
        {
            foreach (Items i in items)
            {

                if (i.getItemName() == name && i.getItemQuantity() != 0)
                {
                    i.setItemQuantity(i.getItemQuantity() - 1);
                }
            }
        }
        public static bool load_data_of_items()
        {
            string record;
            bool result = false;
            string path = "D:\\Semester2\\OOP\\BakaEid\\BusinessApplication\\masla.txt";
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path, false);
                while ((record = myFile.ReadLine()) != null)
                {
                    if (record != "")
                    {
                        string[] splited = record.Split(',');
                        Items i1 = new Items(splited[0], int.Parse(splited[1]), int.Parse(splited[2]));
                        AddItemIntoList(i1);
                    }
                }
                myFile.Close();
                result = true;
            }
            return result;
        }
        public static void Store_data_of_items_to_file()
        {
            string path = "item.txt";
            StreamWriter myFile = new StreamWriter(path, false);
            foreach (Items i in items)
            {
                myFile.WriteLine(i.getItemName() + "," + i.getItemPrice() + "," + i.getItemQuantity());
            }
            myFile.Flush();
            myFile.Close();
        }
    }
}
