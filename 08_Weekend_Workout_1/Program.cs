internal class Program
{
    private static void Main(string[] args)
    {
      

        #region SalaryCalculation
        float vf_monthlySalary = 8500f;
        int year = 1;
        Console.WriteLine("Baslangic maaşını : {0} PNG Kina`dir...",String.Format("{0:###,###}",vf_monthlySalary));

        for (year = 2; year <=5; year++)
        {
            vf_monthlySalary = vf_monthlySalary * 1.15f;
            Console.WriteLine("{0}.yil maasiniz : {1} PNG Kina ",year.ToString(),Math.Ceiling(vf_monthlySalary));

        }


        Console.ReadKey();
        #endregion



    }
}