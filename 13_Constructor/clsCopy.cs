using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsCopy
    {

        int x;
        string mesaj = "Parametre geliyor olay degisiyor.";

        public clsCopy(int i)  //Parametre geliyo mu kontrol etme islemi
        {
            x = i;
            Console.WriteLine($"Parametreli ctor/yapici cagrildi...Parametre degeri : {i}");
        }

        public clsCopy(clsCopy obj) //Sinif uzerine alindi obje adi olarak kullanildi.
        {
            x = obj.x;
        }


        public void Display()
        {
            Console.WriteLine($"X degerinin degeri : {x}");
        }
    }
}
