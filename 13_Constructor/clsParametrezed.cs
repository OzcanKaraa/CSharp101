using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsParametrezed
    {

        int x;
        public clsParametrezed(int i)  //Parametre geliyo mu kontrol etme islemi
        {
            x = i;
            Console.WriteLine($"Parametreli ctor/yapici cagrildi...Parametre degeri : {i}");
        }

        public void Display()
        {
            Console.WriteLine($"X degerinin degeri : {x}");
        }
    }
}
