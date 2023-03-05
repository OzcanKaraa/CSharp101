using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccesModifiers
{
    //Private
    internal class clsStudent
    {
        private string name = "Ozcan"; //private -> public
        public void getName()
        {
            Console.WriteLine("Ogeencini  Adi : {0} ",this.name);
        }
    }
}