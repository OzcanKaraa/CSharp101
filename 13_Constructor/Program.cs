    using _13_Constructor;

    internal class Program
    {
        private static void Main(string[] args)
        {

        #region
        //clsTest test = new clsTest();
        //Console.WriteLine($"i degeri {test.i} - s degeri {test.s} - b degeri {test.b} ");
        #endregion

        #region Parametreli Ctor
        /*// Nesneyi kullanıcı tarafından verilen değerlerle dinamik olarak başlatmak istiyorsak veya bir sınıfın her bir örneğini
        // farklı bir değerler kümesiyle başlatmak istiyorsak, C#'ta Parameterized Constructor'ı kullanmamız gerekir.
        // Bu oluşturucular yalnızca programcılar tarafından tanımlanır. Yani, basit bir ifadeyle, geliştirici tarafından verilen
        // parametrelere sahip kurucu C#'ta Parametreli Yapıcı olarak tanımlanır.
        //
        // Yararı Nedir?
        // 
        // Parametreli bir kurucunun yardımıyla, sınıfın her bir örneğini farklı bir değerler kümesiyle başlatabiliriz.
        // Bu, parametreli yapıcı kullanarak, sınıfta oluşturulan farklı örneklerde farklı bir değer kümesi depolayabileceğimiz
        // anlamına gelir. Yani her nesneyi farklı değerlerle başlatabilme imkanı vermesidir.
         * */
        /*
         * 
        #endregion
      
        /*
        #region  Default Parametresiz 
        
        I/ Bu kurucular, bir programca tarafandan açakça tanamtanabitir veya sanaf altanda açik(explicitly) bir kurucu olmamasa nedeniyle // örtük(implicit) olarak tanimlanacaktir.
        // Boylece, Varsayzlan veya Parametresiz Olusturucular yine iki tipte
        sinaflandaralar.
        // 1.System-Defined Default Constructor
        // 2.User - Defined Default Constructor
        // Eger programamazda açakça herhangi bir kurucu tanamlanmamassak, varsayalan olarak derleyici derleme sirasanda
        // bir kurucu saglayacaktar. Bu yapacaya "varsayalan (default) kurucu" denir ve
        varsayzlan kurucu parametresizdir.
        // Varsayatan kurucu-yapact, veri yeterine (statik olmayan degiskenter)
        // Varsayatan kurucu-yapact, veri yeterine (statik olmayan degiskenter)    
        varsayilan degerler atayacaktar.
        // Bu olusturucu sisten tarafandan olusturuldugundan buna sistem tanaml1
        varsayilan olusturucu da denir.
        #endregion
        */
        #endregion

        #region 
        //clsEmployee empl = new clsEmployee(); //Kullanici tanimli ctor constract ornegi 

        //clsEmployee empl2 = new clsEmployee();
        //empl.DisplayEmployee();
        //empl2.DisplayEmployee();

        #endregion


        #region Parametreli Ctor 
        //clsParametrezed prm1 = new clsParametrezed(10);
        //prm1.Display();

        //clsParametrezed prm2 = new clsParametrezed(20);
        //prm2.Display();

        //clsParametrezed prm3 = new clsParametrezed(30);
        //prm2.Display();
        #endregion


        #region Copy Ctor Construtor
        //Ayni degerlere sahip birden fazla ornek/nesne olusturulmasi istendigi durumlarda kullanilmalidir.
        //Bu durumda copy ctor yapicisi ayni sinifi uzerine parametre olarak alir.
        #endregion



        clsCopy obj1 = new clsCopy(10);
         obj1.Display();

        clsCopy obj2 = new clsCopy(obj1);
        obj2.Display();
        

        Console.ReadKey();


    }


    }