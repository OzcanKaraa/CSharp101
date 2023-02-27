using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Hata oluşturabilecek durum

        //int a = 100;
        //int b = 0; // istenmeyen bazı durumlarda aslında 0 olmayan bu değer 0 lanmış olabilir....

        //Console.WriteLine("{0} / {1} işleminin sonucu = {2} ",a,b,a/b);


        #endregion

        #region Hata avcısı

        //int c = 0;
        //int d = 0; // istenmeyen bazı durumlarda aslında 0 olmayan bu değer 0 lanmış olabilir....

        //try
        //{
        //    Console.WriteLine("{0} / {1} işleminin sonucu = {2} ", c, d, c / d);
        //}
        //catch
        //{
        //    if (c != 0 && d==0)
        //    {
        //        d = c / 100;

        //        Console.WriteLine("D değeri hata oluşturduğundan dolayı güncellenmiş ve {0} değeri atanmıştır...\n {1}/{2} işleminin sonucu = {3} tür ", d, c, d,c/d);
        //    }
        //    else if (c==0 && d!=0)
        //    {
        //        c = d * 10;

        //        Console.WriteLine("C değeri hata oluşturduğundan dolayı güncellenmiş ve {0} değeri atanmıştır...\n {1}/{2} işleminin sonucu = {3} tür ", c, c, d, c / d);
        //    }
        //    else if (c==0 && d==0) 
        //    {
        //        c = 50;
        //        d = 10;

        //        Console.WriteLine("\n {0}/{1} işleminin sonucu = {2} tür ", c, d, c / d);
        //    }

        //}

        #endregion

        #region Hata Metotları

        byte deger;

        try
        {
            Console.Write("Byte türünden bir değer giriniz... : ");
            deger = Convert.ToByte(Console.ReadLine());

        }
        catch (Exception hata)
        {
            Console.WriteLine("Message: {0}\nSource: {1}\nStackTrace: {2}\nTargetSite : {3}", hata.Message, hata.Source, hata.StackTrace, hata.TargetSite);

        }

        #endregion


        #region Başka bir örnek


        int bolunecek, bolen;

        try
        {
            Console.Write("-> Bölünecek Değeri Girin: ");

            bolunecek = Convert.ToInt32(Console.ReadLine());

            Console.Write("-> Bölen Değeri Girin: ");

            bolen = Convert.ToInt32(Console.ReadLine());

            double sonuc = (bolunecek / bolen);

            Console.WriteLine("-> {0} değerinin {1} değerine bölümünün sonucu: {3}", bolunecek, bolen, sonuc);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("\n-> Hata! Sıfıra bölüm işlemi gerçekleştirilemez.\n-> Hata Mesajı: {0}\n", e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("\n-> Hata! Sadece Int32 türünde veri girişi yapabilirsiniz.\n-> Hata Mesajı: {0}\n", e.Message);
        }
        catch (OverflowException e)
        {
            Console.WriteLine("\n-> Hata! Değişgen sınırların aştınız.\n-> Hata Mesajı: {0}\n", e.Message);
        }
        catch (Exception e) // Geri kalan tüm hata durumlarını kapsar
        {
            Console.WriteLine("\n-> Beklenmedik Bir Hata!\n-> Hata Mesajı: {0}\n", e.Message);
        }
        finally
        {
            Console.WriteLine("-> Finally Bloğu Çalışıyor.\n");
        }

        #endregion

        Console.ReadKey();
    }
}