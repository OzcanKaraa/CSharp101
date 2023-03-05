using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsSubTutorials : clsTutorials    //Kalitim kullandi 
        // Üst sınıf olan clsTutorıalsdan miras aldırttım.  
        //Alt sınıf olan clsSubTutorıals da olmayan bır methodu daha onceden yazılmnıs ama farklı sınıfta durumlarında kullanabılmek ıcın ust sınıf olan clsTutorıalstan mıras aldı.

    {
        public void DersAdiBelirle(string pNewName)
        {
        //  clsSubTutorials clsSubTutorials = new clsSubTutorials();  //Uzerine yaratiyor.
        //clsSubTutorials.renameTutorial(pNewName);

         //   Console.WriteLine(getTutorialName());
         TutorialName = pNewName;
        }
    }
}
