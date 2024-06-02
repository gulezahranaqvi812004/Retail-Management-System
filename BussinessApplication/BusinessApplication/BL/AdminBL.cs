using BusinessApplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    internal class AdminBL : Person
    {
        public AdminBL() { }
        public override string toString()
        {
            return base.toString();
        }

        public AdminBL(string name, string password, string role) : base(name, password, role) { }
        public static int FindIndex(Person per)
        {

            int i = 0;
            foreach (Person p in PersonDL.GetUsers())
            {
                if (p.getUserName().Equals(per.getUserName()) && p.getPassword().EndsWith(per.getPassword()))
                {
                    break;
                }
                i++;
            }

            return i;
        }
   
        public static string Return_role(string name, string password)
        {
            string value_to_be_returned = "";
            foreach (Person p in PersonDL.GetUsers())
            {
                if (p.getUserName() == name && p.getPassword()==password)
                {
                    value_to_be_returned = p.getUserRole();
                   
                }
            }
            return value_to_be_returned;
        }
    }
}
