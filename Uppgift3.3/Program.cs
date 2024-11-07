using System;
using System.ComponentModel.Design;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("För hur många timmar vill du hyra ut bilen?");
            Console.WriteLine("MAX: 12 timmar!");
           
            int timmar = int.Parse(Console.ReadLine());

            if (timmar <= 12)
            {
                Console.WriteLine("Du får hrya bilen");
            }
            else if (timmar > 12)
            {
                Console.WriteLine("Du får inte hyra bilen");
            }
           

            int nr = 80;
            int nr2 = timmar * nr;

            Console.WriteLine("du vill hyra ut så här länge:" + " " + timmar + "h" + " " + "Det kommer att kosta dig:" + " " + nr2 + "kr");
            Console.WriteLine("Ha en trevlig resa nu.");

            Console.ReadLine();
        }
    }
}