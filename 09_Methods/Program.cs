internal class Program
{
    private static void Main(string[] args)
    {
        //Dikdortgen alanini hesaplayan methodun 4 farkli seklini incelenmesi.


        #region 1.Geriye deger dondurmeyen ve parametre almayan 

        // Hesapla();

        #endregion


        #region 2.Geriye deger döndürmeyen ve parametre olan 

        //kullanıcı girişi alma burada ...
        //hesap ve ekrana yazma hazırlanacak Hesapla isimli metotda.
        //Dolayısıyla bu metot parametre alan bir metot olacak.. 

        //önce metot yazılabılır.

        //Console.WriteLine("Kısa Kenar : ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Uzun  Kenar : ");
        //int uk = Convert.ToInt32(Console.ReadLine());

        //Hesapla(uk, kk); //Hesapla isimli metoda parametre gonderili

        #endregion


        #region 3.Geriye deger döndüren ve parametre almayan 
        //int sonuc = HesaplaPrmsiz();    //sonuc = alan oldu  degisken tanimla fonksiyon cagir .
        //Console.WriteLine("Alan = {0}", sonuc ); 
        #endregion


        #region 4.Geriye deger donduren ve parametre alan method
        //Console.WriteLine("Kısa Kenar : ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Uzun  Kenar : ");
        //int uk = Convert.ToInt32(Console.ReadLine());
        ////int sonuc1  = HesaplaPrmli(kk, uk);
        //Console.WriteLine("Alan = {0}", HesaplaPrmli(kk, uk));

        #endregion


        #region
        //Uygun metot yapisi kullanarak 4 islemi gerceklestiriniz 
        // 4 islem birden fazla metot tanimlayabilirsiniz.

        //Console.WriteLine("Lutfen 1.sayinizi giriniz ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Lutfen 2.sayinizi giriniz ");
        //int sayi2 = Convert.ToInt32(Console.ReadLine());

        #endregion


        #region Metotlarda Aşırı yükleme (method overloading)

        //Console.WriteLine("2 li toplama : {0) ", toplamaIslemi(45,45) + "\n");
        //Console.WriteLine("3 lu toplama : {0) ", toplamaIslemi(45, 45,78) + "\n");
        // Console.WriteLine("4 lu  toplama  : {0) ", toplamaIslemi(45,45,90,102) + "\n");

        #endregion

      

        Console.ReadKey();
    }

    #region Methodlar 
    //void ile deger doncurmeyen 
    private static void Hesapla()
    {
        //Console.WriteLine("Kısa Kenar : ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Uzun  Kenar : ");
        //int uk = Convert.ToInt32(Console.ReadLine());

        //int alan = Convert.ToInt32(kk * uk);
        //Console.WriteLine("Alan = {0} ",alan );


    }


    private static void Hesapla(int kisa, int uzun)
    {
        //int alan = Convert.ToInt32(kisa * uzun);
        //Console.WriteLine("Alan = {0} ", alan);

    }

    private static int HesaplaPrmsiz()
    {
        //Geriye deger donduren metotlar mutlaka return tanımı olmalıdır.

        //Console.WriteLine("Kısa Kenar : ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Uzun  Kenar : ");
        //int uk = Convert.ToInt32(Console.ReadLine());
        //int alan = uk * kk;
        //return alan; //Çağrıldıgı yere döndürülür.Geri dondurulen bilgi/veri
    }

    private static int HesaplaPrmli(int kisa, int uzun)
    {
        int alan;

        return kisa * uzun;

    }


    private static int toplamaIslemi (int a , int b)
    {
        return a + b;
    }

    private static int toplamaIslemi(int a, int b,int c)
    {
        return a + b + c ;
    }


    private static int toplamaIslemi(int a, int b,int c , int d )
    {
        return a + b + c + d  ;
    }

    #endregion


}

