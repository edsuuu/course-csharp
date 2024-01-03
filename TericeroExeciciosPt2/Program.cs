using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Idade : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.ReadLine("Digite uma letra");
            char letra = char.Parse(Console.ReadLine());

            Console.ReadLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(letra);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}