using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("how many employes do you want to put?");
            int number_employes = Convert.ToInt(Console.Readline());

            for (int i = 0, i < number_employes, i++)
            {
                Console.WriteLine("digite el año ");
                int year = Int32.Parse(Console.ReadLine());

                Console.WriteLine("digite el año ");
                int month = Int32.Parse(Console.ReadLine());

                Console.WriteLine("digite el año ");
                int day = Int32.Parse(Console.ReadLine());
                try
                {
                    var object_date = new Date(year, month, day);
                    Console.WriteLine(object_date.ToString());
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
