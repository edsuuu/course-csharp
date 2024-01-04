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

            Console.WriteLine("Digite uma letra");
            char letra = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double alturaM = altura * 0.01;

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(letra);
            Console.WriteLine(alturaM.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}