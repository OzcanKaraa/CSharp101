using _10_AccesModifiers;

internal class Program : clsMovies //Sinif tamamiyle class Movies kendi uzerine alir. Kalitim (Inheritance)  Protected ile
{
    private static void Main(string[] args)
    {
        #region public 
        clsTutorials tutorials = new clsTutorials(); //CLASS ornekleme nesneyi olusturma 
        tutorials.setTutorial(1, "C# Egitimi");
        Console.WriteLine("Egitim Adi : {0}",tutorials.getTutorialName());
        #endregion



        #region private
        clsStudent student = new clsStudent();  //new ile bellege yerlestirme islemi gerceklestirir.
        student.getName();
        #endregion


        #region protected
        clsMovies movies = new clsMovies();  //Degisken olusturma 
        Program program = new Program();    //Program class yeni nesne  yukarida olusturuldu aktive edildi 

        Console.WriteLine($"Movie Name : ,{program.movieName}"); //program ile kalitim oldu.


        #endregion


        Console.ReadKey();
    }
}