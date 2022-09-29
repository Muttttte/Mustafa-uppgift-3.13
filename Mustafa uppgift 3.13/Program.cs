using System;
namespace Uppgift_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du?");
            double ålder = double.Parse(Console.ReadLine());
            if (ålder >= 19)
{
                Console.WriteLine("du får delta i tävlingen");
            }
             else
            {
                Console.WriteLine("du får inte delta i tävlingen");
            }
        }
    }
}







