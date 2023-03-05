using _12_Polymorfism;

internal class Program
{
    private static void Main(string[] args)
    {
        clsTutorials tutorials = new clsTutorials();

        tutorials.setTutorial(1, "csharp"); //Birinci formunu kullaniyoruz.
        Console.WriteLine(tutorials.getTutorialName()); //tutorial adi getirilir.


        tutorials.setTutorial("Sql Server : "); // 2 .formu
        Console.WriteLine(tutorials.getTutorialName());

        tutorials.setTutorial(1, "Php ","Php egitimi "); //3. formunu kullaniyoruz.
        Console.WriteLine(tutorials.getTutorialName()); //tutorial adi getirilir.





        Console.ReadKey();
    }
}