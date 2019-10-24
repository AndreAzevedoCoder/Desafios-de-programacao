using System;

namespace AlgoritimoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a base: ");
            double basedoretangulo = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura: ");
            double altura = Double.Parse(Console.ReadLine());
            System.Console.WriteLine();
            double area = basedoretangulo*altura;
            double perimetro = 2*(basedoretangulo + altura);
            double diagonal = Math.Sqrt(Math.Pow(basedoretangulo,2) + Math.Pow(altura,2));
            System.Console.WriteLine("Area: "+area);
            System.Console.WriteLine("Perimetro: "+perimetro);
            System.Console.WriteLine("Diagonal: "+diagonal);
        }
    }
}
