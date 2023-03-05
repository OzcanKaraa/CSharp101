using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsEmployee
    {
        public int Id, Age;
        public string Address, Name;
        public bool isActive;
        public clsEmployee()  // User = defined Constructor 
        {
            Id = 100;
            Age = 23;
            Address = "Istanbul";
            Name = "Ozcan";
            isActive = true;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID : {Id}");
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Employee Age : {Age}");
            Console.WriteLine($"Employee Address: {Address}");
            Console.WriteLine($"Employee Actıve : {isActive}\n\n");

        }
    }
}
