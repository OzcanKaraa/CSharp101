using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulletion
{
    internal class clsBank
    {
        #region Normal Durum
        public long AccountNumber; //Hesap No
        public string Name;
        public int Balance; //Miktar
        public void GetBalance()
        {

        }

        public void WithrawAccount()
        {

        }

        public void Deposit()
        {

        }
        #endregion


        #region getter / setter 
        /*private double balance;*/ // yani burada dışarıya kapalı bir değişgen tanımı var

        // Set (setter) Get ( Getter) metodlarinin tanimlanmasi 
        // Public getter metod bu metot balance degiskeninde tutulan degeri almak icin 


        //public  double  GetBalanceCaps()
        //{
        //    // burada farkli islemler var.
        //    return balance;

        //}
        //Public setter method 
        // bu metot balance degiskeninizde tutulan deger almak degistirmek icin degistirmek /guncelemek / update icin.

        //public void  SetBalanceCaps(double balance)
        //{
        //        this.balance = balance;  // This -> Yonlendirmek icin kullanilir.
        //}
        //set metodu deger degistirecegi icin deger almasi gerekiyor
        //void geriye deger dondurmeyen metod girecek bitirecek isi sadece 



        #endregion

        #region Eğer sınıfı tasarlarken Kapsülleme(encapsulation) prensibine uymazsak ne olur?
        /* 
        Daha sonra, gelecekte, müşteri uygulamanın negatif bir değere izin vermemesini istiyor.Ardından, miktar değişkeninde
        saklamadan önce kullanıcı tarafından verilen değerleri doğrulamalıyız.Bu nedenle, kapsülleme ilkesini aşağıdaki
        gibi izleyerek uygulamayı geliştirmemiz gerekir:
         */


        public int Amount;
        public int GetAmaount() //Get metod
         {
            return Amount;
        }
        public void SetAmaount(int Amount)
        {
            if (Amount>0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Lütfen Pozitif Sayı girin ...");   //Hata cikar ise hata yarat ve firlat.
            }
        }

        #region  Properties/değişgenlere de uygulanabilir...
       /* Özellikler C#'da tanıtılan yeni bir dil özelliğidir. C# 'daki özellikler, değerleri okuyarak ve yazarak bir sınıfın
         bir alanının veya değişkeninin korunmasına yardımcı olur. İlk yaklaşım, yani ayarlayıcı ve alıcının kendisi iyidir,
         ancak C# 'daki veri kapsülleme özelliklerle çok daha pürüzsüz olarak gerçekleştirilebilir.*/

        #endregion
        private int _Amount1;

        public int _Amount
        {
            get
            {
                return _Amount1;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Lütfen poziitif değer giriniz : ");
                }
                else
                {
                    _Amount1 = value;
                }
            }
        }


        public int _Amount2 { get; set; }  // en sade - kontrolsuz felan kullanım

        #endregion



    }
}
