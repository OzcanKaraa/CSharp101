using _14_Encapsulletion;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Normal Durum (Public)


        //clsBank bank = new clsBank();
        //bank.AccountNumber = 123456789;
        //bank.Name = "Santander Bank";
        //bank.Balance = 500;


        //bank.GetBalance();
        //bank.WithrawAccount();

        #endregion

        #region getter / setter 
        //clsBank bangs = new clsBank();
        //bangs.SetBalanceCaps(500);
        //Console.WriteLine($"Balance miktari : {bangs.GetBalanceCaps()}");  //Get etmek icin
        #endregion

        #region   Eger sınıf tasarlarken Kapsülleme (Encapsulation) prensibine uymazsak ne olur ??

        /*// Sınıfı tasarlarken C# kapsülleme prensibini takip etmezsek, kullanıcı tarafından verilen verileri iş gereksinimlerimize
        // göre doğrulayamayız ve gelecekteki değişiklikleri ele almanın bu durumda çok zor olduğu açıktır.
        // Bunu bir örnekle anlayalım. İlk proje gereksiniminde, müşterinin uygulamanın negatif sayının depolanmasına izin vermemesi
        // gerektiğini belirtmediğini varsayalım. Bu nedenle, değişkene sınıf dışından doğrudan erişim sağlarız ve şimdi kullanıcı
        // aşağıdaki örnekte gösterildiği gibi herhangi bir değeri depolayabilir. Burada, miktar değişkenine doğrudan clsBank sınıfının
        // dışından eriştiğimizi ve hem pozitif hem de negatif değerler ayarladığımızı görebilirsiniz.
         * */




        //clsBank bank2 = new clsBank();
        //// Pozitif degerle Amaount degerini guncelleme islemi 
        //bank2.Amount = 100;
        //Console.WriteLine($"Bankadaki miktar : {bank2.Amount} Png Kina");
        //bank2.Amount = -150; // Aslinda istenmeyen deger 
        //Console.WriteLine($"Bankadaki miktar : {bank2.Amount} Png Kina");

        //Hata yakalama bolumu 


        //try
        //{

        //    int deger;

        //    clsBank bank3 = new clsBank();

        //    Console.WriteLine("Lütfen degeri giriniz :");
        //     deger = Convert.ToInt32(Console.ReadLine());
        //    bank3.SetAmaount(deger);
        //    Console.WriteLine($"\n\nDüzgün Durum\n\nBankadaki miktar : {bank3.GetAmaount} Png Kina");

        //    Console.WriteLine("Lütfen degeri giriniz :");
        //    deger = Convert.ToInt32(Console.ReadLine());

        //    bank3.SetAmaount(deger);
        //    Console.WriteLine($"Bankadaki miktar : {bank3.GetAmaount} Png Kina");


        //bank3.SetAmaount(2000);
        //Console.WriteLine($"\n\nDüzgün Durum\n\nBankadaki miktar : {bank3.GetAmaount} Png Kina");

        //bank3.SetAmaount(-1500);
        //Console.WriteLine($"Bankadaki miktar : {bank3.GetAmaount} Png Kina");
        //}
        //catch (Exception hata )
        //{
        //    Console.WriteLine(hata.Message);
        //}
        #endregion

        #region Properties / Ozellikler
        /* 
          Özellikler C#'da tanıtılan yeni bir dil özelliğidir. C# 'daki özellikler, değerleri okuyarak ve yazarak bir sınıfın
         bir alanının veya değişkeninin korunmasına yardımcı olur. İlk yaklaşım, yani ayarlayıcı ve alıcının kendisi iyidir,
         ancak C# 'daki veri kapsülleme özelliklerle çok daha pürüzsüz olarak gerçekleştirilebilir.*/


        try
        {
            clsBank bank4 = new clsBank();
          //  We cannot access the _Amount Variable directly
         //           bank._Amount = 50; //Compile Time Error
            Console.WriteLine(bank4._Amount); //Compile Time Error
           // Setting Positive Value using public Amount Property
                    bank4.Amount = 10;

            //Setting the Value using public Amount Property
                    Console.WriteLine(bank4.Amount);

          //  Setting Negative Value
                   bank4.Amount = -150;
            Console.WriteLine(bank4.Amount);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            clsBank bank5 = new clsBank();
            bank5._Amount2 = 100;
            Console.WriteLine($"Değer : {bank5._Amount2}"); //Direk degiskenin properties degerini yazilabilir.Kendisi anlyor set gidecegini
            bank5._Amount2 = -5000;
            Console.WriteLine($"Değer : {bank5._Amount2}"); //Direk degiskenin properties degerini yazilabilir.Kendisi anlyor get gidecegini
        }
        catch 
        {
            Console.WriteLine("Lütfen pozitif sayı girin lutfen");
            throw;
        }
 
    #endregion


    }
}