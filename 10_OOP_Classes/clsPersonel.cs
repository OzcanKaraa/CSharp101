using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Classes
{
    internal class clsPersonel 
    {
        //Degiskenler properties tanımlanması 

        public int PersonelID;
        public string Ad;
        public string Soyad;
        public string Unvan = null; //unvan bos kalmasi icin 
        public int Maas;
        public int IzinGunu;


       
        public void setPersonelBilgileri(string pAd,string pSoyad,int pMaas)
        {
            if (pMaas >= 2500)
            {
            if (pAd.Length > 0 && pSoyad.Length > 0 ) //ad soyad tam girilmesi kontrol edilir.
             { 
                this .Ad = pAd;
                    this.Soyad = pSoyad;
                    this.Maas = pMaas;
                    this.IzinGunu = 14;


                if (pMaas >= 10000 && pMaas <= 140000)
                {
                    this.Unvan = "Kidemli Personel ";
                    this.IzinGunu = 20;
                }

                else if (pMaas > 14001 && pMaas < 15500)
                {
                    this.Unvan = "Kidemli+ Personel ";
                    this.IzinGunu = 24;
                }
                else if (pMaas > 15500)
                {
                    this.Unvan = "Uzman Personel ";
                    this.IzinGunu = 24;
                }
                else
                {
                    this.Unvan = "Junior Personel ";
                }
                }
                else
                {
                    Console.WriteLine("\n Personel olusturulamadı ...");
                }
                {

            }

            }
        }

       

        public string getPersonelBilgileri()
        {
            if (Unvan != null)
            {
                return $"Personel Ad {Ad}\nPersonel Soyad {Soyad}\nUnvan{Unvan}\nMaas:{Maas}\nIzin Gunu :{IzinGunu}günü";
            }
            else
            {
                return "Lutfen personel olusturunuz...";
            }
        }


    }
}
