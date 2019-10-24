using System;

namespace _5__Troca
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero A: ");
            double A = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero B: ");
            double B = Double.Parse(Console.ReadLine());
            double intermediario = A;
            A = B;
            B = intermediario;
            System.Console.WriteLine("Agora o numero A é: "+ A);
            System.Console.WriteLine("Agora o numero B é: "+B);

        }
    }
}
