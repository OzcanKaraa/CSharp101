internal class Program
{
    private static void Main(string[] args)
    {
        #region SquareCreate

        //Kullanicidan 1 den 10 arasinda deger alinacak/
        //kenarlar * olacak , ortasi bos olacak.
        Console.WriteLine("1 ıle 10 arasında bır deger giriniz..: ");
        int edgeLenght= int.Parse(Console.ReadLine());  // bildimiz converto.toint32 karsiligi 
        if (edgeLenght  >= 1 && edgeLenght <=10 )
        {
            for (int i = 0; i < edgeLenght; i++) //satirlar 
            {
                for (int j = 0; j < edgeLenght; j++) //kolonlar 
                {
                    if ()
                    {

                    }  //Hem satirda hem kolonda en son olanin önündemiyim.
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                }

                Console.WriteLine();
            }
        }

        else
        {
            Console.WriteLine("Hatalı Gırıs");
        }

        Console.ReadKey();

        #endregion
    }
}