using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite el año ");
            int year = Int32.Parse(Console.ReadLine()) ;

            Console.WriteLine("digite el año ");
            int month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("digite el año ");
            int day = Int32.Parse(Console.ReadLine());
            try
            {
                var object_date = new Date(year, month, day);
                Console.WriteLine(object_date.ToString());
            } catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
