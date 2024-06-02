using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication.BL
{
    internal class Customer : Person
    {
        public Customer(string name, string password, string role) : base(name, role, password)
        {

        }
        public override string toString()
        {
            return base.toString();
        }


    }
}
