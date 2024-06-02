using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication.DL;
namespace BusinessApplication.BL
{
    internal class Employee : Person
    {
        protected double salary;
        public override string toString()
        {
            return base.toString()+" "+salary.ToString();
        }
        public override string getUserName()
        {
            return base.getUserName();
        }
        public override string getUserRole()
        {
            return base.getUserRole();
        }
        public override string getPassword()
        {
            return base.getPassword();
        }
        public override double getSalary()
        {
            return salary;
        }
        public override void setSalary(double salary)
        {
            this.salary = salary;
        }
        public Employee(double salary)
        {
            this.salary = salary;
        }
        public Employee(string name,  string password, string role, double salary) : base(name, password,role)
        {
            this.salary = salary;
        }
        public static void AddEmployee(Person p)
        {
            PersonDL.AddUserIntoList(p);
            PersonDL.Store_to_file();
        }

        public static void Update_salary(Employee e,int i)
        {
            PersonDL.person.Insert(i, e);
        }

    }

}
