using _11_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {

        clsSubTutorials altsinif = new clsSubTutorials(); //Alt sınıftan turetme
        altsinif.DersAdiBelirle(".Net Tutporial from Linkedin .."); //Bu metod alt sinifta 
        Console.WriteLine(altsinif.getTutorialName());

        //altsiniftan ust sinifin bir metodunu cagirilabiliyor.
        //12.satira geldigimde ekrana bi sey yazmak icin gettutorialName metodunu cagiriyorum aslinda bu metod ust sinifta.
        //Alt sinifin sanki bir metoduymus gibi cagirilabilir. Kalitim Miras
        //
        Console.ReadKey();
    }
}