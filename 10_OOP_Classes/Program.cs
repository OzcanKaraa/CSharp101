using _10_OOP_Classes;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Personel ornegi GET Set ile
        /*
         * Bir Personel kayit sistemi CLS Personel
         * Sinif icerisinde bazi ozellikler ad ,soyad, personel no, tckno maasi 
         * personel kaydi olursturmak icin metot Set Personel Data icerisndeki bilgileri guncelleme 
         * bellekte olustu personel bilgileri ekranda gostermek icin cw icin getpersoneldata metot tanimlanarak ekranda gosterilecek,
         * once sinif yazilip islemler baslayacak.
         * 
         */
        /* Console.WriteLine("Unitim Cerebris Communitas Personel Listesi ");*/ //sırket adı yazdı hoca.
                                                                                //Console.WriteLine("----------------------------------------------");


        //Nesne yaratalım.

        /*  clsPersonel1 per1 = new clsPersonel1(); */ //tıpnden yaratılır sınıfından 
                                                       //nesne yaratildi tum nesnelere olusturulur
                                                       //Manuel olarak 


        //tanimlama yapiliyor.

        //per1.PersonelID = 1;
        //per1.Ad = "Ozcan";
        //per1.Soyad = "Kara";
        //per1.TCKNo = "12345678901";
        //per1.Bolum = "IT";
        //per1.Maas = 1;

        //Set ile
        //per1.setPersonelData(1, "Ozcan ", "Kara ", "12345678901", "IT", 1);
        //per1.getPersonelData();

        //Set personel icin



        //Ikinci nesne olusturma
        //clsPersonel1 per2 = new clsPersonel1();
        //per2.PersonelID = 2;
        //per2.Ad = "Berfın";
        //per2.Soyad = "Gokalp";
        //per2.TCKNo = "25874136971";
        //per2.Bolum = "Doktor";
        //per2.Maas = 2;

        //Set ile
        //per2.setPersonelData(2, "Berfin ", "Kara ", "12345678901", "IT", 2);
        //per2.getPersonelData();



        //Ikinci nesne olusturma
        //clsPersonel1 per3 = new clsPersonel1();
        //per3.PersonelID = 3;
        //per3.Ad = "Buket";
        //per3.Soyad = "Su";
        //per3.TCKNo = "16489753142";
        //per3.Bolum = "Psikolog";
        //per3.Maas = 3;
        //Set ile
        //per3.setPersonelData(2, "Berfin ", "Kara ", "12345678901", "IT", 2);
        //per3.getPersonelData();

        #endregion
        #region
        // Ogrenci Ornegi

        /* bir class yaratilacak ismi ogrenci olsun 
         tutulacak bilgiler properties ogr_no ,ad ,soyad,ders,ders_notu
          2 metot olacak 
        bir tanesi ogrencini verilerini ekrana doksun 
        bir taneside ogrencinin aldigi nota gore 50 kontrol deger  ..gecti kaldi 
        */



        #endregion


        //Ogrencı Ornegı

        #region
        clsOgrenci ogr1 = new clsOgrenci();

        ogr1.OgrNo = 1;
        ogr1.OgrAdSoyad ="Ozcan Kara" ;
        ogr1.DersNot = 15;
        ogr1.Ders = " Matematik ";

        ogr1.OgrenciYaz();
        ogr1.NotKontrol(ogr1.DersNot);


        //2.ogrenci 

        clsOgrenci ogr2 = new clsOgrenci();

        ogr2.OgrNo = 2;
        ogr2.OgrAdSoyad = "Elif";
        ogr2.DersNot = 50;
        ogr2.Ders = " Turkce";

        ogr2.OgrenciYaz();
        ogr2.NotKontrol(ogr2.DersNot);
        #endregion


        #region  Personel ornegi 2
        /*

        Bu ornegin amacı class yapısının buradan source dosyasından farklı bir yerde tanımlanması ve kullanılmasu üzerine
       Bır sirket 
        5 elaman var Ad soyad unvan maas ve izin gunu 
        //Bir tane metod olacak bu metodda oncelikle ad soyad bilgisinin dolu oldugu durumda maasinin miktarina gore personelin  kac gun izin hakki olacagi belirlenecektir.
        Kriterler : 
        
        Maas 2500 -10000 duz personel  izin gunu 14 ,
        maas 10 000 - 14 000 arasindaysa kidemli personel maas  ve izin gunu 20 gun olacak , 
        14 001-15 500 kina arasindaysa kidemli+ izi gunu 24 gun olacak personel sinirlar dahil 
        Maas 15 500 ustundeyse uzman personel ve izin gunu 30 gun 
        olarak cikis veren sekilde olacak.
        Not : Personelin maas bilgisinin belirlenmesi bilgisayari birakacak ...random .. aralik 1000-2000 araligi olsun.
        */


        //Nesneleri olusturduk . 
        clsPersonel ozcan = new clsPersonel();
        clsPersonel ertugrul = new clsPersonel();
        clsPersonel helin = new clsPersonel();
        clsPersonel berna = new clsPersonel();
        clsPersonel  nergis = new clsPersonel();
        clsPersonel snur = new clsPersonel();
        clsPersonel mferit = new clsPersonel();
        clsPersonel ozdenur= new clsPersonel();
        clsPersonel aleyna = new clsPersonel();
        clsPersonel ilker = new clsPersonel(); 
        clsPersonel busra = new clsPersonel();
        clsPersonel mdogan = new clsPersonel();
        clsPersonel umit = new clsPersonel();
        clsPersonel nesibe = new clsPersonel();
        clsPersonel burak = new clsPersonel();

        //aBilgi doldurulmasi 
        int maasilk = 1000;
        int maasson = 20000;


        ozcan.setPersonelBilgileri("Özcan", "KARA", new Random().Next(maasilk, maasson));
        ertugrul.setPersonelBilgileri("Ertuğrul", "DAĞLI", new Random().Next(maasilk, maasson));
        helin.setPersonelBilgileri("Helin", "AYDIN", new Random().Next(maasilk, maasson));
        berna.setPersonelBilgileri("Berna", "ELKOVAN", new Random().Next(maasilk, maasson));
        nergis.setPersonelBilgileri("Nergis", "KETENCİ", new Random().Next(maasilk, maasson));
        snur.setPersonelBilgileri("Saadet Nur", "KARAKAŞ", new Random().Next(maasilk, maasson));
        mferit.setPersonelBilgileri("Muhammet Ferit", "ŞİMŞEK", new Random().Next(maasilk, maasson));
        nesibe.setPersonelBilgileri("Nesibe", "KOSANOĞLU", new Random().Next(maasilk, maasson));
        ozdenur.setPersonelBilgileri("Özdenur", "KOYUNCU", new Random().Next(maasilk, maasson));
        aleyna.setPersonelBilgileri("Aleyna", "ÖZ", new Random().Next(maasilk, maasson));
        ilker.setPersonelBilgileri("İlker", "KAPLAN", new Random().Next(maasilk, maasson));
        busra.setPersonelBilgileri("Büşra", "KÖSE", new Random().Next(maasilk, maasson));
        burak.setPersonelBilgileri("Burak", "ACAR", new Random().Next(maasilk, maasson));
        mdogan.setPersonelBilgileri("Mehmet Doğan", "ERBAY", new Random().Next(maasilk, maasson));
        umit.setPersonelBilgileri("Ümit", "KARAÇİVİ", new Random().Next(maasilk, maasson));

        //Bilgleri okuma 


        Console.WriteLine(ozcan.getPersonelBilgileri());
        Console.WriteLine(ertugrul.getPersonelBilgileri());
        Console.WriteLine(helin.getPersonelBilgileri());
        Console.WriteLine(berna.getPersonelBilgileri());
        Console.WriteLine(nergis.getPersonelBilgileri());
        Console.WriteLine(snur.getPersonelBilgileri());
        Console.WriteLine(mferit.getPersonelBilgileri());
        Console.WriteLine(nesibe.getPersonelBilgileri());
        Console.WriteLine(ozdenur.getPersonelBilgileri());
        Console.WriteLine(aleyna.getPersonelBilgileri());
        Console.WriteLine(ilker.getPersonelBilgileri());
        Console.WriteLine(busra.getPersonelBilgileri());
        Console.WriteLine(burak.getPersonelBilgileri());
        Console.WriteLine(mdogan.getPersonelBilgileri());
        Console.WriteLine(umit.getPersonelBilgileri());





        #endregion
        Console.ReadKey();
    }
}



    class clsPersonel1
    {

        //Simdi sira geldi sinifimin ozelliklerini yazmaya properties


        // properties 
        //public int PersonelID;
        //public String Ad;
        //public string Soyad;
        //public string TCKNo;
        //public string Bolum;
        //public int Maas;


        public void setPersonelData(int pID, string pAD,string pSoyad,string pTCKNo,string pBolum,int pMaas)  //main uzerinde cagirmak icin parametreler tanimlama 
        {
            //Bu metot class nesne bilgilerini  set etmek icin kullanilacak.
            //Tek metot cagirarak tek seferde 
            //PersonelID = pID;
            //Ad = pAD;
            //Soyad = pSoyad;
            //TCKNo = pTCKNo;
            //Bolum = pBolum;
            //Maas = pMaas;


        }
        //Gelen bilgileri okuyacak.
        public void getPersonelData()
        {

            //$ ile degiskenleri sira ile koyulabilir
            //Get ıle bılgılerı okuma 
            //Console.WriteLine($"\n\nPersonel No: {PersonelID}\nAdı ve Soyadı : {Ad} {Soyad}\nTCKMo : {TCKNo}\nBolum: {Bolum}\nMaaş : {Maas}PNG Kina ");

            //Set etmek ayni satirda ayni kodda yazma 
        }

    }


class clsOgrenci
{
    public int OgrNo;
    public string OgrAdSoyad;
    public string Ders;
    public int DersNot;

    public void OgrenciYaz()
    {
        Console.WriteLine($"\n \n Ogrencı Ad Soyad  {OgrAdSoyad}\nOgrenci No : {OgrNo}\nDers : {Ders}\nDers Notu : {DersNot}");
    }

    public void NotKontrol(int pNot)
    {
        if (pNot<50)
        {
            Console.WriteLine("Dersten geçemediniz");
        }
        else
        {
            Console.WriteLine("Dersten geçtiniz");
        }
    }


    //class PersBilgileri
    //{
        
    //    public string PersAdSoyad;
    //    public string unvan;
    //    public int maas;
    //    public int izingunu;
    //}
    //public void PersonelYaz()
    //{
    //    Console.WriteLine($"\n \n Personel Ad Soyad : {PersAdSoyad}\nUnvan: {unvan}\nMaas Günü : {maas}\nIzın Gunu : {izingunu}");
    //}

    //public void MaasKontrol(int maas)
    //{
    //    if (maas >2500  || maas<10000)
    //    {
    //        Console.WriteLine("Izin gunu 14 gundur");
    //    }
    //    else if (maas >1001|| maas < 14000)
    //    {
    //        Console.WriteLine("Izin gunu 20 gundur");
    //    }
    //    else if (maas >= 1401 || maas <=15500)
    //    {
    //        Console.WriteLine("Izin gunu 24 gundur");
    //    }
    //     else if ( maas < 15550)
    //    {
    //        Console.WriteLine("Izin gunu 30 gundur");
    //    }

    //    else if (maas > 2500)
    //    {
    //        Console.WriteLine("Izin gunu 30 gundur");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Tekrar deneyiniz ...");
    //    }

    }







    