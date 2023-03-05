using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorfism
{

    //Public  KALITIM UST SINIF TUtoriLA 
    internal class clsTutorials
    {
       protected int TutorialID;
        protected string TutorialName;
        protected string TutorialDescription;
              
        public void setTutorial(int pID,string pTutorialName)
        {
          this.TutorialID = pID;
          this.TutorialName = pTutorialName;
        }

        public void setTutorial( string pTutorialName) // Ismi guncelleme
        {
            this.TutorialName = pTutorialName;
        }

        public void setTutorial(int pID, string pTutorialName,string pDesc)
        {
            this.TutorialID = pID;
            this.TutorialName = pTutorialName;
            this.TutorialDescription = pDesc;
        }

        public string getTutorialName()
        {
            return this.TutorialName + " " + this.TutorialID;
        }





















    }
}
