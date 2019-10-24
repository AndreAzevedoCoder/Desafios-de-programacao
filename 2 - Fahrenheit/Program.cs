using System;

namespace Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os celsius: ");
            double celsius = Double.Parse(Console.ReadLine());
            double Fahrenheit = (celsius * 9/5) + 32;
            System.Console.WriteLine("São: "+Fahrenheit+" Em Fahrenheit");
        }
    }
}
