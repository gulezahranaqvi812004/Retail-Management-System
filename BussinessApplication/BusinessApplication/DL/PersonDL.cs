using BusinessApplication.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication.UI;
using System.IO;

namespace BusinessApplication.DL
{
    internal class PersonDL
    {
        public static List<Person> person = new List<Person>();

        public static void AddUserIntoList(Person p)
        {
            person.Add(p);
        }
        public static void DeleteUser(int i)
        {
            person.RemoveAt(i);
        }
        public static void Store_to_file()
        {
            string path = "D:\\Semester2\\OOP\\BakaEid\\BusinessApplication\\Person.txt";
            StreamWriter myFile = new StreamWriter(path, false);
            foreach (Person p in person)
            {
                myFile.WriteLine(p.getUserName() + "," + p.getPassword() + "," + p.getUserRole() + "," + p.getSalary());
            }
            myFile.Flush();
            myFile.Close();
        }
        public static bool LoadDataFromFile()
        {
            string record;
            bool result = false;
            string path = "D:\\Semester2\\OOP\\BakaEid\\BusinessApplication\\Person.txt";
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path, false);
                while ((record = myFile.ReadLine()) != null)
                {
                    if (record != "")
                    {
                        string[] splited = record.Split(',');
                        Person p = new Person(splited[0], splited[1], splited[2]);
                        AddUserIntoList(p);
                    }
                }
                myFile.Close();
                result = true;
            }
            return result;
        }
        public static List<Person> GetUsers()
        {
            return person;
        }
        public static void Update_password(string userName, string newPassword)
        {
            foreach (Person p in person)
            {
                if (p.getUserName() == userName)
                {
                    p.setPassword(newPassword);
                }
            }
        }
        public static void Update_name(string userName, string newName)
        {
            foreach (Person p in person)
            {
                if (p.getUserName() == userName)
                {
                    p.setName(newName);
                }
            }
        }
    }
}
