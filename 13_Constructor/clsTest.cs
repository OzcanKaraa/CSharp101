using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsTest
    {
      public  int i; //default = 0
       public string s; // default = "";
       public  bool b; //default = false;

        //Kural: class ismiyle ayni olacak ayni olacak bir metot .
        // ctor construct class devreye girdiginde otomatik calisan bir metot.
        //degisk durumlarda initial islemler yapmak icin kullanilir.
        //parametreli de kullanimi olabilir.

        public clsTest(int i, string s, bool b) //CTOR
        {
            i = 5;
            s = "Hello World";
            b = true; 
        }
    }
}