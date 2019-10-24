using System;

namespace Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga me o tempo: ");
            double Tempo = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade: ");
            double Velocidade = Double.Parse(Console.ReadLine());
            double Distancia = Tempo*Velocidade;
            System.Console.WriteLine("A velocidade é: "+Velocidade);
            System.Console.WriteLine("O tempo gasto é: "+Tempo);
            System.Console.WriteLine("A quantidade de litros vai ser: "+Distancia/12);
            
        }
    }
}
